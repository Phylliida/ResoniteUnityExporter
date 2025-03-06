extern alias Froox;

using Froox::FrooxEngine;

using MemoryMappedFileIPC;
using ResoniteUnityExporterShared;

namespace ImportFromUnityLib
{
    public class ImportFromUnityLib
    {

        public delegate void DebugLogDelegate(string msg);

        public static DebugLogDelegate DebugLog;

        public static Engine CurrentEngine;

        public delegate ServerInfo_U2Res ServerInfoDelegate();

        public static void Register(ResoniteBridgeLib.ResoniteBridgeServer server, ServerInfoDelegate serverInfoCallback, DebugLogDelegate DebugLog, object CurrentEngine)
        {
            ImportFromUnityLib.CurrentEngine = (Engine)CurrentEngine;
            ImportFromUnityLib.DebugLog = DebugLog;
            server.RegisterProcessor("GetServerInfo", (byte[] _) => SerializationUtils.EncodeObject(serverInfoCallback()));
            server.RegisterProcessor("MakePackage", MakePackage.MakePackageFunc);

            server.RegisterProcessor("ImportSlotHierarchy", ImportSlotHierarchy.ImportSlotHierarchyFunc);
            server.RegisterProcessor("ImportToStaticMesh", ImportMesh.ImportToStaticMeshFunc);
            server.RegisterProcessor("ImportToTexture2D", ImportTexture2D.ImportTexture2DFunc);
            server.RegisterProcessor("ImportAvatar", ImportAvatar.ImportAvatarFunc);
            server.RegisterProcessor("ImportSkinnedMeshRenderer", ImportSkinnedMeshRenderer.ImportSkinnedMeshRendererFunc);
            server.RegisterProcessor("ImportMeshRenderer", ImportMeshRenderer.ImportMeshRendererFunc);
            server.RegisterProcessor("ImportToMaterial", ImportMaterial.ImportToMaterialFunc);
            server.RegisterProcessor("ImportDynamicBoneChain", ImportDynamicBones.ImportDynamicBoneChainFunc);
            server.RegisterProcessor("ImportDynamicBoneCollider", ImportDynamicBones.ImportDynamicBoneColliderFunc);
            server.RegisterProcessor("FinalizeAvatarCreator", ImportFinalizeAvatarCreator.ImportFinalizeAvatarCreatorFunc);

            // constraints
            server.RegisterProcessor("ImportPositionConstraint", ImportConstraint.ImportPositionConstraintFunc);
            server.RegisterProcessor("ImportRotationConstraint", ImportConstraint.ImportRotationConstraintFunc);
            server.RegisterProcessor("ImportScaleConstraint", ImportConstraint.ImportScaleConstraintFunc);
            server.RegisterProcessor("ImportAimConstraint", ImportConstraint.ImportAimConstraintFunc);
            server.RegisterProcessor("ImportParentConstraint", ImportConstraint.ImportParentConstraintFunc);
            server.RegisterProcessor("ImportLookAtConstraint", ImportConstraint.ImportLookAtConstraintFunc);

            // colliders
            server.RegisterProcessor("ImportSphereCollider", ImportCollider.ImportSphereColliderFunc);
            server.RegisterProcessor("ImportCapsuleCollider", ImportCollider.ImportCapsuleColliderFunc);
            server.RegisterProcessor("ImportBoxCollider", ImportCollider.ImportBoxColliderFunc);
            server.RegisterProcessor("ImportMeshCollider", ImportCollider.ImportMeshColliderFunc);

            // lights
            server.RegisterProcessor("ImportLight", ImportLight.ImportLightFunc);

            // LODGroups
            server.RegisterProcessor("ImportLODGroup", ImportLOD.ImportLODFunc);
        }
    }
}
