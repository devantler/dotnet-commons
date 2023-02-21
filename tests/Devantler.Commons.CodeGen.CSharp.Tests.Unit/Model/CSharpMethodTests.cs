using Devantler.Commons.CodeGen.Core.Model;
using Devantler.Commons.CodeGen.CSharp.Model;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.Model;

public class CSharpMethodTests
{
    [Fact]
    public void SetVisibility_GivenVisibility_SetsVisibility()
    {
        // Arrange
        var sut = new CSharpMethod("name");

        // Act
        _ = sut.SetVisibility(Visibility.Private);

        // Assert
        _ = sut.Visibility.Should().Be(Visibility.Private);
    }

    [Fact]
    public void SetReturnType_GivenReturnType_SetsReturnType()
    {
        // Arrange
        var sut = new CSharpMethod("name");

        // Act
        _ = sut.SetReturnType("string");

        // Assert
        _ = sut.ReturnType.Should().Be("string");
    }

    [Fact]
    public void AddParameter_GivenParameter_AddsParameter()
    {
        // Arrange
        var sut = new CSharpMethod("name");
        var parameter = new CSharpParameter("string", "name");

        // Act
        _ = sut.AddParameter(parameter);

        // Assert
        _ = sut.Parameters.Should().Contain(parameter);
    }

    [Fact]
    public void AddStatement_GivenStatement_AddsStatement()
    {
        // Arrange
        var sut = new CSharpMethod("name");

        // Act
        _ = sut.AddStatement("statement");

        // Assert
        _ = sut.Statements.Should().Contain("statement");
    }

    [Fact]
    public void SetIsStatic_GivenBoolean_SetsIsStatic()
    {
        // Arrange
        var sut = new CSharpMethod("name");

        // Act
        _ = sut.SetIsStatic(true);

        // Assert
        _ = sut.IsStatic.Should().BeTrue();
    }

    [Fact]
    public void SetIsPartial_GivenBoolean_SetsIsPartial()
    {
        // Arrange
        var sut = new CSharpMethod("name");

        // Act
        _ = sut.SetIsPartial(true);

        // Assert
        _ = sut.IsPartial.Should().BeTrue();
    }
}
