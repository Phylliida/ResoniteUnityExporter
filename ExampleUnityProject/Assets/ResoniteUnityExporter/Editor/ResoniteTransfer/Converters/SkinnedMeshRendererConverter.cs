using ResoniteBridgeLib;
using ResoniteUnityExporter;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor.Graphs;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace ResoniteUnityExporter.Converters
{
    public class SkinnedMeshRendererConverter
    {
        public static IEnumerator<object> ConvertSkinnedMeshRenderer(SkinnedMeshRenderer renderer, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            // this is important to ignore null bones
            Transform[] rendererBones = renderer.bones == null
                ? new Transform[] { }
                : renderer.bones
                    .Where(x => x != null && x.name != null).ToArray();

            string[] boneNames = rendererBones
                    .Select(x => x.name)
                    .ToArray();
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

            foreach (Transform bone in rendererBones)
            {
                if (!hierarchy.TryLookupSlot(bone.transform, out RefID_U2Res _))
                {
                    throw new ArgumentOutOfRangeException("Object " + bone.transform.name + " in bone hierarchy is not one of the transforms we are exporting, do you need to select a higher up object? (or null, for all objects)");
                }
            }
            RefID_U2Res[] boneRefIDs = rendererBones
                .Select(bone => hierarchy.LookupSlot(bone.transform))
                .Where(x => x.id != 0) // ignore null bones
                .ToArray();

            SkinnedMeshRenderer_U2Res meshRendererData = new SkinnedMeshRenderer_U2Res()
            {
                targetSlot = objRefID,
                staticMeshAsset = meshRefId,
                bones = boneRefIDs,
                materials = materialRefIds,
            };

            yield return null;
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Creating skinned mesh renderer";
            yield return null;
            var e = hierarchy.Call<RefID_U2Res, SkinnedMeshRenderer_U2Res>("ImportSkinnedMeshRenderer", meshRendererData, output);
            while (e.MoveNext())
            {
                yield return null;
            }
            yield return null; 
        }
    }
}
