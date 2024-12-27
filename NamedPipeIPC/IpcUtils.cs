using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Newtonsoft.Json;

namespace NamedPipeIPC
{
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
            return Path.Combine(GetServerDirectory(), guid.ToString() + ".json");
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
}