using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
/// A base class for enums.
/// </summary>
public abstract class EnumBase : ICompilableUnit
{
    /// <summary>
    /// The name of the enumeration.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// The namespace the enumeration resides in.
    /// </summary>
    public string Namespace { get; }
    /// <summary>
    /// The documentation block describing the enumeration.
    /// </summary>
    public DocumentationBlockBase? DocumentationBlock { get; set; }
    /// <summary>
    /// The values and their documentation in the enumeration.
    /// </summary>
    public Dictionary<string, DocumentationBlockBase?> Values { get; set; } = new Dictionary<string, DocumentationBlockBase?>();

    /// <summary>
    /// Creates a new enum.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="namespace"></param>
    protected EnumBase(string name, string @namespace)
    {
        Name = name;
        Namespace = @namespace;
    }

    /// <summary>
    /// Adds a value to the enumeration.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="documentationBlock"></param>
    public void AddValue(string value, DocumentationBlockBase? documentationBlock = default) => Values.Add(value, documentationBlock);

    /// <summary>
    /// Compiles the enumeration.
    /// </summary>
    public abstract string Compile();
}
