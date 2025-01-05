using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.IO.Pipes;
using System.Security.AccessControl;
using System.Security.Principal;
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

        Thread dataThread;
        Thread pingThread;
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



        public void Init() {
            // recieve data
            dataThread = new Thread(() =>
            {
                string id = GetServerKey() + "data";
                try
                {
                    DebugLog("Creating server with key " + id);

                    // PipeOptions.Asynchronous is very important!! Or WaitForConnectionAsync won't stop when stopToken is canceled
                    // actually we just implemented our own version of that because it's not available in resonite
                    using (MemoryMappedFileConnection dataServer = new MemoryMappedFileConnection(id, IpcUtils.BUFFER_SIZE, isWriter: false))
                    {
                        dataServer.WaitForConnection(stopToken.Token);

                        // not supported in resonite's dot net
                        //pipeServer.WaitForConnectionAsync(stopToken.Token).GetAwaiter().GetResult();

                        while (!stopToken.IsCancellationRequested)
                        {
                            // if it takes twice as long as ping time, timeout
                            IpcUtils.ResponseType responseType = ReadBytes(dataServer, out byte[] bytes, stopToken);
                            if (responseType == IpcUtils.ResponseType.Ping)
                            {
                                DebugLog("Why did data thread get ping??");
                            }
                            else if (responseType == IpcUtils.ResponseType.Data)
                            {
                                DebugLog("Recieved bytes");
                                OnRecievedBytes?.Invoke(bytes);
                            }
                            else if (responseType == IpcUtils.ResponseType.Error)
                            {
                                DebugLog("Got error from " + id);
                                break;
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    DebugLog("Got exception in server, disconnecting " + e.GetType() + " " + e.Message + " " + e.StackTrace);
                }
                finally
                {
                    selfStopTokenSource.Cancel();
                    DebugLog("Terminating reading thread of server connected to " + GetServerKey());
                }
            });
            
            // recieve keepalive ping
            pingThread = new Thread(() =>
            {
                string id = GetServerKey() + "ping";
                try
                {
                    DebugLog("Creating server with key " + id);
                    // PipeOptions.Asynchronous is very important!! Or WaitForConnectionAsync won't stop when stopToken is canceled
                    using (MemoryMappedFileConnection pingServer = new MemoryMappedFileConnection(id, IpcUtils.PING_BUFFER_SIZE, isWriter: false))
                    {
                        pingServer.WaitForConnection(stopToken.Token);

                        this.connectionStatus = IpcUtils.ConnectionStatus.Connected;
                        OnConnect?.Invoke();
                        while (!stopToken.IsCancellationRequested)
                        {
                            // if it takes twice as long as ping time, timeout
                            IpcUtils.ResponseType responseType = ReadBytes(pingServer, out byte[] bytes, stopToken, millisBetweenPing * 2);
                            if (responseType == IpcUtils.ResponseType.Ping)
                            {
                                DebugLog("Got ping from " + id);
                            }
                            else if (responseType == IpcUtils.ResponseType.Data)
                            {
                                DebugLog("Got data from ping thread?? what u doin");
                                break;
                            }
                            else if (responseType == IpcUtils.ResponseType.Error)
                            {
                                DebugLog("Got error from " + id);
                                break;
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    DebugLog("Got exception in server, disconnecting " + e.GetType() + " " + e.Message + " " + e.StackTrace);
                }
                finally
                {
                    this.connectionStatus = IpcUtils.ConnectionStatus.Terminated;
                    selfStopTokenSource.Cancel();
                    OnDisconnect?.Invoke();
                    DebugLog("Terminating ping thread of server connected to " + id);
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
                IpcUtils.SafeDeleteFile(IpcUtils.GuidToConnectionPath(this.guid), this.stopToken);
                DebugLog("Terminating write status thread of server connected to " + GetServerKey());
            });

            dataThread.Start();
            pingThread.Start();
            writeStatusThread.Start();
        }

        public void Dispose() {
            selfStopTokenSource.Cancel();
            dataThread.Join();
            pingThread.Join();
            writeStatusThread.Join();
            selfStopTokenSource.Dispose();
            stopToken.Dispose();
            DebugLog("Finished disposing server " + GetServerKey());
        }

        public IpcUtils.ResponseType ReadBytes(MemoryMappedFileConnection connection, out byte[] bytes, CancellationTokenSource readStopToken, int millisTimeout=-1)
        {
            byte[] kindBytes = connection.ReadData(readStopToken.Token, millisTimeout);
            DebugLog("read bytes with kind " + kindBytes[0]);
            if (kindBytes[0] == 0) // a zero can happen if we are disconnected (named pipes are weird like that)
            {
                bytes = null;
                DebugLog("Got zero for message type, " + GetServerKey() + " is disconnected");
                return IpcUtils.ResponseType.Error;
            }
            else if (kindBytes[0] == IpcUtils.PING_MESSAGE)
            {
                DebugLog("read ping bytes");
                bytes = null;
                return IpcUtils.ResponseType.Ping;
            }
            else if (kindBytes[0] == IpcUtils.DATA_MESSAGE)
            {
                DebugLog("read data bytes");
                byte[] sizeBytes = connection.ReadData(readStopToken.Token, millisTimeout);
                int numBytes = BitConverter.ToInt32(sizeBytes, 0);
                DebugLog(numBytes + " more bytes to read");
                bytes = connection.ReadData(readStopToken.Token, millisTimeout);
                DebugLog(numBytes + " read " + bytes.Length + " more bytes");
                return IpcUtils.ResponseType.Data;
            }
            else
            {
                throw new ArgumentException("Unknown message kind " + kindBytes[0]);
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