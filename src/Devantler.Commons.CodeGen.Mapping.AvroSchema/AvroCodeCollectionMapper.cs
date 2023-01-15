using Avro;
using Devantler.Commons.CodeGen.Core;
using Devantler.Commons.CodeGen.Core.Base;
using Devantler.Commons.CodeGen.Core.Interfaces;
using Devantler.Commons.CodeGen.CSharp.Models;

namespace Devantler.Commons.CodeGen.Mapping.Avro;

/// <summary>
/// A mapper for mapping an Avro schema to a code collections.
/// </summary>
public class AvroCodeCollectionMapper : ICodeCollectionMapper<Schema>
{
    /// <inheritdoc/>
    public ICodeCollection Map(Schema obj, Language language)
    {
        ICodeCollection codeCollection = language switch
        {
            Language.CSharp => new CSharpCodeCollection(),
            Language.Java => throw new NotImplementedException(),
            _ => throw new NotSupportedException($"The language {language} is not supported.")
        };

        foreach (Schema schema in GetFlattenedSchemas(obj))
        {
            switch (schema)
            {
                case RecordSchema recordSchema:
                    CSharpClass @class = new(recordSchema.Name, recordSchema.Namespace, recordSchema.Documentation);

                    foreach (Field field in recordSchema.Fields)
                    {
                        _ = @class.AddMember(new CSharpProperty(
                                Visibility.Public,
                                field.Schema.Name,
                                field.Name,
                                field.Documentation
                            )
                        );
                    }

                    codeCollection.AddCompilableUnit(@class);
                    break;
                case EnumSchema enumSchema:
                    CSharpEnum @enum = new(enumSchema.Name, enumSchema.Namespace, enumSchema.Documentation);

                    foreach (string? symbol in enumSchema.Symbols)
                    {
                        @enum.AddValue(symbol);
                    }

                    codeCollection.AddCompilableUnit(@enum);
                    break;
                default:
                    continue;
            }
        }

        return codeCollection;
    }

    List<Schema> GetFlattenedSchemas(Schema rootSchema)
    {
        static List<Schema> Flatten(Schema schema)
        {
            List<Schema> schemas = new();

            if (schema is RecordSchema recordSchema)
            {
                schemas.Add(recordSchema);
            }
            else if (schema is EnumSchema enumSchema)
            {
                schemas.Add(enumSchema);
            }
            else if (schema is UnionSchema unionSchema)
            {
                schemas.AddRange(unionSchema.Schemas.ToList().SelectMany(Flatten));
            }
            return schemas;
        }

        return Flatten(rootSchema);
    }
}
