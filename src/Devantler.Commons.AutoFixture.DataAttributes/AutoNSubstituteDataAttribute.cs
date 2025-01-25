using AutoFixture;
using AutoFixture.AutoNSubstitute;
using AutoFixture.Xunit2;

namespace Devantler.Commons.AutoFixture.DataAttributes;

/// <summary>
/// A data attribute that uses AutoFixture and NSubstitute to generate data and create mocks for tests.
/// </summary>
/// <remarks>
/// Creates a new instance of the <see cref="AutoNSubstituteDataAttribute"/> class.
/// </remarks>
/// <param name="customizations"></param>
public class AutoNSubstituteDataAttribute(params Type[] customizations) : AutoDataAttribute(
  () => new Fixture()
    .Customize(new AutoNSubstituteCustomization())
    .Customize(
      new CompositeCustomization(
          customizations.Select(customization => Activator.CreateInstance(customization) as ICustomization)
      )
    )
  )
{
}
