using Chr.Avro.Abstract;

namespace Devantler.Commons.CodeGen.Mapping.Avro;

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
        static List<Schema> Flatten(Schema schema, List<Schema> schemas, Dictionary<string, Schema> seenSchemas)
        {
            switch (schema)
            {
                case RecordSchema recordSchema:
                    {
                        if (!seenSchemas.ContainsKey(recordSchema.Name))
                        {
                            seenSchemas.Add(recordSchema.Name, recordSchema);
                            schemas.Add(recordSchema);
                            foreach (var field in recordSchema.Fields)
                            {
                                _ = Flatten(field.Type, schemas, seenSchemas);
                            }
                        }

                        break;
                    }

                case EnumSchema enumSchema:
                    if (!seenSchemas.ContainsKey(enumSchema.Name))
                    {
                        seenSchemas.Add(enumSchema.Name, enumSchema);
                        schemas.Add(enumSchema);
                    }

                    break;

                case ArraySchema arraySchema:
                    _ = Flatten(arraySchema.Item, schemas, seenSchemas);

                    break;

                case MapSchema mapSchema:
                    _ = Flatten(mapSchema.Value, schemas, seenSchemas);

                    break;

                case UnionSchema unionSchema:
                    foreach (var schemaItem in unionSchema.Schemas)
                    {
                        _ = Flatten(schemaItem, schemas, seenSchemas);
                    }

                    break;
                default:
                    break;
            }

            return schemas;
        }

        return Flatten(rootSchema, [], []);
    }
}
