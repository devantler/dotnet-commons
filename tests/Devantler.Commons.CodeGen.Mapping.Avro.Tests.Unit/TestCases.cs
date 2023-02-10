using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.Core;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Tests.Unit;

public static class TestCases
{
    public static IEnumerable<object[]> ValidCases =>
        new List<object[]> {
            new object[] { new RecordField("NullField", new NullSchema()), Language.CSharp, Target.Model, "object?"},
            new object[] { new RecordField("NullField", new NullSchema()), Language.CSharp, Target.Entity, "object?"},
            new object[] { new RecordField("BooleanField", new BooleanSchema()), Language.CSharp, Target.Model, "bool"},
            new object[] { new RecordField("BooleanField", new BooleanSchema()), Language.CSharp, Target.Entity, "bool"},
            new object[] { new RecordField("IntField", new IntSchema()), Language.CSharp, Target.Model, "int"},
            new object[] { new RecordField("IntField", new IntSchema()), Language.CSharp, Target.Entity, "int"},
            new object[] { new RecordField("LongField", new LongSchema()), Language.CSharp, Target.Model, "long"},
            new object[] { new RecordField("LongField", new LongSchema()), Language.CSharp, Target.Entity, "long"},
            new object[] { new RecordField("FloatField", new FloatSchema()), Language.CSharp, Target.Model, "float"},
            new object[] { new RecordField("FloatField", new FloatSchema()), Language.CSharp, Target.Entity, "float"},
            new object[] { new RecordField("DoubleField", new DoubleSchema()), Language.CSharp, Target.Model, "double"},
            new object[] { new RecordField("DoubleField", new DoubleSchema()), Language.CSharp, Target.Entity, "double"},
            new object[] { new RecordField("BytesField", new BytesSchema()), Language.CSharp, Target.Model, "byte[]"},
            new object[] { new RecordField("BytesField", new BytesSchema()), Language.CSharp, Target.Entity, "byte[]"},
            new object[] { new RecordField("StringField", new StringSchema()), Language.CSharp, Target.Model, "string"},
            new object[] { new RecordField("StringField", new StringSchema()), Language.CSharp, Target.Entity, "string"},
            new object[] { new RecordField("EnumField", new EnumSchema("TestEnum")), Language.CSharp, Target.Model, "TestEnum"},
            new object[] { new RecordField("EnumField", new EnumSchema("TestEnum")), Language.CSharp, Target.Entity, "TestEnum"},
            new object[] { new RecordField("RecordField", new RecordSchema("TestRecord")), Language.CSharp, Target.Model, "TestRecord"},
            new object[] { new RecordField("RecordField", new RecordSchema("TestRecord")), Language.CSharp, Target.Entity, "TestRecordEntity"},
            new object[] { new RecordField("StringArrayField", new ArraySchema(new StringSchema())), Language.CSharp, Target.Model, "List<string>"},
            new object[] { new RecordField("StringArrayField", new ArraySchema(new StringSchema())), Language.CSharp, Target.Entity, "List<string>"},
        };

    public static IEnumerable<object[]> InvalidCases =>
        new List<object[]>
        {
            new object [] { new RecordField("NullField", new NullSchema()), (Language)999, Target.Model},
            new object [] { new RecordField("NullField", new NullSchema()), (Language)999, Target.Entity},
            new object [] { new RecordField("BooleanField", new BooleanSchema()), (Language)999, Target.Model},
            new object [] { new RecordField("BooleanField", new BooleanSchema()), (Language)999, Target.Entity},
            new object [] { new RecordField("BytesField", new BytesSchema()), (Language)999, Target.Model},
            new object [] { new RecordField("BytesField", new BytesSchema()), (Language)999, Target.Entity},
            new object [] { new RecordField("StringArrayField", new ArraySchema(new StringSchema())), (Language)999, Target.Model},
            new object [] { new RecordField("StringArrayField", new ArraySchema(new StringSchema())), (Language)999, Target.Entity},
            new object [] { new RecordField("LogicalField", new IntSchema{ LogicalType = new DateLogicalType()}), (Language)999, Target.Model},
            new object [] { new RecordField("LogicalField", new IntSchema{ LogicalType = new DateLogicalType()}), (Language)999, Target.Entity},
            new object [] { new RecordField("LongField", new LongSchema()), (Language)999, Target.Model},
            new object [] { new RecordField("LongField", new LongSchema()), (Language)999, Target.Entity},
            new object [] { new RecordField("FloatField", new FloatSchema()), (Language)999, Target.Model},
            new object [] { new RecordField("FloatField", new FloatSchema()), (Language)999, Target.Entity},
            new object [] { new RecordField("DoubleField", new DoubleSchema()), (Language)999, Target.Model},
            new object [] { new RecordField("DoubleField", new DoubleSchema()), (Language)999, Target.Entity},
            new object [] { new RecordField("StringField", new StringSchema()), (Language)999, Target.Model},
            new object [] { new RecordField("StringField", new StringSchema()), (Language)999, Target.Entity},
            new object [] { new RecordField("EnumField", new EnumSchema("TestEnum")), (Language)999, Target.Model},
            new object [] { new RecordField("EnumField", new EnumSchema("TestEnum")), (Language)999, Target.Entity},
            new object [] { new RecordField("RecordField", new RecordSchema("TestRecord")), (Language)999, Target.Model},
            new object [] { new RecordField("RecordField", new RecordSchema("TestRecord")), (Language)999, Target.Entity},
            new object [] { new RecordField("UnsupportedField", new UnsupportedSchema()), (Language)999, Target.Model},
            new object [] { new RecordField("UnsupportedField", new UnsupportedSchema()), (Language)999, Target.Entity},
        };
}
