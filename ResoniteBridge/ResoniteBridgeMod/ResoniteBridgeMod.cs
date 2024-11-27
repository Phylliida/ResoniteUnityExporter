using ResoniteBridge;
using ResoniteDataWrapper;
using ResoniteModLoader;
using System;
using System.Collections.Generic;
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
        private static string harmony_id = "tessacoil.resonitebridgemod";

        public override void OnEngineInit()
        {

            Config = GetConfiguration(); //Get the current ModConfiguration for this mod
            Config.Save(true); //If you'd like to save the default config values to file
        
            SetupMod();
        }

        public ResoniteBridge.ResoniteBridgeServer listener;

        public static Dictionary<string, Assembly> LoadAssemblies()
        {
            Msg("Hii! I'm in directory " + System.IO.Directory.GetCurrentDirectory());
            return new Dictionary<string, Assembly>();
        }

        public static void SetupMod()
        {
            new Thread(() =>
            {
                ResoniteBridgeServerData serverData = new ResoniteBridgeServerData()
                {
                    assemblies = LoadAssemblies(),
                    uuidLookup = new UnsupportedTypeLookup(10)
                };
                using (ResoniteBridgeServer bridgeServer = new ResoniteBridgeServer())
                {
                    try
                    {
                        Msg("Starting bridge server");
                        while (FrooxEngine.Engine.Current == null ||
                            FrooxEngine.Engine.Current.WorldManager.FocusedWorld == null)
                        {
                            Thread.Sleep(16);
                        }
                        Msg("Bridge server listening");
                        var cancellation = new CancellationTokenSource();
                        while (true)
                        {
                            FrooxEngine.World focusedWorld = FrooxEngine.Engine.Current.WorldManager.FocusedWorld;
                            if (focusedWorld != null)
                            {
                                serverData.focusedWorld = focusedWorld;
                                serverData.engine = FrooxEngine.Engine.Current;
                                Action runStuff = delegate
                                {
                                    while (bridgeServer.inputMessages.TryDequeue(out ResoniteBridgeMessage message))
                                    {
                                        Msg("Got message of type " + message.messageType + " with name " + message.name + " with target " + message.target + " with inputs " + message.inputs);
                                        bridgeServer.outputMessages.Enqueue(ResoniteBridgeServerEvaluation.EvaluateMessage(serverData, message));
                                    }
                                };
                                focusedWorld.RunSynchronously(runStuff);
                            }
                            Thread.Sleep(16);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString() + "\n" + Environment.StackTrace);
                    }
                }
            }).Start();
        }
    }
}
