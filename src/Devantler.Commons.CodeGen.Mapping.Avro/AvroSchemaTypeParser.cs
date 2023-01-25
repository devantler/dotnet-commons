using Avro;
using Devantler.Commons.CodeGen.Core;

namespace Devantler.Commons.CodeGen.Mapping.Avro;

/// <summary>
/// A class containing methods for parsing <see cref="Schema.Type"/> to other representations.
/// </summary>
public static class AvroSchemaTypeParser
{
    /// <summary>
    /// Parses an <see cref="Schema.Type"/> to a string representation.
    /// </summary>
    /// <param name="field"></param>
    /// <param name="schemaType"></param>
    /// <param name="language"></param>
    public static string Parse(Field field, Schema.Type schemaType, Language language)
    {
        return schemaType switch
        {
            Schema.Type.Null => language switch
            {
                Language.CSharp => "object?",
                _ => throw new NotSupportedException($"Language {language} is not supported.")
            },
            Schema.Type.Bytes => language switch
            {
                Language.CSharp => "byte[]",
                _ => throw new NotSupportedException($"Language {language} is not supported.")
            },
            Schema.Type.Boolean => language switch
            {
                Language.CSharp => "bool",
                _ => throw new NotSupportedException($"Language {language} is not supported.")
            },
            Schema.Type.Array => language switch
            {
                Language.CSharp => $"List<{((ArraySchema)field.Schema).ItemSchema.Name}>",
                _ => throw new NotSupportedException($"Language {language} is not supported.")
            },
            Schema.Type.Logical => throw new NotSupportedException("Logical types are not supported in the Apache.Avro C# library yet."),
            _ => field.Schema.Name
        };
    }
}
