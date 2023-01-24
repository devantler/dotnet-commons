namespace Devantler.Commons.StringHelpers.Tests.Unit.CasingStringExtensionsTests;

public class ToCamelCaseTests
{
    [Theory]
    [AutoData]
    [MemberData(nameof(TestCases.CasingTests), MemberType = typeof(TestCases))]
    public void ReturnsCamelCase(string text)
    {
        //Act
        string actual = text.ToCamelCase();

        //Assert
        _ = RegexLibrary.CamelCaseWithDigitsRegex.IsMatch(actual).Should().BeTrue();
    }
}
