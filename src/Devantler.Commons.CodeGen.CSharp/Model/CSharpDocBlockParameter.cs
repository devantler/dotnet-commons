using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
///     A model representing a C# documentation block parameter.
/// </summary>
/// <remarks>
/// Creates a new C# documentation block parameter.
/// </remarks>
/// <param name="name"></param>
public class CSharpDocBlockParameter(string name) : IDocBlockParameter
{
    /// <inheritdoc/>
    public string Name { get; set; } = name;
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
