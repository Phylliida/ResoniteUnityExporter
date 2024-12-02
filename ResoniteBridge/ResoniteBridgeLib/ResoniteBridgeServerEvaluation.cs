using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using static ResoniteBridge.ReflectionUtils;

namespace ResoniteBridge
{

    public class ResoniteBridgeServerData
    {
        public object engine;
        public object focusedWorld;
        public Dictionary<string, Assembly> assemblies;
        public UnsupportedTypeLookup uuidLookup = new UnsupportedTypeLookup(10);
    }

    public class ResoniteBridgeServerEvaluation
    {
        public static object ParseSpecialKeyword(ResoniteBridgeServerData runner, string specialKeyword)
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
            Guid uuid = Guid.Parse(value.getValueStr());
            if (typeLookup.TryGet(uuid, type, out object result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException("Did not find " + uuid + " of type " + type.Name);
            }
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

        public static object ParseInput(ResoniteBridgeServerData runner, ResoniteBridgeValue value)
        {
            // support null inputs
            if (value.getValueType() == ResoniteBridgeValueType.Null)
            {
                return null;
            }
            Type type = GetTypeFromAssembly(runner.assemblies, value.getAssemblyName(), value.getTypeName());
            switch (value.getValueType())
            {
                case ResoniteBridgeValueType.Serialized:
                    return Newtonsoft.Json.JsonConvert.DeserializeObject(value.getValueStr(), type);
                case ResoniteBridgeValueType.UUID:
                    if (Guid.TryParse(value.getValueStr(), out Guid guid))
                    {
                        if (runner.uuidLookup.TryGet(guid, type, out object result))
                        {
                            return result;
                        }
                        else
                        {
                            throw new ArgumentException("Invalid failed to lookup guid " + guid + " from object of type " + type + " from assembly " + value.getAssemblyName());
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Invalid guid " + guid + " from object of type " + type + " from assembly " + value.getAssemblyName());
                    }
                case ResoniteBridgeValueType.Type:
                    return type;
                case ResoniteBridgeValueType.SpecialKeyword:
                    return ParseSpecialKeyword(runner, value.getValueStr());
            }
            throw new ArgumentException("Unknown ResoniteBridgeValueType " + value.getValueType() + " for type " + type + " from assembly " + value.getAssemblyName());
        }

        public static object[] ParseInputs(ResoniteBridgeServerData runner, ResoniteBridgeValue[] inputs)
        {
            // we also support no inputs
            if (inputs == null)
            {
                return new object[] { };
            }
            object[] results = new object[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
            {
                results[i] = ParseInput(runner, inputs[i]);
            }
            return results;
        }

        public static ResoniteBridgeValue EvaluateMessage(ResoniteBridgeServerData runner, ResoniteBridgeMessage message)
        {
            try
            {
                object result = EvaluateHelper(runner, message);
                if (result == null)
                {
                    return new StructResoniteBridgeValue(); // default value is null
                }
                StructResoniteBridgeValue encodedResult = new StructResoniteBridgeValue()
                {
                    __assemblyName = ResoniteBridgeServer.GetAssemblyName(Assembly.GetAssembly(result.GetType())),
                    __typeName = result.GetType().FullName
                };

                if (IsType(result))
                {
                    encodedResult.setValueStr(null);
                    encodedResult.setValueType(ResoniteBridgeValueType.Type);
                }
                else
                {
                    try
                    {
                        string encoded = Newtonsoft.Json.JsonConvert.SerializeObject(result, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                        encodedResult.setValueStr(encoded);
                        encodedResult.setValueType(ResoniteBridgeValueType.Serialized);
                    }
                    catch (Newtonsoft.Json.JsonSerializationException)
                    {
                        // use guid since serialization failed
                        Guid guid = runner.uuidLookup.Add(result);
                        encodedResult.setValueStr(guid.ToString());
                        encodedResult.setValueType(ResoniteBridgeValueType.UUID);
                    }
                }
                return encodedResult;
            }
            // Return errors to them for easy debugging
            catch (Exception e)
            {
                return new StructResoniteBridgeValue()
                {
                    __typeName = e.GetType().Name,
                    __valueStr = e.ToString() + "\n" + Environment.StackTrace,
                    __valueType = ResoniteBridgeValueType.Error
                };
            }
        }

        public static object EvaluateHelper(ResoniteBridgeServerData runner, ResoniteBridgeMessage message)
        {
            object[] objInputs = ParseInputs(runner, message.inputs);
            object objTarget = null;
            if (message.target.getValueType() != ResoniteBridgeValueType.Null)
            {
                objTarget = ParseInput(runner, message.target);
            }
            switch (message.messageType)
            {
                case ResoniteBridgeMessageType.CallMethod:
                    return CallMethod(objTarget, message.name, objInputs);
                case ResoniteBridgeMessageType.GetField:
                    return GetField(objTarget, message.name);
                case ResoniteBridgeMessageType.SetField:
                    SetField(objTarget, message.name, objInputs[0]);
                    return GetField(objTarget, message.name);
                case ResoniteBridgeMessageType.GetProperty:
                    return GetProperty(objTarget, message.name);
                case ResoniteBridgeMessageType.SetProperty:
                    SetProperty(objTarget, message.name, objInputs[0]);
                    return GetProperty(objTarget, message.name);
                case ResoniteBridgeMessageType.GetEnum:
                    return GetEnum((Type)objTarget, message.name);
                default:
                    throw new ArgumentException("Invalid ResoniteBridgeMessageType " + message.messageType);
            }
        }
    }
}
