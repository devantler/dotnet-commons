using Devantler.Commons.StringHelpers.Extensions;

namespace Devantler.Commons.StringHelpers.Tests.Unit.Extensions.GeneralStringExtensionsTests;

public class GeneralStringExtensionsTests
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void NullIfEmpty_ReturnsNull_ForNullAndEmptyStrings(string input)
    {
        // Act
        string? actual = input.NullIfEmpty();

        // Assert
        _ = actual.Should().BeNull();
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
        _ = actual.Should().Be(input);
    }
}