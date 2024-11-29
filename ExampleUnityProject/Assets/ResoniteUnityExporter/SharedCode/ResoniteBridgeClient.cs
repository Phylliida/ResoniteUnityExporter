using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Threading;
    
namespace ResoniteBridge
{
    public class ResoniteBridgeClient
    {
        public const string NAMED_SOCKET_KEY = "ResoniteCustomBridge";

        Thread monitoringThread;

        public CancellationTokenSource stopToken;

        public volatile bool connected = false;

        public delegate void LogDelegate(string message);

        public ConcurrentQueue<ResoniteBridgeMessage> inputMessages = new ConcurrentQueue<ResoniteBridgeMessage>();
        public ConcurrentQueue<ResoniteBridgeValue> outputMessages = new ConcurrentQueue<ResoniteBridgeValue>();
        public ResoniteBridgeClient(LogDelegate DebugLog)
        {
            stopToken = new CancellationTokenSource();
            // this is a bit cursed but it lets us avoid having to pass client into all calls so I think it's ok
            ResoniteBridgeClientWrappers.client = this;

            int millisTimeout = 10000;

            // network monitoring thread
            monitoringThread = new Thread(() =>
            {
                bool waitingForResponse = false;

                while (!stopToken.IsCancellationRequested)
                {
                    using (NamedPipeClientStream pipeClient =
                        new NamedPipeClientStream(NAMED_SOCKET_KEY))
                    {
                        try
                        {
                            DebugLog("Waiting for connection to Resonite");

                            pipeClient.Connect(millisTimeout);

                            connected = true;
                            DebugLog("Connected to Resonite");
                            // Read the request from the client. Once the client has
                            // written to the pipe its security token will be available.

                            StreamString ss = new StreamString(pipeClient);
                            // Verify our identity to the connected client using a
                            // string that the client anticipates.
                            while (!stopToken.IsCancellationRequested)
                            {
                                if (!waitingForResponse)
                                {
                                    ResoniteBridgeMessage message;
                                    while (!inputMessages.TryDequeue(out message) && !stopToken.IsCancellationRequested)
                                    {
                                        if (!pipeClient.IsConnected)
                                        {
                                            connected = false;
                                            throw new IOException("Disconnected");
                                        }
                                        Thread.Sleep(1);
                                    }
                                    try
                                    {
                                        ss.WriteString(JsonConvert.SerializeObject(message), millisTimeout, stopToken.Token);
                                        waitingForResponse = true;
                                    }
                                    catch (JsonSerializationException e)
                                    {
                                        DebugLog("Failed to serialize message, ignoring");
                                        DebugLog("ERROR: " + e.Message);
                                        DebugLog("Message:" + message);
                                    }
                                }
                                if (waitingForResponse)
                                {
                                    string result = ss.ReadString(millisTimeout, stopToken.Token);
                                    ResoniteBridgeValue parsedResult = null;
                                    if (result != "" && result != null)
                                    {
                                        try
                                        {
                                            // If failed to deserialize, send null but warn in console
                                            // (todo: maybe this throws error?)
                                            parsedResult = JsonConvert.DeserializeObject<ResoniteBridgeValue>(result);
                                            outputMessages.Enqueue(parsedResult);
                                            waitingForResponse = false;
                                        }
                                        catch (JsonSerializationException e)
                                        {
                                            DebugLog("Failed to deserialize result, sending null instead");
                                            DebugLog("ERROR: " + e.Message);
                                            DebugLog("Message: " + result);
                                        }
                                    }
                                }
                            }
                        }
                        // Catch the IOException that is raised if the pipe is broken
                        // or disconnected.
                        catch (IOException e)
                        {
                            DebugLog("Disconnected from Resonite with IOException");
                            DebugLog("ERROR: " + e.Message);
                        }
                        catch (TimeoutException e)
                        {
                            DebugLog("Disconnected from Resonite with TimeoutException");
                            DebugLog("ERROR: " + e.Message);
                        }
                        catch (CanceledException)
                        {
                            DebugLog("Disconnected from Resonite with CanceledException, breaking");
                        }
                        catch (Exception e)
                        {
                            DebugLog("Disconnected from Resonite with error " + e.GetType());
                            DebugLog("ERROR: " + e.Message);
                        }
                        finally
                        {
                            connected = false;
                            pipeClient.Close();
                        }
                    }
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
