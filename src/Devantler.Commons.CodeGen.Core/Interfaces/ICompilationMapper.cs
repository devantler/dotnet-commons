namespace Devantler.Commons.CodeGen.Core.Interfaces;

/// <summary>
///     An interface for mapping some object to a compilation.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ICompilationMapper<T>
{
    /// <summary>
    ///     Maps the given object to a compilation.
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="language"></param>
    public ICompilation Map(T obj, Language language);
}
