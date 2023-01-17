using Devantler.Commons.CodeGen.CSharp.Tests.Unit.StubFactories;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit;

public static class TestCases
{
    public static IEnumerable<object[]> ValidCases =>
        new List<object[]>
        {
            new object[]
            {
                nameof(CSharpCodeCollectionFactory.CreateEmptyCSharpCodeCollectionStub),
                CSharpCodeCollectionFactory.CreateEmptyCSharpCodeCollectionStub()
            },
            new object[]
            {
                nameof(CSharpCodeCollectionFactory.CreateCSharpCodeCollectionStubWithOneEmptyClass),
                CSharpCodeCollectionFactory.CreateCSharpCodeCollectionStubWithOneEmptyClass()
            },
            new object[]
            {
                nameof(CSharpCodeCollectionFactory
                    .CreateCSharpCodeCollectionStubWithOnePopulatedClassWithSingleMembers),
                CSharpCodeCollectionFactory.CreateCSharpCodeCollectionStubWithOnePopulatedClassWithSingleMembers()
            },
            new object[]
            {
                nameof(CSharpCodeCollectionFactory
                    .CreateCSharpCodeCollectionStubWithOnePopulatedClassWithMultipleMembers),
                CSharpCodeCollectionFactory.CreateCSharpCodeCollectionStubWithOnePopulatedClassWithMultipleMembers()
            },
            new object[]
            {
                nameof(CSharpCodeCollectionFactory.CreateCSharpCodeCollectionStubWithOneEmptyInterface),
                CSharpCodeCollectionFactory.CreateCSharpCodeCollectionStubWithOneEmptyInterface()
            },
            new object[]
            {
                nameof(CSharpCodeCollectionFactory
                    .CreateCSharpCodeCollectionStubWithOnePopulatedInterfaceWithSingleMembers),
                CSharpCodeCollectionFactory.CreateCSharpCodeCollectionStubWithOnePopulatedInterfaceWithSingleMembers()
            },
            new object[]
            {
                nameof(CSharpCodeCollectionFactory
                    .CreateCSharpCodeCollectionStubWithOnePopulatedInterfaceWithMultipleMembers),
                CSharpCodeCollectionFactory.CreateCSharpCodeCollectionStubWithOnePopulatedInterfaceWithMultipleMembers()
            },
            new object[]
            {
                nameof(CSharpCodeCollectionFactory.CreateCSharpCodeCollectionStubWithOneEmptyEnum),
                CSharpCodeCollectionFactory.CreateCSharpCodeCollectionStubWithOneEmptyEnum()
            },
            new object[]
            {
                nameof(CSharpCodeCollectionFactory.CreateCSharpCodeCollectionStubWithOnePopulatedEnumWithSingleValue),
                CSharpCodeCollectionFactory.CreateCSharpCodeCollectionStubWithOnePopulatedEnumWithSingleValue()
            },
            new object[]
            {
                nameof(CSharpCodeCollectionFactory
                    .CreateCSharpCodeCollectionStubWithOnePopulatedEnumWithMultipleValues),
                CSharpCodeCollectionFactory.CreateCSharpCodeCollectionStubWithOnePopulatedEnumWithMultipleValues()
            }
        };

    public static IEnumerable<object[]> InvalidCases =>
        new List<object[]>();
}
