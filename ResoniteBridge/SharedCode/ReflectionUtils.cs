using System.Linq.Expressions;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.IO;

namespace ResoniteBridge
{
    public static class ReflectionUtils
    {

        public static object GetField(object obj, string fieldName)
        {
            return obj.GetType().GetField(fieldName).GetValue(obj);
        }

        public static object GetProperty(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName).GetValue(obj);
        }

        public static void SetField(object obj, string fieldName, object value)
        {
            obj.GetType().GetField(fieldName).SetValue(obj, value);
        }

        public static void SetProperty(object obj, string propertyName, object value)
        {
            obj.GetType().GetProperty(propertyName).SetValue(obj, value);
        }

        public static object CallConstructor(Assembly assembly, string typeName, params object[] parameters)
        {
            Type[] inputTypes = new Type[parameters.Length];
            for (int i = 0; i < parameters.Length; i++)
            {
                inputTypes[i] = parameters[i].GetType();
            }
            return assembly.GetType(typeName)
                .GetConstructor(inputTypes)
                .Invoke(parameters);
        }

        public static bool MethodParamsMatch(MethodInfo method, object[] parameters)
        {
            var methodParameters = method.GetParameters();
            // more is bad, but less could mean default params are being used
            if (parameters.Length > methodParameters.Length)
            {
                return false;
            }
            for (int i = 0; i < methodParameters.Length; i++)
            {
                ParameterInfo param = methodParameters[i];
                if (i >= parameters.Length && !param.HasDefaultValue)
                {
                    return false;
                }
                // we allow i>=parameters.length and param.HasDefaultValue
                // because in that case we use the default value
                else if (i < parameters.Length)
                {
                    // needs to be a different type and not a subclass of correct type
                    if (param.ParameterType != parameters[i].GetType() &&
                        !parameters[i].GetType().IsSubclassOf(param.ParameterType))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static object CallMethod(object obj, string methodName, params object[] parameters)
        {
            MethodInfo method = null;
            try
            {
                try
                {
                    method = obj.GetType().GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                    return method
                        .Invoke(obj, parameters);
                }
                // overriden methods, we need to search manually
                catch (System.Reflection.AmbiguousMatchException)
                {
                    foreach (MethodInfo methodInfo in obj.GetType().GetMethods())
                    {
                        var methodParameters = methodInfo.GetParameters();
                        if (MethodParamsMatch(methodInfo, parameters))
                        {
                            method = methodInfo;
                            return method.Invoke(obj, parameters);
                        }
                    }
                }
            }
            // this can happen with default params
            catch (System.Reflection.TargetParameterCountException)
            {
                var methodParams = method.GetParameters();
                // try sticking type missing in other places, this is needed for default arguments
                if (methodParams.Length > parameters.Length)
                {
                    object[] newParams = new object[methodParams.Length];
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        newParams[i] = parameters[i];
                    }
                    for (int i = parameters.Length; i < methodParams.Length; i++)
                    {
                        newParams[i] = Type.Missing;
                    }
                    method.Invoke(obj, newParams);
                }
                else
                {
                    // default args not relevant, we did something wrong
                    throw;
                }
            }
            throw new ArgumentException("Did not find method " + methodName + " in type " + obj.GetType().Name + " with " + parameters.Length + " parameters");
        }

        public static object CallStaticMethod(Type type, string methodName, params object[] parameters)
        {
            return type.GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic)
                .Invoke(null, parameters);
        }

        public static object CallStaticMethod(Assembly assembly, string typeName, string methodName, params object[] parameters)
        {
            return assembly.GetType(typeName).GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic)
                .Invoke(null, parameters);
        }

        public static object GetEnum(Type enumType, string enumValue)
        {
            return Enum.Parse(enumType, enumValue);
        }

        public static object GetEnum(Assembly assembly, string enumTypeName, string enumValue)
        {
            Type enumType = assembly.GetType(enumTypeName);
            return Enum.Parse(enumType, enumValue);
        }

        public delegate void ObjectDelegate(object input);

        public static Delegate CreateDelegateWithInputType(Assembly assembly, string inputTypeName, string delegateTypeName, ObjectDelegate delegateToCall)
        {
            Type inputType = assembly.GetType(inputTypeName);
            Type delegateType = assembly.GetType(delegateTypeName);

            // Cursed shit
            var parameter = Expression.Parameter(inputType, "input");
            var convertExpr = Expression.Convert(parameter, typeof(object));
            Expression call;
            if (delegateToCall.Method.IsStatic)
            {
                call = Expression.Call(
                    delegateToCall.Method,
                    convertExpr
                );
            }
            else
            {
                call = Expression.Call(
                    Expression.Constant(delegateToCall.Target),
                    delegateToCall.Method,
                    convertExpr
                );
            }
            var lambda = Expression.Lambda(delegateType, call, parameter);
            return lambda.Compile();
        }
    }
}
