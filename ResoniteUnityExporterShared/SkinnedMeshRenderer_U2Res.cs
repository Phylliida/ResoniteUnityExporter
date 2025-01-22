using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ResoniteUnityExporterShared
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SkinnedMeshRendererSettings_U2Res
    {
        public bool setupIK;
        public bool forceTPose;
        public bool generateColliders;
        public bool generateSkeletonBoneVisuals;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SkinnedMeshRenderer_U2Res
    {
        public SkinnedMeshRendererSettings_U2Res settings;
        public RefID_U2Res targetSlot;
        public RefID_U2Res staticMeshAsset;
        public RefID_U2Res[] bones;
        public RefID_U2Res[] materials;
    }
}
