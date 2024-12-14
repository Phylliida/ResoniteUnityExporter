using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NamedPipeIPC
{
    public class IpcPublisher : IDisposable
    {
        public CancellationTokenSource stopToken = new CancellationTokenSource();
        public ConcurrentDictionary<int, IpcClientConnection> connections = new ConcurrentDictionary<int, IpcClientConnection>();
        public int processId;
        public int millisBetweenPing;
        public string baseKey;

        public Thread searchThread;
        
        public ManualResetEvent connectEvent = new ManualResetEvent(false);
        public ManualResetEvent disconnectEvent = new ManualResetEvent(true);
        public object connectEventLock = new object();
        
        
        public IpcPublisher(string baseKey, int millisBetweenPing)
        {
            this.baseKey = baseKey;
            this.processId = System.Diagnostics.Process.GetCurrentProcess().Id;
            this.millisBetweenPing = millisBetweenPing;

            // occasionally check to see if new publishers are available
            // todo: use file listener api to look for changes in the server files directly
            // but for the number of servers we have, this is fine enough
            searchThread = new Thread( () =>
            {
                while (!stopToken.IsCancellationRequested)
                {
                    ConnectToAvailableServers();
                    Task.Delay(millisBetweenPing, stopToken.Token).Wait();
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
                    clientConnection.OnDisconnect += () =>
                    {
                        UpdateConnectionEvents();
                        // important we do this after reset connect event to avoid
                        // race condition where we connect between IsConnected test and reset event
                        ConnectToAvailableServers();
                    };
                    clientConnection.OnConnect += UpdateConnectionEvents;
                    clientConnection.Init();
                }
            }
        }

        public bool IsConnected()
        {
            foreach (KeyValuePair<int, IpcClientConnection> connection in connections)
            {
                if (connection.Value.connectionStatus == IpcUtils.ConnectionStatus.Connected)
                {
                    return true;
                }
            }

            return false;
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