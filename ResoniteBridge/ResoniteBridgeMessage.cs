using Newtonsoft.Json;
using ResoniteBridge;
using System;
using System.Collections.Generic;
using System.Reflection;
using static ResoniteBridge.ReflectionUtils;

namespace ResoniteDataWrapper
{
    public class ResoniteBridgeMessage
    {
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

        public ResoniteBridgeMessageType messageType;

        public string assembly = null;

        public ResoniteBridgeValue target = null;

        public string name = null;

        public ResoniteBridgeValue[] inputs = null;


        public static object ParseSpecialKeyword(FrooxEngineRunner runner, string specialKeyword)
        {
            switch (specialKeyword)
            {
                case "engine": return runner.engine;
                case "focusedWorld": return runner.focusedWorld;
            }
            throw new ArgumentException("Invalid special keyword " + specialKeyword);
        }

        public static object ParseUUIDObject(UnsupportedTypeLookup typeLookup, ResoniteBridgeValue value, Type type)
        {
            Guid uuid = Guid.Parse(value.valueStr);
            if (typeLookup.TryGet(uuid, type, out object result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException("Did not find " + uuid + " of type " + type.Name);
            }
        }

        public class ResoniteBridgeValue
        {
            public enum ResoniteBridgeValueType
            {
                Serialized = 0,
                UUID = 1,
                Type = 2,
                SpecialKeyword = 3,
            }
            public string valueStr = null;
            public string assemblyName = null;
            public string typeName = null;
            public ResoniteBridgeValueType valueType = ResoniteBridgeValueType.Serialized;
        }

        public static Type GetTypeFromAssembly(Dictionary<string, Assembly> assemblies, string assemblyName, string typeName)
        {
            if (assemblies.TryGetValue(assemblyName, out Assembly assembly))
            {
                Type outputType = assembly.GetType(typeName);
                if (outputType == null)
                {
                    throw new ArgumentException("Type " + outputType + " does not exist in assembly " + assemblyName);
                }
                return outputType;
            }
            else
            {
                throw new ArgumentException("Unknown assembly: " + assemblyName);
            }
        }

        public static object ParseInput(FrooxEngineRunner runner, ResoniteBridgeValue value)
        {
            // support null inputs
            if (value == null)
            {
                return null;
            }
            Type type = GetTypeFromAssembly(runner.assemblies, value.assemblyName, value.typeName);
            switch (value.valueType)
            {
                case ResoniteBridgeValue.ResoniteBridgeValueType.Serialized:
                    return Newtonsoft.Json.JsonConvert.DeserializeObject(value.valueStr, type);
                case ResoniteBridgeValue.ResoniteBridgeValueType.UUID:
                    if (Guid.TryParse(value.valueStr, out Guid guid))
                    {
                        if (runner.uuidLookup.TryGet(guid, type, out object result))
                        {
                            return result;
                        }
                        else
                        {
                            throw new ArgumentException("Invalid failed to lookup guid " + guid + " from object of type " + type + " from assembly " + value.assemblyName);
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Invalid guid " + guid + " from object of type " + type + " from assembly " + value.assemblyName);
                    }
                case ResoniteBridgeValue.ResoniteBridgeValueType.Type:
                    return type;
                case ResoniteBridgeValue.ResoniteBridgeValueType.SpecialKeyword:
                    return ParseSpecialKeyword(runner, value.valueStr);
            }
            throw new ArgumentException("Unknown ResoniteBridgeValueType " + value.valueType + " for type " + type + " from assembly " + value.assemblyName);
        }

        public static object[] ParseInputs(FrooxEngineRunner runner, ResoniteBridgeValue[] inputs)
        {
            object[] results = new object[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
            {
                results[i] = ParseInput(runner, inputs[i]);
            }
            return results;
        }

        public ResoniteBridgeValue Evaluate(FrooxEngineRunner runner)
        {
            object result = EvaluateHelper(runner);
            if (result == null)
            {
                return null;
            }
            ResoniteBridgeValue encodedResult = new ResoniteBridgeValue()
            {
                assemblyName = Assembly.GetAssembly(result.GetType()).FullName,
                typeName = result.GetType().FullName
            };

            if (result.GetType() == typeof(Type))
            {
                encodedResult.valueStr = null;
                encodedResult.valueType = ResoniteBridgeValue.ResoniteBridgeValueType.Type;
            }
            else
            {
                try
                {
                    string encoded = Newtonsoft.Json.JsonConvert.SerializeObject(result, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                    encodedResult.valueStr = encoded;
                    encodedResult.valueType = ResoniteBridgeValue.ResoniteBridgeValueType.Serialized;
                }
                catch (Newtonsoft.Json.JsonSerializationException)
                {
                    // use guid since serialization failed
                    Guid guid = runner.uuidLookup.Add(result);
                    encodedResult.valueStr = guid.ToString();
                    encodedResult.valueType = ResoniteBridgeValue.ResoniteBridgeValueType.UUID;
                }
            }
            return encodedResult;
        }

        object EvaluateHelper(FrooxEngineRunner runner)
        {
            object[] objInputs = ParseInputs(runner, this.inputs);
            object objTarget = null;
            if (this.target != null)
            {
                objTarget = ParseInput(runner, this.target);
            }
            switch (messageType)
            {
                case ResoniteBridgeMessageType.CallMethod:
                    return CallMethod(objTarget, this.name, objInputs);
                case ResoniteBridgeMessageType.CallStaticMethod:
                    // objTarget should be a type
                    return CallStaticMethod((Type)objTarget, this.name, objInputs);
                case ResoniteBridgeMessageType.GetField:
                    return GetField(objTarget, this.name);
                case ResoniteBridgeMessageType.SetField:
                    SetField(objTarget, this.name, objInputs[0]);
                    return null;
                case ResoniteBridgeMessageType.GetProperty:
                    return GetProperty(objTarget, this.name);
                case ResoniteBridgeMessageType.SetProperty:
                    SetProperty(objTarget, this.name, objInputs[0]);
                    return null;
                case ResoniteBridgeMessageType.GetType:
                    return (Type)objTarget;
                case ResoniteBridgeMessageType.GetEnum:
                    return GetEnum((Type)objTarget, this.name);
                default:
                    throw new ArgumentException("Invalid ResoniteBridgeMessageType " + messageType);
            }
        }
    }
}
