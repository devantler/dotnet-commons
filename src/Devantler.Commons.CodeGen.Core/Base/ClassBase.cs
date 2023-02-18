using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
///     A base class for classes.
/// </summary>
public abstract class ClassBase : IClass
{
    /// <summary>
    ///     Creates a new class.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="namespace"></param>
    protected ClassBase(string name, string? @namespace = null)
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
    public List<IField> Fields { get; } = new();

    /// <inheritdoc />
    public List<IProperty> Properties { get; } = new();

    /// <inheritdoc />
    public List<IConstructor> Constructors { get; } = new();

    /// <inheritdoc />
    public List<IMethod> Methods { get; } = new();

    /// <inheritdoc />
    public List<IImport> Imports { get; } = new();

    /// <inheritdoc/>
    public List<IInterface> Implementations { get; } = new();

    /// <inheritdoc/>
    public IClass? BaseClass { get; set; }

    /// <inheritdoc />
    public IClass AddImport(IImport import)
    {
        Imports.Add(import);
        return this;
    }

    /// <inheritdoc/>
    public IClass AddImplementation(IInterface implementation)
    {
        Implementations.Add(implementation);
        return this;
    }

    /// <inheritdoc />
    public IClass AddField(IField field)
    {
        Fields.Add(field);
        return this;
    }

    /// <inheritdoc />
    public IClass AddProperty(IProperty property)
    {
        Properties.Add(property);
        return this;
    }

    /// <inheritdoc />
    public IClass AddConstructor(IConstructor constructor)
    {
        Constructors.Add(constructor);
        return this;
    }

    /// <inheritdoc />
    public IClass AddMethod(IMethod method)
    {
        Methods.Add(method);
        return this;
    }

    /// <inheritdoc />
    public abstract string Compile();
    /// <inheritdoc/>
    public IClass SetBaseClass(IClass? @class)
    {
        BaseClass = @class;
        return this;
    }
    /// <inheritdoc/>
    public IClass SetName(string name)
    {
        Name = name;
        return this;
    }
    /// <inheritdoc/>
    public IClass SetNamespace(string? @namespace)
    {
        Namespace = @namespace;
        return this;
    }
    /// <inheritdoc/>
    public IClass SetDocBlock(IDocBlock? docBlock)
    {
        DocBlock = docBlock;
        return this;
    }
}
