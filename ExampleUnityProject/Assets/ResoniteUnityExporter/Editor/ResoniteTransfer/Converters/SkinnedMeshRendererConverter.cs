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

namespace Assets.ResoniteUnityExporter.Editor.ResoniteTransfer.Converters
{
    public class SkinnedMeshRendererConverter
    {

        public static RefID_U2Res ConvertSkinnedMeshRenderer(SkinnedMeshRenderer renderer, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy)
        {
            string[] boneNames = renderer.bones.Select(x => x.name).ToArray();
            RefID_U2Res meshRefId = hierarchy.SendOrGetMesh(renderer.sharedMesh, boneNames);


            RefID_U2Res[] materialRefIds = renderer.materials.Select(mat =>
                hierarchy.SendMaterial(mat)).ToArray();

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
            };

            byte[] data = ResoniteBridgeUtils.EncodeObject(meshRendererData);

            return hierarchy.Call<RefID_U2Res, SkinnedMeshRenderer_U2Res>("ImportSkinnedMeshRenderer", meshRendererData);
        }
    }
}
