

using System.IO;
using System.Text;
using System;

namespace ResoniteDataWrapper
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
        private Stream ioStream;
        private UnicodeEncoding streamEncoding;

        public StreamString(Stream ioStream)
        {
            this.ioStream = ioStream;
            streamEncoding = new UnicodeEncoding();
        }

        public string ReadString()
        {
            int len = 0;

            len = ioStream.ReadByte() * 256;
            len += ioStream.ReadByte();
            byte[] inBuffer = new byte[len];
            ioStream.Read(inBuffer, 0, len);

            return streamEncoding.GetString(inBuffer);
        }

        public int WriteString(string outString)
        {
            byte[] outBuffer = streamEncoding.GetBytes(outString);
            int len = outBuffer.Length;
            if (len > UInt16.MaxValue)
            {
                len = (int)UInt16.MaxValue;
            }
            ioStream.WriteByte((byte)(len / 256));
            ioStream.WriteByte((byte)(len & 255));
            ioStream.Write(outBuffer, 0, len);
            ioStream.Flush();

            return outBuffer.Length + 2;
        }
    }
}
