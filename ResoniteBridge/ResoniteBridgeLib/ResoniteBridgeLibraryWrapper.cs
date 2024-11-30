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

namespace ResoniteBridge
{
    public class ResoniteBinaryWrapper
    {
        public static PropertyDeclarationSyntax CreateBridgeProperty(PropertyInfo property, System.Type type)
        {
            string assemblyName = ResoniteBridge.ResoniteBridgeServer.GetAssemblyName(type.Assembly);
            bool isStatic = property.GetAccessors(nonPublic: true)[0].IsStatic;
            string staticStr = isStatic ? "static " : "";
            string propertyCode = $@"
            public {staticStr}ResoniteBridge.ResoniteBridgeValue {property.Name}
            {{
                get
                {{
                    return ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue()
                    {{
                        assemblyName = ""{assemblyName}"",
                        typeName = ""{type.Name}"",
                        valueType = ResoniteBridge.ResoniteBridgeValueType.Type,
                    }}, ""{property.Name}"");
                }}
                set
                {{
                    ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(new ResoniteBridge.ResoniteBridgeValue()
                    {{
                        assemblyName = ""{assemblyName}"",
                        typeName = ""{type.Name}"",
                        valueType = ResoniteBridge.ResoniteBridgeValueType.Type
                    }}, ""{property.Name}"", value);
                }}
            }}";

            return (PropertyDeclarationSyntax)SyntaxFactory.ParseMemberDeclaration(propertyCode);
        }

        public static string FullTypeName(System.Type type)
        {
            string space = GetTypeNamespace(type);
            return space + "." + type.Name;
        }

        public static string GetTypeNamespace(System.Type type)
        {
            string space = type.Namespace;
            string assemblyName = ResoniteBridgeServer.GetAssemblyName(type.Assembly);

            if (space == null || space == "")
            {
                space = assemblyName;
            }
            return space;
        }

        public static NamespaceDeclarationSyntax CreateNamespaceForType(ClassDeclarationSyntax classDecleration, System.Type type)
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
            ClassDeclarationSyntax classDeclaration = SyntaxFactory.ClassDeclaration(type.Name)
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword));

            string fullTypeName = FullTypeName(type);
            foreach (PropertyInfo property in type.GetProperties())
            {
                if (!seenItems.Contains(new Tuple<string, string>(fullTypeName, property.Name)))
                {
                    seenItems.Add(new Tuple<string, string>(fullTypeName, property.Name));
                    PropertyDeclarationSyntax wrappedProperty = CreateBridgeProperty(property, type);
                    classDeclaration = classDeclaration.AddMembers(wrappedProperty);
                }
            }

            return CreateNamespaceForType(classDeclaration, type);
        }

        public static NamespaceDeclarationSyntax WrapAssembly(NamespaceDeclarationSyntax rootNamespace, Assembly assembly, HashSet<string> typesEncountered)
        {
            HashSet<Tuple<string, string>> seenItems = new HashSet<Tuple<string, string>>();
            foreach (System.Type typeInAssembly in assembly.GetTypes())
            {
                string fullTypeName = FullTypeName(typeInAssembly);
                // prevent type shadowing, just use whichever we see first
                if (!typesEncountered.Contains(fullTypeName))
                {
                    // ignore weird generic template things
                    if (!typeInAssembly.FullName.Contains("<>c") &&
                        !typeInAssembly.FullName.Contains("<Execute>d") &&
                        !typeInAssembly.FullName.Contains("<>O") &&
                        !typeInAssembly.FullName.Contains("<GetEnumerator>d"))
                    {
                        rootNamespace = rootNamespace.AddMembers(
                            WrapType(typeInAssembly, seenItems));
                        typesEncountered.Add(fullTypeName);
                    }
                }
            }
            return rootNamespace;
        }

        public static HashSet<string> whitelist = new HashSet<string>()
        {
            "FrooxEngine.Store",
            "SkyFrost.Base.Models",
            "SkyFrost.Base",
            "Elements.Assets",
            "Elements.Core",
            "ProtoFlux.Nodes.FrooxEngine",
            "ProtoFlux.Nodes.Core",
            "ProtoFluxBindings",
            "FrooxEngine",
        };

        public static NamespaceDeclarationSyntax WrapAssemblies(Dictionary<string, Assembly> assemblies, string rootNamespaceName)
        {
            HashSet<string> typesEncountered = new HashSet<string>();
            NamespaceDeclarationSyntax rootNamespace = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(rootNamespaceName));

            foreach (KeyValuePair<string, Assembly> pair in assemblies)
            {
                Assembly assembly = pair.Value;
                if (whitelist.Contains(ResoniteBridgeServer.GetAssemblyName(pair.Value)))
                {
                    Console.WriteLine("Wrapping assembly " + pair.Key);
                    rootNamespace = WrapAssembly(rootNamespace, assembly, typesEncountered);
                    Console.WriteLine("Done wrapping assembly " + pair.Key);
                }
            }
            return rootNamespace;
        }

        public static void CreateWrapperAssembly(Dictionary<string, Assembly> assemblies, string rootNamespaceName)
        {
            new Thread(() =>
            {
                NamespaceDeclarationSyntax rootNamespace = WrapAssemblies(assemblies, rootNamespaceName);
                CompilationUnitSyntax compilationUnit = SyntaxFactory.CompilationUnit()
                    .AddMembers(rootNamespace);

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
                };

                var references = new List<MetadataReference>();
                foreach (var lib in coreLibs)
                {
                    var path = Path.Combine(refPath, lib);
                    references.Add(MetadataReference.CreateFromFile(path));
                }
                PortableExecutableReference bridgeLib = MetadataReference.CreateFromFile(typeof(ResoniteBridge.ResoniteBridgeClient).Assembly.Location);
                references.Add(bridgeLib);


                string outPath = "C:\\Users\\yams\\Desktop\\prog\\ResoniteUnityExporter\\ResoniteBridge\\ResoniteBridgeStandalone\\" + rootNamespaceName + ".dll";
                Console.WriteLine("Compiling");
                // Create compilation
                CSharpCompilation compilation = CSharpCompilation.Create(
                    rootNamespaceName,
                    syntaxTrees: new[] { syntaxTree },
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
