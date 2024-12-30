using System;
using System.IO.Pipes;
using System.Threading;

namespace NamedPipeIPC
{
   public class IpcClientConnection : IDisposable {

        ConcurrentQueueWithNotification<byte[]> bytesToSend = new ConcurrentQueueWithNotification<byte[]>();
        Thread listenerThread;
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
            this.stopToken = stopToken;
            this.idOfServer = idOfServer;
            this.millisBetweenPing = millisBetweenPing;
            this.timeoutMultiplier = timeoutMultiplier;
            this.connectionStatus = IpcUtils.ConnectionStatus.WaitingForConnection;
        }
        public void Init() {
             // server thread
            listenerThread = new Thread(() =>
            {
                try
                {
                    DebugLog("Connecting to " + idOfServer);
                    using (NamedPipeClientStream pipeClient =
                           new NamedPipeClientStream(idOfServer))
                    {
                        pipeClient.Connect(millisBetweenPing * timeoutMultiplier);
                        this.connectionStatus = IpcUtils.ConnectionStatus.Connected;
                        OnConnect?.Invoke();
                        while (!stopToken.IsCancellationRequested)
                        {
                            // keepalive ping
                            if (!SendPing(pipeClient, millisBetweenPing))
                            {
                                break;
                            }

                            // send messages
                            while (bytesToSend.TryDequeue(out byte[] bytes, millisBetweenPing, stopToken.Token))
                            {
                                if (!WriteBytes(pipeClient, millisBetweenPing, new byte[] {IpcUtils.DATA_MESSAGE})
                                    || !WriteBytes(pipeClient, millisBetweenPing, bytes))
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
                    this.connectionStatus = IpcUtils.ConnectionStatus.Terminated;
                    stopToken.Cancel();
                    OnDisconnect?.Invoke();
                }
            });

            listenerThread.Start();
            
        }

        public void Dispose()
        {
            stopToken.Cancel();
            listenerThread.Join();
        }

        /// <summary>
        /// sends dummy message to let them know we are still connected
        /// </summary>
        /// <param name="ioStream"></param>
        /// <param name="millisTimeout"></param>
        /// <returns></returns>
        public bool SendPing(System.IO.Stream ioStream, int millisTimeout)
        {
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

        public bool WriteBytes(System.IO.Stream ioStream, int millisTimeout, byte[] bytes) {
            using (CancellationTokenSource timeoutSource = new CancellationTokenSource(millisTimeout))
            {
                using (CancellationTokenSource mergedSource = CancellationTokenSource.CreateLinkedTokenSource(timeoutSource.Token, this.stopToken.Token)) {
                    try {
                        byte[] kindBytes = new byte[] {IpcUtils.DATA_MESSAGE};
                        IpcUtils.WriteBytes(ioStream, kindBytes, 0, 1, mergedSource.Token);
                        byte[] lenBytes = BitConverter.GetBytes(bytes.Length);
                        IpcUtils.WriteBytes(ioStream, lenBytes, 0, 4, mergedSource.Token);
                        IpcUtils.WriteBytes(ioStream, bytes, 0, bytes.Length, mergedSource.Token);
                        return true;
                    }
                    // we timed out or were canceled
                    catch (IpcUtils.CanceledException canceled) {
                        return false;
                    }
                }
            }
        }

    }
}