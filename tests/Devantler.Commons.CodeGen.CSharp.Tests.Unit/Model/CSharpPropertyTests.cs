using Devantler.Commons.CodeGen.Core.Model;
using Devantler.Commons.CodeGen.CSharp.Model;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.Model;

public class CSharpPropertyTests
{
    [Fact]
    public void SetVisibility_GivenVisibility_SetsVisibility()
    {
        // Arrange
        var sut = new CSharpProperty("type", "name");

        // Act
        _ = sut.SetVisibility(Visibility.Private);

        // Assert
        _ = sut.Visibility.Should().Be(Visibility.Private);
    }
}
