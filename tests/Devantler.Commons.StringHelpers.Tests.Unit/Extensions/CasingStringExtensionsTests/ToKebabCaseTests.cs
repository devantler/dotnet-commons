using Devantler.Commons.StringHelpers.Extensions;

namespace Devantler.Commons.StringHelpers.Tests.Unit.Extensions.CasingStringExtensionsTests;

/// <summary>
/// Test for <see cref="CasingStringExtensions.ToKebabCase"/>.
/// </summary>
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
    Assert.Matches(RegexLibrary.KebabCaseRegex, actual);
  }
}
