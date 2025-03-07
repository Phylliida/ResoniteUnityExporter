extern alias Froox;

using Froox::Elements.Core;
using Froox::FrooxEngine;
using System.Collections.Generic;
using System.IO;
using ResoniteUnityExporterShared;
using Froox::SkyFrost.Base;
using MemoryMappedFileIPC;
using System.Threading.Tasks;

namespace ImportFromUnityLib
{
    public class MakePackage
    {
        public static IEnumerator<Context> MakePackageHelper(byte[] packageInfoBytes, OutputBytesHolder outputBytes)
        {
            yield return Context.ToBackground();
            PackageInfo_U2Res packageInfo = SerializationUtils.DecodeObject<PackageInfo_U2Res>(packageInfoBytes);
            // modified from PackageExportable Resonite
            yield return Context.ToWorld();
            Slot mainParentSlot = (Slot)ImportFromUnityUtils.LookupRefID(packageInfo.mainParentSlot);
            SavedGraph savedGraph = mainParentSlot.SaveObject(DependencyHandling.CollectAssets);
            World focusedWorld = ImportFromUnityLib.CurrentEngine.WorldManager.FocusedWorld;
            Record record = RecordHelper.CreateForObject<Record>(mainParentSlot.Name, focusedWorld.LocalUser.UserID ?? focusedWorld.LocalUser.MachineID, null);
            yield return Context.ToBackground();
            string path = packageInfo.packagePath;
            // make parent directory if not exist
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            using (FileStream fstream = File.OpenWrite(path))
            {
                PackageCreator.BuildPackage(focusedWorld.Engine, record, savedGraph, fstream, packageInfo.includeVariants).GetAwaiter().GetResult();
            }
            outputBytes.outputBytes = SerializationUtils.EncodeObject(true);
        }

        public static async Task<byte[]> MakePackageFunc(byte[] packageInfoBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            await ImportFromUnityUtils.RunCoroutine(MakePackageHelper(packageInfoBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }

    }
}
