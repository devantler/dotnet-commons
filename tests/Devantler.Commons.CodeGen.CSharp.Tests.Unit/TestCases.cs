using Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit;

public static class TestCases
{
    public static IEnumerable<object[]> ValidCases =>
        new List<object[]>
        {
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_Empty",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub()
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneEmptyClass",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: options => options.Count = 1
                )
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneEmptyInterface",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: options => options.Count = 1
                )
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneEmptyEnum",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    enumOptionsAction: options => options.Count = 1
                )
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneClassWithOneMember",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: options =>
                    {
                        options.Count = 1;
                        options.FieldsCount = 1;
                        options.ConstructorsCount = 1;
                        options.PropertiesCount = 1;
                        options.MethodsCount = 1;
                        options.Nullables = false;
                    }
                )
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneClassWithOneNullMember",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: options =>
                    {
                        options.Count = 1;
                        options.FieldsCount = 1;
                        options.ConstructorsCount = 1;
                        options.PropertiesCount = 1;
                        options.MethodsCount = 1;
                        options.Nullables = true;
                    }
                )
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneClassWithOneImplementation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: options =>
                    {
                        options.Count = 1;
                        options.IncludeImplementation = true;
                    }
                )
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneInterfaceWithOneMember",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: options =>
                    {
                        options.Count = 1;
                        options.PropertiesCount = 1;
                        options.MethodsCount = 1;
                        options.Nullables = false;
                    }
                )
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneInterfaceWithOneNullMember",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: options =>
                    {
                        options.Count = 1;
                        options.PropertiesCount = 1;
                        options.MethodsCount = 1;
                        options.Nullables = true;
                    }
                )
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneEnumWithOneSymbol",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    enumOptionsAction: options =>
                    {
                        options.Count = 1;
                        options.SymbolsCount = 1;
                    }
                )
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneClassWithOneMemberAndDocumentation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    classOptionsAction: options =>
                    {
                        options.Count = 1;
                        options.FieldsCount = 1;
                        options.ConstructorsCount = 1;
                        options.PropertiesCount = 1;
                        options.MethodsCount = 1;
                        options.IncludeDocumentation = true;
                    }
                )
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneInterfaceWithOneMemberAndDocumentation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: options =>
                    {
                        options.Count = 1;
                        options.PropertiesCount = 1;
                        options.MethodsCount = 1;
                        options.IncludeDocumentation = true;
                        options.IncludeNamespace = false;
                    }
                )
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneEnumWithOneSymbolAndDocumentation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    enumOptionsAction: options =>
                    {
                        options.Count = 1;
                        options.SymbolsCount = 1;
                        options.IncludeDocumentation = true;
                    }
                )
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_MultipleTypesWithMultipleMembersAndDocumentation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    interfaceOptionsAction: options =>
                    {
                        options.Count = 2;
                        options.PropertiesCount = 2;
                        options.MethodsCount = 2;
                        options.IncludeDocumentation = true;
                    },
                    classOptionsAction: options =>
                    {
                        options.Count = 2;
                        options.FieldsCount = 2;
                        options.ConstructorsCount = 2;
                        options.PropertiesCount = 2;
                        options.MethodsCount = 2;
                        options.IncludeDocumentation = true;
                    },
                    enumOptionsAction: options =>
                    {
                        options.Count = 2;
                        options.SymbolsCount = 2;
                        options.IncludeDocumentation = true;
                    }
                )
            }
        };

    public static IEnumerable<object[]> InvalidCases =>
        new List<object[]>();
}
