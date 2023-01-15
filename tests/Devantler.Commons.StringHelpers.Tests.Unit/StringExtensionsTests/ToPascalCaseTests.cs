namespace Devantler.Commons.StringHelpers.Tests.Unit.StringExtensionsTests;

public class ToPascalCaseTests
{
    [Theory, AutoData]
    public void ReturnsToPascalCase(string text)
    {
        //Act
        string actual = text.ToPascalCase();

        //Assert
        _ = RegexLibrary.PascalCaseWithDigitsRegex.IsMatch(actual).Should().BeTrue();
    }
}
