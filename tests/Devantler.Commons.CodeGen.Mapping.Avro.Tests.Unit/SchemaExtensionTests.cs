using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.Mapping.Avro;

public class SchemaExtensionTests
{
    [Fact]
    public void Flatten_ReturnsOnlyRecordAndEnumSchemas()
    {
        // Arrange
        var recordSchema = new RecordSchema("Person", new List<RecordField>
            {
                new RecordField("Name", new RecordSchema("Name", new List<RecordField>
                {
                    new RecordField("First", new StringSchema()),
                    new RecordField("Last",  new StringSchema())
                })),
                new RecordField("Person", new RecordSchema("Person", new List<RecordField>
                {
                    new RecordField("Name", new RecordSchema("Name", new List<RecordField>
                    {
                        new RecordField("First", new StringSchema()),
                        new RecordField("Last",  new StringSchema())
                    })),
                    new RecordField("Age", new IntSchema())
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
                new RecordField("Person", recordSchema),
                new RecordField("Color", enumSchema),
                new RecordField("Flags", arraySchema),
                new RecordField("Sizes", mapSchema),
                new RecordField("Numbers", unionSchema)
            });

        // Act
        var result = rootSchema.Flatten();

        // Assert
        result.Should().HaveCount(5);
        result.Should().AllSatisfy(schema => (schema is RecordSchema || schema is EnumSchema).Should().BeTrue());
    }
}
