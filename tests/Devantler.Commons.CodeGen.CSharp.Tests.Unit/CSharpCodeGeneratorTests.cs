using Devantler.Commons.CodeGen.CSharp.Model;
using Devantler.Commons.CodeGen.CSharp.Tests.Unit.TestCases;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit;

[UsesVerify]
public class CSharpCodeGeneratorTests
{
    [Theory]
    [MemberData(nameof(ClassTestCases.ValidCases), MemberType = typeof(ClassTestCases))]
    [MemberData(nameof(InterfaceTestCases.ValidCases), MemberType = typeof(InterfaceTestCases))]
    [MemberData(nameof(EnumTestCases.ValidCases), MemberType = typeof(EnumTestCases))]
    public Task Generate_GivenValidCSharpCodeCollection_GenerateCodeCollection(string testName, CSharpCompilation compilation)
    {
        // Arrange
        var codeGenerator = new CSharpCodeGenerator();

        // Act
        var compiledCode = codeGenerator.Generate(compilation);
        string result = string.Join(Environment.NewLine, compiledCode.Select(x => x.Value + Environment.NewLine));

        // Assert
        return Verify(result).UseMethodName(testName);
    }
}
