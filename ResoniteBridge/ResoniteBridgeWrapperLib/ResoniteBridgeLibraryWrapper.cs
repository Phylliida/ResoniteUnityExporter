using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading;

using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.TypeSystem;
using ICSharpCode.Decompiler.CSharp.Syntax;
using ICSharpCode.Decompiler.CSharp.OutputVisitor;
using ICSharpCode.Decompiler.TypeSystem.Implementation;
using ICSharpCode.Decompiler.Semantics;
using System.Runtime.CompilerServices;

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

        public static AstType CleanType(AstType astType, bool removeNullable=true)
        {
            // grab the base type without ref or ?
            if (astType.ToString().Contains("ref ") ||
                (removeNullable && astType.ToString().EndsWith("?")))
            {
                astType = ((ComposedType)astType).BaseType;
            }
            return astType;
        }

        public static BlockStatement WrapOperator(bool isStatic, OperatorDeclaration operatorDeclaration, Expression staticTarget, Expression instanceTarget)
        {
            var operatorNameExp = new PrimitiveExpression(operatorDeclaration.Name);
            var clientWrappers = new TypeReferenceExpression(new SimpleType("ResoniteBridge.ResoniteBridgeClientWrappers"));

            List<Expression> invocationParams = new List<Expression>();
            invocationParams.Add(isStatic
                ? staticTarget.Clone()
                : instanceTarget.Clone());

            invocationParams.Add(operatorNameExp);

            foreach (var param in operatorDeclaration.Parameters)
            {
                invocationParams.Add(new IdentifierExpression(param.NameToken.ToString()));
            }

            InvocationExpression invocation = new InvocationExpression(
                new MemberReferenceExpression(clientWrappers, "CallMethod"),
                invocationParams);


            if (operatorDeclaration.ReturnType.ToString() != "void")
            {
                AstType returnType = CleanType(operatorDeclaration.ReturnType);
                var castValueCall = new InvocationExpression(
                    new MemberReferenceExpression(clientWrappers.Clone(), "CastValue"),
                    invocation,
                    new TypeOfExpression(returnType.Clone())
                );

                // this mess of stuff does this:
                // if ({castValueCall} is ReturnType __retCasted)
                // {
                //     return __retCasted;
                // }
                // throw new InvalidCastException("Cannot cast result to ReturnType");
                return new BlockStatement {
                    new IfElseStatement(
                        CreateIsClause(castValueCall,
                            returnType,
                            "__retCasted"
                        ),
                        new BlockStatement {
                            new ReturnStatement(new IdentifierExpression("__retCasted"))
                        },
                        new BlockStatement {
                            new ThrowStatement(
                                new ObjectCreateExpression(
                                    new SimpleType("ResoniteBridge.InvalidCastException"),
                                    new PrimitiveExpression($"Cannot cast result to {returnType}")
                                )
                            )
                        }
                    )
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
        
        public static BinaryOperatorExpression CreateIsClause(Expression value, AstType castType, string variableName)
        {
            DeclarationExpression declare = new DeclarationExpression();
            SingleVariableDesignation designation = new SingleVariableDesignation();
            declare.Designation = designation;
            designation.Identifier = variableName;
            declare.Type = castType.Clone();
            return new BinaryOperatorExpression(value,
                BinaryOperatorType.IsPattern,
                declare);
        }

        public static string GetMethodName(MethodDeclaration methodDeclaration)
        {
            // Need to do this to get stuff like IEnumerator.GetEnumerator()
            if (!methodDeclaration.PrivateImplementationType.IsNull)
            {
                return methodDeclaration.PrivateImplementationType.ToString() + "." + methodDeclaration.Name;
            }
            else
            {
                return methodDeclaration.Name;
            }
        }

        public static BlockStatement WrapMethod(bool isStatic, MethodDeclaration methodDeclaration, Expression staticTarget, Expression instanceTarget)
        {
            var methodNameExp = new PrimitiveExpression(GetMethodName(methodDeclaration));
            var clientWrappers = new TypeReferenceExpression(new SimpleType("ResoniteBridge.ResoniteBridgeClientWrappers"));

            List<Expression> invocationParams = new List<Expression>();
            invocationParams.Add(isStatic
                ? staticTarget.Clone()
                : instanceTarget.Clone());

            invocationParams.Add(methodNameExp);


            string wrapperMethodName = "CallMethod";


            // this chunk of stuff supports ref/out params
            var outOrRefParams = methodDeclaration.Parameters.Where(
                (p) => p.ParameterModifier.HasFlag(
                         ICSharpCode.Decompiler.CSharp.Syntax.ParameterModifier.Out)
                     || p.ParameterModifier.HasFlag(
                          ICSharpCode.Decompiler.CSharp.Syntax.ParameterModifier.Ref)).ToList();
            List<Expression> assigns = new List<Expression>();
            // If we have ref or out params we need to pass in an extra thing
            if (outOrRefParams.Count > 0)
            {
                AstType outType = new SimpleType("ResoniteBridge.ResoniteBridgeValue[]");

                string outName = "__outVars";
                OutVarDeclarationExpression outDeclare = new OutVarDeclarationExpression(outType, outName);

                invocationParams.Add(outDeclare);
                wrapperMethodName = "CallMethodWithRefsAndOuts";
                IdentifierExpression outIdentifier = new IdentifierExpression(outName);
                // this makes the ith out/ref param 
                // param_i = (param_i_type)__outVars[i]
                for (int i = 0; i < outOrRefParams.Count; i++)
                {
                    AstType paramType = CleanType(outOrRefParams[i].Type);
                    PrimitiveExpression indexExpression = new PrimitiveExpression(i);
                    IdentifierExpression paramIdentifier = new IdentifierExpression(outOrRefParams[i].NameToken.ToString());

                    var castParamValueCall = new InvocationExpression(
                        new MemberReferenceExpression(clientWrappers.Clone(), "CastValue"),
                        new IndexerExpression(
                            outIdentifier.Clone(),
                            indexExpression),
                        new TypeOfExpression(paramType.Clone())
                    );

                    var castExpression = new CastExpression(
                        paramType.Clone(),
                        castParamValueCall
                    );

                    AssignmentExpression assignExpr = new AssignmentExpression(paramIdentifier,
                        castExpression);
                    assigns.Add(assignExpr);
                }
            }

            foreach (var param in methodDeclaration.Parameters)
            {
                // don't pass in out params into wrapper
                if (!param.ParameterModifier.HasFlag(ICSharpCode.Decompiler.CSharp.Syntax.ParameterModifier.Out))
                {
                    invocationParams.Add(new IdentifierExpression(param.NameToken.ToString()));
                }
            }

            InvocationExpression invocation = new InvocationExpression(
                new MemberReferenceExpression(clientWrappers, wrapperMethodName),
                invocationParams);


            if (methodDeclaration.ReturnType.ToString() != "void")
            {
                AstType returnType = CleanType(methodDeclaration.ReturnType);
                AstType returnTypeNoRef = CleanType(methodDeclaration.ReturnType, removeNullable: false);
                // we don't support returning ref
                methodDeclaration.ReturnType.ReplaceWith(returnTypeNoRef);
                var castValueCall = new InvocationExpression(
                    new MemberReferenceExpression(clientWrappers.Clone(), "CastValue"),
                    invocation,
                    new TypeOfExpression(returnType.Clone())
                );

                // this mess of stuff does this:
                // if ({castValueCall} is ReturnType __retCasted)
                // {
                //     return __retCasted;
                // }
                // throw new InvalidCastException("Cannot cast result to ReturnType");
                /*
                return new BlockStatement {
                    new IfElseStatement(
                        CreateIsClause(castValueCall,
                            returnType,
                            "__retCasted"
                        ),
                        new BlockStatement {
                            new ReturnStatement(new IdentifierExpression("__retCasted"))
                        },
                        new BlockStatement {
                            new ThrowStatement(
                                new ObjectCreateExpression(
                                    new SimpleType("ResoniteBridge.InvalidCastException"),
                                    new PrimitiveExpression($"Cannot cast result to {"returnTpe"}")
                                )
                            )
                        }
                    )
                };*/
                //old version
                var castExpression = new CastExpression(
                    methodDeclaration.ReturnType.Clone(),
                    castValueCall
                );

                Expression outputExpression = castExpression;

                BlockStatement result = new BlockStatement
                {

                };

                // stuff to support out/ref

                // this does
                // __finalResult = <cast stuff>
                // <later stuff does assignments to ref and out params>
                // return __finalResult;
                if (assigns.Count > 0)
                {
                    string finalResultName = "__finalResult";
                    VariableDeclarationStatement finalResultDeclare = new VariableDeclarationStatement(
                        methodDeclaration.ReturnType.Clone(),
                       "__finalResult",
                       castExpression);
                    result.Add(finalResultDeclare);
                    outputExpression = new IdentifierExpression(finalResultName);
                }

                foreach (Expression assign in assigns)
                {
                    result.Add(assign);
                }
                result.Add(new ReturnStatement(outputExpression));
                return result;
            }
            else
            {
                BlockStatement result = new BlockStatement
                {
                    invocation
                };
                foreach (Expression assign in assigns)
                {
                    result.Add(assign);
                }
                return result;
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

            getterType = CleanType(getterType);

            var castValueCall = new InvocationExpression(
                new MemberReferenceExpression(clientWrappers, "CastValue"),
                getterCall,
                new TypeOfExpression(getterType.Clone())
            );


            // this mess of stuff does this:
            // if ({castValueCall} is ReturnType __retCasted)
            // {
            //     return __retCasted;
            // }
            // throw new InvalidCastException("Cannot cast result to ReturnType");
            return new Accessor
            {
                Body = new BlockStatement {
                    new IfElseStatement(
                        CreateIsClause(castValueCall,
                            getterType,
                            "__retCasted"
                        ),
                        new BlockStatement {
                            new ReturnStatement(new IdentifierExpression("__retCasted"))
                        },
                        new BlockStatement {
                            new ThrowStatement(
                                new ObjectCreateExpression(
                                    new SimpleType("ResoniteBridge.InvalidCastException"),
                                    new PrimitiveExpression($"Cannot cast result to {getterType}")
                                )
                            )
                        }
                    )
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

        public static BlockStatement WrapConstructor(ConstructorDeclaration constructorDeclaration, Expression staticTarget)
        {
            var clientWrappers = new TypeReferenceExpression(new SimpleType("ResoniteBridge.ResoniteBridgeClientWrappers"));

            List<Expression> invocationParams = new List<Expression>();
            invocationParams.Add(staticTarget.Clone());

            foreach (var param in constructorDeclaration.Parameters)
            {
                invocationParams.Add(new IdentifierExpression(param.NameToken.ToString()));
            }

            InvocationExpression invocation = new InvocationExpression(
                new MemberReferenceExpression(clientWrappers, "CallConstructor"),
                invocationParams);

            // set the backing to the constructed value
            AssignmentExpression assignment = new AssignmentExpression(
                new IdentifierExpression("__backing"),
                invocation);

            return new BlockStatement
            {
                assignment
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
                                baseType.ToString() == "System.Attribute") ||
                                typeDeclaration.NameToken.ToString().EndsWith("Attribute") ||
                                typeDeclaration.NameToken.ToString().Contains("IQuantizationDefaults");
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

        public static bool IsOwnedByTypeDeclaration(TypeDeclaration typeDeclaration, AstNode node)
        {
            foreach (TypeDeclaration typeDeclareParent in node.AncestorsAndSelf.OfType<TypeDeclaration>())
            {
                return typeDeclaration == typeDeclareParent;
            }
            return false;
        }

        // this probably double counts but that's ok
        public static List<ITypeDefinition> GetAllBaseTypeDefinitions(TypeDeclaration typeDeclaration)
        {
            List<ITypeDefinition> allBaseTypeDefinitions = new List<ITypeDefinition>();

            foreach (var baseType in typeDeclaration.BaseTypes)
            {
                ResolveResult resolvedType = baseType.GetResolveResult();
                if (!resolvedType.IsError)
                {
                    allBaseTypeDefinitions.Add(resolvedType.Type.GetDefinition());
                    foreach (var baseTypeDef in resolvedType.Type.GetAllBaseTypeDefinitions())
                    {
                        allBaseTypeDefinitions.Add(baseTypeDef);
                    }
                }
            }
            return allBaseTypeDefinitions;
        }

        // we leave these as is, to decrease communication between wrapper and resonite
        public static HashSet<string> PreservingTypes = new HashSet<string>()
        {
            "float2",
            "float3",
            "float4",
            "double2",
            "double3",
            "double4",
            "int2",
            "int3",
            "int4",
            "long2",
            "long3",
            "long4",
            "bool2",
            "bool3",
            "bool4",
            "floatQ",
            "doubleQ",
            "color",
            "colorX",
            "UV_Array",
            "BoneBinding", // needed to bulk transfer bone data
        };


        public static string WrapType(SyntaxTree typeTree, string syntaxTreeTypeLabel, Assembly assembly, TypeInfoLookup typeInfoLookup, SimpleTypeResolveContext resolveContext, HashSet<string> namespaceList)
        {
            return ParseSyntaxTree(typeTree, syntaxTreeTypeLabel, assembly, typeInfoLookup, resolveContext, namespaceList);
        }

        public static IEnumerable<Tuple<string, string>> WrapAssembly(Assembly assembly, TypeInfoLookup typeInfoLookup, SimpleTypeResolveContext resolveContext, HashSet<string> namespaceList)
        {
            string assemblyName = ReflectionUtils.GetAssemblyName(assembly);
            DecompilerSettings settings = new DecompilerSettings();
            settings.UsingDeclarations = true;
            settings.AlwaysQualifyMemberReferences = true;
            var decompiler = new CSharpDecompiler(assembly.Location, settings);

            Console.WriteLine("Decompiling");
            var topLevelTypes = decompiler.TypeSystem.MainModule.TypeDefinitions
                .Where(t => !t.IsCompilerGenerated() &&
                    t.DeclaringType == null &&
                    !t.Name.StartsWith("<") // weird <module> stuff
                    ).ToArray();

            // sadly we can't just put them all in one file
            // that results in ambiguous usings
            // (because ambiguity only happens when it gets a using from a different type,
            // and by itself it would have been fine)
            Dictionary<string, string> resultFiles = new Dictionary<string, string>();
            int i = 0;
            foreach (var topLevelType in topLevelTypes)
            {
                SyntaxTree typeTree = decompiler.DecompileType(topLevelType.FullTypeName);
                string typeNamespace = topLevelType.Namespace;
                string typeName = topLevelType.Name;
                string key = typeNamespace == null || typeNamespace.Length == 0
                    ? typeName
                    : typeNamespace + "." + typeName;
                yield return new Tuple<string, string>(key, WrapType(typeTree, key, assembly, typeInfoLookup, resolveContext, namespaceList));
                i += 1;
                Console.CursorLeft = 0;
                Console.Write($"{i}/{topLevelTypes.Length}");
            }
        }

        public static string ParseSyntaxTree(SyntaxTree decompTree, string syntaxTreeTypeLabel, Assembly assembly, TypeInfoLookup typeInfoLookup, SimpleTypeResolveContext resolveContext, HashSet<string> namespaceList)
        {
            string assemblyName = ReflectionUtils.GetAssemblyName(assembly);

            // Get all the usings and replace them with empty
            // Because we need them all at the start

            bool foundTypeDec = false;

            List<AstNode> nodesToRemove = new List<AstNode>();

            TraverseSyntaxNodes(decompTree, (astNode) =>
            {
                // these can be in namespaces, outside of types
                if (astNode is DelegateDeclaration delegateDeclare)
                {
                    delegateDeclare.Modifiers = SetAccessibility(delegateDeclare.Modifiers);
                    // replace unmanaged with stuct in delegates so the replacements below also work
                    foreach (var constraint in delegateDeclare.Constraints)
                    {
                        ReplaceUnmanagedConstraintWithStruct(constraint, nodesToRemove);
                    }
                }
                // process and wrap type declarations
                if (astNode is ICSharpCode.Decompiler.CSharp.Syntax.TypeDeclaration typeDeclare)
                {
                    // make all types public
                    // this (and some SetAccessibility below) are needed because ilspy sometimes fails to decompile correctly
                    // resulting in a protected Sync<Thing> where Thing is private
                    typeDeclare.Modifiers = SetAccessibility(typeDeclare.Modifiers);
                    
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


                    // no ref structs, they confuse the wrappers
                    if (typeDeclare.Modifiers.HasFlag(Modifiers.Ref))
                    {
                        typeDeclare.Modifiers &= ~Modifiers.Ref;
                    }


                    List<EntityDeclaration> membersToAdd = new List<EntityDeclaration>();

                    // don't mess with enums, static classes
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
                            // implement constructor from ResoniteBridgeValue (needed for CastValue)
                            var constructorDeclaration = CreateBackingConstructor(typeDeclare);
                            membersToAdd.Add(constructorDeclaration);
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

                    // don't modify attributes, keep them as is
                    // they can't have object fields so we can't make wrappers out of them
                    // but that's okay, they have very simple fields so ez to serialize
                    if (IsAttribute(typeDeclare))
                    {
                        return;
                    }

                    bool wrapFields = true;
                    // we leave these mostly as is (mostly raw types like float3, bool4, floatQ, etc.)
                    if (PreservingTypes.Contains(typeDeclare.NameToken.ToString()))
                    {
                        wrapFields = false;
                    }

                    var staticTarget = new ObjectCreateExpression(
                        new SimpleType("ResoniteBridge.ResoniteBridgeValue"),
                        new Expression[] {
                            new PrimitiveExpression(null),
                            new PrimitiveExpression(assemblyName),
                            new PrimitiveExpression(typeDeclare.GetResolveResult().Type.ReflectionName),
                            new MemberReferenceExpression(
                                new TypeReferenceExpression(new SimpleType("ResoniteBridge.ResoniteBridgeValueType")),
                                "Type"
                            )
                        }
                    );

                    bool lostForbiddenBaseClass = false;
                    // remove "forbidden" base classes, these are things that cause issues due to their requirements
                    var typesToRemove = typeDeclare.BaseTypes.Where(t => IsForbiddenBaseClass(t.ToString()));
                    foreach (var typeToRemove in typesToRemove)
                    {
                        typeToRemove.Remove();
                        lostForbiddenBaseClass = true;
                    }

                    var instanceTarget = new IdentifierExpression(
                        "__Backing"
                    );

                    bool hasDefaultConstructor = false;

                    TraverseSyntaxNodes(astNode, (childNode) =>
                    {
                        // skip nodes of subchildren, we'll process them later
                        if (!IsOwnedByTypeDeclaration(typeDeclare, childNode))
                        {
                            return;
                        }

                        if (childNode is ICSharpCode.Decompiler.CSharp.Syntax.ConstructorDeclaration constructorDeclare)
                        {
                            //constructorDeclare.Modifiers = SetAccessibility(constructorDeclare.Modifiers);

                            if (constructorDeclare.Parameters.Count == 0 &&
                                !constructorDeclare.Modifiers.HasFlag(Modifiers.Static))
                            {
                                hasDefaultConstructor = true;
                            }
                            // only wrap non-static constructors
                            // (a static constructor runs once ever)
                            // for static, just make them empty, they'll be called anyway on the other end
                            constructorDeclare.Body =
                                constructorDeclare.Modifiers.HasFlag(Modifiers.Static)
                                ? new BlockStatement
                                {

                                }
                                : WrapConstructor(constructorDeclare, staticTarget);
                            // No initializer (stuff like :base(...)) since we are just wrapping
                            constructorDeclare.Initializer = null;
                        }
                        if (childNode is IndexerDeclaration indexerDeclare)
                        {
                            //indexerDeclare.Modifiers = SetAccessibility(indexerDeclare.Modifiers);

                            AstType returnType = indexerDeclare.ReturnType;
                            returnType = CleanType(returnType, removeNullable: false);
                            indexerDeclare.ReturnType.ReplaceWith(returnType);

                            string indexerName = indexerDeclare.Name;
                            bool isStatic = indexerDeclare.Modifiers.HasFlag(Modifiers.Static) ||
                                typeDeclare.Modifiers.HasFlag(Modifiers.Static);

                            if (indexerDeclare.Modifiers.HasFlag(Modifiers.Const))
                            {
                                // we need to make it not const bc properties can't be const
                                // (well, our wrapper ones can't be)
                                indexerDeclare.Modifiers &= ~Modifiers.Const;
                            }
                            if (indexerDeclare.Modifiers.HasFlag(Modifiers.Readonly))
                            {
                                // Don't allow readonly ones bc that confuses compiler
                                indexerDeclare.Modifiers &= ~Modifiers.Readonly;
                            }
                            if (indexerDeclare.Modifiers.HasFlag(Modifiers.Volatile))
                            {
                                // Don't allow volatile ones bc no need since we are just a wrapper
                                indexerDeclare.Modifiers &= ~Modifiers.Volatile;
                            }

                            // inherit static from parent
                            if (!indexerDeclare.Modifiers.HasFlag(Modifiers.Static) &&
                                typeDeclare.Modifiers.HasFlag(Modifiers.Static))
                            {
                                indexerDeclare.Modifiers |= Modifiers.Static;
                            }

                            if (!indexerDeclare.Getter.IsNull)
                            {
                                indexerDeclare.Getter = WrapGetter(isStatic,
                                    returnType,
                                    indexerName,
                                    staticTarget,
                                    instanceTarget,
                                    "GetProperty"
                                );
                            }

                            if (!indexerDeclare.Setter.IsNull)
                            {
                                indexerDeclare.Setter = WrapSetter(isStatic,
                                    indexerName,
                                    staticTarget,
                                    instanceTarget,
                                    "SetProperty"
                                );
                            }

                            // don't fill out bodies for abstract fields
                            if (indexerDeclare.Modifiers.HasFlag(Modifiers.Abstract) || typeDeclare.ClassType == ClassType.Interface)
                            {
                                indexerDeclare.Getter = indexerDeclare.Getter.IsNull
                                ? null
                                : new Accessor
                                {

                                };
                                // don't require a setter 
                                indexerDeclare.Setter = null;
                            }
                        }

                        if (childNode is ICSharpCode.Decompiler.CSharp.Syntax.OperatorDeclaration operatorDeclare)
                        {
                            //operatorDeclare.Modifiers = SetAccessibility(operatorDeclare.Modifiers);
                            // leave null bodies null (usually for abstract)
                            if (operatorDeclare.IsNull)
                            {

                            }
                            else
                            {
                                bool isStatic = operatorDeclare.Modifiers.HasFlag(Modifiers.Static);
                                operatorDeclare.Body = WrapOperator(
                                    isStatic,
                                    operatorDeclare,
                                    staticTarget,
                                    instanceTarget);
                            }

                        }
                        if (childNode is ICSharpCode.Decompiler.CSharp.Syntax.MethodDeclaration methodDeclare)
                        {

                            // we don't support unsafe pointers yet (some casting nonsense needs to be done to get this to work right)
                            if (methodDeclare.Parameters.Any(p => p.Type.ToString().Contains("*")))
                            {
                                nodesToRemove.Add(methodDeclare);
                                return;
                            }



                            // we can't make this public sadly
                            bool exception = methodDeclare.Modifiers.HasFlag(Modifiers.Override) &&
                                (methodDeclare.NameToken.ToString() == "Dispose"
                                || methodDeclare.NameToken.ToString() == "GetWebRequest");
                            if (!exception)
                            {
                                //methodDeclare.Modifiers = SetAccessibility(methodDeclare.Modifiers);
                            }

                            if (typeDeclare.NameToken.ToString().Contains("LocalDatabaseAccountDataStore"))
                            {

                                int i = 0;
                                i += 1;
                            }
                            // certain things we need to remove override
                            // if the thing they override no longer exists
                            if (lostForbiddenBaseClass &&
                                methodDeclare.Modifiers.HasFlag(Modifiers.Override) &&
                                ForbiddenBaseClassOverrideMethodNames.Contains(methodDeclare.NameToken.ToString()))
                            {
                                methodDeclare.Modifiers &= ~Modifiers.Override;
                            }
                            // no getters or setters, stap
                            if (methodDeclare.NameToken.ToString().StartsWith("get_") ||
                            methodDeclare.NameToken.ToString().StartsWith("set_") ||
                            // no operators, we handle those above
                            methodDeclare.NameToken.ToString().StartsWith("op_"))
                            {
                                nodesToRemove.Add(methodDeclare);
                            }
                            // leave null bodies null (usually in interfaces)
                            else if (methodDeclare.Body.IsNull)
                            {
                                // still replace the constraints though
                                foreach (var constraint in methodDeclare.Constraints)
                                {
                                    ReplaceUnmanagedConstraintWithStruct(constraint, nodesToRemove);
                                }
                            }
                            else
                            {
                                // we don't support async yet, just return the task
                                if (methodDeclare.Modifiers.HasFlag(Modifiers.Async))
                                {
                                    methodDeclare.Modifiers &= ~Modifiers.Async;
                                }
                                bool isStatic = methodDeclare.Modifiers.HasFlag(Modifiers.Static);

                                // don't fill out body for abstract methods 
                                if (!methodDeclare.Modifiers.HasFlag(Modifiers.Abstract))
                                {
                                    methodDeclare.Body = WrapMethod(
                                        isStatic,
                                        methodDeclare,
                                        staticTarget,
                                        instanceTarget);
                                }
                                foreach (var constraint in methodDeclare.Constraints)
                                {
                                    ReplaceUnmanagedConstraintWithStruct(constraint, nodesToRemove);
                                }
                            }
                        }
                        // don't wrap properties if we have don't wrap set
                        else if (childNode is PropertyDeclaration propertyDeclare && wrapFields)
                        {
                            //propertyDeclare.Modifiers = SetAccessibility(propertyDeclare.Modifiers);

                            string propertyName = propertyDeclare.NameToken.ToString();
                            if (propertyName != "__Backing") // don't override our own backing
                            {
                                AstType returnType = propertyDeclare.ReturnType;
                                // remove ref since we don't support that
                                returnType = CleanType(returnType, removeNullable: false);
                                propertyDeclare.ReturnType.ReplaceWith(returnType);
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
                                // only wrap them if the original exists
                                // or if expression body exists ( => ...)
                                if (!propertyDeclare.Getter.IsNull ||
                                !propertyDeclare.ExpressionBody.IsNull)
                                {
                                    propertyDeclare.Getter = getter;
                                    // no more expression body, we wrapped it
                                    propertyDeclare.ExpressionBody = null;
                                }
                                if (!propertyDeclare.Setter.IsNull)
                                {
                                    propertyDeclare.Setter = setter;
                                }
                                // we don't need these because they'll be called on frooxengine side
                                propertyDeclare.Initializer = null;

                                // don't fill out bodies for abstract properties and interface classes
                                if (propertyDeclare.Modifiers.HasFlag(Modifiers.Abstract) || typeDeclare.ClassType == ClassType.Interface)
                                {
                                    propertyDeclare.Getter = propertyDeclare.Getter.IsNull
                                    ? null
                                    : new Accessor
                                    {

                                    };
                                    propertyDeclare.Setter = propertyDeclare.Setter.IsNull
                                    ? null
                                    : new Accessor
                                    {

                                    };
                                }
                            }
                        }
                        // don't wrap fields if we don't wrap fields
                        else if (childNode is FieldDeclaration fieldDeclare && wrapFields)
                        {
                            //fieldDeclare.Modifiers = SetAccessibility(fieldDeclare.Modifiers);

                            // fieldDeclare.NameToken is null
                            VariableInitializer variableInit = fieldDeclare.Children.OfType<VariableInitializer>().First();
                            string fieldName = variableInit.NameToken.ToString();
                            if (fieldName != "__backing")
                            {
                                AstType returnType = fieldDeclare.ReturnType;
                                returnType = CleanType(returnType, removeNullable: false);
                                fieldDeclare.ReturnType.ReplaceWith(returnType);

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

                                // don't fill out bodies for abstract fields
                                if (fieldDeclare.Modifiers.HasFlag(Modifiers.Abstract) || typeDeclare.ClassType == ClassType.Interface)
                                {
                                    fieldProperty.Getter = fieldProperty.Getter.IsNull
                                    ? null
                                    : new Accessor
                                    {

                                    };
                                    // don't require a setter 
                                    fieldProperty.Setter = null;
                                }
                            }
                        }
                    });

                    // we need to add default constructor since we define a different alternative one
                    // but don't do it for enums or static classes
                    if (!hasDefaultConstructor
                        && typeDeclare.ClassType != ClassType.Enum
                        && !typeDeclare.Modifiers.HasFlag(Modifiers.Static)
                        && typeDeclare.ClassType != ClassType.Interface)
                    {
                        ConstructorDeclaration defaultConstructor = CreateDefaultConstructor(typeDeclare);
                        membersToAdd.Add(defaultConstructor);
                        defaultConstructor.Modifiers = SetAccessibility(defaultConstructor.Modifiers);
                    }
                    // we do this later so the constructor wrappers don't mess with us
                    typeDeclare.Members.AddRange(membersToAdd);

                }
            });


            // remove using statements 

            List<MethodDeclaration> modifiedMethods = new List<MethodDeclaration>();

            // replace all unresolved types with ResoniteBridgeValue
            TraverseSyntaxNodes(decompTree, (astNode) =>
            {
                if (astNode is VariableDeclarationStatement variableDeclare)
                {
                    ReplaceTypeIfUnresolved(variableDeclare.Type, syntaxTreeTypeLabel, resolveContext, namespaceList, removeNullable: true);
                }
                if (astNode is DelegateDeclaration delegateDeclare)
                {
                    ReplaceTypeIfUnresolved(delegateDeclare.ReturnType, syntaxTreeTypeLabel, resolveContext, namespaceList, removeNullable: true);
                }
                if (astNode is ICSharpCode.Decompiler.CSharp.Syntax.MethodDeclaration methodDeclare)
                {
                    // we can't have nullable return type with our wrappers, it confuses type system
                    ReplaceTypeIfUnresolved(methodDeclare.ReturnType, syntaxTreeTypeLabel, resolveContext, namespaceList, removeNullable: true);
                }
                else if (astNode is ParameterDeclaration paramDeclare)
                {
                    if (ReplaceTypeIfUnresolved(paramDeclare.Type, syntaxTreeTypeLabel, resolveContext, namespaceList))
                    {
                        // just fallback to null default
                        // Todo: make this more detailed
                        // we need default because previous ones might be
                        if (!paramDeclare.DefaultExpression.IsNull)
                        {
                            paramDeclare.DefaultExpression = new DefaultValueExpression(paramDeclare.Type.Clone());
                        }
                        MethodDeclaration parentMethod = paramDeclare.Ancestors.OfType<MethodDeclaration>().FirstOrDefault();
                        if (parentMethod != null && parentMethod.Body != null && parentMethod.Modifiers.HasFlag(Modifiers.Override))
                        {
                            modifiedMethods.Add(parentMethod);
                        }
                    }
                }
                else if (astNode is ICSharpCode.Decompiler.CSharp.Syntax.PropertyDeclaration propertyDeclare)
                {
                    ReplaceTypeIfUnresolved(propertyDeclare.ReturnType, syntaxTreeTypeLabel, resolveContext, namespaceList);
                }
                else if(astNode is ICSharpCode.Decompiler.CSharp.Syntax.FieldDeclaration fieldDeclare )
                {
                    ReplaceTypeIfUnresolved(fieldDeclare.ReturnType, syntaxTreeTypeLabel, resolveContext, namespaceList);
                }
                else if(astNode is ICSharpCode.Decompiler.CSharp.Syntax.CastExpression castExpr)
                {
                    ReplaceTypeIfUnresolved(castExpr.Type, syntaxTreeTypeLabel, resolveContext, namespaceList);
                }
                else if(astNode is TypeOfExpression typeOfExpr)
                {
                    // remove nullable for typeof, it confuses it
                    ReplaceTypeIfUnresolved(typeOfExpr.Type, syntaxTreeTypeLabel, resolveContext, namespaceList, removeNullable: true);
                }
                // occurs in if (a is Type b) statements
                else if(astNode is DeclarationExpression declarationExpression)
                {
                    // remove nullable for these is expressions
                    ReplaceTypeIfUnresolved(declarationExpression.Type, syntaxTreeTypeLabel, resolveContext, namespaceList, removeNullable: true);
                }
                else if(astNode is TypeDeclaration typeDeclarationExpression) {
                    foreach (AstType baseType in typeDeclarationExpression.BaseTypes)
                    {
                        ReplaceTypeIfUnresolved(baseType, syntaxTreeTypeLabel, resolveContext, namespaceList);
                    }
                    foreach (Constraint constraint in typeDeclarationExpression.Constraints)
                    {
                        TraverseSyntaxNodes(constraint, (constraintChildNode) =>
                        {
                            if (constraintChildNode is AstType constraintType)
                            {
                                ReplaceTypeIfUnresolved(constraintType, syntaxTreeTypeLabel, resolveContext, namespaceList);
                            }
                        });
                    }
                }
            });

            foreach (MethodDeclaration modifiedMethod in modifiedMethods)
            {
                if (modifiedMethod.Modifiers.HasFlag(Modifiers.Override))
                {
                    TypeDeclaration parentType = modifiedMethod.Ancestors.OfType<TypeDeclaration>().First();
                    string parentTypeName = GetTypeDeclarationName(parentType);
                    string methodName = GetMethodName(modifiedMethod);

                    List<ITypeDefinition> baseTypeDefs = GetAllBaseTypeDefinitions(parentType);
                    // todo: check to see if base type was modified or not (how? might be in different file, need to recheck if types resolve I guess)
                }
            }

            
            AstNode lastUsing = null;
            StringBuilder usingStatements = new StringBuilder();
            TraverseSyntaxNodes(decompTree, (astNode) =>
            {
                if (astNode is ICSharpCode.Decompiler.CSharp.Syntax.UsingDeclaration ||
                    astNode is UsingAliasDeclaration)
                {
                    lastUsing = astNode;
                    if (astNode is ICSharpCode.Decompiler.CSharp.Syntax.UsingDeclaration usingDec)
                    {
                        AstType usingName = usingDec.DescendantNodesAndSelf().OfType<MemberType>().FirstOrDefault();
                        if (usingName == null)
                        {
                            usingName = usingDec.DescendantNodesAndSelf().OfType<SimpleType>().First();
                        }

                        // don't need to recurse so alsoChildren=false, no generics and that messes stuff up
                        if (ReplaceTypeIfUnresolved(usingName, syntaxTreeTypeLabel, resolveContext, namespaceList, alsoChildren: false))
                        {
                            Console.WriteLine("Removing using: " + usingName + " for type " + syntaxTreeTypeLabel);
                        }
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

            var usingDecl = new UsingDeclaration("ResoniteBridge");
            decompTree.InsertChildAfter(lastUsing, usingDecl, SyntaxTree.MemberRole);
            // remove duplicate constructors (they can occur if types get wrapped)
            // like (BlahBlah a)
            // and  (Juniper a)
            // could both be wrapped as (ResoniteBridgeValue a)
            // so then we need to remove one of them
            TraverseSyntaxNodes(decompTree, (astNode) =>
            {
                if (astNode is ICSharpCode.Decompiler.CSharp.Syntax.TypeDeclaration typeDeclare)
                {
                    HashSet<string> constructors = new HashSet<string>();
                    TraverseSyntaxNodes(astNode, (childNode) =>
                    { 
                        // skip nodes of subchildren, we'll process them later
                        if (!IsOwnedByTypeDeclaration(typeDeclare, childNode))
                        {
                            return;
                        }

                        if (childNode is ConstructorDeclaration constructorDeclaration)
                        {
                            // key based on type
                            string staticKey = constructorDeclaration.Modifiers.HasFlag(Modifiers.Static) ?
                            "static" : "notstatic";
                            string constructorKey = staticKey + String.Join(",", constructorDeclaration.Parameters
                                .Select(p => p.Type.ToString()));
                            if (constructors.Contains(constructorKey))
                            {
                                nodesToRemove.Add(constructorDeclaration);
                            }
                            else
                            {
                                constructors.Add(constructorKey);
                            }
                        }
                    });
                }
            });

            // remove duplicate methods (can occur if types get wrapped, similar reasons to constructors)
            TraverseSyntaxNodes(decompTree, (astNode) =>
            {
                if (astNode is ICSharpCode.Decompiler.CSharp.Syntax.TypeDeclaration typeDeclare)
                {
                    HashSet<string> methods = new HashSet<string>();
                    TraverseSyntaxNodes(astNode, (childNode) =>
                    {
                        // skip nodes of subchildren, we'll process them later
                        if (!IsOwnedByTypeDeclaration(typeDeclare, childNode))
                        {
                            return;
                        }

                        if (childNode is MethodDeclaration methodDeclaration)
                        {
                            // key based on type and method name
                            string staticKey = methodDeclaration.Modifiers.HasFlag(Modifiers.Static) ?
                            "static" : "notstatic";
                            string methodKey = staticKey + 
                                GetMethodName(methodDeclaration) +
                                String.Join(",", methodDeclaration.Parameters
                                    .Select(p => p.Type.ToString()));
                            if (methods.Contains(methodKey))
                            {
                                nodesToRemove.Add(methodDeclaration);
                            }
                            else
                            {
                                methods.Add(methodKey);
                            }
                        }
                    });
                }
            });


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
        static Dictionary<string, Type> keywordTypes = new Dictionary<string, Type>()
        {
            {"bool", typeof(System.Boolean)},
            {"byte", typeof(System.Byte)},
            {"char", typeof(System.Char)},
            {"decimal", typeof(System.Decimal)},
            {"double", typeof(System.Double)},
            {"float", typeof(System.Single)},
            {"int", typeof(System.Int32)},
            {"long", typeof(System.Int64)},
            {"object", typeof(System.Object)},
            {"sbyte", typeof(System.SByte)},
            {"short", typeof(System.Int16)},
            {"string", typeof(System.String)},
            {"uint", typeof(System.UInt32)},
            {"ulong", typeof(System.UInt64)},
            {"ushort", typeof(System.UInt16)},
            {"Uri", typeof(System.Uri) },
        };

        static HashSet<string> keywordStrTypes = new HashSet<string>()
        {
            "class",
            "struct",
            "new",
            "unmanaged",
        };

        public static bool IsForbiddenType(AstType astType)
        {
            // spans don't convert well
            return astType.ToString().Contains("Span<")
                // tuples (a, b) don't work 
                || astType.ToString().Contains("(")
                || astType.ToString().Contains("Utf8JsonReader");
        }

        // these cause some problems, ignore them
        static HashSet<string> ForbiddenBaseClasses = new HashSet<string>()
        {
            // these have issues with ref struct UtfJsonReader
            "JsonConverter",
            "System.Text.Json.Serialization.JsonConverter",

            // these have issues with not the right constructor
            "BinaryReader",

            // these need return by ref and idk how to proxy that rn
            "IContactManifold"
        };

        static HashSet<string> ForbiddenBaseClassOverrideMethodNames = new HashSet<string>()
        {
            "CanConvert",
            "Read",
            "Write"
        };

        public static bool IsForbiddenBaseClass(string baseClass)
        {
            string noGenerics = baseClass;
            if (noGenerics.Contains("<"))
            {
                noGenerics = noGenerics.Substring(0, noGenerics.IndexOf("<"));
            }
            return ForbiddenBaseClasses.Contains(noGenerics);
        }

        public static bool ReplaceTypeIfUnresolved(AstType astType, string fileName, ITypeResolveContext resolveContext, HashSet<string> namespaceList, bool alsoChildren=true, bool removeNullable=false)
        {
            if (alsoChildren)
            {
                // recurse (for generics)
                foreach (AstType childType in astType.DescendantNodes().OfType<SimpleType>())
                {
                    ReplaceTypeIfUnresolved(childType, fileName, resolveContext, namespaceList);
                }
            }
            // we have a few things we try for resolving types


            if (removeNullable)
            {
                // remove nullable because that confuses typeof
                //if (astType.ToString().Contains("?"))
                //{
                //    AstType newType = new SimpleType(astType.ToString().Replace("?", ""));
                //    astType.ReplaceWith(newType);
                //    astType = newType;
                //}

            }

            // @int don't resolve propertly
            if (astType.ToString().Contains("@"))
            {
                AstType newType = new SimpleType(astType.ToString().Replace("@", ""));
                astType.ReplaceWith(newType);
                astType = newType;
            }


            // we need to wrap spans bc they don't convert nicely
            // also (tuple, things) don't work, wrap those
            if (!IsForbiddenType(astType))
            {
                if (astType.ToString() == "A")
                {
                    int i = 0;
                    i += 1;
                }
                ResolveResult resolveResult = astType.GetResolveResult();


                ITypeReference typeReference = astType.ToTypeReference();
                IType iType = typeReference.Resolve(resolveContext);

                // expand types into full qualified name
                if (!resolveResult.IsError && astType is SimpleType simpleAstType)
                {
                    Identifier identifierOfThisType = astType.Descendants.OfType<Identifier>().FirstOrDefault();

                    IType type = resolveResult.Type;
                    if (iType.FullName.StartsWith("?"))
                    {
                        type = iType;
                    }
                    

                    // sometimes if it fails to resolve it just puts ? in front for reasons, in those cases we are fine with no resolve
                    if (identifierOfThisType != null && !identifierOfThisType.IsNull && !type.FullName.StartsWith("?"))
                    {
                        // nevermind this was a bad idea
                        // set identifier to be the full qualified name of the type
                        if (ShouldFullyQualifyType(astType))
                        {
                            identifierOfThisType.Name = resolveResult.Type.FullName;
                        }
                    }
                    // generics will be later things, either PrimitiveType or more SimpleType nested, handled by the recursive call above
                }
                // namespaces require seperate resolution
                if (namespaceList.Contains(astType.ToString()) ||
                    bonusList.Contains(astType.ToString()))
                {
                    // it exists, we are happy
                    return false;
                }

                // fix up the @ that gets added to these
                if (keywordTypes.TryGetValue(astType.ToString().Replace("@", ""), out Type keywordType))
                {
                    // IT IS IMPORTANT NOT TO REPLACE WITH keywordType.FullName BECAUSE like System.String will look for String in
                    // TwitchLib.Api.Core.Extensions.System
                    // instead of System
                    // but it'll work fine if we use lowercase keyword (without the @)
                    // We can't use SimpleType("int") (for example) because that'll add the @ back,
                    // but primitiveType should work fine
                    AstType newType = new PrimitiveType(astType.ToString().Replace("@", ""));
                    astType.ReplaceWith(newType);
                    astType = newType;
                    // keywords exist, we are done
                    return false;
                }

                // stuff like new, class, struct
                if (keywordStrTypes.Contains(astType.ToString()))
                {
                    return false;
                }


                // resolved, we are happy
                if (iType.Kind != ICSharpCode.Decompiler.TypeSystem.TypeKind.Unknown)
                {
                    return false;
                }

                // @ confuses resolver, make a temporary version without @
                if (resolveResult.IsError && astType.ToString().Contains("@"))
                {
                    resolveResult = (new SimpleType(astType.ToString().Replace("@", ""))).GetResolveResult();
                }

                // fixes a bug in ilspy, where A : ... fails to resolve even if A is a generic paramter of the type,
                // to fix this, loop through all AstType in type declaration statement and see if we have a matching name
                // because in the AssetManager<A> the A does resolve
                TypeDeclaration typeDeclarationHolder = astType.Ancestors.OfType<TypeDeclaration>().FirstOrDefault();
                List<AstNode> stuffToSearch = new List<AstNode>();
                if (typeDeclarationHolder != null && !typeDeclarationHolder.IsNull)
                {
                    /*
                    // the first AstType of the child of typeDeclaration is the class *Blah* this thing
                    AstType nameDeclare = typeDeclarationHolder.Children.OfType<AstType>().FirstOrDefault();
                    if (nameDeclare != null && !nameDeclare.IsNull)
                    {
                        stuffToSearch.Add(nameDeclare);
                    }
                    */
                    // also search through type parameters, which annoyingly isn't included in the above by default
                    foreach (var typeParam in typeDeclarationHolder.TypeParameters)
                    {
                        // split based on " ", so things like "in C" consider the in and the C
                        if(typeParam.ToString().Split(' ')
                            .Any(piece => piece == astType.ToString()))
                        {
                            return false;
                        }
                    }
                    /*
                    foreach (AstNode nodeToSearch in stuffToSearch)
                    {
                        bool found = false;
                        TraverseSyntaxNodes(nodeToSearch, child =>
                        {
                            if (child is AstType childAstType
                            && childAstType.ToString() == astType.ToString())
                            {
                                found = true;
                            }
                        });
                        // we found it as a generic argument or subgeneric argument, it's fine
                        if (found)
                        {
                            return false;
                        }
                    }
                    */
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
                        return false;
                    }
                }
            }

            if (astType.ToString().Contains("System.Uri"))
            {
                int i = 0;
                i += 1;
            }

            // still didn't resolve, replace with ResoniteBridgeValue

            // arrays need to be replaced with arrays tho
            string wrappedTypeStr = "ResoniteBridge.ResoniteBridgeValue";
            if (astType.ToString().EndsWith("[]"))
            {
                wrappedTypeStr = wrappedTypeStr + "[]";
            }
            Console.WriteLine("Replacing type " + astType.ToString() + " in " + fileName);
            astType.ReplaceWith(new SimpleType(wrappedTypeStr));
            return true;
        }

        static HashSet<Tuple<string, string>> TypeMethodPairNeedsAllFullyDeclaredTypes = new HashSet<Tuple<string, string>>()
        {
            new Tuple<string, string>("LocalDatabaseAccountDataStore", "StoreUserData"),
            new Tuple<string, string>("LocalDatabaseAccountDataStore", "GetUser"),
        };

        static HashSet<Tuple<string, string>> TypeMethodPairNeedsFullyDeclaredReturnType = new HashSet<Tuple<string, string>>()
        {
        };

        static HashSet<Tuple<string, string, string>> TypeMethodParamNameTrioNeedsFullyDeclaredType = new HashSet<Tuple<string, string, string>>()
        {
        };

        static HashSet<Tuple<string, string>> TypePropertyPairNeedsAllFullyDeclaredTypes = new HashSet<Tuple<string, string>>()
        {
            new Tuple<string, string>("PointMesh", "_comparer"),
        };

        static HashSet<string> TypeNeedsToBeFullyDeclared = new HashSet<string>
        {
            "IOperation"
        };


        public static bool IsEqualToOrChildOf(AstType parent, AstType sameOrChild)
        {
            // we can't just check equality because we might be child of return type, check recursively
            bool result = parent == sameOrChild;
            TraverseSyntaxNodes(parent, (parentMethodReturnTypeNode) =>
            {
                if (parentMethodReturnTypeNode == sameOrChild)
                {
                    result = true;
                }
            });
            return result;
        }

        public static bool ShouldFullyQualifyType(AstType type)
        {
            // btw, it's not safe to always do this because froox namespaces have weird aliasing
            // but occasionally it is needed because put all the usings together in one file per dll
            // so sometimes names get overridden
            return false;
            MethodDeclaration parentMethod = type.Ancestors.OfType<MethodDeclaration>().FirstOrDefault();
            TypeDeclaration parentType = type.Ancestors.OfType<TypeDeclaration>().FirstOrDefault();

            if (parentType != null && !parentType.IsNull)
            {
                if (TypeNeedsToBeFullyDeclared.Contains(type.ToString()))
                {
                    return true;
                }
            }

            if (parentMethod != null && !parentMethod.IsNull &&
                parentType != null && !parentType.IsNull)
            {
                string parentMethodName = GetMethodName(parentMethod);
                string parentTypeName = GetTypeDeclarationName(parentType);

               
                
                // return type matching
                bool iAmInReturnType = IsEqualToOrChildOf(parentMethod.ReturnType, type);
                Tuple<string, string> myTypeMethodKey = new Tuple<string, string>(parentTypeName, parentMethodName);
                if (iAmInReturnType &&
                    TypeMethodPairNeedsFullyDeclaredReturnType.Contains(myTypeMethodKey))
                {
                    return true;
                }

                // param type matching
                foreach (ParameterDeclaration param in parentMethod.Parameters)
                {
                    Tuple<string, string, string> myParamKey = new Tuple<string, string, string>(
                        parentTypeName,
                        parentMethodName,
                        param.NameToken.ToString());
                    bool iAmInParamType = IsEqualToOrChildOf(param.Type, type);
                    if (iAmInParamType &&
                        TypeMethodParamNameTrioNeedsFullyDeclaredType.Contains(myParamKey))
                    {
                        return true;
                    }
                }

                // general matching
                if (TypeMethodPairNeedsAllFullyDeclaredTypes.Contains(myTypeMethodKey))
                {
                    return true;
                }
            }
            PropertyDeclaration parentProperty = type.Ancestors.OfType<PropertyDeclaration>().FirstOrDefault();

            if(parentProperty != null && !parentProperty.IsNull &&
                parentType != null && !parentType.IsNull)
            {

                string parentPropertyName = parentProperty.NameToken.ToString();
                string parentTypeName = GetTypeDeclarationName(parentType);
                Tuple<string, string> myTypePropertyKey = new Tuple<string, string>(parentTypeName, parentPropertyName);

                // general matching
                if (TypePropertyPairNeedsAllFullyDeclaredTypes.Contains(myTypePropertyKey))
                {
                    return true;
                }
            }
            return false;
        }

        public static HashSet<string> ForbiddenNamespaces = new HashSet<string>()
        {
            // Used for defining assembly metadata, but we are doing that ourselves
            "Microsoft.CodeAnalysis",
            "System.Runtime.CompilerServices"
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
            "LZ4",
            "PDFiumSharp", // they modified it a lot as far as I can tell, so just wrap it
            "PhotonDust",
            // twitch
            "TwitchLib.Api.Core",
            "TwitchLib.Api.Core.Enums",
            "TwitchLib.Api.Core.Interfaces",
            "TwitchLib.Api.Core.Models",
            "TwitchLib.Api",
            "TwitchLib.Api.Enums",
            "TwitchLib.Api.Helix",
            "TwitchLib.Api.Helix.Models",
            "TwitchLib.Api.V5",
            "TwitchLib.Api.V5.Models",
            "TwitchLib.Client",
            "TwitchLib.Client.Enums",
            "TwitchLib.Client.Models",
            "TwitchLib.Communication",
            "TwitchLib.PubSub",
        };

        public static HashSet<string> bonusList = new HashSet<string>()
        {
            "Assimp",
            "Assimp.Configs",
            "BepuPhysics",
            "BepuPhysics.Collidables",
            "BepuPhysics.CollisionDetection",
            "BepuPhysics.Constraints",
            "BepuPhysics.Trees",
            "BepuUtilities",
            "BepuUtilities.Collections",
            "BepuUtilities.Memory",
            "ICSharpCode.Decompiler",
            "Microsoft.Bcl.AsyncInterfaces",
            "Microsoft.CodeAnalysis.Analyzers",
            "Microsoft.CodeAnalysis",
            "Microsoft.CodeAnalysis.CSharp",
            "Newtonsoft.Json",
            "System.CodeDom",
            "System.Core",
            "System.Text.Json",
            "System.Text.Json.Serialization",
            "System.Private.CoreLib",
            "System.Security.Cryptography",
            "System.Runtime.Serialization.Formatters.Binary",
            "System.Net.Http",
            "System.Numerics",
            "System",
            "System.Collections",
            "System.Collections.Generic",
            "System.ComponentModel",
            "System.Diagnostics",
            "System.Drawing",
            "System.Globalization",
            "System.IO",
            "System.IO.Compression",
            "System.Linq",
            "System.Linq.Expressions",
            "System.Net.Mail",
            "System.Net.Http",
            "System.Net.Http.Headers",
            "System.Net.Sockets",
            "System.Net.Security",
            "System.Net.WebSockets",
            "System.Threading.Tasks",
            "System.Timers",
            "System.Threading.Tasks.Dataflow",
            "System.Text.RegularExpressions",
            "System.Web",
            "Microsoft.AspNetCore.Http.Connections",
            "Microsoft.AspNetCore.Http.Connections.Client",
            "Microsoft.AspNetCore.SignalR",
            "Microsoft.AspNetCore.SignalR.Client",
            "EnumsNET",
            "SignalR.Strong",
            "PDFiumSharp",
            "PDFiumSharp.Enums",
            "PDFiumSharp.Types",
            "LiteDB",
            "LiteDB.Async",
            "LiteNetLib",
            "LiteNetLib.Utils",
            "QRCoder",
            "CSCore",
            "CSCore.Codecs",
            "CSCore.Codecs.FLAC",
            "CSCore.Codecs.OGG",
            "CSCore.Codecs.WAV",
            "TwitchLib.Api",
            "TwitchLib.Api.V5",
            "TwitchLib.Api.V5.Models.Bits",
            "TwitchLib.Api.V5.Models.Badges",
            "TwitchLib.Api.V5.Models.Channels",
            "TwitchLib.Api.V5.Models.Chat",
            "TwitchLib.Api.V5.Models.Clips",
            "TwitchLib.Api.V5.Models.Collections",
            "TwitchLib.Api.V5.Models.Games",
            "TwitchLib.Api.V5.Models.Ingests",
            "TwitchLib.Api.V5.Models.Subscriptions",
            "TwitchLib.Api.V5.Models.Streams",
            "TwitchLib.Api.V5.Models.Search",
            "TwitchLib.Api.V5.Models.Teams",
            "TwitchLib.Api.V5.Models.UploadVideo",
            "TwitchLib.Api.V5.Models.Users",
            "TwitchLib.Api.V5.Models.Videos",
            "TwitchLib.Api.V5.Models.ViewerHeartbeatService",
            "TwitchLib.Api.Core.Models.Search",
            "TwitchLib.Api.Core.Models.Streams",
            "TwitchLib.Api.Core.Models.Teams",
            "TwitchLib.Api.Core.Models.Subscriptions",
            "TwitchLib.Api.Core.Models.Users",
            "TwitchLib.Api.Core.Models.ViewerHeartbeatService",
            "TwitchLib.Client",
            "TwitchLib.Client.Enums",
            "TwitchLib.Client.Events",
            "TwitchLib.Client.Models",
            "TwitchLib.Communication.Events",
            "TwitchLib.PubSub",
            "TwitchLib.PubSub.Events",
            "LZ4",
            "mscorlib",

            // things that fail to resolve even though they should resolve
            "RetryContext",
            "WebRequest",
            "IPEndPoint",
            "SocketError",
            "FileIOMode",
            "IOStream",
            "System.Uri",
            "Vector", // system numerics

            // Ass imp stuff
            "Vector2D",
            "Vector3D",
            "Quaternion",
            "Color3D",
            "Color4D",
            "Matrix4x4",
        }; 

        public class TypeInfoLookup
        {
            public Dictionary<string, ITypeDefinition> typeDefinitions = new Dictionary<string, ITypeDefinition>();
            public Dictionary<string, Type> types = new Dictionary<string, Type>();
            public Dictionary<string, TypeDeclaration> typeDeclarations = new Dictionary<string, TypeDeclaration>();
        }

        // extra assemblies we depend on
        public static List<Assembly> GetExtraAssemblies(out List<string> extraAssemblyPaths)
        {
            extraAssemblyPaths = new List<string>();
            List<Assembly> result = new List<Assembly>();
            foreach (var dllFile in Directory.GetFiles(GetAllDllsRoot(out string _), "*.dll"))
            {
                result.Add(Assembly.LoadFrom(dllFile));
                extraAssemblyPaths.Add(dllFile);
            }
            result.Add(typeof(object).Assembly);
            extraAssemblyPaths.Add(typeof(object).Assembly.Location);
            return result;
        }

        public static Modifiers SetAccessibility(Modifiers modifiers)
        {
            if (modifiers.HasFlag(Modifiers.Private))
            {
                modifiers &= ~Modifiers.Private;
                modifiers |= Modifiers.Public;
            }
            if (modifiers.HasFlag(Modifiers.Protected))
            {
                modifiers &= ~Modifiers.Protected;
                modifiers |= Modifiers.Public;
            }
            if (modifiers.HasFlag(Modifiers.Internal))
            {
                modifiers &= ~Modifiers.Internal;
                modifiers |= Modifiers.Public;
            }
            return modifiers;
        }

        public static string GetAssemblyPath(Assembly assembly)
        {
            return new System.Uri(assembly.CodeBase).LocalPath;
        }

        public static IEnumerable<Tuple<Assembly, string, string>> WrapAssemblies(Dictionary<string, Assembly> assemblies)
        {
            List<Assembly> whitelistedAssemblies = new List<Assembly>();
            // might be modified so have to make a copy
            foreach (KeyValuePair<string, Assembly> pair in new Dictionary<string, Assembly>(assemblies))
            {
                Assembly assembly = pair.Value;
                if (whitelist.Contains(ReflectionUtils.GetAssemblyName(pair.Value)))
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
            allAssemblies.AddRange(GetExtraAssemblies(out List<string> assemblyPathsExtra));
            List<string> assemblyPaths = whitelistedAssemblies.Select(x => x.Location).ToList();
            assemblyPaths.AddRange(assemblyPathsExtra);
            HashSet<string> namespaceList = new HashSet<string>();
            for (int i = 0; i < allAssemblies.Count; i++)
            {
                Assembly assembly = allAssemblies[i];
                string assemblyPath = assemblyPaths[i];
                try
                {
                    var decompiler = new CSharpDecompiler(assemblyPath, new DecompilerSettings()
                    {
                        AlwaysUseGlobal=true,
                    });
                    iModules.Add(decompiler.TypeSystem.MainModule.PEFile);
                    foreach (ITypeDefinition definition in decompiler.TypeSystem.GetAllTypeDefinitions())
                    {
                        typeInfoLookup.typeDefinitions[definition.FullName] = definition;
                    }
                    foreach (Type type in assembly.GetTypes())
                    {
                        if (!namespaceList.Contains(type.Namespace))
                        {
                            namespaceList.Add(type.Namespace);
                        }
                        typeInfoLookup.types[type.FullName] = type;
                    }
                }
                catch
                {
                    Console.WriteLine("Failed to load assembly " + assemblyPath + " (this is probably fine)");
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
                var decompiler = new CSharpDecompiler(GetAssemblyPath(assembly), new DecompilerSettings());
                string assemblyName = ReflectionUtils.GetAssemblyName(assembly);
                Console.WriteLine("Wrapping assembly " + assemblyName);
                foreach (Tuple<string, string> code in WrapAssembly(assembly, typeInfoLookup, resolveContext, namespaceList))
                {
                    yield return new Tuple<Assembly, string, string>(assembly, code.Item1, code.Item2);
                }
                Console.WriteLine("Done wrapping assembly " + assemblyName);
            }


        }

        public static string FindParentDirectory(string startPath, string parentDirNameContains)
        {
            var directory = new DirectoryInfo(startPath);

            while (directory != null)
            {
                if (directory.Name.Contains(parentDirNameContains))
                {
                    return directory.FullName;
                }
                directory = directory.Parent;
            }

            return null; // Parent directory not found
        }

        public static string GetAllDllsRoot(out string gitRepoRoot)
        {
            // todo: this gives resonite directory
            gitRepoRoot = FindParentDirectory(AppDomain.CurrentDomain.BaseDirectory, "ResoniteUnityExporter");
            if (gitRepoRoot == null)
            {
                throw new ArgumentException("This needs to be ran within the ResoniteUnityExporter directory");
            }
            return Path.Combine(gitRepoRoot, "ResoniteBridge/Published/ResoniteBridgeWrapperLib");
        }


        public static List<Microsoft.CodeAnalysis.MetadataReference> GetNetStandardReferences()
        {

            string allDllsRoot = GetAllDllsRoot(out string gitRepoRoot);
            string refPath = Path.Combine(gitRepoRoot, "ResoniteBridge/Published/netstandard2.0");

            var coreLibs = new[]
            {
                    "netstandard.dll",
                    "System.Runtime.dll",
                    "System.Collections.dll",
                    "mscorlib.dll"
            };
            var references = new List<Microsoft.CodeAnalysis.MetadataReference>();
            foreach (var lib in coreLibs)
            {
                var path = Path.Combine(refPath, lib);
                references.Add(Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(path));
            }
            return references;
        }

        public static List<Microsoft.CodeAnalysis.MetadataReference> GetNetFrameworkReferences()
        {

            // netstandard 2.1 core libs
            string refPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
                    "Reference Assemblies",
                    "Microsoft",
                    "Framework",
                    ".NETFramework",
                    "v4.7.2");

            // Add core references
            var coreLibs = new[]
            {
                    "mscorlib.dll",
                    "System.dll",
                    "System.Core.dll",
                    "System.Net.Http.dll",
                    "System.Numerics.dll",
                    "System.IO.Compression.dll",
                    "System.ServiceModel.dll", // For System.Timers
                    "System.Drawing.dll",
                    "System.Web.dll",
            };
            var references = new List<Microsoft.CodeAnalysis.MetadataReference>();
            foreach (var lib in coreLibs)
            {
                var path = Path.Combine(refPath, lib);
                references.Add(Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(path));
            }
            return references;
        }

            



        public static void CreateWrapperAssembly(Dictionary<string, Assembly> assemblies, string rootNamespaceName)
        {
            new Thread(() =>
            {
                // creates if not exist
                
                List<Microsoft.CodeAnalysis.SyntaxTree> syntaxTrees = new List<Microsoft.CodeAnalysis.SyntaxTree>();
                List<string> syntaxTreeLabels = new List<string>();

                string allDllsRoot = GetAllDllsRoot(out string gitRepoRoot);
                string publishRoot = Path.Combine(gitRepoRoot, "ResoniteBridge/Published/ResoniteWrapper/Libraries");
                string generatedCodeRoot = Path.Combine(gitRepoRoot, "ResoniteBridge/Published/ResoniteWrapper/GeneratedCode");
                string errorsRoot = Path.Combine(gitRepoRoot, "ResoniteBridge/Published/ResoniteWrapper/CompileErrors");
                System.IO.Directory.CreateDirectory(publishRoot);
                System.IO.Directory.CreateDirectory(generatedCodeRoot);
                System.IO.Directory.CreateDirectory(errorsRoot);

                foreach (Tuple<Assembly, string, string> codeAndAssembly in WrapAssemblies(assemblies))
                {
                    Assembly assembly = codeAndAssembly.Item1;
                    string label = codeAndAssembly.Item2;
                    string code = codeAndAssembly.Item3;
                    syntaxTrees.Add(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParseText(code));
                    string assemblyName = ReflectionUtils.GetAssemblyName(assembly);
                    string outputCodeName = Path.Combine(Path.Combine(generatedCodeRoot, assemblyName), label.Replace(".", "/") + ".cs");
                    syntaxTreeLabels.Add(outputCodeName);
                    Directory.CreateDirectory(Path.GetDirectoryName(outputCodeName));
                    File.WriteAllText(outputCodeName, code);
                }

                bool netStandard = false;




                var assemblyAttributeSource = @"namespace System.Runtime.CompilerServices
                        {
                            [AttributeUsage(AttributeTargets.Assembly)]
                            public sealed class RefSafetyRulesAttribute : Attribute
                            {
                                public RefSafetyRulesAttribute(int version) => Version = version;
                                public int Version { get; }
                            }
                        }";


                List<Microsoft.CodeAnalysis.MetadataReference> references = GetNetFrameworkReferences();
                // some libraries use netstandard 

                // Walk up to find ResoniteUnityExporter then traverse down to find all the dlls we depend on
                string unityPluginRoot = Path.Combine(gitRepoRoot, "ExampleUnityProject/Assets/ResoniteUnityExporter/Plugins");
                foreach (var dllFile in Directory.GetFiles(allDllsRoot, "*.dll"))
                {
                    Console.WriteLine("extra Found assembly" + dllFile);
                    references.Add(Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(dllFile));
                    // also move any depended on dlls into the publish root directory
                    File.Copy(dllFile, Path.Combine(publishRoot, Path.GetFileName(dllFile)), true);
                    File.Copy(dllFile, Path.Combine(unityPluginRoot, Path.GetFileName(dllFile)), true);
                }


                syntaxTreeLabels.Insert(0, "AssemblyAttributes");
                syntaxTrees.Insert(0, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParseText(assemblyAttributeSource));



                string outDllName = rootNamespaceName + ".dll";
                string outPath =Path.Combine(publishRoot, outDllName);
                Console.WriteLine("Compiling");
                // Create compilation
                Microsoft.CodeAnalysis.CSharp.CSharpCompilation compilation = Microsoft.CodeAnalysis.CSharp.CSharpCompilation.Create(
                    rootNamespaceName,
                    syntaxTrees: syntaxTrees,
                    references: references,
                    options: new Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions(
                        Microsoft.CodeAnalysis.OutputKind.DynamicallyLinkedLibrary,
                        optimizationLevel: Microsoft.CodeAnalysis.OptimizationLevel.Release,
                        allowUnsafe: true
                    ));


                // weird stuff needed to force .NETStandard 2.1/NETFramework 4.7.2 (the version unity likes)

                var targetFrameworkAttribute = netStandard
                    ? compilation.SyntaxTrees.First()
                            .WithFilePath("TargetFrameworkAttribute.cs")
                            .WithRootAndOptions(
                                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParseText(@"
                                        using System.Runtime.Versioning;
                                        [assembly: TargetFramework("".NETStandard,Version=v2.1"")]
                                        ").GetRoot(),
                            compilation.SyntaxTrees.First().Options)
                    : compilation.SyntaxTrees.First()
                            .WithFilePath("TargetFrameworkAttribute.cs")
                            .WithRootAndOptions(
                                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParseText(@"
                                        using System.Runtime.Versioning;
                                        [assembly: TargetFramework("".NETFramework,Version=v4.7.2"")]
                                        ").GetRoot(),
                            compilation.SyntaxTrees.First().Options);



                compilation = compilation.AddSyntaxTrees(targetFrameworkAttribute);


                Console.WriteLine("Emitting..." + outPath);

                Microsoft.CodeAnalysis.Emit.EmitResult result;
                using (FileStream writer = File.OpenWrite(outPath))
                {
                    result = compilation.Emit(writer);
                }
                StringBuilder allErrors = new StringBuilder();
                if (!result.Success)
                {
                    foreach (var diagnostic in result.Diagnostics)
                    {
                        string codePath = "(unknown location)";
                        int treeIndex = syntaxTrees.IndexOf(diagnostic.Location.SourceTree);
                        if (treeIndex != -1)
                        {
                            codePath = syntaxTreeLabels[treeIndex];
                        }
                        if (diagnostic.Severity == Microsoft.CodeAnalysis.DiagnosticSeverity.Error)
                        {
                            allErrors.AppendLine(codePath + " " + diagnostic.ToString());
                            if (diagnostic.Location != null && diagnostic.Location.SourceTree != null)
                            {
                                var location = diagnostic.Location;
                                var lineSpan = location.GetLineSpan();
                                var sourceText = location.SourceTree.GetText();
                                var startLine = sourceText.Lines[Math.Max(lineSpan.StartLinePosition.Line-2, 0)];
                                var endLine = sourceText.Lines[Math.Min(lineSpan.EndLinePosition.Line+2, sourceText.Lines.Count-1)];
                                var fullLines = sourceText.ToString(Microsoft.CodeAnalysis.Text.TextSpan.FromBounds(startLine.Start, endLine.End));
                                allErrors.AppendLine(fullLines);
                            }
                        }
                    }
                    File.WriteAllText(Path.Combine(errorsRoot, "errors.txt"), allErrors.ToString());
                    throw new Exception($"Compilation failed");
                }
                else
                {
                    // move the dll also into the unity project plugins
                    File.Copy(outPath, Path.Combine(unityPluginRoot, Path.GetFileName(outDllName)), true);
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
