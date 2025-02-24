using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ResoniteUnityExporterShared
{
    public static class SkinnedMeshRendererConstants
    {
        public static string tempBonePrefix = "_U2Rtempbone";
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SkinnedMeshRenderer_U2Res
    {
        public RefID_U2Res targetSlot;
        public RefID_U2Res staticMeshAsset;
        public RefID_U2Res[] bones;
        public RefID_U2Res[] materials;
        public float[] blendShapeWeights;
    }
}
