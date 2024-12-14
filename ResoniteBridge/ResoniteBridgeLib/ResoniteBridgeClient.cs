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
    public class ResoniteBridgeClient
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
        private ConcurrentDictionary<int, ResoniteBridgeResponse> outputMessages = new ConcurrentDictionary<int, ResoniteBridgeResponse>();

        private Thread sendingThread;
        private Thread recievingThread;


        public ResoniteBridgeResponse SendMessageSync(ResoniteBridgeMessage message, int timeout)
        {
            int messageUuid = Interlocked.Increment(ref curMessageId);
            message.uuid = messageUuid;
            try
            {
                return SendMessageSync(message, timeout);
            }
            catch (Exception e)
            {
                ResoniteBridgeResponse response = new ResoniteBridgeResponse();
                response.uuid = messageUuid;
                response.response = new ResoniteBridgeValue();
                response.response.valueType = ResoniteBridgeValueType.Error;
                response.response.valueStr = e.Message + " " + e.StackTrace;
                response.responseType = ResoniteBridgeResponseType.Error;
                return response;
            }
        }
        public ResoniteBridgeResponse SendMessageSyncHelper(ResoniteBridgeMessage message, int timeout=-1)
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
                outputMessages.TryRemove(message.uuid, out ResoniteBridgeResponse response);
                return response;
            }
        }

        public ResoniteBridgeClient(LogDelegate DebugLog)
        {
            stopToken = new CancellationTokenSource();
            publisher = new IpcPublisher(NAMED_SOCKET_KEY, millisBetweenPing);
            subscriber = new IpcSubscriber(NAMED_SOCKET_KEY, millisBetweenPing);
            // this is a bit cursed but it lets us avoid having to pass client into all calls so I think it's ok
            ResoniteBridgeClientWrappers.client = this;
            
            // network monitoring thread
            sendingThread = new Thread(() =>
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
                        byte[] strBytes = ResoniteBridgeUtils.EncodeString(JsonConvert.SerializeObject(message));
                        publisher.Publish(strBytes);
                    }
                    catch (JsonSerializationException e)
                    {
                        DebugLog("Failed to serialize message, ignoring");
                        DebugLog("ERROR: " + e.Message);
                        DebugLog("Message:" + message);
                    }
                }
            });
            
            subscriber.RecievedBytes += (bytes) =>
            {
                string result = ResoniteBridgeUtils.DecodeString(bytes);
                try
                {
                    ResoniteBridgeResponse parsedResult =
                        JsonConvert.DeserializeObject<ResoniteBridgeResponse>(result);
                    outputMessages[parsedResult.uuid] = parsedResult;
                    outputMessageEvents[parsedResult.uuid].Set();
                }
                catch (JsonSerializationException e)
                {
                    DebugLog("Failed to deserialize result, ignoring");
                    DebugLog("ERROR: " + e.Message);
                    DebugLog("Message: " + result);
                }
            };
            
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
