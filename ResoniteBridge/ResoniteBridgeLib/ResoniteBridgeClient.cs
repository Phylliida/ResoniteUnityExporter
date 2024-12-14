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
        
        public ResoniteBridgeResponse SendMessageSync(ResoniteBridgeMessage message, int timeout=-1)
        {
            int messageUuid = Interlocked.Increment(ref curMessageId);
            
            message.uuid = messageUuid;

            ManualResetEvent messageEvent = new ManualResetEvent(false);
            outputMessageEvents[messageUuid] = messageEvent;
            inputMessages.Enqueue(message);
            int waitedHandle = WaitHandle.WaitAny(new WaitHandle[]
            {
                stopToken.Token.WaitHandle,
                publisher.disconnectEvent,
                messageEvent
            }, timeout);

            outputMessageEvents.TryRemove(messageUuid, out _);
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
                outputMessages.TryRemove(messageUuid, out ResoniteBridgeResponse response);
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
                        WriteString(publisher, JsonConvert.SerializeObject(message), millisTimeout,
                            stopToken.Token);
                    }
                    catch (JsonSerializationException e)
                    {
                        DebugLog("Failed to serialize message, ignoring");
                        DebugLog("ERROR: " + e.Message);
                        DebugLog("Message:" + message);
                    }
                }
            });
            
            recievingThread = new Thread(() =>
            {
                while (!stopToken.IsCancellationRequested)
                {
                    WaitHandle.WaitAny(new WaitHandle[] { stopToken.Token.WaitHandle, subscriber.connectEvent });
                    if (stopToken.IsCancellationRequested)
                    {
                        break;
                    }
                    string result = ReadString(subscriber, millisTimeout, stopToken.Token);
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
