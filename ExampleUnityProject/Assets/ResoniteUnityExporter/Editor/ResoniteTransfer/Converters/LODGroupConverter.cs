
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ResoniteUnityExporter.Converters
{
    public class LODGroupConverter
    {
        public static IEnumerator<object> ConvertLODGroup(LODGroup lodGroup, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending LOD group on " + obj.name;
            LODGroup_U2Res lodGroupData = new LODGroup_U2Res()
            {
                target = objRefID,
                localReferencePoint = new Float3_U2Res()
                {
                    x = lodGroup.localReferencePoint.x,
                    y = lodGroup.localReferencePoint.y,
                    z = lodGroup.localReferencePoint.z
                },
                size = lodGroup.size,
                lodCount = lodGroup.lodCount,
                lastLODBillboard = lodGroup.lastLODBillboard,
                fadeMode = Enum.Parse<LODFadeMode_U2Res>(Enum.GetName(typeof(LODFadeMode), lodGroup.fadeMode)),
                animateCrossFading = lodGroup.animateCrossFading,
                enabled = lodGroup.enabled,
                crossFadeAnimationDuration = LODGroup.crossFadeAnimationDuration,
            };
            List<LOD_U2Res> lods = new List<LOD_U2Res>();
            foreach (LOD lod in lodGroup.GetLODs())
            {
                // get renderers of lod
                Renderer[] renderers = lod.renderers != null
                    ? lod.renderers // ignore null renderers
                        .Where(renderer => renderer != null).ToArray()
                    : new Renderer[0];
                List<RefID_U2Res> rendererRefIDs = new List<RefID_U2Res>();
                foreach (Renderer renderer in renderers)
                {
                    OutputHolder<object> rendererRefIDHolder = new OutputHolder<object>();
                    var rendererEn = hierarchy.transferManager.LookupComponent(renderer, rendererRefIDHolder);
                    while (rendererEn.MoveNext())
                    {
                        yield return null;
                    }
                    if (rendererRefIDHolder.value != null)
                    {
                        RefID_U2Res rendererRefID = (RefID_U2Res)rendererRefIDHolder.value;
                        if (rendererRefID.id != 0)
                        {
                            rendererRefIDs.Add(rendererRefID);
                        }
                    }
                }
                lods.Add(new LOD_U2Res()
                {
                    renderers = rendererRefIDs.ToArray(),
                    fadeTransitionWidth = lod.fadeTransitionWidth,
                    screenRelativeTransitionHeight = lod.screenRelativeTransitionHeight,
                });
            }
            lodGroupData.LODs = lods.ToArray();

            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending LOD group on " + obj.name;
            var en = hierarchy.Call<RefID_U2Res, LODGroup_U2Res>("ImportLODGroup", lodGroupData, output);
            while (en.MoveNext())
            {
                yield return null;
            }
        }
    }
}