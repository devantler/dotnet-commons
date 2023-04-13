using Devantler.Commons.StringHelpers.Extensions;

namespace Devantler.Commons.StringHelpers.Tests.Unit.Extensions.CasingStringExtensionsTests;

public class ToKebabCaseTests
{
    [Theory]
    [AutoData]
    [MemberData(nameof(TestCases.CasingTests), MemberType = typeof(TestCases))]
    public void ReturnsKebabCase(string text)
    {
        //Act
        string actual = text.ToKebabCase();

        //Assert
        _ = RegexLibrary.KebabCaseRegex.IsMatch(actual).Should().BeTrue();
    }
}
