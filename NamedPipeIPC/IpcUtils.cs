using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NamedPipeIPC
{
    public class IpcUtils
    {
        public static byte PING_MESSAGE = 1;
        public static byte DATA_MESSAGE = 2;

        // important none are zero because that's the default bytes recieved when connection dies
        public enum ResponseType {
            Ping=1,
            Data=2,
            Error=3
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
            int numRead = readTask.GetAwaiter().GetResult();
            if (cancelToken.IsCancellationRequested)
            {
                throw new CanceledException();
            }
            return buffer;
        }

        public static void WriteBytes(System.IO.Stream ioStream, byte[] bytes, int offset, int numToWrite, CancellationToken cancelToken)
        {
            System.Threading.Tasks.Task writeTask = ioStream.WriteAsync(bytes, offset, numToWrite, cancelToken);
            writeTask.GetAwaiter().GetResult();
            if (cancelToken.IsCancellationRequested)
            {
                throw new CanceledException();
            }
        }

        public static void Flush(System.IO.Stream ioStream, CancellationToken cancelToken)
        {
            System.Threading.Tasks.Task flushTask = ioStream.FlushAsync(cancelToken);
            flushTask.GetAwaiter().GetResult();
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

        public static int WAIT_MILLIS = 100;
        public static int NUM_RETRIES = 6;


        public static void SafeDeleteFile(string path, CancellationTokenSource stopToken)
        {
            for (int i = 0; i < NUM_RETRIES && File.Exists(path); i++)
            {
                try
                {
                    File.Delete(path);
                }
                catch (Exception e)
                {
                    if (i == NUM_RETRIES - 1)
                    {
                        throw e;
                    }
                    else
                    {
                        try
                        {
                            Task.Delay(WAIT_MILLIS, stopToken.Token).GetAwaiter().GetResult();
                        }
                        catch (TaskCanceledException)
                        {
                            return;
                        }
                        catch (OperationCanceledException)
                        {
                            return;
                        }
                    }
                }
            }
        }

        public static string SafeReadAllText(string path, CancellationTokenSource stopToken)
        {
            for (int i = 0; i < NUM_RETRIES; i++)
            {
                try
                {
                    using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                    using (var sr = new StreamReader(fs))
                    {
                        return sr.ReadToEnd();
                    }
                }
                catch (Exception e)
                {
                    if (i == NUM_RETRIES - 1)
                    {
                        throw e;
                    }
                    else
                    {
                        try
                        {
                            Task.Delay(WAIT_MILLIS, stopToken.Token).GetAwaiter().GetResult();
                        }
                        catch (TaskCanceledException)
                        {
                            return null;
                        }
                        catch (OperationCanceledException)
                        {
                            return null;
                        }
                    }
                }
            }
            // fail to read
            return null;
        }

        public delegate void DebugLogType(string msg);

        public static void SafeWriteAllText(string path, string contents, CancellationTokenSource stopToken)
        {
            // we need this retry logic because other stuff might be trying to access it
            for (int i = 0; i < NUM_RETRIES; i++)
            {
                try
                {
                    using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                    using (var sw = new StreamWriter(fs))
                    {
                        sw.Write(contents);
                        return;
                    }
                }
                catch (Exception e)
                {
                    if (i == NUM_RETRIES - 1)
                    {
                        throw e;
                    }
                    else
                    {
                        try
                        {
                            Task.Delay(WAIT_MILLIS, stopToken.Token).GetAwaiter().GetResult();
                        }
                        catch (TaskCanceledException)
                        {
                            return;
                        }
                        catch (OperationCanceledException)
                        {
                            return;
                        }
                    }
                }
            }
         }

        /// <summary>
        /// Fetches loaded servers from the config files
        /// </summary>
        /// <param name="keepaliveMillis">How long since last update we allow before a server is ignored</param>
        public static IEnumerable<IpcServerInfo> GetLoadedServers(long keepAliveMillis, CancellationTokenSource stopToken) {
            List<IpcServerInfo> servers = new List<IpcServerInfo>();
            foreach (string server in Directory.GetFiles(GetServerDirectory(), "*.json")) {
                try {
                    string text = SafeReadAllText(server, stopToken);
                    if (text != null)
                    {
                        IpcServerInfo info = JsonConvert.DeserializeObject<IpcServerInfo>(text);
                        long timeSinceUpdated = TimeMillis() - info.timeOfLastUpdate;
                        if (timeSinceUpdated < keepAliveMillis)
                        {
                            servers.Add(info);
                        }
                        // cleanup very old ones so directory not cluttered
                        else if (timeSinceUpdated > keepAliveMillis * 4)
                        {
                            File.Delete(server);
                        }
                    }
                }
                catch (JsonSerializationException e) {
                    
                }
            }

            return servers;
        }
    }
}