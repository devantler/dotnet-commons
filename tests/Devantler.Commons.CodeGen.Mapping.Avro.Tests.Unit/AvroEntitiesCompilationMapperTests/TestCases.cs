using Avro;
using Devantler.Commons.CodeGen.Core;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Tests.Unit.AvroEntitiesCompilationMapperTests;

public static class TestCases
{
    public static IEnumerable<object[]> ValidCases =>
        new List<object[]>
        {
            new object[]
            {
                RecordSchema.Create("RecordSchema", new List<Field>
                {
                    new Field(PrimitiveSchema.Create(Schema.Type.Int), "IntField", 1, doc: "Test documentation", defaultValue: 0),
                    new Field(PrimitiveSchema.Create(Schema.Type.String), "StringField", 2, doc: "Test documentation", defaultValue: "i am a string"),
                    new Field(PrimitiveSchema.Create(Schema.Type.Boolean), "BooleanField", 3, doc: "Test documentation", defaultValue: false),
                    new Field(PrimitiveSchema.Create(Schema.Type.Double), "DoubleField", 4, doc: "Test documentation", defaultValue: 1.5),
                    new Field(PrimitiveSchema.Create(Schema.Type.Float), "FloatField", 5, doc: "Test documentation", defaultValue: 1.5f),
                    new Field(PrimitiveSchema.Create(Schema.Type.Long), "LongField", 6, doc: "Test documentation", defaultValue: 10L),
                    new Field(PrimitiveSchema.Create(Schema.Type.Null), "NullField", 7, doc: "Test documentation", defaultValue: "null!"),
                    new Field(PrimitiveSchema.Create(Schema.Type.Bytes), "BytesField", 8, doc: "Test documentation", defaultValue: "new byte[1]"),
                }, doc: "Test documentation"), Language.CSharp
            },
            new object[]
            {
                UnionSchema.Create(new List<Schema>(){
                    RecordSchema.Create("TestRecord1", new List<Field>
                    {
                        new Field(PrimitiveSchema.Create(Schema.Type.Int), "IntField", 1, doc: "Test documentation", defaultValue: 0),
                        new Field(PrimitiveSchema.Create(Schema.Type.String), "StringField", 2, doc: "Test documentation", defaultValue: "i am a string"),
                        new Field(PrimitiveSchema.Create(Schema.Type.Boolean), "BooleanField", 3, doc: "Test documentation", defaultValue: false),
                        new Field(PrimitiveSchema.Create(Schema.Type.Double), "DoubleField", 4, doc: "Test documentation", defaultValue: 1.5),
                        new Field(PrimitiveSchema.Create(Schema.Type.Float), "FloatField", 5, doc: "Test documentation", defaultValue: 1.5f),
                        new Field(PrimitiveSchema.Create(Schema.Type.Long), "LongField", 6, doc: "Test documentation", defaultValue: 10L),
                        new Field(PrimitiveSchema.Create(Schema.Type.Null), "NullField", 7, doc: "Test documentation", defaultValue: "null!"),
                        new Field(PrimitiveSchema.Create(Schema.Type.Bytes), "BytesField", 8, doc: "Test documentation", defaultValue: "new byte[1]"),
                    }, doc: "Test documentation"),
                    RecordSchema.Create("TestRecord2", new List<Field>
                    {
                        new Field(PrimitiveSchema.Create(Schema.Type.Int), "IntField", 1, doc: "Test documentation", defaultValue: 0),
                        new Field(PrimitiveSchema.Create(Schema.Type.String), "StringField", 2, doc: "Test documentation", defaultValue: "Test"),
                        new Field(PrimitiveSchema.Create(Schema.Type.Boolean), "BooleanField", 3, doc: "Test documentation", defaultValue: false),
                        new Field(PrimitiveSchema.Create(Schema.Type.Double), "DoubleField", 4, doc: "Test documentation", defaultValue: 0.0),
                        new Field(PrimitiveSchema.Create(Schema.Type.Float), "FloatField", 5, doc: "Test documentation", defaultValue: 0.0f),
                        new Field(PrimitiveSchema.Create(Schema.Type.Long), "LongField", 6, doc: "Test documentation", defaultValue: 0L),
                        new Field(PrimitiveSchema.Create(Schema.Type.Null), "NullField", 7, doc: "Test documentation", defaultValue: "null!"),
                        new Field(PrimitiveSchema.Create(Schema.Type.Bytes), "BytesField", 8, doc: "Test documentation", defaultValue: "new byte[1]"),
                    }, doc: "Test documentation"),
                }), Language.CSharp
            }
        };
}
