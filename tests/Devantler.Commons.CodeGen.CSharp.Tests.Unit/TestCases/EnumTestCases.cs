using Devantler.Commons.CodeGen.Core.Model;
using Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.TestCases;

public static class EnumTestCases
{
    public static IEnumerable<object[]> ValidCases =>
        new List<object[]>
        {
            new object[]
            {
                "EmptyEnum",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    enumOptionsAction: options => options.Count = 1
                )
            },
            new object[]
            {
                "EnumWithUsing",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    enumOptionsAction: options => {
                        options.Count = 1;
                        options.IncludeUsing = true;
                    }
                )
            },
            new object[]
            {
                "EnumWithNonDefaultVisibility",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    enumOptionsAction: options => {
                        options.Count = 1;
                        options.Visibility = Visibility.Private;
                    }
                )
            },
            new object[]
            {
                "EnumWithNamespace",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    enumOptionsAction: options => {
                        options.Count = 1;
                        options.IncludeNamespace = true;
                    }
                )
            },
            new object[]
            {
                "EnumWihtDocumentation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    enumOptionsAction: options => {
                        options.Count = 1;
                        options.IncludeDocumentation = true;
                    }
                )
            },
            new object[]
            {
                "EnumWithSymbol",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    enumOptionsAction: options => {
                        options.Count = 1;
                        options.EnumSymbolOptions.Count = 1;
                    }
                )
            },
            new object[]
            {
                "EnumWithSymbolAndDocumentation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    enumOptionsAction: options => {
                        options.Count = 1;
                        options.EnumSymbolOptions.Count = 1;
                        options.EnumSymbolOptions.IncludeDocumentation = true;
                    }
                )
            },
            new object[]
            {
                "EnumWithSymbolAndValue",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(
                    enumOptionsAction: options => {
                        options.Count = 1;
                        options.EnumSymbolOptions.Count = 1;
                        options.EnumSymbolOptions.IncludeValue = true;
                    }
                )
            }
        };
}
