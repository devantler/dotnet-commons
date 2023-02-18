using Devantler.Commons.CodeGen.Core.Model;

namespace Devantler.Commons.CodeGen.CSharp.Model;

/// <summary>
///     A model representing a C# using.
/// </summary>
public class CSharpUsing : IImport
{
    /// <summary>
    /// Creates a new C# using.
    /// </summary>
    /// <param name="name"></param>
    public CSharpUsing(string name) => Name = name;
    /// <inheritdoc/>
    public string Name { get; set; }
    /// <inheritdoc/>
    public string? Alias { get; set; }
    /// <summary>
    /// The template for a C# using.
    /// </summary>
    public static string Template => "using {{ if $1.alias }}{{ $1.alias }} = {{ end }}{{ $1.name}};";
}
