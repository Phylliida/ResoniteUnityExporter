

using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using UnityEngine;
using VRC.SDK3.Dynamics.Constraint.Components;

namespace ResoniteUnityExporter.Converters
{
    public class ColliderConverter
    {
        public static IEnumerator<object> ConvertSphereCollider(SphereCollider sphereCollider, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending sphere collider on " + obj.name;
            SphereCollider_U2Res sphereColliderData = new SphereCollider_U2Res()
            {
                target = objRefID,
                center = new Float3_U2Res()
                {
                    x = sphereCollider.center.x,
                    y = sphereCollider.center.y,
                    z = sphereCollider.center.z
                },
                radius = sphereCollider.radius
            };

            var en = hierarchy.Call<RefID_U2Res, SphereCollider_U2Res>("ImportSphereCollider", sphereColliderData, output);
            while (en.MoveNext())
            {
                yield return null;
            }
        }

        public static IEnumerator<object> ConvertBoxCollider(BoxCollider boxCollider, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending box collider on " + obj.name;
            BoxCollider_U2Res boxColliderData = new BoxCollider_U2Res()
            {
                target = objRefID,
                center = new Float3_U2Res()
                {
                    x = boxCollider.center.x,
                    y = boxCollider.center.y,
                    z = boxCollider.center.z
                },
                size = new Float3_U2Res()
                {
                    x = boxCollider.size.x,
                    y = boxCollider.size.y,
                    z = boxCollider.size.z
                },
            };

            var en = hierarchy.Call<RefID_U2Res, BoxCollider_U2Res>("ImportBoxCollider", boxColliderData, output);
            while (en.MoveNext())
            {
                yield return null;
            }
        }


        public static IEnumerator<object> ConvertCapsuleCollider(CapsuleCollider capsuleCollider, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending capsule collider on " + obj.name;
            CapsuleCollider_U2Res capsuleColliderData = new CapsuleCollider_U2Res()
            {
                target = objRefID,
                center = new Float3_U2Res()
                {
                    x = capsuleCollider.center.x,
                    y = capsuleCollider.center.y,
                    z = capsuleCollider.center.z
                },
                direction = (CapsuleColliderDirection_U2Res) capsuleCollider.direction,
                height = capsuleCollider.height,
                radius = capsuleCollider.radius
            };

            var en = hierarchy.Call<RefID_U2Res, CapsuleCollider_U2Res>("ImportCapsuleCollider", capsuleColliderData, output);
            while (en.MoveNext())
            {
                yield return null;
            }
        }


        public static IEnumerator<object> ConvertMeshCollider(MeshCollider meshCollider, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            if (meshCollider.sharedMesh != null)
            {
                OutputHolder<object> meshAssetRefIDHolder = new OutputHolder<object>();
                // this by default might ignore bones that would be used otherwise if they have skinned mesh
                // if this is processed before that skinned mesh so it gets empty bones
                // but having mesh collider for skinned mesh is cursed don't do that
                // so its probably ok
                var meshEn =  hierarchy.SendOrGetMesh(meshCollider.sharedMesh, new string[] { }, meshAssetRefIDHolder);
                while (meshEn.MoveNext())
                {
                    yield return null;
                }
                RefID_U2Res meshAsset = (RefID_U2Res)meshAssetRefIDHolder.value;
                ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending mesh collider on " + obj.name;
                MeshCollider_U2Res meshColliderData = new MeshCollider_U2Res()
                {
                    target = objRefID,
                    staticMesh = meshAsset,
                    center = new Float3_U2Res()
                    {
                        x = 0,
                        y = 0,
                        z = 0
                    },
                    convex = meshCollider.convex,
                };

                var en = hierarchy.Call<RefID_U2Res, MeshCollider_U2Res>("ImportMeshCollider", meshColliderData, output);
                while (en.MoveNext())
                {
                    yield return null;
                }
            }
        }


    }
}