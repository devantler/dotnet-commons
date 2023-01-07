namespace Devantler.Commons.StringHelpers.Tests.Unit.StringExtensionsTests;

public class IndentTests
{
    [Fact]
    public void Indent_WithSingleLineText_IndentsByFourSpaces()
    {
        const string EXPECTED = "    this is a test";
        var actual = "this is a test".Indent();
        Assert.Equal(EXPECTED, actual);
    }

    [Fact]
    public void Indent_WithMultiLineText_IndentsByFourSpaces()
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
            """.Indent();

        Assert.Equal(EXPECTED, actual);
    }

    [Fact]
    public void Indent_WithSingleLineTextAndSpacesArgument_IndentsBySpecifiedSpaces()
    {
        const string EXPECTED = "    this is a test";
        var actual = "this is a test".Indent(4);
        Assert.Equal(EXPECTED, actual);
    }

    [Fact]
    public void Indent_WithMultiLineTextAndSpacesArgument_IndentsBySpecifiedSpaces()
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
            """.Indent(4);
        Assert.Equal(EXPECTED, actual);
    }

    [Fact]
    public void Indent_WithNegativeSpacesArgument_ThrowsArgumentOutOfRangeException() =>
        Assert.Throws<ArgumentOutOfRangeException>(() => "this is a test".Indent(-1));
}
