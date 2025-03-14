using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ResoniteUnityExporterShared
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ObjectHierarchy_U2Res
    {
        public string hierarchyName;
        public float rescaleFactor;
        /// <summary>
        /// All objects in the hierarchy (each object may include children)
        /// Each object should have a unique id used for looking it up
        /// </summary>
        public Object_U2Res[] objects;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ObjectLookups_U2Res
    {
        public RefID_U2Res mainParentSlot;
        public RefID_U2Res rootAssetSlot;
        public ObjectLookup_U2Res[] lookups;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ObjectLookup_U2Res
    {
        public string uniqueId;
        public RefID_U2Res refId;
    }
}
