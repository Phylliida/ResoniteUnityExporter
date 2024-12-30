using Newtonsoft.Json;
using System;
using System.Threading;
using System.Threading.Tasks;
using NamedPipeIPC;
using System.Collections.Concurrent;

namespace ResoniteBridgeLib
{
    public class ResoniteBridgeServer : IDisposable
    {
        public const string NAMED_SOCKET_KEY = "ResoniteCustomBridge";

        public const int millisBetweenPing = 1000;

        private volatile int curMessageId = 0;

        public IpcPublisher publisher;
        public IpcSubscriber subscriber;

        CancellationTokenSource stopToken;

        public delegate void LogDelegate(string message);

        private ConcurrentDictionary<string, MessageProcessor> processors = new ConcurrentDictionary<string, MessageProcessor>();

        public bool TryGetProcessor(string methodName, out MessageProcessor processor)
        {
            return processors.TryGetValue(methodName, out processor);
        }

        public void RegisterProcessor(string methodName, MessageProcessor processor)
        {
            processors[methodName] = processor;
        }

        public bool TryUnregisterProcessor(string methodName, out MessageProcessor removedProcessor)
        {
            return processors.TryRemove(methodName, out removedProcessor);
        }

        private ConcurrentQueueWithNotification<ResoniteBridgeMessage> outputMessages = new ConcurrentQueueWithNotification<ResoniteBridgeMessage>();

        private Thread sendingThread;
        
        public delegate byte[] MessageProcessor(byte[] input);

        private void ProcessMessageAsync(ResoniteBridgeMessage message, int timeout = -1)
        {
            new Thread(() =>
            {
                ProcessMessageSync(message, timeout);
            }).Start();
        }

        private void ProcessMessageSync(ResoniteBridgeMessage message, int timeout = -1)
        {
            try
            {
                MessageProcessor processor;
                if (!TryGetProcessor(message.methodName, out processor))
                {
                    throw new UnknownProcessorException(message.methodName);
                }

                Task<byte[]> processingTask = Task.Run(() => processor(message.data), stopToken.Token);

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
                    byte[] responseData = processingTask.GetAwaiter().GetResult();
                    ResoniteBridgeMessage response = new ResoniteBridgeMessage()
                    {
                        data = responseData,
                        messageType = ResoniteBridgeValueType.Bytes,
                        methodName = message.methodName,
                        uuid = message.uuid
                    };
                    outputMessages.Enqueue(response);
                }
            }
            catch (Exception ex)
            {
                ResoniteBridgeMessage response = new ResoniteBridgeMessage()
                {
                    data = ResoniteBridgeUtils.EncodeString(ex.ToString() + " " + ex.StackTrace),
                    messageType = ResoniteBridgeValueType.Error,
                    methodName = message.methodName,
                    uuid = message.uuid,
                };
                outputMessages.Enqueue(response);
            }
        }

        public bool IsConnected()
        {
            return subscriber.IsConnected() && publisher.IsConnected();
        }

        public ResoniteBridgeServer(LogDelegate DebugLog)
        {
            stopToken = new CancellationTokenSource();
            publisher = new IpcPublisher(NAMED_SOCKET_KEY, millisBetweenPing, msg => DebugLog(msg));
            subscriber = new IpcSubscriber(NAMED_SOCKET_KEY, millisBetweenPing, msg => DebugLog(msg));

            subscriber.RecievedBytes += (bytes) =>
            {
                try
                {
                    ResoniteBridgeMessage parsedMessage = (ResoniteBridgeMessage)ResoniteBridgeUtils.DecodeObject(
                        bytes, typeof(ResoniteBridgeMessage));
                    ProcessMessageAsync(parsedMessage);
                }
                catch (JsonSerializationException e)
                {
                    DebugLog("Failed to deserialize message, ignoring");
                    DebugLog("ERROR: " + e.Message);
                    DebugLog("Message: " + bytes);
                }
            };
            
            // network monitoring thread
            sendingThread = new Thread(() =>
            {
                try
                {
                    while (!stopToken.IsCancellationRequested)
                    {
                        // Read the request from the client. Once the client has
                        // written to the pipe its security token will be available.

                        outputMessages.TryDequeue(out ResoniteBridgeMessage response, -1, stopToken.Token);
                        // wait for publisher to connect
                        WaitHandle.WaitAny(new WaitHandle[] { stopToken.Token.WaitHandle, publisher.connectEvent });
                        if (stopToken.IsCancellationRequested)
                        {
                            break;
                        }
                        try
                        {
                            byte[] encodedBytes = ResoniteBridgeUtils.EncodeObject(response);
                            publisher.Publish(encodedBytes);
                        }
                        catch (JsonSerializationException e)
                        {
                            DebugLog("Failed to serialize response, ignoring");
                            DebugLog("ERROR: " + e.Message);
                            DebugLog("Message:" + response);
                        }
                    }
                }
                catch (TaskCanceledException)
                {

                }
                catch (OperationCanceledException)
                {

                }
            });
            
            sendingThread.Start();
        }

        public void Dispose()
        {
            if (!stopToken.IsCancellationRequested)
            {
                stopToken.Cancel();
            }
            sendingThread.Join();
            stopToken.Dispose();
            publisher.Dispose();
            subscriber.Dispose();
            outputMessages.Dispose();
        }
    }
}
