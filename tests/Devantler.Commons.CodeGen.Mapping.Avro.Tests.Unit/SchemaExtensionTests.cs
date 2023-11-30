using Chr.Avro.Abstract;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Tests.Unit;

/// <summary>
/// Tests for schema extensions.
/// </summary>
public class SchemaExtensionTests
{
    /// <summary>
    /// Tests the <see cref="SchemaExtensions.Flatten"/> method.
    /// </summary>
    [Fact]
    public void Flatten_ReturnsOnlyRecordAndEnumSchemas()
    {
        // Arrange
        var recordSchema = new RecordSchema("Person", new List<RecordField>
            {
                new("Name", new RecordSchema("Name", new List<RecordField>
                {
                    new("First", new StringSchema()),
                    new("Last",  new StringSchema())
                })),
                new("Person", new RecordSchema("Person", new List<RecordField>
                {
                    new("Name", new RecordSchema("Name", new List<RecordField>
                    {
                        new("First", new StringSchema()),
                        new("Last",  new StringSchema())
                    })),
                    new("Age", new IntSchema())
                }))
            }
        );

        var enumSchema = new EnumSchema("Color", new List<string> { "Red", "Green", "Blue" });

        var arraySchema = new ArraySchema(new BooleanSchema());

        var mapSchema = new MapSchema(new EnumSchema("Size", new List<string> { "Small", "Medium", "Large" }));

        var unionSchema = new UnionSchema(new List<Schema>
            {
                new IntSchema(),
                new LongSchema(),
                new FloatSchema(),
                new DoubleSchema()
            }
        );

        var rootSchema = new RecordSchema("Root", new List<RecordField>
            {
                new("Person", recordSchema),
                new("Color", enumSchema),
                new("Flags", arraySchema),
                new("Sizes", mapSchema),
                new("Numbers", unionSchema)
            });

        // Act
        var result = rootSchema.Flatten();

        // Assert
        Assert.Equal(5, result.Count);
        Assert.True(result.All(schema => schema is RecordSchema or EnumSchema));
    }
}
