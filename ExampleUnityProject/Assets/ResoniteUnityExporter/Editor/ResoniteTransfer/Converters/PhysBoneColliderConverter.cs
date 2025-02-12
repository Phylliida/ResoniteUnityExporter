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
    public class PhysBoneColliderConverter
    {
        public static IEnumerator<object> ConvertPhysBoneCollider(VRCPhysBoneCollider physBoneCollider, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            DynamicBoneCollider_U2Res boneChainColliderData = new DynamicBoneCollider_U2Res()
            {
                targetSlot = objRefID,
                colliderType = physBoneCollider.shapeType.ToString(),
                radius = physBoneCollider.radius,
                height = physBoneCollider.height,
                localPosition = new Float3_U2Res()
                {
                    x = physBoneCollider.position.x,
                    y = physBoneCollider.position.y,
                    z = physBoneCollider.position.z,
                },
                localRotation = new Float4_U2Res()
                {
                    x = physBoneCollider.rotation.x,
                    y = physBoneCollider.rotation.y,
                    z = physBoneCollider.rotation.z,
                    w = physBoneCollider.rotation.w,
                }
            };

            yield return null;
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Creating dynamic bone collider";
            yield return null;
            var e = hierarchy.Call<RefID_U2Res[], DynamicBoneCollider_U2Res>("ImportDynamicBoneCollider", boneChainColliderData, output);
            while (e.MoveNext())
            {
                yield return null;
            }
        }
    }
}
