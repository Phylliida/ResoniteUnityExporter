using ResoniteBridgeLib;
using ResoniteUnityExporter;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Mathematics;
using UnityEditor.Graphs;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace Assets.ResoniteUnityExporter.Editor.ResoniteTransfer.Converters
{
    public class SkinnedMeshRendererConverter
    {
        public static IEnumerator<object> ConvertSkinnedMeshRenderer(SkinnedMeshRenderer renderer, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy)
        {
            string[] boneNames = renderer.bones.Select(x => x.name).ToArray();
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending mesh " + renderer.sharedMesh.name;
            yield return null;
            RefID_U2Res meshRefId = hierarchy.SendOrGetMesh(renderer.sharedMesh, boneNames);
            yield return null;

            RefID_U2Res[] materialRefIds = new RefID_U2Res[renderer.sharedMaterials.Length];
            int i = 0;
            foreach (UnityEngine.Material mat in renderer.sharedMaterials)
            {
                ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending material " + mat.name;
                yield return null;
                materialRefIds[i++] = hierarchy.SendOrGetMaterial(mat);
                yield return null;
            }

            foreach (Transform bone in renderer.bones)
            {
                if (!hierarchy.TryLookupSlot(bone.transform, out RefID_U2Res _))
                {
                    throw new ArgumentOutOfRangeException("Object " + bone.transform.name + " in bone hierarchy is not one of the transforms we are exporting, do you need to select a higher up object? (or null, for all objects)");
                }
            }
            RefID_U2Res[] boneRefIDs = renderer.bones.Select(
                bone => hierarchy.LookupSlot(bone.transform)).ToArray();

            SkinnedMeshRenderer_U2Res meshRendererData = new SkinnedMeshRenderer_U2Res()
            {
                targetSlot = objRefID,
                staticMeshAsset = meshRefId,
                bones = boneRefIDs,
                materials = materialRefIds,
                settings = new SkinnedMeshRendererSettings_U2Res()
                {
                    forceTPose = false,
                    generateColliders = true,
                    generateSkeletonBoneVisuals = false,
                    setupIK = true,
                    setupAvatar = true
                }
            };

            byte[] data = ResoniteBridgeUtils.EncodeObject(meshRendererData);
            yield return null;
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Creating skinned mesh renderer";
            yield return null;
            yield return hierarchy.Call<RefID_U2Res, SkinnedMeshRenderer_U2Res>("ImportSkinnedMeshRenderer", meshRendererData);
        }
    }
}
