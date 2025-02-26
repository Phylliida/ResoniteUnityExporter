using FreeImageAPI;
using FrooxEngine;
using FrooxEngine.Store;
using MemoryMappedFileIPC;
using ResoniteUnityExporterShared;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ImportFromUnityLib
{
    public class ImportTexture2D
    {

        public static void SaveRawDataToPNG(int width, int height, Color32_U2Res[] rawData, string filePath)
        {
            FIBITMAP bitmap = FreeImage.AllocateT(FREE_IMAGE_TYPE.FIT_BITMAP,
                width, height, 32,
                FreeImage.FI_RGBA_RED_MASK,
                FreeImage.FI_RGBA_GREEN_MASK,
                FreeImage.FI_RGBA_BLUE_MASK);
            
            // shuffle around into bgra it expects
            // sadly idk a way to do this in bulk (probably best option is to use simd)
            byte[] pixels = new byte[rawData.Length * 4];
            int dataI = 0;
            for (int i = 0; i < rawData.Length; i++)
            {
                var col = rawData[i];
                pixels[dataI++] = col.b;
                pixels[dataI++] = col.g;
                pixels[dataI++] = col.r;
                pixels[dataI++] = col.a;
            }
            var stride = FreeImage.GetPitch(bitmap);
            for (int y = 0; y < height; y++)
            {
                var scan = FreeImage.GetScanLine(bitmap, y);
                Marshal.Copy(pixels, y * width * 4, scan, width * 4);
            }
            FreeImage.Save(FREE_IMAGE_FORMAT.FIF_PNG, bitmap, filePath, FREE_IMAGE_SAVE_FLAGS.PNG_Z_BEST_COMPRESSION);
        }
        public static IEnumerator<Context> ImportToTexture2DHelper(byte[] texData, OutputBytesHolder outputBytes)
        {
            yield return Context.ToBackground();
            // load data from bytes
            Texture2D_U2Res tex = SerializationUtils.DecodeObject<Texture2D_U2Res>(texData);
            // load texture into localdb to get a url
            World focusedWorld = FrooxEngine.Engine.Current.WorldManager.FocusedWorld;
            FrooxEngine.Store.LocalDB localDb = focusedWorld.Engine.LocalDB;

            string tempFilePath;
            // raw data import
            if (tex.data != null)
            {
                ImportFromUnityLib.DebugLog("Importing texture raw data");
                tempFilePath = localDb.GetTempFilePath("png");
                //ImportFromUnityLib.DebugLog("Got raw data for texture");
                SaveRawDataToPNG(tex.width, tex.height, tex.data, tempFilePath);
            }
            // import from file
            else
            {
                ImportFromUnityLib.DebugLog("Importing texture from path " + tex.path);
                tempFilePath = localDb.GetTempFilePath(System.IO.Path.GetExtension(tex.path));
                //ImportFromUnityLib.DebugLog("Got path " + tex.path + " for texture");
                System.IO.File.Copy(tex.path, tempFilePath, true);
            }

            System.Uri url = localDb.ImportLocalAssetAsync(tempFilePath, LocalDB.ImportLocation.Move).GetAwaiter().GetResult();
            yield return Context.ToWorld();
            Slot assetsSlot = focusedWorld.AssetsSlot.FindChild(x => (ulong)x.ReferenceID == tex.rootAssetsSlot.id);
            FrooxEngine.StaticTexture2D tex2d = assetsSlot.AttachComponent<FrooxEngine.StaticTexture2D>();
            tex2d.URL.Value = url;
            // return refid of StaticMesh component
            RefID_U2Res result = new RefID_U2Res()
            {
                id = (ulong)tex2d.ReferenceID
            };
            outputBytes.outputBytes = SerializationUtils.EncodeObject(result);
        }

        public static byte[] ImportTexture2DFunc(byte[] texData)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            ImportFromUnityUtils.RunOnWorldThread(ImportToTexture2DHelper(texData, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }
    }
}
