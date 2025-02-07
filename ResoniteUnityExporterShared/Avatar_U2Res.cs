using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ResoniteUnityExporterShared
{

    [StructLayout(LayoutKind.Sequential)]
    public struct Avatar_U2Res
    {
        public RefID_U2Res[] renderers;
        public RefID_U2Res assetsSlot;
        public bool hasCustomHeadPosition;
        public Float3_U2Res customHeadPosition; 
        public bool floorOnOrigin;
        public bool rescale;
        public float targetScale;
        public bool setupIK;
        public bool setupAvatarCreator;
        public bool forceTPose;
        public bool generateColliders;
        public bool generateSkeletonBoneVisuals;
        public float nearClip;
    }
}
