using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NamedPipeIPC
{
    public class IpcServerConnection : IDisposable
    {
        public static Guid MakeUniqueGuid() {
            Guid guid = new Guid();
            while (File.Exists(IpcUtils.GuidToConnectionPath(guid))) {
                guid = new Guid();
            }
            return guid;
        }

        public string baseKey;
        public int millisBetweenPing;
        public Guid guid;
        public int processId;

        CancellationTokenSource stopToken;
        
        public string GetServerKey() {
            return IpcUtils.GetServerKey(baseKey, guid);
        }

        public volatile IpcUtils.ConnectionStatus connectionStatus;

        public delegate void RecievedBytesCallback(byte[] bytes);
        public event RecievedBytesCallback OnRecievedBytes;
        
        public event Action OnConnected;
        public event Action OnDisconnected;

        Thread listenerThread;
        Thread writeStatusThread;

        public IpcServerConnection(string baseKey, int millisBetweenPing, int processId,
            CancellationTokenSource stopToken)
        {
            this.baseKey = baseKey;
            this.millisBetweenPing = millisBetweenPing;
            this.processId = processId;
            this.stopToken = stopToken;
            this.connectionStatus = IpcUtils.ConnectionStatus.WaitingForConnection;
            guid = MakeUniqueGuid();

            // server thread
            listenerThread = new Thread(() =>
            {
                try
                {
                    using (NamedPipeServerStream pipeServer =
                           new NamedPipeServerStream(GetServerKey(), PipeDirection.In))
                    {
                        pipeServer.WaitForConnection();
                        OnConnected?.Invoke();
                        while (!stopToken.IsCancellationRequested)
                        {
                            // if it takes twice as long as ping time, timeout
                            IpcUtils.ResponseType responseType = ReadBytes(pipeServer, millisBetweenPing * 2, out byte[] bytes);
                            if (responseType == IpcUtils.ResponseType.Ping)
                            {

                            }
                            else if (responseType == IpcUtils.ResponseType.Data)
                            {
                                OnRecievedBytes?.Invoke(bytes);
                            }
                            else if (responseType == IpcUtils.ResponseType.Error)
                            {
                                break;
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    OnDisconnected?.Invoke();
                    this.connectionStatus = IpcUtils.ConnectionStatus.Terminated;
                    stopToken.Cancel();
                }
            });

            // server status thread
            writeStatusThread = new Thread (() =>
            {
                while (!stopToken.IsCancellationRequested) {
                    WriteServerStatus();
                    // this will immediately return if stopToken canceled
                    Task.Delay(millisBetweenPing, stopToken.Token).Wait();
                }
                // remove our file since we are closed
                File.Delete(IpcUtils.GuidToConnectionPath(this.guid));
            });

            listenerThread.Start();
            writeStatusThread.Start();
        }

        public void Dispose() {
            stopToken.Cancel();
            listenerThread.Join();
            writeStatusThread.Join();
        }


        public IpcUtils.ResponseType ReadBytes(System.IO.Stream ioSteam, int millisTimeout, out byte[] bytes) {
            using (CancellationTokenSource timeoutSource = new CancellationTokenSource(millisTimeout))
            {
                using (CancellationTokenSource mergedSource = CancellationTokenSource.CreateLinkedTokenSource(timeoutSource.Token, this.stopToken.Token)) {
                    try {
                        byte[] kindBytes = IpcUtils.ReadBytes(ioSteam, 1, mergedSource.Token);
                        if (kindBytes[0] == IpcUtils.PING_MESSAGE)
                        {
                            bytes = null;
                            return IpcUtils.ResponseType.Ping;
                        }
                        else if(kindBytes[0] == IpcUtils.DATA_MESSAGE) {
                            byte[] sizeBytes = IpcUtils.ReadBytes(ioSteam, 4, mergedSource.Token);
                            int numBytes = BitConverter.ToInt32(sizeBytes, 0);
                            bytes = IpcUtils.ReadBytes(ioSteam, numBytes, mergedSource.Token);
                            return IpcUtils.ResponseType.Data;
                        }
                        else {
                            throw new ArgumentException("Unknown message kind " + kindBytes[0]);
                        }
                    }
                    // we timed out or were canceled, terminate the connection
                    catch (IpcUtils.CanceledException canceled) {
                        bytes = null;
                        return IpcUtils.ResponseType.Error;
                    }
                }
            }
        }

        public void WriteServerStatus() {
            IpcServerInfo serverInfo = new IpcServerInfo() {
                timeOfLastUpdate = IpcUtils.TimeMillis(),
                guid = this.guid,
                processId = this.processId,
                connectionStatus = this.connectionStatus,
                baseKey = this.baseKey
            };

            File.WriteAllText(
                IpcUtils.GuidToConnectionPath(this.guid),
                JsonConvert.SerializeObject(serverInfo)
            );
        }
    }
}