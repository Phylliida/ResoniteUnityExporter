using System;
using System.IO.Pipes;
using System.Threading;
using System.Threading.Tasks;

namespace NamedPipeIPC
{
   public class IpcClientConnection : IDisposable {

        ConcurrentQueueWithNotification<byte[]> bytesToSend = new ConcurrentQueueWithNotification<byte[]>();
        Thread dataThread;
        Thread pingThread;
        CancellationTokenSource parentStopTokenSource;
        CancellationTokenSource selfStopTokenSource;
        CancellationTokenSource stopToken;

        public IpcUtils.ConnectionStatus connectionStatus;
        
        public event Action OnDisconnect;
        public event Action OnConnect;
        
        public void SendBytes(byte[] bytes)
        {
            bytesToSend.Enqueue(bytes);
        }



        private string idOfServer;
        private int millisBetweenPing;
        private int timeoutMultiplier;

        IpcUtils.DebugLogType DebugLog;
        public IpcClientConnection(string idOfServer, int millisBetweenPing, int timeoutMultiplier,
            CancellationTokenSource stopToken, IpcUtils.DebugLogType DebugLog)
        {
            this.DebugLog = DebugLog;
            this.parentStopTokenSource = stopToken;
            this.selfStopTokenSource = new CancellationTokenSource();
            this.stopToken = CancellationTokenSource.CreateLinkedTokenSource(parentStopTokenSource.Token, selfStopTokenSource.Token);
            this.idOfServer = idOfServer;
            this.millisBetweenPing = millisBetweenPing;
            this.timeoutMultiplier = timeoutMultiplier;
            this.connectionStatus = IpcUtils.ConnectionStatus.WaitingForConnection;
        }
        public void Init() {
             // each connection is actually two connections
             // one that is just for sending keepalive pings
             // the other for the actual data
             
            // we need to send keepalive pings because named pipes don't have easy
            // ways of telling when connection died in certain cases
            // however if we required a keepalive ping every x seconds, that would prevent us from
            // sending large chunks of data that took more than x seconds to recieve
            // (because a timeout would be triggered, which is indistinguishable from connection dropped)

            // this "two connection" method allows us to be regularly sending keepalive pings
            // while simultaneously sending large chunks of data


             // server thread
            dataThread = new Thread(() =>
            {
                string id = idOfServer + "data";
                try
                {
                    DebugLog("Connecting to " + id);
                    // "." means local computer which is what we want
                    // PipeOptions.Asynchronous is very important!! Or ConnectAsync won't stop when stopToken is canceled
                    using (NamedPipeClientStream pipeClient =
                           new NamedPipeClientStream(".", id, PipeDirection.InOut, PipeOptions.Asynchronous))
                    {
                        pipeClient.ConnectAsync(millisBetweenPing * timeoutMultiplier, stopToken.Token).GetAwaiter().GetResult();
                        this.connectionStatus = IpcUtils.ConnectionStatus.Connected;
                        while (!stopToken.IsCancellationRequested)
                        {
                            // send messages
                            while (bytesToSend.TryDequeue(out byte[] bytes, -1, stopToken.Token))
                            {
                                if (!WriteBytes(pipeClient, new byte[] {IpcUtils.DATA_MESSAGE})
                                    || !WriteBytes(pipeClient, bytes))
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    DebugLog("Got error in connection, disconnecting:" + e.Message + e.StackTrace);
                }
                finally
                {
                    DebugLog("Terminating connection to " + id);
                    selfStopTokenSource.Cancel();
                }
            });

            pingThread = new Thread(() =>
            {
                string id = idOfServer + "ping";
                try
                {
                    DebugLog("Connecting to " + id);
                    // "." means local computer which is what we want
                    // PipeOptions.Asynchronous is very important!! Or ConnectAsync won't stop when stopToken is canceled
                    using (NamedPipeClientStream pipeClient =
                           new NamedPipeClientStream(".", id, PipeDirection.InOut, PipeOptions.Asynchronous))
                    {
                        pipeClient.ConnectAsync(millisBetweenPing * timeoutMultiplier, stopToken.Token).GetAwaiter().GetResult();
                        this.connectionStatus = IpcUtils.ConnectionStatus.Connected;
                        OnConnect?.Invoke();
                        while (!stopToken.IsCancellationRequested)
                        {
                            // keepalive ping
                            if (!SendPing(pipeClient, millisBetweenPing))
                            {
                                break;
                            }
                            Task.Delay(millisBetweenPing, stopToken.Token).GetAwaiter().GetResult();
                        }
                    }
                }
                catch (Exception e)
                {
                    DebugLog("Got error in connection, disconnecting:" + e.Message + e.StackTrace);
                }
                finally
                {
                    DebugLog("Terminating connection to " + id);
                    this.connectionStatus = IpcUtils.ConnectionStatus.Terminated;
                    selfStopTokenSource.Cancel();
                    OnDisconnect?.Invoke();
                }
            });

            dataThread.Start();
            pingThread.Start();
        }

        public void Dispose()
        {
            selfStopTokenSource.Cancel();
            dataThread.Join();
            pingThread.Join();
            bytesToSend.Dispose();
            selfStopTokenSource.Dispose();
        }

        /// <summary>
        /// sends dummy message to let them know we are still connected
        /// </summary>
        /// <param name="ioStream"></param>
        /// <param name="millisTimeout"></param>
        /// <returns></returns>
        public bool SendPing(System.IO.Stream ioStream, int millisTimeout)
        {
            DebugLog("Sending ping to " + this.idOfServer);
            using (CancellationTokenSource timeoutSource = new CancellationTokenSource(millisTimeout))
            {
                using (CancellationTokenSource mergedSource = CancellationTokenSource.CreateLinkedTokenSource(timeoutSource.Token, this.stopToken.Token)) {
                    try {
                        byte[] kindBytes = new byte[] {IpcUtils.PING_MESSAGE};
                        IpcUtils.WriteBytes(ioStream, kindBytes, 0, 1, mergedSource.Token);
                        return true;
                    }
                    // we timed out or were canceled
                    catch (IpcUtils.CanceledException canceled) {
                        return false;
                    }
                }
            }
        }

        public bool WriteBytes(System.IO.Stream ioStream, byte[] bytes) {
            try {
                byte[] kindBytes = new byte[] {IpcUtils.DATA_MESSAGE};
                IpcUtils.WriteBytes(ioStream, kindBytes, 0, 1, stopToken.Token);
                byte[] lenBytes = BitConverter.GetBytes(bytes.Length);
                IpcUtils.WriteBytes(ioStream, lenBytes, 0, 4, stopToken.Token);
                IpcUtils.WriteBytes(ioStream, bytes, 0, bytes.Length, stopToken.Token);
                return true;
            }
            // we timed out or were canceled
            catch (IpcUtils.CanceledException canceled) {
                return false;
            }
        }

    }
}