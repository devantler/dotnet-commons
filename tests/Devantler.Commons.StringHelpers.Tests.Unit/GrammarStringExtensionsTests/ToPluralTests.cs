namespace Devantler.Commons.StringHelpers.Tests.Unit.GrammarStringExtensionsTests;

public class ToPluralTests
{
    [Theory]
    [InlineData("addresses")]
    [InlineData("map")]
    [InlineData("maps")]
    [InlineData("child")]
    [InlineData("index")]
    [InlineData("Bay")]
    [InlineData(null, null)]
    [InlineData("", "")]
    [InlineData("word", "words")]
    [InlineData("buzz", "buzzes")]
    [InlineData("fox", "foxes")]
    [InlineData("baby", "babies")]
    [InlineData("day", "days")]
    [InlineData("toy", "toys")]
    [InlineData("potato", "potatoes")]
    [InlineData("hero", "heroes")]
    [InlineData("woman", "women")]
    [InlineData("man", "men")]
    [InlineData("child", "children")]
    [InlineData("deer", "deer")]
    [InlineData("species", "species")]
    [InlineData("address", "addresses")]
    [InlineData("addresses", "addresses")]
    public void ToPlural_GivenSingleWord_ReturnsPlural(string input, string expected)
    {
        Assert.Equal(expectedOutput, input.ToPlural());
    }
}
