namespace Devantler.Commons.StringHelpers.Tests.Unit.StringExtensionsTests;

public class ToKebabCaseTests
{
    [Theory, AutoData]
    public void ReturnsKebabCase(string text)
    {
        //Act
        string actual = text.ToKebabCase();

        //Assert
        _ = RegexLibrary.KebabCaseRegex.IsMatch(actual).Should().BeTrue();
    }
}
