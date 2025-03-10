using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ResoniteUnityExporterShared
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Bool3_U2Res
    {
        public bool x;
        public bool y;
        public bool z;
    }

    public enum WorldUpType_U2Res
    {
        SceneUp,
        ObjectUp,
        ObjectRotationUp,
        Vector,
        None,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ConstraintSource_U2Res
    {
        public RefID_U2Res transform;
        public float weight;
        public Float3_U2Res parentPositionOffset;
        public Float3_U2Res parentRotationOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PositionConstraint_U2Res
    {
        public RefID_U2Res target;
        public ConstraintSource_U2Res[] sources;
        public bool isActive;
        public float weight;
        public bool lockConstraint;
        public Float3_U2Res positionAtRest;
        public Float3_U2Res positionOffset;
        public Bool3_U2Res affectsPositionAxes;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct RotationConstraint_U2Res
    {
        public RefID_U2Res target;
        public ConstraintSource_U2Res[] sources;
        public bool isActive;
        public float weight;
        public bool lockConstraint;
        public Float3_U2Res rotationAtRest;
        public Float3_U2Res rotationOffset;
        public Bool3_U2Res affectsRotationAxes;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct ScaleConstraint_U2Res
    {
        public RefID_U2Res target;
        public ConstraintSource_U2Res[] sources;
        public bool isActive;
        public float weight;
        public bool lockConstraint;
        public Float3_U2Res scaleAtRest;
        public Float3_U2Res scaleOffset;
        public Bool3_U2Res affectsScaleAxes;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct AimConstraint_U2Res
    {
        public RefID_U2Res target;
        public ConstraintSource_U2Res[] sources;
        public bool isActive;
        public float weight;
        public Float3_U2Res aimVector;
        public Float3_U2Res upVector;
        public WorldUpType_U2Res worldUpType;
        public bool lockConstraint;
        public Float3_U2Res rotationAtRest;
        public Float3_U2Res rotationOffset;
        public Bool3_U2Res affectsRotationAxes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ParentConstraint_U2Res
    {
        public RefID_U2Res target;
        public ConstraintSource_U2Res[] sources;
        public bool isActive;
        public float weight;
        public bool lockConstraint;
        public Float3_U2Res positionAtRest;
        public Float3_U2Res rotationAtRest;
        public Bool3_U2Res affectsPositionAxes;
        public Bool3_U2Res affectsRotationAxes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LookAtConstraint_U2Res
    {
        public RefID_U2Res target;
        public ConstraintSource_U2Res[] sources;
        public bool isActive;
        public float weight;
        public bool useUpObject;
        public RefID_U2Res worldUpObject;
        public float roll;
        public bool lockConstraint;
        public Float3_U2Res rotationAtRest;
        public Float3_U2Res rotationOffset;
    }
}
