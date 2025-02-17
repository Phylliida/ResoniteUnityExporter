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

            bool hasColor = false;
            colorX matColor = new colorX(1, 1, 1, 1);
            bool hasEmissionColor = false;
            colorX matEmissionColor = new colorX(1,1,1,1);

            bool hasMainTex = false;
            RefID_U2Res mainTexRefID = new RefID_U2Res();
            float2 mainTexOffset = new float2(0,0);
            float2 mainTexScale = new float2(1,1);

            bool hasMetallicGlossTex = false;
            RefID_U2Res metallicGlossTexRefID = new RefID_U2Res();
            float2 metallicGlossTexOffset = new float2(0, 0);
            float2 metallicGlossTexScale = new float2(1,1);

            bool hasEmissionMapTex = false;
            RefID_U2Res emissionMapTexRefID;
            float2 emissionMapTexOffset = new float2(0, 0);
            float2 emissionMapTexScale = new float2(1,1);

            bool hasOcclusionMapTex = false;
            RefID_U2Res occlusionMapTexRefID = new RefID_U2Res();
            float2 occlusionMapTexOffset = new float2(0, 0);
            float2 occlusionMapTexScale = new float2(1,1);

            bool hasBumpMapTex = false;
            RefID_U2Res bumpMapTexRefID = new RefID_U2Res();
            float2 bumpMapTexOffset = new float2(0, 0);
            float2 bumpMapTexScale = new float2(1, 1);

            bool hasDetailAlbedoMapTex = false;
            RefID_U2Res detailAlbedoMapTexRefID = new RefID_U2Res();
            float2 detailAlbedoMapTexOffset = new float2(0, 0);
            float2 detailAlbedoMapTexScale = new float2(1, 1);

            bool hasDetailNormalMapTex = false;
            RefID_U2Res detailNormalMapTexRefID = new RefID_U2Res();
            float2 detailNormalMapTexOffset = new float2(0, 0);
            float2 detailNormalMapTexScale = new float2(1, 1);

            // _Color,
            if (TryGetMaterialFloat4(materialData, "_Color", out Float4_U2Res color))
            {
                hasColor = true;
                //mat.Color.Value
                matColor = new colorX(color.x, color.y, color.z, color.w);
            }
            // _EmissionColor,
            if (TryGetMaterialFloat4(materialData, "_EmissionColor", out Float4_U2Res emissionColor))
            {
                hasEmissionColor = true;
                // mat.EmissionColor.Value
                matEmissionColor = new colorX(emissionColor.x, emissionColor.y, emissionColor.z, emissionColor.w);
            }
            // _MainTex_ST,_MainTex_TexelSize,_MainTex_HDR,
            if (TryGetMaterialTexture(materialData, "_MainTex", out mainTexRefID))
            {
                hasMainTex = true;
                // mat.MainTexture.Value
            }
            if (TryGetMaterialTextureTransform(materialData, "_MainTex_ST", out mainTexOffset, out mainTexScale))
            {
                //mat.MainTextureOffset.Value
                //mat.MainTextureScale.Value
            }
            // _MetallicGlossMap_ST,_MetallicGlossMap_TexelSize,_MetallicGlossMap_HDR,
            if (TryGetMaterialTexture(materialData, "_MetallicGlossMap", out metallicGlossTexRefID))
            {
                hasMetallicGlossTex = true;
                //mat.MetallicGlossMap.Value
            }
            if (TryGetMaterialTextureTransform(materialData, "_MetallicGlossMap_ST", out metallicGlossTexOffset, out metallicGlossTexScale))
            {
                //mat.MetallicGlossMapOffset.Value
                //mat.MetallicGlossMapScale.Value
            }
            
            // _EmissionMap_ST,_EmissionMap_TexelSize,_EmissionMap_HDR,
            if (TryGetMaterialTexture(materialData, "_EmissionMap", out emissionMapTexRefID))
            {
                hasEmissionMapTex = true;
                //mat.EmissionMap.Value
            }
            if (TryGetMaterialTextureTransform(materialData, "_EmissionMap_ST", out emissionMapTexOffset, out emissionMapTexScale))
            {
                //mat.EmissionMapOffset.Value
                //mat.EmissionMapScale.Value
            }

            // _OcclusionMap_ST,_OcclusionMap_TexelSize,_OcclusionMap_HDR,
            if (TryGetMaterialTexture(materialData, "_OcclusionMap", out occlusionMapTexRefID))
            {
                hasOcclusionMapTex = true;
                //mat.OcclusionMap.Value
            }
            if (TryGetMaterialTextureTransform(materialData, "_OcclusionMap_ST", out occlusionMapTexOffset, out occlusionMapTexScale))
            {
                //mat.OcclusionMapOffset.Value
                //mat.OcclusionMapScale.Value
            }

            // _BumpMap_ST,_BumpMap_TexelSize,_BumpMap_HDR,
            // "normal maps are a type of bump map" says unity
            if (TryGetMaterialTexture(materialData, "_BumpMap", out bumpMapTexRefID))
            {
                hasBumpMapTex = true;
                //mat.NormalMap.Value
            }
            if (TryGetMaterialTextureTransform(materialData, "_BumpMap_ST", out bumpMapTexOffset, out bumpMapTexScale))
            {
                //mat.NormalMapOffset.Value
                //mat.NormalMapScale.Value
            }
            // _DetailAlbedoMap_ST,_DetailAlbedoMap_TexelSize,_DetailAlbedoMap_HDR,
            if (TryGetMaterialTexture(materialData, "_DetailAlbedoMap", out detailAlbedoMapTexRefID))
            {
                hasDetailAlbedoMapTex = true;
                //mat.NormalMap.Value
            }
            if (TryGetMaterialTextureTransform(materialData, "_DetailAlbedoMap_ST", out detailAlbedoMapTexOffset, out detailAlbedoMapTexScale))
            {
                //mat.NormalMapOffset.Value
                //mat.NormalMapScale.Value
            }

            // _DetailNormalMap_ST,_DetailNormalMap_TexelSize,_DetailNormalMap_HDR
            if (TryGetMaterialTexture(materialData, "_DetailNormalMap", out detailNormalMapTexRefID))
            {
                hasDetailNormalMapTex = true;
                //mat.NormalMap.Value
            }
            if (TryGetMaterialTextureTransform(materialData, "_DetailNormalMap_ST", out detailNormalMapTexOffset, out detailNormalMapTexScale))
            {
                //mat.NormalMapOffset.Value
                //mat.NormalMapScale.Value
            }


            RefID_U2Res matRefId = new RefID_U2Res()
            {
                id = 0
            };
            if (materialData.materialName == MaterialNames_U2Res.XIEXE_TOON_MAT)
            {
                FrooxEngine.XiexeToonMaterial mat = assetsSlot.AttachComponent<FrooxEngine.XiexeToonMaterial>();
                matRefId.id = (ulong)mat.ReferenceID;
                if (hasColor)
                {
                    mat.Color.Value = matColor;
                }
                if (hasEmissionColor)
                {
                    mat.EmissionColor.Value = matEmissionColor;
                }
                if (hasMainTex)
                {
                    mat.MainTexture.Value = mainTexRefID.id;
                    mat.MainTextureOffset.Value = mainTexOffset;
                    mat.MainTextureScale.Value = mainTexScale;
                }
                if (hasMetallicGlossTex)
                {
                    mat.MetallicGlossMap.Value = metallicGlossTexRefID.id;
                    mat.MetallicGlossMapOffset.Value = metallicGlossTexOffset;
                    mat.MetallicGlossMapScale.Value = metallicGlossTexScale;
                }
                if (hasEmissionMapTex)
                {
                    mat.EmissionMap.Value = emissionMapTexRefID.id;
                    mat.EmissionMapOffset.Value = emissionMapTexOffset;
                    mat.EmissionMapScale.Value = emissionMapTexScale;
                }
                if (hasOcclusionMapTex)
                {
                    mat.OcclusionMap.Value = occlusionMapTexRefID.id;
                    mat.OcclusionMapOffset.Value = occlusionMapTexOffset;
                    mat.OcclusionMapScale.Value = occlusionMapTexScale;
                }
                if (hasBumpMapTex)
                {
                    mat.NormalMap.Value = bumpMapTexRefID.id;
                    mat.NormalMapOffset.Value = bumpMapTexOffset;
                    mat.NormalMapScale.Value = bumpMapTexScale;
                }
            }
            else if (materialData.materialName == MaterialNames_U2Res.PBS_SPECULAR_MAT) {
                FrooxEngine.PBS_Specular mat = assetsSlot.AttachComponent<FrooxEngine.PBS_Specular>();
                matRefId.id = (ulong)mat.ReferenceID;
                if (hasColor)
                {
                    mat.AlbedoColor.Value = matColor;
                }
                if (hasEmissionColor)
                {
                    mat.EmissiveColor.Value = matEmissionColor;
                }
                if (hasMainTex)
                {
                    mat.AlbedoTexture.Value = mainTexRefID.id;
                    mat.TextureOffset.Value = mainTexOffset;
                    mat.TextureScale.Value = mainTexScale;
                }
                if (hasMetallicGlossTex)
                {
                    //mat.MetallicGlossMap.Value = metallicGlossTexRefID.id;
                    //mat.MetallicGlossMapOffset.Value = metallicGlossTexOffset;
                    //mat.MetallicGlossMapScale.Value = metallicGlossTexScale;
                }
                if (hasEmissionMapTex)
                {
                    mat.EmissiveMap.Value = emissionMapTexRefID.id;
                    //mat.EmissionMapOffset.Value = emissionMapTexOffset;
                    //mat.EmissionMapScale.Value = emissionMapTexScale;
                }
                if (hasOcclusionMapTex)
                {
                    mat.OcclusionMap.Value = occlusionMapTexRefID.id;
                    //mat.OcclusionMapOffset.Value = occlusionMapTexOffset;
                    //mat.OcclusionMapScale.Value = occlusionMapTexScale;
                }
                if (hasBumpMapTex)
                {
                    mat.NormalMap.Value = bumpMapTexRefID.id;
                    //mat.NormalMapOffset.Value = bumpMapTexOffset;
                    //mat.NormalScale.Value;
                }
                if (hasDetailAlbedoMapTex)
                {
                    mat.DetailAlbedoTexture.Value = detailAlbedoMapTexRefID.id;
                    mat.DetailTextureOffset.Value = detailAlbedoMapTexOffset;
                    mat.DetailTextureScale.Value = detailAlbedoMapTexScale;
                }

                if (hasDetailNormalMapTex)
                {
                    mat.DetailNormalMap.Value = detailNormalMapTexRefID.id;
                    //mat.DetailNormalScale.Value = detailNormalMapTexScale;
                }
            }
            else if (materialData.materialName == MaterialNames_U2Res.PBS_METALLIC_MAT)
            {
                FrooxEngine.PBS_Metallic mat = assetsSlot.AttachComponent<FrooxEngine.PBS_Metallic>();
                matRefId.id = (ulong)mat.ReferenceID;
                if (hasColor)
                {
                    mat.AlbedoColor.Value = matColor;
                }
                if (hasEmissionColor)
                {
                    mat.EmissiveColor.Value = matEmissionColor;
                }
                if (hasMainTex)
                {
                    mat.AlbedoTexture.Value = mainTexRefID.id;
                    mat.TextureOffset.Value = mainTexOffset;
                    mat.TextureScale.Value = mainTexScale;
                }
                if (hasMetallicGlossTex)
                {
                    mat.MetallicMap.Value = metallicGlossTexRefID.id;
                    //mat.MetallicGlossMapOffset.Value = metallicGlossTexOffset;
                    //mat.MetallicGlossMapScale.Value = metallicGlossTexScale;
                }
                if (hasEmissionMapTex)
                {
                    mat.EmissiveMap.Value = emissionMapTexRefID.id;
                    //mat.EmissionMapOffset.Value = emissionMapTexOffset;
                    //mat.EmissionMapScale.Value = emissionMapTexScale;
                }
                if (hasOcclusionMapTex)
                {
                    mat.OcclusionMap.Value = occlusionMapTexRefID.id;
                    //mat.OcclusionMapOffset.Value = occlusionMapTexOffset;
                    //mat.OcclusionMapScale.Value = occlusionMapTexScale;
                }
                if (hasBumpMapTex)
                {
                    mat.NormalMap.Value = bumpMapTexRefID.id;
                    //mat.NormalMapOffset.Value = bumpMapTexOffset;
                    //mat.NormalScale.Value;
                }
                if (hasDetailAlbedoMapTex)
                {
                    mat.DetailAlbedoTexture.Value = detailAlbedoMapTexRefID.id;
                    mat.DetailTextureOffset.Value = detailAlbedoMapTexOffset;
                    mat.DetailTextureScale.Value = detailAlbedoMapTexScale;
                }

                if (hasDetailNormalMapTex)
                {
                    mat.DetailNormalMap.Value = detailNormalMapTexRefID.id;
                    //mat.DetailNormalScale.Value = detailNormalMapTexScale;
                }
            }
            else if (materialData.materialName == MaterialNames_U2Res.UNLIT_MAT)
            {
                FrooxEngine.UnlitMaterial mat = assetsSlot.AttachComponent<FrooxEngine.UnlitMaterial>();
                matRefId.id = (ulong)mat.ReferenceID;
                if (hasColor)
                {
                    mat.TintColor.Value = matColor;
                }
                if (hasEmissionColor)
                {
                    //mat.color.Value = matEmissionColor;
                }
                if (hasMainTex)
                {
                    mat.Texture.Value = mainTexRefID.id;
                    mat.TextureOffset.Value = mainTexOffset;
                    mat.TextureScale.Value = mainTexScale;
                }
                if (hasMetallicGlossTex)
                {
                    //mat.MetallicMap.Value = metallicGlossTexRefID.id;
                    //mat.MetallicGlossMapOffset.Value = metallicGlossTexOffset;
                    //mat.MetallicGlossMapScale.Value = metallicGlossTexScale;
                }
                if (hasEmissionMapTex)
                {
                    //mat.EmissiveMap.Value = emissionMapTexRefID.id;
                    //mat.EmissionMapOffset.Value = emissionMapTexOffset;
                    //mat.EmissionMapScale.Value = emissionMapTexScale;
                }
                if (hasOcclusionMapTex)
                {
                    //mat.OcclusionMap.Value = occlusionMapTexRefID.id;
                    //mat.OcclusionMapOffset.Value = occlusionMapTexOffset;
                    //mat.OcclusionMapScale.Value = occlusionMapTexScale;
                }
                if (hasBumpMapTex)
                {
                    StaticTexture2D tex = (StaticTexture2D)ImportFromUnityUtils.LookupRefID(bumpMapTexRefID);
                    mat.NormalMap = tex;
                }
                if (hasDetailAlbedoMapTex)
                {
                    //mat.DetailAlbedoTexture.Value = detailAlbedoMapTexRefID.id;
                    //mat.DetailTextureOffset.Value = detailAlbedoMapTexOffset;
                    //mat.DetailTextureScale.Value = detailAlbedoMapTexScale;
                }

                if (hasDetailNormalMapTex && !hasBumpMapTex)
                {
                    //StaticTexture2D tex = (StaticTexture2D)ImportFromUnityUtils.LookupRefID(detailNormalMapTexRefID);
                    //mat.NormalMap = tex;
                    //mat.DetailNormalScale.Value = detailNormalMapTexScale;
                }
            }

            // todo:
            // _DetailMask_ST,_DetailMask_TexelSize,_DetailMask_HDR,
            // _ParallaxMap_ST,_ParallaxMap_TexelSize,_ParallaxMap_HDR,
            // return refid of StaticMesh component
            outputBytes.outputBytes = ResoniteBridgeUtils.EncodeObject(matRefId);
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
