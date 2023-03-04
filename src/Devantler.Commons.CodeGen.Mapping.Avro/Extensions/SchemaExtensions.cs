using Chr.Avro.Abstract;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Extensions;

/// <summary>
/// A static class containing extension methods for the <see cref="Schema"/> type.
/// </summary>
public static class SchemaExtensions
{
    /// <summary>
    /// Flattens a schema into a list of supported schemas.
    /// </summary>
    /// <param name="rootSchema"></param>
    public static List<Schema> Flatten(this Schema rootSchema)
    {
        static List<Schema> Flatten(Schema schema, List<Schema> schemas)
        {
            if (schemas.Contains(schema))
            {
                return schemas;
            }

            switch (schema)
            {
                case RecordSchema recordSchema:
                    {
                        schemas.Add(recordSchema);
                        foreach (var field in recordSchema.Fields)
                        {
                            schemas = Flatten(field.Type, schemas);
                        }

                        break;
                    }

                case EnumSchema enumSchema:
                    schemas.Add(enumSchema);
                    break;
                case ArraySchema arraySchema:
                    schemas = Flatten(arraySchema.Item, schemas);
                    break;
                case MapSchema mapSchema:
                    schemas = Flatten(mapSchema.Value, schemas);
                    break;
                case UnionSchema unionSchema:
                    schemas.AddRange(unionSchema.Schemas.ToList().SelectMany(s => Flatten(s, schemas)));
                    break;
            }

            return schemas;
        }

        return Flatten(rootSchema, new List<Schema>()).Distinct().ToList();
    }
}
