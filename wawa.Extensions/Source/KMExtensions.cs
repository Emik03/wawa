// SPDX-License-Identifier: MPL-2.0
namespace wawa.Extensions;

using static KMAudio;
using State = KMGameInfo.State;

/// <summary>Contains static methods able to be accessed from anywhere within this library.</summary>
[CLSCompliant(false), PublicAPI]
public static class KMExtensions
{
    [ProvidesContext]
    static readonly bool
        s_isKtane = Application.productName is "Keep Talking and Nobody Explodes" && !Application.isEditor,
        s_isKtaneOrRewritten = s_isKtane || Application.productName is not "Keep Talking and Nobody Explodes";

    /// <summary>
    /// Adds the specified delegate parameter if not <see langword="null"/> into the <see cref="KMAudioRef"/>.
    /// </summary>
    /// <param name="audio">
    /// The <see cref="IEnumerable{T}"/> of <see cref="KMAudioRef"/>
    /// instances to invoke <see cref="KMAudioRef.StopSound"/>.
    /// </param>
    /// <param name="onStopSound">Called when the sound is prematurely stopped.</param>
    /// <returns>The parameter <paramref name="audio"/>.</returns>
    [NotNull, PublicAPI]
    public static KMAudioRef Add([NotNull] this KMAudioRef audio, [NotNull] Action onStopSound)
    {
        onStopSound.Add(ref audio.StopSound);
        return audio;
    }

    /// <summary>
    /// Sets the specified delegate parameter if not <see langword="null"/> into the <see cref="KMAudioRef"/>.
    /// </summary>
    /// <param name="audio">
    /// The <see cref="IEnumerable{T}"/> of <see cref="KMAudioRef"/>
    /// instances to invoke <see cref="KMAudioRef.StopSound"/>.
    /// </param>
    /// <param name="onStopSound">Called when the sound is prematurely stopped.</param>
    /// <returns>The parameter <paramref name="audio"/>.</returns>
    [NotNull, PublicAPI]
    public static KMAudioRef Set([NotNull] this KMAudioRef audio, [NotNull] Action onStopSound)
    {
        onStopSound.Set(out audio.StopSound);
        return audio;
    }

    /// <summary>Sets specified delegate parameters into the <see cref="KMSelectable"/>.</summary>
    /// <param name="info">The <see cref="KMBombInfo"/> to hook.</param>
    /// <param name="onBombExploded">Called when the bomb explodes.</param>
    /// <param name="onBombSolved">Called when the bomb is defused.</param>
    /// <returns>The parameter <paramref name="info"/>.</returns>
    [NotNull, PublicAPI]
    public static KMBombInfo Add(
        [NotNull] this KMBombInfo info,
        [AllowNull, CanBeNull] Action onBombExploded = null,
        [AllowNull, CanBeNull] Action onBombSolved = null
    )
    {
        onBombExploded?.Add(ref info.OnBombExploded);
        onBombSolved?.Add(ref info.OnBombSolved);
        return info;
    }

    /// <summary>Sets specified delegate parameters into the <see cref="KMSelectable"/>.</summary>
    /// <param name="info">The <see cref="KMBombInfo"/> to hook.</param>
    /// <param name="onBombExploded">Called when the bomb explodes.</param>
    /// <param name="onBombSolved">Called when the bomb is defused.</param>
    /// <returns>The parameter <paramref name="info"/>.</returns>
    [NotNull, PublicAPI]
    public static KMBombInfo Set(
        [NotNull] this KMBombInfo info,
        [AllowNull, CanBeNull] Action onBombExploded = null,
        [AllowNull, CanBeNull] Action onBombSolved = null
    )
    {
        onBombExploded?.Set(out info.OnBombExploded);
        onBombSolved?.Set(out info.OnBombSolved);
        return info;
    }

    /// <summary>Sets specified delegate parameters into the <see cref="KMBombModule"/>.</summary>
    /// <param name="module">The <see cref="KMBombModule"/> to hook.</param>
    /// <param name="onActivate">Called when the lights turn on.</param>
    /// <param name="onPass">Called when the module is solved.</param>
    /// <param name="onStrike">Called when the module strikes.</param>
    /// <returns>The parameter <paramref name="module"/>.</returns>
    [NotNull, PublicAPI]
    public static KMBombModule Add(
        [NotNull] this KMBombModule module,
        [AllowNull, CanBeNull] Action onActivate = null,
        [AllowNull, CanBeNull] Action onPass = null,
        [AllowNull, CanBeNull] Action onStrike = null
    )
    {
        onActivate?.Add(ref module.OnActivate);
        onPass?.ToFunc(false).Add(ref module.OnPass);
        onStrike?.ToFunc(false).Add(ref module.OnStrike);
        return module;
    }

    /// <summary>Sets specified delegate parameters into the <see cref="KMBombModule"/>.</summary>
    /// <param name="module">The <see cref="KMBombModule"/> to hook.</param>
    /// <param name="onActivate">Called when the lights turn on.</param>
    /// <param name="onPass">Called when the module is solved.</param>
    /// <param name="onStrike">Called when the module strikes.</param>
    /// <returns>The parameter <paramref name="module"/>.</returns>
    [NotNull, PublicAPI]
    public static KMBombModule Set(
        [NotNull] this KMBombModule module,
        [AllowNull, CanBeNull] Action onActivate = null,
        [AllowNull, CanBeNull] Action onPass = null,
        [AllowNull, CanBeNull] Action onStrike = null
    )
    {
        onActivate?.Set(out module.OnActivate);
        onPass?.ToFunc(false).Set(out module.OnPass);
        onStrike?.ToFunc(false).Set(out module.OnStrike);
        return module;
    }

    /// <summary>Sets specified delegate parameters into the <see cref="KMGameInfo"/>.</summary>
    /// <param name="game">The <see cref="KMGameInfo"/> to hook.</param>
    /// <param name="onStateChange">Called when the state of the game changes.</param>
    /// <param name="onAlarmClockChange">
    /// Called when the alarm clock changes state, and passes in whether it's on or off.
    /// </param>
    /// <param name="onLightsChange">Called when the lights change state, and passes in whether it's on or off.</param>
    /// <returns>The parameter <paramref name="game"/>.</returns>
    [NotNull, PublicAPI]
    public static KMGameInfo Add(
        [NotNull] this KMGameInfo game,
        [AllowNull, CanBeNull] Action onStateChange = null,
        [AllowNull, CanBeNull] Action onAlarmClockChange = null,
        [AllowNull, CanBeNull] Action onLightsChange = null
    )
    {
        onStateChange?.ToAction<State>().Add(ref game.OnStateChange);
        onAlarmClockChange?.ToAction<bool>().Add(ref game.OnAlarmClockChange);
        onLightsChange?.ToAction<bool>().Add(ref game.OnLightsChange);
        return game;
    }

    /// <summary>Sets specified delegate parameters into the <see cref="KMGameInfo"/>.</summary>
    /// <param name="game">The <see cref="KMGameInfo"/> to hook.</param>
    /// <param name="onStateChange">Called when the state of the game changes.</param>
    /// <param name="onAlarmClockChange">
    /// Called when the alarm clock changes state, and passes in whether it's on or off.
    /// </param>
    /// <param name="onLightsChange">Called when the lights change state, and passes in whether it's on or off.</param>
    /// <returns>The parameter <paramref name="game"/>.</returns>
    [NotNull, PublicAPI]
    public static KMGameInfo Set(
        [NotNull] this KMGameInfo game,
        [AllowNull, CanBeNull] Action onStateChange = null,
        [AllowNull, CanBeNull] Action onAlarmClockChange = null,
        [AllowNull, CanBeNull] Action onLightsChange = null
    )
    {
        onStateChange?.ToAction<State>().Set(out game.OnStateChange);
        onAlarmClockChange?.ToAction<bool>().Set(out game.OnAlarmClockChange);
        onLightsChange?.ToAction<bool>().Set(out game.OnLightsChange);
        return game;
    }

    /// <summary>Sets specified delegate parameters into the <see cref="KMNeedyModule"/>.</summary>
    /// <param name="needy">The <see cref="KMNeedyModule"/> to hook.</param>
    /// <param name="onActivate">Called when the lights turn on.</param>
    /// <param name="onNeedyActivation">Called when the needy activates.</param>
    /// <param name="onNeedyDeactivation">Called when the needy deactivates.</param>
    /// <param name="onPass">Called when the needy is solved.</param>
    /// <param name="onStrike">Called when the needy strikes.</param>
    /// <param name="onTimerExpired">Called when the timer runs out of time.</param>
    /// <returns>The parameter <paramref name="needy"/>.</returns>
    [NotNull, PublicAPI]
    public static KMNeedyModule Add(
        [NotNull] this KMNeedyModule needy,
        [AllowNull, CanBeNull] Action onActivate = null,
        [AllowNull, CanBeNull] Action onNeedyActivation = null,
        [AllowNull, CanBeNull] Action onNeedyDeactivation = null,
        [AllowNull, CanBeNull] Action onPass = null,
        [AllowNull, CanBeNull] Action onStrike = null,
        [AllowNull, CanBeNull] Action onTimerExpired = null
    )
    {
        onActivate?.Add(ref needy.OnActivate);
        onNeedyActivation?.Add(ref needy.OnNeedyActivation);
        onNeedyDeactivation?.Add(ref needy.OnNeedyDeactivation);
        onTimerExpired?.Add(ref needy.OnTimerExpired);
        onPass?.ToFunc(false).Add(ref needy.OnPass);
        onStrike?.ToFunc(false).Add(ref needy.OnStrike);
        return needy;
    }

    /// <summary>Sets specified delegate parameters into the <see cref="KMNeedyModule"/>.</summary>
    /// <param name="needy">The <see cref="KMNeedyModule"/> to hook.</param>
    /// <param name="onActivate">Called when the lights turn on.</param>
    /// <param name="onNeedyActivation">Called when the needy activates.</param>
    /// <param name="onNeedyDeactivation">Called when the needy deactivates.</param>
    /// <param name="onPass">Called when the needy is solved.</param>
    /// <param name="onStrike">Called when the needy strikes.</param>
    /// <param name="onTimerExpired">Called when the timer runs out of time.</param>
    /// <returns>The parameter <paramref name="needy"/>.</returns>
    [NotNull, PublicAPI]
    public static KMNeedyModule Set(
        [NotNull] this KMNeedyModule needy,
        [AllowNull, CanBeNull] Action onActivate = null,
        [AllowNull, CanBeNull] Action onNeedyActivation = null,
        [AllowNull, CanBeNull] Action onNeedyDeactivation = null,
        [AllowNull, CanBeNull] Action onPass = null,
        [AllowNull, CanBeNull] Action onStrike = null,
        [AllowNull, CanBeNull] Action onTimerExpired = null
    )
    {
        onActivate?.Set(out needy.OnActivate);
        onNeedyActivation?.Set(out needy.OnNeedyActivation);
        onNeedyDeactivation?.Set(out needy.OnNeedyDeactivation);
        onTimerExpired?.Set(out needy.OnTimerExpired);
        onPass?.ToFunc(false).Set(out needy.OnPass);
        onStrike?.ToFunc(false).Set(out needy.OnStrike);
        return needy;
    }

    /// <summary>Adds specified delegate parameters into the <see cref="KMSelectable"/>.</summary>
    /// <param name="selectable">The <see cref="KMSelectable"/> to hook.</param>
    /// <param name="isParent">
    /// The <see langword="return"/> value of <see cref="KMSelectable.OnCancel"/>
    /// and <see cref="KMSelectable.OnInteract"/>.
    /// If <see langword="null"/>, the value is evaluated at runtime to be <see langword="true"/> if
    /// <see cref="KMSelectable.Children"/> is a populated <see cref="Array"/>, and <see langword="false"/> otherwise.
    /// </param>
    /// <param name="onCancel">Called when player backs out of this selectable.</param>
    /// <param name="onDefocus">
    /// Called when a different selectable becomes the focus, or the module has been backed out of.
    /// </param>
    /// <param name="onDeselect">Called when the selectable stops being the current selectable.</param>
    /// <param name="onFocus">
    /// Called when a module is focused, this is when it is interacted with from the bomb face level
    /// and its children can be selected.
    /// </param>
    /// <param name="onHighlight">Called when the highlight is turned on.</param>
    /// <param name="onHighlightEnded">Called when the highlight is turned off.</param>
    /// <param name="onInteract">Called when player interacts with the selectable.</param>
    /// <param name="onInteractEnded">
    /// Called when a player interacting with the selectable releases the mouse or controller button.
    /// </param>
    /// <param name="onInteractionPunch">Called when the interaction punch method is called.</param>
    /// <param name="onLeft">Called when the left controller stick is pulled while selected.</param>
    /// <param name="onRight">Called when the right controller stick is pulled while selected.</param>
    /// <param name="onSelect">Called whenever the selectable becomes the current selectable.</param>
    /// <param name="onUpdateChildren">Called when the selectable updates its children.</param>
    /// <returns>The parameter <paramref name="selectable"/>.</returns>
    // ReSharper disable FunctionComplexityOverflow
    [NotNull, PublicAPI]
    public static KMSelectable Add(
        [NotNull] this KMSelectable selectable,
        bool? isParent = null,
        [AllowNull, CanBeNull] Action onCancel = null,
        [AllowNull, CanBeNull] Action onDefocus = null,
        [AllowNull, CanBeNull] Action onDeselect = null,
        [AllowNull, CanBeNull] Action onFocus = null,
        [AllowNull, CanBeNull] Action onHighlight = null,
        [AllowNull, CanBeNull] Action onHighlightEnded = null,
        [AllowNull, CanBeNull] Action onInteract = null,
        [AllowNull, CanBeNull] Action onInteractEnded = null,
        [AllowNull, CanBeNull] Action onInteractionPunch = null,
        [AllowNull, CanBeNull] Action onLeft = null,
        [AllowNull, CanBeNull] Action onRight = null,
        [AllowNull, CanBeNull] Action onSelect = null,
        [AllowNull, CanBeNull] Action onUpdateChildren = null
    )
    {
        isParent ??= selectable.Children.Length > 0;
        onDefocus?.ToBiAction()?.Add(ref selectable.OnDefocus);
        onDeselect?.Add(ref selectable.OnDeselect);
        onFocus?.Add(ref selectable.OnFocus);
        onHighlight?.Add(ref selectable.OnHighlight);
        onHighlightEnded?.Add(ref selectable.OnHighlightEnded);
        onInteractEnded?.Add(ref selectable.OnInteractEnded);
        onLeft?.Add(ref selectable.OnLeft);
        onRight?.Add(ref selectable.OnRight);
        onSelect?.Add(ref selectable.OnSelect);
        onCancel?.ToFunc(isParent.Value).Add(ref selectable.OnCancel);
        onInteract?.ToFunc(isParent.Value).Add(ref selectable.OnInteract);
        onInteractionPunch?.ToAction<float>().Add(ref selectable.OnInteractionPunch);
        onUpdateChildren?.Add(ref selectable.OnUpdateChildren);
        return selectable;
    }

    /// <summary>Notifies the game that the children list has been updated.</summary>
    /// <remarks><para>
    /// This is a swap-in replacement for <see cref="KMSelectable.UpdateChildren"/>,
    /// since that method only works in the editor.
    /// </para></remarks>
    /// <param name="selectable">The <see cref="KMSelectable"/> to update its children.</param>
    /// <param name="childrenToSelect">The child <see cref="KMSelectable"/> to force a selection on, if specified.</param>
    /// <returns>The parameter <paramref name="selectable"/>.</returns>
    [NotNull, PublicAPI]
    public static KMSelectable Notify(
        [NotNull] this KMSelectable selectable,
        [AllowNull, CanBeNull] KMSelectable childrenToSelect = null
    )
    {
        if (s_isKtane)
            selectable.NotifyAll();

        selectable.UpdateChildren(childrenToSelect);
        return selectable;
    }

    /// <summary>Sets specified delegate parameters into the <see cref="KMSelectable"/>.</summary>
    /// <param name="selectable">The <see cref="KMSelectable"/> to hook.</param>
    /// <param name="isParent">
    /// The <see langword="return"/> value of <see cref="KMSelectable.OnCancel"/>
    /// and <see cref="KMSelectable.OnInteract"/>.
    /// If <see langword="null"/>, the value is evaluated at runtime to be <see langword="true"/> if
    /// <see cref="KMSelectable.Children"/> is a populated <see cref="Array"/>, and <see langword="false"/> otherwise.
    /// </param>
    /// <param name="onCancel">Called when player backs out of this selectable.</param>
    /// <param name="onDefocus">
    /// Called when a different selectable becomes the focus, or the module has been backed out of.
    /// </param>
    /// <param name="onDeselect">Called when the selectable stops being the current selectable.</param>
    /// <param name="onFocus">
    /// Called when a module is focused, this is when it is interacted
    /// with from the bomb face level and its children can be selected.
    /// </param>
    /// <param name="onHighlight">Called when the highlight is turned on.</param>
    /// <param name="onHighlightEnded">Called when the highlight is turned off.</param>
    /// <param name="onInteract">Called when player interacts with the selectable.</param>
    /// <param name="onInteractEnded">
    /// Called when a player interacting with the selectable releases the mouse or controller button.
    /// </param>
    /// <param name="onInteractionPunch">Called when the interaction punch method is called.</param>
    /// <param name="onLeft">Called when the left controller stick is pulled while selected.</param>
    /// <param name="onRight">Called when the right controller stick is pulled while selected.</param>
    /// <param name="onSelect">Called whenever the selectable becomes the current selectable.</param>
    /// <param name="onUpdateChildren">Called when the selectable updates its children.</param>
    /// <returns>The parameter <paramref name="selectable"/>.</returns>
    [NotNull, PublicAPI]
    public static KMSelectable Set(
        [NotNull] this KMSelectable selectable,
        bool? isParent = null,
        [AllowNull, CanBeNull] Action onCancel = null,
        [AllowNull, CanBeNull] Action onDefocus = null,
        [AllowNull, CanBeNull] Action onDeselect = null,
        [AllowNull, CanBeNull] Action onFocus = null,
        [AllowNull, CanBeNull] Action onHighlight = null,
        [AllowNull, CanBeNull] Action onHighlightEnded = null,
        [AllowNull, CanBeNull] Action onInteract = null,
        [AllowNull, CanBeNull] Action onInteractEnded = null,
        [AllowNull, CanBeNull] Action onInteractionPunch = null,
        [AllowNull, CanBeNull] Action onLeft = null,
        [AllowNull, CanBeNull] Action onRight = null,
        [AllowNull, CanBeNull] Action onSelect = null,
        [AllowNull, CanBeNull] Action onUpdateChildren = null
    )
    {
        isParent ??= selectable.Children.Length > 0;
        onCancel?.ToFunc(isParent.Value).Set(out selectable.OnCancel);
        onDefocus?.ToBiAction()?.Set(out selectable.OnDefocus);
        onDeselect?.Set(out selectable.OnDeselect);
        onFocus?.Set(out selectable.OnFocus);
        onHighlight?.Set(out selectable.OnHighlight);
        onHighlightEnded?.Set(out selectable.OnHighlightEnded);
        onInteractEnded?.Set(out selectable.OnInteractEnded);
        onLeft?.Set(out selectable.OnLeft);
        onRight?.Set(out selectable.OnRight);
        onSelect?.Set(out selectable.OnSelect);
        onInteract?.ToFunc(isParent.Value).Set(out selectable.OnInteract);
        onInteractionPunch?.ToAction<float>().Set(out selectable.OnInteractionPunch);
        onUpdateChildren?.Set(out selectable.OnUpdateChildren);
        return selectable;
    }

    /// <summary>
    /// Adds the specified delegate parameter if not <see langword="null"/> into the <see cref="IEnumerable{T}"/>
    /// of <see cref="KMSelectable"/> instances. An <see cref="int"/> is passed in the <see cref="Action{T}"/>
    /// based on the index from the collection.
    /// </summary>
    /// <typeparam name="T">
    /// The type of <see cref="IEnumerable{T}"/> containing <see cref="KMSelectable"/> instances.
    /// </typeparam>
    /// <param name="audio">
    /// The <see cref="IEnumerable{T}"/> of <see cref="KMAudioRef"/>
    /// instances to invoke <see cref="KMAudioRef.StopSound"/>.
    /// </param>
    /// <param name="onStopSound">Called when the sound is prematurely stopped.</param>
    /// <returns>The parameter <paramref name="audio"/>.</returns>
    [NotNull, PublicAPI]
    public static T Add<T>([InstantHandle, ItemNotNull, NotNull] this T audio, [NotNull] Action<int> onStopSound)
        where T : IEnumerable<KMAudioRef>
    {
        var i = 0;

        foreach (var a in audio)
            a.Add(onStopSound.ToAction(checked(i++)));

        return audio;
    }

    /// <summary>
    /// Sets the specified delegate parameter if not <see langword="null"/> into the <see cref="IEnumerable{T}"/>
    /// of <see cref="KMSelectable"/> instances. An <see cref="int"/> is passed in the <see cref="Action{T}"/>
    /// based on the index from the collection.
    /// </summary>
    /// <typeparam name="T">
    /// The type of <see cref="IEnumerable{T}"/> containing <see cref="KMSelectable"/> instances.
    /// </typeparam>
    /// <param name="audio">
    /// The <see cref="IEnumerable{T}"/> of <see cref="KMAudioRef"/>
    /// instances to invoke <see cref="KMAudioRef.StopSound"/>.
    /// </param>
    /// <param name="onStopSound">Called when the sound is prematurely stopped.</param>
    /// <returns>The parameter <paramref name="audio"/>.</returns>
    [NotNull, PublicAPI]
    public static T Set<T>([InstantHandle, ItemNotNull, NotNull] this T audio, [NotNull] Action<int> onStopSound)
        where T : IEnumerable<KMAudioRef>
    {
        var i = 0;

        foreach (var a in audio)
            a.Set(onStopSound.ToAction(checked(i++)));

        return audio;
    }

    /// <summary>
    /// Adds specified delegate parameters into the <see cref="IEnumerable{T}"/> of <see cref="KMSelectable"/> instances.
    /// An <see cref="int"/> is passed in the <see cref="Action{T}"/> based on the index from the collection.
    /// </summary>
    /// <typeparam name="T">
    /// The type of <see cref="IEnumerable{T}"/> containing <see cref="KMSelectable"/> instances.
    /// </typeparam>
    /// <param name="selectables">The <see cref="IEnumerable{T}"/> of <see cref="KMSelectable"/> instances to hook.</param>
    /// <param name="isParent">
    /// The <see langword="return"/> value of <see cref="KMSelectable.OnCancel"/>
    /// and <see cref="KMSelectable.OnInteract"/>.
    /// If <see langword="null"/>, the value is evaluated at runtime to be <see langword="true"/> if
    /// <see cref="KMSelectable.Children"/> is a populated <see cref="Array"/>, and <see langword="false"/> otherwise.
    /// </param>
    /// <param name="onCancel">Called when player backs out of this selectable.</param>
    /// <param name="onDefocus">
    /// Called when a different selectable becomes the focus, or the module has been backed out of.
    /// </param>
    /// <param name="onDeselect">Called when the selectable stops being the current selectable.</param>
    /// <param name="onFocus">
    /// Called when a module is focused, this is when it is interacted with from the bomb face level
    /// and its children can be selected.
    /// </param>
    /// <param name="onHighlight">Called when the highlight is turned on.</param>
    /// <param name="onHighlightEnded">Called when the highlight is turned off.</param>
    /// <param name="onInteract">Called when player interacts with the selectable.</param>
    /// <param name="onInteractEnded">
    /// Called when a player interacting with the selectable releases the mouse or controller button.
    /// </param>
    /// <param name="onInteractionPunch">Called when the interaction punch method is called.</param>
    /// <param name="onLeft">Called when the left controller stick is pulled while selected.</param>
    /// <param name="onRight">Called when the right controller stick is pulled while selected.</param>
    /// <param name="onSelect">Called whenever the selectable becomes the current selectable.</param>
    /// <param name="onUpdateChildren">Called when the selectable updates its children.</param>
    /// <returns>The parameter <paramref name="selectables"/>.</returns>
    [NotNull, PublicAPI]
    public static T Add<T>(
        [InstantHandle, ItemNotNull, NotNull] this T selectables,
        bool? isParent = null,
        [AllowNull, CanBeNull] Action<int> onCancel = null,
        [AllowNull, CanBeNull] Action<int> onDefocus = null,
        [AllowNull, CanBeNull] Action<int> onDeselect = null,
        [AllowNull, CanBeNull] Action<int> onFocus = null,
        [AllowNull, CanBeNull] Action<int> onHighlight = null,
        [AllowNull, CanBeNull] Action<int> onHighlightEnded = null,
        [AllowNull, CanBeNull] Action<int> onInteract = null,
        [AllowNull, CanBeNull] Action<int> onInteractEnded = null,
        [AllowNull, CanBeNull] Action<int> onInteractionPunch = null,
        [AllowNull, CanBeNull] Action<int> onLeft = null,
        [AllowNull, CanBeNull] Action<int> onRight = null,
        [AllowNull, CanBeNull] Action<int> onSelect = null,
        [AllowNull, CanBeNull] Action<int> onUpdateChildren = null
    )
        where T : IEnumerable<KMSelectable>
    {
        var i = 0;

        foreach (var s in selectables)
            s.Add(
                isParent,
                onCancel?.ToAction(i),
                onDefocus?.ToAction(i),
                onDeselect?.ToAction(i),
                onFocus?.ToAction(i),
                onHighlight?.ToAction(i),
                onHighlightEnded?.ToAction(i),
                onInteract?.ToAction(i),
                onInteractEnded?.ToAction(i),
                onInteractionPunch?.ToAction(i),
                onLeft?.ToAction(i),
                onRight?.ToAction(i),
                onSelect?.ToAction(i),
                onUpdateChildren?.ToAction(checked(i++))
            );

        return selectables;
    }

    /// <summary>Notifies the game that the children list has been updated.</summary>
    /// <remarks><para>
    /// This is a swap-in replacement for <see cref="KMSelectable.UpdateChildren"/>,
    /// since that method only works in the editor.
    /// </para></remarks>
    /// <typeparam name="T">
    /// The type of <see cref="IEnumerable{T}"/> containing <see cref="KMSelectable"/> instances.
    /// </typeparam>
    /// <param name="selectables">
    /// The <see cref="IEnumerable{T}"/> of <see cref="KMSelectable"/> instances to update its children.
    /// </param>
    /// <param name="childrenToSelect">
    /// The <see cref="Array"/> of children <see cref="KMSelectable"/> to force selections on, if specified.
    /// </param>
    /// <returns>The parameter <paramref name="selectables"/>.</returns>
    [NotNull, PublicAPI]
    public static T Notify<T>(
        [InstantHandle, ItemNotNull, NotNull] this T selectables,
        [AllowNull, CanBeNull, InstantHandle] params KMSelectable[] childrenToSelect
    )
        where T : IEnumerable<KMSelectable> =>
        selectables.Notify(childrenToSelect as IEnumerable<KMSelectable>);

    /// <summary>Notifies the game that the children list has been updated.</summary>
    /// <remarks><para>
    /// This is a swap-in replacement for <see cref="KMSelectable.UpdateChildren"/>,
    /// since that method only works in the editor.
    /// </para></remarks>
    /// <typeparam name="T">
    /// The type of <see cref="IEnumerable{T}"/> containing <see cref="KMSelectable"/> instances.
    /// </typeparam>
    /// <typeparam name="TChild">
    /// The type of <see cref="IEnumerable{T}"/> containing child <see cref="KMSelectable"/> instances.
    /// </typeparam>
    /// <param name="selectables">
    /// The <see cref="IEnumerable{T}"/> of <see cref="KMSelectable"/> instances to update its children.
    /// </param>
    /// <param name="childrenToSelect">
    /// The <see cref="IEnumerable{T}"/> of children <see cref="KMSelectable"/> to force selections on, if specified.
    /// </param>
    /// <returns>The parameter <paramref name="selectables"/>.</returns>
    [NotNull, PublicAPI]
    public static T Notify<T, TChild>(
        [InstantHandle, ItemNotNull, NotNull] this T selectables,
        [AllowNull, CanBeNull, InstantHandle] TChild childrenToSelect
    )
        where T : IEnumerable<KMSelectable>
        where TChild : IEnumerable<KMSelectable>
    {
        using var enumerator = childrenToSelect?.GetEnumerator() ?? Enumerable.Empty<KMSelectable>().GetEnumerator();

        foreach (var s in selectables)
            s.Notify(enumerator.MoveNext() ? enumerator.Current : null);

        return selectables;
    }

    /// <summary>
    /// Sets specified delegate parameters into the <see cref="IEnumerable{T}"/> of <see cref="KMSelectable"/> instances.
    /// An <see cref="int"/> is passed in the <see cref="Action{T}"/> based on the index from the collection.
    /// </summary>
    /// <typeparam name="T">
    /// The type of <see cref="IEnumerable{T}"/> containing <see cref="KMSelectable"/> instances.
    /// </typeparam>
    /// <param name="selectables">
    /// The <see cref="IEnumerable{T}"/> of <see cref="KMSelectable"/> instances to hook.
    /// </param>
    /// <param name="isParent">
    /// The <see langword="return"/> value of <see cref="KMSelectable.OnCancel"/>
    /// and <see cref="KMSelectable.OnInteract"/>.
    /// If <see langword="null"/>, the value is evaluated at runtime to be <see langword="true"/> if
    /// <see cref="KMSelectable.Children"/> is a populated <see cref="Array"/>, and <see langword="false"/> otherwise.
    /// </param>
    /// <param name="onCancel">Called when player backs out of this selectable.</param>
    /// <param name="onDefocus">
    /// Called when a different selectable becomes the focus, or the module has been backed out of.
    /// </param>
    /// <param name="onDeselect">Called when the selectable stops being the current selectable.</param>
    /// <param name="onFocus">
    /// Called when a module is focused, this is when it is interacted
    /// with from the bomb face level and its children can be selected.
    /// </param>
    /// <param name="onHighlight">Called when the highlight is turned on.</param>
    /// <param name="onHighlightEnded">Called when the highlight is turned off.</param>
    /// <param name="onInteract">Called when player interacts with the selectable.</param>
    /// <param name="onInteractEnded">
    /// Called when a player interacting with the selectable releases the mouse or controller button.
    /// </param>
    /// <param name="onInteractionPunch">Called when the interaction punch method is called.</param>
    /// <param name="onLeft">Called when the left controller stick is pulled while selected.</param>
    /// <param name="onRight">Called when the right controller stick is pulled while selected.</param>
    /// <param name="onSelect">Called whenever the selectable becomes the current selectable.</param>
    /// <param name="onUpdateChildren">Called when the selectable updates its children.</param>
    /// <returns>The parameter <paramref name="selectables"/>.</returns>
    [NotNull, PublicAPI]
    public static T Set<T>(
        [InstantHandle, ItemNotNull, NotNull] this T selectables,
        bool? isParent = null,
        [AllowNull, CanBeNull] Action<int> onCancel = null,
        [AllowNull, CanBeNull] Action<int> onDefocus = null,
        [AllowNull, CanBeNull] Action<int> onDeselect = null,
        [AllowNull, CanBeNull] Action<int> onFocus = null,
        [AllowNull, CanBeNull] Action<int> onHighlight = null,
        [AllowNull, CanBeNull] Action<int> onHighlightEnded = null,
        [AllowNull, CanBeNull] Action<int> onInteract = null,
        [AllowNull, CanBeNull] Action<int> onInteractEnded = null,
        [AllowNull, CanBeNull] Action<int> onInteractionPunch = null,
        [AllowNull, CanBeNull] Action<int> onLeft = null,
        [AllowNull, CanBeNull] Action<int> onRight = null,
        [AllowNull, CanBeNull] Action<int> onSelect = null,
        [AllowNull, CanBeNull] Action<int> onUpdateChildren = null
    )
        where T : IEnumerable<KMSelectable>
    {
        var i = 0;

        foreach (var s in selectables)
            s.Set(
                isParent,
                onCancel?.ToAction(i),
                onDefocus?.ToAction(i),
                onDeselect?.ToAction(i),
                onFocus?.ToAction(i),
                onHighlight?.ToAction(i),
                onHighlightEnded?.ToAction(i),
                onInteract?.ToAction(i),
                onInteractEnded?.ToAction(i),
                onInteractionPunch?.ToAction(i),
                onLeft?.ToAction(i),
                onRight?.ToAction(i),
                onSelect?.ToAction(i),
                onUpdateChildren?.ToAction(checked(i++))
            );

        return selectables;
    }

    /// <summary>
    /// Invokes <see cref="KMAudioRef.StopSound"/> for all elements in the
    /// <see cref="IEnumerable{T}"/> of <see cref="KMAudioRef"/> instances.
    /// </summary>
    /// <typeparam name="T">
    /// The type of <see cref="IEnumerable{T}"/> containing <see cref="KMSelectable"/> instances.
    /// </typeparam>
    /// <param name="audio">
    /// The <see cref="IEnumerable{T}"/> of <see cref="KMAudioRef"/>
    /// instances to invoke <see cref="KMAudioRef.StopSound"/>.
    /// </param>
    /// <returns>The parameter <paramref name="audio"/>.</returns>
    [NotNull, PublicAPI]
    public static T Stop<T>([InstantHandle, ItemCanBeNull, NotNull] this T audio)
        where T : IEnumerable<KMAudioRef>
    {
        foreach (var a in audio)
            a?.StopSound();

        return audio;
    }

    static void Add<T>([NotNull] this Delegate del, [NotNull] ref T mut)
        where T : Delegate =>
        mut = (T)Delegate.Combine(mut, del.Cast<T>());

    static void NotifyAll([NotNull] this KMSelectable selectable)
    {
        foreach (var child in selectable.Children)
            child.NotifyInner();

        selectable.NotifyInner();
    }

    static void NotifyInner([AllowNull, CanBeNull] this KMSelectable selectable)
    {
        if (selectable && selectable.GetComponent<ModSelectable>() is var mod && mod)
            mod.CopySettingsFromProxy();
    }

    static void Set<T>([NotNull] this Delegate del, [NotNull] out T mut)
        where T : Delegate =>
        mut = del.Cast<T>();

    [NotNull, Pure]
    static Action ToAction([NotNull] this Action<int> action, int parameterValue) => () => action(parameterValue);

    [NotNull, Pure]
    static Action<T> ToAction<T>([NotNull] this Action action) => _ => action();

    [NotNull, Pure]
    static Action ToBiAction([NotNull] this Action action)
    {
        var call = false;

        void BiAction()
        {
            call ^= true;

            if (call)
                action();
        }

        return s_isKtaneOrRewritten ? BiAction : action;
    }

    [NotNull, Pure]
    static Func<bool> ToFunc([NotNull] this Action action, bool value)
    {
        bool Func()
        {
            action();
            return value;
        }

        return Func;
    }

    [NotNull]
    static T Cast<T>([NotNull] this Delegate del)
        where T : Delegate =>
        (T)Delegate.CreateDelegate(typeof(T), del.Target, del.Method);
}
