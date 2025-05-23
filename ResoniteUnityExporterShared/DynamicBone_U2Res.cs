﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ResoniteUnityExporterShared
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DynamicBoneCollider_U2Res
    {
        public RefID_U2Res targetSlot;
        public string colliderType;
        public float radius;
        public float height;
        public Float3_U2Res localPosition;
        public Float4_U2Res localRotation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DynamicBoneChain_U2Res
    {
        public RefID_U2Res targetSlot;
        public RefID_U2Res[] bones;
        public bool grabbable;
        public float stiffness;
        public float gravity;
        public float baseBoneRadius;
        public float[] boneRadiusModifiers;
        public RefID_U2Res[] colliders;
    }
}
