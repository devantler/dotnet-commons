using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devantler.Commons.StringHelpers.Test.StringExtensionsTests;

public class ToPluralTests
{
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
