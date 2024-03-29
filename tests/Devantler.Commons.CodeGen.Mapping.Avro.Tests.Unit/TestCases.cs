using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.Core;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Tests.Unit;

/// <summary>
/// Test cases for Avro schema parsing.
/// </summary>
public static class TestCases
{
    /// <summary>
    /// Valid test cases.
    /// </summary>
    public static IEnumerable<object[]> ValidCases =>
        new List<object[]> {
            new object[] { new RecordField("BooleanField", new BooleanSchema()), Language.CSharp, "bool"},
            new object[] { new RecordField("BytesField", new BytesSchema()), Language.CSharp, "byte[]"},
            new object[] { new RecordField("DoubleField", new DoubleSchema()), Language.CSharp, "double"},
            new object[] { new RecordField("EnumField", new EnumSchema("TestEnum")), Language.CSharp, "TestEnum"},
            new object[] { new RecordField("FloatField", new FloatSchema()), Language.CSharp, "float"},
            new object[] { new RecordField("IntField", new IntSchema()), Language.CSharp, "int"},
            new object[] { new RecordField("LongField", new LongSchema()), Language.CSharp, "long"},
            new object[] { new RecordField("NullField", new UnionSchema(new List<Schema>(){new StringSchema(), new NullSchema()})), Language.CSharp, "string?"},
            new object[] { new RecordField("RecordField", new RecordSchema("TestRecord")), Language.CSharp, "TestRecord"},
            new object[] { new RecordField("RecordFieldWithSuffix", new RecordSchema("TestRecord")), Language.CSharp, "TestRecordSuffix", new AvroSchemaParserOptions { RecordSuffix = "Suffix" }},
            new object[] { new RecordField("StringArrayField", new ArraySchema(new StringSchema())), Language.CSharp, "List<string>"},
            new object[] { new RecordField("StringDateField", new StringSchema{ LogicalType = new DateLogicalType()}), Language.CSharp, "DateTime"},
            new object[] { new RecordField("StringField", new StringSchema()), Language.CSharp, "string"},
            new object[] { new RecordField("StringMapField", new MapSchema(new StringSchema())), Language.CSharp, "IDictionary<string, string>"},
            new object[] { new RecordField("StringUuidField", new StringSchema{ LogicalType = new UuidLogicalType()}), Language.CSharp, "Guid"}
        };

    /// <summary>
    /// Invalid test cases.
    /// </summary>
    public static IEnumerable<object[]> InvalidCases =>
        new List<object[]>
        {
            new object [] { new RecordField("BooleanField", new BooleanSchema()), (Language)999},
            new object [] { new RecordField("BytesField", new BytesSchema()), (Language)999},
            new object [] { new RecordField("DoubleField", new DoubleSchema()), (Language)999},
            new object [] { new RecordField("EnumField", new EnumSchema("TestEnum")), (Language)999},
            new object [] { new RecordField("FloatField", new FloatSchema()), (Language)999},
            new object [] { new RecordField("LogicalField", new IntSchema{ LogicalType = new DateLogicalType()}), (Language)999},
            new object [] { new RecordField("LongField", new LongSchema()), (Language)999},
            new object [] { new RecordField("NullField", new NullSchema()), (Language)999},
            new object [] { new RecordField("RecordField", new RecordSchema("TestRecord")), (Language)999},
            new object [] { new RecordField("StringArrayField", new ArraySchema(new StringSchema())), (Language)999},
            new object [] { new RecordField("StringField", new StringSchema()), (Language)999},
            new object [] { new RecordField("UnsupportedField", new UnsupportedSchema()), (Language)999}
        };
}
