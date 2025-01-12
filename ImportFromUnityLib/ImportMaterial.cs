using Elements.Assets;
using Elements.Core;
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
        static bool TryGetMaterialTextureTransform(Material_U2Res material, string fieldName, out float2 offset, out float2 scale)
        {
            offset = new float2(0, 0);
            scale = new float2(1, 1);
            if (TryGetMaterialFloat4(material, fieldName, out Float4_U2Res value))
            {
                // xy is scale, zw is offset because of unity reasons (idk)
                offset = new float2(value.z, value.w);
                scale = new float2(value.x, value.y);
                return true;
            }
            return false;
        }

        static bool TryGetMaterialFloat4(Material_U2Res material, string fieldName, out Float4_U2Res value)
        {
            value = new Float4_U2Res();
            for (int i = 0; i < material.float4Names.Length; i++)
            {
                if (material.float4Names[i] == fieldName)
                {
                    value = material.float4Values[i];
                    return true;
                }
            }
            return false;
        }

        static bool TryGetMaterialTexture(Material_U2Res material, string textureName, out RefID_U2Res matRefID)
        {
            matRefID = new RefID_U2Res()
            {
                id = 0
            };

            for (int i = 0; i < material.texture2DNames.Length; i++)
            {
                if (material.texture2DNames[i] == textureName)
                {
                    matRefID = material.texture2DValues[i];
                    return true;
                }
            }
            return false;
        }
        static IEnumerator<Context> ImportToMaterialHelper(byte[] materialBytes, OutputBytesHolder outputBytes)
        {
            // Load mesh data into a meshx
            yield return Context.ToBackground();
            Material_U2Res materialData = ResoniteBridgeLib.ResoniteBridgeUtils.DecodeObject<Material_U2Res>(materialBytes);
            yield return Context.ToWorld();
            Slot assetsSlot = (Slot)ImportFromUnityUtils.LookupRefID(materialData.rootAssetsSlot);
            FrooxEngine.XiexeToonMaterial mat = assetsSlot.AttachComponent<FrooxEngine.XiexeToonMaterial>();

            // _EmissionColor,
            if (TryGetMaterialFloat4(materialData, "_EmissionColor", out Float4_U2Res emissionColor))
            {
                mat.EmissionColor.Value = new colorX(emissionColor.x, emissionColor.y, emissionColor.z, emissionColor.w);
            }
            // _Color,
            if (TryGetMaterialFloat4(materialData, "_Color", out Float4_U2Res color))
            {
                mat.Color.Value = new colorX(color.x, color.y, color.z, color.w);
            }
            // _MainTex_ST,_MainTex_TexelSize,_MainTex_HDR,
            if (TryGetMaterialTexture(materialData, "_MainTex", out RefID_U2Res matRefID))
            {
                mat.MainTexture.Value = matRefID.id;
            }
            if (TryGetMaterialTextureTransform(materialData, "_MainTex_ST", out float2 offset, out float2 scale))
            {
                mat.MainTextureOffset.Value = offset;
                mat.MainTextureScale.Value = scale;
            }
            // _MetallicGlossMap_ST,_MetallicGlossMap_TexelSize,_MetallicGlossMap_HDR,
            if (TryGetMaterialTexture(materialData, "_MetallicGlossMap", out RefID_U2Res metallicGlossMapRefID))
            {
                mat.MetallicGlossMap.Value = metallicGlossMapRefID.id;
            }
            if (TryGetMaterialTextureTransform(materialData, "_MetallicGlossMap_ST", out float2 metallicoffset, out float2 metallicscale))
            {
                mat.MetallicGlossMapOffset.Value = metallicoffset;
                mat.MetallicGlossMapScale.Value = metallicscale;
            }            
            
            // _EmissionMap_ST,_EmissionMap_TexelSize,_EmissionMap_HDR,
            if (TryGetMaterialTexture(materialData, "_EmissionMap", out RefID_U2Res emissionMapRefID))
            {
                mat.EmissionMap.Value = emissionMapRefID.id;
            }
            if (TryGetMaterialTextureTransform(materialData, "_EmissionMap_ST", out float2 emissionoffset, out float2 emissionscale))
            {
                mat.EmissionMapOffset.Value = emissionoffset;
                mat.EmissionMapScale.Value = emissionscale;
            }

            // _OcclusionMap_ST,_OcclusionMap_TexelSize,_OcclusionMap_HDR,
            if (TryGetMaterialTexture(materialData, "_OcclusionMap", out RefID_U2Res occlusionMapRefID))
            {
                mat.OcclusionMap.Value = occlusionMapRefID.id;
            }
            if (TryGetMaterialTextureTransform(materialData, "_OcclusionMap_ST", out float2 occlusionoffset, out float2 occlusionscale))
            {
                mat.OcclusionMapOffset.Value = occlusionoffset;
                mat.OcclusionMapScale.Value = occlusionscale;
            }

            // _BumpMap_ST,_BumpMap_TexelSize,_BumpMap_HDR,
            // "normal maps are a type of bump map" says unity
            if (TryGetMaterialTexture(materialData, "_BumpMap", out RefID_U2Res bumpMapRefID))
            {
                mat.NormalMap.Value = bumpMapRefID.id;
            }
            if (TryGetMaterialTextureTransform(materialData, "_OcclusionMap_ST", out float2 bumpMapOffset, out float2 bumpMapScale))
            {
                mat.NormalMapOffset.Value = bumpMapOffset;
                mat.NormalMapScale.Value = bumpMapScale;
            }

            // todo:
            // _DetailMask_ST,_DetailMask_TexelSize,_DetailMask_HDR,
            // _DetailAlbedoMap_ST,_DetailAlbedoMap_TexelSize,_DetailAlbedoMap_HDR,
            // _DetailNormalMap_ST,_DetailNormalMap_TexelSize,_DetailNormalMap_HDR
            // _ParallaxMap_ST,_ParallaxMap_TexelSize,_ParallaxMap_HDR,
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
