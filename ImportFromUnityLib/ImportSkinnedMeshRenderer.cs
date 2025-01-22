using FrooxEngine.Store;
using FrooxEngine;
using ResoniteBridgeLib;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FrooxEngine.DataFeedItemMappingManager;
using Elements.Core;
using Assimp;
using static OfficialAssets.Graphics;
using System.IO;
using System.Xml.Linq;
using System.Reflection;
using FrooxEngine.FinalIK;

namespace ImportFromUnityLib
{
    public class ImportSkinnedMeshRenderer
    {

        public static IEnumerator<Context> ImportSkinnedMeshRendererHelper(byte[] skinnedMeshRendererBytes, OutputBytesHolder outputBytes)
        {
            yield return Context.ToBackground();
            // load data from bytes
            SkinnedMeshRenderer_U2Res skinnedMeshRendererData = ResoniteBridgeUtils.DecodeObject<SkinnedMeshRenderer_U2Res>(skinnedMeshRendererBytes);
            // load texture into localdb to get a url
            World focusedWorld = FrooxEngine.Engine.Current.WorldManager.FocusedWorld;
            yield return Context.ToWorld();
            Slot targetSlot = (Slot)ImportFromUnityUtils.LookupRefID(skinnedMeshRendererData.targetSlot);
            SkinnedMeshRenderer renderer = targetSlot.AttachComponent<SkinnedMeshRenderer>();
            renderer.Mesh.Value = skinnedMeshRendererData.staticMeshAsset.id;
            Slot assetsSlot = ((FrooxEngine.StaticMesh)ImportFromUnityUtils.LookupRefID(skinnedMeshRendererData.staticMeshAsset)).Slot;
            // assign materials
            renderer.Materials.Clear();
            foreach (RefID_U2Res material in skinnedMeshRendererData.materials)
            {
                IAssetProvider<FrooxEngine.Material> frooxMat = (IAssetProvider<FrooxEngine.Material>)ImportFromUnityUtils.LookupRefID(material);
                renderer.Materials.Add(frooxMat);
            }
            // assign bones and rig
            // todo: resonite forces these to be unique by name
            // but that constraint doesn't seem necessary as far as I can tell so I did everything
            // so that we can have multiple bones named same thing
            // will that cause issues? idk
            foreach (RefID_U2Res boneRefID in skinnedMeshRendererData.bones)
            {
                renderer.Bones.Add().Value = boneRefID.id;
            }
            renderer.BoundsComputeMethod.Value = SkinnedBounds.Static;
            List<RefID_U2Res> refIds = new List<RefID_U2Res>(skinnedMeshRendererData.bones);
            refIds.Add(new RefID_U2Res()
            {
                id = (ulong)renderer.Slot.ReferenceID
            });

            Slot sharedParent = FindSharedParent(refIds.ToArray());
            Rig rig = sharedParent.AttachComponent<Rig>();
            foreach (RefID_U2Res boneRefID in skinnedMeshRendererData.bones)
            {
                rig.Bones.Add().Value = boneRefID.id;
            }
            if (skinnedMeshRendererData.settings.setupIK)
            {
                SetupIK(rig, sharedParent, assetsSlot,
                    skinnedMeshRendererData.settings.forceTPose,
                    skinnedMeshRendererData.settings.generateColliders,
                    skinnedMeshRendererData.settings.generateSkeletonBoneVisuals);

                BipedRig bipedRig = rig.Slot.GetComponent<BipedRig>();
                if (skinnedMeshRendererData.settings.setupAvatar)
                {
                    Slot space = focusedWorld.LocalUserSpace;
                    if (space == null)
                    {
                        space = focusedWorld.RootSlot;
                    }
                    Slot slot = space.AddSlot("Avatar Creator");
                    AvatarCreator aviCreator = slot.AttachComponent<AvatarCreator>();
                    // LocalUser.Root is null in standalone
                    if (focusedWorld.LocalUser != null && focusedWorld.LocalUser.Root != null && focusedWorld.LocalUser.Root.Slot != null)
                    {
                        slot.AttachComponent<ReferenceField<User>>().Reference.Target = focusedWorld.LocalUser;
                        slot.PositionInFrontOfUser(null, null, 1.25f);
                        slot.FloorAtUserRoot(height: 0, user: focusedWorld.LocalUser);
                        slot.PointAtUserHead(float3.Forward, verticalAxisOnly: true);
                    }
                    Slot head = bipedRig.TryGetBone(BodyNode.Head);
                    Slot rightHandRef = ((SyncRef<Slot>)aviCreator.GetType().GetField("_rightReference", BindingFlags.Instance | BindingFlags.NonPublic)
                        .GetValue(aviCreator)).Target;
                    float3 aviCreatorScale = ComputeAviCreatorScale(bipedRig, rightHandRef);
                    // line up head
                    if (head != null)
                    {
                        Slot headsetRef = ((SyncRef<Slot>)aviCreator.GetType().GetField("_headsetReference", BindingFlags.Instance | BindingFlags.NonPublic)
                        .GetValue(aviCreator)).Target;
                        float3 localCenter = head.ComputeBoundingBox(includeInactive: false, space: head.Parent).Center;
                        headsetRef.GlobalPosition = head.Parent.LocalPointToGlobal(localCenter);
                        headsetRef.GlobalRotation = head.GlobalRotation;
                    }
                    // line up right hand (symmetry will take care of left hand)
                    Slot rightHand = bipedRig.TryGetBone(BodyNode.RightHand);
                    if (rightHand != null)
                    {
                        float3 localCenter = rightHand.ComputeBoundingBox(includeInactive: false, space: rightHand.Parent).Center;
                        rightHandRef.GlobalPosition = rightHand.Parent.LocalPointToGlobal(localCenter);
                        rightHandRef.GlobalRotation = rightHand.GlobalRotation;
                    }
                }

            }


            // ik
            // return refid of StaticMesh component
            RefID_U2Res result = new RefID_U2Res()
            {
                id = (ulong)renderer.ReferenceID
            };
            
            outputBytes.outputBytes = ResoniteBridgeUtils.EncodeObject(result);
        }

        static float3 ComputeAviCreatorScale(BipedRig rig, Slot handProxy)
        {
            Slot handSlot = rig.TryGetBone(BodyNode.LeftHand);
            if (handSlot != null)
            {
                float3 handSize = handSlot.ComputeExactBounds().GetAwaiter().GetResult().Size;
                float maxSize = Math.Max(Math.Max(handSize.x, handSize.y), handSize.z);
                float3 handMaxSize = new float3(maxSize, maxSize, maxSize);
                float3 resultScale = handSlot.Parent.LocalScaleToSpace(handMaxSize, handProxy.Parent);
                return resultScale / 0.3f; // this is the size of the spheres
            }
            else
            {
                return new float3(1,1,1);
            }
        }

        static Slot GetSharedParent(Slot a, Slot b)
        {
            if (a.ReferenceID == b.ReferenceID)
            {
                return a;
            }
            else
            {
                return b.GetNearestSharedParent(a);
            }

        }

        public static Slot FindSharedParent(RefID_U2Res[] refIds)
        {
            if (refIds.Length == 0)
            {
                return Engine.Current.WorldManager.FocusedWorld.RootSlot;
            }
            Slot[] slots = refIds.Select(r => (Slot)ImportFromUnityUtils.LookupRefID(r)).ToArray();
            Slot sharedParent = slots[0];
            foreach (Slot slot in slots)
            {
                sharedParent = GetSharedParent(slot, sharedParent);
            }
            return sharedParent;
        }

        public static void SetupIK(Rig rig, Slot targetSlot, Slot assetsSlot, bool forceTPose=true, bool generateColliders=true, bool generateSkeletonBoneVisuals=false)
        {
            // need to use hacky reflection stuff because they are private
            // make ModelImportData
            Type modelImportDataType = typeof(ModelImporter).GetTypeInfo()
                .DeclaredNestedTypes
                .Where(t => t.Name == "ModelImportData").First();
            Type[] constructorTypes = new Type[] {
                    typeof(string),
                    typeof(Assimp.Scene),
                    typeof(Slot),
                    typeof(Slot),
                    typeof(ModelImportSettings),
                    typeof(IProgressIndicator)
                };            
            // these are the only settings this import method uses
            ModelImportSettings modelImportSettings = new ModelImportSettings()
            {
                ForceTpose=forceTPose,
                SetupIK=true,
                GenerateColliders=generateColliders,
                GenerateSkeletonBoneVisuals=generateSkeletonBoneVisuals,
            };
            object[] constructorParameters = new object[]
            {
                    Path.GetTempPath(), // file (idk it doesn't really matter what we pass here as long as it's a valid file---
                    null, // scene
                    targetSlot, // target slot
                    assetsSlot, // assets slot
                    modelImportSettings, // import settings
                    null // progress indicator
            };

            object modelImportData = modelImportDataType.GetConstructor(constructorTypes)
                .Invoke(constructorParameters);

            ImportFromUnityLib.DebugLog("Got model import data " + modelImportData);

            // Call GenerateRigBones, which makes the IK
            var generateRigBonesMethod = typeof(ModelImporter)
                .GetMethods(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
                .Where(method => method.Name == "GenerateRigBones" &&
                    method.GetParameters().Length == 2)
                .First();
            ImportFromUnityLib.DebugLog("Got generate rig bones method " + generateRigBonesMethod);
            generateRigBonesMethod.Invoke(null, new object[]
            {
                rig,
                modelImportData
            });
        }

        public static byte[] ImportSkinnedMeshRendererFunc(byte[] skinnedMeshRendererData)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            ImportFromUnityUtils.RunOnWorldThread(ImportSkinnedMeshRendererHelper(skinnedMeshRendererData, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }
    }
}
