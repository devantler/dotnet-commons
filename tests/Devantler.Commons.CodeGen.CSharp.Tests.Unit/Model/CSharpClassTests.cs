using Devantler.Commons.CodeGen.CSharp.Model;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.Model;

public class CSharpClassTests
{
    public void SetBaseClass_GivenBaseClass_SetsBaseClass()
    {
        // Arrange
        var sut = new CSharpClass("TestClass");

        // Act
        _ = sut.SetBaseClass(new CSharpClass("BaseClass"));

        // Assert
        _ = sut.BaseClass.Should().Be("BaseClass");
    }
}
