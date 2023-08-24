// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Callbacks;

/// <summary>Implementations for <see cref="Selected"/>.</summary>
[PublicAPI]
public static class SelectedCore
{
    /// <summary>
    /// Gets the <see cref="Entity"/> of this <see cref="Selected"/>.
    /// An empty value is given if there is no attached <see cref="Entity"/> on the <see cref="Selected"/>.
    /// </summary>
    /// <param name="that">This instance of <see cref="Selected"/>.</param>
    /// <returns>
    /// A <see cref="Maybe{T}"/>, consisting of either a <see cref="Entity"/>
    /// that is attached to this instance, or <see langword="default"/>.
    /// </returns>
    [MustUseReturnValue, PublicAPI]
    public static Maybe<Entity> ToEntity(this Selected that) => Entity.FromComponent(that.Value);

    /// <summary>Creates an instance of <see cref="Entity"/> where <see cref="Entity.Solvable"/> is set.</summary>
    /// <param name="that">The <see cref="KMBombModule"/> to pass in <see cref="Entity"/>.</param>
    /// <returns>A new instance of <see cref="Entity"/> which encapsulates <paramref name="that"/>.</returns>
    [CLSCompliant(false), NotNull, PublicAPI, Pure]
    public static Selected AsSelectable(this KMSelectable that) => new(that);

    /// <summary>Adds the parameter values to the corresponding hooks, when applicable.</summary>
    /// <param name="that">This instance of <see cref="Selected"/>.</param>
    /// <param name="onCancel">Invoked when the player backs out of the selectable.</param>
    /// <param name="onDefocus">Invoked when the selectable is defocused.</param>
    /// <param name="onDeselect">Invoked when this stops being the current selectable.</param>
    /// <param name="onFocus">Invoked when the selectable is focused.</param>
    /// <param name="onHighlight">Invoked whenever the highlight is turned on.</param>
    /// <param name="onHighlightEnded">Invoked whenever the highlight is turned off.</param>
    /// <param name="onInteract">Invoked when the player interacts with the selectable.</param>
    /// <param name="onInteractEnded">Invoked when the player releases the mouse or controller button.</param>
    /// <param name="onLeft">Invoked when the player pulls the selection stick left while selected.</param>
    /// <param name="onRight">Invoked when the player pulls the selection stick right while selected.</param>
    /// <param name="onSelect">Invoked when this becomes the current selectable.</param>
    /// <param name="onUpdateChildren">Invoked when the list of children are updated.</param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    // ReSharper disable FunctionComplexityOverflow
    [NotNull, PublicAPI]
    public static Selected Add(
        [NotNull] this Selected that,
        [AllowNull, CanBeNull] Action onCancel = null,
        [AllowNull, CanBeNull] Action onDefocus = null,
        [AllowNull, CanBeNull] Action onDeselect = null,
        [AllowNull, CanBeNull] Action onFocus = null,
        [AllowNull, CanBeNull] Action onHighlight = null,
        [AllowNull, CanBeNull] Action onHighlightEnded = null,
        [AllowNull, CanBeNull] Action onInteract = null,
        [AllowNull, CanBeNull] Action onInteractEnded = null,
        [AllowNull, CanBeNull] Action onLeft = null,
        [AllowNull, CanBeNull] Action onRight = null,
        [AllowNull, CanBeNull] Action onSelect = null,
        [AllowNull, CanBeNull] Action onUpdateChildren = null
    )
    {
        that.Left.Add(onLeft);
        that.Focus.Add(onFocus);
        that.Right.Add(onRight);
        that.Cancel.Add(onCancel);
        that.Select.Add(onSelect);
        that.Defocus.Add(onDefocus);
        that.Deselect.Add(onDeselect);
        that.Interact.Add(onInteract);
        that.Highlight.Add(onHighlight);
        that.InteractEnded.Add(onInteractEnded);
        that.HighlightEnded.Add(onHighlightEnded);
        that.UpdateChildren.TryAdd(onUpdateChildren);
        return that;
    }

    /// <summary>Removes the parameter values to the corresponding hooks, when applicable.</summary>
    /// <inheritdoc cref="Add(Selected, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action)"/>
    [NotNull, PublicAPI]
    public static Selected Remove(
        [NotNull] this Selected that,
        [AllowNull, CanBeNull] Action onCancel = null,
        [AllowNull, CanBeNull] Action onDefocus = null,
        [AllowNull, CanBeNull] Action onDeselect = null,
        [AllowNull, CanBeNull] Action onFocus = null,
        [AllowNull, CanBeNull] Action onHighlight = null,
        [AllowNull, CanBeNull] Action onHighlightEnded = null,
        [AllowNull, CanBeNull] Action onInteract = null,
        [AllowNull, CanBeNull] Action onInteractEnded = null,
        [AllowNull, CanBeNull] Action onLeft = null,
        [AllowNull, CanBeNull] Action onRight = null,
        [AllowNull, CanBeNull] Action onSelect = null,
        [AllowNull, CanBeNull] Action onUpdateChildren = null
    )
    {
        that.Left.Remove(onLeft);
        that.Focus.Remove(onFocus);
        that.Right.Remove(onRight);
        that.Cancel.Remove(onCancel);
        that.Select.Remove(onSelect);
        that.Defocus.Remove(onDefocus);
        that.Deselect.Remove(onDeselect);
        that.Interact.Remove(onInteract);
        that.Highlight.Remove(onHighlight);
        that.InteractEnded.Remove(onInteractEnded);
        that.HighlightEnded.Remove(onHighlightEnded);
        that.UpdateChildren.TryRemove(onUpdateChildren);
        return that;
    }

    /// <summary>Sets the parameter values to the corresponding hooks, when applicable.</summary>
    /// <inheritdoc cref="Add(Selected, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action, Action)"/>
    [NotNull, PublicAPI]
    public static Selected Set(
        [NotNull] this Selected that,
        [AllowNull, CanBeNull] Action onCancel = null,
        [AllowNull, CanBeNull] Action onDefocus = null,
        [AllowNull, CanBeNull] Action onDeselect = null,
        [AllowNull, CanBeNull] Action onFocus = null,
        [AllowNull, CanBeNull] Action onHighlight = null,
        [AllowNull, CanBeNull] Action onHighlightEnded = null,
        [AllowNull, CanBeNull] Action onInteract = null,
        [AllowNull, CanBeNull] Action onInteractEnded = null,
        [AllowNull, CanBeNull] Action onLeft = null,
        [AllowNull, CanBeNull] Action onRight = null,
        [AllowNull, CanBeNull] Action onSelect = null,
        [AllowNull, CanBeNull] Action onUpdateChildren = null
    )
    {
        that.Left.Set(onLeft);
        that.Focus.Set(onFocus);
        that.Right.Set(onRight);
        that.Cancel.Set(onCancel);
        that.Select.Set(onSelect);
        that.Defocus.Set(onDefocus);
        that.Deselect.Set(onDeselect);
        that.Interact.Set(onInteract);
        that.Highlight.Set(onHighlight);
        that.InteractEnded.Set(onInteractEnded);
        that.HighlightEnded.Set(onHighlightEnded);
        that.UpdateChildren.TrySet(onUpdateChildren);
        return that;
    }

    /// <summary>Removes the parameter values to the corresponding hooks, when applicable.</summary>
    /// <param name="that">This instance of <see cref="Selected"/>.</param>
    /// <param name="onCancel">Invoked when the player backs out of the selectable.</param>
    /// <param name="onInteract">Invoked when the player interacts with the selectable.</param>
    /// <param name="onUpdateChildren">Invoked when the list of children are updated.</param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    // ReSharper disable FunctionComplexityOverflow
    [CLSCompliant(false), NotNull, PublicAPI]
    public static Selected Add(
        [NotNull] this Selected that,
        [AllowNull, CanBeNull] Func<bool> onCancel = null,
        [AllowNull, CanBeNull] Func<bool> onInteract = null,
        [AllowNull, CanBeNull] Action<KMSelectable> onUpdateChildren = null
    )
    {
        that.Cancel.Add(onCancel);
        that.Interact.Add(onInteract);
        that.UpdateChildren.TryAdd(onUpdateChildren);
        return that;
    }

    /// <summary>Removes the parameter values to the corresponding hooks, when applicable.</summary>
    /// <inheritdoc cref="Add(Selected, Func{bool}, Func{bool}, Action{KMSelectable})"/>
    [CLSCompliant(false), NotNull, PublicAPI]
    public static Selected Remove(
        [NotNull] this Selected that,
        [AllowNull, CanBeNull] Func<bool> cancel = null,
        [AllowNull, CanBeNull] Func<bool> interact = null,
        [AllowNull, CanBeNull] Action<KMSelectable> updateChildren = null
    )
    {
        that.Cancel.Remove(cancel);
        that.Interact.Remove(interact);
        that.UpdateChildren.TryRemove(updateChildren);
        return that;
    }

    /// <summary>Removes the parameter values to the corresponding hooks, when applicable.</summary>
    /// <inheritdoc cref="Add(Selected, Func{bool}, Func{bool}, Action{KMSelectable})"/>
    [CLSCompliant(false), NotNull, PublicAPI]
    public static Selected Set(
        [NotNull] Selected that,
        [AllowNull, CanBeNull] Func<bool> cancel = null,
        [AllowNull, CanBeNull] Func<bool> interact = null,
        [AllowNull, CanBeNull] Action<KMSelectable> updateChildren = null
    )
    {
        that.Cancel.Set(cancel);
        that.Interact.Set(interact);
        that.UpdateChildren.TrySet(updateChildren);
        return that;
    }

    /// <summary>Hooks the logger to each instance.</summary>
    /// <remarks><para>
    /// Since the logger is implicitly created within this function, the logging cannot easily
    /// be reversed without using the nuclear option <see cref="Generator.Clear{T}(Hook{T})"/>.
    /// </para></remarks>
    /// <param name="that">This instance of <see cref="Selected"/>.</param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [NotNull, PublicAPI]
    public static Selected Log([NotNull] this Selected that) =>
        that.Add(
            that.Logger(nameof(Selected.Cancel)),
            that.Logger(nameof(Selected.Defocus)),
            that.Logger(nameof(Selected.Deselect)),
            that.Logger(nameof(Selected.Focus)),
            that.Logger(nameof(Selected.Highlight)),
            that.Logger(nameof(Selected.HighlightEnded)),
            that.Logger(nameof(Selected.Interact)),
            that.Logger(nameof(Selected.InteractEnded)),
            that.Logger(nameof(Selected.Left)),
            that.Logger(nameof(Selected.Right)),
            that.Logger(nameof(Selected.UpdateChildren))
        );

    /// <inheritdoc cref="Log"/>
    /// <typeparam name="T">The <see cref="IEnumerable{T}"/> of <see cref="Selected"/> instances to hook.</typeparam>
    [NotNull, PublicAPI]
    public static T Log<T>([NotNull] this T that)
        where T : IEnumerable<Selected>
    {
        foreach (var next in that)
            next.Log();

        return that;
    }

    /// <summary>Creates an <see cref="ReadOnlyCollection{T}"/> where each element has been converted.</summary>
    /// <param name="that">The collection.</param>
    /// <returns>An immutable array.</returns>
    [MustUseReturnValue, NotNull, PublicAPI]
    public static ReadOnlyCollection<Maybe<Entity>>
        ToEntities([AllowNull, CanBeNull] this IEnumerable<Selected> that) =>
        that is null ? Cache<Maybe<Entity>>.Empty : new(that.Select(ToEntity).ToList());

    /// <summary>Creates an <see cref="ReadOnlyCollection{T}"/> where each element has been converted.</summary>
    /// <param name="that">The collection.</param>
    /// <returns>An immutable array.</returns>
    [CLSCompliant(false), NotNull, PublicAPI, Pure]
    public static ReadOnlyCollection<Selected> ToSelectables(
        [AllowNull, CanBeNull] this IEnumerable<KMSelectable> that
    ) =>
        that is null ? Cache<Selected>.Empty : new(that.Select(AsSelectable).ToList());
}
