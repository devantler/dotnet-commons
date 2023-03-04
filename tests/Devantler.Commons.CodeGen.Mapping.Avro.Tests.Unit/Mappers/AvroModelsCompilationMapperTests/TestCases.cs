using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.Core;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Tests.Unit.Mappers.AvroModelsCompilationMapperTests;

public static class TestCases
{
    public static IEnumerable<object[]> ValidCases
    {
        get
        {
            var enumSchema = new EnumSchema("TestEnum", new List<string> { "Test1", "Test2", "Test3" })
            {
                Documentation = "Test documentation"
            };
            var recordSchema = GetRecordSchema("RecordSchema");
            return new List<object[]>{
                new object[]{ recordSchema, Language.CSharp },
                new object[]{ enumSchema, Language.CSharp},
                new object[]
                {
                    new UnionSchema(new List<Schema>() {
                            GetRecordSchema("UnionRecordSchema1"),
                            new RecordSchema("UnionRecordSchema2", new List<RecordField>
                            {
                                new RecordField("EnumField", enumSchema) { Documentation = "Test documentation" },
                            }) { Documentation = "Test documentation" },
                            enumSchema
                    }), Language.CSharp
                }
            };
        }
    }

    static RecordSchema GetRecordSchema(string name)
    {
        return new RecordSchema(name, new List<RecordField>
            {
                new RecordField("IntField", new IntSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<int>(0, new IntSchema()) },
                new RecordField("StringField", new StringSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<string>("string", new StringSchema()) },
                new RecordField("BooleanField", new BooleanSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<bool>(false, new BooleanSchema()) },
                new RecordField("DoubleField", new DoubleSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<double>(1.5, new DoubleSchema()) },
                new RecordField("FloatField", new FloatSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<float>(1.5f, new FloatSchema()) },
                new RecordField("LongField", new LongSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<long>(10L, new LongSchema()) },
                new RecordField("NullField", new UnionSchema(new List<Schema>(){new StringSchema(), new NullSchema()})) { Documentation = "Test documentation", Default = new ObjectDefaultValue<object>(null!, new NullSchema()) },
                new RecordField("BytesField", new BytesSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<byte[]>(new byte[1], new BytesSchema()) },
                new RecordField("StringArrayField", new ArraySchema(new StringSchema())) { Documentation = "Test documentation" },
                new RecordField("StringMapField", new MapSchema(new StringSchema())) { Documentation = "Test documentation" }
            })
        { Documentation = "Test documentation" };
    }
}
