using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ResoniteUnityExporterShared
{
    [StructLayout(LayoutKind.Sequential)]
    public struct BoxCollider_U2Res
    {
        public RefID_U2Res target;
        public Float3_U2Res center;
        public Float3_U2Res size;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SphereCollider_U2Res
    {
        public RefID_U2Res target;
        public Float3_U2Res center;
        public float radius;
    }

    public enum CapsuleColliderDirection_U2Res
    {
        X = 0,
        Y = 1,
        Z = 2,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CapsuleCollider_U2Res
    {
        public RefID_U2Res target;
        public Float3_U2Res center;
        public float radius;
        public float height;
        public CapsuleColliderDirection_U2Res direction;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MeshCollider_U2Res
    {
        public RefID_U2Res target;
        public RefID_U2Res staticMesh;
        public Float3_U2Res center;
        public bool convex;
    }
}
