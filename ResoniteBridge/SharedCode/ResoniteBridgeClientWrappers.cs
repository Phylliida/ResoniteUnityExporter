using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ResoniteDataWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ResoniteBridgeClient
{
    public class ResoniteBridgeClientWrappers
    {
        public static ResoniteBridgeClient client;

        ResoniteBridgeValue EncodeInput(object input)
        {
            if (input.GetType() == typeof(ResoniteBridgeValue)) {
                // already a value, just return it
                return (ResoniteBridgeValue)input;
            } else {                
                // we need to serialize it
                string serialized = Newtonsoft.Json.JsonConvert.SerializeObject(input, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                ResoniteBridgeValue result = new ResoniteBridgeValue()
                {
                    assemblyName = Assembly.GetAssembly(input.GetType()).FullName,
                    typeName = input.GetType().FullName,
                    valueStr = serialized,
                    valueType = ResoniteBridgeValueType.Serialized                    
                };
                return result;
            }
        }

        ResoniteBridgeValue[] EncodeInputs(object[] inputs)
        {
            ResoniteBridgeValue[] encodedInputs = new ResoniteBridgeValue[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
            {
                encodedInputs[i] = EncodeInput(inputs[i]);
            }
            return encodedInputs;
        }

        public ResoniteBridgeValue SendBridgeMessage(ResoniteBridgeMessage message)
        {
            client.inputMessages.Enqueue(message);
            ResoniteBridgeValue output;
            while (!client.outputMessages.TryDequeue(out output))
            {
                // We are on unity thread, can't sleep :(
            }
            return output;
        }

        public ResoniteBridgeValue CallMethod(ResoniteBridgeValue target, string methodName, params object[] args)
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

        public ResoniteBridgeValue CallStaticMethod(string assemblyName, string typeName, string methodName, params object[] args)
        {
            ResoniteBridgeMessage message = new ResoniteBridgeMessage()
            {
                inputs = EncodeInputs(args),
                messageType = ResoniteBridgeMessageType.CallStaticMethod,
                name = methodName,
                target = new ResoniteBridgeValue()
                {
                    valueType = ResoniteBridgeValueType.Type,
                    assemblyName = assemblyName,
                    typeName = typeName
                }
            };
            return SendBridgeMessage(message);
        }

        public ResoniteBridgeValue GetField(ResoniteBridgeValue target, string fieldName)
        {
            ResoniteBridgeMessage message = new ResoniteBridgeMessage()
            {
                messageType = ResoniteBridgeMessageType.GetField,
                name = fieldName,
                target = target,
            };

            return SendBridgeMessage(message);
        }


        public ResoniteBridgeValue GetProperty(ResoniteBridgeValue target, string fieldName)
        {
            ResoniteBridgeMessage message = new ResoniteBridgeMessage()
            {
                messageType = ResoniteBridgeMessageType.GetProperty,
                name = fieldName,
                target = target,
            };

            return SendBridgeMessage(message);
        }
        public ResoniteBridgeValue SetField(ResoniteBridgeValue target, string fieldName, object value)
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

        public ResoniteBridgeValue SetProperty(ResoniteBridgeValue target, string fieldName, object value)
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

        public ResoniteBridgeValue GetType(string assemblyName, string typeName)
        {
            return new ResoniteBridgeValue()
            {
                assemblyName = assemblyName,
                typeName = typeName,
                valueStr = null,
                valueType = ResoniteBridgeValueType.Type
            };
        }

        public ResoniteBridgeValue GetType(ResoniteBridgeValue target)
        {
            // no need to send any message as we already have all the needed data
            return new ResoniteBridgeValue()
            {
                assemblyName = target.assemblyName,
                typeName = target.typeName,
                valueStr = null,
                valueType = ResoniteBridgeValueType.Type
            };
        }

        public ResoniteBridgeValue GetEnum(string assemblyName, string typeName, string enumValue)
        {
            ResoniteBridgeMessage message = new ResoniteBridgeMessage()
            {
                messageType = ResoniteBridgeMessageType.GetEnum,
                name = enumValue,
                target = GetType(assemblyName, typeName)
            };

            return SendBridgeMessage(message);
        }
    }
}
