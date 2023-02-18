using Devantler.Commons.CodeGen.CSharp.Model;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit;

[UsesVerify]
public class CSharpCodeGeneratorTests
{
    [Theory]
    [MemberData(nameof(TestCases.ValidCases), MemberType = typeof(TestCases))]
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
