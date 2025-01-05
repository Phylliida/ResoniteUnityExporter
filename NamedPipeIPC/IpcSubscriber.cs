using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
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
                    CheckListeners();
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
            connection.OnRecievedBytes += (byte[] bytes) =>
            {
                DebugLog("Recieved bytes in handler " + bytes.Length);
                this.RecievedBytes?.Invoke(bytes);
            };
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
            bool anyAreWaiting = false;
            lock(connectEventLock)
            {
                anyAreWaiting = connections.Any(
                    (c) =>
                        c.connectionStatus == IpcUtils.ConnectionStatus.WaitingForConnection);
            }
            if (!anyAreWaiting)
            {
                AddNewListener();
            }
            
            // remove all terminated connections from bag and dispose them
            lock(connectEventLock)
            {
                List<IpcServerConnection> terminatedConnections = new List<IpcServerConnection>();
                ConcurrentBag<IpcServerConnection> cleanedBag = new ConcurrentBag<IpcServerConnection>();
                foreach (IpcServerConnection connection in connections)
                {
                    if (connection.connectionStatus == ConnectionStatus.Terminated)
                    {
                        terminatedConnections.Add(connection);
                    }
                    else
                    {
                        cleanedBag.Add(connection);
                    }
                }
                connections = cleanedBag;
                // need to terminate in seperate thread since we may be currently executing
                // within one of the threads that we need to join on dispose
                if (terminatedConnections.Count > 0)
                {
                    new Thread(() =>
                    {
                        // dispose all terminated connections
                        foreach (IpcServerConnection terminatedConnection in terminatedConnections)
                        {
                            DebugLog("Disposing server connection: " + terminatedConnection.GetServerKey());
                            terminatedConnection.Dispose();
                        }
                    }).Start();
                }
            }
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
            connectEvent.Dispose();
            disconnectEvent.Dispose();
            stopToken.Dispose();
        }
    }
}