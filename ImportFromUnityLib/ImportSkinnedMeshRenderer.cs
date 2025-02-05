using FrooxEngine.Store;
using FrooxEngine;
using ResoniteBridgeLib;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FrooxEngine.DataFeedItemMappingManager;
using Elements.Core;
using Assimp;
using static OfficialAssets.Graphics;
using System.IO;
using System.Xml.Linq;
using System.Reflection;
using FrooxEngine.FinalIK;

namespace ImportFromUnityLib
{
    public class ImportSkinnedMeshRenderer
    {
        public static IEnumerator<Context> ImportSkinnedMeshRendererHelper(byte[] skinnedMeshRendererBytes, OutputBytesHolder outputBytes)
        {
            yield return Context.ToBackground();
            // load data from bytes
            SkinnedMeshRenderer_U2Res skinnedMeshRendererData = ResoniteBridgeUtils.DecodeObject<SkinnedMeshRenderer_U2Res>(skinnedMeshRendererBytes);
            // load texture into localdb to get a url
            World focusedWorld = FrooxEngine.Engine.Current.WorldManager.FocusedWorld;
            yield return Context.ToWorld();
            Slot targetSlot = (Slot)ImportFromUnityUtils.LookupRefID(skinnedMeshRendererData.targetSlot);
            SkinnedMeshRenderer renderer = targetSlot.AttachComponent<SkinnedMeshRenderer>();
            renderer.Mesh.Value = skinnedMeshRendererData.staticMeshAsset.id;
            Slot assetsSlot = ((FrooxEngine.StaticMesh)ImportFromUnityUtils.LookupRefID(skinnedMeshRendererData.staticMeshAsset)).Slot;
            // assign materials
            renderer.Materials.Clear();
            foreach (RefID_U2Res material in skinnedMeshRendererData.materials)
            {
                IAssetProvider<FrooxEngine.Material> frooxMat = (IAssetProvider<FrooxEngine.Material>)ImportFromUnityUtils.LookupRefID(material);
                renderer.Materials.Add(frooxMat);
            }
            // assign bones and rig
            // todo: resonite forces these to be unique by name
            // but that constraint doesn't seem necessary as far as I can tell so I did everything
            // so that we can have multiple bones named same thing
            // will that cause issues? idk
            foreach (RefID_U2Res boneRefID in skinnedMeshRendererData.bones)
            {
                renderer.Bones.Add().Value = boneRefID.id;
            }
            renderer.BoundsComputeMethod.Value = SkinnedBounds.Static;
            
            // return refid of SkinnedMeshRenderer component
            RefID_U2Res result = new RefID_U2Res()
            {
                id = (ulong)renderer.ReferenceID
            };
            
            outputBytes.outputBytes = ResoniteBridgeUtils.EncodeObject(result);
        }

        public static byte[] ImportSkinnedMeshRendererFunc(byte[] skinnedMeshRendererData)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            ImportFromUnityUtils.RunOnWorldThread(ImportSkinnedMeshRendererHelper(skinnedMeshRendererData, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }
    }
}
