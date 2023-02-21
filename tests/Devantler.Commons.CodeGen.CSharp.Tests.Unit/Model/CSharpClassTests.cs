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

    [Fact]
    public void AddProperty_GivenProperty_AddsProperty()
    {
        // Arrange
        var sut = new CSharpClass("TestClass");

        // Act
        _ = sut.AddProperty(new CSharpProperty("string", "TestProperty"));

        // Assert
        _ = sut.Properties.Should().HaveCount(1);
        _ = sut.Properties[0].Name.Should().Be("TestProperty");
    }
}
