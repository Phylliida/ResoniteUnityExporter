using Elements.Core;
using FrooxEngine.Store;
using FrooxEngine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ResoniteUnityExporterShared;
using ResoniteBridgeLib;
using SkyFrost.Base;

namespace ImportFromUnityLib
{
    internal class MakePackage
    {
        public static IEnumerator<Context> MakePackageHelper(byte[] packageInfoBytes, OutputBytesHolder outputBytes)
        {
            yield return Context.ToBackground();
            PackageInfo_U2Res packageInfo = ResoniteBridgeUtils.DecodeObject<PackageInfo_U2Res>(packageInfoBytes);
            // modified from PackageExportable Resonite
            yield return Context.ToWorld();
            Slot mainParentSlot = (Slot)ImportFromUnityUtils.LookupRefID(packageInfo.mainParentSlot);
            SavedGraph savedGraph = mainParentSlot.SaveObject(DependencyHandling.CollectAssets);
            World focusedWorld = FrooxEngine.Engine.Current.WorldManager.FocusedWorld;
            SkyFrost.Base.Record record = RecordHelper.CreateForObject<SkyFrost.Base.Record>(mainParentSlot.Name, focusedWorld.LocalUser.UserID ?? focusedWorld.LocalUser.MachineID, null);
            yield return Context.ToBackground();
            string path = packageInfo.packagePath;
            // make parent directory if not exist
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            using (FileStream fstream = File.OpenWrite(path))
            {
                PackageCreator.BuildPackage(focusedWorld.Engine, record, savedGraph, fstream, packageInfo.includeVariants).GetAwaiter().GetResult();
            }
            outputBytes.outputBytes = ResoniteBridgeUtils.EncodeObject(true);
        }

        public static byte[] MakePackageFunc(byte[] packageInfoBytes)
        {
            OutputBytesHolder outputBytesHolder = new OutputBytesHolder();
            ImportFromUnityUtils.RunOnWorldThread(MakePackageHelper(packageInfoBytes, outputBytesHolder));
            return outputBytesHolder.outputBytes;
        }

    }
}
