using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
///     A model representing a C# using.
/// </summary>
/// <remarks>
/// Creates a new C# using.
/// </remarks>
/// <param name="name"></param>
public class CSharpUsing(string name) : IImport
{
    /// <inheritdoc/>
    public string Name { get; set; } = name;
    /// <inheritdoc/>
    public string? Alias { get; set; }
    /// <summary>
    /// The template for a C# using.
    /// </summary>
    public static string Template => "using {{ if $1.alias }}{{ $1.alias }} = {{ end }}{{ $1.name}};";
}
