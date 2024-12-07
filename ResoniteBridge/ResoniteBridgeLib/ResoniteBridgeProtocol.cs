

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
        Null = 0,
        Serialized = 1,
        UUID = 2,
        Type = 3,
        SpecialKeyword = 4,
        Error = 5,
    }

    public interface ResoniteBridgeValueHolder
    {
        public ResoniteBridgeValue __Backing { get; set; }
    }

    public struct ResoniteBridgeValue
    {
        public string valueStr;
        public string assemblyName;
        public string typeName;
        public ResoniteBridgeValueType valueType;

        public static readonly ResoniteBridgeValue Null = new ResoniteBridgeValue();

        public ResoniteBridgeValue(string valueStr, string assemblyName, string typeName, ResoniteBridgeValueType valueType)
        {
            this.valueStr = valueStr;
            this.assemblyName = assemblyName;
            this.typeName = typeName;
            this.valueType = valueType;
        }

        public ResoniteBridgeValue(ResoniteBridgeValue other)
        {
            this.valueStr = other.valueStr;
            this.assemblyName = other.assemblyName;
            this.typeName = other.typeName;
            this.valueType = other.valueType;
        }

        public override string ToString()
        {
            var thisObj = this;
            var fields = GetType()
                .GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                .Select<FieldInfo, string>(f => $"{f.Name}={f.GetValue(thisObj)}");

            return $"{GetType().Name}: {string.Join(", ", fields)}";
        }
    }

    public class ResoniteBridgeMessage
    {

        public ResoniteBridgeMessageType messageType;

        public ResoniteBridgeValue target;

        public string name = null;

        public ResoniteBridgeValue[] inputs = null;
    }

    public enum ResoniteBridgeResponseType
    {
        Error=0,
        Success=1,
    }
    public class ResoniteBridgeResponse
    {
        public ResoniteBridgeValue response;
        public ResoniteBridgeResponseType responseType;

        public ResoniteBridgeValue[] extraResults = null;
    }

    public enum ResoniteBridgeMessageType
    {
        CallMethod = 0,
        CallMethodWithRefsAndOuts = 1,
        CallConstructor = 2,
        GetField = 3,
        SetField = 4,
        GetProperty = 5,
        SetProperty = 6,
        GetEnum = 7,
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
