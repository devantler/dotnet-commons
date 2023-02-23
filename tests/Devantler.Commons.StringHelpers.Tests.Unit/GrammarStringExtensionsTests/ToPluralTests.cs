namespace Devantler.Commons.StringHelpers.Tests.Unit.GrammarStringExtensionsTests;

public class ToPluralTests
{
    [Theory]
    [InlineData("address")]
    [InlineData("addresses")]
    [InlineData("map")]
    [InlineData("maps")]
    public void ToPlural_GivenSingleWord_ReturnsPlural(string word)
    {
        //Act
        string actual = word.ToPlural();

        //Assert
        _ = word.EndsWith("es", StringComparison.OrdinalIgnoreCase)
            ? actual.Should().Be(word)
            : word.EndsWith("s", StringComparison.OrdinalIgnoreCase)
                ? actual.Should().EndWith("es")
                : actual.Should().EndWith("s");
    }
}
