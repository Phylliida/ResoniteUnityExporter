﻿using ImportFromUnityLib;
using ResoniteBridgeLib;
using ResoniteModLoader;
using ResoniteUnityExporterShared;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Threading;

namespace ResoniteBridgeMod
{
    public class ResoniteBridgeMod : ResoniteMod
    {
        public override string Name => "ResoniteBridgeMod";
        public override string Author => "TessaCoil";
        public override string Version => "1.0.0"; //Version of the mod, should match the AssemblyVersion
        public override string Link => "https://github.com/Phylliida/ResoniteUnityExporter"; // Optional link to a repo where this mod would be located

        [AutoRegisterConfigKey]
        private static readonly ModConfigurationKey<bool> enabled = new ModConfigurationKey<bool>("enabled", "Should the mod be enabled", () => true); //Optional config settings

        private static ModConfiguration Config; //If you use config settings, this will be where you interface with them.
        private static string harmony_id = "tessacoil.ResoniteUnityExporterMod";

        public override void OnEngineInit()
        {
            Config = GetConfiguration(); //Get the current ModConfiguration for this mod
            Config.Save(true); //If you'd like to save the default config values to file
        
            SetupMod();
        }

        public ResoniteBridgeLib.ResoniteBridgeServer listener;

        static Dictionary<string, Assembly> loadedAssemblies;

        
        public static CancellationTokenSource cancellation = new CancellationTokenSource();

        public static void SetupMod()
        {
            new Thread(() =>
            {
                ManualResetEvent readyToProcess = new ManualResetEvent(false);
                
                try
                {
                    Msg("Starting resonite unity exporter server");
                    while (FrooxEngine.Engine.Current == null ||
                        FrooxEngine.Engine.Current.WorldManager == null ||
                        FrooxEngine.Engine.Current.WorldManager.FocusedWorld == null)
                    {
                        Thread.Sleep(16);
                    }
                    readyToProcess.Set();
                    string serverDirectory =
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                            "UnityResoniteImporter",
                            "IPCConnections",
                            "Servers"
                        );
                    using (ResoniteBridgeServer bridgeServer = new ResoniteBridgeServer("UnityResoniteImporter", serverDirectory, (string msg) =>
                    {
                        // enable for debugging connections
                        //Msg("Bridge message:" + msg);
                    }))
                    {
                        ImportFromUnityLib.ImportFromUnityLib.Register(bridgeServer, () =>
                        {
                            var focusedWorld = FrooxEngine.Engine.Current.WorldManager.FocusedWorld;
                            return new ServerInfo_U2Res()
                            {
                                allowedToCreateInWorld = ImportFromUnityUtils.AllowedToSpawn(),
                                label = "Mod",
                                worldName = focusedWorld != null ? focusedWorld.Name : "None"
                            };
                        }, Msg, CurrentEngine: FrooxEngine.Engine.Current);
                        Msg("Bridge server listening");
                        cancellation.Token.WaitHandle.WaitOne();
                    }
                }
                catch (Exception ex)
                {
                    Msg("Got exception:" + ex.ToString() + "\n" + Environment.StackTrace);
                }
            }).Start();
        }
    }
}
