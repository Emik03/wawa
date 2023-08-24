// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Callbacks;

/// <summary>
/// Encapsulates a vanilla or modded highlight, and extends functionality to get or
/// mutate its inner values and events without worrying the kind of highlight it is.
/// </summary>
public sealed partial class Highlighted
{
    [CanBeNull]
    PropDef<float> _outline;

    [CanBeNull]
    PropDef<Vector3> _scale;

    /// <summary>Gets a value indicating whether this instance contains a modded highlightable.</summary>
    [PublicAPI]
    public bool IsModded
    {
        [Pure] get => Value.Core() is KMHighlightable;
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

    /// <summary>
    /// Gets the encapsulated Highlightable from this instance as <see cref="Maybe{T}"/> due to ambiguity in this value being set.
    /// </summary>
    [CLSCompliant(false), PublicAPI]
    public Maybe<MonoBehaviour> Vanilla
    {
        [Pure] get => Value.Core() is KMHighlightable ? default : Value;
    }

    /// <summary>Gets the outline thickness amount.</summary>
    [NotNull, PublicAPI]
    public PropDef<float> Outline
    {
        [Pure] get => _outline ??= new(Value, nameof(KMHighlightable.OutlineAmount));
    }

    /// <summary>
    /// Gets the scaling. A non-zero value for a custom highlight scale.
    /// Otherwise, leave it at <see cref="Vector3.zero"/> for default scaling.
    /// </summary>
    [CLSCompliant(false), NotNull, PublicAPI]
    public PropDef<Vector3> Scale
    {
        [Pure] get => _scale ??= new(Value, nameof(KMHighlightable.HighlightScale));
    }
}
