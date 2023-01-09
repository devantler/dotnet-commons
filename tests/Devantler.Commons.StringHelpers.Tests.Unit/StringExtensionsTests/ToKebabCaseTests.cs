namespace Devantler.Commons.StringHelpers.Tests.Unit.StringExtensionsTests;

public class ToKebabCaseTests
{
    [Fact]
    public void ToKebabCase_WithCamelCase_ReturnsKebabCase()
    {
        //Arrange
        const string expected = "this-is-a-test";

        //Act
        string actual = "thisIsATest".ToKebabCase();

        //Assert
        _ = actual.Should().Be(expected);
    }

    [Fact]
    public void ToKebabCase_WithPascalCase_ReturnsKebabCase()
    {
        //Arrange
        const string expected = "this-is-a-test";

        //Act
        string actual = "ThisIsATest".ToKebabCase();

        //Assert
        _ = actual.Should().Be(expected);
    }

    [Fact]
    public void ToKebabCase_WithSnakeCase_ReturnsKebabCase()
    {
        //Arrange
        const string expected = "this-is-a-test";

        //Act
        string actual = "this_is_a_test".ToKebabCase();

        //Assert
        _ = actual.Should().Be(expected);
    }

    [Fact]
    public void ToKebabCase_WithMacroCase_ReturnsKebabCase()
    {
        //Arrange
        const string expected = "this-is-a-test";

        //Act
        string actual = "THIS_IS_A_TEST".ToKebabCase();

        //Assert
        _ = actual.Should().Be(expected);
    }

    [Fact]
    public void ToKebabCase_WithTrainCase_ReturnsKebabCase()
    {
        //Arrange
        const string expected = "this-is-a-test";

        //Act
        string actual = "THIS-IS-A-TEST".ToKebabCase();

        //Assert
        _ = actual.Should().Be(expected);
    }

    [Fact]
    public void ToKebabCase_WithPlainText_ReturnsKebabCase()
    {
        //Arrange
        const string expected = "this-is-a-test";

        //Act
        string actual = "This is a test".ToKebabCase();

        //Assert
        _ = actual.Should().Be(expected);
    }
}
