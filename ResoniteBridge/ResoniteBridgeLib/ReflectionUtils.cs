using System.Linq.Expressions;
using System.Reflection;
using System;
using System.Collections.Generic;

namespace ResoniteBridge
{
    public static class ReflectionUtils
    {
        
        // from https://stackoverflow.com/a/10253634
        public static IEnumerable<Assembly> GetAssemblies(Assembly frooxEngineAsm, params string[] searchPaths)
        {
            var list = new List<string>();
            var stack = new Stack<Assembly>();

            stack.Push(frooxEngineAsm);

            do
            {
                var asm = stack.Pop();

                yield return asm;

                foreach (var reference in asm.GetReferencedAssemblies())
                    if (!list.Contains(reference.FullName))
                    {
                        try
                        {
                            stack.Push(Assembly.Load(reference));
                        }
                        catch (Exception e) when (e is System.IO.FileNotFoundException || e is System.IO.FileLoadException)
                        {
                            foreach (string searchPath in searchPaths)
                            {
                                try
                                {
                                    stack.Push(Assembly.Load(System.IO.Path.Combine(searchPath, reference.Name)));
                                    break;
                                }
                                catch (Exception e2) when (e2 is System.IO.FileNotFoundException || e2 is System.IO.FileLoadException)
                                {

                                }
                            }
                        }
                        list.Add(reference.FullName);
                    }

            }
            while (stack.Count > 0);

        }

        public static string GetAssemblyName(Assembly assembly)
        {
            return assembly.GetName().Name;
        }

        public static Dictionary<string, Assembly> LoadAssemblies(Assembly frooxEngineAsm, params string[] searchPaths)
        {
            Dictionary<string, Assembly> loadedAssemblies = new Dictionary<string, Assembly>();

            foreach (Assembly assembly in GetAssemblies(frooxEngineAsm, searchPaths))
            {
                if (!loadedAssemblies.ContainsKey(GetAssemblyName(assembly)))
                {
                    loadedAssemblies.Add(GetAssemblyName(assembly), assembly);
                }
            }

            // Any assemblies loaded later
            AppDomain.CurrentDomain.AssemblyLoad += (object sender, AssemblyLoadEventArgs args) => {
                if (!loadedAssemblies.ContainsKey(GetAssemblyName(args.LoadedAssembly)))
                {
                    loadedAssemblies.Add(GetAssemblyName(args.LoadedAssembly), args.LoadedAssembly);
                }
            };
            // This will be directory holding resonite
            // For example
            // C:\Program Files (x86)\Steam\steamapps\common\Resonite
            return loadedAssemblies;
        }

        
        public static BindingFlags StaticBindingFlags = BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy | BindingFlags.NonPublic;

        public static BindingFlags InstanceBindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.FlattenHierarchy;

        static System.ComponentModel.TypeConverter typeToStringConverter = System.ComponentModel.TypeDescriptor.GetConverter(typeof(Type));

        public static string TypeToString(Type type)
        {
            string outType = typeToStringConverter.ConvertToString(type);
            if (!outType.StartsWith(type.Namespace))
            {
                outType = type.Namespace + outType;
            }
            return outType;
        }

        public static Type TypeFromString(string str)
        {
            return Type.GetType(str);
        }


        public static bool IsType(object obj)
        {
            return obj.GetType() == typeof(Type) || obj.GetType().FullName == "System.RuntimeType";
        }

        public static object GetField(object obj, string fieldName)
        {
            // static get
            if (IsType(obj))
            {
                return ((Type)obj).GetField(fieldName, StaticBindingFlags)
                    // static take null for obj
                    .GetValue(null);
            }
            // instance get
            else
            {
                return obj.GetType().GetField(fieldName, InstanceBindingFlags)
                    .GetValue(obj);
            }
        }


        public static object GetProperty(object obj, string propertyName)
        {
            // static get
            if (IsType(obj))
            {
                return ((Type)obj).GetProperty(propertyName, StaticBindingFlags)
                    // static take null for obj
                    .GetValue(null);
            }
            // instance get
            else
            {
                return obj.GetType().GetProperty(propertyName, InstanceBindingFlags)
                    .GetValue(obj);
            }
        }

        public static ResoniteBridgeServerData serverData;

        public static Type LookupType(string assemblyName, string typeName)
        {
            return serverData.assemblies[assemblyName].GetType(typeName);
        }

        public static void SetField(object obj, string fieldName, object value)
        {
            // static get
            if (IsType(obj))
            {
                ((Type)obj).GetField(fieldName, StaticBindingFlags)
                    // static take null for obj
                    .SetValue(null, value);
            }
            // instance get
            else
            {
                obj.GetType().GetField(fieldName, InstanceBindingFlags)
                    .SetValue(obj, value);
            }
        }

        public static void SetProperty(object obj, string propertyName, object value)
        {
            // static get
            if (IsType(obj))
            {
                ((Type)obj).GetProperty(propertyName, StaticBindingFlags)
                    // static take null for obj
                    .SetValue(null, value);
            }
            // instance get
            else
            {
                obj.GetType().GetProperty(propertyName, InstanceBindingFlags)
                    .SetValue(obj, value);
            }
        }

        public static object CallConstructor(Assembly assembly, string typeName, params object[] parameters)
        {
            return CallConstructorFromType(assembly.GetType(typeName), parameters);
        }
        public static object CallConstructorFromType(Type type, params object[] parameters)
        {
            Type[] inputTypes = new Type[parameters.Length];
            for (int i = 0; i < parameters.Length; i++)
            {
                inputTypes[i] = parameters[i].GetType();
            }
            return type
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
                    // Static method
                    if (IsType(obj))
                    {
                        method = ((Type)obj).GetMethod(methodName, StaticBindingFlags);
                        // static takes null as obj
                        return method.Invoke(null, parameters);
                    }
                    // Instance method
                    else
                    {
                        method = obj.GetType().GetMethod(methodName, InstanceBindingFlags);
                        return method.Invoke(obj, parameters);
                    }
                }
                // overriden methods, we need to search manually
                catch (System.Reflection.AmbiguousMatchException)
                {
                    Console.WriteLine("Ambiguous");
                    MethodInfo[] methods = IsType(obj)
                        // static
                        ? ((Type)obj).GetMethods()
                        // instance
                        : obj.GetType().GetMethods();

                    foreach (MethodInfo methodInfo in methods)
                    {
                        var methodParameters = methodInfo.GetParameters();
                        if (MethodParamsMatch(methodInfo, parameters))
                        {
                            method = methodInfo;
                            if (IsType(obj))
                            {
                                Console.WriteLine("try static");
                                // static method call
                                return method.Invoke(null, parameters);
                            }
                            else
                            {
                                Console.WriteLine("try class");
                                // regular call
                                return method.Invoke(obj, parameters);
                            }
                        }
                    }
                }
            }
            // this can happen with default params
            catch (System.Reflection.TargetParameterCountException)
            {
                Console.WriteLine("param count exception");
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
                    if (IsType(obj))
                    {
                        method.Invoke(null, newParams);
                    }
                    else
                    {
                        method.Invoke(obj, newParams);
                    }
                }
                else
                {
                    // default args not relevant, we did something wrong
                    throw;
                }
            }
            throw new ArgumentException("Did not find method " + methodName + " in type " + obj.GetType().Name + " with " + parameters.Length + " parameters");
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
