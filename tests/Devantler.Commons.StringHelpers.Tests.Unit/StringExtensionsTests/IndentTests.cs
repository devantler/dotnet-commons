namespace Devantler.Commons.StringHelpers.Tests.Unit.StringExtensionsTests;

public class IndentTests
{
    [Fact]
    public void Indent_GivenMultiLineTextAndSpacesArgument_IndentsBySpecifiedSpaces()
    {
        //Arrange
        const string expected =
            """
                first line
                second line
            """;

        //Act
        string actual =
            """
            first line
            second line
            """.Indent(4);

        //Assert
        _ = expected.Should().Be(actual);
    }

    [Fact]
    public void Indent_GivenMultiLineTextAndStringInterpolation_IndentsBySpecifiedSpaces()
    {
        const string expected =
            """
                first line
                    second line
            """;
        string actual =
            $$"""
            first line
            {{"second line".Indent(4)}}
            """.Indent(4);
        _ = expected.Should().Be(actual);
    }

    [Fact]
    public void Indent_GivenMultiLineText_IndentsByFourSpaces()
    {
        const string expected =
            """
                first line
                second line
            """;
        string actual =
            """
            first line
            second line
            """.Indent();

        _ = expected.Should().Be(actual);
    }

    [Fact]
    public void Indent_GivenNegativeSpacesArgument_ThrowsArgumentOutOfRangeException()
    {
        //Arrange/Act
        Action action = () => "this is a test".Indent(-1);

        //Assert
        _ = action.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Fact]
    public void Indent_GivenSingleLineTextAndSpacesArgument_IndentsBySpecifiedSpaces()
    {
        //Arrange
        const string expected = "    this is a test";

        //Act
        string actual = "this is a test".Indent(4);

        //Assert
        _ = expected.Should().Be(actual);
    }

    [Fact]
    public void Indent_GivenSingleLineText_IndentsByFourSpaces()
    {
        const string expected = "    this is a test";
        string actual = "this is a test".Indent();
        _ = expected.Should().Be(actual);
    }
}
