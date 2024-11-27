using Newtonsoft.Json;
using ResoniteDataWrapper;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ResoniteBridgeClient
{
    public class ResoniteBridgeClient
    {
        public const string NAMED_SOCKET_KEY = "ResoniteCustomBridge";

        Thread monitoringThread;

        public volatile bool running = true;

        public ConcurrentQueue<ResoniteBridgeMessage> inputMessages = new ConcurrentQueue<ResoniteBridgeMessage>();
        public ConcurrentQueue<ResoniteBridgeValue> outputMessages = new ConcurrentQueue<ResoniteBridgeValue>();
        public ResoniteBridgeClient()
        {
            // this is a bit cursed but it lets us avoid having to pass client into all calls so I think it's ok
            ResoniteBridgeClientWrappers.client = this;

            // network monitoring thread
            monitoringThread = new Thread(() =>
            {
                bool waitingForResponse = false;

                while (running)
                {
                    using (NamedPipeServerStream pipeServer =
                        new NamedPipeServerStream(NAMED_SOCKET_KEY, PipeDirection.InOut))
                    {

                        Console.WriteLine("Waiting for connection to Resonite");

                        pipeServer.WaitForConnection();

                        Console.WriteLine("Connected to Resonite");
                        try
                        {
                            // Read the request from the client. Once the client has
                            // written to the pipe its security token will be available.

                            StreamString ss = new StreamString(pipeServer);
                            // Verify our identity to the connected client using a
                            // string that the client anticipates.
                            while (running)
                            {
                                if (!waitingForResponse)
                                {
                                    ResoniteBridgeMessage message;
                                    while (!inputMessages.TryDequeue(out message) && running)
                                    {
                                        Thread.Sleep(1);
                                    }
                                    try
                                    {
                                        ss.WriteString(JsonConvert.SerializeObject(message));
                                        waitingForResponse = true;
                                    }
                                    catch (JsonSerializationException e)
                                    {
                                        Console.WriteLine("Failed to serialize message, ignoring");
                                        Console.WriteLine("ERROR: {0}", e.Message);
                                        Console.WriteLine("Message:" + message);
                                    }
                                }
                                if (waitingForResponse)
                                {
                                    string result = ss.ReadString();
                                    ResoniteBridgeValue parsedResult = null;
                                    if (result != "")
                                    {
                                        try
                                        {
                                            // If failed to deserialize, send null but warn in console
                                            // (todo: maybe this throws error?)
                                            parsedResult = JsonConvert.DeserializeObject<ResoniteBridgeValue>(result);
                                        }
                                        catch (JsonSerializationException e)
                                        {
                                            Console.WriteLine("Failed to deserialize result, sending null instead");
                                            Console.WriteLine("ERROR: {0}", e.Message);
                                            Console.WriteLine("Message:" + result);
                                        }
                                    }
                                    outputMessages.Enqueue(parsedResult);
                                    waitingForResponse = false;
                                }
                            }
                        }
                        // Catch the IOException that is raised if the pipe is broken
                        // or disconnected.
                        catch (IOException e)
                        {
                            Console.WriteLine("Disconnected from Resonite with error");
                            Console.WriteLine("ERROR: {0}", e.Message);
                        }
                    }
                }
            });

            monitoringThread.Start();
        }

        public void Dispose()
        {
            running = false;
            monitoringThread.Join();
        }
    }
}
