namespace Devantler.Commons.CodeGen.Core.Interfaces;

/// <summary>
/// An interface for mapping some object to a code collection.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ICodeCollectionMapper<T>
{
    /// <summary>
    /// Maps the given object to a code collection.
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="language"></param>
    public ICodeCollection Map(T obj, Language language);
}
