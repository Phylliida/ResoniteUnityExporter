using Elements.Assets;
using FrooxEngine;
using ResoniteBridgeLib;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportFromUnityLib
{
    public class ImportMaterial
    {
        static RefID_U2Res GetMaterialTexture(Material_U2Res material, string textureName)
        {
            for (int i = 0; i < material.texture2DNames.Length; i++)
            {
                if (material.texture2DNames[i] == textureName)
                {
                    return material.texture2DValues[i];
                }
            }
            return new RefID_U2Res()
            {
                id=0
            };
        }
        static IEnumerator<Context> ImportToMaterialHelper(byte[] materialBytes, OutputBytesHolder outputBytes)
        {
            // Load mesh data into a meshx
            yield return Context.ToBackground();
            Material_U2Res materialData = ResoniteBridgeLib.ResoniteBridgeUtils.DecodeObject<Material_U2Res>(materialBytes);
            Slot assetsSlot = (Slot)ImportFromUnityUtils.LookupRefID(materialData.rootAssetsSlot);
            FrooxEngine.XiexeToonMaterial mat = assetsSlot.AttachComponent<FrooxEngine.XiexeToonMaterial>();            
            // return refid of StaticMesh component
            RefID_U2Res result = new RefID_U2Res()
            {
                id = (ulong)mat.ReferenceID
            };
            outputBytes.outputBytes = ResoniteBridgeUtils.EncodeObject(result);
        }

        /// <summary>
        /// Takes static mesh data and makes a StaticMesh asset
        /// </summary>
        /// <param name="staticMeshBytes"></param>
        /// <returns>bytes representing RefID_U2Res that contains the static mesh asset component</returns>
        public static byte[] ImportToMaterialFunc(byte[] materialBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            ImportFromUnityUtils.RunOnWorldThread(ImportToMaterialHelper(materialBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }
    }
}
