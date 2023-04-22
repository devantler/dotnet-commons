using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.Core;

namespace Devantler.Commons.CodeGen.Mapping.Avro.Tests.Unit;

public class AvroSchemaTypeParserTests
{
    [Theory, MemberData(nameof(TestCases.ValidCases), MemberType = typeof(TestCases))]
    public void Parse_GivenValidFieldAndLanguage_ReturnsParsedValue(RecordField field, Language language, string expected, AvroSchemaParserOptions? options = default)
    {
        // Arrange
        var parser = new AvroSchemaParser();

        // Act
        string actual = parser.Parse(field.Type, language, x => x.RecordSuffix = options?.RecordSuffix ?? string.Empty);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory, MemberData(nameof(TestCases.InvalidCases), MemberType = typeof(TestCases))]
    public void Parse_GivenInvalidFieldOrLanguage_ThrowsNotSupportedException(RecordField field, Language language)
    {
        // Arrange
        var parser = new AvroSchemaParser();

        // Act
        void actual() => parser.Parse(field.Type, language);

        // Assert
        _ = Assert.Throws<NotSupportedException>(actual);
    }
}
