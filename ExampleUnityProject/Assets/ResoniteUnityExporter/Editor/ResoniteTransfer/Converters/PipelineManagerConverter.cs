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
#if RUE_HAS_AVATAR_VRCSDK
using VRC.SDK3.Avatars.Components;
#endif
#if RUE_HAS_VRCSDK
using VRC.Core;
using VRC.Utility;
#endif

namespace ResoniteUnityExporter.Converters
{
    public class PipelineManagerConverter
    {
        // we could use vrc avatar descriptor, however some old avatars don't have that,
        // whereas pipeline manager is very common
        public static IEnumerator<object> ConvertPipelineManager(PipelineManager pipelineManager, GameObject obj, RefID_U2Res objRefId, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            // not sending avatar, bail
            if (settings.makeAvatar)
            {
                ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "";
                // fetch all SkinnedMeshRenderer and MeshRenderer ref ids
                OutputHolder<object[]> refIdsSkinned = new OutputHolder<object[]>();
                var e = hierarchy.transferManager.LookupAllComponentsOfType<SkinnedMeshRenderer>(refIdsSkinned);
                while (e.MoveNext())
                {
                    yield return null;
                }
                OutputHolder<object[]> refIdsUnskinned = new OutputHolder<object[]>();
                var eu = hierarchy.transferManager.LookupAllComponentsOfType<MeshRenderer>(refIdsUnskinned);
                while (eu.MoveNext())
                {
                    yield return null;
                }
                List<object> refIds = new List<object>(refIdsSkinned.value);
                refIds.AddRange(refIdsUnskinned.value);

                RefID_U2Res[] rendererRefIds = refIds
                    .Where(x => x != null)
                    .Select(x => (RefID_U2Res)x).ToArray();

                bool hasCustomHeadPosition = false;
                Avatar_U2Res avatarData;
                Float3_U2Res customHeadPosition = new Float3_U2Res()
                {
                    x = 0,
                    y = 0,
                    z = 0
                };

                if(ResoniteTransferUtils.TryGetHeadPosition(hierarchy.transferManager.rootTransform, out bool foundHead, out Vector3 headPosition, out GameObject headTransform))
                {
                    hasCustomHeadPosition = true;
                    customHeadPosition = new Float3_U2Res()
                    {
                        x = headPosition.x * ResoniteTransferMesh.FIXED_SCALE_FACTOR,
                        y = headPosition.y * ResoniteTransferMesh.FIXED_SCALE_FACTOR,
                        z = headPosition.z * ResoniteTransferMesh.FIXED_SCALE_FACTOR
                    };
                }
                avatarData = new Avatar_U2Res()
                {
                    mainParentSlot = hierarchy.mainParentSlot,
                    renderers = rendererRefIds,
                    floorOnOrigin = false,
                    assetsSlot = hierarchy.rootAssetsSlot,
                    forceTPose = false,
                    generateColliders = true,
                    generateSkeletonBoneVisuals = false,
                    setupIK = settings.setupIK,
                    setupAvatarCreator = settings.setupAvatarCreator,
                    rescale = true,
                    targetScale = 1.3f,
                    nearClip = settings.nearClip,
                    hasCustomHeadPosition = hasCustomHeadPosition,
                    customHeadPosition = customHeadPosition,
                };

                yield return null;
                ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Creating avatar";
                yield return null;
                var eout = hierarchy.Call<RefID_U2Res, Avatar_U2Res>("ImportAvatar", avatarData, output);
                while (eout.MoveNext())
                {
                    yield return null;
                }
                yield return null;              
            }
        }
    }
}
