namespace Devantler.Commons.CodeGen.Core.Interfaces;

/// <summary>
///     An interface representing a compilation.
/// </summary>
public interface ICompilation
{
    /// <summary>
    ///     A list of interfaces in the compilation.
    /// </summary>
    public List<IInterface> Interfaces { get; }

    /// <summary>
    ///     A list of classes in the compilation.
    /// </summary>
    public List<IClass> Classes { get; }

    /// <summary>
    ///     A list of classes in the compilation.
    /// </summary>
    public List<IEnum> Enums { get; }

    /// <summary>
    ///     Adds an interface to the compilation.
    /// </summary>
    /// <param name="interface"></param>
    public ICompilation AddInterface(IInterface @interface);

    /// <summary>
    ///     Adds a class to the compilation.
    /// </summary>
    /// <param name="class"></param>
    public ICompilation AddClass(IClass @class);

    /// <summary>
    ///     Adds an enumeration to the compilation.
    /// </summary>
    /// <param name="enum"></param>
    public ICompilation AddEnum(IEnum @enum);

    /// <summary>
    ///     Compiles the compilation.
    /// </summary>
    /// <param name="assemblyPath"></param>
    /// <exception cref="InvalidOperationException"></exception>
    public Dictionary<string, string> Compile(string? assemblyPath = default);
}
