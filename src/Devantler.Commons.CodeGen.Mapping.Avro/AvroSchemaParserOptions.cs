using Devantler.Commons.CodeGen.Mapping.Core;

namespace Devantler.Commons.CodeGen.Mapping.Avro;

/// <summary>
/// A class containing options for the <see cref="AvroSchemaParser"/>.
/// </summary>
public class AvroSchemaParserOptions : IParserOptions
{
    /// <summary>
    /// Gets or sets the record suffix.
    /// </summary>
    public string RecordSuffix { get; set; } = string.Empty;
}
