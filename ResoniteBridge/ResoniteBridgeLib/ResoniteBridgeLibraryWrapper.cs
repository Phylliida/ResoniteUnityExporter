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
using Microsoft.CodeAnalysis.Text;
using ICSharpCode.Decompiler.TypeSystem.Implementation;
using ICSharpCode.Decompiler.IL.Patterns;
using ICSharpCode.Decompiler.Semantics;

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
                            new IdentifierExpression(
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
                                new IdentifierExpression("__backing"),
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

        public static string GetTypeDeclarationName(TypeDeclaration typeDeclaration)
        {
            return typeDeclaration.NameToken.ToString();
        }

        public static string GetTypeDeclarationNamespace(ICSharpCode.Decompiler.CSharp.Syntax.TypeDeclaration typeDeclaration)
        {
            return String.Join(".",
                typeDeclaration.Ancestors.OfType<ICSharpCode.Decompiler.CSharp.Syntax.NamespaceDeclaration>()
                .Select(n => n.Name));
        }

        public struct TypeDeclarationInfo
        {
            public string typeNamespace;
            public string parentTypes;
            public string name;
            public string fullName;
            public IType type;
            public TypeDeclarationInfo(TypeDeclaration typeDeclaration)
            {
                List<string> pieces = new List<string>();

                this.typeNamespace = GetTypeDeclarationNamespace(typeDeclaration);
                if (typeNamespace.Length > 0)
                {
                    pieces.Add(typeNamespace);
                }
                this.parentTypes = String.Join(".",
                    typeDeclaration.Ancestors.OfType<ICSharpCode.Decompiler.CSharp.Syntax.TypeDeclaration>()
                    .Select(td => GetTypeDeclarationName(td)));

                if (parentTypes.Length > 0)
                {
                    pieces.Add(parentTypes);
                }
                name = typeDeclaration.NameToken.ToString();
                pieces.Add(name);
                fullName = String.Join(".", name);

                ICSharpCode.Decompiler.Semantics.TypeResolveResult resolveAnnotation =
                    typeDeclaration.Annotations
                    .OfType<ICSharpCode.Decompiler.Semantics.TypeResolveResult>()
                    .FirstOrDefault();
                if (!resolveAnnotation.IsError && resolveAnnotation.Type != null)
                {
                    this.type = resolveAnnotation.Type;
                    this.fullName = type.FullName;
                }
                else
                {
                    this.type = null;
                }

            }
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


        public static Accessor WrapGetter(bool isStatic, AstType getterType, string getterName, ObjectCreateExpression staticTarget, Expression instanceTarget, string getMethodName)
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
                            new IdentifierExpression(
                                "__backing"
                            ),
                            new IdentifierExpression("value")
                        )
                    )
                }
            };
        }

        public static ConstructorDeclaration CreateDefaultConstructor(TypeDeclaration typeDeclaration)
        {
            return new ConstructorDeclaration
            {
                Name = typeDeclaration.NameToken.ToString(),
                Modifiers = Modifiers.Public,
                Parameters = {

                },
                Body = new BlockStatement {
                }
            };
        }

        public static AstNode MakeEmptyStatement()
        {
            return new Comment("", CommentType.SingleLine);
        }
        public static bool IsAttribute(TypeDeclaration typeDeclaration)
        {
            return typeDeclaration.BaseTypes
                .Any(baseType => baseType.ToString() == "Attribute" ||
                                baseType.ToString() == "System.Attribute");
        }

        public static void ReplaceUnmanagedConstraintWithStruct(Constraint constraint, List<AstNode> removeAsts)
        {
            TraverseSyntaxNodes(constraint, (constraintChildNode) =>
            {
                if (constraintChildNode is PrimitiveType primitiveType &&
                    primitiveType.Keyword == "unmanaged")
                {
                    primitiveType.ReplaceWith(new PrimitiveType("struct"));
                }
                // keep struct ones
                else if (constraintChildNode is PrimitiveType primitiveType2 &&
                    primitiveType2.Keyword == "struct")
                {

                }
                // remove rest
                else
                {
                    //removeAsts.Add(constraint);
                }
            });
        }

        public static string WrapAssembly(Assembly assembly, TypeInfoLookup typeInfoLookup, SimpleTypeResolveContext resolveContext, HashSet<string> namespaceList, out string usings)
        {
            string assemblyName = ResoniteBridgeServer.GetAssemblyName(assembly);
            var decompiler = new CSharpDecompiler(assembly.Location, new DecompilerSettings());
            Console.WriteLine("Decompiling");
            var decompTree = decompiler.DecompileWholeModuleAsSingleFile();

            // Get all the usings and replace them with empty
            // Because we need them all at the start

            bool foundTypeDec = false;


            List<AstNode> nodesToRemove = new List<AstNode>();

            TraverseSyntaxNodes(decompTree, (astNode) =>
            {
                if (astNode is ICSharpCode.Decompiler.CSharp.Syntax.TypeDeclaration typeDeclare)
                {
                    string typeNamespace = GetTypeDeclarationNamespace(typeDeclare);
                    // none of these spooky beasts
                    if (ForbiddenNamespaces.Contains(typeNamespace))
                    {
                        nodesToRemove.Add(typeDeclare);
                        return;
                    }
                    // compiler generated, ignore
                    if (typeDeclare.NameToken.ToString().StartsWith("<>c") ||
                        typeDeclare.NameToken.ToString().Contains("FunctionProxy")) // we aren't gonna wrap all function proxies, they confuse ILSpy
                    {
                        nodesToRemove.Add(typeDeclare);
                        return;
                    }

                    int numConstructors = 0;

                    // don't mess with enums, static classes, and attributes
                    if (typeDeclare.ClassType != ClassType.Enum
                    && !typeDeclare.Modifiers.HasFlag(Modifiers.Static)
                    && !IsAttribute(typeDeclare))
                    {
                        // Add ResoniteBridgeValueHolder interface
                        typeDeclare.BaseTypes.Add(new SimpleType("ResoniteBridge.ResoniteBridgeValueHolder"));

                        // interfaces don't need the implementations
                        if (typeDeclare.ClassType != ClassType.Interface)
                        {
                            // implement ResoniteBridgeValueHolder interface
                            AddBackingDeclaration(typeDeclare);

                            // abstract class doesn't need the constructor
                            if (!typeDeclare.Modifiers.HasFlag(Modifiers.Abstract))
                            {
                                // implement constructor from ResoniteBridgeValue (needed for CastValue)
                                var constructorDeclaration = CreateBackingConstructor(typeDeclare);
                                typeDeclare.Members.Add(constructorDeclaration);
                                numConstructors -= 1;
                            }
                        }
                    }

                    // replace : where T is unmanaged with : where T is struct to allow our hacky stuff
                    foreach (var constraint in typeDeclare.Constraints)
                    {
                        ReplaceUnmanagedConstraintWithStruct(constraint, nodesToRemove);
                    }

                    // no readonly because we are just wrappers (and the backing could change)
                    if (typeDeclare.Modifiers.HasFlag(Modifiers.Readonly))
                    {
                        typeDeclare.Modifiers &= ~Modifiers.Readonly;
                    }

                    // we don't need to do anything else for interfaces and abstract classes, bail
                    if (typeDeclare.ClassType == ClassType.Interface || typeDeclare.Modifiers.HasFlag(Modifiers.Abstract))
                    {
                        return;
                    }




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

                    var instanceTarget = new IdentifierExpression(
                        "__Backing"
                    );


                    TraverseSyntaxNodes(astNode, (childNode) =>
                    {
                        if (childNode is ICSharpCode.Decompiler.CSharp.Syntax.ConstructorDeclaration constructor)
                        {
                            numConstructors += 1;
                        }
                        if (childNode is ICSharpCode.Decompiler.CSharp.Syntax.MethodDeclaration methodDeclare)
                        {
                            // no getters or setters, stap
                            if (methodDeclare.NameToken.ToString().StartsWith("get_") ||
                            methodDeclare.NameToken.ToString().StartsWith("set_"))
                            {
                                nodesToRemove.Add(methodDeclare);
                            }
                            else
                            {
                                bool isStatic = methodDeclare.Modifiers.HasFlag(Modifiers.Static);
                                methodDeclare.Body = WrapMethod(
                                    isStatic,
                                    methodDeclare,
                                    staticTarget,
                                    instanceTarget);


                                foreach (var constraint in methodDeclare.Constraints)
                                {
                                    ReplaceUnmanagedConstraintWithStruct(constraint, nodesToRemove);
                                }
                            }
                        }
                        else if (childNode is PropertyDeclaration propertyDeclare)
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
                                // we don't need these because they'll be called on frooxengine side
                                propertyDeclare.Initializer = null;
                            }
                        }
                        else if (childNode is FieldDeclaration fieldDeclare)
                        {
                            // fieldDeclare.NameToken is null
                            VariableInitializer variableInit = fieldDeclare.Children.OfType<VariableInitializer>().First();
                            string fieldName = variableInit.NameToken.ToString();
                            if (fieldName != "__backing")
                            {
                                AstType returnType = fieldDeclare.ReturnType;

                                bool isStatic = fieldDeclare.Modifiers.HasFlag(Modifiers.Static) ||
                                    typeDeclare.Modifiers.HasFlag(Modifiers.Static);
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
                                if (fieldDeclare.Modifiers.HasFlag(Modifiers.Readonly))
                                {
                                    // Don't allow readonly ones bc that confuses compiler
                                    fieldDeclare.Modifiers &= ~Modifiers.Readonly;
                                }
                                if (fieldDeclare.Modifiers.HasFlag(Modifiers.Volatile))
                                {
                                    // Don't allow volatile ones bc no need since we are just a wrapper
                                    fieldDeclare.Modifiers &= ~Modifiers.Volatile;
                                }

                                // inherit static from parent
                                if (!fieldDeclare.Modifiers.HasFlag(Modifiers.Static) &&
                                    typeDeclare.Modifiers.HasFlag(Modifiers.Static))
                                {
                                    fieldDeclare.Modifiers |= Modifiers.Static;
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
                    // we need to add default constructor since we define a different alternative one
                    // but don't do it for enums or static classes
                    if (numConstructors == 0
                        && typeDeclare.ClassType != ClassType.Enum
                        && !typeDeclare.Modifiers.HasFlag(Modifiers.Static))
                    {
                        ConstructorDeclaration defaultConstructor = CreateDefaultConstructor(typeDeclare);
                        typeDeclare.Members.Add(defaultConstructor);
                    }
                }
            });


            // remove using statements 
            
            
            // replace all unresolved types with ResoniteBridgeValue
            TraverseSyntaxNodes(decompTree, (astNode) =>
            {
                if(astNode is ICSharpCode.Decompiler.CSharp.Syntax.MethodDeclaration methodDeclare )
                {
                    ReplaceTypeIfUnresolved(methodDeclare.ReturnType, resolveContext, namespaceList);
                }
                else if (astNode is ParameterDeclaration paramDeclare)
                {
                    ReplaceTypeIfUnresolved(paramDeclare.Type, resolveContext, namespaceList);
                }
                else if (astNode is ICSharpCode.Decompiler.CSharp.Syntax.PropertyDeclaration propertyDeclare)
                {
                    ReplaceTypeIfUnresolved(propertyDeclare.ReturnType, resolveContext, namespaceList);
                }
                else if(astNode is ICSharpCode.Decompiler.CSharp.Syntax.FieldDeclaration fieldDeclare )
                {
                    ReplaceTypeIfUnresolved(fieldDeclare.ReturnType, resolveContext, namespaceList);
                }
                else if(astNode is ICSharpCode.Decompiler.CSharp.Syntax.CastExpression castExpr)
                {
                    ReplaceTypeIfUnresolved(castExpr.Type, resolveContext, namespaceList);
                }
                else if(astNode is TypeOfExpression typeOfExpr)
                {
                    ReplaceTypeIfUnresolved(typeOfExpr.Type, resolveContext, namespaceList);
                }
            });


            StringBuilder usingStatements = new StringBuilder();
            TraverseSyntaxNodes(decompTree, (astNode) =>
            {
                if (astNode is ICSharpCode.Decompiler.CSharp.Syntax.UsingDeclaration ||
                    astNode is UsingAliasDeclaration)
                {
                    if (astNode is ICSharpCode.Decompiler.CSharp.Syntax.UsingDeclaration usingDec)
                    {
                        AstType usingName = usingDec.DescendantNodesAndSelf().OfType<MemberType>().FirstOrDefault();
                        if (usingName == null)
                        {
                            usingName = usingDec.DescendantNodesAndSelf().OfType<SimpleType>().First();
                        }
                        ReplaceTypeIfUnresolved(usingName, resolveContext, namespaceList);
                        // the code above will replace unknown usings with this, but it's redundant we can remove it
                        if (astNode.ToString().Trim() == "using ResoniteBridge.ResoniteBridgeValue;")
                        {
                            nodesToRemove.Add(astNode);
                        }
                    }
                }
                else if (astNode is AttributeSection attrSection)
                {
                    // once we find type declare, all the dll attributes are done so we stop deleting them
                    if (!foundTypeDec)
                    {
                        nodesToRemove.Add(astNode);
                    }
                }
                else if (astNode is TypeDeclaration typeDeclare)
                {
                    foundTypeDec = true;
                }
            });
            usings = "using ResoniteBridge;\n";


            // we need to do this seperately to avoid modification in place changing order
            foreach (AstNode nodeToRemove in nodesToRemove)
            {
                nodeToRemove.Remove();
            }


            var writer = new StringWriter();
            var visitor = new CSharpOutputVisitor(writer, FormattingOptionsFactory.CreateAllman());
            decompTree.AcceptVisitor(visitor);
            return writer.ToString();
        }
        
        // these don't resolve but they are valid, pass them through
        public static HashSet<string> primitiveTypes = new HashSet<string>()
        {
            "string",
            "bool",
            "int",
            "double",
            "float",
            "void",
        };

        public static void ReplaceTypeIfUnresolved(AstType astType, ITypeResolveContext resolveContext, HashSet<string> namespaceList)
        {
            // we have a few things we try for resolving types

            // remove nullable because that confuses typeof
            if (astType.ToString().Contains("?"))
            {
                AstType newType = new SimpleType(astType.ToString().Replace("?", ""));
                astType.ReplaceWith(newType);
                astType = newType;
            }

            // @int don't resolve propertly
            if (astType.ToString().Contains("@"))
            {
                AstType newType = new SimpleType(astType.ToString().Replace("@", ""));
                astType.ReplaceWith(newType);
                astType = newType;
            }

            // namespaces require seperate resolution
            if (namespaceList.Contains(astType.ToString()))
            {
                // it exists, we are happy
                return;
            }

            if (primitiveTypes.Contains(astType.ToString().Replace("@", ""))) {
                return;
            }
            
            ITypeReference typeReference = astType.ToTypeReference();
            IType iType = typeReference.Resolve(resolveContext);
            // resolved, we are happy
            if (iType.Kind != ICSharpCode.Decompiler.TypeSystem.TypeKind.Unknown)
            {
                return;
            }

            ResolveResult resolveResult = astType.GetResolveResult();

            // @ confuses resolver, make a temporary version without @
            if (resolveResult.IsError && astType.ToString().Contains("@"))
            {
                resolveResult = (new SimpleType(astType.ToString().Replace("@", ""))).GetResolveResult();
            }

            if (!resolveResult.IsError)
            {
                // resolve is too powerful and will fetch types from assemblies
                // not in our lists, limit it a bit
                string assemblyName = null;
                if (resolveResult.Type.GetDefinition() != null)
                {
                    assemblyName = resolveResult.Type.GetDefinition().ParentModule.AssemblyName;
                }
                // getdefinition is null for generic types, which we allow
                if (resolveResult.Type.GetDefinition() == null ||
                    whitelist.Contains(assemblyName) ||
                    bonusList.Contains(assemblyName))
                {
                    return;
                }
            }
            // still didn't resolve, replace with ResoniteBridgeValue
            astType.ReplaceWith(new SimpleType("ResoniteBridge.ResoniteBridgeValue"));
        }

        public static HashSet<string> ForbiddenNamespaces = new HashSet<string>()
        {
            // Used for defining assembly metadata, but we are doing that ourselves
            "Microsoft.CodeAnalysis",
            "System.Runtime.CompilerServices"
        };

        public static HashSet<string> whitelist = new HashSet<string>()
        {
            //"FrooxEngine.Store",
            "SkyFrost.Base.Models",
            "SkyFrost.Base",
            //"Elements.Assets",
            //"Elements.Core",
            //"Elements.Quantity",
            //"ProtoFlux.Nodes.FrooxEngine",
            //"ProtoFlux.Nodes.Core",
            //"ProtoFlux.Core",
            //"ProtoFluxBindings",
            //"FrooxEngine",
        };

        public static HashSet<string> bonusList = new HashSet<string>()
        {
            "ICSharpCode.Decompiler",
            "Microsoft.CodeAnalysis.Analyzers",
            "Microsoft.CodeAnalysis",
            "Microsoft.CodeAnalysis.CSharp",
            "Newtonsoft.Json",
            "System.CodeDom",
            "System.Text.Json",
            "System.Private.CoreLib",
        };

        public class TypeInfoLookup
        {
            public Dictionary<string, ITypeDefinition> typeDefinitions = new Dictionary<string, ITypeDefinition>();
            public Dictionary<string, Type> types = new Dictionary<string, Type>();
            public Dictionary<string, TypeDeclaration> typeDeclarations = new Dictionary<string, TypeDeclaration>();
        }

        // extra assemblies we depend on
        public static List<Assembly> GetExtraAssemblies()
        {
            List<Assembly> result = new List<Assembly>();
            result.Add(typeof(ResoniteBridge.ResoniteBridgeValue).Assembly);
            result.Add(typeof(Newtonsoft.Json.JsonConvert).Assembly);
            result.Add(typeof(System.Text.Json.JsonDocument).Assembly);
            result.Add(typeof(object).Assembly);// system runtime
            result.Add(typeof(List<int>).Assembly); // generics
            return result;
        }

        public static IEnumerable<Tuple<Assembly, string>> WrapAssemblies(Dictionary<string, Assembly> assemblies)
        {
            List<Assembly> whitelistedAssemblies = new List<Assembly>();
            // might be modified so have to make a copy
            foreach (KeyValuePair<string, Assembly> pair in new Dictionary<string, Assembly>(assemblies))
            {
                Assembly assembly = pair.Value;
                if (whitelist.Contains(ResoniteBridgeServer.GetAssemblyName(pair.Value)))
                {
                    whitelistedAssemblies.Add(assembly);
                }
            }

            TypeInfoLookup typeInfoLookup = new TypeInfoLookup();

            // make type looking
            List<IModuleReference> iModules = new List<IModuleReference>();
            // for type lookup, include extra assemblies
            List<Assembly> allAssemblies = new List<Assembly>();
            allAssemblies.AddRange(whitelistedAssemblies);
            allAssemblies.AddRange(GetExtraAssemblies());
            HashSet<string> namespaceList = new HashSet<string>();
            foreach (Assembly assembly in allAssemblies)
            {
                Console.WriteLine("Loading assembly " + assembly.Location);
                var decompiler = new CSharpDecompiler(assembly.Location, new DecompilerSettings());
                iModules.Add(decompiler.TypeSystem.MainModule.PEFile);
                foreach (ITypeDefinition definition in decompiler.TypeSystem.GetAllTypeDefinitions())
                {
                    typeInfoLookup.typeDefinitions[definition.FullName] = definition;
                }
                foreach (Type type in assembly.GetTypes())
                {
                    namespaceList.Add(type.Namespace);
                    typeInfoLookup.types[type.FullName] = type;
                }
            }

            IModuleReference first = iModules[0];
            iModules.RemoveAt(0);

            SimpleCompilation compilation = new SimpleCompilation(first, iModules);
            foreach (ITypeDefinition typeDef in compilation.GetAllTypeDefinitions())
            {
                // it's not very good at type resolution, help it
                namespaceList.Add(typeDef.FullName);
            }
            SimpleTypeResolveContext resolveContext = new SimpleTypeResolveContext(compilation);

            foreach (Assembly assembly in whitelistedAssemblies)
            {
                var decompiler = new CSharpDecompiler(assembly.Location, new DecompilerSettings());
                string assemblyName = ResoniteBridgeServer.GetAssemblyName(assembly);
                Console.WriteLine("Wrapping assembly " + assemblyName);
                string outputCode = WrapAssembly(assembly, typeInfoLookup, resolveContext, namespaceList, out string usings);
                yield return new Tuple<Assembly, string>(assembly, usings + "\n" + outputCode);
                Console.WriteLine("Done wrapping assembly " + assemblyName);
            }


        }

        public static void CreateWrapperAssembly(Dictionary<string, Assembly> assemblies, string rootNamespaceName)
        {
            new Thread(() =>
            {
                string outTxt = "C:\\Users\\yams\\Desktop\\prog\\ResoniteUnityExporter\\ResoniteBridge\\" + rootNamespaceName + ".cs";
                string outErrors = "C:\\Users\\yams\\Desktop\\prog\\ResoniteUnityExporter\\ResoniteBridge\\" + rootNamespaceName + "errors.cs";

                List<Microsoft.CodeAnalysis.SyntaxTree> syntaxTrees = new List<Microsoft.CodeAnalysis.SyntaxTree>();

                // Create CodeDom provider for C#
                using (var provider = CodeDomProvider.CreateProvider("CSharp"))
                {
                    foreach (Tuple<Assembly, string> codeAndAssembly in WrapAssemblies(assemblies))
                    {
                        Assembly assembly = codeAndAssembly.Item1;
                        string code = codeAndAssembly.Item2;
                        syntaxTrees.Add(CSharpSyntaxTree.ParseText(code));
                        File.WriteAllText(outTxt + assembly.FullName + ".cs", code);
                    }
                }

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

                syntaxTrees.Insert(0, CSharpSyntaxTree.ParseText(assemblyAttributeSource));

                string outPath = "C:\\Users\\yams\\Desktop\\prog\\ResoniteUnityExporter\\ResoniteBridge\\ResoniteBridgeStandalone\\" + rootNamespaceName + ".dll";
                Console.WriteLine("Compiling");
                // Create compilation
                CSharpCompilation compilation = CSharpCompilation.Create(
                    rootNamespaceName,
                    syntaxTrees: syntaxTrees,
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
                            allErrors.AppendLine(diagnostic.Location + " " + diagnostic.ToString());
                            if (diagnostic.Location != null && diagnostic.Location.SourceTree != null)
                            {
                                var location = diagnostic.Location;
                                var lineSpan = location.GetLineSpan();
                                var sourceText = location.SourceTree.GetText();
                                var startLine = sourceText.Lines[lineSpan.StartLinePosition.Line];
                                var endLine = sourceText.Lines[lineSpan.EndLinePosition.Line];
                                var fullLines = sourceText.ToString(TextSpan.FromBounds(startLine.Start, endLine.End));
                                allErrors.AppendLine(fullLines);
                            }
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
