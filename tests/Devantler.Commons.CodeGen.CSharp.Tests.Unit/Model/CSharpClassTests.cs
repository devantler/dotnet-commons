using Devantler.Commons.CodeGen.CSharp.Model;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.Model;

public class CSharpClassTests
{
    [Fact]
    public void SetBaseClass_GivenBaseClass_SetsBaseClass()
    {
        // Arrange
        var sut = new CSharpClass("TestClass");

        // Act
        _ = sut.SetBaseClass(new CSharpClass("BaseClass"));

        // Assert
        _ = sut.BaseClass.Should().NotBeNull();
        _ = sut.BaseClass!.Name.Should().Be("BaseClass");
    }

    [Fact]
    public void SetNamespace_GivenString_SetsNamespace()
    {
        // Arrange
        var sut = new CSharpClass("TestClass");

        // Act
        _ = sut.SetNamespace("TestNamespace");

        // Assert
        _ = sut.Namespace.Should().Be("TestNamespace");
    }
}
