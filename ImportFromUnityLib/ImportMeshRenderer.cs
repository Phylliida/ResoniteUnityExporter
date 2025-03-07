extern alias Froox;

using Froox::FrooxEngine;
using ResoniteUnityExporterShared;
using System.Collections.Generic;
using MemoryMappedFileIPC;
using System.Threading.Tasks;

namespace ImportFromUnityLib
{
    public class ImportMeshRenderer
    {
        public static void ImportMeshRendererHelper(byte[] meshRendererBytes, OutputBytesHolder outputBytes)
        {
            // load data from bytes
            MeshRenderer_U2Res meshRendererData = SerializationUtils.DecodeObject<MeshRenderer_U2Res>(meshRendererBytes);
            // load texture into localdb to get a url
            World focusedWorld = ImportFromUnityLib.CurrentEngine.WorldManager.FocusedWorld;
            Slot targetSlot = (Slot)ImportFromUnityUtils.LookupRefID(meshRendererData.targetSlot);
            ImportFromUnityLib.DebugLog("Importing mesh renderer on " + targetSlot.Name);
            MeshRenderer renderer = targetSlot.AttachComponent<MeshRenderer>();
            renderer.Mesh.Value = meshRendererData.staticMeshAsset.id;
            Slot assetsSlot = ((StaticMesh)ImportFromUnityUtils.LookupRefID(meshRendererData.staticMeshAsset)).Slot;
            // assign materials
            renderer.Materials.Clear();
            foreach (RefID_U2Res material in meshRendererData.materials)
            {
                IAssetProvider<Material> frooxMat = (IAssetProvider<Material>)ImportFromUnityUtils.LookupRefID(material);
                renderer.Materials.Add(frooxMat);
            }
            // return refid of MeshRenderer component
            RefID_U2Res result = new RefID_U2Res()
            {
                id = (ulong)renderer.ReferenceID
            };
            
            outputBytes.outputBytes = SerializationUtils.EncodeObject(result);
        }

        public static async Task<byte[]> ImportMeshRendererFunc(byte[] meshRendererData)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            await ImportFromUnityUtils.RunOnWorldThread(() => ImportMeshRendererHelper(meshRendererData, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }
    }
}
