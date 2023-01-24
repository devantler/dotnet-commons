using Devantler.Commons.CodeGen.Core.Base;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
///     A model representing a C# parameter.
/// </summary>
public class CSharpParameter : ParameterBase
{
    /// <summary>
    ///     Creates a new parameter.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="name"></param>
    public CSharpParameter(string type, string name) : base(type, name)
    {
    }

    /// <summary>
    /// The template for a C# parameter.
    /// </summary>
    public static string Template => """{{ parameter.type }} {{ parameter.name }}""";
}
