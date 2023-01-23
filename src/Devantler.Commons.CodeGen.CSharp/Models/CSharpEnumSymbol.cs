using Devantler.Commons.CodeGen.Core.Base;

namespace Devantler.Commons.CodeGen.CSharp.Models;

/// <summary>
/// A model representing a C# enum value.
/// </summary>
public class CSharpEnumSymbol : EnumValueBase
{
    /// <summary>
    /// Creates a new enum value.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="value"></param>
    public CSharpEnumSymbol(string name, string value) : base(name, value)
    {
    }

    /// <summary>
    /// Creates a new enum value.
    /// </summary>
    /// <param name="name"></param>
    public CSharpEnumSymbol(string name) : base(name)
    {
    }
}
