namespace Devantler.Commons.AutoFixture.DataAttributes.Tests.Unit;

public class AutoNSubstituteDataAttributeTests
{
    [Fact]
    [Obsolete("The test uses a deprecated method, but no alternative was found.")]
    public void GivenNothing_CreatesFixture()
    {
        // Arrange
        var sut = new AutoNSubstituteDataAttribute();
        var fixture = sut.Fixture;

        // Assert
        Assert.NotEmpty(fixture.Customizations);
    }

    [Fact]
    [Obsolete("The test uses a deprecated method, but no alternative was found.")]
    public void GivenCustomizations_CreatesFixtureWithCustomizations()
    {
        // Arrange
        var customizations = new[] { typeof(RandomNumericSequenceCustomization) };
        var sut = new AutoNSubstituteDataAttribute(customizations);
        var fixture = sut.Fixture;

        // Assert
        Assert.NotEmpty(fixture.Customizations);
    }
}
