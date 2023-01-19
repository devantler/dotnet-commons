using AutoFixture;
using AutoFixture.AutoNSubstitute;
using AutoFixture.Xunit2;

namespace Devantler.Commons.AutoFixture.DataAttributes;

public class AutoNSubstituteDataAttribute : AutoDataAttribute
{
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
