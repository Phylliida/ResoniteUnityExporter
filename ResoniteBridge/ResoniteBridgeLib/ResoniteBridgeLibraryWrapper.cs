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
using System.Xml.Serialization;
using System.CodeDom.Compiler;
using System.CodeDom;
using System.Xml.Linq;

using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.TypeSystem;
using ICSharpCode.Decompiler.CSharp.Syntax;
using ICSharpCode.Decompiler.CSharp.OutputVisitor;
using ICSharpCode.Decompiler.Metadata;
using System.Reflection.Metadata.Ecma335;
using ICSharpCode.Decompiler.CSharp.Syntax.PatternMatching;
using System.Text;

namespace ResoniteBridge
{
    // probably a better option is to just send the code and generate dll on mod side
    // but idk this gives us autocomplete and stuff which is kinda nice
    public class ResoniteBinaryWrapper
    {

        public static void AddBackingDeclaration(TypeDeclaration typeDeclaration)
        {
            // Create backing field
            var backingField = new FieldDeclaration
            {
                ReturnType = new SimpleType("ResoniteBridge.ResoniteBridgeValue"),
                Variables = { new VariableInitializer("__backing") },
                Modifiers = Modifiers.Private
            };

            // Create backing property
            var backingProperty = new PropertyDeclaration
            {
                Name = "__Backing",
                ReturnType = new SimpleType("ResoniteBridge.ResoniteBridgeValue"),
                Modifiers = Modifiers.Public,

                // Getter
                Getter = new Accessor
                {
                    Body = new BlockStatement {
                        new ReturnStatement(
                            new MemberReferenceExpression(
                                new ThisReferenceExpression(),
                                "__backing"
                            )
                        )
                    }
                },

                // Setter
                Setter = new Accessor
                {
                    Body = new BlockStatement {
                        new ExpressionStatement(
                            new AssignmentExpression(
                                new MemberReferenceExpression(
                                    new ThisReferenceExpression(),
                                    "__backing"
                                ),
                                new IdentifierExpression("value")
                            )
                        )
                    }
                }
            };

            typeDeclaration.Members.Add(backingField);
            typeDeclaration.Members.Add(backingProperty);
        }
        public static string NodeToString(AstNode node)
        {
            return node.ToString();
        }

        public static void TraverseSyntaxNodes(AstNode node, Action<AstNode> action)
        {
            if (node == null)
                return;

            // Process current node
            action(node);

            // Recursively process all children
            foreach (var child in node.Children)
            {
                TraverseSyntaxNodes(child, action);
            }
        }

        public static string GetTypeDeclarationNamespace(ICSharpCode.Decompiler.CSharp.Syntax.TypeDeclaration typeDeclaration)
        {
            return String.Join(".",
                typeDeclaration.Ancestors.OfType<ICSharpCode.Decompiler.CSharp.Syntax.NamespaceDeclaration>()
                .Select(n => n.Name));
        }

        public static BlockStatement WrapMethod(bool isStatic, MethodDeclaration methodDeclaration, Expression staticTarget, Expression instanceTarget)
        {
            var methodNameExp = new PrimitiveExpression(methodDeclaration.Name);
            var clientWrappers = new TypeReferenceExpression(new SimpleType("ResoniteBridge.ResoniteBridgeClientWrappers"));

            List<Expression> invocationParams = new List<Expression>();
            invocationParams.Add(isStatic
                ? staticTarget.Clone() 
                : instanceTarget.Clone());

            invocationParams.Add(methodNameExp);

            foreach (var param in methodDeclaration.Parameters)
            {
                invocationParams.Add(new IdentifierExpression(param.NameToken.ToString()));
            }

            InvocationExpression invocation = new InvocationExpression(
                new MemberReferenceExpression(clientWrappers, "CallMethod"),
                invocationParams);


            if (methodDeclaration.ReturnType.ToString() != "void")
            {
                var castValueCall = new InvocationExpression(
                    new MemberReferenceExpression(clientWrappers.Clone(), "CastValue"),
                    invocation,
                    new TypeOfExpression(methodDeclaration.ReturnType.Clone())
                );

                var castExpression = new CastExpression(
                    methodDeclaration.ReturnType.Clone(),
                    castValueCall
                );

                return new BlockStatement {
                    new ReturnStatement(castExpression)
                };
            }
            else
            {
                return new BlockStatement
                {
                    invocation
                };
            }
        }

        public static Accessor WrapSetter(bool isStatic, string setterName, Expression staticTarget, Expression instanceTarget, string setMethodName)
        {
            var setterNameExp = new PrimitiveExpression(setterName);
            var clientWrappers = new TypeReferenceExpression(new SimpleType("ResoniteBridge.ResoniteBridgeClientWrappers"));
            var valueExp = new IdentifierExpression("value");

            InvocationExpression invocation = new InvocationExpression(
                new MemberReferenceExpression(clientWrappers, setMethodName),
                isStatic
                    ? new Expression[] { staticTarget.Clone(), setterNameExp, valueExp }
                    : new Expression[] { instanceTarget.Clone(), setterNameExp, valueExp }
            );
            return new Accessor
            {
                Body = new BlockStatement
                {
                    invocation
                }
            };
        }


        public static Accessor WrapGetter(bool isStatic, AstType getterType, string getterName, ObjectCreateExpression staticTarget, MemberReferenceExpression instanceTarget, string getMethodName)
        {
            var getterNameExp = new PrimitiveExpression(getterName);
            var clientWrappers = new TypeReferenceExpression(new SimpleType("ResoniteBridge.ResoniteBridgeClientWrappers"));

            var getterCall = new InvocationExpression(
                new MemberReferenceExpression(clientWrappers.Clone(), getMethodName),
                isStatic
                    ? new Expression[] { staticTarget.Clone(), getterNameExp } // have to clone or it gets angry
                    : new Expression[] { instanceTarget.Clone(), getterNameExp }
            );

            var castValueCall = new InvocationExpression(
                new MemberReferenceExpression(clientWrappers, "CastValue"),
                getterCall,
                new TypeOfExpression(getterType.Clone())
            );

            var castExpression = new CastExpression(
                getterType.Clone(),
                castValueCall
            );

            return new Accessor
            {
                Body = new BlockStatement
                {
                    new ReturnStatement(castExpression)
                }
            };
        }

        public static ConstructorDeclaration CreateBackingConstructor(TypeDeclaration typeDeclaration)
        {
            return new ConstructorDeclaration
            {
                Name = typeDeclaration.NameToken.ToString(),
                Modifiers = Modifiers.Public,
                Parameters = {
                    new ParameterDeclaration(
                        new SimpleType("ResoniteBridge.ResoniteBridgeValue"),
                        "value"
                    )
                },
                Body = new BlockStatement {
                    new ExpressionStatement(
                        new AssignmentExpression(
                            new MemberReferenceExpression(
                                new ThisReferenceExpression(),
                                "__Backing"
                            ),
                            new IdentifierExpression("value")
                        )
                    )
                }
            };
        }

        public static string WrapAssembly(Assembly assembly, out string usings)
        {

            string assemblyName = ResoniteBridgeServer.GetAssemblyName(assembly);
            var decompiler = new CSharpDecompiler(assembly.Location, new DecompilerSettings());
            Console.WriteLine("Decompiling");
            var decompTree = decompiler.DecompileWholeModuleAsSingleFile();
            Console.WriteLine("Decompiled");

            // Get all the usings and replace them with empty
            // Because we need them all at the start
            StringBuilder usingStatements = new StringBuilder();
            TraverseSyntaxNodes(decompTree, (astNode) =>
            {
                if (astNode is ICSharpCode.Decompiler.CSharp.Syntax.UsingDeclaration ||
                    astNode is UsingAliasDeclaration)
                {
                    usingStatements.AppendLine(astNode.ToString());
                    astNode.ReplaceWith(new EmptyStatement());
                }
            });
            usings = usingStatements.ToString();

            TraverseSyntaxNodes(decompTree, (astNode) =>
            {
                if (astNode is ICSharpCode.Decompiler.CSharp.Syntax.TypeDeclaration typeDeclare)
                {
                    // Add ResoniteBridgeValueHolder interface
                    typeDeclare.BaseTypes.Add(new SimpleType("ResoniteBridge.ResoniteBridgeValueHolder"));

                    // implement ResoniteBridgeValueHolder interface
                    AddBackingDeclaration(typeDeclare);

                    // implement constructor from ResoniteBridgeValue (needed for CastValue)
                    var constructorDeclaration = CreateBackingConstructor(typeDeclare);
                    typeDeclare.Members.Add(constructorDeclaration);

                    var staticTarget = new ObjectCreateExpression(
                        new SimpleType("ResoniteBridge.ResoniteBridgeValue"),
                        new Expression[] {
                            new PrimitiveExpression(null),
                            new PrimitiveExpression(assemblyName),
                            new PrimitiveExpression(typeDeclare.Name),
                            new MemberReferenceExpression(
                                new TypeReferenceExpression(new SimpleType("ResoniteBridge.ResoniteBridgeValueType")),
                                "Type"
                            )
                        }
                    );

                    var instanceTarget = new MemberReferenceExpression(
                        new ThisReferenceExpression(),
                        "__Backing"
                    );

                    TraverseSyntaxNodes(astNode, (childNode) =>
                    {
                        if (childNode is ICSharpCode.Decompiler.CSharp.Syntax.MethodDeclaration methodDeclare)
                        {
                            bool isStatic = methodDeclare.Modifiers.HasFlag(Modifiers.Static);
                            methodDeclare.Body = WrapMethod(
                                isStatic,
                                methodDeclare,
                                staticTarget,
                                instanceTarget);
                        }
                        else if(childNode is PropertyDeclaration propertyDeclare)
                        {
                            string propertyName = propertyDeclare.NameToken.ToString();
                            if (propertyName != "__Backing") // don't override our own backing
                            {
                                AstType returnType = propertyDeclare.ReturnType;

                                bool isStatic = propertyDeclare.Modifiers.HasFlag(Modifiers.Static);
                                Accessor getter = WrapGetter(isStatic,
                                    returnType,
                                    propertyName,
                                    staticTarget,
                                    instanceTarget,
                                    "GetProperty"
                                );

                                Accessor setter = WrapSetter(isStatic,
                                    propertyName,
                                    staticTarget,
                                    instanceTarget,
                                    "SetProperty");

                                propertyDeclare.Getter = getter;
                                propertyDeclare.Setter = setter;
                            }
                        }
                        else if(childNode is FieldDeclaration fieldDeclare)
                        {
                            // fieldDeclare.NameToken is null
                            VariableInitializer variableInit = fieldDeclare.Children.OfType<VariableInitializer>().First();
                            string fieldName = variableInit.NameToken.ToString();
                            if (fieldName != "__backing")
                            {
                                AstType returnType = fieldDeclare.ReturnType;

                                bool isStatic = fieldDeclare.Modifiers.HasFlag(Modifiers.Static);
                                Accessor getter = WrapGetter(isStatic,
                                    returnType,
                                    fieldName,
                                    staticTarget,
                                    instanceTarget,
                                    "GetField"
                                );

                                Accessor setter = WrapSetter(isStatic,
                                    fieldName,
                                    staticTarget,
                                    instanceTarget,
                                    "SetField");

                                if (fieldDeclare.Modifiers.HasFlag(Modifiers.Const))
                                {
                                    // we need to make it not const bc properties can't be const
                                    // (well, our wrapper ones can't be)
                                    fieldDeclare.Modifiers &= ~Modifiers.Const;
                                }
                                var fieldProperty = new PropertyDeclaration
                                {
                                    Name = fieldName,
                                    ReturnType = fieldDeclare.ReturnType.Clone(),
                                    Modifiers = fieldDeclare.Modifiers,
                                    Getter = getter,
                                    Setter = setter
                                };
                                fieldDeclare.ReplaceWith(fieldProperty);
                            }
                        }
                    });
                }
            });

            var writer = new StringWriter();
            var visitor = new CSharpOutputVisitor(writer, FormattingOptionsFactory.CreateAllman());
            decompTree.AcceptVisitor(visitor);
            return writer.ToString();
        }

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
            //"FrooxEngine",
        };

        public static string WrapAssemblies(Dictionary<string, Assembly> assemblies)
        {
            StringBuilder outCode = new StringBuilder();
            StringBuilder outUsings = new StringBuilder();
            // might be modified so have to make a copy
            foreach (KeyValuePair<string, Assembly> pair in new Dictionary<string, Assembly>(assemblies))
            {
                Assembly assembly = pair.Value;
                if (whitelist.Contains(ResoniteBridgeServer.GetAssemblyName(pair.Value)))
                {
                    Console.WriteLine("Wrapping assembly " + pair.Key);
                    string outputCode = WrapAssembly(assembly, out string usings);
                    outUsings.AppendLine(usings);
                    outCode.Append("\n" + outputCode + "\n");
                    Console.WriteLine("Done wrapping assembly " + pair.Key);
                }
            }
            return outUsings.ToString() + "\n" + outCode.ToString();
        }

        public static void DefineNamespaceAliases(CodeCompileUnit compileUnit)
        {
            var globalNamespace = new CodeNamespace("");
            globalNamespace.Imports.Add(new CodeNamespaceImport("ProtoFlux"));
            globalNamespace.Imports.Add(new CodeNamespaceImport("FrooxEngine"));
            globalNamespace.Imports.Add(new CodeNamespaceImport("ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine = FrooxEngine"));
            globalNamespace.Imports.Add(new CodeNamespaceImport("FrooxEngine.ProtoFlux = ProtoFlux"));

            compileUnit.Namespaces.Add(globalNamespace);
        }

        public static void CreateWrapperAssembly(Dictionary<string, Assembly> assemblies, string rootNamespaceName)
        {
            new Thread(() =>
            {
            string outTxt = "C:\\Users\\yams\\Desktop\\prog\\ResoniteUnityExporter\\ResoniteBridge\\" + rootNamespaceName + ".cs";
            string outErrors = "C:\\Users\\yams\\Desktop\\prog\\ResoniteUnityExporter\\ResoniteBridge\\" + rootNamespaceName + "errors.cs";

            // Create CodeDom provider for C#
            using (var provider = CodeDomProvider.CreateProvider("CSharp"))
            {
                // Create compilation unit
                var compileUnit = new CodeCompileUnit();

                DefineNamespaceAliases(compileUnit);

                string allCode = WrapAssemblies(assemblies);

                Console.WriteLine("Writing code to file");

                File.WriteAllText(outTxt, allCode);

                Console.WriteLine("Done writing to file");
            }
            Console.WriteLine("Parsing code");

            Microsoft.CodeAnalysis.SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(File.ReadAllText(outTxt));

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

            Console.WriteLine("Emitting..." + outPath);

            EmitResult result = compilation.Emit(outPath);
            StringBuilder allErrors = new StringBuilder();
            if (!result.Success)
            {
                foreach (Diagnostic diagnostic in result.Diagnostics)
                {
                    if (diagnostic.Severity == DiagnosticSeverity.Error)
                    {
                        Console.WriteLine(diagnostic.ToString());
                        allErrors.AppendLine(diagnostic.ToString());
                    }
                }
                File.WriteAllText(outErrors, allErrors.ToString());
                throw new Exception($"Compilation failed");
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
