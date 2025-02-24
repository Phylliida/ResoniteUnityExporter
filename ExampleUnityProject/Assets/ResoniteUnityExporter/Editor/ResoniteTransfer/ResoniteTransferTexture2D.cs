using ResoniteBridgeLib;
using ResoniteUnityExporterShared;
using System;
using System.IO;
using UnityEditor;
using UnityEngine;
using static ResoniteUnityExporter.ResoniteTransferUtils;

namespace ResoniteUnityExporter
{
    public class ResoniteTransferTexture2D
    {
        // needed for reading a texture that isn't readable
        // from https://discussions.unity.com/t/easy-way-to-make-texture-isreadable-true-by-script/848617/6
        static UnityEngine.Texture2D DupTexAsReadable(Texture2D source)
        {
            RenderTexture renderTex = RenderTexture.GetTemporary(
                        source.width,
                        source.height,
                        0,
                        RenderTextureFormat.Default,
                        RenderTextureReadWrite.Linear);

            Graphics.Blit(source, renderTex);
            RenderTexture previous = RenderTexture.active;
            RenderTexture.active = renderTex;
            Texture2D readableText = new Texture2D(source.width, source.height);
            readableText.ReadPixels(new Rect(0, 0, renderTex.width, renderTex.height), 0, 0);
            readableText.Apply();
            RenderTexture.active = previous;
            RenderTexture.ReleaseTemporary(renderTex);
            return readableText;
        }

        public static Texture2D_U2Res ConvertTexture(UnityEngine.Texture2D texture)
        {
            string path = Path.GetFullPath(AssetDatabase.GetAssetPath(texture));
            Debug.Log("Got texture path:" + path);

            // if the texture exists in the file systefm (isn't some procedural thing), use that
            if (path != null && File.Exists(path))
            {
                return new Texture2D_U2Res
                {
                    path = path,
                };
            }
            else
            {
                if (!texture.isReadable)
                {
                    texture = DupTexAsReadable(texture);
                }
                // this is slow (takes 10-20ms) but that's good enough for one time transfer
                // and it's better to use this vs getting raw data because we need to convert format
                UnityEngine.Color32[] textureColors = texture.GetPixels32();
                Color32_U2Res[] colorData = ResoniteBridgeUtils.ConvertArray<Color32_U2Res, UnityEngine.Color32>(textureColors);
                return new Texture2D_U2Res
                {
                    width = texture.width,
                    height = texture.height,
                    data = colorData
                };
            }

        }
        public static RefID_U2Res SendTextureToResonite(HierarchyLookup hierarchyLookup, UnityEngine.Texture2D texture, ResoniteBridgeClient bridgeClient)
        {
            Texture2D_U2Res convertedTexture = ConvertTexture(texture);
            convertedTexture.rootAssetsSlot = hierarchyLookup.rootAssetsSlot;

            byte[] encoded = null;

            using (Timer _ = new Timer("Encoding"))
            {
                encoded = ResoniteBridgeUtils.EncodeObject(convertedTexture);
            }
            using (Timer _ = new Timer("Processing Static Mesh"))
            {
                bridgeClient.SendMessageSync(
                    "ImportToTexture2D",
                    encoded,
                    -1,
                    out byte[] outBytes,
                    out bool isError
                    );
                if (isError)
                {
                    throw new Exception(ResoniteBridgeUtils.DecodeString(outBytes));
                }
                RefID_U2Res staticMeshRefId = ResoniteBridgeUtils.DecodeObject<RefID_U2Res>(outBytes);
                Debug.Log("Got refid for Texture2D of " + staticMeshRefId.id);
                return staticMeshRefId;
            }
        }
    }
}
