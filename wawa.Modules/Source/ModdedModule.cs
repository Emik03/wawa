// <copyright file="ModdedModule.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Wawa.Modules;

/// <summary>
/// A <see cref="Component"/> that handles general Keep Talking and Nobody Explodes modded module behaviour.
/// </summary>
[CLSCompliant(false), PublicAPI]
public abstract class ModdedModule : CachedBehaviour
{
    [NotNull]
    const string
        ExceptionStackTrace = "Rethrow as ",
        NoComponent = $"There is no attached {nameof(KMBombModule)} or {nameof(KMNeedyModule)}.",
        NotFound = "[[HYPERLINK BLOCKED]]",
        Prefix = "\n| ",
        TooFewAudioSources = $"You need a {nameof(KMAudio)} component to play a sound. " +
            "It cannot be instantiated by this library, since the game could hook before this library can create one.",
        TooManyAudioSources =
            $"There is more than one {nameof(KMAudio)} component. " +
            "This is considered a mistake because the game will only add the sounds to one of the " +
            $"{nameof(KMAudio)} components, which gives no certainty on the {nameof(KMAudio)} having sounds assigned.";

    // For some reason this doesn't compile??
    // ReSharper disable ReplaceWithFieldKeyword
    [CanBeNull]
    KMBombModule _solvable;

    [CanBeNull]
    KMNeedyModule _needy;

    [CanBeNull]
    State _status;

    /// <summary>Gets the current solve/strike status of the module.</summary>
    [NotNull]
    public State Status => _status ??= new(Name);

    /// <summary>
    /// Gets the mod id. Override this if you are working with an assembly with a different name than your mod id.
    /// </summary>
    [NotNull]
    protected virtual string Id => GetType().Assembly.GetName().Name;

    // DO NOT REMOVE. The mod 'Tweaks' uses reflection to get any field/property named "moduleId". (case-insensitive)
    [UsedImplicitly]
    int ModuleId => Status.Id;

    [NotNull]
    string Name
    {
        [Pure]
        get =>
            Solvable is { } s ? s.ModuleDisplayName :
            Needy is { } n ? n.ModuleDisplayName : throw new MissingComponentException(NoComponent);
    }

    [AllowNull, CanBeNull]
    KMBombModule Solvable => _solvable ??= GetComponent<KMBombModule>();

    [AllowNull, CanBeNull]
    KMNeedyModule Needy => _needy ??= GetComponent<KMNeedyModule>();

    /// <inheritdoc/>
    [Pure]
    public override string ToString() => Name;

    /// <summary>Plays one or more sounds from the module <see cref="Transform"/>.</summary>
    /// <exception cref="InvalidOperationException">
    /// There isn't exactly 1 <see cref="KMAudio"/> <see cref="Component"/> attached to this <see cref="GameObject"/>.
    /// </exception>
    /// <param name="sounds">The sounds to play.</param>
    /// <returns>The parameter <paramref name="sounds"/>.</returns>
    [NotNull]
    public Sound[] Play([InstantHandle, NotNull] params Sound[] sounds) => PlayEnum(sounds, transform);

    /// <summary>Plays one or more sounds from a specified <see cref="Transform"/>.</summary>
    /// <exception cref="InvalidOperationException">
    /// There isn't exactly 1 <see cref="KMAudio"/> <see cref="Component"/> attached to this <see cref="GameObject"/>.
    /// </exception>
    /// <param name="location">The source of the sound.</param>
    /// <param name="sounds">The sounds to play.</param>
    /// <returns>The parameter <paramref name="sounds"/>.</returns>
    [NotNull]
    public Sound[] Play([NotNull] Transform location, [InstantHandle, NotNull] params Sound[] sounds) =>
        PlayEnum(sounds, location);

    /// <summary>Plays one or more sounds from a specified <see cref="Transform"/>.</summary>
    /// <typeparam name="T">The type of iterator.</typeparam>
    /// <exception cref="InvalidOperationException">
    /// There isn't exactly 1 <see cref="KMAudio"/> <see cref="Component"/> attached to this <see cref="GameObject"/>.
    /// </exception>
    /// <param name="sounds">The sounds to play.</param>
    /// <param name="location">The source of the sound.</param>
    /// <returns>The parameter <paramref name="sounds"/>.</returns>
    [NotNull]
    public T PlayEnum<T>([InstantHandle, NotNull] T sounds, [AllowNull, CanBeNull] Transform location = null)
        where T : IEnumerable<Sound>
    {
        var sources = Get<KMAudio[]>();

        var source = sources.Length switch
        {
            0 => throw new InvalidOperationException(TooFewAudioSources),
            1 => sources[0],
            _ => throw new InvalidOperationException(TooManyAudioSources),
        };

        var local = location ? location : transform;

        return Play(local, sounds, source);
    }

    /// <summary>Plays sounds and shakes the bomb from a selectable.</summary>
    /// <param name="selectable">The source of the interaction punch and sound source.</param>
    /// <param name="intensityModifier">The intensity of the interaction punch.</param>
    /// <param name="sounds">The sounds to play.</param>
    /// <returns>The parameter <paramref name="selectable"/>.</returns>
    [NotNull]
    public KMSelectable Shake(
        [NotNull] KMSelectable selectable,
        float intensityModifier = 0,
        [NotNull] params Sound[] sounds
    )
    {
        var location = selectable.transform;

        selectable.AddInteractionPunch(intensityModifier);
        Play(location, sounds);

        return selectable;
    }

    /// <summary>Solves the module.</summary>
    /// <param name="format">The value to log.</param>
    /// <param name="args">The arguments to hook into format.</param>
    /// <returns>The value <see langword="default"/>.</returns>
    public Unit Solve([AllowNull, CanBeNull] string format = null, [NotNull] params object[] args)
    {
        if (Status.IsSolved)
            return default;

        if (Status.HasException && IsKtane) // ReSharper disable Unity.PerformanceCriticalCodeInvocation
            Parent<KMBomb>().SetStrikes(Status.Strikes);

        // ReSharper restore Unity.PerformanceCriticalCodeInvocation

        if (format is not null)
            Log(format, args);

        Status.IsSolved = true;

        if (Solvable is { } s)
            s.HandlePass();

        if (Needy is { } n)
            n.HandlePass();

        return default;
    }

    /// <summary>Strikes the module.</summary>
    /// <param name="format">The value to log.</param>
    /// <param name="args">The arguments to hook into format.</param>
    /// <returns>The value <see langword="default"/>.</returns>
    public Unit Strike([AllowNull, CanBeNull] string format = null, [NotNull] params object[] args)
    {
        if (Status.HasException)
            return default;

        if (format is not null)
            Log(format, args);

        Status.HasStruck = true;
        Status.Strikes++;

        if (Solvable is { } s)
            s.HandleStrike();

        if (Needy is { } n)
            n.HandleStrike();

        return default;
    }

    /// <summary>
    /// Logs and formats a message to the Unity Console in a format compliant with the Logfile Analyzer.
    /// </summary>
    /// <typeparam name="T">The type of the value to log.</typeparam>
    /// <param name="format">The value to log.</param>
    /// <param name="logType">The kind of logging method to invoke.</param>
    /// <returns>The parameter <paramref name="format"/>.</returns>
    [CanBeNull]
    [return: AllowNull]
    public T Log<T>([AllowNull, CanBeNull] T format = default, LogType logType = LogType.Log)
    {
        var id = Status.Id;
        var stringify = format.Stringify();
        var message = $@"[{Name} #{id}] {stringify}";

        Debug.unityLogger.Log(logType, message);

        return format;
    }

    /// <summary>
    /// Logs and formats a message to the Unity Console in a format compliant with the Logfile Analyzer.
    /// </summary>
    /// <typeparam name="T">The type of the value to log.</typeparam>
    /// <param name="format">The value to log.</param>
    /// <param name="args">The arguments to hook into format.</param>
    /// <returns>The parameter <paramref name="format"/>.</returns>
    [CanBeNull]
    [return: AllowNull]
    public T Log<T>([AllowNull, CanBeNull] T format = default, [NotNull] params object[] args)
    {
        var convertAll = Array.ConvertAll(args, static o => (object)o.Stringify());
        var stringify = format.Stringify();
        var provider = CultureInfo.InvariantCulture;
        var message = string.Format(provider, stringify, convertAll);

        Log(message);

        return format;
    }

    /// <summary>
    /// Logs and formats a message to the Unity Console in a format not compliant with the Logfile Analyzer.
    /// </summary>
    /// <typeparam name="T">The type of the value to log.</typeparam>
    /// <param name="format">The value to log.</param>
    /// <param name="logType">The kind of logging method to invoke.</param>
    /// <returns>The parameter <paramref name="format"/>.</returns>
    [CanBeNull]
    [return: AllowNull]
    public T LogLower<T>([AllowNull, CanBeNull] T format = default, LogType logType = LogType.Log)
    {
        var message = $@"<{Name} #{Status.Id}> {format.Stringify()}";

        Log(format, message, logType);

        return format;
    }

    /// <summary>
    /// Logs and formats a message to the Unity Console in a format not compliant with the Logfile Analyzer.
    /// </summary>
    /// <typeparam name="T">The type of the value to log.</typeparam>
    /// <param name="format">The value to log.</param>
    /// <param name="args">The arguments to hook into format.</param>
    /// <returns>The parameter <paramref name="format"/>.</returns>
    [CanBeNull]
    [return: AllowNull]
    public T LogLower<T>([AllowNull, CanBeNull] T format = default, [NotNull] params object[] args)
    {
        var convertAll = Array.ConvertAll(args, static o => (object)o.Stringify());
        var stringify = format.Stringify();
        var provider = CultureInfo.InvariantCulture;
        var message = string.Format(provider, stringify, convertAll);

        LogLower(message);

        return format;
    }

    /// <summary>Logs version numbers. Be sure to call this method if you are implementing Awake.</summary>
    protected virtual void Awake()
    {
        AssemblyLog($@"The module ""{Name}"" uses this library.");
        Log($@"Version: {GetModInfo(Id).Value?.Version ?? NotFound}");
    }

    /// <summary>The method that is called when the lights are turned on. Automatically hooked in Awake.</summary>
    /// <remarks><para>The base method doesn't do anything; Calling this base method is a no-op.</para></remarks>
    protected virtual void OnActivate() { }

    /// <summary>
    /// Subscribes <see cref="Application.logMessageReceived"/> and <see cref="KMBombModule.OnActivate"/>.
    /// </summary>
    /// <remarks><para>It is recommended to invoke the base method when overriding this method.</para></remarks>
    protected virtual void OnDisable()
    {
        Application.logMessageReceived -= CheckForException;

        if (Solvable is { } s)
            s.OnActivate -= OnActivate;

        if (Needy is { } n)
            n.OnActivate -= OnActivate;
    }

    /// <summary>
    /// Unsubscribes <see cref="Application.logMessageReceived"/> and <see cref="KMBombModule.OnActivate"/>.
    /// </summary>
    /// <remarks><para>It is recommended to invoke the base method when overriding this method.</para></remarks>
    protected virtual void OnEnable()
    {
        Application.logMessageReceived += CheckForException;

        if (Solvable is { } s)
            s.OnActivate += OnActivate;

        if (Needy is { } n)
            n.OnActivate += OnActivate;
    }

    /// <summary>
    /// The method that is called when an unhandled <see cref="Exception"/> is thrown by this module type.
    /// </summary>
    /// <param name="message">The message of the <see cref="Exception"/>.</param>
    protected virtual void OnException([NotNull] string message)
    {
        var formatted = $@"Unhandled: {message}";

        Log(formatted, LogType.Warning);

        if (GetComponent<ISolvable>()?.IsTP ?? false)
            return;

        if (GetComponent<KMSelectable>() is not { } selectable)
        {
            StartCoroutine(WaitForSolve());

            return;
        }

        selectable.OnInteract += () =>
        {
            StartCoroutine(WaitForSolve());

            return false;
        };
    }

    [NotNull]
    static T Play<T>([NotNull] in Transform location, [NotNull] in T sounds, [NotNull] in KMAudio source)
        where T : IEnumerable<Sound>
    {
        foreach (var sound in sounds)
            sound?.Play(source, location);

        return sounds;
    }

    void CheckForException([NotNull] string condition, [NotNull] string stackTrace, LogType type)
    {
        if (type is not LogType.Exception)
            return;

        var typeName = GetType().Name;
        var traces = stackTrace.Split('\n');

        if (traces.Any(x => x.StartsWith(typeName, Ordinal)))
            PrepareException(condition, traces);
    }

    void PrepareException([NotNull] string condition, [NotNull] IEnumerable<string> traces)
    {
        Application.logMessageReceived -= CheckForException;
        Status.HasException = true;

        var rethrows =
            traces
               .TakeWhile(static s => s.StartsWith(ExceptionStackTrace, Ordinal))
               .ToArray();

        var innerExceptions = string.Join(Prefix, rethrows);
        var spacing = innerExceptions is "" ? "" : Prefix;
        var message = $@"{condition}{spacing}{innerExceptions}";

        OnException(message);
    }

    [NotNull]
    IEnumerator WaitForSolve()
    {
        // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
        Solve();

        // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
        if (GetComponent<ISolvable>() is { } solver)
            yield return solver.ForceTPSolve();
    }
}
