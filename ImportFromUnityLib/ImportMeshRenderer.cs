using FrooxEngine;
using ResoniteUnityExporterShared;
using System.Collections.Generic;
using MemoryMappedFileIPC;

namespace ImportFromUnityLib
{
    public class ImportMeshRenderer
    {
        public static IEnumerator<Context> ImportMeshRendererHelper(byte[] meshRendererBytes, OutputBytesHolder outputBytes)
        {
            yield return Context.ToBackground();
            // load data from bytes
            MeshRenderer_U2Res meshRendererData = SerializationUtils.DecodeObject<MeshRenderer_U2Res>(meshRendererBytes);
            // load texture into localdb to get a url
            World focusedWorld = FrooxEngine.Engine.Current.WorldManager.FocusedWorld;
            yield return Context.ToWorld();
            Slot targetSlot = (Slot)ImportFromUnityUtils.LookupRefID(meshRendererData.targetSlot);
            MeshRenderer renderer = targetSlot.AttachComponent<MeshRenderer>();
            renderer.Mesh.Value = meshRendererData.staticMeshAsset.id;
            Slot assetsSlot = ((FrooxEngine.StaticMesh)ImportFromUnityUtils.LookupRefID(meshRendererData.staticMeshAsset)).Slot;
            // assign materials
            renderer.Materials.Clear();
            foreach (RefID_U2Res material in meshRendererData.materials)
            {
                IAssetProvider<FrooxEngine.Material> frooxMat = (IAssetProvider<FrooxEngine.Material>)ImportFromUnityUtils.LookupRefID(material);
                renderer.Materials.Add(frooxMat);
            }
            // return refid of MeshRenderer component
            RefID_U2Res result = new RefID_U2Res()
            {
                id = (ulong)renderer.ReferenceID
            };
            
            outputBytes.outputBytes = SerializationUtils.EncodeObject(result);
        }

        public static byte[] ImportMeshRendererFunc(byte[] meshRendererData)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            ImportFromUnityUtils.RunOnWorldThread(ImportMeshRendererHelper(meshRendererData, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }
    }
}
