using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
///     A base class for interfaces.
/// </summary>
public abstract class InterfaceBase : IInterface
{
    /// <summary>
    ///     Creates a new interface.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="namespace"></param>
    protected InterfaceBase(string name, string? @namespace = default)
    {
        Name = name;
        Namespace = @namespace;
    }

    /// <summary>
    ///     The name of the interface.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     The namespace of the interface.
    /// </summary>
    public string? Namespace { get; set; }

    /// <inheritdoc />
    public IDocBlock? DocBlock { get; set; }

    /// <inheritdoc />
    public List<IImport> Imports { get; } = new();

    /// <inheritdoc />
    public List<IProperty> Properties { get; } = new();

    /// <inheritdoc />
    public List<IMethod> Methods { get; } = new();

    /// <inheritdoc />
    public IInterface AddImport(IImport import)
    {
        Imports.Add(import);
        return this;
    }

    /// <inheritdoc />
    public IInterface AddProperty(IProperty property)
    {
        Properties.Add(property);
        return this;
    }

    /// <inheritdoc />
    public IInterface AddMethod(IMethod method)
    {
        Methods.Add(method);
        return this;
    }

    /// <inheritdoc />
    public abstract string Compile();
    /// <inheritdoc/>
    public IInterface SetName(string name)
    {
        Name = name;
        return this;
    }
    /// <inheritdoc/>
    public IInterface SetNamespace(string? @namespace)
    {
        Namespace = @namespace;
        return this;
    }
    /// <inheritdoc/>
    public IInterface SetDocBlock(IDocBlock? docBlock)
    {
        DocBlock = docBlock;
        return this;
    }
}
