﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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

        static ResoniteBridgeValue EncodeInput(object input)
        {
            if (input.GetType() == typeof(ResoniteBridgeValue)) {
                // already a value, just return it
                return (ResoniteBridgeValue)input;
            } else {                
                // we need to serialize it
                string serialized = Newtonsoft.Json.JsonConvert.SerializeObject(input, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                ResoniteBridgeValue result = new ResoniteBridgeValue()
                {
                    assemblyName = Assembly.GetAssembly(input.GetType()).GetName().Name,
                    typeName = input.GetType().FullName,
                    valueStr = serialized,
                    valueType = ResoniteBridgeValueType.Serialized                    
                };
                return result;
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

        public static ResoniteBridgeValue SendBridgeMessage(ResoniteBridgeMessage message)
        {
            client.inputMessages.Enqueue(message);
            ResoniteBridgeValue output = null;
            Stopwatch elapsedTime = new Stopwatch();
            elapsedTime.Start();
            while (!client.outputMessages.TryDequeue(out output))
            {
                if (elapsedTime.ElapsedMilliseconds > 5000)
                {
                    throw new TimeoutException("Timed out waiting for response from server");
                }
                // We are on unity thread, can't sleep :(
            }
            if (output == null){
                DebugLog("Got null output?");
                throw new EvaluationException("Got null output?");
            }
            if (output.valueType == ResoniteBridgeValueType.Error)
            {
                DebugLog("Got excfeption:" + output.valueStr);
            }
            return output;
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
        public static ResoniteBridgeValue SetField(ResoniteBridgeValue target, string fieldName, object value)
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

        public static ResoniteBridgeValue SetProperty(ResoniteBridgeValue target, string fieldName, object value)
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
                valueStr = null,
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
                valueStr = null,
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
    }
}