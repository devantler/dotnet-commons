using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.Core;
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
    /// Adds a property to a class given an <see cref="RecordField"/>.
    /// </summary>
    /// <param name="class"></param>
    /// <param name="field"></param>
    public static IClass AddProperty(this IClass @class, RecordField field)
    {
        return @class.AddProperty(
            new CSharpProperty(
                Visibility.Public,
                AvroSchemaTypeParser.Parse(field, field.Type, Language.CSharp),
                field.Name,
                field.Default?.ToObject<object>()?.ToString(),
                field.Documentation
            )
        );
    }
}
