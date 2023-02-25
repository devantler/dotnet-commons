using Devantler.Commons.CodeGen.Core.Model;
using Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.TestCases;

public static class InterfaceTestCases
{
    public static IEnumerable<object[]> ValidCases =>
        new List<object[]>
        {
             new object[]
            {
                "EmptyInterface",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => interfaceOptions.Count = 1
                )
            },
            new object[]
            {
                "InterfaceWithUsing",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.IncludeUsing = true;
                    }
                )
            },
            new object[]{
                "InterfaceWithNonDefaultVisibility",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.Visibility = Visibility.Private;
                    }
                )
            },
            new object[]{
                "PartialInterface",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.IsPartial = true;
                    }
                )
            },
            new object[]
            {
                "InterfaceWithDocumentation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.IncludeDocumentation = true;
                    }
                )
            },
            new object[]
            {
                "InterfaceWithNamespace",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.IncludeNamespace = true;
                    }
                )
            },
            new object[]
            {
                "InterfaceWithProperty",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.PropertyOptions.Count = 1;
                    }
                )
            },
            new object[]
            {
                "InterfaceWithPropertyAndValue",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.PropertyOptions.Count = 1;
                        interfaceOptions.PropertyOptions.IncludeValue = true;
                    }
                )
            },
            new object[]
            {
                "InterfaceWithPropertyAndExpressionBodiedMembers",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.PropertyOptions.Count = 1;
                        interfaceOptions.PropertyOptions.IncludeValue = true;
                        interfaceOptions.PropertyOptions.IsExpressionBodiedMembers = true;
                    }
                )
            },
            new object[]
            {
                "InterfaceWithNullableProperty",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.PropertyOptions.Count = 1;
                        interfaceOptions.PropertyOptions.Nullables = true;
                    }
                )
            },
            new object[]
            {
                "InterfaceWithPropertyAndNonDefaultVisibility",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.PropertyOptions.Count = 1;
                        interfaceOptions.PropertyOptions.Visibility = Visibility.Private;
                    }
                )
            },
            new object[]
            {
                "InterfaceWithPropertyAndDocumentation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.PropertyOptions.Count = 1;
                        interfaceOptions.PropertyOptions.IncludeDocumentation = true;
                    }
                )
            },
            new object[]
            {
                "InterfaceWithImplementation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.ImplementationOptions.Count = 1;
                    }
                )
            },
            new object[]
            {
                "InterfaceWithImplementationAndProperties",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.ImplementationOptions.Count = 1;
                        interfaceOptions.ImplementationOptions.PropertyOptions.Count = 1;
                    }
                )
            },
            new object[]
            {
                "InterfaceWithMethod",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.MethodOptions.Count = 1;
                    }
                )
            },
            new object[]
            {
                "InterfaceWithMethodAndNonDefaultVisibility",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.MethodOptions.Count = 1;
                        interfaceOptions.MethodOptions.Visibility = Visibility.Private;
                    }
                )
            },
            new object[]
            {
                "InterfaceWithMethodAndAttribute",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.MethodOptions.Count = 1;
                        interfaceOptions.MethodOptions.IncludeAttribute = true;
                    }
                )
            },
            new object[]
            {
                "InterfaceWithMethodAndStatement",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.MethodOptions.Count = 1;
                        interfaceOptions.MethodOptions.IncludeStatement = true;
                    }
                )
            },
            new object[]
            {
                "InterfaceWithExpressionBodiedMethod",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptionsAction => {
                        interfaceOptionsAction.Count = 1;
                        interfaceOptionsAction.MethodOptions.Count = 1;
                        interfaceOptionsAction.MethodOptions.IncludeStatement = true;
                        interfaceOptionsAction.MethodOptions.IsExpressionBodied = true;
                    }
                )
            },
            new object[]
            {
                "InterfaceWithMethodAndDocumentation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.MethodOptions.Count = 1;
                        interfaceOptions.MethodOptions.IncludeDocumentation = true;
                    }
                )
            },
            new object[]
            {
                "InterfaceWithMethodAndNonDefaultReturnType",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.MethodOptions.Count = 1;
                        interfaceOptions.MethodOptions.ReturnType = "object";
                    }
                )
            },
            new object[]
            {
                "InterfaceWithMethodAndParameter",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.MethodOptions.Count = 1;
                        interfaceOptions.MethodOptions.ParameterOptions.Count = 1;
                    }
                )
            },
            new object[]
            {
                "InterfaceWithMethodAndNullableParameter",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.MethodOptions.Count = 1;
                        interfaceOptions.MethodOptions.ParameterOptions.Count = 1;
                        interfaceOptions.MethodOptions.ParameterOptions.Nullables = true;
                    }
                )
            },
                        new object[]
            {
                "InterfaceWithMethodAndParameterWithDefaultValue",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: interfaceOptions => {
                        interfaceOptions.Count = 1;
                        interfaceOptions.MethodOptions.Count = 1;
                        interfaceOptions.MethodOptions.ParameterOptions.Count = 1;
                        interfaceOptions.MethodOptions.ParameterOptions.HasDefaultValue = true;
                    }
                )
            }
        };

    public static IEnumerable<object[]> InvalidCases =>
        new List<object[]>();
}
