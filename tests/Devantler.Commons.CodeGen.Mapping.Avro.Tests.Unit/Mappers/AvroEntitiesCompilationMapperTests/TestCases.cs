using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.Core;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Tests.Unit.Mappers.AvroEntitiesCompilationMapperTests;

public static class TestCases
{
    public static IEnumerable<object[]> ValidCases
    {
        get
        {
            var enumSchema = new EnumSchema("TestEnum", new List<string> { "Test1", "Test2", "Test3" });
            var recordSchema = GetRecordSchema("RecordSchema");
            return new List<object[]>{
                new object[]{ recordSchema, Language.CSharp },
                new object[]
                {
                    new UnionSchema(new List<Schema>() {
                            GetRecordSchema("UnionRecordSchema1"),
                            new RecordSchema("UnionRecordSchema2", new List<RecordField>
                            {
                                new("EnumField", enumSchema) { Documentation = "Test documentation" },
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
                new("IntField", new IntSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<int>(0, new IntSchema()) },
                new("StringField", new StringSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<string>("string", new StringSchema()) },
                new("BooleanField", new BooleanSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<bool>(false, new BooleanSchema()) },
                new("DoubleField", new DoubleSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<double>(1.5, new DoubleSchema()) },
                new("FloatField", new FloatSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<float>(1.5f, new FloatSchema()) },
                new("LongField", new LongSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<long>(10L, new LongSchema()) },
                new("NullField", new UnionSchema(new List<Schema>(){new StringSchema(), new NullSchema()})) { Documentation = "Test documentation", Default = new ObjectDefaultValue<object>(null!, new NullSchema()) },
                new("BytesField", new BytesSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<byte[]>(new byte[1], new BytesSchema()) },
                new("StringArrayField", new ArraySchema(new StringSchema())) { Documentation = "Test documentation" },
                new("StringMapField", new MapSchema(new StringSchema())) { Documentation = "Test documentation" }
            })
        { Documentation = "Test documentation" };
    }
}
