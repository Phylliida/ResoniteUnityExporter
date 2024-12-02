

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

    public interface ResoniteBridgeValue
    {
        public string getValueStr();
        public void setValueStr(string valueStr);
        public string getAssemblyName();
        public void setAssemblyName(string assemblyName);
        public string getTypeName();
        public void setTypeName(string typeName);

        public ResoniteBridgeValueType getValueType();
        public void setValueType(ResoniteBridgeValueType valueType);
    }

    public struct StructResoniteBridgeValue : ResoniteBridgeValue
    {
        public string __valueStr;
        public string __assemblyName;
        public string __typeName;
        public ResoniteBridgeValueType __valueType;


        public StructResoniteBridgeValue(string valueStr, string assemblyName, string typeName, ResoniteBridgeValueType valueType)
        {
            this.__valueStr = valueStr;
            this.__assemblyName = assemblyName;
            this.__typeName = typeName;
            this.__valueType = valueType;
        }

        public StructResoniteBridgeValue(ResoniteBridgeValue other)
        {
            this.__valueStr = other.getValueStr();
            this.__assemblyName = other.getAssemblyName();
            this.__typeName = other.getTypeName();
            this.__valueType = other.getValueType();
        }
        public override string ToString()
        {
            var thisObj = this;
            var fields = GetType()
                .GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                .Select<FieldInfo, string>(f => $"{f.Name}={f.GetValue(thisObj)}");

            return $"{GetType().Name}: {string.Join(", ", fields)}";
        }

        public string getValueStr()
        {
            return __valueStr;
        }

        public void setValueStr(string valueStr)
        {
            this.__valueStr = valueStr;
        }

        public string getAssemblyName()
        {
            return __assemblyName;
        }

        public void setAssemblyName(string assemblyName)
        {
            this.__assemblyName = assemblyName;
        }

        public string getTypeName()
        {
            return __typeName;
        }

        public void setTypeName(string typeName)
        {
            this.__typeName = typeName;
        }

        public ResoniteBridgeValueType getValueType()
        {
            return __valueType;
        }

        public void setValueType(ResoniteBridgeValueType valueType)
        {
            this.__valueType = valueType;
        }
    }

    public class ClassResoniteBridgeValue : ResoniteBridgeValue
    {
        public string __valueStr;
        public string __assemblyName;
        public string __typeName;
        public ResoniteBridgeValueType __valueType;

        public ClassResoniteBridgeValue() {
            this.__valueStr = null;
            this.__assemblyName = null;
            this.__typeName = null;
            this.__valueType = ResoniteBridgeValueType.Null;
        }

        public ClassResoniteBridgeValue(string valueStr, string assemblyName, string typeName, ResoniteBridgeValueType valueType)
        {
            this.__valueStr = valueStr;
            this.__assemblyName = assemblyName;
            this.__typeName = typeName;
            this.__valueType = valueType;
        }

        public ClassResoniteBridgeValue(ResoniteBridgeValue other)
        {
            this.__valueStr = other.getValueStr();
            this.__assemblyName = other.getAssemblyName();
            this.__typeName = other.getTypeName();
            this.__valueType = other.getValueType();
        }
        public override string ToString()
        {
            var thisObj = this;
            var fields = GetType()
                .GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                .Select<FieldInfo, string>(f => $"{f.Name}={f.GetValue(thisObj)}");

            return $"{GetType().Name}: {string.Join(", ", fields)}";
        }

        public string getValueStr()
        {
            return __valueStr;
        }

        public void setValueStr(string valueStr)
        {
            this.__valueStr = valueStr;
        }

        public string getAssemblyName()
        {
            return __assemblyName;
        }

        public void setAssemblyName(string assemblyName)
        {
            this.__assemblyName = assemblyName;
        }

        public string getTypeName()
        {
            return __typeName;
        }

        public void setTypeName(string typeName)
        {
            this.__typeName = typeName;
        }

        public ResoniteBridgeValueType getValueType()
        {
            return __valueType;
        }

        public void setValueType(ResoniteBridgeValueType valueType)
        {
            this.__valueType = valueType;
        }
    }

    public class ResoniteBridgeMessage
    {

        public ResoniteBridgeMessageType messageType;

        public ResoniteBridgeValue target;

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
