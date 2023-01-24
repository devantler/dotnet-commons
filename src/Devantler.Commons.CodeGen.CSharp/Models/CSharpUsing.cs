using Devantler.Commons.CodeGen.Core.Base;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
///     A model representing a C# using.
/// </summary>
public class CSharpUsing : ImportBase
{
    /// <summary>
    ///     Creates a new import.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="alias"></param>
    public CSharpUsing(string name, string? alias = null) : base(name, alias)
    {
    }

    /// <summary>
    /// The template for a C# using.
    /// </summary>
    public static string Template => "using {{ if $1.alias != null }}{{ $1.alias }} = {{ end }}{{ $1.name}};";
}
