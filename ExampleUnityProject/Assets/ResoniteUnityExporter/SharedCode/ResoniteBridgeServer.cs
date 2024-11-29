using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ResoniteBridge
{
    public class ResoniteBridgeServer : IDisposable
    {
        public const string NAMED_SOCKET_KEY = "ResoniteCustomBridge";

        Thread monitoringThread;

        public CancellationTokenSource stopToken;
        public delegate void LogDelegate(string message);

        public ConcurrentQueue<ResoniteBridgeMessage> inputMessages = new ConcurrentQueue<ResoniteBridgeMessage>();
        public ConcurrentQueue<ResoniteBridgeValue> outputMessages = new ConcurrentQueue<ResoniteBridgeValue>();
        public ResoniteBridgeServer (LogDelegate DebugLog)
        {
            stopToken = new CancellationTokenSource();
            int timeout = 10000;
            // network monitoring thread
            monitoringThread = new Thread(() =>
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
                                    string message = ss.ReadString(timeout);
                                    try
                                    {
                                        DebugLog("Got string " + message);
                                        ResoniteBridgeMessage parsedMessage = JsonConvert.DeserializeObject<ResoniteBridgeMessage>(message);
                                        inputMessages.Enqueue(parsedMessage);
                                        Stopwatch elapsed = new Stopwatch();
                                        while (!outputMessages.TryDequeue(out response) && !stopToken.IsCancellationRequested)
                                        {
                                            if (elapsed.ElapsedMilliseconds > timeout)
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
                                        ss.WriteString("", timeout);
                                    }
                                    else
                                    {
                                        try
                                        {
                                            ss.WriteString(JsonConvert.SerializeObject(response), timeout);
                                        }
                                        catch (JsonSerializationException e)
                                        {
                                            DebugLog("Failed to serialize response, sending null (empty string) instead");
                                            DebugLog("ERROR: " + e.Message);
                                            DebugLog("Message:" + response);
                                            ss.WriteString("", timeout);
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
                            DebugLog("ERROR: " + e.Message);
                        }
                        catch (TimeoutException e)
                        {
                            DebugLog("Timeout, disconnected from client with error");
                            DebugLog("ERROR: " + e.Message);
                        }
                        catch (Exception e)
                        {
                            DebugLog("Disconnected from client with error " + e.GetType());
                            DebugLog("ERROR: " + e.Message);
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
