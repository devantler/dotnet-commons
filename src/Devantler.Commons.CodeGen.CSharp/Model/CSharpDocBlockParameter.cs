using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
///     A model representing a C# documentation block parameter.
/// </summary>
public class CSharpDocBlockParameter : IDocBlockParameter
{
    /// <summary>
    /// Creates a new C# documentation block parameter.
    /// </summary>
    /// <param name="name"></param>
    public CSharpDocBlockParameter(string name) => Name = name;
    /// <inheritdoc/>
    public string Name { get; set; }
    /// <inheritdoc/>
    public string? Description { get; set; }
    /// <inheritdoc/>
    public CSharpDocBlockParameter SetDescription(string description)
    {
        Description = description;
        return this;
    }

    /// <summary>
    /// The template for a C# documentation block parameter.
    /// </summary>
    public static string Template =>
        """<param name="{{ $1.name }}">{{ $1.description }}</param>""";
}
