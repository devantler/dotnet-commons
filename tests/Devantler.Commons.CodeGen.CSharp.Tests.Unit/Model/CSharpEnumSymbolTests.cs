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
        Assert.Equal("TestMember", sut.Value);
    }

    public enum TestValue
    {
        TestMember = 0
    }
}
