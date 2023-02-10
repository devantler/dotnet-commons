namespace Devantler.Commons.CodeGen.Core.Interfaces;

/// <summary>
/// An interface for mapping an object to code compilation.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ICompilationMapper<T>
{
    /// <summary>
    /// Maps given object to a code compilation for a specified language.
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="language"></param>
    public ICompilation Map(T obj, Language language);
}
