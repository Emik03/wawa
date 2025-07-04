// SPDX-License-Identifier: MPL-2.0
namespace wawa.Recall;

/// <summary>
/// Encapsulates a vanilla or modded selectable, and extends functionality to get or
/// mutate its inner values and events without worrying the kind of selectable it is.
/// </summary>
public sealed partial class Selected
{
    /// <summary>
    /// Gets the number of children the selectable has. Calling <see cref="ChildLength"/> is more efficient
    /// than <see cref="Children"/> then using <see cref="ReadOnlyCollection{T}.Count"/> because
    /// <see cref="Children"/> constructs a new <see cref="ReadOnlyCollection{T}"/> every time.
    /// </summary>
    [NonNegativeValue, PublicAPI]
    public int ChildLength
    {
        [Pure] get => Value is KMSelectable km && km ? km.Children.Length : ChildLengthInner(Value);
    }

    /// <summary>Gets the <see cref="Highlighted"/> for this <see cref="Selected"/>.</summary>
    [NotNull, PublicAPI]
    public Highlighted Highlighted
    {
        [Pure] get => Value is KMSelectable km && km ? km.Highlight : HighlighterInner(Value);
    }

    /// <summary>
    /// Gets the <see cref="Action"/> that is called whenever this selectable becomes the current selectable.
    /// </summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public HookDef<Action> Select
    {
        [Pure] get => field ??= new(Value, nameof(KMSelectable.OnSelect));
    }

    /// <summary>
    /// Gets the <see cref="Action"/> that is called whenever this selectable stops being the current selectable.
    /// </summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public HookDef<Action> Deselect
    {
        [Pure] get => field ??= new(Value, nameof(KMSelectable.OnDeselect));
    }

    /// <summary>
    /// Gets the <see cref="Func{TResult}"/> that is called whenever the player backs out of this
    /// selectable, an example would be zooming out of a module. Returning <see langword="true"/>
    /// backs out of the selectable and makes its parent the current, and <see langword="false"/>
    /// does not back out of the selectable and keeps the selectable as the current.
    /// </summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public HookDef<Func<bool>> Cancel
    {
        [Pure] get => field ??= new(Value, nameof(KMSelectable.OnCancel), converter: False);
    }

    /// <summary>
    /// Gets the <see cref="Func{TResult}"/> that is called whenever the player interacts with
    /// this selectable. Done on button down. Returning <see langword="true"/> makes the selectable
    /// behave as a module with children, and <see langword="false"/> as a button with no children.
    /// </summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public HookDef<Func<bool>> Interact
    {
        [Pure] get => field ??= new(Value, nameof(KMSelectable.OnInteract), converter: InteractHandler);
    }

    /// <summary>
    /// Gets the <see cref="Action"/> that is called whenever the player is interacting
    /// with this selectable and releases the mouse or controller button.
    /// </summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public HookDef<Action> InteractEnded
    {
        [Pure] get => field ??= new(Value, nameof(KMSelectable.OnInteractEnded));
    }

    /// <summary>Gets the <see cref="Action"/> that is called whenever the highlight is turned on.</summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public HookDef<Action> Highlight
    {
        [Pure] get => field ??= new(Value, nameof(KMSelectable.OnHighlight));
    }

    /// <summary>Gets the <see cref="Action"/> that is called whenever the highlight is turned off.</summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public HookDef<Action> HighlightEnded
    {
        [Pure] get => field ??= new(Value, nameof(KMSelectable.OnHighlightEnded));
    }

    /// <summary>
    /// Gets the <see cref="Action"/> that is called whenever the module is focused,
    /// this is when it is interacted with from the bomb face level and this module's children can be selected.
    /// </summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public HookDef<Action> Focus
    {
        [Pure] get => field ??= new(Value, nameof(KMSelectable.OnFocus));
    }

    /// <summary>
    /// Gets the <see cref="Action"/> that is called whenever the module is defocused,
    /// this is when a different selectable becomes the focus or the module has been backed out of.
    /// </summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public HookDef<Action> Defocus
    {
        [Pure]
        get =>
            field ??= new(
                Value,
                nameof(KMSelectable.OnDefocus),
                wrapper: IsKtane || IsRewritten ? DefocusFix : Lot<Action>.Id
            );
    }

    /// <summary>
    /// Gets the <see cref="Action"/> that is called whenever the player
    /// pulls selection stick left while this selectable is focused.
    /// </summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public HookDef<Action> Left
    {
        [Pure] get => field ??= new(Value, nameof(KMSelectable.OnLeft));
    }

    /// <summary>
    /// Gets the <see cref="Action"/> that is called whenever player
    /// pulls selection stick right while this selectable is focused.
    /// </summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public HookDef<Action> Right
    {
        [Pure] get => field ??= new(Value, nameof(KMSelectable.OnRight));
    }

    /// <summary>
    /// Gets the <see cref="Action"/> that when called, performs an interaction punch
    /// or bomb shake with the impact level based on the parameter passed in. Modded Only.
    /// </summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public HookMay<Action<float>> InteractionPunch
    {
        [Pure]
        get => field ??= new(Value, nameof(KMSelectable.OnInteractionPunch), converter: Invoke<float>);
    }

    /// <summary>
    /// Gets the <see cref="Action"/> that when called, updates the list of children,
    /// with the parameter being the <see cref="KMSelectable"/> to select. Modded Only.
    /// </summary>
    [CLSCompliant(false), NotNull, PublicAPI]
    [field: CanBeNull]
    public HookMay<Action<KMSelectable>> UpdateChildren
    {
        [Pure]
        get => field ??= new(Value, nameof(KMSelectable.OnUpdateChildren), converter: Invoke<KMSelectable>);
    }

    /// <summary>
    /// Gets the encapsulated <see cref="KMSelectable"/> from this instance
    /// as <see cref="Maybe{T}"/> due to ambiguity in this value being set.
    /// </summary>
    [CLSCompliant(false), PublicAPI]
    public Maybe<KMSelectable> Modded
    {
        [Pure] get => Value as KMSelectable;
    }

    /// <summary>Gets the encapsulated <c>Selectable</c> from this instance.</summary>
    [CLSCompliant(false), PublicAPI]
    public Maybe<MonoBehaviour> Vanilla
    {
#pragma warning disable CS0184
        [Pure] get => Value is KMSelectable ? null : Value;
#pragma warning restore CS0184
    }

    /// <summary>Gets the parent of this selectable.</summary>
    [PublicAPI]
    public Maybe<Selected> Parent
    {
        [Pure] get => Value is KMSelectable km && km ? km.Parent is var p && p ? new(p) : null : ParentInner(Value);
    }

    /// <summary>Gets a value indicating whether gamepad selection should wrap around left/right.</summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public PropDef<bool> AllowWrapX
    {
        [Pure] get => field ??= new(Value, nameof(KMSelectable.AllowSelectionWrapX));
    }

    /// <summary>Gets a value indicating whether gamepad selection should wrap around up/down.</summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public PropDef<bool> AllowWrapY
    {
        [Pure] get => field ??= new(Value, nameof(KMSelectable.AllowSelectionWrapY));
    }

    /// <summary>
    /// Gets a value indicating whether it forces highlight to be selection highlight,
    /// this is yellow in game. Should be used when interaction will drill down to child selectables.
    /// </summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public PropDef<bool> ForceSelectionHighlight
    {
        [Pure] get => field ??= new(Value, nameof(KMSelectable.ForceSelectionHighlight));
    }

    /// <summary>
    /// Gets a value indicating whether it forces highlight to be interaction highlight,
    /// this is red in game. Should be used when interaction will trigger a behavior.
    /// </summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public PropDef<bool> ForceInteractionHighlight
    {
        [Pure] get => field ??= new(Value, nameof(KMSelectable.ForceInteractionHighlight));
    }

    /// <summary>
    /// Gets a value indicating whether this selectable is essentially a container, currently used for bomb faces.
    /// </summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public PropDef<bool> IsPassThrough
    {
        [Pure] get => field ??= new(Value, nameof(KMSelectable.IsPassThrough));
    }

    /// <summary>Gets the number of selectables per row for gamepad controls.</summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public PropDef<int> ChildRowLength
    {
        [Pure] get => field ??= new(Value, nameof(KMSelectable.ChildRowLength));
    }

    /// <summary>Gets the particular child as the default index for gamepad controls.</summary>
    [NotNull, PublicAPI]
    [field: CanBeNull]
    public PropDef<int> DefaultIndex
    {
        [Pure] get => field ??= new(Value, nameof(KMSelectable.DefaultSelectableIndex));
    }

    /// <summary>Gets the interaction colliders for mouse other than the highlight. Modded Only.</summary>
    [CLSCompliant(false), NotNull, PublicAPI]
    [field: CanBeNull]
    public PropMay<Collider[]> Colliders
    {
        [Pure] get => field ??= new(Value, nameof(KMSelectable.SelectableColliders));
    }

    /// <summary>
    /// Gets the scaling. A non-zero value for a custom highlight scale. Otherwise,
    /// leave it at <see cref="Vector3.zero"/> for default scaling. Vanilla Only.
    /// </summary>
    [CLSCompliant(false), NotNull, PublicAPI]
    [field: CanBeNull]
    public PropMay<Vector3> Scale
    {
        [Pure] get => field ??= new(Value, nameof(Selectable.HighlightScale));
    }

    /// <summary>
    /// Gets the list of child selectables. Order is important as it is treated
    /// as a grid with row length defined by <see cref="ChildRowLength"/>.
    /// </summary>
    [NotNull, PublicAPI]
    public ReadOnlyCollection<Maybe<Selected>> Children
    {
        [Pure] get => Array.AsReadOnly(Value is KMSelectable km ? ChildrenOuter(km) : ChildrenInner(Value));
    }

    /// <summary>Gets a value indicating whether this instance contains a modded selectable.</summary>
    [PublicAPI]
    public bool IsModded
    {
#pragma warning disable CS0184
        [Pure] get => Value is KMSelectable;
#pragma warning restore CS0184
    }

    /// <summary>Gets a value indicating whether this instance contains a vanilla selectable.</summary>
    [PublicAPI]
    public bool IsVanilla
    {
        [Pure] get => !IsModded;
    }

    [NonNegativeValue]
    static int ChildLengthInner([NotNull] in object component) => ((Selectable)component).Children.Length;

    [NotNull]
    static Action DefocusFix([NotNull] Action onDefocus)
    {
        var call = true;

        return () =>
        {
            call ^= true;

            if (call)
                onDefocus();
        };
    }

    [NotNull]
    static Highlighted HighlighterInner([NotNull] in object m) => new(((Selectable)m).Highlight.Core());

    static Maybe<Selected> ParentInner([NotNull] in object m) =>
        ((Selectable)m).Parent is var selectable && selectable ? new Selected(selectable.Core()) : null;

    [NotNull]
    static Maybe<Selected>[] ChildrenInner([NotNull] in object m)
    {
        var children = ((Selectable)m).Children;
        var modules = new Maybe<Selected>[children.Length];

        for (var i = 0; i < children.Length; i++)
            modules[i] = children[i] is var selectable && selectable ? new Selected(selectable.Core()) : null;

        return modules;
    }

    [NotNull]
    static Maybe<Selected>[] ChildrenOuter([NotNull] in KMSelectable v)
    {
        var modules = new Maybe<Selected>[v.Children.Length];

        for (var i = 0; i < v.Children.Length; i++)
            modules[i] = v.Children[i] is var selectable && selectable ? new Selected(selectable) : null;

        return modules;
    }

    [NotNull, Pure]
    Func<bool> InteractHandler([NotNull] Action a) =>
        () =>
        {
            a();
            return ChildLength > 0;
        };
}
