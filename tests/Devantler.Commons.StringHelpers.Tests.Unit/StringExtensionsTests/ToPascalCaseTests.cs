using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devantler.Commons.StringHelpers.Test.StringExtensionsTests;

public class ToPascalCaseTests
{
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
}
