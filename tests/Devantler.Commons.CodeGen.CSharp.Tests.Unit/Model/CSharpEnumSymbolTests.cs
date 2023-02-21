using Devantler.Commons.CodeGen.CSharp.Model;

namespace Devantler.Commons.CodeGen.CSharp.Tests.Unit.Model;

public class CSharpEnumSymbolTests
{
    [Fact]
    public void SetValue_GivenEnumValue_SetsValue()
    {
        // Arrange
        var sut = new CSharpEnumSymbol("TestEnum");

        // Act
        _ = sut.SetValue(TestValue.TestMember);

        // Assert
        _ = sut.Value.Should().Be("TestMember");
    }

    public enum TestValue
    {
        TestMember = 0
    }
}
