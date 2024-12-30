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
            Guid guid = Guid.NewGuid();
            while (File.Exists(IpcUtils.GuidToConnectionPath(guid))) {
                guid = Guid.NewGuid();
            }
            return guid;
        }

        public string baseKey;
        public int millisBetweenPing;
        public Guid guid;
        public int processId;

        CancellationTokenSource parentStopToken;
        CancellationTokenSource selfStopTokenSource;
        CancellationTokenSource stopToken;

        public string GetServerKey() {
            return IpcUtils.GetServerKey(baseKey, guid);
        }

        public volatile IpcUtils.ConnectionStatus connectionStatus;

        public delegate void RecievedBytesCallback(byte[] bytes);
        public event RecievedBytesCallback OnRecievedBytes;
        
        public event Action OnConnect;
        public event Action OnDisconnect;

        Thread listenerThread;
        Thread writeStatusThread;
        IpcUtils.DebugLogType DebugLog;
        public IpcServerConnection(string baseKey, int millisBetweenPing, int processId,
            CancellationTokenSource stopToken, IpcUtils.DebugLogType DebugLog)
        {
            this.DebugLog = DebugLog;
            this.baseKey = baseKey;
            this.millisBetweenPing = millisBetweenPing;
            this.processId = processId;
            this.parentStopToken = stopToken;
            this.selfStopTokenSource = new CancellationTokenSource();
            this.stopToken = CancellationTokenSource.CreateLinkedTokenSource(this.selfStopTokenSource.Token, this.parentStopToken.Token);
            this.connectionStatus = IpcUtils.ConnectionStatus.WaitingForConnection;
            guid = MakeUniqueGuid();
        }

        public AutoResetEvent doneProcessing = new AutoResetEvent(false);

        public void Init() {
            // server thread
            listenerThread = new Thread(() =>
            {
                try
                {
                    DebugLog("Creating server with key " + GetServerKey());
                    using (NamedPipeServerStream pipeServer =
                           new NamedPipeServerStream(GetServerKey()))
                    {
                        IAsyncResult connectionResult = pipeServer.BeginWaitForConnection((IAsyncResult iar) =>
                        {
                            try
                            {
                                NamedPipeServerStream serverStream =
                                    (NamedPipeServerStream)iar.AsyncState;

                                this.connectionStatus = IpcUtils.ConnectionStatus.Connected;
                                OnConnect?.Invoke();
                                while (!stopToken.IsCancellationRequested)
                                {
                                    // if it takes twice as long as ping time, timeout
                                    IpcUtils.ResponseType responseType = ReadBytes(serverStream, millisBetweenPing * 2, out byte[] bytes);
                                    if (responseType == IpcUtils.ResponseType.Ping)
                                    {
                                        DebugLog("Got ping from " + GetServerKey());
                                    }
                                    else if (responseType == IpcUtils.ResponseType.Data)
                                    {
                                        OnRecievedBytes?.Invoke(bytes);
                                    }
                                    else if (responseType == IpcUtils.ResponseType.Error)
                                    {
                                        DebugLog("Got error from " + GetServerKey());
                                        break;
                                    }
                                }
                            }
                            catch (Exception e)
                            {
                                DebugLog("Got exception in server, disconnecting " + e.Message + " " + e.StackTrace);
                            }
                            finally
                            {
                                // trigger the waiter below to pass through
                                doneProcessing.Set();
                            }
                        }, pipeServer);

                        int handleIndex = WaitHandle.WaitAny(new[] { stopToken.Token.WaitHandle, connectionResult.AsyncWaitHandle });

                        if (handleIndex == 0)
                        {
                            DebugLog("Canceled, bailing");   
                        }
                        else if(handleIndex == 1)
                        {
                            pipeServer.EndWaitForConnection(connectionResult);
                            // wait for the handler to be done
                            int handleIndexProcessing = WaitHandle.WaitAny(new[] { stopToken.Token.WaitHandle, doneProcessing });
                        }
                    }
                }
                catch (Exception e)
                {
                    DebugLog("Got exception in server, disconnecting " + e.Message + " " + e.StackTrace);
                }
                finally
                {
                    this.connectionStatus = IpcUtils.ConnectionStatus.Terminated;
                    selfStopTokenSource.Cancel();
                    OnDisconnect?.Invoke();
                    DebugLog("Terminating reading thread of server connected to " + GetServerKey());
                }
            });

            // server status thread
            writeStatusThread = new Thread (() =>
            {
                try
                {
                    while (!stopToken.IsCancellationRequested)
                    {
                        WriteServerStatus();
                        // this will immediately return if stopToken canceled
                        Task.Delay(millisBetweenPing, stopToken.Token).GetAwaiter().GetResult();
                    }
                }
                catch (TaskCanceledException)
                {

                }
                catch (OperationCanceledException)
                {

                }
                // remove our file since we are closed
                File.Delete(IpcUtils.GuidToConnectionPath(this.guid));
                DebugLog("Terminating write status thread of server connected to " + GetServerKey());
            });

            listenerThread.Start();
            writeStatusThread.Start();
        }

        public void Dispose() {
            selfStopTokenSource.Cancel();
            listenerThread.Join();
            writeStatusThread.Join();
            selfStopTokenSource.Dispose();
            stopToken.Dispose();
            doneProcessing.Dispose();
        }


        public IpcUtils.ResponseType ReadBytes(System.IO.Stream ioSteam, int millisTimeout, out byte[] bytes) {
            using (CancellationTokenSource timeoutSource = new CancellationTokenSource(millisTimeout))
            {
                using (CancellationTokenSource mergedSource = CancellationTokenSource.CreateLinkedTokenSource(timeoutSource.Token, this.stopToken.Token)) {
                    try {
                        byte[] kindBytes = IpcUtils.ReadBytes(ioSteam, 1, mergedSource.Token);
                        if (kindBytes[0] == 0) // a zero can happen if we are disconnected (named pipes are weird like that)
                        {
                            bytes = null;
                            DebugLog("Got zero for message type, " + GetServerKey() + " is disconnected");
                            return IpcUtils.ResponseType.Error;
                        }
                        else if (kindBytes[0] == IpcUtils.PING_MESSAGE)
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

            IpcUtils.SafeWriteAllText(
                IpcUtils.GuidToConnectionPath(this.guid),
                JsonConvert.SerializeObject(serverInfo),
                stopToken
            );
        }
    }
}