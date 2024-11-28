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

namespace ResoniteBridge
{
    public class ResoniteBridgeServer : IDisposable
    {
        public const string NAMED_SOCKET_KEY = "ResoniteCustomBridge";

        Thread monitoringThread;

        public CancellationTokenSource stopToken = new CancellationTokenSource();

        public ConcurrentQueue<ResoniteBridgeMessage> inputMessages = new ConcurrentQueue<ResoniteBridgeMessage>();
        public ConcurrentQueue<ResoniteBridgeValue> outputMessages = new ConcurrentQueue<ResoniteBridgeValue>();
        public ResoniteBridgeServer ()
        {
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
                            while (!stopToken.IsCancellationRequested)
                            {
                                if (waitingForRequest)
                                {
                                    string message = ss.ReadString();
                                    try
                                    {
                                        ResoniteBridgeMessage parsedMessage = JsonConvert.DeserializeObject<ResoniteBridgeMessage>(message);
                                        inputMessages.Enqueue(parsedMessage);
                                        while (!outputMessages.TryDequeue(out response) && !stopToken.IsCancellationRequested)
                                        {
                                            Thread.Sleep(1);
                                        }
                                        waitingForRequest = false;
                                    }
                                    catch (JsonSerializationException e)
                                    {
                                        Console.WriteLine("Failed to serialize message, ignoring");
                                        Console.WriteLine("ERROR: {0}", e.Message);
                                        Console.WriteLine("Message:" + message);
                                    }
                                }
                                
                                if (!waitingForRequest)
                                {
                                    if (response == null)
                                    {
                                        // empty string is null
                                        ss.WriteString("");
                                    }
                                    else
                                    {
                                        try
                                        {
                                            ss.WriteString(JsonConvert.SerializeObject(response));
                                        }
                                        catch (JsonSerializationException e)
                                        {
                                            Console.WriteLine("Failed to serialize response, sending null (empty string) instead");
                                            Console.WriteLine("ERROR: {0}", e.Message);
                                            Console.WriteLine("Message:" + response);
                                            ss.WriteString("");
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
                            Console.WriteLine("Disconnected from unity with error");
                            Console.WriteLine("ERROR: {0}", e.Message);
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
            }
        }
    }
}
