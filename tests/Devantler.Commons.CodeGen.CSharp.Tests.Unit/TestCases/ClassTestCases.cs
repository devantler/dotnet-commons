using Devantler.Commons.CodeGen.Core.Model;
using Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.TestCases;

public static class ClassTestCases
{
    public static IEnumerable<object[]> ValidCases =>
        new List<object[]>
        {
            new object[]
            {
                "EmptyClass",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => classOptions.Count = 1
                )
            },
            new object[]
            {
                "ClassWithUsing",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.IncludeUsing = true;
                    }
                )
            },
            new object[]
            {
                "ClassWithBaseClass",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.IncludeBaseClass = true;
                    }
                )
            },
            new object[]{
                "ClassWithNonDefaultVisibility",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.Visibility = Visibility.Private;
                    }
                )
            },
            new object[]{
                "PartialClass",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.IsPartial = true;
                    }
                )
            },
            new object[]
            {
                "PartialClassWithPartialMethod",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.IsPartial = true;
                        classOptions.MethodOptions.Count = 1;
                        classOptions.MethodOptions.IsPartial = true;
                    }
                )
            },
            new object[]{
                "AbstractClass",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.IsAbstract = true;
                    }
                )
            },
            new object[]{
                "StaticClass",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.IsStatic = true;
                    }
                )
            },
            new object[]
            {
                "ClassWithDocumentation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.IncludeDocumentation = true;
                    }
                )
            },
            new object[]
            {
                "ClassWithNamespace",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.IncludeNamespace = true;
                    }
                )
            },
            new object[]
            {
                "ClassWithField",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.FieldOptions.Count = 1;
                    }
                )
            },
            new object[]
            {
                "ClassWithFieldAndNonDefaultVisibility",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.FieldOptions.Count = 1;
                        classOptions.FieldOptions.Visibility = Visibility.Private;
                    }
                )
            },
            new object[]
            {
                "ClassWithNullableField",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.FieldOptions.Count = 1;
                        classOptions.FieldOptions.Nullables = true;
                    }
                )
            },
            new object[]
            {
                "ClassWithFieldAndValue",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.FieldOptions.Count = 1;
                        classOptions.FieldOptions.IncludeValue = true;
                    }
                )
            },
            new object[]
            {
                "ClassWithFieldAndDocumentation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.FieldOptions.Count = 1;
                        classOptions.FieldOptions.IncludeDocumentation = true;
                    }
                )
            },
            new object[]
            {
                "ClassWithProperty",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.PropertyOptions.Count = 1;
                    }
                )
            },
            new object[]
            {
                "ClassWithNullableProperty",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.PropertyOptions.Count = 1;
                        classOptions.PropertyOptions.Nullables = true;
                    }
                )
            },
            new object[]
            {
                "ClassWithPropertyAndNonDefaultVisibility",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.PropertyOptions.Count = 1;
                        classOptions.PropertyOptions.Visibility = Visibility.Private;
                    }
                )
            },
            new object[]
            {
                "ClassWithPropertyAndDocumentation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.PropertyOptions.Count = 1;
                        classOptions.PropertyOptions.IncludeDocumentation = true;
                    }
                )
            },
            new object[]
            {
                "ClassWithPropertyAndValue",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.PropertyOptions.Count = 1;
                        classOptions.PropertyOptions.IncludeValue = true;
                    }
                )
            },
            new object[]
            {
                "ClassWithPropertyAndExpressionBodiedMember",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.PropertyOptions.Count = 1;
                        classOptions.PropertyOptions.IncludeValue = true;
                        classOptions.PropertyOptions.IsExpressionBodiedMembers = true;
                    }
                )
            },
            new object[]
            {
                "ClassWithImplementation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.ImplementationOptions.Count = 1;
                    }
                )
            },
            new object[]
            {
                "ClassWithImplementationAndProperties",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.ImplementationOptions.Count = 1;
                        classOptions.ImplementationOptions.PropertyOptions.Count = 1;
                    }
                )
            },
            new object[]
            {
                "ClassWithConstructor",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.ConstructorOptions.Count = 1;
                    }
                )
            },
            new object[]
            {
                "ClassWithConstructorAndStatement",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.ConstructorOptions.Count = 1;
                        classOptions.ConstructorOptions.IncludeStatement = true;
                    }
                )
            },
            new object[]
            {
                "ClassWithConstructorAndDocumentation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.ConstructorOptions.Count = 1;
                        classOptions.ConstructorOptions.IncludeDocumentation = true;
                    }
                )
            },
            new object[]
            {
                "ClassWithConstructorAndParameter",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.ConstructorOptions.Count = 1;
                        classOptions.ConstructorOptions.ParameterOptions.Count = 1;
                    }
                )
            },
            new object[]
            {
                "ClassWithConstructorAndBaseParameter",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.IncludeBaseClass = true;
                        classOptions.ConstructorOptions.Count = 1;
                        classOptions.ConstructorOptions.ParameterOptions.Count = 1;
                    }
                )
            },
            new object[]
            {
                "ClassWithMethod",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.MethodOptions.Count = 1;
                    }
                )
            },
            new object[]
            {
                "ClassWithStaticMethod",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.MethodOptions.Count = 1;
                        classOptions.MethodOptions.IsStatic = true;
                    }
                )
            },
            new object[]
            {
                "ClassWithExtensionMethod",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.MethodOptions.ParameterOptions.Count = 2;
                        classOptions.MethodOptions.Count = 1;
                        classOptions.MethodOptions.IsExtensionMethod = true;
                    }
                )
            },
            new object[]
            {
                "ClassWithMethodAndNonDefaultVisibility",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.MethodOptions.Count = 1;
                        classOptions.MethodOptions.Visibility = Visibility.Private;
                    }
                )
            },
            new object[]
            {
                "ClassWithMethodAndStatement",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.MethodOptions.Count = 1;
                        classOptions.MethodOptions.IncludeStatement = true;
                    }
                )
            },
            new object[]
            {
                "ClassWithMethodAndDocumentation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.MethodOptions.Count = 1;
                        classOptions.MethodOptions.IncludeDocumentation = true;
                    }
                )
            },
            new object[]
            {
                "ClassWithMethodAndNonDefaultReturnType",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.MethodOptions.Count = 1;
                        classOptions.MethodOptions.ReturnType = "object";
                    }
                )
            },
            new object[]
            {
                "ClassWithMethodAndOverriddenMethod",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.IncludeBaseClass = true;
                        classOptions.MethodOptions.Count = 1;
                    }
                )
            },
            new object[]
            {
                "ClassWithMethodAndParameter",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: classOptions => {
                        classOptions.Count = 1;
                        classOptions.MethodOptions.Count = 1;
                        classOptions.MethodOptions.ParameterOptions.Count = 1;
                    }
                )
            }
        };

    public static IEnumerable<object[]> InvalidCases =>
        new List<object[]>();
}
