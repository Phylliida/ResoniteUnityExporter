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
    public class MeshRendererConverter
    {
        public static IEnumerator<object> ConvertMeshRenderer(MeshRenderer renderer, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            if (renderer.GetComponent<MeshFilter>() != null && renderer.GetComponent<MeshFilter>().sharedMesh != null)
            {
                Mesh sharedMesh = renderer.GetComponent<MeshFilter>().sharedMesh;
                ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending mesh " + sharedMesh.name;
                yield return null;
                OutputHolder<object> meshOutputHolder = new OutputHolder<object>();
                var meshEn = hierarchy.SendOrGetMesh(sharedMesh, new string[] { }, meshOutputHolder);
                while (meshEn.MoveNext())
                {
                    yield return null;
                }
                RefID_U2Res meshRefId = (RefID_U2Res)meshOutputHolder.value;

                RefID_U2Res[] materialRefIds = new RefID_U2Res[renderer.sharedMaterials.Length];
                int i = 0;
                foreach (UnityEngine.Material mat in renderer.sharedMaterials)
                {
                    ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending material " + mat.name;
                    yield return null;
                    OutputHolder<object> materialOutputHolder = new OutputHolder<object>();
                    var materialEn = hierarchy.SendOrGetMaterial(mat, materialOutputHolder);
                    while (materialEn.MoveNext())
                    {
                        yield return null;
                    }
                    materialRefIds[i++] = (RefID_U2Res)materialOutputHolder.value;
                    yield return null;
                }

                MeshRenderer_U2Res meshRendererData = new MeshRenderer_U2Res()
                {
                    targetSlot = objRefID,
                    staticMeshAsset = meshRefId,
                    materials = materialRefIds,
                };

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
}
