using Devantler.Commons.Extensions.StringExtensions;

namespace Devantler.Commons.StringHelpers.Tests.Unit.Extensions.GeneralStringExtensionsTests;

public class GeneralStringExtensionsTests
{
  [Theory]
  [InlineData(null)]
  [InlineData("")]
  public void NullIfEmpty_ReturnsNull_ForNullAndEmptyStrings(string? input)
  {
    // Act
    string? actual = input?.NullIfEmpty();

    // Assert
    Assert.Null(actual);
  }

  [Theory]
  [InlineData("hello")]
  [InlineData("a")]
  [InlineData(" ")]
  public void NullIfEmpty_ReturnsOriginalString_ForNonEmptyStrings(string input)
  {
    // Act
    string? actual = input.NullIfEmpty();

    // Assert
    Assert.Equal(input, actual);
  }
}
