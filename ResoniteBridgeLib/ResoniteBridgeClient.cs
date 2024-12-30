using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Threading;
using NamedPipeIPC;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ResoniteBridgeLib
{
    public class ResoniteBridgeClient : IDisposable
    {
        public const string NAMED_SOCKET_KEY = "ResoniteCustomBridge";

        public const int millisBetweenPing = 1000;

        private volatile int curMessageId = 0;

        public IpcPublisher publisher;
        public IpcSubscriber subscriber;

        CancellationTokenSource stopToken;

        public delegate void LogDelegate(string message);

        private ConcurrentQueueWithNotification<ResoniteBridgeMessage> inputMessages = new ConcurrentQueueWithNotification<ResoniteBridgeMessage>();
        private ConcurrentDictionary<int, ManualResetEvent> outputMessageEvents = new ConcurrentDictionary<int, ManualResetEvent>();
        private ConcurrentDictionary<int, ResoniteBridgeMessage> outputMessages = new ConcurrentDictionary<int, ResoniteBridgeMessage>();

        private Thread sendingThread;


        public bool IsConnected()
        {
            return publisher.IsConnected() && subscriber.IsConnected();
        }

        public delegate void MessageResponseHandler(byte[] responseBytes, bool isError);

        public void SendMessageAsync(string name, byte[] data, int timeout, MessageResponseHandler handler)
        {
            new Thread(() =>
            {
                SendMessageSync(name, data, timeout, out byte[] responseBytes, out bool isError);
                handler(responseBytes, isError);
            }).Start(); 
        }

        public void SendMessageSync(string name, byte[] data, int timeout, out byte[] responseBytes, out bool isError)
        {
            int messageUuid = Interlocked.Increment(ref curMessageId);
            ResoniteBridgeMessage message = new ResoniteBridgeMessage()
            {
                data = data,
                methodName = name,
                messageType = ResoniteBridgeValueType.Bytes,
                uuid = messageUuid,
            };
            try
            {
                ResoniteBridgeMessage responseMessage = SendMessageSyncHelper(message, timeout);
                responseBytes = responseMessage.data;
                isError = responseMessage.messageType == ResoniteBridgeValueType.Error;
            }
            catch (Exception e)
            {
                responseBytes = ResoniteBridgeUtils.EncodeString(e.Message + " " + e.StackTrace);
                isError = true;
            }
        }
        private ResoniteBridgeMessage SendMessageSyncHelper(ResoniteBridgeMessage message, int timeout=-1)
        {
            ManualResetEvent messageEvent = new ManualResetEvent(false);
            outputMessageEvents[message.uuid] = messageEvent;
            inputMessages.Enqueue(message);
            int waitedHandle = WaitHandle.WaitAny(new WaitHandle[]
            {
                stopToken.Token.WaitHandle,
                publisher.disconnectEvent,
                messageEvent
            }, timeout);

            outputMessageEvents.TryRemove(message.uuid, out _);
            messageEvent.Dispose();
            
            if (waitedHandle == 0)
            {
                throw new CanceledException();
            }
            else if (waitedHandle == 1)
            {
                throw new DisconnectException();
            }
            else if (waitedHandle == WaitHandle.WaitTimeout)
            {
                throw new TimeoutException();
            }
            else
            {
                if(outputMessages.TryRemove(message.uuid, out ResoniteBridgeMessage response))
                {
                    return response;
                }
                else
                {
                    throw new ArgumentException("Could not find output message, something went wrong");
                }
            }
        }

        public LogDelegate DebugLog;

        public ResoniteBridgeClient(LogDelegate DebugLog)
        {
            this.DebugLog = DebugLog;
            stopToken = new CancellationTokenSource();
            publisher = new IpcPublisher(NAMED_SOCKET_KEY, millisBetweenPing, (msg) => DebugLog(msg));
            subscriber = new IpcSubscriber(NAMED_SOCKET_KEY, millisBetweenPing, (msg) => DebugLog(msg));
            
            // network monitoring thread
            sendingThread = new Thread(() =>
            {
                try
                {
                    while (!stopToken.IsCancellationRequested)
                    {
                        // Read the request from the client. Once the client has
                        // written to the pipe its security token will be available.

                        inputMessages.TryDequeue(out ResoniteBridgeMessage message, -1, stopToken.Token);
                        // wait for publisher to connect
                        WaitHandle.WaitAny(new WaitHandle[] { stopToken.Token.WaitHandle, publisher.connectEvent });
                        if (stopToken.IsCancellationRequested)
                        {
                            break;
                        }
                        try
                        {
                            // we use bson to decrease communication size
                            // especially useful for arrays
                            byte[] encodedBytes = ResoniteBridgeUtils.EncodeObject(message);
                            publisher.Publish(encodedBytes);
                        }
                        catch (JsonSerializationException e)
                        {
                            DebugLog("Failed to serialize message, ignoring");
                            DebugLog("ERROR: " + e.Message);
                            DebugLog("Message:" + message);
                        }
                    }
                }
                catch(TaskCanceledException)
                {

                }
                catch (OperationCanceledException)
                {

                }
            });
            
            subscriber.RecievedBytes += (bytes) =>
            {
                try
                {
                    ResoniteBridgeMessage parsedResult = (ResoniteBridgeMessage)ResoniteBridgeUtils.DecodeObject(
                        bytes, typeof(ResoniteBridgeMessage));
                    outputMessages[parsedResult.uuid] = parsedResult;
                    outputMessageEvents[parsedResult.uuid].Set();
                }
                catch (JsonSerializationException e)
                {
                    DebugLog("Failed to deserialize result, ignoring");
                    DebugLog("ERROR: " + e.Message);
                    DebugLog("Message: " + bytes);
                }
            };
            
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
            inputMessages.Dispose();
        }
    }
}
