using ResoniteBridgeLib;
using ResoniteUnityExporter;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
#if RUE_HAS_VRCSDK
using VRC.Dynamics;
using VRC.SDK3.Dynamics.PhysBone.Components;
using static VRC.Dynamics.PhysBoneManager;
#endif

namespace ResoniteUnityExporter.Converters
{
    public class PhysBoneConverter
    {

        public struct BoneInfo
        {
            public int boneChainIndex;
            public float weight;
            public Transform transform;
        }
        public static void GetBonesFromChildren(Transform curChild, List<BoneInfo> bones, float weight, int depth, VRCPhysBone.MultiChildType multiChildType)
        {

            bones.Add(new BoneInfo()
            {
                boneChainIndex = depth,
                weight = weight,
                transform = curChild,
            });
            for (int i = 0; i < curChild.childCount; i++)
            {
                float childWeight = 1.0f;
                if (multiChildType == VRCPhysBoneBase.MultiChildType.First)
                {
                    childWeight = 1.0f;
                }
                else if(multiChildType == VRCPhysBoneBase.MultiChildType.Average)
                {
                    childWeight = 1.0f / curChild.childCount;
                }
                GetBonesFromChildren(curChild.GetChild(i), bones, childWeight, depth + 1, multiChildType);
                // don't do other children in these cases
                if (multiChildType == VRCPhysBoneBase.MultiChildType.First)
                {
                    break;
                }
            }
        }

        public static BoneInfo[] GetBones(VRCPhysBone physBone, GameObject obj, out int depth)
        {
            if (physBone.bones == null || physBone.bones.Count == 0)
            {
                List<BoneInfo> bones = new List<BoneInfo>();
                // setup from children
                GetBonesFromChildren(obj.transform, bones, 1.0f, 0, physBone.multiChildType);
                depth = bones.Max(x => x.boneChainIndex)+1;
                return bones.ToArray();
            }
            else
            {
                var bones = physBone.bones.Select(bone => new BoneInfo()
                {
                    boneChainIndex = bone.boneChainIndex,
                    weight = 1.0f,
                    transform = bone.transform,
                }).ToArray();
                depth = bones.Max(x => x.boneChainIndex) + 1;
                return bones;
            }
        }

        public static IEnumerator<object> ConvertPhysBone(VRCPhysBone physBone, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            // this will auto add children if empty (sometimes VRCPhysBones do that)
            BoneInfo[] bones = GetBones(physBone, obj, out int depth);
            RefID_U2Res[] boneSlots = bones
                .Select(bone => hierarchy.LookupSlot(bone.transform))
                .ToArray();
            float divideBy = Math.Max(1, depth-1);
            float[] boneRadiusModifiers = bones
                .Select(bone => physBone.radiusCurve.Evaluate(
                    bone.boneChainIndex / divideBy))
            .ToArray();

            // fetch collider's ported values
            List<RefID_U2Res> colliders = new List<RefID_U2Res>();
            foreach (VRCPhysBoneColliderBase collider in physBone.colliders)
            {
                if (collider != null)
                {
                    OutputHolder<object> componentRefID = new OutputHolder<object>();
                    var en = hierarchy.transferManager.LookupComponent(collider, componentRefID);
                    while (en.MoveNext())
                    {
                        yield return null;
                    }
                    if (componentRefID.value != null)
                    {
                        // each could be multiple, add them all
                        colliders.AddRange((RefID_U2Res[])componentRefID.value);
                    }
                }
            }

            DynamicBoneChain_U2Res boneChainData = new DynamicBoneChain_U2Res()
            {
                targetSlot = objRefID,
                bones = boneSlots,
                grabbable = physBone.allowGrabbing == VRCPhysBoneBase.AdvancedBool.True,
                stiffness = physBone.stiffness,
                gravity = physBone.gravity,
                baseBoneRadius = physBone.radius * ResoniteTransferMesh.FIXED_SCALE_FACTOR,
                boneRadiusModifiers = boneRadiusModifiers,
                colliders = colliders.ToArray(),
            };

            yield return null;
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Creating dynamic bone chain";
            yield return null;
            var e = hierarchy.Call<RefID_U2Res, DynamicBoneChain_U2Res>("ImportDynamicBoneChain", boneChainData, output);
            while (e.MoveNext())
            {
                yield return null;
            }
        }
    }
}
