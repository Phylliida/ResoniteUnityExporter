using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ResoniteUnityExporterShared
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MeshRenderer_U2Res
    {
        public RefID_U2Res targetSlot;
        public RefID_U2Res staticMeshAsset;
        public RefID_U2Res[] materials;
    }
}
