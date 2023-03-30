namespace Devantler.Commons.EntityFramework.Extensions;

/// <summary>
/// An interface for entities.
/// </summary>
public interface IEntity<T>
{
    /// <summary>
    /// A unique identifier for the entity.
    /// </summary>
    public T Id { get; set; }
}
