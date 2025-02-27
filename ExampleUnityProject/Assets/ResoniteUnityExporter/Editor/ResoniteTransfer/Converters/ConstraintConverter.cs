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
using UnityEngine.Animations;
using UnityEngine.SocialPlatforms;
#if RUE_HAS_VRCSDK
using VRC.SDK3.Dynamics.Constraint.Components;
#endif

namespace ResoniteUnityExporter.Converters
{
    public class ConstraintConverter
    {
        public static IEnumerator<object> ConvertVRCPositionConstraint(VRCPositionConstraint vrcPositionConstraint, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending position constraint on " + obj.name;
            yield return null;
            RefID_U2Res targetTransform = objRefID;

            if (vrcPositionConstraint.TargetTransform != null)
            {
                hierarchy.TryLookupSlot(vrcPositionConstraint.TargetTransform, out targetTransform);
            }


            PositionConstraint_U2Res positionConstraintData = new PositionConstraint_U2Res()
            {
                isActive = vrcPositionConstraint.IsActive,
                weight = vrcPositionConstraint.GlobalWeight,
                lockConstraint = vrcPositionConstraint.Locked,
                positionAtRest = new Float3_U2Res()
                {
                    x = vrcPositionConstraint.PositionAtRest.x,
                    y = vrcPositionConstraint.PositionAtRest.y,
                    z = vrcPositionConstraint.PositionAtRest.z
                },
                positionOffset = new Float3_U2Res()
                {
                    x = vrcPositionConstraint.PositionOffset.x,
                    y = vrcPositionConstraint.PositionOffset.y,
                    z = vrcPositionConstraint.PositionOffset.z
                },
                affectsPositionAxes = new Bool3_U2Res()
                {
                    x = vrcPositionConstraint.AffectsPositionX,
                    y = vrcPositionConstraint.AffectsPositionY,
                    z = vrcPositionConstraint.AffectsPositionZ
                },
                target = targetTransform
            };


            yield return null;
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Creating position constraint";
            yield return null;
            var e = hierarchy.Call<RefID_U2Res, PositionConstraint_U2Res>("ImportPositionConstraint", positionConstraintData, output);
            while (e.MoveNext())
            {
                yield return null;
            }
        }
        public static IEnumerator<object> ConvertPositionConstraint(PositionConstraint positionConstraint, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending position constraint on " + obj.name;
            yield return null;

            RefID_U2Res targetTransform = objRefID;
            PositionConstraint_U2Res positionConstraintData = new PositionConstraint_U2Res()
            {
                isActive = positionConstraint.constraintActive,
                weight = positionConstraint.weight,
                lockConstraint = positionConstraint.locked,
                positionAtRest = new Float3_U2Res()
                {
                    x = positionConstraint.translationAtRest.x,
                    y = positionConstraint.translationAtRest.y,
                    z = positionConstraint.translationAtRest.z
                },
                positionOffset = new Float3_U2Res()
                {
                    x = positionConstraint.translationOffset.x,
                    y = positionConstraint.translationOffset.y,
                    z = positionConstraint.translationOffset.z
                },
                affectsPositionAxes = new Bool3_U2Res()
                {
                    x = (positionConstraint.translationAxis & Axis.X) != 0,
                    y = (positionConstraint.translationAxis & Axis.Y) != 0,
                    z = (positionConstraint.translationAxis & Axis.Z) != 0
                },
                target = targetTransform
            };


            yield return null;
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Creating position constraint";
            yield return null;
            var e = hierarchy.Call<RefID_U2Res, PositionConstraint_U2Res>("ImportPositionConstraint", positionConstraintData, output);
            while (e.MoveNext())
            {
                yield return null;
            }
        }













        public static IEnumerator<object> ConvertVRCRotationConstraint(VRCRotationConstraint vrcRotationConstraint, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending rotation constraint on " + obj.name;
            yield return null;


            RefID_U2Res targetTransform = objRefID;
            
            if (vrcRotationConstraint.TargetTransform != null)
            {
                hierarchy.TryLookupSlot(vrcRotationConstraint.TargetTransform, out targetTransform);
            }


            RotationConstraint_U2Res rotationConstraintData = new RotationConstraint_U2Res()
            {
                isActive = vrcRotationConstraint.IsActive,
                weight = vrcRotationConstraint.GlobalWeight,
                lockConstraint = vrcRotationConstraint.Locked,
                rotationAtRest = new Float3_U2Res()
                {
                    x = vrcRotationConstraint.RotationAtRest.x,
                    y = vrcRotationConstraint.RotationAtRest.y,
                    z = vrcRotationConstraint.RotationAtRest.z
                },
                rotationOffset = new Float3_U2Res()
                {
                    x = vrcRotationConstraint.RotationOffset.x,
                    y = vrcRotationConstraint.RotationOffset.y,
                    z = vrcRotationConstraint.RotationOffset.z
                },
                affectsRotationAxes = new Bool3_U2Res()
                {
                    x = vrcRotationConstraint.AffectsRotationX,
                    y = vrcRotationConstraint.AffectsRotationY,
                    z = vrcRotationConstraint.AffectsRotationZ
                },
                target = targetTransform
            };


            yield return null;
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Creating rotation constraint";
            yield return null;
            var e = hierarchy.Call<RefID_U2Res, RotationConstraint_U2Res>("ImportRotationConstraint", rotationConstraintData, output);
            while (e.MoveNext())
            {
                yield return null;
            }
        }
        public static IEnumerator<object> ConvertRotationConstraint(RotationConstraint rotationConstraint, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending rotation constraint on " + obj.name;
            yield return null;

            RefID_U2Res targetTransform = objRefID;

            RotationConstraint_U2Res rotationConstraintData = new RotationConstraint_U2Res()
            {
                isActive = rotationConstraint.constraintActive,
                weight = rotationConstraint.weight,
                lockConstraint = rotationConstraint.locked,
                rotationAtRest = new Float3_U2Res()
                {
                    x = rotationConstraint.rotationAtRest.x,
                    y = rotationConstraint.rotationAtRest.y,
                    z = rotationConstraint.rotationAtRest.z
                },
                rotationOffset = new Float3_U2Res()
                {
                    x = rotationConstraint.rotationOffset.x,
                    y = rotationConstraint.rotationOffset.y,
                    z = rotationConstraint.rotationOffset.z
                },
                affectsRotationAxes = new Bool3_U2Res()
                {
                    x = (rotationConstraint.rotationAxis & Axis.X) != 0,
                    y = (rotationConstraint.rotationAxis & Axis.Y) != 0,
                    z = (rotationConstraint.rotationAxis & Axis.Z) != 0
                },
                target = targetTransform
            };


            yield return null;
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Creating rotation constraint";
            yield return null;
            var e = hierarchy.Call<RefID_U2Res, RotationConstraint_U2Res>("ImportRotationConstraint", rotationConstraintData, output);
            while (e.MoveNext())
            {
                yield return null;
            }
        }










        public static IEnumerator<object> ConvertVRCScaleConstraint(VRCScaleConstraint vrcScaleConstraint, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending scale constraint on " + obj.name;
            yield return null;


            RefID_U2Res targetTransform = objRefID;
            
            if (vrcScaleConstraint.TargetTransform != null)
            {
                hierarchy.TryLookupSlot(vrcScaleConstraint.TargetTransform, out targetTransform);
            }


            ScaleConstraint_U2Res scaleConstraintData = new ScaleConstraint_U2Res()
            {
                isActive = vrcScaleConstraint.IsActive,
                weight = vrcScaleConstraint.GlobalWeight,
                lockConstraint = vrcScaleConstraint.Locked,
                scaleAtRest = new Float3_U2Res()
                {
                    x = vrcScaleConstraint.ScaleAtRest.x,
                    y = vrcScaleConstraint.ScaleAtRest.y,
                    z = vrcScaleConstraint.ScaleAtRest.z
                },
                scaleOffset = new Float3_U2Res()
                {
                    x = vrcScaleConstraint.ScaleOffset.x,
                    y = vrcScaleConstraint.ScaleOffset.y,
                    z = vrcScaleConstraint.ScaleOffset.z
                },
                affectsScaleAxes = new Bool3_U2Res()
                {
                    x = vrcScaleConstraint.AffectsScaleX,
                    y = vrcScaleConstraint.AffectsScaleY,
                    z = vrcScaleConstraint.AffectsScaleZ
                },
                target = targetTransform
            };


            yield return null;
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Creating scale constraint";
            yield return null;
            var e = hierarchy.Call<RefID_U2Res, ScaleConstraint_U2Res>("ImportScaleConstraint", scaleConstraintData, output);
            while (e.MoveNext())
            {
                yield return null;
            }
        }
        public static IEnumerator<object> ConvertScaleConstraint(ScaleConstraint scaleConstraint, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending scale constraint on " + obj.name;
            yield return null;

            RefID_U2Res targetTransform = objRefID;

            ScaleConstraint_U2Res scaleConstraintData = new ScaleConstraint_U2Res()
            {
                isActive = scaleConstraint.constraintActive,
                weight = scaleConstraint.weight,
                lockConstraint = scaleConstraint.locked,
                scaleAtRest = new Float3_U2Res()
                {
                    x = scaleConstraint.scaleAtRest.x,
                    y = scaleConstraint.scaleAtRest.y,
                    z = scaleConstraint.scaleAtRest.z
                },
                scaleOffset = new Float3_U2Res()
                {
                    x = scaleConstraint.scaleOffset.x,
                    y = scaleConstraint.scaleOffset.y,
                    z = scaleConstraint.scaleOffset.z
                },
                affectsScaleAxes = new Bool3_U2Res()
                {
                    x = (scaleConstraint.scalingAxis & Axis.X) != 0,
                    y = (scaleConstraint.scalingAxis & Axis.Y) != 0,
                    z = (scaleConstraint.scalingAxis & Axis.Z) != 0
                },
                target = targetTransform
            };


            yield return null;
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Creating scale constraint";
            yield return null;
            var e = hierarchy.Call<RefID_U2Res, ScaleConstraint_U2Res>("ImportScaleConstraint", scaleConstraintData, output);
            while (e.MoveNext())
            {
                yield return null;
            }
        }










        public static IEnumerator<object> ConvertVRCAimConstraint(VRCAimConstraint vrcAimConstraint, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending aim constraint on " + obj.name;
            yield return null;


            RefID_U2Res targetTransform = objRefID;
            
            if (vrcAimConstraint.TargetTransform != null)
            {
                hierarchy.TryLookupSlot(vrcAimConstraint.TargetTransform, out targetTransform);
            }

            WorldUpType_U2Res worldUpType = WorldUpType_U2Res.SceneUp;
            if (Enum.TryParse(typeof(WorldUpType_U2Res), vrcAimConstraint.WorldUp.ToString(), true, out object worldUpEnum)) {
                worldUpType = (WorldUpType_U2Res)worldUpEnum;
            }

            AimConstraint_U2Res aimConstraintData = new AimConstraint_U2Res()
            {
                isActive = vrcAimConstraint.IsActive,
                weight = vrcAimConstraint.GlobalWeight,
                aimVector = new Float3_U2Res()
                {
                    x = vrcAimConstraint.AimAxis.x,
                    y = vrcAimConstraint.AimAxis.y,
                    z = vrcAimConstraint.AimAxis.z,
                },
                upVector = new Float3_U2Res()
                {
                    x = vrcAimConstraint.UpAxis.x,
                    y = vrcAimConstraint.UpAxis.y,
                    z = vrcAimConstraint.UpAxis.z,
                },
                worldUpType = worldUpType,
                lockConstraint = vrcAimConstraint.Locked,
                rotationAtRest = new Float3_U2Res()
                {
                    x = vrcAimConstraint.RotationAtRest.x,
                    y = vrcAimConstraint.RotationAtRest.y,
                    z = vrcAimConstraint.RotationAtRest.z
                },
                rotationOffset = new Float3_U2Res()
                {
                    x = vrcAimConstraint.RotationOffset.x,
                    y = vrcAimConstraint.RotationOffset.y,
                    z = vrcAimConstraint.RotationOffset.z
                },
                affectsRotationAxes = new Bool3_U2Res()
                {
                    x = vrcAimConstraint.AffectsRotationX,
                    y = vrcAimConstraint.AffectsRotationY,
                    z = vrcAimConstraint.AffectsRotationZ
                },
                target = targetTransform
            };

            yield return null;
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Creating aim constraint";
            yield return null;
            var e = hierarchy.Call<RefID_U2Res, AimConstraint_U2Res>("ImportAimConstraint", aimConstraintData, output);
            while (e.MoveNext())
            {
                yield return null;
            }
        }
        public static IEnumerator<object> ConvertAimConstraint(AimConstraint aimConstraint, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending aim constraint on " + obj.name;
            yield return null;


            RefID_U2Res targetTransform = objRefID;
            
            
            WorldUpType_U2Res worldUpType = WorldUpType_U2Res.SceneUp;
            if (Enum.TryParse(typeof(WorldUpType_U2Res), aimConstraint.worldUpType.ToString(), true, out object worldUpEnum))
            {
                worldUpType = (WorldUpType_U2Res)worldUpEnum;
            }

            AimConstraint_U2Res aimConstraintData = new AimConstraint_U2Res()
            {
                isActive = aimConstraint.constraintActive,
                weight = aimConstraint.weight,
                aimVector = new Float3_U2Res()
                {
                    x = aimConstraint.aimVector.x,
                    y = aimConstraint.aimVector.y,
                    z = aimConstraint.aimVector.z,
                },
                upVector = new Float3_U2Res()
                {
                    x = aimConstraint.upVector.x,
                    y = aimConstraint.upVector.y,
                    z = aimConstraint.upVector.z,
                },
                worldUpType = worldUpType,
                lockConstraint = aimConstraint.locked,
                rotationAtRest = new Float3_U2Res()
                {
                    x = aimConstraint.rotationAtRest.x,
                    y = aimConstraint.rotationAtRest.y,
                    z = aimConstraint.rotationAtRest.z
                },
                rotationOffset = new Float3_U2Res()
                {
                    x = aimConstraint.rotationOffset.x,
                    y = aimConstraint.rotationOffset.y,
                    z = aimConstraint.rotationOffset.z
                },
                affectsRotationAxes = new Bool3_U2Res()
                {
                    x = (aimConstraint.rotationAxis & Axis.X) != 0,
                    y = (aimConstraint.rotationAxis & Axis.Y) != 0,
                    z = (aimConstraint.rotationAxis & Axis.Z) != 0
                },
                target = targetTransform
            };


            yield return null;
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Creating aim constraint";
            yield return null;
            var e = hierarchy.Call<RefID_U2Res, AimConstraint_U2Res>("ImportAimConstraint", aimConstraintData, output);
            while (e.MoveNext())
            {
                yield return null;
            }
        }

























        public static IEnumerator<object> ConvertVRCParentConstraint(VRCParentConstraint vrcParentConstraint, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending parent constraint on " + obj.name;
            yield return null;


            RefID_U2Res targetTransform = objRefID;
            
            if (vrcParentConstraint.TargetTransform != null)
            {
                hierarchy.TryLookupSlot(vrcParentConstraint.TargetTransform, out targetTransform);
            }

            ParentConstraint_U2Res parentConstraintData = new ParentConstraint_U2Res()
            {
                isActive = vrcParentConstraint.IsActive,
                weight = vrcParentConstraint.GlobalWeight,                
                lockConstraint = vrcParentConstraint.Locked,
                positionAtRest = new Float3_U2Res()
                {
                    x = vrcParentConstraint.PositionAtRest.x,
                    y = vrcParentConstraint.PositionAtRest.y,
                    z = vrcParentConstraint.PositionAtRest.z
                },
                rotationAtRest = new Float3_U2Res()
                {
                    x = vrcParentConstraint.RotationAtRest.x,
                    y = vrcParentConstraint.RotationAtRest.y,
                    z = vrcParentConstraint.RotationAtRest.z
                },
                affectsPositionAxes = new Bool3_U2Res()
                {
                    x = vrcParentConstraint.AffectsPositionX,
                    y = vrcParentConstraint.AffectsPositionY,
                    z = vrcParentConstraint.AffectsPositionZ
                },
                affectsRotationAxes = new Bool3_U2Res()
                {
                    x = vrcParentConstraint.AffectsRotationX,
                    y = vrcParentConstraint.AffectsRotationY,
                    z = vrcParentConstraint.AffectsRotationZ
                },
                target = targetTransform
            };

            yield return null;
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Creating parent constraint";
            yield return null;
            var e = hierarchy.Call<RefID_U2Res, ParentConstraint_U2Res>("ImportParentConstraint", parentConstraintData, output);
            while (e.MoveNext())
            {
                yield return null;
            }
        }
        public static IEnumerator<object> ConvertParentConstraint(ParentConstraint parentConstraint, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending parent constraint on " + obj.name;
            yield return null;


            RefID_U2Res targetTransform = objRefID;


            ParentConstraint_U2Res parentConstraintData = new ParentConstraint_U2Res()
            {
                isActive = parentConstraint.constraintActive,
                weight = parentConstraint.weight,
                lockConstraint = parentConstraint.locked,
                positionAtRest = new Float3_U2Res()
                {
                    x = parentConstraint.translationAtRest.x,
                    y = parentConstraint.translationAtRest.y,
                    z = parentConstraint.translationAtRest.z
                },
                rotationAtRest = new Float3_U2Res()
                {
                    x = parentConstraint.rotationAtRest.x,
                    y = parentConstraint.rotationAtRest.y,
                    z = parentConstraint.rotationAtRest.z
                },
                affectsPositionAxes = new Bool3_U2Res()
                {
                    x = (parentConstraint.translationAxis & Axis.X) != 0,
                    y = (parentConstraint.translationAxis & Axis.Y) != 0,
                    z = (parentConstraint.translationAxis & Axis.Z) != 0
                },
                affectsRotationAxes = new Bool3_U2Res()
                {
                    x = (parentConstraint.rotationAxis & Axis.X) != 0,
                    y = (parentConstraint.rotationAxis & Axis.Y) != 0,
                    z = (parentConstraint.rotationAxis & Axis.Z) != 0
                },
                target = targetTransform
            };

            yield return null;
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Creating parent constraint";
            yield return null;
            var e = hierarchy.Call<RefID_U2Res, ParentConstraint_U2Res>("ImportParentConstraint", parentConstraintData, output);
            while (e.MoveNext())
            {
                yield return null;
            }
        }















        public static IEnumerator<object> ConvertVRCLookAtConstraint(VRCLookAtConstraint vrcLookAtConstraint, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending look at constraint on " + obj.name;
            yield return null;

            RefID_U2Res targetTransform = objRefID;
            if (vrcLookAtConstraint.TargetTransform != null)
            {
                hierarchy.TryLookupSlot(vrcLookAtConstraint.TargetTransform, out targetTransform);
            }

            RefID_U2Res worldUpTransform = new RefID_U2Res()
            {
                id = 0
            };
            if (vrcLookAtConstraint.WorldUpTransform != null)
            {
                hierarchy.TryLookupSlot(vrcLookAtConstraint.WorldUpTransform, out worldUpTransform);
            }



            LookAtConstraint_U2Res lookAtConstraintData = new LookAtConstraint_U2Res()
            {
                isActive = vrcLookAtConstraint.IsActive,
                weight = vrcLookAtConstraint.GlobalWeight,
                useUpObject = vrcLookAtConstraint.UseUpTransform,
                worldUpObject = worldUpTransform,
                roll = vrcLookAtConstraint.Roll,
                lockConstraint = vrcLookAtConstraint.Locked,
                rotationAtRest = new Float3_U2Res()
                {
                    x = vrcLookAtConstraint.RotationAtRest.x,
                    y = vrcLookAtConstraint.RotationAtRest.y,
                    z = vrcLookAtConstraint.RotationAtRest.z
                },
                rotationOffset = new Float3_U2Res()
                {
                    x = vrcLookAtConstraint.RotationOffset.x,
                    y = vrcLookAtConstraint.RotationOffset.y,
                    z = vrcLookAtConstraint.RotationOffset.z
                },
                target = targetTransform
            };

            yield return null;
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Creating look at constraint";
            yield return null;
            var e = hierarchy.Call<RefID_U2Res, LookAtConstraint_U2Res>("ImportLookAtConstraint", lookAtConstraintData, output);
            while (e.MoveNext())
            {
                yield return null;
            }
        }
        public static IEnumerator<object> ConvertLookAtConstraint(LookAtConstraint lookAtConstraint, GameObject obj, RefID_U2Res objRefID, HierarchyLookup hierarchy, ResoniteTransferSettings settings, OutputHolder<object> output)
        {
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Sending look at constraint on " + obj.name;
            yield return null;

            RefID_U2Res targetTransform = objRefID;

            RefID_U2Res worldUpTransform = new RefID_U2Res()
            {
                id = 0
            };
            if (lookAtConstraint.worldUpObject != null)
            {
                hierarchy.TryLookupSlot(lookAtConstraint.worldUpObject, out worldUpTransform);
            }


            LookAtConstraint_U2Res lookAtConstraintData = new LookAtConstraint_U2Res()
            {
                isActive = lookAtConstraint.constraintActive,
                weight = lookAtConstraint.weight,
                useUpObject = lookAtConstraint.useUpObject,
                worldUpObject = worldUpTransform,
                roll = lookAtConstraint.roll,
                lockConstraint = lookAtConstraint.locked,
                rotationAtRest = new Float3_U2Res()
                {
                    x = lookAtConstraint.rotationAtRest.x,
                    y = lookAtConstraint.rotationAtRest.y,
                    z = lookAtConstraint.rotationAtRest.z
                },
                rotationOffset = new Float3_U2Res()
                {
                    x = lookAtConstraint.rotationOffset.x,
                    y = lookAtConstraint.rotationOffset.y,
                    z = lookAtConstraint.rotationOffset.z,
                },
                target = targetTransform
            };

            yield return null;
            ResoniteUnityExporterEditorWindow.DebugProgressStringDetail = "Creating look at constraint";
            yield return null;
            var e = hierarchy.Call<RefID_U2Res, LookAtConstraint_U2Res>("ImportLookAtConstraint", lookAtConstraintData, output);
            while (e.MoveNext())
            {
                yield return null;
            }
        }








    }
}
