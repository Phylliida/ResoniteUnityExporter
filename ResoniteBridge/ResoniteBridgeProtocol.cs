using Newtonsoft.Json;
using ResoniteBridge;
using System;
using System.Collections.Generic;
using System.Reflection;
using static ResoniteBridge.ReflectionUtils;

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

        public string assembly = null;

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
        GetType = 6,
        GetEnum = 7,
    }
}
