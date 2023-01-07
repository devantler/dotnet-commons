namespace Devantler.Commons.StringHelpers.Tests.Unit.StringExtensionsTests;

public class ToCamelCaseTests
{
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
}
