using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ResoniteBridge
{
    public class ResoniteBridgeServer : IDisposable
    {

        // from https://stackoverflow.com/a/10253634
        public static IEnumerable<Assembly> GetAssemblies(Assembly frooxEngineAsm, params string[] searchPaths)
        {
            var list = new List<string>();
            var stack = new Stack<Assembly>();

            stack.Push(frooxEngineAsm);

            do
            {
                var asm = stack.Pop();

                yield return asm;

                foreach (var reference in asm.GetReferencedAssemblies())
                    if (!list.Contains(reference.FullName))
                    {
                        try
                        {
                            stack.Push(Assembly.Load(reference));
                        }
                        catch (Exception e) when (e is System.IO.FileNotFoundException || e is System.IO.FileLoadException)
                        {
                            foreach (string searchPath in searchPaths)
                            {
                                try
                                {
                                    stack.Push(Assembly.Load(System.IO.Path.Combine(searchPath, reference.Name)));
                                    break;
                                }
                                catch (Exception e2) when (e2 is System.IO.FileNotFoundException || e2 is System.IO.FileLoadException)
                                {

                                }
                            }
                        }
                        list.Add(reference.FullName);
                    }

            }
            while (stack.Count > 0);

        }

        public static string GetAssemblyName(Assembly assembly)
        {
            return assembly.GetName().Name;
        }

        public static Dictionary<string, Assembly> LoadAssemblies(Assembly frooxEngineAsm, params string[] searchPaths)
        {
            Dictionary<string, Assembly> loadedAssemblies = new Dictionary<string, Assembly>();

            foreach (Assembly assembly in GetAssemblies(frooxEngineAsm, searchPaths))
            {
                if (!loadedAssemblies.ContainsKey(GetAssemblyName(assembly)))
                {
                    loadedAssemblies.Add(GetAssemblyName(assembly), assembly);
                }
            }

            // Any assemblies loaded later
            AppDomain.CurrentDomain.AssemblyLoad += (object sender, AssemblyLoadEventArgs args) => {
                if (!loadedAssemblies.ContainsKey(GetAssemblyName(args.LoadedAssembly)))
                {
                    loadedAssemblies.Add(GetAssemblyName(args.LoadedAssembly), args.LoadedAssembly);
                }
            };
            // This will be directory holding resonite
            // For example
            // C:\Program Files (x86)\Steam\steamapps\common\Resonite
            return loadedAssemblies;
        }


        public const string NAMED_SOCKET_KEY = "ResoniteCustomBridge";

        Thread monitoringThread;

        public CancellationTokenSource stopToken;
        public delegate void LogDelegate(string message);

        public ConcurrentQueue<ResoniteBridgeMessage> inputMessages = new ConcurrentQueue<ResoniteBridgeMessage>();
        public ConcurrentQueue<ResoniteBridgeValue> outputMessages = new ConcurrentQueue<ResoniteBridgeValue>();
        public ResoniteBridgeServer (LogDelegate DebugLog)
        {
            stopToken = new CancellationTokenSource();
            int millisTimeout = 10000;
            // network monitoring thread
            monitoringThread = new Thread(() =>
            {
                try
                {
                    bool waitingForRequest = true;
                    ResoniteBridgeValue response = null;

                    while (!stopToken.IsCancellationRequested)
                    {
                        using (NamedPipeServerStream pipeServer =
                            new NamedPipeServerStream(NAMED_SOCKET_KEY, PipeDirection.InOut))
                        {
                            try
                            {
                                DebugLog("Waiting for connection to client");

                                pipeServer.WaitForConnection();

                                DebugLog("Connected to client");
                                // Read the request from the client. Once the client has
                                // written to the pipe its security token will be available.

                                StreamString ss = new StreamString(pipeServer);

                                // Verify our identity to the connected client using a
                                // string that the client anticipates.
                                while (!stopToken.IsCancellationRequested)
                                {
                                    if (waitingForRequest)
                                    {
                                        string message = ss.ReadString(millisTimeout, stopToken.Token);
                                        if (message == null)
                                        {
                                            DebugLog("Got null message, breaking");
                                            break;
                                        }
                                        try
                                        {
                                            DebugLog("Got string " + message);
                                            ResoniteBridgeMessage parsedMessage = JsonConvert.DeserializeObject<ResoniteBridgeMessage>(message);
                                            inputMessages.Enqueue(parsedMessage);
                                            Stopwatch elapsed = new Stopwatch();
                                            while (!outputMessages.TryDequeue(out response) && !stopToken.IsCancellationRequested)
                                            {
                                                if (elapsed.ElapsedMilliseconds > millisTimeout)
                                                {
                                                    throw new TimeoutException("Recieved message but took too long to process");
                                                }
                                                Thread.Sleep(1);
                                            }
                                            waitingForRequest = false;
                                        }
                                        catch (JsonSerializationException e)
                                        {
                                            DebugLog("Failed to serialize message, ignoring");
                                            DebugLog("ERROR: " + e.Message);
                                            DebugLog("Message:" + message);
                                        }
                                    }

                                    if (!waitingForRequest)
                                    {
                                        if (response == null)
                                        {
                                            // empty string is null
                                            ss.WriteString("", millisTimeout, stopToken.Token);
                                        }
                                        else
                                        {
                                            try
                                            {
                                                ss.WriteString(JsonConvert.SerializeObject(response), millisTimeout, stopToken.Token);
                                            }
                                            catch (JsonSerializationException e)
                                            {
                                                DebugLog("Failed to serialize response, sending null (empty string) instead");
                                                DebugLog("ERROR: " + e.Message);
                                                DebugLog("Message:" + response);
                                                ss.WriteString("", millisTimeout, stopToken.Token);
                                            }
                                        }
                                        waitingForRequest = true;
                                    }
                                }
                            }
                            // Catch the IOException that is raised if the pipe is broken
                            // or disconnected.
                            catch (IOException e)
                            {
                                DebugLog("Disconnected from client with io exception");
                                DebugLog("ERROR: " + e.Message + " " + Environment.StackTrace);
                            }
                            catch (TimeoutException e)
                            {
                                DebugLog("Timeout, disconnected from client with error");
                                DebugLog("ERROR: " + e.Message + " " + Environment.StackTrace);
                            }
                            catch (CanceledException)
                            {
                                DebugLog("Disconnected from client with CanceledException, breaking" + " " + Environment.StackTrace);
                                break;
                            }
                            catch (Exception e)
                            {
                                DebugLog("Disconnected from client with error " + e.GetType() + " " + Environment.StackTrace);
                                DebugLog("ERROR: " + e.Message);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    DebugLog("Got exception " + e.Message + " " + Environment.StackTrace);
                }
            });

            monitoringThread.Start();
        }

        public void Dispose()
        {
            if (!stopToken.IsCancellationRequested)
            {
                stopToken.Cancel();
                monitoringThread.Join();
                stopToken.Dispose();
            }
        }
    }
}
