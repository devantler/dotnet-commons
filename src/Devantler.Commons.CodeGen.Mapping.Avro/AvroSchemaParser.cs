using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.Core;
using Devantler.Commons.CodeGen.Mapping.Core;

namespace Devantler.Commons.CodeGen.Mapping.Avro;

/// <summary>
/// A class containing methods for parsing <see cref="Schema"/> types to strings.
/// </summary>
public class AvroSchemaParser : IParser<Schema, AvroSchemaParserOptions>
{
    /// <inheritdoc />
    public string Parse(Schema @object, Language language, Action<AvroSchemaParserOptions>? action = default)
    {
        var options = new AvroSchemaParserOptions();
        action?.Invoke(options);
        return @object switch
        {
            UnionSchema unionSchema => language switch
            {
                Language.CSharp => ParseUnionSchema(unionSchema, language),
                _ => throw new NotSupportedException($"Language {language} is not supported.")
            },
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
                Language.CSharp => @object.LogicalType switch
                {
                    DateLogicalType => "DateTime",
                    UuidLogicalType => "Guid",
                    _ => "string"
                },
                _ => throw new NotSupportedException($"Language {language} is not supported.")
            },
            NullSchema => language switch
            {
                Language.CSharp => "?",
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
            EnumSchema => language switch
            {
                Language.CSharp => ((EnumSchema)@object).Name,
                _ => throw new NotSupportedException($"Language {language} is not supported.")
            },
            RecordSchema => language switch
            {
                Language.CSharp => $"{((RecordSchema)@object).Name}{options.RecordSuffix}",
                _ => throw new NotSupportedException($"Language {language} is not supported.")
            },
            ArraySchema => language switch
            {
                Language.CSharp => $"List<{Parse(((ArraySchema)@object).Item, language, action)}>",
                _ => throw new NotSupportedException($"Language {language} is not supported.")
            },
            MapSchema => language switch
            {
                Language.CSharp => $"IDictionary<string, {Parse(((MapSchema)@object).Value, language, action)}>",
                _ => throw new NotSupportedException($"Language {language} is not supported.")
            },
            _ => throw new NotSupportedException($"Schema type {@object.GetType().Name} is not supported."),
        };
    }

    string ParseUnionSchema(UnionSchema unionSchema, Language language)
    {
        switch (language)
        {
            case Language.CSharp:
                if (unionSchema.Schemas.Count != 2 && !unionSchema.Schemas.Any(s => s is NullSchema))
                {
                    throw new NotSupportedException("Union types are not supported in C#.");
                }
                var nonNullSchema = unionSchema.Schemas.First(s => s is not NullSchema);
                return Parse(nonNullSchema, Language.CSharp) + "?";
            default:
                throw new NotSupportedException($"Language {language} is not supported.");
        }
    }
}
