using Newtonsoft.Json;
using ResoniteBridge;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using NamedPipeIPC;
using TwitchLib.Api.Helix.Models.Moderation.CheckAutoModStatus.Request;

namespace ResoniteBridge
{
    public class ResoniteBridgeServer
    {
        public const string NAMED_SOCKET_KEY = "ResoniteCustomBridge";

        public const int millisBetweenPing = 1000;

        private volatile int curMessageId = 0;

        public IpcPublisher publisher;
        public IpcSubscriber subscriber;

        CancellationTokenSource stopToken;

        public delegate void LogDelegate(string message);

        private ConcurrentQueueWithNotification<ResoniteBridgeResponse> outputMessages = new ConcurrentQueueWithNotification<ResoniteBridgeResponse>();

        private Thread sendingThread;
        private Thread recievingThread;
        
        public delegate ResoniteBridgeResponse MessageProcessor(ResoniteBridgeMessage message);

        public void ProcessMessageAsync(ResoniteBridgeMessage message,
            MessageProcessor messageProcessor, int timeout = -1)
        {
            Thread processThread = new Thread(() =>
            {
                ProcessMessageSync(message, messageProcessor, timeout);
            });
            processThread.Start();
        }
        
        public void ProcessMessageSync(ResoniteBridgeMessage message,
            MessageProcessor messageProcessor, int timeout = -1)
        {
            Task<ResoniteBridgeResponse> processingTask = Task.Run(() => messageProcessor(message), stopToken.Token);
        
            // Create a task for disconnect event
            Task disconnectTask = Task.Run(() => publisher.disconnectEvent.WaitOne(), stopToken.Token);

            Task timeoutTask = Task.Delay(timeout, stopToken.Token);
            
            // Wait for the first task to complete
            Task completedTask = Task.WhenAny(
                processingTask,
                disconnectTask,
                timeoutTask
            );
            
            if (stopToken.IsCancellationRequested)
            {
                throw new CanceledException();
            }
            else if (completedTask == disconnectTask)
            {
                throw new DisconnectException();
            }
            else if (completedTask == timeoutTask)
            {
                throw new TimeoutException();
            }
            else
            {
                ResoniteBridgeResponse response = processingTask.GetAwaiter().GetResult();
                response.uuid = message.uuid;
                outputMessages.Enqueue(response);
            }
        }

        public ResoniteBridgeServer(LogDelegate DebugLog, MessageProcessor messageProcessor)
        {
            stopToken = new CancellationTokenSource();
            publisher = new IpcPublisher(NAMED_SOCKET_KEY, millisBetweenPing);
            subscriber = new IpcSubscriber(NAMED_SOCKET_KEY, millisBetweenPing);
            
            recievingThread = new Thread(() =>
            {
                while (!stopToken.IsCancellationRequested)
                {
                    WaitHandle.WaitAny(new WaitHandle[] { stopToken.Token.WaitHandle, subscriber.connectEvent });
                    if (stopToken.IsCancellationRequested)
                    {
                        break;
                    }
                    string message = ReadString(subscriber, Timeout.Infinite, stopToken.Token);
                    try
                    {
                        ResoniteBridgeMessage parsedMessage =
                            JsonConvert.DeserializeObject<ResoniteBridgeMessage>(message);
                        ProcessMessageAsync(parsedMessage, messageProcessor);
                    }
                    catch (JsonSerializationException e)
                    {
                        DebugLog("Failed to deserialize message, ignoring");
                        DebugLog("ERROR: " + e.Message);
                        DebugLog("Message: " + message);
                    }
                }
            });
            
            // network monitoring thread
            sendingThread = new Thread(() =>
            {
                while (!stopToken.IsCancellationRequested)
                {
                    // Read the request from the client. Once the client has
                    // written to the pipe its security token will be available.

                    outputMessages.TryDequeue(out ResoniteBridgeResponse response, -1, stopToken.Token);
                    // wait for publisher to connect
                    WaitHandle.WaitAny(new WaitHandle[] { stopToken.Token.WaitHandle, publisher.connectEvent });
                    if (stopToken.IsCancellationRequested)
                    {
                        break;
                    }

                    try
                    {
                        WriteString(publisher, JsonConvert.SerializeObject(response), Timeout.Infinite,
                            stopToken.Token);
                    }
                    catch (JsonSerializationException e)
                    {
                        DebugLog("Failed to serialize response, ignoring");
                        DebugLog("ERROR: " + e.Message);
                        DebugLog("Message:" + response);
                    }
                }
            });
            
            sendingThread.Start();
            recievingThread.Start();
        }

        public void Dispose()
        {
            if (!stopToken.IsCancellationRequested)
            {
                stopToken.Cancel();
                sendingThread.Join();
                recievingThread.Join();
                stopToken.Dispose();
            }
        }
    }
}
