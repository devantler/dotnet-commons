using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
///     A base class for enums.
/// </summary>
public abstract class EnumBase : IEnum
{
    /// <summary>
    ///     Creates a new enumeration.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="namespace"></param>
    protected EnumBase(string name, string? @namespace)
    {
        Name = name;
        Namespace = @namespace;
    }

    /// <inheritdoc />
    public string Name { get; set; }

    /// <inheritdoc />
    public string? Namespace { get; set; }

    /// <inheritdoc />
    public IDocBlock? DocBlock { get; set; }

    /// <inheritdoc />
    public List<IImport> Imports { get; } = new();

    /// <inheritdoc />
    public List<IEnumValue> Values { get; } = new();

    /// <inheritdoc />
    public IEnum AddImport(IImport import)
    {
        Imports.Add(import);
        return this;
    }

    /// <inheritdoc />
    public IEnum AddValue(IEnumValue value)
    {
        Values.Add(value);
        return this;
    }

    /// <inheritdoc />
    public abstract string Compile();
    /// <inheritdoc/>
    public IEnum SetDocBlock(IDocBlock? docBlock)
    {
        DocBlock = docBlock;
        return this;
    }
    /// <inheritdoc/>
    public IEnum SetName(string name)
    {
        Name = name;
        return this;
    }
    /// <inheritdoc/>
    public IEnum SetNamespace(string? @namespace)
    {
        Namespace = @namespace;
        return this;
    }
}
