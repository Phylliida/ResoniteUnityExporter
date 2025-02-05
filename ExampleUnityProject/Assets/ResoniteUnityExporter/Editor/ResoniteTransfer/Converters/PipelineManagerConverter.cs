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
using VRC.Core;

namespace ResoniteTransfer.Converters
{
    public class PipelineManagerConverter
    {
        // we could use vrc avatar descriptor, however some old avatars don't have that,
        // whereas pipeline manager is very common
        public static IEnumerator<object> ConvertPipelineManager(PipelineManager pipelineManager, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
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

            Avatar_U2Res avatarData = new Avatar_U2Res()
            {
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
            };
            byte[] data = ResoniteBridgeUtils.EncodeObject(avatarData);
            yield return null;
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Creating avatar";
            yield return null;
            output.value = hierarchy.Call<RefID_U2Res, Avatar_U2Res>("ImportAvatar", avatarData);
            yield return null;
        }
    }
}
