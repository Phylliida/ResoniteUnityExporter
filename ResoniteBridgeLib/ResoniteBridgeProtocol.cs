

using System.Text;
using System;
using System.Threading;
using System.Reflection;
using System.Linq;

namespace ResoniteBridgeLib
{
    public enum ResoniteBridgeValueType
    {
        Bytes = 0,
        None = 1,
        Error = 2,
    }

    public struct ResoniteBridgeMessage
    {
        public string methodName;
        public byte[] data;
        public ResoniteBridgeValueType messageType;
        public int uuid;
    }

    public class CanceledException : Exception {
    
    }

    public class DisconnectException : Exception
    {
        
    }

    public class UnknownProcessorException : Exception
    {
        public string name;

        public UnknownProcessorException(string name)
        {
            this.name = name;
        }

    }
}
