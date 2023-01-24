namespace Devantler.Commons.StringHelpers.Tests.Unit.GrammarStringExtensionsTests;

public class ToPluralTests
{
    [Theory]
    [AutoData]
    public void ToPlural_GivenSingleWord_ReturnsPlural(string word)
    {
        //Act
        string actual = word.ToPlural();

        //Assert
        _ = word.EndsWith("s", StringComparison.OrdinalIgnoreCase)
            ? actual.Should().EndWith("es")
            : actual.Should().EndWith("s");
    }
}
