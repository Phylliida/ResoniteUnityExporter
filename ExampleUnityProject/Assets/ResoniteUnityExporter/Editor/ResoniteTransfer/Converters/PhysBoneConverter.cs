using ResoniteBridgeLib;
using ResoniteUnityExporter;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VRC.Dynamics;
using VRC.SDK3.Dynamics.PhysBone.Components;
using static VRC.Dynamics.PhysBoneManager;

namespace ResoniteTransfer.Converters
{
    public class PhysBoneConverter
    {
        public static IEnumerator<object> ConvertPhysBone(VRCPhysBone physBone, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            RefID_U2Res[] boneSlots = physBone.bones
                .Select(bone => hierarchy.LookupSlot(bone.transform))
                .ToArray();
            float divideBy = Math.Max(1, physBone.bones.Count-1);
            float[] boneRadiuses = physBone.bones
                .Select(bone => physBone.CalcRadius(
                    bone.boneChainIndex / divideBy))
            .ToArray();

            Debug.Log("Got " + physBone.bones.Count + " bones on obj " + obj.name);
            foreach (RefID_U2Res boneRefID in boneSlots)
            {
                Debug.Log("Bone refid " + boneRefID.id);
            }
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
                boneRadiuses = boneRadiuses,
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
