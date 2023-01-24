using Avro;

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
