namespace Devantler.Commons.StringHelpers.Tests.Unit.StringExtensionsTests;

public class ToCamelCaseTests
{
    [Theory, AutoData]
    public void ReturnsCamelCase(string text)
    {
        //Act
        string actual = text.ToCamelCase();

        //Assert
        _ = RegexLibrary.CamelCaseWithDigitsRegex.IsMatch(actual).Should().BeTrue();
    }
}
