using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;

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


        public static Type GetTypeFromAssembly(Dictionary<string, Assembly> assemblies, string assemblyName, string typeName)
        {
            if (assemblies.TryGetValue(assemblyName, out Assembly assembly))
            {
                Type outputType = ReflectionUtils.TypeFromString(typeName);
                if (outputType == null)
                {
                    throw new ArgumentException("Type " + typeName + " does not exist in assembly " + assemblyName);
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
            if (value.valueType == ResoniteBridgeValueType.Null)
            {
                return null;
            }
            Type type = GetTypeFromAssembly(runner.assemblies, value.assemblyName, value.typeName);
            switch (value.valueType)
            {
                case ResoniteBridgeValueType.Serialized:
                    return Newtonsoft.Json.JsonConvert.DeserializeObject(value.valueStr, type);
                case ResoniteBridgeValueType.UUID:
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
                case ResoniteBridgeValueType.Type:
                    return type;
                case ResoniteBridgeValueType.SpecialKeyword:
                    return ParseSpecialKeyword(runner, value.valueStr);
            }
            throw new ArgumentException("Unknown ResoniteBridgeValueType " + value.valueType + " for type " + type + " from assembly " + value.assemblyName);
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

        public static ResoniteBridgeValue EncodeValue(ResoniteBridgeServerData runner, object value)
        {
            ResoniteBridgeValue encodedResult = value == null
                    ? new ResoniteBridgeValue(
                        valueStr: null,
                        assemblyName: null,
                        typeName: null,
                        ResoniteBridgeValueType.Null)
                    : new ResoniteBridgeValue(
                        valueStr: null,
                        assemblyName: ReflectionUtils.GetAssemblyName(Assembly.GetAssembly(value.GetType())),
                        typeName: value.GetType().FullName,
                        valueType: ResoniteBridgeValueType.Type
                        );


            if (value != null && !IsType(value))
            {
                try
                {
                    string encoded = Newtonsoft.Json.JsonConvert.SerializeObject(value, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                    encodedResult.valueStr = encoded;
                    encodedResult.valueType = ResoniteBridgeValueType.Serialized;
                }
                catch (Newtonsoft.Json.JsonSerializationException)
                {
                    // use guid since serialization failed
                    Guid guid = runner.uuidLookup.Add(value);
                    encodedResult.valueStr = guid.ToString();
                    encodedResult.valueType = ResoniteBridgeValueType.UUID;
                }
            }
            return encodedResult;
        }

        public static ResoniteBridgeResponse EvaluateMessage(ResoniteBridgeServerData runner, ResoniteBridgeMessage message)
        {
            try
            {
                object result = EvaluateHelper(runner, message, out object[] extraResults);

                ResoniteBridgeValue encodedResult = EncodeValue(runner, result);
                ResoniteBridgeResponse response = new ResoniteBridgeResponse();
                response.responseType = ResoniteBridgeResponseType.Success;
                response.response = encodedResult;
                if (extraResults != null)
                {
                    ResoniteBridgeValue[] extraResultValues = new ResoniteBridgeValue[extraResults.Length];
                    for(int i = 0; i < extraResults.Length;i ++)
                    {
                        extraResultValues[i] = EncodeValue(runner, extraResults[i]);
                    }
                    response.extraResults = extraResultValues;
                }

                return response;
            }
            // Return errors to them for easy debugging
            catch (Exception e)
            {
                return new ResoniteBridgeResponse()
                {
                    response = new ResoniteBridgeValue()
                    {
                        typeName = e.GetType().Name,
                        valueStr = e.ToString() + "\n" + Environment.StackTrace,
                        valueType = ResoniteBridgeValueType.Error
                    },
                    responseType = ResoniteBridgeResponseType.Error,
                    extraResults = null
                };
            }
        }

        public static object EvaluateHelper(ResoniteBridgeServerData runner, ResoniteBridgeMessage message, out object[] extraOutputs)
        {
            extraOutputs = null;
            object[] objInputs = ParseInputs(runner, message.inputs);
            object objTarget = null;
            if (message.target.valueType != ResoniteBridgeValueType.Null)
            {
                objTarget = ParseInput(runner, message.target);
            }
            switch (message.messageType)
            {
                case ResoniteBridgeMessageType.CallMethod:
                    return CallMethod(objTarget, message.name, objInputs);
                case ResoniteBridgeMessageType.CallMethodWithRefsAndOuts:
                    // todo
                    return CallMethod(objTarget, message.name, objInputs);
                case ResoniteBridgeMessageType.CallConstructor:
                    return CallConstructorFromType((Type)objTarget, objInputs);
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
