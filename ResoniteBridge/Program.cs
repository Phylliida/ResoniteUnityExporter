using System;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Collections.Concurrent;
using System.IO.Pipes;
using System.Text;
using System.Text.Json.Nodes;
using System.ComponentModel;

using static ResoniteBridge.ReflectionUtils;
using System.Text.Json;
using Newtonsoft.Json;
using ResoniteDataWrapper;

namespace ResoniteBridge
{
    public class FrooxEngineRunner
    {

        // Modified from https://github.com/Lexevolution/Resonite-DataTree-Converter/blob/main/Program.cs
        public static string GetResoniteExePath(out Dictionary<string, Assembly> libraries)
        {
            string settingsLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TefssaCoil", "ResoniteDataWrapper", "app.config");

            bool success = false;
            libraries = new Dictionary<string, Assembly>();
            string resoniteExeLocation = "";

            while (!success)
            {
                while (!File.Exists(settingsLocation))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(settingsLocation));
                    Console.WriteLine("Please find Resonite.exe");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    OpenFileDialog ofd = new OpenFileDialog()
                    {
                        Filter = "Executable Files (*.exe)|*.exe",
                        Title = "Please select Resonite.exe",
                        CheckFileExists = true,
                        CheckPathExists = true,
                        Multiselect = false
                    };
                    string defaultResonitePosition = @"C:\Program Files (x86)\Steam\steamapps\common\Resonite";
                    if (Path.Exists(defaultResonitePosition))
                    {
                        ofd.InitialDirectory = defaultResonitePosition;
                    }
                    DialogResult result = ofd.ShowDialog();
                    Console.WriteLine("");
                    if (result == DialogResult.Cancel)
                    {
                        Console.WriteLine("Cancelled, restarting...");
                        Console.WriteLine("");
                    }
                    else
                    {
                        File.WriteAllText(settingsLocation, ofd.FileName);
                    }
                }
                StreamReader sr = new StreamReader(settingsLocation);
                resoniteExeLocation = sr.ReadToEnd();
                sr.Close();
                Console.WriteLine(string.Format("DIRECTORY: {0}", Path.GetDirectoryName(resoniteExeLocation)));
                libraries.Clear();
                string resoniteFolder = Path.GetDirectoryName(resoniteExeLocation);
                string libraryFolder = Path.Combine(resoniteFolder, "Resonite_Data", "Managed");

                // needed so it can fetch various config stuff
                Directory.SetCurrentDirectory(resoniteFolder);

                Environment.SetEnvironmentVariable("PATH",
                    Environment.GetEnvironmentVariable("PATH") + ";"
                    + libraryFolder + ";"
                    + Path.Combine(resoniteFolder, "Resonite_Data", "Plugins", "x86_64") + ";"
                    + resoniteFolder); // for assimp.dll


                AppDomain.CurrentDomain.AssemblyResolve += delegate (object sender, ResolveEventArgs args)
                {
                    string assemblyFile = (args.Name.Contains(','))
                        ? args.Name.Substring(0, args.Name.IndexOf(','))
                        : args.Name;

                    assemblyFile += ".dll";

                    string targetPath = Path.Combine(libraryFolder, assemblyFile);

                    try
                    {
                        return Assembly.LoadFile(targetPath);
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                };


                Console.WriteLine("current path" + Environment.GetEnvironmentVariable("PATH"));
                try
                {
                    libraries.Add("Newtonsoft.Json", Assembly.LoadFrom(Path.Combine(libraryFolder, "Newtonsoft.Json.dll")));
                    libraries.Add("FrooxEngine", Assembly.LoadFrom(Path.Combine(libraryFolder, "FrooxEngine.dll")));
                    libraries.Add("SkyFrost.Base", Assembly.LoadFrom(Path.Combine(libraryFolder, "SkyFrost.Base.dll")));
                    libraries.Add("SkyFrost.Base.Models", Assembly.LoadFrom(Path.Combine(libraryFolder, "SkyFrost.Base.Models.dll")));
                    libraries.Add("Elements.Core", Assembly.LoadFrom(Path.Combine(libraryFolder, "Elements.Core.dll")));
                    success = true;
                }
                catch
                {
                    Console.WriteLine("Resonite.exe not detected. Restarting...");
                    Console.WriteLine("");
                    File.Delete(settingsLocation);
                }
            }
            return resoniteExeLocation;
        }

        public object engine;
        public object systemInfo;
        public object focusedWorld;
        public Assembly FrooxEngineAsm;
        public Assembly SkyFrostBaseModelsAsm;
        public object mainRootSlot;
        public Dictionary<string, Assembly> assemblies;
        public UnsupportedTypeLookup uuidLookup = new UnsupportedTypeLookup(10);

        // heavily modified from code given to me by whatsavalue3 (who gave permission to license this as MIT)
        public FrooxEngineRunner()
        {
            string resoniteDir = Path.GetDirectoryName(
                FrooxEngineRunner.GetResoniteExePath(out assemblies)
            );
            string curDir = System.IO.Directory.GetCurrentDirectory();
            string libraryPath = Path.Combine(resoniteDir, "Resonite_Data", "Managed");

            assemblies.TryGetValue("FrooxEngine", out FrooxEngineAsm);
            assemblies.TryGetValue("SkyFrost.Base.Models", out SkyFrostBaseModelsAsm);

            object launchOptions = CallConstructor(FrooxEngineAsm, "FrooxEngine.LaunchOptions");

            SetProperty(launchOptions, "DataDirectory",
                Path.Combine(resoniteDir, "Resonite_Data", "Data"));
            // Cache needs to be local in order to run this while Resonite is also running
            SetProperty(launchOptions, "CacheDirectory",
                Path.Combine(curDir, "Cache"));
            SetProperty(launchOptions, "LogsDirectory",
                Path.Combine(resoniteDir, "Logs"));
            SetProperty(launchOptions, "CloudProfile",
                GetEnum(FrooxEngineAsm, "FrooxEngine.CloudProfile", "Production"));
            SetProperty(launchOptions, "VerboseInit",
                false);

            engine = CallConstructor(FrooxEngineAsm, "FrooxEngine.Engine");
            systemInfo = CallConstructor(FrooxEngineAsm, "FrooxEngine.StandaloneSystemInfo");

            System.Threading.Tasks.Task task = (System.Threading.Tasks.Task)
                CallMethod(engine, "Initialize",
                    libraryPath,
                    launchOptions,
                    systemInfo,
                    null,
                    CallConstructor(FrooxEngineAsm, "FrooxEngine.ConsoleEngineInitProgress"));

            var configuredTaskAwaiter = task.ConfigureAwait(false).GetAwaiter();

            while (!configuredTaskAwaiter.IsCompleted)
            {
                Thread.Sleep(16);
            }

            // if you want to login, optional
            //var consolelogin = ((FrooxEngine.Engine)this.engine).Cloud.InteractiveConsoleLogin().ConfigureAwait(false).GetAwaiter();
            //((FrooxEngine.Engine)this.engine).Cloud.
            //while (!consolelogin.IsCompleted)
            //{

            //}
            var userspaceWorld = CallStaticMethod(FrooxEngineAsm, "FrooxEngine.Userspace", "SetupUserspace", engine);
            CallMethod(engine, "RunUpdateLoop");
            
            object worldStart = CallConstructor(FrooxEngineAsm, "FrooxEngine.WorldStartSettings");
            SetField(worldStart, "AutoFocus", true);
            SetField(worldStart, "DefaultAccessLevel", 
                GetEnum(SkyFrostBaseModelsAsm, "SkyFrost.Base.SessionAccessLevel", "Private"));

            Delegate initWorldDelegate = 
                CreateDelegateWithInputType(FrooxEngineAsm,
                "FrooxEngine.World",
                "FrooxEngine.WorldAction",
                delegate (object world)
                {
                    CallStaticMethod(FrooxEngineAsm, "FrooxEngine.WorldPresets", "Grid", world);
                    SetProperty(world, "AccessLevel",
                        GetEnum(SkyFrostBaseModelsAsm, "SkyFrost.Base.SessionAccessLevel", "Private"));
                    SetField(world, "ForceAnnounceOnWAN", false);
                    SetProperty(world, "MaxUsers", 1);
                    SetProperty(world, "Name", "ResoniteDataWrapper");
                    mainRootSlot = CallMethod(world, "AddSlot", "ResoniteDataWrapperSlotRoot");
                });
            SetField(worldStart, "InitWorld", initWorldDelegate);

            System.Threading.Tasks.Task opener = (System.Threading.Tasks.Task)
                CallStaticMethod(FrooxEngineAsm,
                "FrooxEngine.Userspace",
                "OpenWorld",
                worldStart);
            opener.ConfigureAwait(false).GetAwaiter();

            ConcurrentQueue<string> messages = new ConcurrentQueue<string>();
            new Thread(() =>
            {
                using (ResoniteBridgeServer bridgeServer = new ResoniteBridgeServer())
                {

                    try
                    {
                        Console.WriteLine("Starting");
                        while (!opener.IsCompleted)
                        {
                            CallMethod(engine, "RunUpdateLoop");
                            CallMethod(systemInfo, "FrameFinished");
                            Thread.Sleep(16);
                        }
                        Console.WriteLine("Started");
                        var cancellation = new CancellationTokenSource();
                        while (true)
                        {
                            object focusedWorld =
                                GetProperty(
                                    GetProperty(engine, "WorldManager"),
                                    "FocusedWorld");

                            if (focusedWorld != null)
                            {
                                this.focusedWorld = focusedWorld;
                                Action runStuff = delegate
                                {
                                    while(bridgeServer.inputMessages.TryPeek(out ResoniteBridgeMessage message))
                                    {
                                        bridgeServer.outputMessages.Enqueue(message.Evaluate(this));
                                    }
                                };
                                CallMethod(focusedWorld, "RunSynchronously",
                                    runStuff,
                                    false,
                                    null,
                                    false);
                            }
                            CallMethod(engine, "RunUpdateLoop");
                            CallMethod(systemInfo, "FrameFinished");
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

    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            FrooxEngineRunner runner = new FrooxEngineRunner();
        }
    }
}
