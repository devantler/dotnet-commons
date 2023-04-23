using Devantler.Commons.StringHelpers.Extensions;

namespace Devantler.Commons.StringHelpers.Tests.Unit.Extensions.CasingStringExtensionsTests;

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
        Assert.Matches(RegexLibrary.CamelCaseWithDigitsRegex, actual);
    }
}
