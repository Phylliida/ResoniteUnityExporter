using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ResoniteUnityExporterShared
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Object_U2Res
    {
        /// <summary>
        /// A unique id identifying this slot, used for connecting bones
        /// </summary>
        public string uniqueId;
        /// <summary>
        /// Name of slot, this doesn't have to be unique
        /// </summary>
        public string name;
        public bool enabled;
        public Float3_U2Res localPosition;
        public Float4_U2Res localRotation;
        public Float3_U2Res localScale;
        /// <summary>
        /// Any children of this slot
        /// </summary>
        public Object_U2Res[] children;
    }
}
