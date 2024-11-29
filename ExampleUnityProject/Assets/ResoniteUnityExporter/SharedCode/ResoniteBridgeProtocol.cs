

using System.IO;
using System.Text;
using System;
using System.Threading;

namespace ResoniteBridge
{
    public enum ResoniteBridgeValueType
    {
        Serialized = 0,
        UUID = 1,
        Type = 2,
        SpecialKeyword = 3,
    }

    public class ResoniteBridgeValue
    {
        public string valueStr = null;
        public string assemblyName = null;
        public string typeName = null;
        public ResoniteBridgeValueType valueType = ResoniteBridgeValueType.Serialized;
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
        CallStaticMethod = 1,
        GetField = 2,
        SetField = 3,
        GetProperty = 4,
        SetProperty = 5,
        GetEnum = 6,
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

        public byte[] ReadBytes(int numBytes, int millisTimeout)
        {
            using (CancellationTokenSource timeoutSource = new CancellationTokenSource(millisTimeout))
            {
                byte[] buffer = new byte[numBytes];
                System.Threading.Tasks.Task<int> readTask = ioStream.ReadAsync(buffer, 0, numBytes, timeoutSource.Token);
                readTask.Wait();
                if (timeoutSource.IsCancellationRequested)
                {
                    throw new TimeoutException("Read timed out at only " + readTask.Result + " bytes read");
                }
                return buffer;
            }
        }

        public string ReadString(int millisTimeout)
        {
            byte[] lenBytes = ReadBytes(4, millisTimeout);
            int len = BitConverter.ToInt32(lenBytes, 0);
            byte[] stringBytes = ReadBytes(len, millisTimeout);
            return streamEncoding.GetString(stringBytes);
        }

        public void WriteBytes(byte[] bytes, int offset, int numToWrite, int millisTimeout)
        {
            using (CancellationTokenSource timeoutSource = new CancellationTokenSource(millisTimeout))
            {
                System.Threading.Tasks.Task writeTask = ioStream.WriteAsync(bytes, offset, numToWrite, timeoutSource.Token);
                writeTask.Wait();
                if (timeoutSource.IsCancellationRequested)
                {
                    throw new TimeoutException("Write timed out");
                }
            }
        }

        public void Flush(int millisTimeout)
        {
            using (CancellationTokenSource timeoutSource = new CancellationTokenSource(millisTimeout))
            {
                System.Threading.Tasks.Task flushTask = ioStream.FlushAsync(timeoutSource.Token);
                flushTask.Wait();
                if (timeoutSource.IsCancellationRequested)
                {
                    throw new TimeoutException("Flush timed out");
                }
            }
        }

        public int WriteString(string outString, int millisTimeout)
        {
            byte[] outBuffer = streamEncoding.GetBytes(outString);
            int len = outBuffer.Length;
            byte[] lenBytes = BitConverter.GetBytes(len);
            WriteBytes(lenBytes, 0, lenBytes.Length, millisTimeout);
            WriteBytes(outBuffer, 0, outBuffer.Length, millisTimeout);
            Flush(millisTimeout);
            return outBuffer.Length + lenBytes.Length;
        }
    }
}
