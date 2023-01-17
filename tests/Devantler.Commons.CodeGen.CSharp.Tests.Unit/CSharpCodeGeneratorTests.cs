using Devantler.Commons.CodeGen.CSharp.Models;

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

    // [Theory]
    // [MemberData(nameof(TestCases.InvalidCases), MemberType = typeof(TestCases))]
    // public void Generate_GivenInvalidCSharpCodeCollection_Throws(CSharpCompilation compilation)
    // {
    //     // Arrange
    //     var codeGenerator = new CSharpCodeGenerator();

    //     // Act
    //     Action action = () => codeGenerator.Generate(compilation);

    //     // Assert
    //     _ = action.Should().Throw<InvalidOperationException>();
    // }
}
