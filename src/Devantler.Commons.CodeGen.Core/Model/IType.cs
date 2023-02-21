namespace Devantler.Commons.CodeGen.Core.Model;

/// <summary>
///     An interface representing a compilable type in the programming language.
/// </summary>
public interface IType
{
    /// <summary>
    ///     The name of the type.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     The namespace of the type.
    /// </summary>
    public string? Namespace { get; set; }

    /// <summary>
    ///     Documentation for the type.
    /// </summary>
    public IDocBlock? DocBlock { get; }

    /// <summary>
    ///     The imports to the type.
    /// </summary>
    public List<IImport> Imports { get; }

    /// <summary>
    /// The visibility of the type.
    /// </summary>
    public Visibility Visibility { get; set; }

    /// <summary>
    /// Compiles the type.
    /// </summary>
    public string Compile();
}
