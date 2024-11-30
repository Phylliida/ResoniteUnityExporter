

using System.IO;
using System.Text;
using System;
using System.Threading;
using System.Reflection;
using System.Linq;

namespace ResoniteBridge
{
    public enum ResoniteBridgeValueType
    {
        Serialized = 0,
        UUID = 1,
        Type = 2,
        SpecialKeyword = 3,
        Error = 4,
    }

    public class ResoniteBridgeValue
    {
        public string valueStr = null;
        public string assemblyName = null;
        public string typeName = null;
        public ResoniteBridgeValueType valueType = ResoniteBridgeValueType.Serialized;
        public override string ToString()
        {
            var fields = GetType()
                .GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                .Select<FieldInfo, string>(f => $"{f.Name}={f.GetValue(this)}");

            return $"{GetType().Name}: {string.Join(", ", fields)}";
        }
    }
    public class ResoniteBridgeMessage
    {

        public ResoniteBridgeMessageType messageType;

        public ResoniteBridgeValue target = null;

        public string name = null;

        public ResoniteBridgeValue[] inputs = null;
    }
    public enum ResoniteBridgeMessageType
    {
        CallMethod = 0,
        GetField = 1,
        SetField = 2,
        GetProperty = 3,
        SetProperty = 4,
        GetEnum = 5,
    }


    public class CanceledException : Exception {
    
    }


    // from https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-use-named-pipes-for-network-interprocess-communication
    public class StreamString
    {
        private System.IO.Stream ioStream;
        private UnicodeEncoding streamEncoding;

        public StreamString(System.IO.Stream ioStream)
        {
            this.ioStream = ioStream;
            streamEncoding = new UnicodeEncoding();
        }

        byte[] ReadBytes(int numBytes, CancellationToken cancelToken)
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

        public string ReadString(int millisTimeout, CancellationToken cancelToken)
        {
            using (CancellationTokenSource timeoutSource = new CancellationTokenSource(millisTimeout))
            {
                using (CancellationTokenSource mergedSource = CancellationTokenSource.CreateLinkedTokenSource(timeoutSource.Token, cancelToken))
                {
                    try
                    {
                        byte[] lenBytes = ReadBytes(4, mergedSource.Token);
                        int len = BitConverter.ToInt32(lenBytes, 0);
                        byte[] stringBytes = ReadBytes(len, mergedSource.Token);
                        return streamEncoding.GetString(stringBytes);
                    }
                    catch (CanceledException)
                    {
                        if (timeoutSource.IsCancellationRequested && !cancelToken.IsCancellationRequested)
                        {
                            throw new TimeoutException();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
            }
        }

        void WriteBytes(byte[] bytes, int offset, int numToWrite, CancellationToken cancelToken)
        {
            System.Threading.Tasks.Task writeTask = ioStream.WriteAsync(bytes, offset, numToWrite, cancelToken);
            writeTask.Wait();
            if (cancelToken.IsCancellationRequested)
            {
                throw new CanceledException();
            }
        }

        void Flush(CancellationToken cancelToken)
        {
            System.Threading.Tasks.Task flushTask = ioStream.FlushAsync(cancelToken);
            flushTask.Wait();
            if (cancelToken.IsCancellationRequested)
            {
                throw new CanceledException();
            }
        }

        public int WriteString(string outString, int millisTimeout, CancellationToken cancelToken)
        {
            using (CancellationTokenSource timeoutSource = new CancellationTokenSource(millisTimeout))
            {
                using (CancellationTokenSource mergedSource = CancellationTokenSource.CreateLinkedTokenSource(timeoutSource.Token, cancelToken))
                {
                    try
                    {
                        byte[] outBuffer = streamEncoding.GetBytes(outString);
                        int len = outBuffer.Length;
                        byte[] lenBytes = BitConverter.GetBytes(len);
                        WriteBytes(lenBytes, 0, lenBytes.Length, mergedSource.Token);
                        WriteBytes(outBuffer, 0, outBuffer.Length, mergedSource.Token);
                        Flush(mergedSource.Token);
                        return outBuffer.Length + lenBytes.Length;
                    }
                    catch (CanceledException)
                    {
                        if (timeoutSource.IsCancellationRequested && !cancelToken.IsCancellationRequested)
                        {
                            throw new TimeoutException();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
            }
        }
    }
}
