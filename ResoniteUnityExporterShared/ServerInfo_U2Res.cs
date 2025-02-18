using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ResoniteUnityExporterShared
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ServerInfo_U2Res
    {
        public string label;
        public string worldName;
        public bool allowedToCreateInWorld;
    }
}
