using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
/// A base class for interfaces.
/// </summary>
public abstract class InterfaceBase : IInterface
{
    /// <summary>
    /// The name of the interface.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// The namespace of the interface.
    /// </summary>
    public string Namespace { get; }
    /// <inheritdoc/>
    public abstract IDocBlock? DocBlock { get; }
    /// <inheritdoc/>
    public List<IImport> Imports { get; } = new();
    /// <inheritdoc/>
    public List<IProperty> Properties { get; } = new();
    /// <inheritdoc/>
    public List<IMethod> Methods { get; } = new();

    /// <summary>
    /// Creates a new interface.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="namespace"></param>
    protected InterfaceBase(string name, string @namespace)
    {
        Name = name;
        Namespace = @namespace;
    }

    /// <inheritdoc/>
    public IInterface AddImport(IImport import)
    {
        Imports.Add(import);
        return this;
    }
    /// <inheritdoc/>
    public IInterface AddProperty(IProperty property)
    {
        Properties.Add(property);
        return this;
    }
    /// <inheritdoc/>
    public IInterface AddMethod(IMethod method)
    {
        Methods.Add(method);
        return this;
    }
    /// <inheritdoc/>
    public abstract string Compile();
}
