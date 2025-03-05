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

namespace ResoniteUnityExporter.Converters
{
    public class SkinnedMeshRendererConverter
    {
        public static IEnumerator<object> ConvertSkinnedMeshRenderer(SkinnedMeshRenderer renderer, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            if (renderer.sharedMesh != null)
            {
                Transform[] rendererBones = renderer.bones;
                if (renderer.bones == null)
                {
                    renderer.bones = new Transform[0];
                }
                int boneIndex = 0;
                // this is important to ignore null bones
                string[] boneNames = new string[rendererBones.Length];
                RefID_U2Res[] boneRefIDs = new RefID_U2Res[rendererBones.Length];

                // handling for null bones, replace with bone at origin, they can fix it as needed
                for (int boneI = 0; boneI < rendererBones.Length; boneI++)
                {
                    Transform bone = rendererBones[boneI];
                    if (bone != null)
                    {
                        boneNames[boneI] = bone.name;
                        boneRefIDs[boneI] = hierarchy.LookupSlot(bone);
                    }
                    else
                    {
                        // make a fake bone to fill in for null bone so the indices are correct
                        boneNames[boneI] = SkinnedMeshRendererConstants.tempBonePrefix + boneI;
                        boneRefIDs[boneI] = new RefID_U2Res()
                        {
                            id = 0
                        };
                    }
                }

                ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending mesh " + renderer.sharedMesh.name;
                yield return null;
                OutputHolder<object> meshOutputHolder = new OutputHolder<object>();
                var meshEn = hierarchy.SendOrGetMesh(renderer.sharedMesh, boneNames, meshOutputHolder);
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
                    var matEn = hierarchy.SendOrGetMaterial(mat, materialOutputHolder);
                    while (matEn.MoveNext())
                    {
                        yield return null;
                    }
                    materialRefIds[i++] = (RefID_U2Res)materialOutputHolder.value;
                    yield return null;
                }

                foreach (Transform bone in rendererBones)
                {
                    if (bone != null)
                    {
                        if (!hierarchy.TryLookupSlot(bone.transform, out RefID_U2Res _))
                        {
                            throw new ArgumentOutOfRangeException("Object " + bone.transform.name + " in bone hierarchy is not one of the transforms we are exporting, do you need to select a higher up object? (or null, for all objects)");
                        }
                    }
                }

                float[] blendShapeWeights = new float[renderer.sharedMesh.blendShapeCount];
                for (int blendShapeI = 0; blendShapeI < renderer.sharedMesh.blendShapeCount; blendShapeI++)
                {
                    // need to scale blend shape
                    blendShapeWeights[blendShapeI] = renderer.GetBlendShapeWeight(blendShapeI) / 100.0f;
                }

                SkinnedMeshRenderer_U2Res meshRendererData = new SkinnedMeshRenderer_U2Res()
                {
                    targetSlot = objRefID,
                    staticMeshAsset = meshRefId,
                    bones = boneRefIDs,
                    materials = materialRefIds,
                    blendShapeWeights = blendShapeWeights,
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
}
