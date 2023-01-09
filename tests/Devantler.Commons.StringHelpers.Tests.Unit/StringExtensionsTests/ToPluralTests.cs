namespace Devantler.Commons.StringHelpers.Tests.Unit.StringExtensionsTests;

public class ToPluralTests
{
    [Fact]
    public void ToPlural_WithSingleWord_ReturnsPlural()
    {
        //Arrange
        const string text = "test";
        const string expected = "tests";

        //Act
        string actual = text.ToPlural();

        //Assert
        _ = expected.Should().Be(actual);
    }

    [Fact]
    public void ToPlural_WithSingleWordEndingWithS_ReturnsPlural()
    {
        //Arrange
        const string TEXT = "glass";
        const string expected = "glasses";

        //Act
        string actual = TEXT.ToPlural();

        //Assert
        _ = actual.Should().Be(expected);
    }
}
