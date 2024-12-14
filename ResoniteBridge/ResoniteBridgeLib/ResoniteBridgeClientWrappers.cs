using Newtonsoft.Json;
using System;
using System.Reflection;

namespace ResoniteBridge
{
    public class EvaluationException : Exception
    {
        public string exceptionType;

        public string Message;
        public EvaluationException(string message)
        {
            this.Message = message;
        }
    }

    public class ResoniteBridgeClientWrappers
    {
        public static ResoniteBridgeClient client;

        public delegate void DebugLogDelegate(string msg);

        public static DebugLogDelegate DebugLog;
        
        static ResoniteBridgeValue EncodeInput<T>(T input)
        {
            if (input is ResoniteBridgeValueHolder valueHolder)
            {
                // already a value, just return it
                return valueHolder.__Backing;
            }
            else if (input is ResoniteBridgeValue bridgeValue)
            {
                return bridgeValue;
            }
            else
            {
                Console.WriteLine("Got input of type " + input.GetType().ToString() + " with full name " + input.GetType().FullName);
                // we need to serialize it
                byte[] serialized = ResoniteBridgeUtils.EncodeObject(input);
                return new ResoniteBridgeValue(serialized,
                    Assembly.GetAssembly(input.GetType()).GetName().Name,
                    ReflectionUtils.TypeToString(input.GetType()) + "bees",
                    ResoniteBridgeValueType.Serialized);
            }
        }

        static ResoniteBridgeValue[] EncodeInputs(object[] inputs)
        {
            ResoniteBridgeValue[] encodedInputs = new ResoniteBridgeValue[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
            {
                encodedInputs[i] = EncodeInput(inputs[i]);
            }
            return encodedInputs;
        }

        public static ResoniteBridgeResponse SendBridgeMessageFull(ResoniteBridgeMessage message)
        {
            ResoniteBridgeResponse output = client.SendMessageSync(message, 5000);
            if (output.responseType == ResoniteBridgeResponseType.Error ||
                output.response.valueType == ResoniteBridgeValueType.Error)
            {
                DebugLog("Got exception:" + output.response.valueBytes);
            }
            return output;
        }

        public static ResoniteBridgeValue SendBridgeMessage(ResoniteBridgeMessage message)
        {
            return SendBridgeMessageFull(message).response;
        }

        public static ResoniteBridgeValue CallMethodWithRefsAndOuts(ResoniteBridgeValue target,
            string methodName,
            out ResoniteBridgeValue[] outs,
            params object[] inputParams)
        {
            ResoniteBridgeMessage message = new ResoniteBridgeMessage()
            {
                inputs = EncodeInputs(inputParams),
                messageType = ResoniteBridgeMessageType.CallMethodWithRefsAndOuts,
                name = methodName,
                target = target
            };
            ResoniteBridgeResponse results = SendBridgeMessageFull(message);
            outs = results.extraResults;
            return results.response;
        }

        public static ResoniteBridgeValue CallMethod(ResoniteBridgeValue target, string methodName, params object[] args)
        {
            ResoniteBridgeMessage message = new ResoniteBridgeMessage()
            {
                inputs = EncodeInputs(args),
                messageType = ResoniteBridgeMessageType.CallMethod,
                name = methodName,
                target = target
            };
            return SendBridgeMessage(message);
        }


        public static ResoniteBridgeValue GetField(ResoniteBridgeValue target, string fieldName)
        {
            ResoniteBridgeMessage message = new ResoniteBridgeMessage()
            {
                messageType = ResoniteBridgeMessageType.GetField,
                name = fieldName,
                target = target,
            };

            return SendBridgeMessage(message);
        }


        public static ResoniteBridgeValue GetProperty(ResoniteBridgeValue target, string fieldName)
        {
            ResoniteBridgeMessage message = new ResoniteBridgeMessage()
            {
                messageType = ResoniteBridgeMessageType.GetProperty,
                name = fieldName,
                target = target,
            };

            return SendBridgeMessage(message);
        }
        public static ResoniteBridgeValue SetField<T>(ResoniteBridgeValue target, string fieldName, T value)
        {
            ResoniteBridgeMessage message = new ResoniteBridgeMessage()
            {
                messageType = ResoniteBridgeMessageType.SetField,
                name = fieldName,
                target = target,
                inputs = new ResoniteBridgeValue[] { EncodeInput(value) }
            };

            return SendBridgeMessage(message);
        }

        public static ResoniteBridgeValue SetProperty<T>(ResoniteBridgeValue target, string fieldName, T value)
        {
            ResoniteBridgeMessage message = new ResoniteBridgeMessage()
            {
                messageType = ResoniteBridgeMessageType.SetProperty,
                name = fieldName,
                target = target,
                inputs = new ResoniteBridgeValue[] { EncodeInput(value) }
            };

            return SendBridgeMessage(message);
        }

        public static ResoniteBridgeValue LookupType(string assemblyName, string typeName)
        {
            return new ResoniteBridgeValue()
            {
                assemblyName = assemblyName,
                typeName = typeName,
                valueBytes = null,
                valueType = ResoniteBridgeValueType.Type
            };
        }

        public static ResoniteBridgeValue LookupType(ResoniteBridgeValue target)
        {
            // no need to send any message as we already have all the needed data
            return new ResoniteBridgeValue()
            {
                assemblyName = target.assemblyName,
                typeName = target.typeName,
                valueBytes = null,
                valueType = ResoniteBridgeValueType.Type
            };
        }

        public static ResoniteBridgeValue GetEnum(string assemblyName, string typeName, string enumValue)
        {
            ResoniteBridgeMessage message = new ResoniteBridgeMessage()
            {
                messageType = ResoniteBridgeMessageType.GetEnum,
                name = enumValue,
                target = LookupType(assemblyName, typeName)
            };

            return SendBridgeMessage(message);
        }

        public static object CastValue(ResoniteBridgeValue value, Type typeToCastTo)
        {
            if (typeToCastTo.IsAssignableFrom(typeof(ResoniteBridgeValueHolder)))
            {
                return ReflectionUtils.CallConstructor(typeToCastTo.Assembly, ReflectionUtils.TypeToString(typeToCastTo), value);
            }
            //else if(typeToCastTo.IsEnum)
            //{
            //    return Enum.Parse(typeToCastTo, ResoniteBridgeUtils.DecodeString(value.valueBytes));
            //}
            else
            {
                return ResoniteBridgeUtils.DecodeObject(value.valueBytes, typeToCastTo);
            }
        }

        public static ResoniteBridgeValue CallConstructor(ResoniteBridgeValue targetType, params object[] inputs)
        {
            ResoniteBridgeMessage message = new ResoniteBridgeMessage()
            {
                inputs = EncodeInputs(inputs),
                messageType = ResoniteBridgeMessageType.CallConstructor,
                name = null,
                target = targetType
            };
            return SendBridgeMessage(message);
        }
    }
}
