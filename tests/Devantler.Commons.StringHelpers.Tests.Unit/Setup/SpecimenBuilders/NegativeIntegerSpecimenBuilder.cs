using AutoFixture.Kernel;

namespace Devantler.Commons.StringHelpers.Tests.Unit.Setup.SpecimenBuilders;

public class NegativeIntegerSpecimenBuilder : ISpecimenBuilder
{
    public object Create(object request, ISpecimenContext context)
    {
        return request is int ?
            context.Create<int>() * -1 :
            new NoSpecimen();
    }
}
