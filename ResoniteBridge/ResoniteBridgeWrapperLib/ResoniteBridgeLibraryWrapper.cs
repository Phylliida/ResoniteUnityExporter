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
                                    new SimpleType("InvalidCastException"),
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

            foreach (var param in methodDeclaration.Parameters)
            {
                invocationParams.Add(new IdentifierExpression(param.NameToken.ToString()));
            }

            InvocationExpression invocation = new InvocationExpression(
                new MemberReferenceExpression(clientWrappers, "CallMethod"),
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
                                    new SimpleType("InvalidCastException"),
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
                                    new SimpleType("InvalidCastException"),
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
                // these can be in namespaces, outside of types
                if (astNode is DelegateDeclaration delegateDeclare)
                {
                    // replace unmanaged with stuct in delegates so the replacements below also work
                    foreach (var constraint in delegateDeclare.Constraints)
                    {
                        ReplaceUnmanagedConstraintWithStruct(constraint, nodesToRemove);
                    }
                }
                // process and wrap type declarations
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
                            if (indexerDeclare.Modifiers.HasFlag(Modifiers.Abstract))
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
                            if (typeDeclare.NameToken.ToString().Contains("LocalDatabaseAccountDataStore")) {
                                
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
                            methodDeclare.NameToken.ToString().StartsWith("op_") ||
                            // we don't support out yet
                            methodDeclare.Parameters.Any(
                                (p) => p.ParameterModifier.HasFlag(
                                    ICSharpCode.Decompiler.CSharp.Syntax.ParameterModifier.Out))
                            )
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
                                if (!methodDeclare.Modifiers.HasFlag(Modifiers.Abstract)) { 
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
                        else if (childNode is PropertyDeclaration propertyDeclare)
                        {
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

                                // don't fill out bodies for abstract properties
                                if (propertyDeclare.Modifiers.HasFlag(Modifiers.Abstract))
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
                        else if (childNode is FieldDeclaration fieldDeclare)
                        {
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
                                if (fieldDeclare.Modifiers.HasFlag(Modifiers.Abstract))
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
                if (astNode is ICSharpCode.Decompiler.CSharp.Syntax.MethodDeclaration methodDeclare)
                {
                    // we can't have nullable return type with our wrappers, it confuses type system
                    ReplaceTypeIfUnresolved(methodDeclare.ReturnType, resolveContext, namespaceList, removeNullable: true);
                }
                else if (astNode is ParameterDeclaration paramDeclare)
                {
                    if (ReplaceTypeIfUnresolved(paramDeclare.Type, resolveContext, namespaceList))
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
                    // remove nullable for typeof, it confuses it
                    ReplaceTypeIfUnresolved(typeOfExpr.Type, resolveContext, namespaceList, removeNullable: true);
                }
                // occurs in if (a is Type b) statements
                else if(astNode is DeclarationExpression declarationExpression)
                {
                    // remove nullable for these is expressions
                    ReplaceTypeIfUnresolved(declarationExpression.Type, resolveContext, namespaceList, removeNullable: true);
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

                        // don't need to recurse so alsoChildren=false, no generics and that messes stuff up
                        if(ReplaceTypeIfUnresolved(usingName, resolveContext, namespaceList, alsoChildren: false))
                        {
                            Console.WriteLine("Removing using: " + usingName);
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
            usings = "using ResoniteBridge;";


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
            "BinaryReader"
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

        public static bool ReplaceTypeIfUnresolved(AstType astType, ITypeResolveContext resolveContext, HashSet<string> namespaceList, bool alsoChildren=true, bool removeNullable=false)
        {
            if (alsoChildren)
            {
                // recurse (for generics)
                foreach (AstType childType in astType.DescendantNodes().OfType<SimpleType>())
                {
                    ReplaceTypeIfUnresolved(childType, resolveContext, namespaceList);
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
                    AstType newType = new SimpleType(keywordType.FullName);
                    astType.ReplaceWith(newType);
                    astType = newType;
                    // keywords exist, we are done
                    return false;
                }

                ITypeReference typeReference = astType.ToTypeReference();
                IType iType = typeReference.Resolve(resolveContext);
                // resolved, we are happy
                if (iType.Kind != ICSharpCode.Decompiler.TypeSystem.TypeKind.Unknown)
                {
                    return false;
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
                        return false;
                    }
                }
            }
            // still didn't resolve, replace with ResoniteBridgeValue
            astType.ReplaceWith(new SimpleType("ResoniteBridge.ResoniteBridgeValue"));
            return true;
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
        };

        public static HashSet<string> bonusList = new HashSet<string>()
        {
            "Assimp",
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
            "System.Text.Json",
            "System.Private.CoreLib",
            "System.Security.Cryptography",
            "System.Runtime.Serialization.Formatters.Binary",
            "System.Net.Http",
            "System",
            "System.Collections",
            "System.Collections.Generic",
            "System.ComponentModel",
            "System.Diagnostics",
            "System.Globalization",
            "System.IO",
            "System.Linq",
            "System.Net.Http",
            "System.Net.Http.Headers",
            "System.Net.Sockets",
            "System.Net.WebSockets",
            "System.Threading.Tasks.Dataflow",
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
            "TwitchLib.Api.V5.Models.Badges",
            "TwitchLib.Client",
            "TwitchLib.Client.Enums",
            "TwitchLib.Client.Events",
            "TwitchLib.Client.Models",
            "TwitchLib.Communication.Events",
            "TwitchLib.PubSub",
            "TwitchLib.PubSub.Events",
            "mscorlib",

            // things that fail to resolve even though they should resolve
            "RetryContext",
            "WebRequest",

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
            Console.WriteLine("START GET EXTRA");
            List<Assembly> result = new List<Assembly>();
            foreach (var dllFile in Directory.GetFiles(@"C:\Users\yams\Desktop\prog\ResoniteUnityExporter\ResoniteBridge\ResoniteBridgeLib\bin\Debug\netstandard2.1", "*.dll"))
            {
                Console.WriteLine("EXTRA Found assembly" + dllFile);
                result.Add(Assembly.LoadFrom(dllFile));
                extraAssemblyPaths.Add(dllFile);
            }
            result.Add(typeof(object).Assembly);
            extraAssemblyPaths.Add(typeof(object).Assembly.Location);
            return result;
        }

        public static string GetAssemblyPath(Assembly assembly)
        {
            return new System.Uri(assembly.CodeBase).LocalPath;
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
                    var decompiler = new CSharpDecompiler(assemblyPath, new DecompilerSettings());
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
                    Console.WriteLine("FAiled to load assembly " + assemblyPath);
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

                foreach (Tuple<Assembly, string> codeAndAssembly in WrapAssemblies(assemblies))
                {
                    Assembly assembly = codeAndAssembly.Item1;
                    string code = codeAndAssembly.Item2;
                    syntaxTrees.Add(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParseText(code));
                    File.WriteAllText(outTxt + assembly.FullName + ".cs", code);
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

                var references = new List<Microsoft.CodeAnalysis.MetadataReference>();
                foreach (var lib in coreLibs)
                {
                    var path = Path.Combine(refPath, lib);
                    references.Add(Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(path));
                }

                foreach (var dllFile in Directory.GetFiles(@"C:\Users\yams\Desktop\prog\ResoniteUnityExporter\ResoniteBridge\ResoniteBridgeLib\bin\Debug\netstandard2.1", "*.dll"))
                {
                    Console.WriteLine("extra Found assembly" + dllFile);
                    references.Add(Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(dllFile));
                }
                syntaxTrees.Insert(0, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParseText(assemblyAttributeSource));

                string outPath = "C:\\Users\\yams\\Desktop\\prog\\ResoniteUnityExporter\\ResoniteBridge\\ResoniteBridgeStandalone\\" + rootNamespaceName + ".dll";
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

                
                // weird stuff needed to force .NETStandard 2.1
                var targetFrameworkAttribute = compilation.SyntaxTrees.First()
                            .WithFilePath("TargetFrameworkAttribute.cs")
                            .WithRootAndOptions(
                                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree.ParseText(@"
                                        using System.Runtime.Versioning;
                                        [assembly: TargetFramework("".NETStandard,Version=v2.1"")]
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
                        if (diagnostic.Severity == Microsoft.CodeAnalysis.DiagnosticSeverity.Error)
                        {
                            allErrors.AppendLine(diagnostic.Location + " " + diagnostic.ToString());
                            if (diagnostic.Location != null && diagnostic.Location.SourceTree != null)
                            {
                                var location = diagnostic.Location;
                                var lineSpan = location.GetLineSpan();
                                var sourceText = location.SourceTree.GetText();
                                var startLine = sourceText.Lines[lineSpan.StartLinePosition.Line-2];
                                var endLine = sourceText.Lines[lineSpan.EndLinePosition.Line+2];
                                var fullLines = sourceText.ToString(Microsoft.CodeAnalysis.Text.TextSpan.FromBounds(startLine.Start, endLine.End));
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
