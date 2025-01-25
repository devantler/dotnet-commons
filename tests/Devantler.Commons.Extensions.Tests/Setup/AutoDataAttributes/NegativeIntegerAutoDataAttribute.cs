using AutoFixture;
using AutoFixture.Xunit2;
using Devantler.Commons.Extensions.Tests.Unit.Setup.SpecimenBuilders;

namespace Devantler.Commons.Extensions.Tests.Unit.Setup.AutoDataAttributes;

/// <summary>
/// An auto data attribute that generates negative integers.
/// </summary>
public class NegativeIntegerAutoDataAttribute : AutoDataAttribute
{
  /// <summary>
  /// Creates a new instance of the <see cref="NegativeIntegerAutoDataAttribute"/> class.
  /// </summary>
  public NegativeIntegerAutoDataAttribute() : base(() =>
  {
    var fixture = new Fixture();
    fixture.Customizations.Add(new NegativeIntegerSpecimenBuilder());
    return fixture;
  })
  {
  }
}
