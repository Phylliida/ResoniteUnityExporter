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
    public class MeshRendererConverter
    {
        public static IEnumerator<object> ConvertMeshRenderer(MeshRenderer renderer, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            Mesh sharedMesh = renderer.GetComponent<MeshFilter>().sharedMesh;
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending mesh " + sharedMesh.name;
            yield return null;
            RefID_U2Res meshRefId = hierarchy.SendOrGetMesh(sharedMesh, new string[] { });
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

            MeshRenderer_U2Res meshRendererData = new MeshRenderer_U2Res()
            {
                targetSlot = objRefID,
                staticMeshAsset = meshRefId,
                materials = materialRefIds,
            };

            byte[] data = ResoniteBridgeUtils.EncodeObject(meshRendererData);
            yield return null;
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Creating skinned mesh renderer";
            yield return null;
            var e = hierarchy.Call<RefID_U2Res, MeshRenderer_U2Res>("ImportMeshRenderer", meshRendererData, output);
            while (e.MoveNext())
            {
                yield return null;
            }
        }
    }
}
