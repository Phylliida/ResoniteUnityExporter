

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
        public byte[] valueBytes;
        public string assemblyName;
        public string typeName;
        public ResoniteBridgeValueType valueType;

        public static readonly ResoniteBridgeValue Null = new ResoniteBridgeValue();

        public ResoniteBridgeValue(byte[] valueBytes, string assemblyName, string typeName, ResoniteBridgeValueType valueType)
        {
            this.valueBytes = valueBytes;
            this.assemblyName = assemblyName;
            this.typeName = typeName;
            this.valueType = valueType;
        }

        public ResoniteBridgeValue(ResoniteBridgeValue other)
        {
            this.valueBytes = other.valueBytes;
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

        public int uuid;
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
        
        public int uuid;
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

    public class DisconnectException : Exception
    {
        
    }
}
