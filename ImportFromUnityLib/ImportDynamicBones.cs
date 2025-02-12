using Elements.Core;
using FrooxEngine;
using ResoniteBridgeLib;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportFromUnityLib
{
    public class ImportDynamicBones
    {

        public static float3[] ConvertCapsuleToSpheres(float3 localCapsulePos, float3 localCapsuleUp, float capsuleRadius, float capsuleHeight)
        {
            // every radius/2 put a sphere
            // it's not perfect but good enough
            int numSpheres = (int)Math.Max(1, Math.Ceiling(capsuleHeight / capsuleRadius));
            float3 startPos = localCapsulePos - localCapsuleUp * capsuleHeight / 2.0f;
            float3 endPos = localCapsulePos + localCapsuleUp * capsuleHeight / 2.0f;
            float3[] localSpherePositions = new float3[numSpheres];
            for (int i = 0; i < numSpheres; i++)
            {
                // go from 0 to 1
                float p = i / (float)Math.Max(numSpheres - 1, 1);
                float3 lerpedPos = startPos * p + endPos * (1 - p);
                localSpherePositions[i] = lerpedPos;
            }
            return localSpherePositions;
        }

        public static IEnumerator<Context> ImportDynamicBoneColliderHelper(byte[] dynamicBonesColliderBytes, OutputBytesHolder outputBytes)
        {
            yield return Context.ToBackground();
            // load data from bytes
            DynamicBoneCollider_U2Res boneColliderData = ResoniteBridgeUtils.DecodeObject<DynamicBoneCollider_U2Res>(dynamicBonesColliderBytes);
            yield return Context.ToWorld();
            Slot targetSlot = (Slot)ImportFromUnityUtils.LookupRefID(boneColliderData.targetSlot);
            // resonite only has spheres, no capsules :(
            // we will do our best to convert

            float3 localPos = new float3(
                boneColliderData.localPosition.x,
                boneColliderData.localPosition.y,
                boneColliderData.localPosition.z);

            float3[] localSpherePositions;

            if (boneColliderData.colliderType.ToLower() == "sphere")
            {
                // just use localPos and make one sphere
                localSpherePositions = new float3[]
                {
                    localPos
                };
            }
            else if (boneColliderData.colliderType.ToLower() == "capsule")
            {
                // need to convert capsule into lots of spheres cause resonite doesn't have sphere
                // tmp slot to figure out what direction is capsule up
                Slot tmpHolder = targetSlot.AddSlot("tmp");
                tmpHolder.LocalRotation = new floatQ(
                    boneColliderData.localRotation.x,
                    boneColliderData.localRotation.y,
                    boneColliderData.localRotation.z,
                    boneColliderData.localRotation.w);
                float3 localCapsuleUp = targetSlot.GlobalDirectionToLocal(
                    tmpHolder.LocalDirectionToGlobal(float3.Up)
                );
                tmpHolder.Destroy();
                localSpherePositions = ConvertCapsuleToSpheres(
                    localPos,
                    localCapsuleUp,
                    boneColliderData.radius,
                    boneColliderData.height
                );
            }
            // just make a sphere, TODO improve this
            else if (boneColliderData.colliderType.ToLower() == "plane")
            {
                localSpherePositions = new float3[]
                {
                    localPos
                };
            }
            else
            {
                ImportFromUnityLib.DebugLog("Error: unsupported collider type:" + boneColliderData.colliderType);

                localSpherePositions = new float3[]
                {
                    localPos
                };
            }

            List<RefID_U2Res> boneColliderRefIDs = new List<RefID_U2Res>();
            foreach (float3 localSpherePos in localSpherePositions)
            {
                // need to make child because they don't have offsets
                if (localSpherePos != float3.Zero)
                {
                    Slot colliderSlot = targetSlot.AddSlot(targetSlot.Name + " DynBoneCollider");
                    colliderSlot.LocalPosition = localSpherePos;
                    DynamicBoneSphereCollider collider = colliderSlot.AttachComponent<DynamicBoneSphereCollider>();
                    collider.Radius.Value = boneColliderData.radius;
                    boneColliderRefIDs.Add(new RefID_U2Res()
                    {
                        id = (ulong)collider.ReferenceID
                    });
                }
            }
            // return refid array since there could be multiple colliders
            outputBytes.outputBytes = ResoniteBridgeUtils.EncodeObject(boneColliderRefIDs.ToArray());
        }

        public static byte[] ImportDynamicBoneColliderFunc(byte[] dynamicBoneColliderData)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            ImportFromUnityUtils.RunOnWorldThread(ImportDynamicBoneColliderHelper(dynamicBoneColliderData, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }

        public static IEnumerator<Context> ImportDynamicBoneChainHelper(byte[] dynamicBoneChainBytes, OutputBytesHolder outputBytes)
        {
            yield return Context.ToBackground();
            // load data from bytes
            DynamicBoneChain_U2Res boneChainData = ResoniteBridgeUtils.DecodeObject<DynamicBoneChain_U2Res>(dynamicBoneChainBytes);
            yield return Context.ToWorld();
            Slot targetSlot = (Slot)ImportFromUnityUtils.LookupRefID(boneChainData.targetSlot);
            // resonite only has spheres, no capsules :(
            // we will do our best to convert
            DynamicBoneChain boneChain = targetSlot.AttachComponent<DynamicBoneChain>();
            boneChain.BaseBoneRadius.Value = boneChainData.baseBoneRadius;
            // add bones
            for (int i = 0; i < boneChainData.bones.Length; i++)
            {
                RefID_U2Res boneRefID = boneChainData.bones[i];
                float boneRadiusModifier = boneChainData.boneRadiusModifiers[i];
                Slot boneSlot = (Slot)ImportFromUnityUtils.LookupRefID(boneRefID);
                // need to access list like this because struct copies value
                boneChain.Bones.Add();
                boneChain.Bones[i].Assign(boneSlot);
                boneChain.Bones[i].RadiusModifier.Value = boneRadiusModifier;
            }

            // add colliders
            List<IDynamicBoneCollider> boneColliders = new List<IDynamicBoneCollider>();
            foreach (RefID_U2Res boneColliderRefID in boneChainData.colliders)
            {
                DynamicBoneSphereCollider boneColliderComponent = (DynamicBoneSphereCollider)ImportFromUnityUtils.LookupRefID(boneColliderRefID);
                if (boneColliderComponent != null)
                {
                    boneChain.StaticColliders.Add(boneColliderComponent);
                }
            }

            RefID_U2Res boneChainRefID = new RefID_U2Res()
            {
                id = (ulong)boneChain.ReferenceID
            };
            // return refid array since there could be multiple colliders
            outputBytes.outputBytes = ResoniteBridgeUtils.EncodeObject(boneChainRefID);
        }


        public static byte[] ImportDynamicBoneChainFunc(byte[] dynamicBoneColliderData)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            ImportFromUnityUtils.RunOnWorldThread(ImportDynamicBoneChainHelper(dynamicBoneColliderData, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }
    }
}
