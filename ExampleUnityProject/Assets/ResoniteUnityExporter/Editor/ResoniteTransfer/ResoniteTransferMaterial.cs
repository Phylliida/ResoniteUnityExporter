using MemoryMappedFileIPC;
using ResoniteBridgeLib;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ResoniteUnityExporter
{
    public class ResoniteTransferMaterial
    {

        public static IEnumerator<object> SendMaterialToResonite(HierarchyLookup hierarchyLookup, UnityEngine.Material material, ResoniteBridgeClient bridgeClient, OutputHolder<object> output)
        {
            Material_U2Res materialData = new Material_U2Res();
            materialData.rootAssetsSlot = hierarchyLookup.rootAssetsSlot;
            string[] textures = material.GetPropertyNames(MaterialPropertyType.Texture);
            List<string> texture2DNames = new List<string>();
            List<RefID_U2Res> texture2DValues = new List<RefID_U2Res>();
            foreach (string texName in textures)
            {
                Texture tex = material.GetTexture(texName);
                if (tex is Texture2D tex2D)
                {
                    texture2DNames.Add(texName);
                    var textureOutputHolder = new OutputHolder<object>();

                    var texEn = hierarchyLookup.SendOrGetTexture(tex2D, textureOutputHolder);
                    while (texEn.MoveNext())
                    {
                        yield return null;
                    }
                    texture2DValues.Add((RefID_U2Res)textureOutputHolder.value);
                }
                else
                {
                    // todo: 3D textures, idk something else too?
                }
            }
            materialData.texture2DNames = texture2DNames.ToArray();
            materialData.texture2DValues = texture2DValues.ToArray();

            string[] floatNames = material.GetPropertyNames(MaterialPropertyType.Float);
            float[] floatValues = floatNames.Select(f => material.GetFloat(f)).ToArray();
            materialData.floatNames = floatNames;
            materialData.floatValues = floatValues.ToArray();

            // annoyingly unity has all vectors and colors as vector4
            string[] vectorNames = material.GetPropertyNames(MaterialPropertyType.Vector);
            Vector4[] vectorValuesUnity = vectorNames.Select(f => material.GetVector(f)).ToArray();
            Float4_U2Res[] vectorValues = 
                SerializationUtils.ConvertArray<Float4_U2Res, Vector4>(vectorValuesUnity);
            materialData.float4Names = vectorNames;
            materialData.float4Values = vectorValues;

            string[] intNames = material.GetPropertyNames(MaterialPropertyType.Int);
            // GetInt is a seperate thing and is still backed by floats, so should be covered by GetFloat above (I think?)
            int[] intValues = intNames.Select(f => material.GetInteger(f)).ToArray();
            materialData.intNames = intNames;
            materialData.intValues = intValues.ToArray();

            Dictionary<int, string> materialMappings = hierarchyLookup.transferManager.settings.materialMappings;
            if (!materialMappings.TryGetValue(material.GetInstanceID(), out materialData.materialName))
            {
                materialData.materialName = MaterialNames_U2Res.PBS_METALLIC_MAT;
                Debug.LogWarning("Unknown material map for material: " + material.name + " with shader " + material.shader);
            }

            var en = hierarchyLookup.Call<RefID_U2Res, Material_U2Res>("ImportToMaterial", materialData, output);
            while (en.MoveNext())
            {
                yield return null;
            }
        }
    }
}
