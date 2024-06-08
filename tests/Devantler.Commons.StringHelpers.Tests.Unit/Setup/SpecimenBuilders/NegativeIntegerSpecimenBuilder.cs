using AutoFixture.Kernel;

namespace Devantler.Commons.StringHelpers.Tests.Unit.Setup.SpecimenBuilders;

/// <summary>
/// A specimen builder for negative integers.
/// </summary>
public class NegativeIntegerSpecimenBuilder : ISpecimenBuilder
{
  /// <inheritdoc/>
  public object Create(object request, ISpecimenContext context) =>
    request is int ? context.Create<int>() * -1 : new NoSpecimen();
}
