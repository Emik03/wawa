// SPDX-License-Identifier: MPL-2.0
namespace wawa.Recall;

/// <summary>
/// Encapsulates a vanilla or modded highlight, and extends functionality to get or
/// mutate its inner values and events without worrying the kind of highlight it is.
/// </summary>
public sealed partial class Highlighted
{
    /// <summary>Gets a value indicating whether this instance contains a modded highlightable.</summary>
    [PublicAPI]
    public bool IsModded
    {
#pragma warning disable CS0184
        [Pure] get => Value is KMHighlightable;
#pragma warning restore CS0184
    }

    /// <summary>Gets a value indicating whether this instance contains a vanilla highlightable.</summary>
    [PublicAPI]
    public bool IsVanilla
    {
        [Pure] get => !IsModded;
    }

    /// <summary>Gets the encapsulated <see cref="KMHighlightable"/> from this instance.</summary>
    [CLSCompliant(false), PublicAPI]
    public Maybe<KMHighlightable> Modded
    {
        [Pure] get => Value as KMHighlightable;
    }

    /// <summary>Gets the encapsulated <c>Highlightable</c> from this instance.</summary>
    [CLSCompliant(false), PublicAPI]
    public Maybe<MonoBehaviour> Vanilla
    {
#pragma warning disable CS0184
        [Pure] get => Value is KMHighlightable ? null : Value;
#pragma warning restore CS0184
    }

    /// <summary>Gets the outline thickness amount.</summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public PropDef<float> Outline
    {
        [Pure] get => field ??= new(Value, nameof(KMHighlightable.OutlineAmount));
    }

    /// <summary>
    /// Gets the scaling. A non-zero value for a custom highlight scale. Otherwise,
    /// leave it at <see cref="Vector3.zero"/> for default scaling.
    /// </summary>
    [CLSCompliant(false), NotNull, PublicAPI]
    [field: CanBeNull]
    public PropDef<Vector3> Scale
    {
        [Pure] get => field ??= new(Value, nameof(KMHighlightable.HighlightScale));
    }

    /// <summary>
    /// Gets the value that if true, the highlight would only activate directly: it
    /// will not be activated when a parent highlight is activated. Vanilla Only.
    /// </summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public PropMay<bool> Ignore
    {
        [Pure] get => field ??= new(Value, nameof(Highlightable.IgnoreAsChildHighlight));
    }

    /// <summary>
    /// Gets the value that if true, the highlight would only activate directly: it will not
    /// be activated when a parent highlight is activated. Vanilla Only.
    /// </summary>
    [CLSCompliant(false), NotNull, PublicAPI]
    [field: CanBeNull]
    public PropMay<Material> Override
    {
        [Pure] get => field ??= new(Value, nameof(Highlightable.MaterialOverride));
    }
}
