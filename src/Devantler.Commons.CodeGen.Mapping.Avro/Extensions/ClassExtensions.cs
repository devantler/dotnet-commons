using Avro;
using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.Core.Interfaces;
using Devantler.Commons.CodeGen.CSharp.Models;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Extensions;

/// <summary>
/// Extension methods for <see cref="IClass"/>.
/// </summary>
public static class ClassExtensions
{
    /// <summary>
    /// Adds a property to a class given an <see cref="Field"/>.
    /// </summary>
    /// <param name="class"></param>
    /// <param name="field"></param>
    public static IClass AddProperty(this IClass @class, Field field)
    {
        return @class.AddProperty(
            new CSharpProperty(
                Visibility.Public,
                field.Schema.Tag switch
                {
                    Schema.Type.Null => "object?",
                    Schema.Type.Bytes => "byte[]",
                    Schema.Type.Boolean => "bool",
                    _ => field.Schema.Name
                },
                field.Name,
                field.DefaultValue?.ToObject<string>(),
                field.Documentation
            )
        );
    }
}
