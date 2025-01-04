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


        const int BUFFER_SIZE = 2048 * 16;
        const int PING_BUFFER_SIZE = 128;

        volatile MemoryMappedFileConnection dataClient;
        volatile MemoryMappedFileConnection pingClient;
        object cleanupLock = new object();

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
                    dataClient = new MemoryMappedFileConnection(id, BUFFER_SIZE, isWriter: true);

                    dataClient.WaitForConnection(stopToken.Token, millisBetweenPing * timeoutMultiplier);
                    this.connectionStatus = IpcUtils.ConnectionStatus.Connected;
                    while (!stopToken.IsCancellationRequested)
                    {
                        // send messages
                        while (bytesToSend.TryDequeue(out byte[] bytes, -1, stopToken.Token))
                        {
                            WriteBytes(dataClient, bytes);
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
                    pingClient = new MemoryMappedFileConnection(id, PING_BUFFER_SIZE, isWriter: true);
                    pingClient.WaitForConnection(stopToken.Token, millisBetweenPing * timeoutMultiplier);
                    this.connectionStatus = IpcUtils.ConnectionStatus.Connected;
                    OnConnect?.Invoke();
                    while (!stopToken.IsCancellationRequested)
                    {
                        // keepalive ping
                        SendPing(pingClient, millisBetweenPing);
                        Task.Delay(millisBetweenPing, stopToken.Token).GetAwaiter().GetResult();
                    }
                }
                catch (Exception e)
                {
                    DebugLog("Got error in connection, disconnecting:" + e.GetType() + " " + e.Message + e.StackTrace);
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
            // disposing them will interrupt attempts to connect/send message
            if (dataClient != null)
            {
                dataClient.Dispose();
                dataClient = null;
            }
            if (pingClient != null)
            {
                pingClient.Dispose();
                pingClient = null;
            }
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
        public void SendPing(MemoryMappedFileConnection connection, int millisTimeout)
        {
            byte[] kindBytes = new byte[] { IpcUtils.PING_MESSAGE };
            connection.WriteData(kindBytes, 0, 1, stopToken.Token, millisTimeout);
        }

        public void WriteBytes(MemoryMappedFileConnection connection, byte[] bytes, int millisTimeout=-1) {
            byte[] kindBytes = new byte[] {IpcUtils.DATA_MESSAGE};
            connection.WriteData(kindBytes, 0, 1, stopToken.Token, millisTimeout);
            byte[] lenBytes = BitConverter.GetBytes(bytes.Length);
            connection.WriteData(lenBytes, 0, 4, stopToken.Token, millisTimeout);
            connection.WriteData(bytes, 0, bytes.Length, stopToken.Token, millisTimeout);
        }

    }
}