using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
///     A base class for compilations.
/// </summary>
public abstract class CompilationBase : ICompilation
{
    /// <inheritdoc />
    public List<IInterface> Interfaces { get; } = new();

    /// <inheritdoc />
    public List<IClass> Classes { get; } = new();

    /// <inheritdoc />
    public List<IEnum> Enums { get; } = new();

    /// <inheritdoc />
    public ICompilation AddClass(IClass @class)
    {
        Classes.Add(@class);
        return this;
    }

    /// <inheritdoc />
    public ICompilation AddEnum(IEnum @enum)
    {
        Enums.Add(@enum);
        return this;
    }

    /// <inheritdoc />
    public ICompilation AddInterface(IInterface @interface)
    {
        Interfaces.Add(@interface);
        return this;
    }

    /// <inheritdoc />
    public abstract Dictionary<string, string> Compile();
}
