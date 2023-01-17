using Devantler.Commons.CodeGen.Core.Base;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
///     A model representing a C# documentation block parameter.
/// </summary>
public class CSharpDocBlockParameter : DocBlockParameterBase
{
    /// <summary>
    ///     Creates a new documentation block parameter.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="description"></param>
    public CSharpDocBlockParameter(string name, string? description = default) : base(name, description)
    {
    }
}
