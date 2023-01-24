using System.ComponentModel.DataAnnotations;

namespace Devantler.Commons.StringHelpers.Tests.Unit.FormattingStringExtensionsTests;

public class IndentTests
{
    [Theory]
    [AutoData]
    public void GivenSingleLineTextAndPositiveIndentSize_IndentsBySpecifiedSpaces(string text, int indentSize)
    {
        //Act
        string actual = text.Indent(indentSize);

        //Assert
        _ = actual.Should().StartWith(new string(' ', indentSize));
    }

    [Fact]
    public void GivenMultiLineTextAndIgnoreFirstLine_IgnoresFirstLine()
    {
        //Arrange
        const string multiLineText = """
        first line
        second line
        """;

        //Act
        string actual = multiLineText.Indent(4, true);

        //Assert
        _ = actual.Should().StartWith("first line");
        _ = actual.Should().EndWith("    second line");
    }

    [Theory]
    [InlineAutoData(
        """
        first line
        second line
        """
    )]
    public void GivenMultiLineTextAndPositiveIndentSize_IndentsBySpecifiedSpaces(string multiLineText, int indentSize)
    {
        //Act
        string actual = multiLineText.Indent(indentSize);

        //Assert
        _ = actual.Split(Environment.NewLine).Should()
            .OnlyContain(line => line.StartsWith(new string(' ', indentSize)));
    }

    [Theory]
    [AutoData]
    public void GivenSingleLineTextAndNegativeIndentSize_Throws([Range(-100, -1)] int indentSize)
    {
        //Act
        Action action = () => "this is a test".Indent(indentSize);

        //Assert
        _ = action.Should().Throw<ArgumentOutOfRangeException>();
    }
}
