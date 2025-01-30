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
                if (skinnedMeshRendererData.settings.setupAvatarCreator)
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
                        headsetRef.GlobalPosition = head.GlobalPosition;
                        headsetRef.GlobalRotation = head.GlobalRotation;
                        headsetRef.GlobalScale = aviCreatorScale;
                    }
                    // line up right hand (symmetry will take care of left hand)
                    Slot rightHand = bipedRig.TryGetBone(BodyNode.RightHand);
                    if (rightHand != null)
                    {
                        rightHandRef.GlobalPosition = rightHand.GlobalPosition;
                        float3 localScale = rightHandRef.Parent.GlobalScaleToLocal(aviCreatorScale);
                        rightHandRef.GlobalScale = aviCreatorScale;
                        SetAviCreatorHandRotation(bipedRig, aviCreator, localScale, true);
                    }
                    // todo: optional set up left hand if it's not symmetric
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

        static float3[] relativeFingerPositionsRight = new float3[] {
            new float3(-0.0944553f, -0.06033006f, 0.1202253f), // thumb
            new float3(-0.03632067f, -0.0295704f, 0.2140587f), // index
            new float3(-0.01105062f, -0.02654553f, 0.2155553f), // middle
            new float3(0.01396004f, -0.02654572f, 0.2100046f), // ring
            new float3(0.03692787f, -0.02956969f, 0.1954267f) // pinky
        };

        static float3[] relativeFingerPositionsLeft = new float3[]
        {
            new float3(0.09763367f, -0.06523453f, 0.1208142f), // thumb
            new float3(0.03690476f, -0.02722489f, 0.209686f), // index
            new float3(0.01103727f, -0.02597604f, 0.2162421f), // middle
            new float3(-0.0133688f, -0.0280386f, 0.2088304f), // ring
            new float3(-0.03593383f, -0.03025665f, 0.1963694f) // pinky
        };

        static BodyNode[][] leftFingerOrders = new BodyNode[][]
        {
            new BodyNode[]
            {
                BodyNode.LeftThumb_Metacarpal,
                BodyNode.LeftThumb_Proximal,
                BodyNode.LeftThumb_Distal,
                BodyNode.LeftThumb_Tip,
            },
            new BodyNode[]
            {
                BodyNode.LeftIndexFinger_Metacarpal,
                BodyNode.LeftIndexFinger_Proximal,
                BodyNode.LeftIndexFinger_Intermediate,
                BodyNode.LeftIndexFinger_Distal,
                BodyNode.LeftIndexFinger_Tip,
            },
            new BodyNode[]
            {
                BodyNode.LeftMiddleFinger_Metacarpal,
                BodyNode.LeftMiddleFinger_Proximal,
                BodyNode.LeftMiddleFinger_Intermediate,
                BodyNode.LeftMiddleFinger_Distal,
                BodyNode.LeftMiddleFinger_Tip,
            },
            new BodyNode[]
            {
                BodyNode.LeftRingFinger_Metacarpal,
                BodyNode.LeftRingFinger_Proximal,
                BodyNode.LeftRingFinger_Intermediate,
                BodyNode.LeftRingFinger_Distal,
                BodyNode.LeftRingFinger_Tip,
           },
            new BodyNode[]
            {
                BodyNode.LeftPinky_Metacarpal,
                BodyNode.LeftPinky_Proximal,
                BodyNode.LeftPinky_Intermediate,
                BodyNode.LeftPinky_Distal,
                BodyNode.LeftPinky_Tip,
            },
        };

        static BodyNode[][] rightFingerOrders = new BodyNode[][]
        {
            new BodyNode[]
            {
                BodyNode.RightThumb_Metacarpal,
                BodyNode.RightThumb_Proximal,
                BodyNode.RightThumb_Distal,
                BodyNode.RightThumb_Tip,
            },
            new BodyNode[]
            {
                BodyNode.RightIndexFinger_Metacarpal,
                BodyNode.RightIndexFinger_Proximal,
                BodyNode.RightIndexFinger_Intermediate,
                BodyNode.RightIndexFinger_Distal,
                BodyNode.RightIndexFinger_Tip,
            },
            new BodyNode[]
            {
                BodyNode.RightMiddleFinger_Metacarpal,
                BodyNode.RightMiddleFinger_Proximal,
                BodyNode.RightMiddleFinger_Intermediate,
                BodyNode.RightMiddleFinger_Distal,
                BodyNode.RightMiddleFinger_Tip,
            },
            new BodyNode[]
            {
                BodyNode.RightRingFinger_Metacarpal,
                BodyNode.RightRingFinger_Proximal,
                BodyNode.RightRingFinger_Intermediate,
                BodyNode.RightRingFinger_Distal,
                BodyNode.RightRingFinger_Tip,
           },
            new BodyNode[]
            {
                BodyNode.RightPinky_Metacarpal,
                BodyNode.RightPinky_Proximal,
                BodyNode.RightPinky_Intermediate,
                BodyNode.RightPinky_Distal,
                BodyNode.RightPinky_Tip,
            },
        };

        static Slot[] GetFingerTips(BipedRig bipedRig, bool rightSide, out float3[] tipRefs, bool includeThumb)
        {
            BodyNode[][] fingerOrders = rightSide ? rightFingerOrders : leftFingerOrders;
            float3[] handTipRefs = rightSide ? relativeFingerPositionsRight : relativeFingerPositionsLeft;
            List<Slot> fingerTips = new List<Slot>();
            List<float3> tipRefsList = new List<float3>();
            for(int i = 0; i < fingerOrders.Length; i++)
            {
                ImportFromUnityLib.DebugLog("Finger order:" + fingerOrders[i]);
                BodyNode[] fingerOrder = fingerOrders[i];
                // todo: lookup positions for left hand
                if (!includeThumb && fingerOrder[0].ToString().ToLower().Contains("thumb"))
                {
                    continue;
                }
                // get furthest part of finger available
                Slot fingerTip = null;
                foreach (BodyNode fingerPart in fingerOrder)
                {
                    ImportFromUnityLib.DebugLog("Finger part:" + fingerPart);
                    Slot curTip = bipedRig.TryGetBone(fingerPart);
                    if (curTip != null)
                    {
                        fingerTip = curTip;
                    }
                }
                if (fingerTip != null)
                {
                    ImportFromUnityLib.DebugLog("Got tip for finger:" + fingerTip + " with i " + i);
                    tipRefsList.Add(handTipRefs[i]);
                    ImportFromUnityLib.DebugLog("set tip for finger:" + fingerTip);
                    fingerTips.Add(fingerTip);
                }
            }
            tipRefs = tipRefsList.ToArray();
            return fingerTips.ToArray();
        }

        static void SetAviCreatorHandRotation(BipedRig bipedRig, AvatarCreator avatarCreator, float3 localScale, bool rightSide)
        {
            float3 globalFingerTipRef1;
            float3 globalFingerTipRef2;
            float3 localAviCreatorTipRef1;
            float3 localAviCreatorTipRef2;
            Slot[] nonThumbFingerTips = GetFingerTips(bipedRig, rightSide, out float3[] noThumbAviCreatorTipRefs, includeThumb: false);
            Slot avatarCreatorHand = avatarCreator.Slot.FindChild(rightSide ? "RightHand" : "LeftHand", matchSubstring: false, ignoreCase: false, maxDepth: 0);
            // only one finger, need to also use thumb for other ref
            if (nonThumbFingerTips.Length == 1)
            {
                Slot[] withThumbFingerTips = GetFingerTips(bipedRig, rightSide, out float3[] aviCreatorTipRefs, includeThumb: true);
                if (withThumbFingerTips.Length == 1)
                {
                    // idk what u expect of us when we only have one point
                    return;
                }
                else
                {
                    globalFingerTipRef1 = withThumbFingerTips[0].GlobalPosition;
                    globalFingerTipRef2 = withThumbFingerTips[1].GlobalPosition;
                    localAviCreatorTipRef1 = aviCreatorTipRefs[0];
                    localAviCreatorTipRef2 = aviCreatorTipRefs[1];
                }
            }
            else
            {
                // do first and last (non-thumb) finger, these are furthest apart which makes aligning nicer
                globalFingerTipRef1 = nonThumbFingerTips[0].GlobalPosition;
                globalFingerTipRef2 = nonThumbFingerTips[nonThumbFingerTips.Length-1].GlobalPosition;
                localAviCreatorTipRef1 = noThumbAviCreatorTipRefs[0];
                localAviCreatorTipRef2 = noThumbAviCreatorTipRefs[nonThumbFingerTips.Length-1];
            }
            // now we have two finger points (fingerTipRef1 and fingerTipRef2)
            // and two points on the avatar creator glove that we want to align to those points
            // so we want to find a rotation for avatarCreatorHand such that
            // Distance(
            //   avatarCreatorHand.LocalPointToGlobal(aviCreatorTipRef1),
            //    fingerTipRef1
            // ) +
            // Distance(
            //   avatarCreatorHand.LocalPointToGlobal(aviCreatorTipRef2),
            //    fingerTipRef2
            // )
            // is minimized

            // to do this, first find the rotation that aligns the midpoints:
            float3 globalFingerTipMidpoint = (globalFingerTipRef1 + globalFingerTipRef2) / 2.0f;
            float3 localFingerTipMidpoint = avatarCreatorHand.GlobalPointToLocal(globalFingerTipMidpoint);
            float3 localAviTipRefsMidpoint = (localAviCreatorTipRef1 + localAviCreatorTipRef2) / 2.0f;
            floatQ lineUpMidpointRotation = floatQ.FromToRotation(localAviTipRefsMidpoint.Normalized, localFingerTipMidpoint.Normalized);
            avatarCreatorHand.LocalRotation = avatarCreatorHand.LocalRotation * lineUpMidpointRotation;
            // double check we did it right
            float3 newDirToFingerTipMidpoint = avatarCreatorHand.GlobalPointToLocal(globalFingerTipMidpoint);
            ImportFromUnityLib.DebugLog("got new finger tip midpoint:" + newDirToFingerTipMidpoint.Normalized);
            ImportFromUnityLib.DebugLog("target direction is        :" + localAviTipRefsMidpoint.Normalized);

            // now the midpoint is lined up, we just need to rotate around vecToFingerTipMidpoint until the two points are best aligned
            // there's probably an analytic solution (feel free to PR such a solution) but iterative is good enough for a one-time thing
            int ITERS = 2000;
            
            float minScore = float.MaxValue;
            floatQ bestRotation = floatQ.Identity;
            floatQ baseLocalRotation = avatarCreatorHand.LocalRotation;
            float3 localPosition = avatarCreatorHand.LocalPosition;
            float3 globalPosition = avatarCreatorHand.Parent.LocalPointToGlobal(localPosition);
            float3 globalScale = avatarCreatorHand.Parent.LocalScaleToGlobal(localScale);
            for (int i = 0; i < ITERS; i++)
            {
                float angleRotation = 360f * (i / (float)(ITERS - 1));
                floatQ localRotation = baseLocalRotation * floatQ.AxisAngle(localAviTipRefsMidpoint, angleRotation);
                avatarCreatorHand.LocalRotation = localRotation;
                    float score = (
                       avatarCreatorHand.LocalPointToGlobal(localAviCreatorTipRef1) -
                       globalFingerTipRef1
                    ).Magnitude + (
                       avatarCreatorHand.LocalPointToGlobal(localAviCreatorTipRef2) -
                       globalFingerTipRef2
                    ).Magnitude;
                //ImportFromUnityLib.DebugLog("Got score:" + score + " with angle " + angleRotation);
                //ImportFromUnityLib.DebugLog("fingerTipRef1: " + globalFingerTipRef1);
                //ImportFromUnityLib.DebugLog("avi tip ref  : " + avatarCreatorHand.LocalPointToGlobal(localAviCreatorTipRef1));
                //ImportFromUnityLib.DebugLog("fingerTipRef1: " + globalFingerTipRef2);
                //ImportFromUnityLib.DebugLog("avi tip ref  : " + avatarCreatorHand.LocalPointToGlobal(localAviCreatorTipRef2));
                if (score < minScore)
                {
                    ImportFromUnityLib.DebugLog("Got best score:" + score + " with angle " + angleRotation);
                    minScore = score;
                    bestRotation = localRotation;
                }
            }
            avatarCreatorHand.LocalRotation = bestRotation;
        }

        static float3 ComputeAviCreatorScale(BipedRig rig, Slot handProxy)
        {
            Slot handSlot = rig.TryGetBone(BodyNode.LeftHand);
            if (handSlot != null)
            {
                float3 handSize = handSlot.ComputeBoundingBox(includeInactive: true, space: handSlot.Parent).Size;
                float maxSize = Math.Max(Math.Max(handSize.x, handSize.y), handSize.z);
                float3 handMaxSize = new float3(maxSize, maxSize, maxSize);
                float3 resultScale = handSlot.Parent.LocalScaleToGlobal(handMaxSize);
                ImportFromUnityLib.DebugLog("Got scale:" + resultScale);
                return resultScale / 0.23f; // this is the distance from center of wrist to end of avatar creator fingers
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
