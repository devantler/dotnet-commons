using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devantler.Commons.StringHelpers.Test.StringExtensionsTests;

public class IndentByTests
{
    [Fact]
    public void IndentBy_WithSingleLineText_IndentsByFourSpaces()
    {
        const string EXPECTED = "    this is a test";
        var actual = "this is a test".IndentBy();
        Assert.Equal(EXPECTED, actual);
    }

    [Fact]
    public void IndentBy_WithMultiLineText_IndentsByFourSpaces()
    {
        const string EXPECTED =
            """
                first line
                second line
            """;
        var actual =
            """
            first line
            second line
            """.IndentBy();

        Assert.Equal(EXPECTED, actual);
    }

    [Fact]
    public void IndentBy_WithSingleLineTextAndSpacesArgument_IndentsBySpecifiedSpaces()
    {
        const string EXPECTED = "    this is a test";
        var actual = "this is a test".IndentBy(4);
        Assert.Equal(EXPECTED, actual);
    }

    [Fact]
    public void IndentBy_WithMultiLineTextAndSpacesArgument_IndentsBySpecifiedSpaces()
    {
        const string EXPECTED =
            """
                first line
                second line
            """;
        var actual =
            """
            first line
            second line
            """.IndentBy(4);
        Assert.Equal(EXPECTED, actual);
    }

    [Fact]
    public void IndentBy_WithNegativeSpacesArgument_ThrowsArgumentOutOfRangeException() =>
        Assert.Throws<ArgumentOutOfRangeException>(() => "this is a test".IndentBy(-1));
}
