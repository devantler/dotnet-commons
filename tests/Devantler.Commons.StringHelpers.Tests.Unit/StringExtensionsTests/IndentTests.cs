using System.ComponentModel.DataAnnotations;

namespace Devantler.Commons.StringHelpers.Tests.Unit.StringExtensionsTests;

public class IndentTests
{
    [Theory, AutoData]
    public void GivenSingleLineTextAndPositiveIndentSize_IndentsBySpecifiedSpaces(string text, int indentSize)
    {
        //Act
        string actual = text.Indent(indentSize);

        //Assert
        _ = actual.Should().StartWith(new string(' ', indentSize));
    }

    [Theory, InlineAutoData(
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
        _ = actual.Split(Environment.NewLine).Should().OnlyContain(line => line.StartsWith(new string(' ', indentSize)));
    }

    [Theory, AutoData]
    public void GivenSingleLineTextAndNegativeIndentSize_Throws([Range(-100, -1)] int indentSize)
    {
        //Act
        Action action = () => "this is a test".Indent(indentSize);

        //Assert
        _ = action.Should().Throw<ArgumentOutOfRangeException>();
    }
}
