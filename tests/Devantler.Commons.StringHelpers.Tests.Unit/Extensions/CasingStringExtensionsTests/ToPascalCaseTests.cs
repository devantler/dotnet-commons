using Devantler.Commons.StringHelpers.Extensions;

namespace Devantler.Commons.StringHelpers.Tests.Unit.Extensions.CasingStringExtensionsTests;

/// <summary>
/// Test for <see cref="CasingStringExtensions.ToPascalCase"/>.
/// </summary>
public class ToPascalCaseTests
{
  [Theory]
  [AutoData]
  [MemberData(nameof(TestCases.CasingTests), MemberType = typeof(TestCases))]
  public void ReturnsToPascalCase(string text)
  {
    //Act
    string actual = text.ToPascalCase();

    //Assert
    Assert.Matches(RegexLibrary.PascalCaseWithDigitsRegex, actual);
  }
}
