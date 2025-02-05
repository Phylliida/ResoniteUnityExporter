using ResoniteBridgeLib;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportFromUnityLib
{
    public class ImportFromUnityLib
    {

        public delegate void DebugLogDelegate(string msg);

        public static DebugLogDelegate DebugLog;

        public static void Register(ResoniteBridgeLib.ResoniteBridgeServer server, DebugLogDelegate DebugLog)
        {
            ImportFromUnityLib.DebugLog = DebugLog;
            server.RegisterProcessor("TestBees", SimpleTestFunc);
            server.RegisterProcessor("ImportSlotHierarchy", ImportSlotHierarchy.ImportSlotHierarchyFunc);
            server.RegisterProcessor("ImportToStaticMesh", ImportMesh.ImportToStaticMeshFunc);
            server.RegisterProcessor("ImportToTexture2D", ImportTexture2D.ImportTexture2DFunc);
            server.RegisterProcessor("ImportAvatar", ImportAvatar.ImportAvatarFunc);
            server.RegisterProcessor("ImportSkinnedMeshRenderer", ImportSkinnedMeshRenderer.ImportSkinnedMeshRendererFunc);
            server.RegisterProcessor("ImportMeshRenderer", ImportMeshRenderer.ImportMeshRendererFunc);
            server.RegisterProcessor("ImportToMaterial", ImportMaterial.ImportToMaterialFunc);
        }

        public static byte[] SimpleTestFunc(byte[] data)
        {
            Float3_U2Res input = ResoniteBridgeUtils.DecodeObject<Float3_U2Res>(data);
            Float3_U2Res result = new Float3_U2Res()
            {
                x = input.x + 1,
                y = input.y - 2,
                z = input.z * 2,
            };
            return ResoniteBridgeUtils.EncodeObject(result);
        }
    }
}
