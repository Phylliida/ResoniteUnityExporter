using ResoniteBridgeLib;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ResoniteUnityExporter.ResoniteTransferUtils;

namespace ResoniteUnityExporter
{
    public class ResoniteTransferTexture2D
    {
        public static Texture2D_U2Res ConvertTexture(UnityEngine.Texture2D texture)
        {
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
