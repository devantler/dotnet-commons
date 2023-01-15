using Devantler.Commons.CodeGen.CSharp.Models;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit;

[UsesVerify]
public class CSharpCodeGeneratorTests
{
    [Theory]
    [MemberData(nameof(TestCases.ValidCases), MemberType = typeof(TestCases))]
    public Task Generate_GivenValidCSharpCodeCollection_GenerateCodeCollection(string testName, CSharpCodeCollection codeCollection)
    {
        // Arrange
        var codeGenerator = new CSharpCodeGenerator();

        // Act
        Dictionary<string, string> compiledCode = codeGenerator.Generate(codeCollection);

        // Assert
        string result = string.Join(Environment.NewLine, compiledCode.Select(x => x.Value + Environment.NewLine));

        return Verify(result).UseMethodName(testName);
    }

    [Theory]
    [MemberData(nameof(TestCases.InvalidCases), MemberType = typeof(TestCases))]
    public void Generate_GivenInvalidCSharpCodeCollection_Throws(CSharpCodeCollection codeCollection)
    {
        // Arrange
        var codeGenerator = new CSharpCodeGenerator();

        // Act
        Action action = () => codeGenerator.Generate(codeCollection);

        // Assert
        _ = action.Should().Throw<InvalidOperationException>();
    }
}
