using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.Core;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Tests.Unit.Mappers.AvroEntitiesCompilationMapperTests;

public static class TestCases
{
    public static IEnumerable<object[]> ValidCases =>
        new List<object[]>
        {
            new object[]
            {
                new RecordSchema("RecordSchema", new List<RecordField>
                {
                    new RecordField("IntField", new IntSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<int>(0, new IntSchema()) },
                    new RecordField("StringField", new StringSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<string>("string", new StringSchema()) },
                    new RecordField("BooleanField", new BooleanSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<bool>(false, new BooleanSchema()) },
                    new RecordField("DoubleField", new DoubleSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<double>(1.5, new DoubleSchema()) },
                    new RecordField("FloatField", new FloatSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<float>(1.5f, new FloatSchema()) },
                    new RecordField("LongField", new LongSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<long>(10L, new LongSchema()) },
                    new RecordField("NullField", new NullSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<object>(null!, new NullSchema()) },
                    new RecordField("BytesField", new BytesSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<byte[]>(new byte[1], new BytesSchema()) },
                    new RecordField("StringArrayField", new ArraySchema(new StringSchema())) { Documentation = "Test documentation" },
                }) { Documentation = "Test documentation" }, Language.CSharp
            },
            new object[]
            {
                new UnionSchema(new List<Schema>(){
                    new RecordSchema("TestRecord1", new List<RecordField>
                    {
                        new RecordField("IntField", new IntSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<int>(0, new IntSchema()) },
                        new RecordField("StringField", new StringSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<string>("string", new StringSchema()) },
                        new RecordField("BooleanField", new BooleanSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<bool>(false, new BooleanSchema()) },
                        new RecordField("DoubleField", new DoubleSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<double>(1.5, new DoubleSchema()) },
                        new RecordField("FloatField", new FloatSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<float>(1.5f, new FloatSchema()) },
                        new RecordField("LongField", new LongSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<long>(10L, new LongSchema()) },
                        new RecordField("NullField", new NullSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<object>(null!, new NullSchema()) },
                        new RecordField("BytesField", new BytesSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<byte[]>(new byte[1], new BytesSchema()) },
                        new RecordField("StringArrayField", new ArraySchema(new StringSchema())) { Documentation = "Test documentation" },
                    }) { Documentation = "Test documentation"},
                    new RecordSchema("TestRecord2", new List<RecordField>
                    {
                        new RecordField("IntField", new IntSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<int>(0, new IntSchema()) },
                        new RecordField("StringField", new StringSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<string>("string", new StringSchema()) },
                        new RecordField("BooleanField", new BooleanSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<bool>(false, new BooleanSchema()) },
                        new RecordField("DoubleField", new DoubleSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<double>(1.5, new DoubleSchema()) },
                        new RecordField("FloatField", new FloatSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<float>(1.5f, new FloatSchema()) },
                        new RecordField("LongField", new LongSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<long>(10L, new LongSchema()) },
                        new RecordField("NullField", new NullSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<object>(null!, new NullSchema()) },
                        new RecordField("BytesField", new BytesSchema()) { Documentation = "Test documentation", Default = new ObjectDefaultValue<byte[]>(new byte[1], new BytesSchema()) },
                        new RecordField("StringArrayField", new ArraySchema(new StringSchema())) { Documentation = "Test documentation" },
                    }) { Documentation = "Test documentation"},
                }), Language.CSharp
            }
        };
}
