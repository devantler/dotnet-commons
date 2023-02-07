using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.Core;

namespace Devantler.Commons.CodeGen.Mapping.Avro;

/// <summary>
/// A class containing methods for parsing <see cref="Schema"/> types to strings.
/// </summary>
public static class AvroSchemaTypeParser
{
    /// <summary>
    /// Parses the given <see cref="RecordField"/> to a string representation.
    /// </summary>
    /// <param name="field"></param>
    /// <param name="schemaType"></param>
    /// <param name="language"></param>
    /// <returns></returns>
    public static string Parse(RecordField field, Schema schemaType, Language language)
    {
        return schemaType switch
        {
            IntSchema => language switch
            {
                Language.CSharp => "int",
                _ => throw new NotSupportedException($"Language {language} is not supported.")
            },
            LongSchema => language switch
            {
                Language.CSharp => "long",
                _ => throw new NotSupportedException($"Language {language} is not supported.")
            },
            FloatSchema => language switch
            {
                Language.CSharp => "float",
                _ => throw new NotSupportedException($"Language {language} is not supported.")
            },
            DoubleSchema => language switch
            {
                Language.CSharp => "double",
                _ => throw new NotSupportedException($"Language {language} is not supported.")
            },
            StringSchema => language switch
            {
                Language.CSharp => "string",
                _ => throw new NotSupportedException($"Language {language} is not supported.")
            },
            NullSchema => language switch
            {
                Language.CSharp => "object?",
                _ => throw new NotSupportedException($"Language {language} is not supported.")
            },
            BytesSchema => language switch
            {
                Language.CSharp => "byte[]",
                _ => throw new NotSupportedException($"Language {language} is not supported.")
            },
            BooleanSchema => language switch
            {
                Language.CSharp => "bool",
                _ => throw new NotSupportedException($"Language {language} is not supported.")
            },
            ArraySchema => language switch
            {
                Language.CSharp => $"List<{Parse(field, ((ArraySchema)field.Type).Item, language)}>",
                _ => throw new NotSupportedException($"Language {language} is not supported.")
            },
            _ => throw new NotSupportedException($"Schema type {schemaType.GetType().Name} is not supported."),
        };
    }
}
