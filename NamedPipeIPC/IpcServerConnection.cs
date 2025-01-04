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
                    using (NamedPipeServerStreamDotNet pipeServer =
                           new NamedPipeServerStreamDotNet(id, PipeDirectionDotNet.InOut, 1, PipeTransmissionModeDotNet.Byte, PipeOptionsDotNet.Asynchronous))
                    {
                        pipeServer.WaitForConnectionAsync(stopToken.Token).GetAwaiter().GetResult();
                        
                        // not supported in resonite's dot net
                        //pipeServer.WaitForConnectionAsync(stopToken.Token).GetAwaiter().GetResult();

                        while (!stopToken.IsCancellationRequested)
                        {
                            // if it takes twice as long as ping time, timeout
                            IpcUtils.ResponseType responseType = ReadBytes(pipeServer, -1, out byte[] bytes);
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
                    DebugLog("Got exception in server, disconnecting " + e.Message + " " + e.StackTrace);
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
                    using (NamedPipeServerStreamDotNet pipeServer =
                           new NamedPipeServerStreamDotNet(id, PipeDirectionDotNet.InOut, 1, PipeTransmissionModeDotNet.Byte, PipeOptionsDotNet.Asynchronous))
                    {
                        pipeServer.WaitForConnectionAsync(stopToken.Token).GetAwaiter().GetResult();

                        this.connectionStatus = IpcUtils.ConnectionStatus.Connected;
                        OnConnect?.Invoke();
                        while (!stopToken.IsCancellationRequested)
                        {
                            // if it takes twice as long as ping time, timeout
                            IpcUtils.ResponseType responseType = ReadBytes(pipeServer, millisBetweenPing * 2, out byte[] bytes);
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
                    DebugLog("Got exception in server, disconnecting " + e.Message + " " + e.StackTrace);
                }
                finally
                {
                    this.connectionStatus = IpcUtils.ConnectionStatus.Terminated;
                    selfStopTokenSource.Cancel();
                    OnDisconnect?.Invoke();
                    DebugLog("Terminating reading thread of server connected to " + id);
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
        }

        public IpcUtils.ResponseType ReadBytes(System.IO.Stream ioStream, out byte[] bytes, CancellationTokenSource readStopToken)
        {
            try
            {
                byte[] kindBytes = IpcUtils.ReadBytes(ioStream, 1, readStopToken.Token);
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
                    byte[] sizeBytes = IpcUtils.ReadBytes(ioStream, 4, readStopToken.Token);
                    int numBytes = BitConverter.ToInt32(sizeBytes, 0);
                    DebugLog(numBytes + " more bytes to read");
                    bytes = IpcUtils.ReadBytes(ioStream, numBytes, readStopToken.Token);
                    DebugLog(numBytes + " read " + bytes.Length + " more bytes");
                    return IpcUtils.ResponseType.Data;
                }
                else
                {
                    throw new ArgumentException("Unknown message kind " + kindBytes[0]);
                }
            }
            // we timed out or were canceled, terminate the connection
            catch (IpcUtils.CanceledException canceled)
            {
                bytes = null;
                return IpcUtils.ResponseType.Error;
            }
        }
        public IpcUtils.ResponseType ReadBytes(System.IO.Stream ioStream, int millisTimeout, out byte[] bytes) {
            if (millisTimeout < 0)
            {
                return ReadBytes(ioStream, out bytes, stopToken);
            }
            else
            {
                using (CancellationTokenSource timeoutSource = new CancellationTokenSource(millisTimeout))
                {
                    using (CancellationTokenSource mergedSource = CancellationTokenSource.CreateLinkedTokenSource(timeoutSource.Token, this.stopToken.Token))
                    {
                        return ReadBytes(ioStream, out bytes, mergedSource);
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