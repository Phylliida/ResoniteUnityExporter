using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ResoniteUnityExporterShared
{
    public enum LODFadeMode_U2Res
    {
        // docs from unity
        // Summary:
        //     Indicates the LOD fading is turned off.
        None=0,
        //
        // Summary:
        //     Perform cross-fade style blending between the current LOD and the next LOD if
        //     the distance to camera falls in the range specified by the LOD.fadeTransitionWidth
        //     of each LOD.
        CrossFade=1,
        //
        // Summary:
        //     By specifying this mode, your LODGroup will perform a SpeedTree-style LOD fading
        //     scheme: * For all the mesh LODs other than the last (most crude) mesh LOD, the
        //     fade factor is calculated as the percentage of the object's current screen height,
        //     compared to the whole range of the LOD. It is 1, if the camera is right at the
        //     position where the previous LOD switches out and 0, if the next LOD is just about
        //     to switch in. * For the last mesh LOD and the billboard LOD, the cross-fade mode
        //     is used.
        SpeedTree=2
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct LOD_U2Res
    {
        public float screenRelativeTransitionHeight;
        public float fadeTransitionWidth;
        public RefID_U2Res[] renderers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LODGroup_U2Res
    {
        public RefID_U2Res target;
        public LOD_U2Res[] LODs;
        public Float3_U2Res localReferencePoint;
        public float size;
        public int lodCount;
        public bool lastLODBillboard;
        public LODFadeMode_U2Res fadeMode;
        public bool animateCrossFading;
        public bool enabled;
        public float crossFadeAnimationDuration;
    }
}
