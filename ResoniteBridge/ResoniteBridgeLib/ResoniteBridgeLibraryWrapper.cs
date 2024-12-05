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
            AsResoniteBridgeValue = 0,
            AsType = 1,
            AsRaw = 2
        }



        public static ParsingType GetParsingType(Type type)
        {
            string fullTypeName = GetTypeName(type);
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
                    return GetTypeName(type);
                case ParsingType.AsRaw:
                    return GetTypeName(type);
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

        public static HashSet<string> OverrideMethods = new HashSet<string>()
        {
            "ToString",
            "GetHashCode",
        };
        public static bool IsOverrideMethod(string methodName)
        {
            return OverrideMethods.Contains(methodName);
        }

        public static Dictionary<string, string> ParameterNameReplacements = new Dictionary<string, string>()
        {
            // object is a keyword
            {"object", "__object" },
            {"namespace", "__namespace" }
        };

        public static Dictionary<string, string> ParameterTypeReplacements = new Dictionary<string, string>()
        {
            // nullable is not permitted as input type
            {"System.Nullable", "System.Object" }
        };

        public static MethodDeclarationSyntax CreateBridgeMethod(MethodInfo method, System.Type type)
        {
            string assemblyName = ResoniteBridge.ResoniteBridgeServer.GetAssemblyName(type.Assembly);
            string genericStr = "";
            string constraints = "";
            if (method.IsGenericMethod)
            {
                List<string> genericTypeNames = new List<string>(); ;
                foreach (Type genericType in method.GetGenericArguments())
                {
                    genericTypeNames.Add(genericType.Name);
                }
                genericStr = "<" + String.Join(", ", genericTypeNames) + ">";
                constraints = GetGenericConstraints(method.GetGenericArguments());
            }

            List<string> argumentStrs = new List<string>();
            List<string> variableStrs = new List<string>();

            foreach (ParameterInfo param in method.GetParameters())
            {
                // stuff like "object" are keywords and confuse the compiler
                string paramName = param.Name;
                if (ParameterNameReplacements.ContainsKey(paramName))
                {
                    paramName = ParameterNameReplacements[paramName];
                }
                string wrappedType = GetWrappedDataType(param.ParameterType);
                if (ParameterTypeReplacements.ContainsKey(wrappedType))
                {
                    wrappedType = ParameterTypeReplacements[wrappedType];
                }
                argumentStrs.Add(wrappedType + " " + paramName);
                variableStrs.Add("" + paramName);
            }

            string outputType = GetWrappedDataType(method.ReturnType);

            string argumentInputs = String.Join(", ", argumentStrs);
            string variableInputs = String.Join(", ", variableStrs);

            if (variableInputs.Length > 0)
            {
                variableInputs = ", " + variableInputs;
            }

            string staticStr = method.IsStatic
                ? "static "
                : "";

            string overrideStr = IsOverrideMethod(method.Name)
                ? "override "
                : "";
            string target = GetTarget(method.IsStatic, assemblyName, type.Name);

            // void has no return str
            string returnStr = outputType == "void"
                ? ""
                : $@"return ({outputType})";

            string methodCode = $@"
                    public {staticStr}{overrideStr}{outputType} {method.Name}{genericStr}({argumentInputs}) {constraints}
                    {{
                        {returnStr}ResoniteBridge.ResoniteBridgeClientWrappers.CastValue( 
                                ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(
                                {target}, 
                                ""{method.Name}""
                                {variableInputs}),
                            typeof({outputType}));
                    }}";

            return (MethodDeclarationSyntax)SyntaxFactory.ParseMemberDeclaration(methodCode);
        }
        // non static are tricky, we need to store the data in the types somehow

        public static void AddBackingDeclaration(CodeTypeDeclaration typeDeclaration)
        {
            var backingField = new CodeMemberField(
                new CodeTypeReference("ResoniteBridge.ResoniteBridgeValue"),
                "__backing");

            backingField.Attributes = MemberAttributes.Private;

            // Property declaration
            var backingProperty = new CodeMemberProperty
            {
                Name = "__Backing",
                Type = new CodeTypeReference("ResoniteBridge.ResoniteBridgeValue"),
                Attributes = MemberAttributes.Public | MemberAttributes.Final,
                HasGet = true,
                HasSet = true
            };

            // Getter
            backingProperty.GetStatements.Add(
                new CodeMethodReturnStatement(
                    new CodeFieldReferenceExpression(
                        new CodeThisReferenceExpression(),
                        "__backing")));

            // Setter
            backingProperty.SetStatements.Add(
                new CodeAssignStatement(
                    new CodeFieldReferenceExpression(
                        new CodeThisReferenceExpression(),
                        "__backing"),
                    new CodePropertySetValueReferenceExpression()));

            typeDeclaration.Members.Add(backingField);
            typeDeclaration.Members.Add(backingProperty);
        }
        public static IEnumerable<Type> GetDirectInterfaces(Type type)
        {
            // get all interfaces
            var allInterfaces = type.GetInterfaces();
            // get all interfaces of those interfaces
            var inheritedInterfaces = allInterfaces
                .SelectMany(i => i.GetInterfaces());
            var baseInherited = allInterfaces
                .Select(i => i.BaseType);

            var twoOrMoreLevelsUp = inheritedInterfaces.Union(baseInherited).Distinct();

            // exclude those from all of them
            // that way we only have direct (lowest level) ones
            return allInterfaces
                .Except(twoOrMoreLevelsUp);
        }

        public static string NodeToString(AstNode node)
        {
            return node.ToString();
            /*
            var writer = new StringWriter();
            var tokenWriter = new TextTokenWriter(writer);
            node.WriteAnnotatedTo(tokenWriter);
            return writer.ToString();
            */
            /*
            var output = new StringWriter();
            var visitor = new CSharpOutputVisitor(output,
                FormattingOptionsFactory.CreateAllman());  // or CreateMono() for alternative style
            node.AcceptVisitor(visitor);
            return output.ToString();
            */
        }

        /*
        public static CodeTypeDeclaration DeclareType(ICSharpCode.Decompiler.CSharp.Syntax.TypeDeclaration syntaxTree, ITypeDefinition typeDef, Type sourceType)
        {
            string assemblyName = ResoniteBridgeServer.GetAssemblyName(sourceType.Assembly);

            string typeName = GetTypeName(sourceType, includeNamespace: false, includeGenerics: false, includeParentClasses: false);

            TypeAttributes typeAttributes = TypeAttributes.Public;
           
            
            // Create type declaration
            var typeDeclaration = new CodeTypeDeclaration(typeName)
            {
                IsClass = typeDef.Kind == ICSharpCode.Decompiler.TypeSystem.TypeKind.Class,
                IsInterface = typeDef.Kind == ICSharpCode.Decompiler.TypeSystem.TypeKind.Interface,
                IsEnum = typeDef.Kind == ICSharpCode.Decompiler.TypeSystem.TypeKind.Enum,
                IsStruct = typeDef.Kind == ICSharpCode.Decompiler.TypeSystem.TypeKind.Struct,
                TypeAttributes = TypeAttributes.Public
            };

            // add generics
            if (sourceType.IsGenericType)
            {
                // remove ` stuff
                typeDeclaration.Name = sourceType.Name.Split('`')[0];

                foreach (var genericArg in sourceType.GetGenericArguments())
                {
                    var typeParam = new CodeTypeParameter(genericArg.Name);

                    // Add constraints
                    var constraints = genericArg.GetGenericParameterConstraints();
                    foreach (var constraint in constraints)
                    {
                        typeParam.Constraints.Add(new CodeTypeReference(constraint));
                    }

                    // Add special constraints ( : class, : struct, :new())
                    var attributes = genericArg.GenericParameterAttributes;
                    // unfortunately there's no easy to make : class and :struct so we just do a term with zero width space and replace it later
                    // cursed but it works
                    // we don't need this
                    //if ((attributes & GenericParameterAttributes.ReferenceTypeConstraint) != 0)
                    //    typeParam.Constraints.Add("CLASSCONSTRAINT");
                    if ((attributes & GenericParameterAttributes.NotNullableValueTypeConstraint) != 0)
                        typeParam.Constraints.Add("STRUCTCONSTRAINT");
                    // we don't need this
                    // if ((attributes & GenericParameterAttributes.DefaultConstructorConstraint) != 0)
                    //    typeParam.HasConstructorConstraint = true;
                    typeDeclaration.TypeParameters.Add(typeParam);
                }
            }


            foreach (AstNode baseType in typeDeclaration.BaseTypes)
            {
                typeDeclaration.BaseTypes.Add(new CodeTypeReference(baseType.ToString()));
            }

            //var directlyDeclared = typeDef.DirectBaseTypes
            //    .Where(t => !t.IsKnownType(KnownTypeCode.Object));

            //foreach (IType interfaceType in directlyDeclared)
            //{
            //   interfaceType.ReflectionName));
            //}

            // Add base type if exists and not value type
            //if (sourceType.BaseType != null && sourceType.BaseType != typeof(ValueType))
            //{
            //    typeDeclaration.BaseTypes.Add(new CodeTypeReference(sourceType.BaseType));
            //}

            // Add interfaces
            //foreach (var interface_ in GetDirectInterfaces(sourceType))
            //{
            //    typeDeclaration.BaseTypes.Add(new CodeTypeReference(interface_));
            //}



            typeDeclaration.BaseTypes.Add(new CodeTypeReference(typeof(ResoniteBridge.ResoniteBridgeValueHolder)));
            AddBackingDeclaration(typeDeclaration);

            var staticTarget = new CodeObjectCreateExpression(
                    "ResoniteBridge.ResoniteBridgeValue",
                    new CodePrimitiveExpression(null),
                    new CodePrimitiveExpression(assemblyName),
                    new CodePrimitiveExpression(sourceType.Name),
                    new CodeFieldReferenceExpression(
                        new CodeTypeReferenceExpression("ResoniteBridge.ResoniteBridgeValueType"),
                        "Type"
                    )
                );
            var instanceTarget = new CodeFieldReferenceExpression(
                    new CodeThisReferenceExpression(),
                    "__Backing"
            );


            // Add properties
            foreach (var prop in sourceType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static))
            {
                // we don't support ref types yet, there's only 12 in all libraries so not a big deal
                if (prop.PropertyType.IsByRef)
                {
                    continue;
                }
                bool isStatic = prop.GetAccessors(nonPublic: true)[0].IsStatic;
                // final is needed to remove virtual which is added by default
                MemberAttributes attributes = MemberAttributes.Public | MemberAttributes.Final;
                if (isStatic)
                {
                    attributes |= MemberAttributes.Static;
                }
                var propertyDecl = new CodeMemberProperty
                {
                    Name = prop.Name,
                    Type = new CodeTypeReference(prop.PropertyType),
                    Attributes = attributes
                };

                if (prop.CanRead)
                {
                    propertyDecl.HasGet = true;
                    var getter = WrapGetter(isStatic, prop.PropertyType, prop.Name, staticTarget, instanceTarget, "GetProperty");
                    propertyDecl.GetStatements.Add(getter);
                }
                if (prop.CanWrite)
                {
                    propertyDecl.HasSet = true;
                    var setter = WrapSetter(isStatic, prop.Name, staticTarget, instanceTarget, "SetProperty");
                    propertyDecl.SetStatements.Add(setter);
                }

                typeDeclaration.Members.Add(propertyDecl);
            }

            // Add fields
            foreach (var field in sourceType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static))
            {
                // we don't support ref types yet, there's only 12 in all libraries so not a big deal
                if (field.FieldType.IsByRef)
                {
                    continue;
                }
                bool isStatic = field.IsStatic;
                // final is needed to remove virtual which is added by default
                MemberAttributes attributes = MemberAttributes.Public | MemberAttributes.Final;
                if (isStatic)
                {
                    attributes |= MemberAttributes.Static;
                }
                var propertyDecl = new CodeMemberProperty
                {
                    Name = field.Name,
                    Type = new CodeTypeReference(field.FieldType),
                    Attributes = attributes
                };


                propertyDecl.HasGet = true;
                var getter = WrapGetter(isStatic, field.FieldType, field.Name, staticTarget, instanceTarget, "GetField");
                propertyDecl.GetStatements.Add(getter);
                propertyDecl.HasSet = true;
                var setter = WrapSetter(isStatic, field.Name, staticTarget, instanceTarget, "SetField");
                propertyDecl.SetStatements.Add(setter);
                typeDeclaration.Members.Add(propertyDecl);
            }

            /*
            // Add methods
            foreach (var method in sourceType.GetMethods(BindingFlags.Public | BindingFlags.Instance))
            {
                // Skip property accessors and special methods
                if (method.IsSpecialName)
                    continue;

                var methodDecl = new CodeMemberMethod
                {
                    Name = method.Name,
                    ReturnType = new CodeTypeReference(method.ReturnType),
                    Attributes = MemberAttributes.Public
                };

                // Add parameters
                foreach (var param in method.GetParameters())
                {
                    methodDecl.Parameters.Add(
                        new CodeParameterDeclarationExpression(param.ParameterType, param.Name));
                }

                // Add method body (just throws NotImplementedException)
                methodDecl.Statements.Add(
                    new CodeThrowExceptionStatement(
                        new CodeObjectCreateExpression(typeof(NotImplementedException))));

                typeDeclaration.Members.Add(methodDecl);
            }
            * /

            // recursively declare subtypes inside this
            //foreach (var subtype in sourceType.GetNestedTypes())
            //{
            //    typeDeclaration.Members.Add(DeclareType(subtype));
            //}

            return typeDeclaration;
        }
        */

        public static void WrapType(CodeCompileUnit compileUnit, ICSharpCode.Decompiler.CSharp.Syntax.TypeDeclaration typeDeclaration, ITypeDefinition sourceType, Type type)
        {
            // we handle nested types seperately, inside the type that holds them
            if (sourceType.DeclaringTypeDefinition != null)
            {
                return;
            }

            // Add namespace
            var codeNamespace = new CodeNamespace(sourceType.Namespace);
            compileUnit.Namespaces.Add(codeNamespace);

           // var typeDeclare = DeclareType(typeDeclaration, sourceType, type);

            //codeNamespace.Types.Add(typeDeclare);
        }
        

        // modified from https://stackoverflow.com/a/16466858
        // This gives the code that represents the type
        // Neither FullName or Name always give the right thing
        // Wheras this will
        public static string GetTypeNameHelper(Type type, bool includeNamespace, bool includeGenerics)
        {
            string result;

            using (var codeDomProvider = CodeDomProvider.CreateProvider("C#"))
            {
                CodeTypeReference reference = new CodeTypeReference(type);
                reference.Options = CodeTypeReferenceOptions.GenericTypeParameter;
                var typeReferenceExpression = new CodeTypeReferenceExpression(reference);
                using (var writer = new StringWriter())
                {
                    codeDomProvider.GenerateCodeFromExpression(typeReferenceExpression, writer, new CodeGeneratorOptions());
                    result = writer.GetStringBuilder().ToString();
                }
            }
            if (!includeNamespace && type.Namespace != null)
            {
                string namespaceStr = type.Namespace;
                if (!result.StartsWith(namespaceStr))
                {
                    throw new ArgumentException("Somehow it doesn't start with own namespace?");
                }
                // +1 because .
                result = result.Substring(namespaceStr.Length + 1);
            }
            if (!includeGenerics && result.Contains("<"))
            {
                result = result.Substring(0, result.IndexOf("<"));
            }
            return result;
        }

        public static string GetTypeName(System.Type type, bool includeNamespace = true, bool includeGenerics = true, bool includeParentClasses = true)
        {
            string result = GetTypeNameHelper(type, includeNamespace: includeNamespace, includeGenerics: includeGenerics);
            if (includeNamespace)
            {
                result = ReplaceNamespaceAliases(result);
            }
            result = result.Replace("&", ""); // roslyn gets confused by these, we don't need them
            if (!includeParentClasses)
            {
                // get everything after last .
                if (result.Contains("."))
                {
                    result = result.Substring(result.LastIndexOf(".") + 1);
                }
            }
            return result;
        }


        public static string GetTypeNamespace(System.Type type)
        {
            if (type.Namespace == null)
            {
                return null;
            }
            return NamespaceOnlyAliases(type.Namespace);
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
                .Replace("FrooxEngine.ProtoFlux", "ProtoFlux")
                .Replace("System.Void", "void"); // System.Void isn't a valid return type, void is
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

        public static string GetGenericConstraints(System.Type[] genericArguments)
        {
            string constraints = "";
            bool[] isGenericParamNonNullable = new bool[genericArguments.Length];
            foreach (System.Type genericArgument in genericArguments)
            {
                // we should also test for value type and enum but ehh it's ok
                if((genericArgument.GenericParameterAttributes
                    & GenericParameterAttributes.NotNullableValueTypeConstraint) != 0)
                {
                    constraints += " where " + genericArgument.Name + " : struct ";
                }
            }
            return constraints;
        }


        public static NamespaceDeclarationSyntax WrapTypeOld(System.Type type, HashSet<Tuple<string, string>> seenItems)
        {
            string fullTypeNameWithoutNamespace = GetTypeName(type, includeNamespace: false);
            string fullTypeNameWithoutGenerics = GetTypeName(type, includeNamespace: false, includeGenerics: false);

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
                constraints = GetGenericConstraints(type.GetGenericArguments());
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

            string fullTypeName = GetTypeName(type);

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

            foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance))
            {
                if (method.Name != type.Name && // prevents "member names cannot be the same as their enclosing type"
                    !seenItems.Contains(new Tuple<string, string>(fullTypeName, method.Name)) // avoid duplicates
                    // generics
                    && !method.Name.Contains("`")
                    // getters and setters, those are addressed in properties above
                    && !method.Name.StartsWith("get_")
                    && !method.Name.StartsWith("set_")
                    // we don't need to bridge GetType
                    && method.Name != "GetType"
                    // these weird autogenerated ones
                    && !method.Name.StartsWith("<"))
                {
                    seenItems.Add(new Tuple<string, string>(fullTypeName, method.Name));
                    //MethodDeclarationSyntax wrappedMethod = CreateBridgeMethod(method, type);
                    if (type.IsClass)
                    {
                    //    classDeclaration = classDeclaration.AddMembers(wrappedMethod);
                    }
                    else
                    {
                    //    structDeclaration = structDeclaration.AddMembers(wrappedMethod);
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



        public class TypeCollector : IAstVisitor
        {
            private readonly List<TypeDeclaration> _types = new List<TypeDeclaration>();
            public IReadOnlyList<TypeDeclaration> Types => _types;

            public void VisitAccessor(Accessor accessor)
            {
            }

            public void VisitAnonymousMethodExpression(AnonymousMethodExpression anonymousMethodExpression)
            {
            }

            public void VisitAnonymousTypeCreateExpression(AnonymousTypeCreateExpression anonymousTypeCreateExpression)
            {
            }

            public void VisitArrayCreateExpression(ArrayCreateExpression arrayCreateExpression)
            {
            }

            public void VisitArrayInitializerExpression(ArrayInitializerExpression arrayInitializerExpression)
            {
            }

            public void VisitArraySpecifier(ArraySpecifier arraySpecifier)
            {
            }

            public void VisitAsExpression(AsExpression asExpression)
            {
            }

            public void VisitAssignmentExpression(AssignmentExpression assignmentExpression)
            {
            }

            public void VisitAttribute(ICSharpCode.Decompiler.CSharp.Syntax.Attribute attribute)
            {
            }

            public void VisitAttributeSection(AttributeSection attributeSection)
            {
            }

            public void VisitBaseReferenceExpression(BaseReferenceExpression baseReferenceExpression)
            {
            }

            public void VisitBinaryOperatorExpression(BinaryOperatorExpression binaryOperatorExpression)
            {
            }

            public void VisitBlockStatement(BlockStatement blockStatement)
            {
            }

            public void VisitBreakStatement(BreakStatement breakStatement)
            {
            }

            public void VisitCaseLabel(CaseLabel caseLabel)
            {
            }

            public void VisitCastExpression(CastExpression castExpression)
            {
            }

            public void VisitCatchClause(CatchClause catchClause)
            {
            }

            public void VisitCheckedExpression(CheckedExpression checkedExpression)
            {
            }

            public void VisitCheckedStatement(CheckedStatement checkedStatement)
            {
            }

            public void VisitComment(Comment comment)
            {
            }

            public void VisitComposedType(ComposedType composedType)
            {
            }

            public void VisitConditionalExpression(ConditionalExpression conditionalExpression)
            {
            }

            public void VisitConstraint(Constraint constraint)
            {
            }

            public void VisitConstructorDeclaration(ConstructorDeclaration constructorDeclaration)
            {
            }

            public void VisitConstructorInitializer(ConstructorInitializer constructorInitializer)
            {
            }

            public void VisitContinueStatement(ContinueStatement continueStatement)
            {
            }

            public void VisitCSharpTokenNode(CSharpTokenNode cSharpTokenNode)
            {
            }

            public void VisitCustomEventDeclaration(CustomEventDeclaration customEventDeclaration)
            {
            }

            public void VisitDeclarationExpression(DeclarationExpression declarationExpression)
            {
            }

            public void VisitDefaultValueExpression(DefaultValueExpression defaultValueExpression)
            {
            }

            public void VisitDelegateDeclaration(DelegateDeclaration delegateDeclaration)
            {
            }

            public void VisitDestructorDeclaration(DestructorDeclaration destructorDeclaration)
            {
            }

            public void VisitDirectionExpression(DirectionExpression directionExpression)
            {
            }

            public void VisitDocumentationReference(DocumentationReference documentationReference)
            {
            }

            public void VisitDoWhileStatement(DoWhileStatement doWhileStatement)
            {
            }

            public void VisitEmptyStatement(EmptyStatement emptyStatement)
            {
            }

            public void VisitEnumMemberDeclaration(EnumMemberDeclaration enumMemberDeclaration)
            {
            }

            public void VisitErrorNode(AstNode errorNode)
            {
            }

            public void VisitEventDeclaration(EventDeclaration eventDeclaration)
            {
            }

            public void VisitExpressionStatement(ExpressionStatement expressionStatement)
            {
            }

            public void VisitExternAliasDeclaration(ExternAliasDeclaration externAliasDeclaration)
            {
            }

            public void VisitFieldDeclaration(FieldDeclaration fieldDeclaration)
            {
            }

            public void VisitFixedFieldDeclaration(FixedFieldDeclaration fixedFieldDeclaration)
            {
            }

            public void VisitFixedStatement(FixedStatement fixedStatement)
            {
            }

            public void VisitFixedVariableInitializer(FixedVariableInitializer fixedVariableInitializer)
            {
            }

            public void VisitForeachStatement(ForeachStatement foreachStatement)
            {
            }

            public void VisitForStatement(ForStatement forStatement)
            {
            }

            public void VisitFunctionPointerType(FunctionPointerAstType functionPointerType)
            {
            }

            public void VisitGotoCaseStatement(GotoCaseStatement gotoCaseStatement)
            {
            }

            public void VisitGotoDefaultStatement(GotoDefaultStatement gotoDefaultStatement)
            {
            }

            public void VisitGotoStatement(GotoStatement gotoStatement)
            {
            }

            public void VisitIdentifier(Identifier identifier)
            {
            }

            public void VisitIdentifierExpression(IdentifierExpression identifierExpression)
            {
            }

            public void VisitIfElseStatement(IfElseStatement ifElseStatement)
            {
            }

            public void VisitIndexerDeclaration(IndexerDeclaration indexerDeclaration)
            {
            }

            public void VisitIndexerExpression(IndexerExpression indexerExpression)
            {
            }

            public void VisitInterpolatedStringExpression(InterpolatedStringExpression interpolatedStringExpression)
            {
            }

            public void VisitInterpolatedStringText(InterpolatedStringText interpolatedStringText)
            {
            }

            public void VisitInterpolation(Interpolation interpolation)
            {
            }

            public void VisitInvocationExpression(InvocationExpression invocationExpression)
            {
            }

            public void VisitInvocationType(InvocationAstType invocationType)
            {
            }

            public void VisitIsExpression(IsExpression isExpression)
            {
            }

            public void VisitLabelStatement(LabelStatement labelStatement)
            {
            }

            public void VisitLambdaExpression(LambdaExpression lambdaExpression)
            {
            }

            public void VisitLocalFunctionDeclarationStatement(LocalFunctionDeclarationStatement localFunctionDeclarationStatement)
            {
            }

            public void VisitLockStatement(LockStatement lockStatement)
            {
            }

            public void VisitMemberReferenceExpression(MemberReferenceExpression memberReferenceExpression)
            {
            }

            public void VisitMemberType(MemberType memberType)
            {
            }

            public void VisitMethodDeclaration(MethodDeclaration methodDeclaration)
            {
            }

            public void VisitNamedArgumentExpression(NamedArgumentExpression namedArgumentExpression)
            {
            }

            public void VisitNamedExpression(NamedExpression namedExpression)
            {
            }

            public void VisitNamespaceDeclaration(NamespaceDeclaration namespaceDeclaration)
            {
            }

            public void VisitNullNode(AstNode nullNode)
            {
            }

            public void VisitNullReferenceExpression(NullReferenceExpression nullReferenceExpression)
            {
            }

            public void VisitObjectCreateExpression(ObjectCreateExpression objectCreateExpression)
            {
            }

            public void VisitOperatorDeclaration(OperatorDeclaration operatorDeclaration)
            {
            }

            public void VisitOutVarDeclarationExpression(OutVarDeclarationExpression outVarDeclarationExpression)
            {
            }

            public void VisitParameterDeclaration(ParameterDeclaration parameterDeclaration)
            {
            }

            public void VisitParenthesizedExpression(ParenthesizedExpression parenthesizedExpression)
            {
            }

            public void VisitParenthesizedVariableDesignation(ParenthesizedVariableDesignation parenthesizedVariableDesignation)
            {
            }

            public void VisitPatternPlaceholder(AstNode placeholder, Pattern pattern)
            {
            }

            public void VisitPointerReferenceExpression(PointerReferenceExpression pointerReferenceExpression)
            {
            }

            public void VisitPreProcessorDirective(PreProcessorDirective preProcessorDirective)
            {
            }

            public void VisitPrimitiveExpression(PrimitiveExpression primitiveExpression)
            {
            }

            public void VisitPrimitiveType(PrimitiveType primitiveType)
            {
            }

            public void VisitPropertyDeclaration(PropertyDeclaration propertyDeclaration)
            {
            }

            public void VisitQueryContinuationClause(QueryContinuationClause queryContinuationClause)
            {
            }

            public void VisitQueryExpression(QueryExpression queryExpression)
            {
            }

            public void VisitQueryFromClause(QueryFromClause queryFromClause)
            {
            }

            public void VisitQueryGroupClause(QueryGroupClause queryGroupClause)
            {
            }

            public void VisitQueryJoinClause(QueryJoinClause queryJoinClause)
            {
            }

            public void VisitQueryLetClause(QueryLetClause queryLetClause)
            {
            }

            public void VisitQueryOrderClause(QueryOrderClause queryOrderClause)
            {
            }

            public void VisitQueryOrdering(QueryOrdering queryOrdering)
            {
            }

            public void VisitQuerySelectClause(QuerySelectClause querySelectClause)
            {
            }

            public void VisitQueryWhereClause(QueryWhereClause queryWhereClause)
            {
            }

            public void VisitRecursivePatternExpression(RecursivePatternExpression recursivePatternExpression)
            {
            }

            public void VisitReturnStatement(ReturnStatement returnStatement)
            {
            }

            public void VisitSimpleType(SimpleType simpleType)
            {
            }

            public void VisitSingleVariableDesignation(SingleVariableDesignation singleVariableDesignation)
            {
            }

            public void VisitSizeOfExpression(SizeOfExpression sizeOfExpression)
            {
            }

            public void VisitStackAllocExpression(StackAllocExpression stackAllocExpression)
            {
            }

            public void VisitSwitchExpression(SwitchExpression switchExpression)
            {
            }

            public void VisitSwitchExpressionSection(SwitchExpressionSection switchExpressionSection)
            {
            }

            public void VisitSwitchSection(SwitchSection switchSection)
            {
            }

            public void VisitSwitchStatement(SwitchStatement switchStatement)
            {
            }

            public void VisitSyntaxTree(ICSharpCode.Decompiler.CSharp.Syntax.SyntaxTree syntaxTree)
            {
                syntaxTree.AcceptVisitor(this);
            }

            public void VisitThisReferenceExpression(ThisReferenceExpression thisReferenceExpression)
            {
            }

            public void VisitThrowExpression(ThrowExpression throwExpression)
            {
            }

            public void VisitThrowStatement(ThrowStatement throwStatement)
            {
            }

            public void VisitTryCatchStatement(TryCatchStatement tryCatchStatement)
            {
            }

            public void VisitTupleExpression(TupleExpression tupleExpression)
            {
            }

            public void VisitTupleType(TupleAstType tupleType)
            {
            }

            public void VisitTupleTypeElement(TupleTypeElement tupleTypeElement)
            {
            }

            public void VisitTypeDeclaration(TypeDeclaration typeDeclaration)
            {
            }

            public void VisitTypeOfExpression(TypeOfExpression typeOfExpression)
            {
            }

            public void VisitTypeParameterDeclaration(TypeParameterDeclaration typeParameterDeclaration)
            {
            }

            public void VisitTypeReferenceExpression(TypeReferenceExpression typeReferenceExpression)
            {
            }

            public void VisitUnaryOperatorExpression(UnaryOperatorExpression unaryOperatorExpression)
            {
            }

            public void VisitUncheckedExpression(UncheckedExpression uncheckedExpression)
            {
            }

            public void VisitUncheckedStatement(UncheckedStatement uncheckedStatement)
            {
            }

            public void VisitUndocumentedExpression(UndocumentedExpression undocumentedExpression)
            {
            }

            public void VisitUnsafeStatement(UnsafeStatement unsafeStatement)
            {
            }

            public void VisitUsingAliasDeclaration(UsingAliasDeclaration usingAliasDeclaration)
            {
            }

            public void VisitUsingDeclaration(UsingDeclaration usingDeclaration)
            {
            }

            public void VisitUsingStatement(UsingStatement usingStatement)
            {
            }

            public void VisitVariableDeclarationStatement(VariableDeclarationStatement variableDeclarationStatement)
            {
            }

            public void VisitVariableInitializer(VariableInitializer variableInitializer)
            {
            }

            public void VisitWhileStatement(WhileStatement whileStatement)
            {
            }

            public void VisitWithInitializerExpression(WithInitializerExpression withInitializerExpression)
            {
            }

            public void VisitYieldBreakStatement(YieldBreakStatement yieldBreakStatement)
            {
            }

            public void VisitYieldReturnStatement(YieldReturnStatement yieldReturnStatement)
            {
            }
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

        public static Accessor WrapSetter(bool isStatic, string setterName, Expression staticTarget, Expression instanceTarget, string setMethodName)
        {
            var setterNameExp = new PrimitiveExpression(setterName);
            var clientWrappers = new TypeReferenceExpression(new SimpleType("ResoniteBridge.ResoniteBridgeClientWrappers"));
            var valueExp = new IdentifierExpression("value");

            InvocationExpression invocation = new InvocationExpression(
                new MemberReferenceExpression(clientWrappers, setMethodName),
                isStatic
                    ? new Expression[] { staticTarget, setterNameExp, valueExp }
                    : new Expression[] { instanceTarget, setterNameExp, valueExp }
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
                new MemberReferenceExpression(clientWrappers, getMethodName),
                isStatic
                    ? new Expression[] { staticTarget, getterNameExp }
                    : new Expression[] { instanceTarget, getterNameExp }
            );

            var castValueCall = new InvocationExpression(
                new MemberReferenceExpression(clientWrappers, "CastValue"),
                getterCall,
                new TypeOfExpression(getterType)
            );

            var castExpression = new CastExpression(
                getterType,
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

        public static string WrapAssembly(Assembly assembly)
        {
            string assemblyName = ResoniteBridgeServer.GetAssemblyName(assembly);
            var decompiler = new CSharpDecompiler(assembly.Location, new DecompilerSettings());
            Console.WriteLine("Decompiling");
            var decompTree = decompiler.DecompileWholeModuleAsSingleFile();
            Console.WriteLine("Decompiled");
            
            /*
            Dictionary<string, Tuple<ITypeDefinition, Type>> typeLookup = new Dictionary<string, Tuple<ITypeDefinition, Type>>();
            foreach (ITypeDefinition decompType in decompiler.TypeSystem.MainModule.Compilation.GetTopLevelTypeDefinitions())
            {
                Type assemblyType = assembly.GetType(decompType.ReflectionName);
                if (assemblyType != null)
                {
                    typeLookup[decompType.FullName] = new Tuple<ITypeDefinition, Type>(decompType, assemblyType);
                }
            }
            */

            TraverseSyntaxNodes(decompTree, (astNode) =>
            {
                if (astNode is ICSharpCode.Decompiler.CSharp.Syntax.TypeDeclaration typeDeclare)
                {
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
                            methodDeclare.Body.ReplaceWith(new EmptyStatement());
                        }
                        else if(childNode is PropertyDeclaration propertyDeclare)
                        {
                            string propertyName = propertyDeclare.NameToken.ToString();
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

                            propertyDeclare.Getter.ReplaceWith(getter);
                            propertyDeclare.Setter.ReplaceWith(setter);
                        }
                        else if(childNode is FieldDeclaration fieldDeclare)
                        {
                            string fieldName = fieldDeclare.NameToken.ToString();
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

                            var fieldProperty = new PropertyDeclaration
                            {
                                Name = fieldDeclare.Name,
                                ReturnType = fieldDeclare.ReturnType,
                                Modifiers = fieldDeclare.Modifiers,
                                Getter = getter,
                                Setter = setter
                            };
                            fieldDeclare.ReplaceWith(fieldProperty);
                        }
                    });
                }
            });

            var writer = new StringWriter();
            var visitor = new CSharpOutputVisitor(writer, FormattingOptionsFactory.CreateAllman());
            decompTree.AcceptVisitor(visitor);
            return writer.ToString();
            /*
            decompTree..Descendants.OfType < 
            HashSet<Tuple<string, string>> seenItems = new HashSet<Tuple<string, string>>();
            var allTypes = decompiler.TypeSystem.GetAllTypeDefinitions();
            var tokens = allTypes.Select(t => decompiler.TypeSystem.FindType(t.FullTypeName));
            var allSyntaxTrees = MetadataTokens.TypeDefinitionHandle()
            var result = new Dictionary<ITypeDefinition, SyntaxTree>();

            // Decompile in batch for better performance
            var tokens = allTypes.Select(t => t.MetadataToken).ToArray();
            var allSyntaxTrees = decompiler.DecompileTypes(tokens);

            // Match each syntax tree back to its type
            var typeDeclarations = allSyntaxTrees.Descendants.OfType<TypeDeclarationSyntax>();
            foreach (var typeDecl in typeDeclarations)
            {
                var typeDefinition = typeDecl.GetSymbol() as ITypeDefinition;
                if (typeDefinition != null)
                {
                    result[typeDefinition] = new SyntaxTree { Children = { typeDecl } };
                }
            }
            foreach (ITypeDefinition decompType in decompiler.TypeSystem.MainModule.Compilation.GetTopLevelTypeDefinitions())
            {
                var syntaxTree = decompiler.DecompileType(decompType.FullTypeName);
                var type = assembly.GetType(decompType.ReflectionName);
                if (type != null)
                {
                    WrapType(compileUnit, syntaxTree, decompType, type);
                }
                /*
                string fullTypeName = GetTypeName(typeInAssembly);
                // prevent type shadowing, just use whichever we see first
                if (!typesEncountered.Contains(fullTypeName))
                {
                    string typeNamespace = GetTypeNamespace(typeInAssembly);
                    string fullTypeNameWithoutNamespace = GetTypeName(typeInAssembly, includeNamespace: false);
                    // ignore weird generic template things
                    if (typeNamespace != null &&
                        !typeInAssembly.FullName.Contains("<>") &&
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
                        WrapType(compileUnit, typeInAssembly);
                        typesEncountered.Add(fullTypeName);
                    }
                }
                * /
            }
            */
        }


        // stuff I don't feel like directly supporting
        // prefix matches
        public static List<string> blackList = new List<string>()
        {
            "System.Collections.Generic.KeyCollection",
            "System.Collections.Generic.ValueCollection",
            "System.Collections.Generic.Enumerator",
            "POpusCodec",
            "QRCoder",
            "FrooxEngine.Sync<POpusCodec",
            "FrooxEngine.Sync<QRCoder",
            "ProtoFlux.Core.ValueOutput<TwitchLib",
            "System.Span", // give compilation issues
            "System.ReadOnlySpan", // give compilation issues
            "System.Threading.Tasks",
            "System.Collections.Generic.IEnumerable", // todo: this would be nice
            "System.Half", // not available in netstandard 2.1
            "TwitchLib.",
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
            //"FrooxEngine",
        };

        public static CompilationUnitSyntax WrapAssemblies(Dictionary<string, Assembly> assemblies)
        {
            HashSet<string> typesEncountered = new HashSet<string>();
            StringBuilder outCode = new StringBuilder();

            // might be modified so have to make a copy
            foreach (KeyValuePair<string, Assembly> pair in new Dictionary<string, Assembly>(assemblies))
            {
                Assembly assembly = pair.Value;
                if (whitelist.Contains(ResoniteBridgeServer.GetAssemblyName(pair.Value)))
                {
                    Console.WriteLine("Wrapping assembly " + pair.Key);
                    string outputCode = WrapAssembly(assembly);
                    outCode.Append(outputCode);
                    Console.WriteLine("Done wrapping assembly " + pair.Key);
                }
            }
            return outCode;
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

                // Create CodeDom provider for C#
                using (var provider = CodeDomProvider.CreateProvider("CSharp"))
                {
                    // Create compilation unit
                    var compileUnit = new CodeCompileUnit();

                    DefineNamespaceAliases(compileUnit);
                 
                    WrapAssemblies(compileUnit, assemblies, rootNamespaceName);

                    // write to file
                    Console.WriteLine("Writing to file");
                    using (var writer = new StreamWriter(outTxt))
                    {
                        provider.GenerateCodeFromCompileUnit(compileUnit, writer, 
                            new CodeGeneratorOptions { BracingStyle = "C" });
                    }
                    // hack to get :struct and :class constraints
                    File.WriteAllText(outTxt, File.ReadAllText(outTxt).Replace("CLASSCONSTRAINT", "class").Replace("STRUCTCONSTRAINT", "struct")
                        .Replace("ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.", "FrooxEngine."));
                    Console.WriteLine("Done writing to file");
                }

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
                if (!result.Success)
                {
                    foreach (Diagnostic diagnostic in result.Diagnostics)
                    {
                        if (diagnostic.Severity == DiagnosticSeverity.Error)
                        {
                            Console.WriteLine(diagnostic.ToString());
                        }
                    }
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
