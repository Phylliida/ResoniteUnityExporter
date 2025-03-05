using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ResoniteUnityExporterShared
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Texture2D_U2Res
    {
        public RefID_U2Res rootAssetsSlot;
        public int width;
        public int height;
        public Color32_U2Res[] data;
        public string path;
    }
}