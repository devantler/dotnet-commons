namespace Devantler.Commons.CodeGen.Core.Interfaces;

/// <summary>
/// An interface representing a compilable type in the programming language.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IType<T>
{
    /// <summary>
    /// The name of the type.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The namespace of the type.
    /// </summary>
    public string Namespace { get; }

    /// <summary>
    /// Documentation for the type.
    /// </summary>
    public IDocBlock? DocBlock { get; }

    /// <summary>
    /// The imports to the type.
    /// </summary>
    public List<IImport> Imports { get; }

    /// <summary>
    /// Adds an import to the type.
    /// </summary>
    /// <param name="import"></param>
    public T AddImport(IImport import);

    /// <summary>
    /// Compiles the type.
    /// </summary>
    public string Compile();
}
