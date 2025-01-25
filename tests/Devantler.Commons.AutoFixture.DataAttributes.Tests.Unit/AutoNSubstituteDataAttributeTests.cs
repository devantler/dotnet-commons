namespace Devantler.Commons.AutoFixture.DataAttributes.Tests.Unit;

/// <summary>
/// Tests for the <see cref="AutoNSubstituteDataAttribute"/> class.
/// </summary>
public class AutoNSubstituteDataAttributeTests
{
  /// <summary>
  /// Tests that the <see cref="AutoNSubstituteDataAttribute"/> class can be instantiated.
  /// </summary>
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

  /// <summary>
  /// Tests that the <see cref="AutoNSubstituteDataAttribute"/> class can be instantiated with customizations.
  /// </summary>
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
