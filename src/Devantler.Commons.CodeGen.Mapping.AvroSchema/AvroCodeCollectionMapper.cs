using Avro;
using Devantler.Commons.CodeGen.Core;
using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.Core.Interfaces;
using Devantler.Commons.CodeGen.CSharp.Models;

namespace Devantler.Commons.CodeGen.Mapping.Avro;

/// <summary>
///     A mapper for mapping an Avro schema to a compilations.
/// </summary>
public class AvroCodeCollectionMapper : ICompilationMapper<Schema>
{
    /// <inheritdoc />
    public ICompilation Map(Schema obj, Language language)
    {
        ICompilation compilation = language switch
        {
            Language.CSharp => new CSharpCompilation(),
            Language.Java => throw new NotImplementedException(),
            _ => throw new NotSupportedException($"The language {language} is not supported.")
        };

        foreach (var schema in GetFlattenedSchemas(obj))
        {
            switch (schema)
            {
                case RecordSchema recordSchema:
                    CSharpClass @class = new(recordSchema.Name, recordSchema.Namespace, recordSchema.Documentation);

                    foreach (var field in recordSchema.Fields)
                    {
                        _ = @class.AddProperty(new CSharpProperty(
                                Visibility.Public,
                                field.Schema.Name,
                                field.Name,
                                field.Documentation
                            )
                        );
                    }

                    _ = compilation.AddClass(@class);
                    break;
                case EnumSchema enumSchema:
                    CSharpEnum @enum = new(enumSchema.Name, enumSchema.Namespace, enumSchema.Documentation);

                    for (int i = 0; i < enumSchema.Symbols.Count; i++)
                        _ = @enum.AddValue(new CSharpEnumValue(enumSchema.Symbols[i], i.ToString()));

                    _ = compilation.AddEnum(@enum);
                    break;
                default:
                    continue;
            }
        }

        return compilation;
    }

    List<Schema> GetFlattenedSchemas(Schema rootSchema)
    {
        static List<Schema> Flatten(Schema schema)
        {
            List<Schema> schemas = new();

            if (schema is RecordSchema recordSchema)
                schemas.Add(recordSchema);
            else if (schema is EnumSchema enumSchema)
                schemas.Add(enumSchema);
            else if (schema is UnionSchema unionSchema)
                schemas.AddRange(unionSchema.Schemas.ToList().SelectMany(Flatten));
            return schemas;
        }

        return Flatten(rootSchema);
    }
}
