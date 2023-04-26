using System.ComponentModel.DataAnnotations;
using Devantler.Commons.StringHelpers.Extensions;

namespace Devantler.Commons.StringHelpers.Tests.Unit.Extensions.FormattingStringExtensionsTests;

public class IndentTests
{
    [Theory]
    [AutoData]
    public void GivenSingleLineTextAndPositiveIndentSize_IndentsBySpecifiedSpaces(string text, int indentSize)
    {
        //Act
        string actual = text.Indent(indentSize);

        //Assert
        Assert.StartsWith(new string(' ', indentSize), actual);
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
        Assert.StartsWith("first line", actual);
        Assert.EndsWith("    second line", actual);
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
        Assert.All(actual.Split(Environment.NewLine), line => Assert.StartsWith(new string(' ', indentSize), line));
    }

    [Theory]
    [AutoData]
    public void GivenSingleLineTextAndNegativeIndentSize_Throws([Range(-100, -1)] int indentSize)
    {
        //Act
        void action() => "this is a test".Indent(indentSize);

        //Assert
        _ = Assert.Throws<ArgumentOutOfRangeException>(action);
    }
}
