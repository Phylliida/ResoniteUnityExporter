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
using VRC.SDK3.Avatars.Components;

namespace ResoniteTransfer.Converters
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
                Debug.Log("converting avatar...");
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
                Debug.Log("converting avatar (fetched meshes)");

                RefID_U2Res[] rendererRefIds = refIds
                    .Where(x => x != null)
                    .Select(x => (RefID_U2Res)x).ToArray();

                bool hasCustomHeadPosition = false;
                VRCAvatarDescriptor[] descriptors = hierarchy.transferManager.GetComponents<VRCAvatarDescriptor>();
                Float3_U2Res customHeadPosition = new Float3_U2Res() { x = 0, y = 0, z = 0 };
                if (descriptors.Length > 0)
                {
                    VRCAvatarDescriptor descriptor = descriptors[0];
                    hasCustomHeadPosition = true;
                    customHeadPosition = new Float3_U2Res()
                    {
                        x = descriptor.ViewPosition.x * ResoniteTransferMesh.FIXED_SCALE_FACTOR,
                        y = descriptor.ViewPosition.y * ResoniteTransferMesh.FIXED_SCALE_FACTOR,
                        z = descriptor.ViewPosition.z * ResoniteTransferMesh.FIXED_SCALE_FACTOR
                    };
                }

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
                Debug.Log("converted avatar");
                yield return null;
            }
        }
    }
}
