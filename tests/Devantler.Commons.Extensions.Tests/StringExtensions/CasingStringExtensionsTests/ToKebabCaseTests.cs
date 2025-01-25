using AutoFixture.Xunit2;
using Devantler.Commons.Extensions;
using Devantler.Commons.Extensions.StringExtensions;

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
