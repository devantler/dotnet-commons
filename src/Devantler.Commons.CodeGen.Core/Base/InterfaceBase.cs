using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
/// A base class for interfaces.
/// </summary>
public abstract class InterfaceBase : ICompilableUnit
{
    /// <summary>
    /// The name of the interface.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// The namespace of the interface.
    /// </summary>
    public string Namespace { get; }
    /// <summary>
    /// The documentation block describing the interface.
    /// </summary>
    public DocumentationBlockBase? DocumentationBlock { get; set; }
    /// <summary>
    /// A list of usings in the interface.
    /// </summary>
    public List<string> Usings { get; set; } = new List<string>();
    /// <summary>
    /// The members of the interface.
    /// </summary>
    public List<IInterfaceMember> Members { get; set; } = new List<IInterfaceMember>();

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
    /// <summary>
    /// Adds a using to the interface.
    /// </summary>
    /// <param name="using"></param>
    public InterfaceBase AddUsing(string @using)
    {
        Usings.Add(@using);
        return this;
    }

    /// <summary>
    /// Adds a member to the interface.
    /// </summary>
    /// <param name="member"></param>
    public InterfaceBase AddMember(IInterfaceMember member)
    {
        Members.Add(member);
        return this;
    }
    /// <summary>
    /// Compiles the interface.
    /// </summary>
    public abstract string Compile();
}
