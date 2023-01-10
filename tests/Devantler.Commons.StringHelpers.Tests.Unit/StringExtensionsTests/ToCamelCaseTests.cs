namespace Devantler.Commons.StringHelpers.Tests.Unit.StringExtensionsTests;

public class ToCamelCaseTests
{
    [Theory]
    [InlineData("this-is-a-test")]
    [InlineData("this_is_a_test")]
    [InlineData("THIS_IS_A_TEST")]
    [InlineData("THIS-IS-A-TEST")]
    [InlineData("This is a test")]
    [InlineData("ThisIsATest")]
    [InlineData("thisIsATest")]
    public void ReturnsCamelCase(string text)
    {
        //Arrange
        const string expected = "thisIsATest";

        //Act
        string actual = text.ToCamelCase();

        //Assert
        _ = actual.Should().Be(expected);
    }
}
