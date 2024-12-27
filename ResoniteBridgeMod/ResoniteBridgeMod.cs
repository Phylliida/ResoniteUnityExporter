using ResoniteBridge;
using ResoniteModLoader;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        static Dictionary<string, Assembly> loadedAssemblies;

        

        static CancellationTokenSource cancellation = new CancellationTokenSource();

        public static void SetupMod()
        {
            new Thread(() =>
            {
                ManualResetEvent readyToProcess = new ManualResetEvent(false);
                ResoniteBridgeServerData serverData = new ResoniteBridgeServerData()
                {
                    assemblies = ReflectionUtils.LoadAssemblies(typeof(FrooxEngine.Engine).Assembly),
                    uuidLookup = new UnsupportedTypeLookup(10)
                };
                using (ResoniteBridgeServer bridgeServer = new ResoniteBridgeServer((string msg) =>
                {
                    if (FrooxEngine.Engine.Current == null || FrooxEngine.Engine.Current.WorldManager == null || FrooxEngine.Engine.Current.WorldManager.FocusedWorld == null)
                    {
                        Msg("Bridge message:" + msg);
                    }
                    else
                    {
                        FrooxEngine.Engine.Current.WorldManager.FocusedWorld.RunSynchronously(() =>
                        {
                            Msg("Bridge message:" + msg);
                        });
                    }
                }, (message, threadState) =>
                {
                    // wait for ready to process
                    WaitHandle.WaitAny(new[] { readyToProcess, cancellation.Token.WaitHandle });
                    if (cancellation.IsCancellationRequested)
                    {
                        throw new CanceledException();
                    }

                    ResoniteBridgeResponse response = null;
                    
                    Action runStuff = delegate
                    {
                        try
                        {
                            response = ResoniteBridgeServerEvaluation.EvaluateMessage(serverData, message);
                        }
                        catch (Exception ex)
                        {
                            Msg("Got exception when evaluating message:" + ex.ToString() + "\n" +
                                Environment.StackTrace);
                            response = new ResoniteBridgeResponse
                            {
                                response = new ResoniteBridgeValue()
                                {
                                    typeName = ex.GetType().Name,
                                    valueStr = ex.ToString() + "\n" + Environment.StackTrace,
                                    valueType = ResoniteBridgeValueType.Error
                                },
                                responseType = ResoniteBridgeResponseType.Error,
                                extraResults = null
                            };
                        }
                    };
                    if (FrooxEngine.Engine.Current.WorldManager.FocusedWorld != null)
                    {
                        if (threadState == ResoniteBridgeServer.ThreadState.Background)
                        {
                            FrooxEngine.Engine.Current.WorldManager.FocusedWorld.Coroutines.StartBackgroundTask(
                                () => new System.Threading.Tasks.Task(runStuff));
                        }
                        else
                        {
                            FrooxEngine.Engine.Current.WorldManager.FocusedWorld.RunSynchronously(runStuff);
                        }
                    }
                    return response;
                }))
                {
                    try
                    {
                        Msg("Starting bridge server");
                        while (FrooxEngine.Engine.Current == null ||
                            FrooxEngine.Engine.Current.WorldManager == null ||
                            FrooxEngine.Engine.Current.WorldManager.FocusedWorld == null)
                        {
                            Thread.Sleep(16);
                        }
                        readyToProcess.Set();
                        Msg("Bridge server listening");
                        cancellation.Token.WaitHandle.WaitOne();
                    }
                    catch (Exception ex)
                    {
                        Msg("Got exception:" + ex.ToString() + "\n" + Environment.StackTrace);
                    }
                }
            }).Start();
        }
    }
}
