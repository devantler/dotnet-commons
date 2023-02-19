namespace Devantler.Commons.CodeGen.Core.Model;

/// <summary>
///     An enum representing the visibility of a unit.
/// </summary>
public enum Visibility
{
    /// <summary>
    ///     A unit that is visible to all.
    /// </summary>
    Public = 0,

    /// <summary>
    /// A unit that is visible to the declaring type and its descendants.
    /// </summary>
    Protected = 1,

    /// <summary>
    ///     A unit that is only visible to the declaring type.
    /// </summary>
    Private = 2
}
