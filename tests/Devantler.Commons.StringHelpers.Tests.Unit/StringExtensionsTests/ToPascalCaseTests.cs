namespace Devantler.Commons.StringHelpers.Tests.Unit.StringExtensionsTests;

public class ToPascalCaseTests
{
    [Fact]
    public void ToPascalCase_WithSingleWord_ReturnsPascalCase()
    {
        const string TEXT = "test";
        const string expected = "Test";
        string actual = TEXT.ToPascalCase();
        _ = expected.Should().Be(actual);
    }

    [Fact]
    public void ToPascalCase_WithMultipleWords_ReturnsPascalCase()
    {
        const string TEXT = "this is a test";
        const string expected = "ThisIsATest";
        string actual = TEXT.ToPascalCase();
        _ = expected.Should().Be(actual);
    }

    [Fact]
    public void ToPascalCase_WithCamelCase_ReturnsPascalCase()
    {
        const string TEXT = "thisIsATest";
        const string expected = "ThisIsATest";
        string actual = TEXT.ToPascalCase();
        _ = expected.Should().Be(actual);
    }

    [Fact]
    public void ToPascalCase_WithSnakeCase_ReturnsPascalCase()
    {
        const string TEXT = "this_is_a_test";
        const string expected = "ThisIsATest";
        string actual = TEXT.ToPascalCase();
        _ = expected.Should().Be(actual);
    }

    [Fact]
    public void ToPascalCase_WithKebabCase_ReturnsPascalCase()
    {
        const string TEXT = "this-is-a-test";
        const string expected = "ThisIsATest";
        string actual = TEXT.ToPascalCase();
        _ = expected.Should().Be(actual);
    }
}
