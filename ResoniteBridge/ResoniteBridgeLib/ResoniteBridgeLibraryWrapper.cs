using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Operations;
using System.Text.Json;
using Newtonsoft.Json;
using static ResoniteBridge.ResoniteBinaryWrapper;



namespace ResoniteBridge
{
    // probably a better option is to just send the code and generate dll on mod side
    // but idk this gives us autocomplete and stuff which is kinda nice
    public class ResoniteBinaryWrapper
    {

        public static PropertyDeclarationSyntax CreateBridgeProperty(PropertyInfo property, System.Type type)
        {
            string assemblyName = ResoniteBridge.ResoniteBridgeServer.GetAssemblyName(type.Assembly);
            string dataType = GetWrappedDataType(property.PropertyType);
            bool isStatic = property.GetAccessors(nonPublic: true)[0].IsStatic;
            string staticStr = isStatic ? "static " : "";


            string target = GetTarget(isStatic, assemblyName, type.Name);

            string propertyCode = $@"
            public {staticStr}{dataType} {property.Name}
            {{
                get
                {{
                    return ({dataType})ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(
                        ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(
                            {target}, 
                            ""{property.Name}""
                        ), typeof({dataType}));
                }}
                set
                {{
                    ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(
                            {target},
                            ""{property.Name}"",
                            value);
                }}
            }}";
            return (PropertyDeclarationSyntax)SyntaxFactory.ParseMemberDeclaration(propertyCode);
        }

        public enum ParsingType
        {
            AsResoniteBridgeValue=0,
            AsType=1,
            AsRaw=2
        }



        public static ParsingType GetParsingType(Type type)
        {
            string fullTypeName = GetTypeNameIncludingGenericArguments(type);
            string fieldTypeAssemblyName = ResoniteBridge.ResoniteBridgeServer.GetAssemblyName(type.Assembly);
            ParsingType parsingType = ParsingType.AsResoniteBridgeValue;
            
            // types we don't have support for
            foreach (string blackListPrefix in blackList)
            {
                if (fullTypeName.StartsWith(blackListPrefix))
                {
                    return ParsingType.AsResoniteBridgeValue;
                }
            }
            // it's one of our data models
            if (whitelist.Contains(fieldTypeAssemblyName))
            {
                parsingType = ParsingType.AsType;
            }
            // it's system (and not a generic)
            else if (fieldTypeAssemblyName.StartsWith("System"))
            {
                parsingType = ParsingType.AsRaw;
            }
            return parsingType;
        }

        public static string GetWrappedDataType(Type type)
        {
            ParsingType parsingType = GetParsingType(type);
            switch (parsingType)
            {
                case ParsingType.AsResoniteBridgeValue:
                    return "ResoniteBridge.ResoniteBridgeValue";
                case ParsingType.AsType:
                    return GetTypeNameIncludingGenericArguments(type);
                case ParsingType.AsRaw:
                    return GetTypeNameIncludingGenericArguments(type);
            }
            throw new ArgumentException("Unknown parsing type " + parsingType + " for type " + type.FullName);
        }

        public static string GetTarget(bool isStatic, string assemblyName, string typeName)
        {
            return isStatic
                        ? $@"new ResoniteBridge.ResoniteBridgeValue(
                            null,
                            ""{assemblyName}"",
                            ""{typeName}"",
                            ResoniteBridge.ResoniteBridgeValueType.Type)"
                        : "this.__Backing";
        }

        // we have to make fields properties in order to have custom getter and setters
        public static PropertyDeclarationSyntax CreateBridgeField(FieldInfo field, System.Type type)
        {
            string assemblyName = ResoniteBridge.ResoniteBridgeServer.GetAssemblyName(type.Assembly);
            string dataType = GetWrappedDataType(field.FieldType);
            bool isStatic = field.IsStatic;
            string staticStr = isStatic ? "static " : "";


            string target = GetTarget(field.IsStatic, assemblyName, type.Name);

            string fieldCode = $@"
            public {staticStr}{dataType} {field.Name}
            {{
                get
                {{
                    return ({dataType})ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(
                        ResoniteBridge.ResoniteBridgeClientWrappers.GetField(
                            {target}, 
                            ""{field.Name}""
                        ), typeof({dataType}));
                }}
                set
                {{
                    ResoniteBridge.ResoniteBridgeClientWrappers.SetField(
                            {target},
                            ""{field.Name}"",
                            value);
                }}
            }}";

            return (PropertyDeclarationSyntax)SyntaxFactory.ParseMemberDeclaration(fieldCode);
        }

        
        public static MethodDeclarationSyntax CreateBridgeMethod(MethodInfo method, System.Type type)
        {
            string assemblyName = ResoniteBridge.ResoniteBridgeServer.GetAssemblyName(type.Assembly);
            List<string> argumentStrs = new List<string>();
            List<string> variableStrs = new List<string>();
            string argumentNames = "abcdefghijklmnopqrstuvwxyz";
            foreach (ParameterInfo param in method.GetParameters())
            {
                string wrappedType = GetWrappedDataType(param.ParameterType);
                argumentStrs.Add(wrappedType + " " + param.Name);
                variableStrs.Add("" + param.Name);
            }

            string outputType = GetWrappedDataType(method.ReturnType);

            string argumentInputs = String.Join(", " + argumentNames);
            string variableInputs = String.Join(", " + variableStrs);

            if (variableInputs.Length > 0)
            {
                variableInputs = ", " + variableInputs;
            }

            string staticStr = method.IsStatic
                ? "static "
                : "";
            string target = GetTarget(method.IsStatic, assemblyName, type.Name);


            string methodCode = $@"
                    public {staticStr}{outputType} {method.Name}({argumentInputs})
                    {{
                        return ResoniteBridge.ResoniteBridgeClientWrappers.CastValue( 
                                ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(
                                {target}, 
                                ""{method.Name}""
                                {variableInputs}),
                            typeof({outputType}));
                    }}";

            return (MethodDeclarationSyntax)SyntaxFactory.ParseMemberDeclaration(methodCode);
        }
        // non static are tricky, we need to store the data in the types somehow


        public static string GetTypeNameIncludingGenericArguments(System.Type type, bool includeNamespace=true, bool includeGenericArguments=true)
        {
            string genericStr = "";
            if (type.IsGenericType)
            {
                List<string> genericStrs = new List<string>();

                foreach (Type genericType in type.GetGenericArguments())
                {
                    // stuff like <T>
                    if (type.IsGenericTypeDefinition)
                    {
                        if (includeGenericArguments)
                        {
                            genericStrs.Add(genericType.Name);
                        }
                    }
                    // specific types (like List<string>)
                    else
                    {
                        genericStrs.Add(GetTypeNameIncludingGenericArguments(genericType));
                    }
                }
                if (genericStrs.Count > 0 )
                {
                    genericStr = "<" + String.Join(", ", genericStrs) + ">";
                }
            }
            string typeName = type.Name;
            for (int i = 0; i < 10; i++)
            {
                typeName = typeName.Replace("`" + i, "");
            }
            // KeyCollection needs some special treatment
            if (type.DeclaringType != null && type.Assembly.FullName.StartsWith("System.Collections"))
            {
                string declaring = GetTypeNameIncludingGenericArguments(GetDeclaringTypeWithGenericArgs(type), includeNamespace: includeNamespace, includeGenericArguments: includeGenericArguments);
                typeName = declaring + "." + typeName;
            }
            else
            {
                typeName = typeName + genericStr;
            }
            // & doesn't work in roslyn idk why
            typeName = typeName.Replace("&", "");
            bool isGenericArray = type.IsArray && (type.GetElementType().IsGenericType || type.GetElementType().IsGenericTypeParameter);

            // generic type parameters we ignore adding namespace to (like <T>)
            if (includeNamespace && !type.IsGenericTypeParameter && !isGenericArray)
            {
                string space = GetTypeNamespace(type);
                typeName = space + "." + typeName;
            }

            // idk why these show up but they cause problems, remove them
            return ReplaceNamespaceAliases(typeName);
        }

        // cursed shit to make the generics line up
        public static Type GetDeclaringTypeWithGenericArgs(Type type)
        {
            var declaringType = type.DeclaringType;
            if (declaringType == null || !declaringType.IsGenericType)
                return declaringType;

            // Get the generic type definition of the declaring type
            var declaringGenericDefinition = declaringType.GetGenericTypeDefinition();

            // Get the generic parameters of the declaring type definition
            var declaringGenericArguments = declaringGenericDefinition.GetGenericArguments();

            // Map the generic arguments from the nested type to the declaring type's parameters
            var genericArguments = new Type[declaringGenericArguments.Length];

            for (int i = 0; i < declaringGenericArguments.Length; i++)
            {
                genericArguments[i] = declaringGenericArguments[i];
                if (type.IsGenericType)
                {
                    Type[] baseGenericArguments = type.GetGenericTypeDefinition().GetGenericArguments();
                    // look for matches to transfer over
                    for (int j = 0; j < baseGenericArguments.Length; j++)
                    {
                        if (genericArguments[i].Name == baseGenericArguments[j].Name)
                        {
                            genericArguments[i] = baseGenericArguments[j];
                        }
                    }
                }
            }

            return declaringGenericDefinition.MakeGenericType(genericArguments);
        }

        public static string GetTypeNamespace(System.Type type)
        {
            string space = type.Namespace;
            string assemblyName = ResoniteBridgeServer.GetAssemblyName(type.Assembly);

            if (space == null || space == "")
            {
                space = assemblyName;
            }
            return ReplaceNamespaceAliases(NamespaceOnlyAliases(space));
        }

        public static string NamespaceOnlyAliases(string namespaceNames)
        {
            // these overlap with namespaces of the same name so rename them
            return namespaceNames
                .Replace("FrooxEngine.Interaction", "FrooxEngine.Interacting");
        }

        public static string ReplaceNamespaceAliases(string name)
        {
            return name.Replace("FrooxEngine.FrooxEngine", "FrooxEngine")
                .Replace("ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine", "FrooxEngine")
                .Replace("FrooxEngine.ProtoFlux", "ProtoFlux");
        }

        public static NamespaceDeclarationSyntax CreateNamespaceForType(MemberDeclarationSyntax classDecleration, System.Type type)
        {
            // some various nonsense to make sure they properly go like "FrooxEngine.World" instead of just World
            string space = GetTypeNamespace(type);
            string[] pieces = space.Split(".");

            // start innermost and work outwards`
            NamespaceDeclarationSyntax curNamespace =
                SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(pieces[pieces.Length - 1]))
                .AddMembers(classDecleration);

            for (int i = pieces.Length - 2; i >= 0; i--)
            {
                curNamespace =
                    SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(pieces[i]))
                    .AddMembers(curNamespace);
            }
            return curNamespace;
        }


        public static NamespaceDeclarationSyntax WrapType(System.Type type, HashSet<Tuple<string, string>> seenItems)
        {
            string fullTypeNameWithoutNamespace = GetTypeNameIncludingGenericArguments(type, includeNamespace: false);
            string fullTypeNameWithoutGenerics = GetTypeNameIncludingGenericArguments(type, includeNamespace: false, includeGenericArguments: false);

            string inheritFrom = type.IsClass
                ? "ResoniteBridge.ClassResoniteBridgeValueHolder"
                : "ResoniteBridge.ResoniteBridgeValueHolder";

            string structOrClass = type.IsClass
                ? "class"
                : "struct";

            // specify nonnullable constraints (A : struct)
            string constraints = "";
            if (type.IsGenericType)
            {
                Type[] genericArguments = type.GetGenericArguments();
                bool[] isGenericParamNonNullable = new bool[genericArguments.Length];
                for (int i = 0; i < genericArguments.Length; i++)
                {
                    // we should also test for value type and enum but ehh it's ok
                    isGenericParamNonNullable[i] = 
                        (genericArguments[i].GenericParameterAttributes 
                        & GenericParameterAttributes.NotNullableValueTypeConstraint) != 0;
                }
                for (int i = 0; i < genericArguments.Length; i++)
                {
                    if (isGenericParamNonNullable[i])
                    {
                        constraints += " where " + genericArguments[i].Name + " : struct ";
                    }
                }
            }

            string body = "";
            // manually implement interface since structs can't inherit from structs
            if (!type.IsClass)
            {
                body = $@"
                        ResoniteBridge.ResoniteBridgeValue __backing;
                        public ResoniteBridge.ResoniteBridgeValue __Backing
                        {{
                            get
                            {{
                                return __backing;
                            }}
                            set
                            {{
                                __backing = value;
                            }}
                        }}";

            }


            string classCode = $@"public {structOrClass} {fullTypeNameWithoutNamespace} : {inheritFrom} {constraints}
            {{
                public {fullTypeNameWithoutGenerics}(ResoniteBridge.ResoniteBridgeValue backing)
                {{
                    this.__Backing = backing;
                }}

                {body}
            }}";


            ClassDeclarationSyntax classDeclaration = null;
            StructDeclarationSyntax structDeclaration = null;
            if (type.IsClass)
            {
               classDeclaration = (ClassDeclarationSyntax)SyntaxFactory.ParseMemberDeclaration(classCode);
            }
            else
            {
                structDeclaration = (StructDeclarationSyntax)SyntaxFactory.ParseMemberDeclaration(classCode);
            }
            
            HashSet<string> forbidden = new HashSet<string>()
            {
                "interface"
            };

            string fullTypeName = GetTypeNameIncludingGenericArguments(type);

            foreach (PropertyInfo property in type.GetProperties())
            {
                if (property.Name.Contains("<") || property.Name.Contains(">") || property.Name.Contains("`"))
                {

                }
                else if (property.Name != type.Name && // prevents "member names cannot be the same as their enclosing type"
                    !seenItems.Contains(new Tuple<string, string>(fullTypeName, property.Name)) // avoid duplicates
                                                                                                )
                {
                    seenItems.Add(new Tuple<string, string>(fullTypeName, property.Name));
                    PropertyDeclarationSyntax wrappedProperty = CreateBridgeProperty(property, type);
                    if (type.IsClass)
                    {
                        classDeclaration = classDeclaration.AddMembers(wrappedProperty);
                    }
                    else
                    {
                        structDeclaration = structDeclaration.AddMembers(wrappedProperty);
                    }
                }
            }

            foreach (FieldInfo field in type.GetFields())
            {
                // ignore weird generic fields
                if (field.Name.Contains("<") || field.Name.Contains(">") || field.Name.Contains("`"))
                {

                }
                else
                {
                    if (field.Name != type.Name && // prevents "member names cannot be the same as their enclosing type"
                        !seenItems.Contains(new Tuple<string, string>(fullTypeName, field.Name)) // avoid duplicates
                        && !forbidden.Contains(field.Name))
                    {
                        seenItems.Add(new Tuple<string, string>(fullTypeName, field.Name));
                        PropertyDeclarationSyntax wrappedField = CreateBridgeField(field, type);
                        if (type.IsClass)
                        {
                            classDeclaration = classDeclaration.AddMembers(wrappedField);
                        }
                        else
                        {
                            structDeclaration = structDeclaration.AddMembers(wrappedField);
                        }
                    }

                }
            }

            foreach (MethodInfo method in type.GetMethods())
            {
                if (method.Name != type.Name && // prevents "member names cannot be the same as their enclosing type"
                    !seenItems.Contains(new Tuple<string, string>(fullTypeName, method.Name)) // avoid duplicates
                    && !method.Name.Contains("`")
                                                                                                )
                {
                    seenItems.Add(new Tuple<string, string>(fullTypeName, method.Name));
                    //MethodDeclarationSyntax wrappedField = CreateBridgeMethod(method, type);
                    //classDeclaration = classDeclaration.AddMembers(wrappedField);
                    if (type.IsClass)
                    {
                        //classDeclaration = classDeclaration.AddMembers(wrappedField);
                    }
                    else
                    {
                        //structDeclaration = structDeclaration.AddMembers(wrappedField);
                    }
                }
            }
            
            if (type.IsClass)
            {
                return CreateNamespaceForType(classDeclaration, type);
            }
            else
            {
                return CreateNamespaceForType(structDeclaration, type);
            }
        }

        public static void WrapAssembly(ref NamespaceDeclarationSyntax rootNamespace, ref CompilationUnitSyntax emptyHolder, Assembly assembly, HashSet<string> typesEncountered)
        {
            HashSet<Tuple<string, string>> seenItems = new HashSet<Tuple<string, string>>();
            foreach (System.Type typeInAssembly in assembly.GetTypes())
            {
                string fullTypeName = GetTypeNameIncludingGenericArguments(typeInAssembly);
                // prevent type shadowing, just use whichever we see first
                if (!typesEncountered.Contains(fullTypeName))
                {
                    string typeNamespace = GetTypeNamespace(typeInAssembly);
                    string fullTypeNameWithoutNamespace = GetTypeNameIncludingGenericArguments(typeInAssembly, includeNamespace: false);
                    // ignore weird generic template things
                    if (!typeInAssembly.FullName.Contains("<>") &&
                        !typeInAssembly.FullName.Contains(">d") &&
                        fullTypeName != "FrooxEngine.ProtoFlux" &&// namespace and class
                        !fullTypeNameWithoutNamespace.StartsWith("<") && // weird implementation things <SpawnEntity>, <PrivateImplementationDetails>, etc.
                        !fullTypeNameWithoutNamespace.StartsWith("__StaticArray") && // idk what these are but they break stuff
                        fullTypeNameWithoutNamespace != "static" &&
                        !fullTypeName.StartsWith("FrooxEngine.Elements") && // these exist and seem useless and confuse other stuff
                        fullTypeNameWithoutNamespace != "ProtoFlux" &&// some weird type idk what its doin
                        // these 3 conflict with a namespace of the same name
                        fullTypeName != "FrooxEngine.Interactions" && 
                        fullTypeName != "FrooxEngine.Locomotion" &&
                        typeNamespace != "FrooxEngine.Animation" &&
                        // Don't define this, we need to define it ourselves
                        fullTypeName != "System.Runtime.CompilerServices.RefSafetyRulesAttribute"
                        )
                    {
                        NamespaceDeclarationSyntax wrappedType = WrapType(typeInAssembly, seenItems);
                        if (fullTypeName.StartsWith("System."))
                        {
                            emptyHolder = emptyHolder.AddMembers(wrappedType);
                        }
                        else
                        {
                            rootNamespace = rootNamespace.AddMembers(wrappedType);
                        }
                        rootNamespace = rootNamespace.AddMembers();
                        typesEncountered.Add(fullTypeName);
                    }
                }
            }
        }


        // stuff I don't feel like directly supporting
        // prefix matches
        public static List<string> blackList = new List<string>()
        {
            "System.Collections.Generic.KeyCollection",
            "System.Collections.Generic.ValueCollection",
            "POpusCodec",
            "QRCoder",
            "FrooxEngine.Sync<POpusCodec",
            "FrooxEngine.Sync<QRCoder",
            "ProtoFlux.Core.ValueOutput<TwitchLib",
            "System.Span<S>"
        };

        public static HashSet<string> whitelist = new HashSet<string>()
        {
            "FrooxEngine.Store",
            "SkyFrost.Base.Models",
            "SkyFrost.Base",
            "Elements.Assets",
            "Elements.Core",
            "Elements.Quantity",
            "ProtoFlux.Nodes.FrooxEngine",
            "ProtoFlux.Nodes.Core",
            "ProtoFlux.Core",
            //"ProtoFluxBindings",
            "FrooxEngine",
        };

        public static CompilationUnitSyntax WrapAssemblies(Dictionary<string, Assembly> assemblies, string rootNamespaceName)
        {
            HashSet<string> typesEncountered = new HashSet<string>();
            NamespaceDeclarationSyntax rootNamespace = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(rootNamespaceName));
            CompilationUnitSyntax emptyHolder = SyntaxFactory.CompilationUnit();

            foreach (KeyValuePair<string, Assembly> pair in assemblies)
            {
                Assembly assembly = pair.Value;
                if (whitelist.Contains(ResoniteBridgeServer.GetAssemblyName(pair.Value)))
                {
                    Console.WriteLine("Wrapping assembly " + pair.Key);
                    WrapAssembly(ref rootNamespace, ref emptyHolder, assembly, typesEncountered);
                    Console.WriteLine("Done wrapping assembly " + pair.Key);
                }
            }
            return emptyHolder.AddMembers(rootNamespace);
        }

        public static void CreateWrapperAssembly(Dictionary<string, Assembly> assemblies, string rootNamespaceName)
        {
            new Thread(() =>
            {
                CompilationUnitSyntax compilationUnit = WrapAssemblies(assemblies, rootNamespaceName);

                SyntaxTree syntaxTree = CSharpSyntaxTree.Create(compilationUnit);

                // netstandard 2.1 core libs
                string refPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                    "dotnet",
                    "packs",
                    "NETStandard.Library.Ref",
                    "2.1.0",
                    "ref",
                    "netstandard2.1");

                // Add core references
                var coreLibs = new[]
                {
                    "netstandard.dll",
                    "System.Runtime.dll",
                    "System.Collections.dll",
                    "mscorlib.dll"
                };

                var assemblyAttributeSource = @"namespace System.Runtime.CompilerServices
                    {
                        [AttributeUsage(AttributeTargets.Assembly)]
                        public sealed class RefSafetyRulesAttribute : Attribute
                        {
                            public RefSafetyRulesAttribute(int version) => Version = version;
                            public int Version { get; }
                        }
                    }";
                
                var references = new List<MetadataReference>();
                foreach (var lib in coreLibs)
                {
                    var path = Path.Combine(refPath, lib);
                    references.Add(MetadataReference.CreateFromFile(path));
                }
                PortableExecutableReference bridgeLib = MetadataReference.CreateFromFile(typeof(ResoniteBridge.ResoniteBridgeClient).Assembly.Location);
                references.Add(bridgeLib);
                PortableExecutableReference newtonsoftJson = MetadataReference.CreateFromFile(typeof(Newtonsoft.Json.JsonConverter).Assembly.Location);
                references.Add(newtonsoftJson);
                PortableExecutableReference systemTextJson = MetadataReference.CreateFromFile(typeof(System.Text.Json.JsonDocument).Assembly.Location);
                references.Add(systemTextJson);



                string outPath = "C:\\Users\\yams\\Desktop\\prog\\ResoniteUnityExporter\\ResoniteBridge\\ResoniteBridgeStandalone\\" + rootNamespaceName + ".dll";
                Console.WriteLine("Compiling");
                // Create compilation
                CSharpCompilation compilation = CSharpCompilation.Create(
                    rootNamespaceName,
                    syntaxTrees: new[] { CSharpSyntaxTree.ParseText(assemblyAttributeSource), syntaxTree },
                    references: references,
                    options: new CSharpCompilationOptions(
                        OutputKind.DynamicallyLinkedLibrary,
                        optimizationLevel: OptimizationLevel.Release
                    ));


                // weird stuff needed to force .NETStandard 2.1
                var targetFrameworkAttribute = compilation.SyntaxTrees.First()
                            .WithFilePath("TargetFrameworkAttribute.cs")
                            .WithRootAndOptions(
                                CSharpSyntaxTree.ParseText(@"
                                    using System.Runtime.Versioning;
                                    [assembly: TargetFramework("".NETStandard,Version=v2.1"")]
                                    ").GetRoot(),
                            compilation.SyntaxTrees.First().Options);



                compilation = compilation.AddSyntaxTrees(targetFrameworkAttribute);


                //string sourceCode = compilationUnit.ToFullString();
                string outTxt = "C:\\Users\\yams\\Desktop\\prog\\ResoniteUnityExporter\\ResoniteBridge\\" + rootNamespaceName + ".cs";

                //File.WriteAllText(outTxt, sourceCode);

                // Option 1: Write directly to file instead of keeping in memory
                using (var writer = new StreamWriter(outTxt))
                {
                    foreach (var syntaxTreef in compilation.SyntaxTrees)
                    {
                        writer.Write(syntaxTreef.ToString());
                    }
                }

                Console.WriteLine("Emitting..." + outPath);


                EmitResult result = compilation.Emit(outPath);
                if (!result.Success)
                {
                    var errors = string.Join("\n", result.Diagnostics.Select(d => d.ToString()));
                    throw new Exception($"Compilation failed: {errors}");
                }

                Console.WriteLine("Done!");

            }).Start();
            /*
            using (MemoryStream ms = new MemoryStream())
            {
                EmitResult result = compilation.Emit(ms);
                if (!result.Success)
                {
                    var errors = string.Join("\n", result.Diagnostics.Select(d => d.ToString()));
                    throw new Exception($"Compilation failed: {errors}");
                }
                ms.Seek(0, SeekOrigin.Begin);
            }
            */

            



        }

    }


}
