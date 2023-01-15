using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
/// A base class for classes.
/// </summary>
public abstract class ClassBase : ICompilableUnit
{
    /// <summary>
    /// The name of the class.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// The namespace the class resides in.
    /// </summary>
    public string Namespace { get; }
    /// <summary>
    /// A list of usings in the class.
    /// </summary>
    public List<string> Usings { get; set; } = new List<string>();
    /// <summary>
    /// A list of compilable elements in the class.
    /// </summary>
    public List<IClassMember> Members { get; set; } = new List<IClassMember>();
    /// <summary>
    /// The documentation block of the class.
    /// </summary>
    public DocumentationBlockBase? DocumentationBlock { get; set; }

    /// <summary>
    /// Creates a new class.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="namespace"></param>
    protected ClassBase(string name, string @namespace)
    {
        Name = name;
        Namespace = @namespace;
    }

    /// <summary>
    /// Adds a member to the class.
    /// </summary>
    /// <param name="member"></param>
    public ClassBase AddMember(IClassMember member)
    {
        Members.Add(member);
        return this;
    }

    /// <summary>
    /// Adds a using to the class.
    /// </summary>
    /// <param name="using"></param>
    public ClassBase AddUsing(string @using)
    {
        Usings.Add(@using);
        return this;
    }

    /// <summary>
    /// Compiles the class.
    /// </summary>
    public abstract string Compile();
}
