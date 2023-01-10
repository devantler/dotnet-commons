namespace Devantler.Commons.StringHelpers.Tests.Unit.StringExtensionsTests;

public class ToPascalCaseTests
{
    [Theory]
    [InlineData("this-is-a-test")]
    [InlineData("this_is_a_test")]
    [InlineData("THIS_IS_A_TEST")]
    [InlineData("THIS-IS-A-TEST")]
    [InlineData("This is a test")]
    [InlineData("this is a test")]
    [InlineData("ThisIsATest")]
    [InlineData("thisIsATest")]
    [InlineData("ThisIs1Test")]
    public void ReturnsToPascalCase(string text)
    {
        //Arrange
        string[] expected = { "ThisIsATest", "ThisIs1Test" };

        //Act
        string actual = text.ToPascalCase();

        //Assert
        _ = expected.Should().Contain(actual);
    }
}
