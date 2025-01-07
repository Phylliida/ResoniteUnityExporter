using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ResoniteUnityExporterShared
{
    [StructLayout(LayoutKind.Sequential)]
    public class Texture2D_U2Res
    {
        public RefID_U2Res rootAssetsSlot;
        public int width;
        public int height;
        public Color_U2Res[] data;
    }
}