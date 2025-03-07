extern alias Froox;

using Froox::FrooxEngine;
using Froox::Elements.Core;
using MemoryMappedFileIPC;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportFromUnityLib
{
    public class ImportCollider
    {
        public static void ImportSphereColliderHelper(byte[] colliderBytes, OutputBytesHolder outputBytes)
        {
            SphereCollider_U2Res sphereColliderData = SerializationUtils.DecodeObject<SphereCollider_U2Res>(colliderBytes);
            Slot holdingSlot = (Slot)ImportFromUnityUtils.LookupRefID(sphereColliderData.target);
            RefID result = RefID.Null;
            if (holdingSlot != null)
            {
                SphereCollider sphereCollider = holdingSlot.AttachComponent<SphereCollider>();
                sphereCollider.Offset.Value = new float3(
                    sphereColliderData.center.x,
                    sphereColliderData.center.y,
                    sphereColliderData.center.z
                );
                sphereCollider.Radius.Value = sphereColliderData.radius;
                result = sphereCollider.ReferenceID;
            }

            // return refid of sphere collider
            RefID_U2Res outputRefID = new RefID_U2Res()
            {
                id = (ulong)result
            };

            outputBytes.outputBytes = SerializationUtils.EncodeObject(outputRefID);
        }
        public static async Task<byte[]> ImportSphereColliderFunc(byte[] colliderBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            await ImportFromUnityUtils.RunOnWorldThread(() => ImportSphereColliderHelper(colliderBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }

        public static void ImportBoxColliderHelper(byte[] colliderBytes, OutputBytesHolder outputBytes)
        {
            BoxCollider_U2Res boxColliderData = SerializationUtils.DecodeObject<BoxCollider_U2Res>(colliderBytes);
            Slot holdingSlot = (Slot)ImportFromUnityUtils.LookupRefID(boxColliderData.target);
            RefID result = RefID.Null;
            if (holdingSlot != null)
            {
                BoxCollider boxCollider = holdingSlot.AttachComponent<BoxCollider>();
                boxCollider.Offset.Value = new float3(
                    boxColliderData.center.x,
                    boxColliderData.center.y,
                    boxColliderData.center.z
                );
                boxCollider.Size.Value = new float3(
                    boxColliderData.size.x,
                    boxColliderData.size.y,
                    boxColliderData.size.z);

                result = boxCollider.ReferenceID;
            }

            // return refid of sphere collider
            RefID_U2Res outputRefID = new RefID_U2Res()
            {
                id = (ulong)result
            };

            outputBytes.outputBytes = SerializationUtils.EncodeObject(outputRefID);
        }
        public static async Task<byte[]> ImportBoxColliderFunc(byte[] colliderBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            await ImportFromUnityUtils.RunOnWorldThread(() => ImportBoxColliderHelper(colliderBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }

        public static void ImportCapsuleColliderHelper(byte[] colliderBytes, OutputBytesHolder outputBytes)
        {
            CapsuleCollider_U2Res capsuleColliderData = SerializationUtils.DecodeObject<CapsuleCollider_U2Res>(colliderBytes);
            Slot holdingSlot = (Slot)ImportFromUnityUtils.LookupRefID(capsuleColliderData.target);
            RefID result = RefID.Null;
            if (holdingSlot != null)
            {
                if (capsuleColliderData.direction != CapsuleColliderDirection_U2Res.Y)
                {
                    // need to create rotated child, by default it is along y axis
                    holdingSlot = holdingSlot.AddSlot(holdingSlot.Name + " Capsule Collider");
                    if (capsuleColliderData.direction == CapsuleColliderDirection_U2Res.X)
                    {

                    }
                    else if (capsuleColliderData.direction == CapsuleColliderDirection_U2Res.Z)
                    {

                    }
                }
                CapsuleCollider capsuleCollider = holdingSlot.AttachComponent<CapsuleCollider>();
                capsuleCollider.Offset.Value = new float3(
                    capsuleColliderData.center.x,
                    capsuleColliderData.center.y,
                    capsuleColliderData.center.z
                );
                capsuleCollider.Height.Value = capsuleColliderData.height;
                capsuleCollider.Radius.Value = capsuleColliderData.radius;
                result = capsuleCollider.ReferenceID;
            }

            // return refid of sphere collider
            RefID_U2Res outputRefID = new RefID_U2Res()
            {
                id = (ulong)result
            };

            outputBytes.outputBytes = SerializationUtils.EncodeObject(outputRefID);
        }
        public static async Task<byte[]> ImportCapsuleColliderFunc(byte[] colliderBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            await ImportFromUnityUtils.RunOnWorldThread(() => ImportCapsuleColliderHelper(colliderBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }



        public static void ImportMeshColliderHelper(byte[] colliderBytes, OutputBytesHolder outputBytes)
        {
            MeshCollider_U2Res meshColliderData = SerializationUtils.DecodeObject<MeshCollider_U2Res>(colliderBytes);
            Slot holdingSlot = (Slot)ImportFromUnityUtils.LookupRefID(meshColliderData.target);
            RefID result = RefID.Null;
            if (holdingSlot != null)
            {
                MeshCollider meshCollider = holdingSlot.AttachComponent<MeshCollider>();
                meshCollider.Mesh.Value = ((StaticMesh)ImportFromUnityUtils.LookupRefID(meshColliderData.staticMesh)).ReferenceID;
                meshCollider.Offset.Value = new float3(
                    meshColliderData.center.x,
                    meshColliderData.center.y,
                    meshColliderData.center.z
                );
                // sadly I don't know about convex options in mesh collider??
                result = meshCollider.ReferenceID;
            }

            // return refid of sphere collider
            RefID_U2Res outputRefID = new RefID_U2Res()
            {
                id = (ulong)result
            };

            outputBytes.outputBytes = SerializationUtils.EncodeObject(outputRefID);
        }
        public static async Task<byte[]> ImportMeshColliderFunc(byte[] colliderBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            await ImportFromUnityUtils.RunOnWorldThread(() => ImportMeshColliderHelper(colliderBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }

    }
}
