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
    [
      [new RecordField("BooleanField", new BooleanSchema()), Language.CSharp, "bool"],
      [new RecordField("BytesField", new BytesSchema()), Language.CSharp, "byte[]"],
      [new RecordField("DoubleField", new DoubleSchema()), Language.CSharp, "double"],
      [new RecordField("EnumField", new EnumSchema("TestEnum")), Language.CSharp, "TestEnum"],
      [new RecordField("FloatField", new FloatSchema()), Language.CSharp, "float"],
      [new RecordField("IntField", new IntSchema()), Language.CSharp, "int"],
      [new RecordField("LongField", new LongSchema()), Language.CSharp, "long"],
      [new RecordField("NullField", new UnionSchema([new StringSchema(), new NullSchema()])), Language.CSharp, "string?"],
      [new RecordField("RecordField", new RecordSchema("TestRecord")), Language.CSharp, "TestRecord"],
      [new RecordField("RecordFieldWithSuffix", new RecordSchema("TestRecord")), Language.CSharp, "TestRecordSuffix", new AvroSchemaParserOptions { RecordSuffix = "Suffix" }],
      [new RecordField("StringArrayField", new ArraySchema(new StringSchema())), Language.CSharp, "List<string>"],
      [new RecordField("StringDateField", new StringSchema{ LogicalType = new DateLogicalType()}), Language.CSharp, "DateTime"],
      [new RecordField("StringField", new StringSchema()), Language.CSharp, "string"],
      [new RecordField("StringMapField", new MapSchema(new StringSchema())), Language.CSharp, "IDictionary<string, string>"],
      [new RecordField("StringUuidField", new StringSchema{ LogicalType = new UuidLogicalType()}), Language.CSharp, "Guid"]
    ];

  /// <summary>
  /// Invalid test cases.
  /// </summary>
  public static IEnumerable<object[]> InvalidCases =>
    [
      [new RecordField("BooleanField", new BooleanSchema()), (Language)999],
      [new RecordField("BytesField", new BytesSchema()), (Language)999],
      [new RecordField("DoubleField", new DoubleSchema()), (Language)999],
      [new RecordField("EnumField", new EnumSchema("TestEnum")), (Language)999],
      [new RecordField("FloatField", new FloatSchema()), (Language)999],
      [new RecordField("LogicalField", new IntSchema{ LogicalType = new DateLogicalType()}), (Language)999],
      [new RecordField("LongField", new LongSchema()), (Language)999],
      [new RecordField("NullField", new NullSchema()), (Language)999],
      [new RecordField("RecordField", new RecordSchema("TestRecord")), (Language)999],
      [new RecordField("StringArrayField", new ArraySchema(new StringSchema())), (Language)999],
      [new RecordField("StringField", new StringSchema()), (Language)999],
      [new RecordField("UnsupportedField", new UnsupportedSchema()), (Language)999]
    ];
}
