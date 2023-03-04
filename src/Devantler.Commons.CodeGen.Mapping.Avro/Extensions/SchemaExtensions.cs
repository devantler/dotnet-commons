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
        static List<Schema> Flatten(Schema schema)
        {
            List<Schema> schemas = new();

            switch (schema)
            {
                case RecordSchema recordSchema:
                    {
                        schemas.Add(recordSchema);
                        foreach (var field in recordSchema.Fields)
                        {
                            schemas.AddRange(Flatten(field.Type));
                        }

                        break;
                    }

                case EnumSchema enumSchema:
                    schemas.Add(enumSchema);
                    break;
                case ArraySchema arraySchema:
                    schemas.AddRange(Flatten(arraySchema.Item));
                    break;
                case MapSchema mapSchema:
                    schemas.AddRange(Flatten(mapSchema.Value));
                    break;
                case UnionSchema unionSchema:
                    schemas.AddRange(unionSchema.Schemas.ToList().SelectMany(Flatten));
                    break;
            }

            return schemas;
        }

        return Flatten(rootSchema).Distinct().ToList();
    }
}
