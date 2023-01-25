using Avro;
using Devantler.Commons.CodeGen.Core;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Tests.Unit;

public static class TestCases
{
    public static IEnumerable<object[]> ValidCases =>
        new List<object[]> {
            new object[] { new Field(PrimitiveSchema.Create(Schema.Type.Null), "NullField", 0), Language.CSharp, "object?"},
            new object[] { new Field(PrimitiveSchema.Create(Schema.Type.Boolean), "BooleanField", 0), Language.CSharp, "bool"},
            new object[] { new Field(PrimitiveSchema.Create(Schema.Type.Int), "IntField", 0), Language.CSharp, "int"},
            new object[] { new Field(PrimitiveSchema.Create(Schema.Type.Long), "LongField", 0), Language.CSharp, "long"},
            new object[] { new Field(PrimitiveSchema.Create(Schema.Type.Float), "FloatField", 0), Language.CSharp, "float"},
            new object[] { new Field(PrimitiveSchema.Create(Schema.Type.Double), "DoubleField", 0), Language.CSharp, "double"},
            new object[] { new Field(PrimitiveSchema.Create(Schema.Type.Bytes), "BytesField", 0), Language.CSharp, "byte[]"},
            new object[] { new Field(PrimitiveSchema.Create(Schema.Type.String), "StringField", 0), Language.CSharp, "string"},
            new object[] { new Field(ArraySchema.Create(PrimitiveSchema.Create(Schema.Type.String)), "StringArrayField", 0), Language.CSharp, "List<string>"}
        };

    public static IEnumerable<object[]> InvalidCases =>
        new List<object[]>
        {
            new object[] { new Field(PrimitiveSchema.Create(Schema.Type.Null), "NullField", 0), (Language)999},
            new object[] { new Field(PrimitiveSchema.Create(Schema.Type.Bytes), "BytesField", 0), (Language)999},
            new object[] { new Field(PrimitiveSchema.Create(Schema.Type.Boolean), "BooleanField", 0), (Language)999},
            new object[] { new Field(ArraySchema.Create(PrimitiveSchema.Create(Schema.Type.String)), "StringArrayField", 0), (Language)999},
            new object[] { new Field(PrimitiveSchema.Create(Schema.Type.Logical), "LogicalField", 0), (Language)999},
        };
}
