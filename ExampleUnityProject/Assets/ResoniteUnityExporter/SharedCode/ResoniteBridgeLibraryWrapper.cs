using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
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
            string propertyCode = $@"
            public ResoniteBridge.ResoniteBridgeValue {property.Name}
            {{
                get
                {{
                    return ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridgeValue()
                    {{
                        assemblyName = ""{assemblyName}"",
                        typeName = ""{type.Name}"",
                        valueType = ResoniteBridgeValueType.Type,
                    }}, ""{property.Name}"");
                }}
                set
                {{
                    ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(new ResoniteBridgeValue()
                    {{
                        assemblyName = ""{assemblyName}"",
                        typeName = ""{type.Name}"",
                        valueType = ResoniteBridgeValueType.Type
                    }}, ""{property.Name}"", value);
                }}
            }}";

            return (PropertyDeclarationSyntax)SyntaxFactory.ParseMemberDeclaration(propertyCode);
        }

        public static NamespaceDeclarationSyntax CreateNamespaceForType(ClassDeclarationSyntax classDecleration, System.Type type)
        {
            string[] pieces = type.Namespace.Split(".");

            // start innermost and work outwards
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


        public static NamespaceDeclarationSyntax WrapType(System.Type type)
        {
            ClassDeclarationSyntax classDeclaration = SyntaxFactory.ClassDeclaration(type.Name)
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword));

            foreach (PropertyInfo property in type.GetProperties())
            {
                PropertyDeclarationSyntax wrappedProperty = CreateBridgeProperty(property, type);
                classDeclaration = classDeclaration.AddMembers(wrappedProperty);
            }

            return CreateNamespaceForType(classDeclaration, type);
        }

        public static NamespaceDeclarationSyntax WrapAssembly(NamespaceDeclarationSyntax rootNamespace, Assembly assembly, HashSet<string> typesEncountered)
        {
            foreach (System.Type typeInAssembly in assembly.GetTypes())
            {
                // prevent type shadowing, just use whichever we see first
                if (!typesEncountered.Contains(typeInAssembly.FullName))
                {
                    rootNamespace = rootNamespace.AddMembers(
                        WrapType(typeInAssembly));
                    typesEncountered.Add(typeInAssembly.FullName);
                }
            }
            return rootNamespace;
        }

        public static NamespaceDeclarationSyntax WrapAssemblies(Dictionary<string, Assembly> assemblies, string rootNamespaceName)
        {
            HashSet<string> typesEncountered = new HashSet<string>();
            NamespaceDeclarationSyntax rootNamespace = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(rootNamespaceName));

            foreach (KeyValuePair<string, Assembly> pair in assemblies)
            {
                Assembly assembly = pair.Value;
                rootNamespace = WrapAssembly(rootNamespace, assembly, typesEncountered);
            }
            return rootNamespace;
        }

        public static void CreateWrapperAssembly(Dictionary<string, Assembly> assemblies, string rootNamespaceName)
        {
            NamespaceDeclarationSyntax rootNamespace = WrapAssemblies(assemblies, rootNamespaceName);
            CompilationUnitSyntax compilationUnit = SyntaxFactory.CompilationUnit()
                .AddMembers(rootNamespace);

            SyntaxTree syntaxTree = CSharpSyntaxTree.Create(compilationUnit);

            // Get reference to netstandard.dll
            PortableExecutableReference netstandardLib = MetadataReference.CreateFromFile(Assembly.Load("netstandard").Location);
            PortableExecutableReference bridgeLib = MetadataReference.CreateFromFile(typeof(ResoniteBridge.ResoniteBridgeClient).Assembly.Location);

            // Create compilation
            CSharpCompilation compilation = CSharpCompilation.Create(
                rootNamespaceName,
                syntaxTrees: new[] { syntaxTree },
                references: new[]
                {
                netstandardLib,
                bridgeLib
                },
                options: new CSharpCompilationOptions(
                    OutputKind.DynamicallyLinkedLibrary,
                    optimizationLevel: OptimizationLevel.Release
                ));

            compilation.Emit(rootNamespaceName + ".dll");
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
