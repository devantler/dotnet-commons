using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.Core.Interfaces;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
///     A model representing a C# method.
/// </summary>
public class CSharpMethod : MethodBase
{
    /// <summary>
    ///     Creates a new method.
    /// </summary>
    /// <param name="visibility"></param>
    /// <param name="type"></param>
    /// <param name="name"></param>
    /// <param name="body"></param>
    /// <param name="documentationBlock"></param>
    public CSharpMethod(Visibility visibility, string type, string name, string? body = null,
        IDocBlock? documentationBlock = null) : base(visibility, type, name, body, documentationBlock)
    {
    }
}
