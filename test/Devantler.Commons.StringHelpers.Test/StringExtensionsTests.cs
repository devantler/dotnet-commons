namespace Devantler.Commons.StringHelpers.Test;

public class StringExtensionsTest
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

    [Fact]
    public void ToPascalCase_WithSingleWord_ReturnsPascalCase()
    {
        const string TEXT = "test";
        const string EXPECTED = "Test";
        var actual = TEXT.ToPascalCase();
        Assert.Equal(EXPECTED, actual);
    }

    [Fact]
    public void ToPascalCase_WithMultipleWords_ReturnsPascalCase()
    {
        const string TEXT = "this is a test";
        const string EXPECTED = "ThisIsATest";
        var actual = TEXT.ToPascalCase();
        Assert.Equal(EXPECTED, actual);
    }

    [Fact]
    public void ToPascalCase_WithCamelCase_ReturnsPascalCase()
    {
        const string TEXT = "thisIsATest";
        const string EXPECTED = "ThisIsATest";
        var actual = TEXT.ToPascalCase();
        Assert.Equal(EXPECTED, actual);
    }

    [Fact]
    public void ToPascalCase_WithSnakeCase_ReturnsPascalCase()
    {
        const string TEXT = "this_is_a_test";
        const string EXPECTED = "ThisIsATest";
        var actual = TEXT.ToPascalCase();
        Assert.Equal(EXPECTED, actual);
    }

    [Fact]
    public void ToPascalCase_WithKebabCase_ReturnsPascalCase()
    {
        const string TEXT = "this-is-a-test";
        const string EXPECTED = "ThisIsATest";
        var actual = TEXT.ToPascalCase();
        Assert.Equal(EXPECTED, actual);
    }

    [Fact]
    public void ToCamelCase_WithSingleWord_ReturnsCamelCase()
    {
        const string TEXT = "test";
        const string EXPECTED = "test";
        var actual = TEXT.ToCamelCase();
        Assert.Equal(EXPECTED, actual);
    }

    [Fact]
    public void ToCamelCase_WithMultipleWords_ReturnsCamelCase()
    {
        const string TEXT = "this is a test";
        const string EXPECTED = "thisIsATest";
        var actual = TEXT.ToCamelCase();
        Assert.Equal(EXPECTED, actual);
    }

    [Fact]
    public void ToCamelCase_WithPascalCase_ReturnsCamelCase()
    {
        const string TEXT = "ThisIsATest";
        const string EXPECTED = "thisIsATest";
        var actual = TEXT.ToCamelCase();
        Assert.Equal(EXPECTED, actual);
    }

    [Fact]
    public void ToCamelCase_WithSnakeCase_ReturnsCamelCase()
    {
        const string TEXT = "this_is_a_test";
        const string EXPECTED = "thisIsATest";
        var actual = TEXT.ToCamelCase();
        Assert.Equal(EXPECTED, actual);
    }

    [Fact]
    public void ToCamelCase_WithKebabCase_ReturnsCamelCase()
    {
        const string TEXT = "this-is-a-test";
        const string EXPECTED = "thisIsATest";
        var actual = TEXT.ToCamelCase();
        Assert.Equal(EXPECTED, actual);
    }

    [Fact]
    public void ToPlural_WithSingleWord_ReturnsPlural()
    {
        const string TEXT = "test";
        const string EXPECTED = "tests";
        var actual = TEXT.ToPlural();
        Assert.Equal(EXPECTED, actual);
    }

    [Fact]
    public void ToPlural_WithSingleWordEndingWithS_ReturnsPlural()
    {
        const string TEXT = "glass";
        const string EXPECTED = "glasses";
        var actual = TEXT.ToPlural();
        Assert.Equal(EXPECTED, actual);
    }
}
