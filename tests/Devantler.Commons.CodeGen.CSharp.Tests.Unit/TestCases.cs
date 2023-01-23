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
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(0, 0, 0, 0, false, false)
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneEmptyClass",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(0, 1, 0, 0, false, false)
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneEmptyInterface",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(1, 0, 0, 0, false, false)
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneEmptyEnum",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(0, 0, 1, 0, false, false)
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneClassWithOneMember",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(0, 1, 0, 1, false, false)
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneInterfaceWithOneMember",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(1, 0, 0, 1, false, false)
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneEnumWithOneSymbol",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(0, 0, 1, 1, false, false)
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneClassWithOneMemberAndDocumentation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(0, 1, 0, 1, true, true)
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneInterfaceWithOneMemberAndDocumentation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(1, 0, 0, 1, true, true)
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_OneEnumWithOneSymbolAndDocumentation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(0, 0, 1, 1, true, true)
            },
            new object[]
            {
                $"{nameof(CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub)}_MultipleTypesWithMultipleMembersAndDocumentation",
                CSharpCodeCompilationFactory.CreateCSharpCodeCompilationStub(1, 1, 1, 2, true, true)
            }
        };

    public static IEnumerable<object[]> InvalidCases =>
        new List<object[]>();
}
