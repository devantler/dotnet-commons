using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.Core.Base;

/// <summary>
/// A base class for documentation blocks.
/// </summary>
public abstract class DocumentationBlockBase : ICompilable
{
    /// <summary>
    /// The summary of the documented unit described by the documentation block.
    /// </summary>
    public string Summary { get; }
    /// <summary>
    /// The documented parameters of the documented unit described by the documentation block.
    /// </summary>
    public List<string> Parameters { get; set; } = new List<string>();

    /// <summary>
    /// Creates a new instance of <see cref="DocumentationBlockBase"/>.
    /// </summary>
    /// <param name="summary"></param>
    protected DocumentationBlockBase(string summary) => Summary = summary;

    /// <summary>
    /// Adds a parameter to the documentation block.
    /// </summary>
    /// <param name="parameter"></param>
    public void AddParameter(string parameter) => Parameters.Add(parameter);

    /// <summary>
    /// Compiles the documentation block.
    /// </summary>
    public abstract string Compile();
}
