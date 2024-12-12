using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TwitchLib.Api.Core.Extensions.System;

namespace ResoniteBridge
{
     public class ConcurrentQueueWithNotification<T> { 
        private ConcurrentQueue<T> queue = new ConcurrentQueue<T>();
        private AutoResetEvent signal = new AutoResetEvent(false);

        public void Enqueue(T item)
        {
            queue.Enqueue(item);
            signal.Set(); // Signal that queue has an item
        }

        public bool TryDequeue(out T item, int timeoutMillis, CancellationToken stopToken)
        {
            while (!stopToken.IsCancellationRequested)
            {
                if (queue.TryDequeue(out item))
                {
                    return true;
                }
                int tokenIndex = WaitHandle.WaitAny(new[] { stopToken.WaitHandle, signal }, timeoutMillis);
                // stopped
                if (tokenIndex == 0)
                {
                    throw new OperationCanceledException();
                }
                // timed out
                else if(tokenIndex == WaitHandle.WaitTimeout) {
                    item = default;
                    return false;
                }
                // recieved an entry in the queue, return it
                else if(tokenIndex == 1) {

                }
            }

            throw new OperationCanceledException();
        }

        public void Dispose()
        {
            signal.Dispose();
        }
    }
    
    public struct IpcServerInfo {
        public long timeOfLastUpdate;
        public string baseKey;
        public Guid guid;
        public int processId;
        public IpcUtils.ConnectionStatus connectionStatus;
    }
    public class IpcUtils
    {
        public static byte PING_MESSAGE = 0;
        public static byte DATA_MESSAGE = 1;

        public enum ResponseType {
            Ping,
            Data,
            Error
        }

       public enum ConnectionStatus {
            WaitingForConnection,
            Connected,
            Terminated
        }
        public class CanceledException : Exception {
        
        }


        public static string GetServerKey(string baseKey, Guid guid)
        {
            return baseKey + guid.ToString();
        }
        public static byte[] ReadBytes(System.IO.Stream ioStream, int numBytes, CancellationToken cancelToken)
        {
            byte[] buffer = new byte[numBytes];
            System.Threading.Tasks.Task<int> readTask = ioStream.ReadAsync(buffer, 0, numBytes, cancelToken);
            readTask.Wait();
            if (cancelToken.IsCancellationRequested)
            {
                throw new CanceledException();
            }
            return buffer;
        }

        public static void WriteBytes(System.IO.Stream ioStream, byte[] bytes, int offset, int numToWrite, CancellationToken cancelToken)
        {
            System.Threading.Tasks.Task writeTask = ioStream.WriteAsync(bytes, offset, numToWrite, cancelToken);
            writeTask.Wait();
            if (cancelToken.IsCancellationRequested)
            {
                throw new CanceledException();
            }
        }

        public static void Flush(System.IO.Stream ioStream, CancellationToken cancelToken)
        {
            System.Threading.Tasks.Task flushTask = ioStream.FlushAsync(cancelToken);
            flushTask.Wait();
            if (cancelToken.IsCancellationRequested)
            {
                throw new CanceledException();
            }
        }
        
        public static long TimeMillis() {
            return DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        public static string GuidToConnectionPath(Guid guid) {
            return Path.Join(GetServerDirectory(), guid.ToString() + ".json");
        }

        public static string GetServerDirectory() {
            string serverDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TefssaCoil", "ResoniteDataWrapper", "Servers");
            // make if not exists
            Directory.CreateDirectory(serverDirectory);
            return serverDirectory;

        }

        /// <summary>
        /// Fetches loaded servers from the config files
        /// </summary>
        /// <param name="keepaliveMillis">How long since last update we allow before a server is ignored</param>
        public static IEnumerable<IpcServerInfo> GetLoadedServers(long keepAliveMillis) {
            List<IpcServerInfo> servers = new List<IpcServerInfo>();
            foreach (string server in Directory.GetFiles(GetServerDirectory(), "*.json")) {
                try {
                    IpcServerInfo info = JsonConvert.DeserializeObject<IpcServerInfo>(File.ReadAllText(server));
                    long timeSinceUpdated = TimeMillis() - info.timeOfLastUpdate;
                    if  (timeSinceUpdated < keepAliveMillis) {
                        servers.Add(info);
                    }
                    // cleanup very old ones so directory not cluttered
                    else if (timeSinceUpdated > keepAliveMillis * 4) {
                        File.Delete(server);
                    }
                }
                catch (JsonSerializationException e) {
                    
                }
            }

            return servers;
        }
    }

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

        public IpcClientConnection(string idOfServer, int millisBetweenPing, int timeoutMultiplier, CancellationTokenSource stopToken) {
            this.stopToken = stopToken;
            this.connectionStatus = IpcUtils.ConnectionStatus.WaitingForConnection;
            // server thread
            listenerThread = new Thread(() =>
            {
                try
                {
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
                                if (!WriteBytes(pipeClient, millisBetweenPing, bytes))
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Got error in connection, disconnecting:" + e.Message);
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
            writeStatusThread = new Thread(async () =>
            {
                while (!stopToken.IsCancellationRequested) {
                    WriteServerStatus();
                    // this will immediately return if stopToken canceled
                    await Task.Delay(millisBetweenPing, stopToken.Token);
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

    /// <summary>
    /// One server has multiple IPCServerConnections to allow for more than one client
    /// It creates more connections as needed
    /// </summary>
    public class IpcSubscriber : IDisposable
    {
        string baseKey;
        int millisBetweenPing;
        int processId;
        
        CancellationTokenSource stopToken = new CancellationTokenSource();
        
        public volatile ConcurrentBag<IpcServerConnection> connections = new ConcurrentBag<IpcServerConnection>();
        public IpcSubscriber(string baseKey, int millisBetweenPing) {
            this.baseKey = baseKey;
            this.millisBetweenPing = millisBetweenPing;
            this.processId = System.Diagnostics.Process.GetCurrentProcess().Id;
        }

        void AddNewListener()
        {
            IpcServerConnection connection = new IpcServerConnection(
                this.baseKey,
                this.millisBetweenPing,
                this.processId,
                stopToken);
            connections.Add(connection);
            // once it connects, we need to open a new channel for new people that want to connect
            connection.OnConnected += AddNewListener;
            connection.OnDisconnected += CheckListeners;
        }

        void CheckListeners()
        {
            // if no one is waiting for connection, make a new one (maybe an error was thrown in connection attempt)
            bool anyAreWaiting = connections.Any(
                (c) =>
                    c.connectionStatus == IpcUtils.ConnectionStatus.WaitingForConnection);
            if (!anyAreWaiting)
            {
                AddNewListener();
            }
            
            // remove all terminated connections from bag
            ConcurrentBag<IpcServerConnection> cleanedBag = new ConcurrentBag<IpcServerConnection>();
            foreach (IpcServerConnection connection in connections)
            {
                if (connection.connectionStatus != IpcUtils.ConnectionStatus.Terminated)
                {
                    cleanedBag.Add(connection);
                }
            }

            connections = cleanedBag;
        }

        public void Dispose()
        {
            stopToken.Cancel();
            foreach (IpcServerConnection connection in connections)
            {
                connection.Dispose();
            }
            stopToken.Dispose();
        }
    }

    public class IpcPublisher : IDisposable
    {
        public CancellationTokenSource stopToken = new CancellationTokenSource();
        public ConcurrentDictionary<int, IpcClientConnection> connections = new ConcurrentDictionary<int, IpcClientConnection>();
        public int processId;
        public int millisBetweenPing;
        public string baseKey;

        public Thread searchThread;

        public IpcPublisher(string baseKey, int millisBetweenPing)
        {
            this.baseKey = baseKey;
            this.processId = System.Diagnostics.Process.GetCurrentProcess().Id;
            this.millisBetweenPing = millisBetweenPing;

            // occasionally check to see if new publishers are available
            // todo: use file listener api to look for changes in the server files directly
            // but for the number of servers we have, this is fine enough
            searchThread = new Thread(async () =>
            {
                while (!stopToken.IsCancellationRequested)
                {
                    ConnectToAvailableServers();
                    await Task.Delay(millisBetweenPing, stopToken.Token);
                }
            });
            searchThread.Start();
        }

        public void Publish(byte[] bytes)
        {
            foreach (KeyValuePair<int, IpcClientConnection> connection in connections)
            {
                if (connection.Value.connectionStatus == IpcUtils.ConnectionStatus.Connected)
                {
                    connection.Value.SendBytes(bytes);
                }
            }
        }
        
        void ConnectToAvailableServers() {
            foreach (IpcServerInfo server in IpcUtils.GetLoadedServers(this.millisBetweenPing * 2))
            {
                if (server.baseKey == baseKey &&
                    server.connectionStatus == IpcUtils.ConnectionStatus.WaitingForConnection &&
                    server.processId != processId &&
                    !connections.ContainsKey(server.processId))
                {
                    IpcClientConnection clientConnection = new IpcClientConnection(
                        IpcUtils.GetServerKey(server.baseKey, server.guid),
                        this.millisBetweenPing,
                        2,
                        stopToken);
                    connections[server.processId] = clientConnection;
                    // on disconnect, try to reconnect
                    clientConnection.OnDisconnect += ConnectToAvailableServers;
                }
            }
        }

        public void Dispose()
        {
            stopToken.Cancel();
            foreach (KeyValuePair<int, IpcClientConnection> connection in connections)
            {
                connection.Value.Dispose();
            }

            searchThread.Join();
        }
    }
}