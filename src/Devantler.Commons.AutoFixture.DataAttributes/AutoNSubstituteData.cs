using AutoFixture;
using AutoFixture.AutoNSubstitute;
using AutoFixture.Xunit2;

namespace Devantler.Commons.AutoFixture.DataAttributes;

/// <summary>
/// A data attribute that uses AutoFixture and NSubstitute to generate data and create mocks for tests.
/// </summary>
public class AutoNSubstituteDataAttribute : AutoDataAttribute
{
    /// <summary>
    /// Creates a new instance of the <see cref="AutoNSubstituteDataAttribute"/> class.
    /// </summary>
    /// <param name="customizations"></param>
    public AutoNSubstituteDataAttribute(params Type[] customizations) : base(
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
}
