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

namespace ResoniteDataWrapper
{

    public class FrooxEngineRunner
    {

        public static object ReadField(object obj, string fieldName)
        {
            return obj.GetType().GetField(fieldName).GetValue(obj);
        }

        public static object ReadProperty(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName).GetValue(obj);
        }

        public static void SetField(object obj, string fieldName, object value)
        {
            obj.GetType().GetField(fieldName).SetValue(obj, value);
        }

        public static void SetProperty(object obj, string propertyName, object value)
        {
            obj.GetType().GetProperty(propertyName).SetValue(obj, value);
        }

        public static object CallConstructor(Assembly assembly, string typeName, params object[] parameters)
        {
            Type[] inputTypes = new Type[parameters.Length];
            for(int i = 0; i < parameters.Length; i++)
            {
                inputTypes[i] = parameters[i].GetType();
            }
            return assembly.GetType(typeName)
                .GetConstructor(inputTypes)
                .Invoke(parameters);
        }

        public static bool MethodParamsMatch(MethodInfo method, object[] parameters)
        {
            var methodParameters = method.GetParameters();
            // more is bad, but less could mean default params are being used
            if (parameters.Length > methodParameters.Length)
            {
                return false;
            }
            for (int i = 0; i < methodParameters.Length; i++)
            {
                ParameterInfo param = methodParameters[i];
                if (i >= parameters.Length && !param.HasDefaultValue)
                {
                    return false;
                }
                // we allow i>=parameters.length and param.HasDefaultValue
                // because in that case we use the default value
                else if(i < parameters.Length)
                {
                    // needs to be a different type and not a subclass of correct type
                    if (param.ParameterType != parameters[i].GetType() &&
                        !parameters[i].GetType().IsSubclassOf(param.ParameterType))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static object? CallMethod(object obj, string methodName, params object[] parameters)
        {
            MethodInfo method = null;
            try
            {
                try
                {
                    method = obj.GetType().GetMethod(methodName);
                    return method
                        .Invoke(obj, parameters);
                }
                // overriden methods, we need to search manually
                catch (System.Reflection.AmbiguousMatchException)
                {
                    foreach (MethodInfo methodInfo in obj.GetType().GetMethods())
                    {
                        var methodParameters = methodInfo.GetParameters();
                        if (MethodParamsMatch(methodInfo, parameters))
                        {
                            method = methodInfo;
                            return method.Invoke(obj, parameters);
                        }
                    }
                }
            }
            // this can happen with default params
            catch (System.Reflection.TargetParameterCountException)
            {
                var methodParams = method.GetParameters();
                // try sticking type missing in other places, this is needed for default arguments
                if (methodParams.Length > parameters.Length)
                {
                    object[] newParams = new object[methodParams.Length];
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        newParams[i] = parameters[i];
                    }
                    for (int i = parameters.Length; i < methodParams.Length; i++)
                    {
                        newParams[i] = Type.Missing;
                    }
                    method.Invoke(obj, newParams);
                }
                else
                {
                    // default args not relevant, we did something wrong
                    throw;
                }
            }
            throw new ArgumentException("Did not find method " + methodName + " in type " + obj.GetType().Name + " with " + parameters.Length + " parameters");
        }

        public static object? CallStaticMethod(Assembly assembly, string typeName, string methodName, params object[] parameters)
        {
            return assembly.GetType(typeName).GetMethod(methodName, BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic)
                .Invoke(null, parameters);
        }

        public static object GetEnum(Assembly assembly, string enumTypeName, string enumValue)
        {
            Type enumType = assembly.GetType(enumTypeName);
            return Enum.Parse(enumType, enumValue);
        }

        public delegate void ObjectDelegate(object input);

        public static Delegate CreateDelegateWithInputType(Assembly assembly, string inputTypeName, string delegateTypeName, ObjectDelegate delegateToCall)
        {
            Type inputType = assembly.GetType(inputTypeName);
            Type delegateType = assembly.GetType(delegateTypeName);

            // Cursed shit
            var parameter = Expression.Parameter(inputType, "input");
            var convertExpr = Expression.Convert(parameter, typeof(object));
            Expression call;
            if (delegateToCall.Method.IsStatic)
            {
                call = Expression.Call(
                    delegateToCall.Method,
                    convertExpr
                );
            }
            else
            {
                call = Expression.Call(
                    Expression.Constant(delegateToCall.Target),
                    delegateToCall.Method,
                    convertExpr
                );
            }
            var lambda = Expression.Lambda(delegateType, call, parameter);
            return lambda.Compile();
        }


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
        public Assembly FrooxEngineAsm;
        public Assembly SkyFrostBaseModelsAsm;
        public object mainRootSlot;


        // heavily modified from code given to me by whatsavalue3 (who gave permission to license this as MIT)
        public FrooxEngineRunner()
        {
            string resoniteDir = Path.GetDirectoryName(
                FrooxEngineRunner.GetResoniteExePath(out Dictionary<string, Assembly> libraries)
            );
            string curDir = System.IO.Directory.GetCurrentDirectory();
            string libraryPath = Path.Combine(resoniteDir, "Resonite_Data", "Managed");

            libraries.TryGetValue("FrooxEngine", out FrooxEngineAsm);
            libraries.TryGetValue("SkyFrost.Base.Models", out SkyFrostBaseModelsAsm);

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
                // network monitoring thread
                new Thread(() =>
                {
                    while (true)
                    {
                        using (NamedPipeServerStream pipeServer =
                            new NamedPipeServerStream("testpipew", PipeDirection.InOut))
                        {

                            Console.WriteLine("Waiting for connection to unity");

                            pipeServer.WaitForConnection();

                            Console.WriteLine("Connected to unity");
                            try
                            {
                                // Read the request from the client. Once the client has
                                // written to the pipe its security token will be available.

                                StreamString ss = new StreamString(pipeServer);

                                // Verify our identity to the connected client using a
                                // string that the client anticipates.
                                ss.WriteString("Hello!");
                                while (true)
                                {
                                    string filename = ss.ReadString();
                                    Console.WriteLine("Recieved string: '" + ss.ReadString() + "'");
                                }
                            }
                            // Catch the IOException that is raised if the pipe is broken
                            // or disconnected.
                            catch (IOException e)
                            {
                                Console.WriteLine("Disconnected from unity with error");
                                Console.WriteLine("ERROR: {0}", e.Message);
                            }
                        }
                    }
                }).Start();
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
                            ReadProperty(
                                ReadProperty(engine, "WorldManager"),
                                "FocusedWorld");
                            
                        if (focusedWorld != null)
                        {
                            Action runStuff = delegate {
                                // code here for modifying world
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
    public class StreamString
    {
        private Stream ioStream;
        private UnicodeEncoding streamEncoding;

        public StreamString(Stream ioStream)
        {
            this.ioStream = ioStream;
            streamEncoding = new UnicodeEncoding();
        }

        public string ReadString()
        {
            int len = 0;

            len = ioStream.ReadByte() * 256;
            len += ioStream.ReadByte();
            byte[] inBuffer = new byte[len];
            ioStream.Read(inBuffer, 0, len);

            return streamEncoding.GetString(inBuffer);
        }

        public int WriteString(string outString)
        {
            byte[] outBuffer = streamEncoding.GetBytes(outString);
            int len = outBuffer.Length;
            if (len > UInt16.MaxValue)
            {
                len = (int)UInt16.MaxValue;
            }
            ioStream.WriteByte((byte)(len / 256));
            ioStream.WriteByte((byte)(len & 255));
            ioStream.Write(outBuffer, 0, len);
            ioStream.Flush();

            return outBuffer.Length + 2;
        }
    }
}
