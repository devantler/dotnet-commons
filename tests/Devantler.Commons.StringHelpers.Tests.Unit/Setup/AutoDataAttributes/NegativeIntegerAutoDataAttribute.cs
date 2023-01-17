using Devantler.Commons.StringHelpers.Tests.Unit.Setup.SpecimenBuilders;

namespace Devantler.Commons.StringHelpers.Tests.Unit.Setup.AutoDataAttributes;

public class NegativeIntegerAutoDataAttribute : AutoDataAttribute
{
    public NegativeIntegerAutoDataAttribute() : base(() =>
    {
        var fixture = new Fixture();
        fixture.Customizations.Add(new NegativeIntegerSpecimenBuilder());
        return fixture;
    })
    {
    }
}
