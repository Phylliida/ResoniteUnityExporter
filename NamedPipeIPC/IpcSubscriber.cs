using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using static NamedPipeIPC.IpcUtils;

namespace NamedPipeIPC
{
    
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

        public event IpcServerConnection.RecievedBytesCallback RecievedBytes;
        
        
        public ManualResetEvent connectEvent = new ManualResetEvent(false);
        public ManualResetEvent disconnectEvent = new ManualResetEvent(true);
        public object connectEventLock = new object();

        DebugLogType DebugLog;

        public IpcSubscriber(string baseKey, int millisBetweenPing, DebugLogType logger) {
            this.DebugLog = logger;
            this.baseKey = baseKey;
            this.millisBetweenPing = millisBetweenPing;
            this.processId = System.Diagnostics.Process.GetCurrentProcess().Id;
            AddNewListener();
        }

        void AddNewListener()
        {
            DebugLog("Adding new ipc listener");
            IpcServerConnection connection = new IpcServerConnection(
                this.baseKey,
                this.millisBetweenPing,
                this.processId,
                stopToken,
                DebugLog);
            connections.Add(connection);
            connection.OnDisconnect += () =>
            {
                DebugLog("ipc listener " + connection.GetServerKey() + " disconnected");
                UpdateConnectionEvents();
                if (!stopToken.IsCancellationRequested)
                {
                    AddNewListener();
                }
            };
            connection.OnConnect += () =>
            {
                DebugLog("ipc listener " + connection.GetServerKey() + " connected");
                UpdateConnectionEvents();
                
                if (!stopToken.IsCancellationRequested)
                {
                    CheckListeners();
                }
            };
            // once it connects, we need to open a new channel for new people that want to connect
            connection.OnRecievedBytes += RecievedBytes;
            connection.Init();
        }

        void UpdateConnectionEvents()
        {
            // we need to lock to ensure we don't set this between the IsConnected check above and resetting
            lock (connectEventLock)
            {
                if (IsConnected())
                {
                    connectEvent.Set();
                    disconnectEvent.Reset();
                }
                else
                {
                    connectEvent.Reset();
                    disconnectEvent.Set();
                }
            }
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

        public bool IsConnected()
        {
            foreach (IpcServerConnection connection in connections)
            {
                if (connection.connectionStatus == IpcUtils.ConnectionStatus.Connected)
                {
                    return true;
                }
            }

            return false;
        }

        public void Dispose()
        {
            stopToken.Cancel();
            foreach (IpcServerConnection connection in connections)
            {
                connection.Dispose();
            }
            stopToken.Dispose();
            connectEvent.Dispose();
            disconnectEvent.Dispose();
        }
    }
}