﻿// SPDX-License-Identifier: MPL-2.0
namespace wawa.Modules;

/// <summary>
/// The <see cref="Component"/> that handles general Keep Talking and Nobody Explodes modded module behaviour.
/// </summary>
[CLSCompliant(false), PublicAPI]
public abstract class ModdedModule : CachedBehaviour
{
    /// <summary>The message to log.</summary>
    [NotNull]
    const string
        ExceptionStackTrace = "Rethrow as ",
        NoComponent = $"There is no attached {nameof(KMBombModule)} or {nameof(KMNeedyModule)}.",
        NotFound = "[[HYPERLINK BLOCKED]]",
        Prefix = "\n| ",
        TooFewAudioSources = $"{nameof(Play)} Error: You need a {nameof(KMAudio)} component to play a sound. " +
            "It cannot be instantiated by this library, since the game could hook before this library can create one.",
        TooManyAudioSources =
            $"There is more than one {nameof(KMAudio)} component. " +
            "This is considered a mistake because the game will only add the sounds to one of the " +
            $"{nameof(KMAudio)} components, which gives no certainty on the {nameof(KMAudio)} having sounds assigned.",
        Unspecified = "There is no version. Press [F5] or go to [Keep Talking ModKit > Configure Mod] to specify one.";

    /// <summary>The matrix attached to this <see cref="GameObject"/>.</summary>
    [CanBeNull]
    IList<IList<KMSelectable>>? _matrix;

    /// <summary>Gets the children of the top-level selectable.</summary>
    /// <exception cref="MissingComponentException">
    /// There is no <see cref="KMSelectable"/> <see cref="Component"/> attached to this <see cref="GameObject"/>.
    /// </exception>
    [PublicAPI]
    public IList<KMSelectable> Children
    {
        [ItemCanBeNull, NotNull, MustUseReturnValue] get => GetChildSelectables();
    }

    /// <summary>Gets the children of the top-level selectable.</summary>
    /// <remarks><para>
    /// Unlike <see cref="Children"/>, this returns a 2-dimensional list by mapping
    /// it with inference from <see cref="KMSelectable.ChildRowLength"/>.
    /// </para></remarks>
    /// <exception cref="InvalidOperationException">
    /// The <see cref="KMSelectable"/> <see cref="Component"/> attached to this <see cref="GameObject"/>
    /// has a <see cref="KMSelectable.ChildRowLength"/> value of <c>0</c>.
    /// </exception>
    /// <exception cref="MissingComponentException">
    /// There is no <see cref="KMSelectable"/> <see cref="Component"/> attached to this <see cref="GameObject"/>.
    /// </exception>
    [PublicAPI]
    public IList<IList<KMSelectable>> Matrix
    {
        [ItemCanBeNull, NotNull, MustUseReturnValue]
        get => _matrix ??= new Matrix<KMSelectable>(GetChildSelectables, GetChildSelectableRowLength);
    }

    /// <summary>Gets the current solve/strike status of the module.</summary>
    [NotNull]
    [field: CanBeNull]
    public State Status
    {
        [Pure] get => field ??= new(Name);
    }

    /// <summary>
    /// Gets the mod id. Override this if you are working with an assembly with a different name than your mod id.
    /// </summary>
    [NotNull]
    [field: CanBeNull]
    protected virtual string Id
    {
        [MustUseReturnValue] get => field ??= Lookup.ModNameOf(this).Value ?? GetType().Assembly.GetName().Name;
    }

    /// <summary>Gets the module id. Unused by the library.</summary>
    /// <remarks><para>
    /// <b>DO NOT REMOVE.</b>
    /// The mod 'Tweaks' uses reflection to get any field or property named "moduleid" case-insensitively.
    /// </para></remarks>
    [UsedImplicitly]
    int ModuleId
    {
        [Pure] get => Status.Id;
    }

    /// <summary>Gets the name of the module.</summary>
    /// <exception cref="MissingComponentException"></exception>
    [NotNull]
    string Name
    {
        [Pure]
        get =>
            Solvable ? Solvable.ModuleDisplayName :
            Needy ? Needy.ModuleDisplayName : throw new MissingComponentException(NoComponent);
    }

    /// <summary>Gets the <see cref="KMBombModule"/> component.</summary>
    [AllowNull, CanBeNull]
    [field: CanBeNull]
    KMBombModule Solvable
    {
        [Pure] get => field ? field : field = GetComponent<KMBombModule>();
    }

    /// <summary>Gets the <see cref="KMNeedyModule"/> component.</summary>
    [AllowNull, CanBeNull]
    [field: CanBeNull]
    KMNeedyModule Needy
    {
        [Pure] get => field ? field : field = GetComponent<KMNeedyModule>();
    }

    /// <inheritdoc/>
    [Pure]
    public override string ToString() => Name;

    /// <summary>
    /// Converts <paramref name="source"/> into a <see cref="string"/> representation of <paramref name="source"/>.
    /// </summary>
    /// <remarks><para>Used for logging, such as <see cref="Log{T}(T, object[])"/>.</para></remarks>
    /// <typeparam name="T">The type of the source.</typeparam>
    /// <param name="source">The item to get a <see cref="string"/> representation of.</param>
    /// <returns><paramref name="source"/> as <see cref="string"/>.</returns>
    [NotNull, Pure]
    public virtual string Stringify<T>([AllowNull, CanBeNull] T source) => Stringify(source, null);

    /// <summary>
    /// Converts <paramref name="source"/> into a <see cref="string"/> representation of <paramref name="source"/>.
    /// </summary>
    /// <remarks><para>Used for logging, such as <see cref="Log{T}(T, object[])"/>.</para></remarks>
    /// <typeparam name="T">The type of the source.</typeparam>
    /// <param name="source">The item to get a <see cref="string"/> representation of.</param>
    /// <param name="format">The format string.</param>
    /// <returns><paramref name="source"/> as <see cref="string"/>.</returns>
    [NotNull, Pure] // ReSharper disable once CognitiveComplexity
    public virtual string Stringify<T>([AllowNull, CanBeNull] T source, [AllowNull, CanBeNull] string format)
    {
        const int Limit = 500;

        string Dictionary([NotNull] IDictionary dictionary, [AllowNull, CanBeNull] string format)
        {
            var enumerator = dictionary.GetEnumerator();
            using var _ = enumerator as IDisposable;

            if (!enumerator.MoveNext())
                return "{ }";

            StringBuilder builder = new("{ ");

            builder
               .Append(Stringify(enumerator.Key, format))
               .Append(": ")
               .Append(Stringify(enumerator.Value, format));

            for (var i = 0; i < Limit && enumerator.MoveNext(); i++)
                builder
                   .Append(", ")
                   .Append(Stringify(enumerator.Key, format))
                   .Append(": ")
                   .Append(Stringify(enumerator.Value, format));

            return builder.Append(" }").ToString();
        }

        string Enumerable([NotNull] IEnumerable enumerable, [AllowNull, CanBeNull] string format)
        {
            var enumerator = enumerable.GetEnumerator();
            using var _ = enumerator as IDisposable;

            if (!enumerator.MoveNext())
                return "[]";

            StringBuilder builder = new("[");
            builder.Append(Stringify(enumerator.Current, format));

            for (var i = 0; i < Limit && enumerator.MoveNext(); i++)
                builder.Append(", ").Append(Stringify(enumerator.Current, format));

            return builder.Append(']').ToString();
        }

        return source switch
        {
            IEnumerable<char> x => x as string ?? new([..x]),
            IDictionary x => Dictionary(x, format),
            IEnumerable x => Enumerable(x, format),
            IFormattable x => x.ToString(format, CultureInfo.InvariantCulture),
            _ => source?.ToString() ?? "null",
        };
    }

    /// <summary>
    /// Formats and logs the parameter, which will show up under the module's tab in the Logfile Analyzer.
    /// </summary>
    /// <param name="format">The value to log.</param>
    /// <param name="logType">The kind of logging method to invoke.</param>
    /// <returns>The parameter <paramref name="format"/>.</returns>
    public InterpolatedStringHandlerEnumerable Log(
        InterpolatedStringHandlerEnumerable format,
        LogType logType = LogType.Log
    )
    {
        StringBuilder builder = new(format.RecommendedLength);

        foreach (var next in format)
            builder.Append(Stringify(next.Key, next.Value));

        Log(builder, logType);
        return format;
    }

    /// <summary>
    /// Formats and logs the parameter, which will remain hidden under the module's tab in the Logfile Analyzer.
    /// </summary>
    /// <param name="format">The value to log.</param>
    /// <param name="logType">The kind of logging method to invoke.</param>
    /// <returns>The parameter <paramref name="format"/>.</returns>
    public InterpolatedStringHandlerEnumerable LogLower(
        InterpolatedStringHandlerEnumerable format,
        LogType logType = LogType.Log
    )
    {
        StringBuilder builder = new(format.RecommendedLength);

        foreach (var next in format)
            builder.Append(Stringify(next.Key, next.Value));

        Log(builder, logType);
        return format;
    }

    /// <summary>Plays one or more sounds from the module <see cref="Transform"/>.</summary>
    /// <param name="sounds">The sounds to play.</param>
    /// <returns>The parameter <paramref name="sounds"/>.</returns>
    [ItemCanBeNull, NotNull]
    public IList<Sound> Play([NotNull] params Sound[] sounds) => Play(transform, sounds);

    /// <summary>Plays one or more sounds from the specified <see cref="Transform"/>.</summary>
    /// <param name="location">The source of the sound.</param>
    /// <param name="sounds">The sounds to play.</param>
    /// <returns>The parameter <paramref name="sounds"/>.</returns>
    [ItemCanBeNull, NotNull]
    public IList<Sound> Play([AllowNull, CanBeNull] Transform location, [NotNull] params Sound[] sounds)
    {
        var sources = Get<KMAudio[]>();

        if (sources.Length is not 1)
        {
            AssemblyLog(sources.Length is 0 ? TooFewAudioSources : TooManyAudioSources, LogType.Error);
            return sounds;
        }

        var source = sources[0];
        var local = location ? location : transform;

        foreach (var sound in sounds)
            sound.Play(source, local);

        return sounds;
    }

    /// <summary>Attempts to parse the <see cref="JToken"/> from the mission description.</summary>
    /// <returns>
    /// The parsed value. Note that while the return type might resemble a <c>Result</c> type, it is possible that both
    /// variants are <see cref="Maybe.None{T}"/>. However, both variants will never both be <see cref="Maybe.Some{T}"/>.
    /// </returns>
    public KeyValuePair<Maybe<JsonReaderException>, Maybe<JToken>> MissionSettings()
    {
        if (Missions.Description.Value is not { } desc)
            return default;

        var mod = Name;

        for (var i = 0; desc.IndexOf(mod, i, StringComparison.Ordinal) is not -1 and var n; i = n + mod.Length)
        {
            if (n is 0 || n + mod.Length >= desc.Length || desc[n - 1] is not '[' || desc[n + mod.Length] is not ']')
                continue;

            using SubstringReader str = new(desc, n);
            using JsonTextReader reader = new(str);

            try
            {
                return new(default, JToken.ReadFrom(reader));
            }
            catch (JsonReaderException e)
            {
                return new(e, default);
            }
        }

        return default;
    }

    /// <summary>Attempts to parse the <see cref="JToken"/> from the mission description.</summary>
    /// <typeparam name="T">The type to parse.</typeparam>
    /// <returns>
    /// The parsed value. Note that while the return type might resemble a <c>Result</c> type, it is possible that both
    /// variants are <see cref="Maybe.None{T}"/>. However, both variants will never both be <see cref="Maybe.Some{T}"/>.
    /// </returns>
    public KeyValuePair<Maybe<Exception>, Maybe<T>> MissionSettings<T>()
    {
        // ReSharper disable once MergeIntoPattern
        if (MissionSettings() is { Key.Value: var key, Value.Value: var value } && key is not null)
            return new(key, default);

        if (value is null)
            return default;

        try
        {
            return new(default, value.ToObject<T>());
        }
        catch (Exception e)
        {
            return new(e, default);
        }
    }

    /// <summary>Plays sounds and shakes the bomb from a selectable.</summary>
    /// <param name="selectable">The source of the interaction punch and sound source.</param>
    /// <param name="intensityModifier">The intensity of the interaction punch.</param>
    /// <param name="sounds">The sounds to play.</param>
    /// <returns>The parameter <paramref name="selectable"/>.</returns>
    [NotNull]
    public KMSelectable Shake(
        [NotNull] KMSelectable selectable,
        float intensityModifier = 1,
        [NotNull] params Sound[] sounds
    )
    {
        selectable.AddInteractionPunch(intensityModifier);
        var location = selectable.transform;
        Play(location, sounds);
        return selectable;
    }

    /// <summary>Solves the module.</summary>
    /// <param name="format">The value to log.</param>
    /// <param name="args">The arguments to hook into format.</param>
    /// <returns>The value <see langword="default"/>.</returns>
    [PublicAPI, StringFormatMethod(nameof(format))]
    public Unit Solve(
        [AllowNull, CanBeNull, StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format = null,
        [ItemCanBeNull, NotNull] params object[] args
    )
    {
        if (Status.IsSolved && Solvable)
            return default;

        if (Status.HasException && IsKtane && Parent<KMBomb>() is var bomb)
            bomb.SetStrikes(bomb.GetStrikes() - Status.Strikes);

        if (format is not null)
            Log(format, args);

        if (Solvable)
            Solvable.HandlePass();

        if (Needy)
            Needy.HandlePass();

        return default;
    }

    /// <summary>Strikes the module.</summary>
    /// <param name="format">The value to log.</param>
    /// <param name="args">The arguments to hook into format.</param>
    /// <returns>The value <see langword="default"/>.</returns>
    [PublicAPI, StringFormatMethod(nameof(format))]
    public Unit Strike(
        [AllowNull, CanBeNull, StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format = null,
        [ItemCanBeNull, NotNull] params object[] args
    )
    {
        if (Status.HasException)
            return default;

        if (format is not null)
            Log(format, args);

        if (Solvable)
            Solvable.HandleStrike();

        if (Needy)
            Needy.HandleStrike();

        return default;
    }

    /// <summary>
    /// Formats and logs the parameter, which will show up under the module's tab in the Logfile Analyzer.
    /// </summary>
    /// <typeparam name="T">The type of the value to log.</typeparam>
    /// <param name="format">The value to log.</param>
    /// <param name="logType">The kind of logging method to invoke.</param>
    /// <returns>The parameter <paramref name="format"/>.</returns>
    [CanBeNull]
    [return: AllowNull, NotNullIfNotNull(nameof(format))]
    public T Log<T>([AllowNull, CanBeNull] T format = default, LogType logType = LogType.Log)
    {
        var stringified = Stringify(format);
        var message = $"[{Name} #{Status.Id}] {stringified}";
        Debug.unityLogger.Log(logType, (object)message, this);
        return format;
    }

    /// <summary>
    /// Formats and logs the parameter, which will show up under the module's tab in the Logfile Analyzer.
    /// </summary>
    /// <typeparam name="T">The type of the value to log.</typeparam>
    /// <param name="format">The value to log.</param>
    /// <param name="args">The arguments to hook into format.</param>
    /// <returns>The parameter <paramref name="format"/>.</returns>
    [CanBeNull]
    [return: AllowNull, NotNullIfNotNull(nameof(format))]
    public T Log<T>(
        [AllowNull, CanBeNull, StringSyntax(StringSyntaxAttribute.CompositeFormat)] T format = default,
        [ItemCanBeNull, NotNull] params object[] args
    )
    {
        var convertAll = Array.ConvertAll<object, object>(args, Stringify);
        var stringified = Stringify(format);
        var provider = CultureInfo.InvariantCulture;
        var message = string.Format(provider, stringified, convertAll);
        Log(message);
        return format;
    }

    /// <summary>
    /// Formats and logs the parameter, which will remain hidden under the module's tab in the Logfile Analyzer.
    /// </summary>
    /// <typeparam name="T">The type of the value to log.</typeparam>
    /// <param name="format">The value to log.</param>
    /// <param name="logType">The kind of logging method to invoke.</param>
    /// <returns>The parameter <paramref name="format"/>.</returns>
    [CanBeNull]
    [return: AllowNull, NotNullIfNotNull(nameof(format))]
    public T LogLower<T>([AllowNull, CanBeNull] T format = default, LogType logType = LogType.Log)
    {
        var stringified = Stringify(format);
        var message = $"<{Name} #{Status.Id}> {stringified}";
        Debug.unityLogger.Log(logType, (object)message, this);
        return format;
    }

    /// <summary>
    /// Formats and logs the parameter, which will remain hidden under the module's tab in the Logfile Analyzer.
    /// </summary>
    /// <typeparam name="T">The type of the value to log.</typeparam>
    /// <param name="format">The value to log.</param>
    /// <param name="args">The arguments to hook into format.</param>
    /// <returns>The parameter <paramref name="format"/>.</returns>
    [CanBeNull, StringFormatMethod(nameof(format))]
    [return: AllowNull, NotNullIfNotNull(nameof(format))]
    public T LogLower<T>(
        [AllowNull, CanBeNull, StringSyntax(StringSyntaxAttribute.CompositeFormat)] T format = default,
        [ItemCanBeNull, NotNull] params object[] args
    )
    {
        var convertAll = Array.ConvertAll<object, object>(args, Stringify);
        var stringify = Stringify(format);
        var provider = CultureInfo.InvariantCulture;
        var message = string.Format(provider, stringify, convertAll);
        LogLower(message);
        return format;
    }

    /// <summary>Logs the version number for both the module and this library.</summary>
    protected virtual void Awake()
    {
        var version = $"Version: {GetModInfo(Id).Value?.Version switch
        {
            null => NotFound,
            "" => Unspecified,
            var x => x,
        }}";

        AssemblyLog($"""The module "{Name}" uses this library.""");
        Log(version);
    }

    /// <summary>The method that is called when the lights are turned on. Automatically hooked in Awake.</summary>
    /// <remarks><para>The base method doesn't do anything; Calling this base method is a no-op.</para></remarks>
    protected virtual void OnActivate() { }

    /// <summary>
    /// Unsubscribes from <see cref="Application.logMessageReceived"/>, <see cref="KMBombModule.OnActivate"/>,
    /// <see cref="KMBombModule.OnPass"/>, and <see cref="KMBombModule.OnStrike"/>.
    /// </summary>
    /// <remarks><para>It is recommended to invoke the base method when overriding this method.</para></remarks>
    protected virtual void OnDisable()
    {
        Application.logMessageReceived -= CheckForException;

        if (Solvable)
        {
            Solvable.OnPass -= OnPass;
            Solvable.OnStrike -= OnStrike;
            Solvable.OnActivate -= OnActivate;
        }

        if (!Needy)
            return;

        Needy.OnPass -= OnPass;
        Needy.OnStrike -= OnStrike;
        Needy.OnActivate -= OnActivate;
        Needy.OnNeedyActivation -= Revert;
    }

    /// <summary>
    /// Subscribes from <see cref="Application.logMessageReceived"/>, <see cref="KMBombModule.OnActivate"/>,
    /// <see cref="KMBombModule.OnPass"/>, and <see cref="KMBombModule.OnStrike"/>.
    /// </summary>
    /// <remarks><para>It is recommended to invoke the base method when overriding this method.</para></remarks>
    protected virtual void OnEnable()
    {
        Application.logMessageReceived += CheckForException;

        if (Solvable)
        {
            Solvable.OnPass += OnPass;
            Solvable.OnStrike += OnStrike;
            Solvable.OnActivate += OnActivate;
        }

        if (!Needy)
            return;

        Needy.OnPass += OnPass;
        Needy.OnStrike += OnStrike;
        Needy.OnActivate += OnActivate;
        Needy.OnNeedyActivation += Revert;
    }

    /// <summary>
    /// The method that is called when an unhandled <see cref="Exception"/> is thrown by this module type.
    /// </summary>
    /// <param name="message">The message of the <see cref="Exception"/>.</param>
    protected virtual void OnException([NotNull] string message)
    {
        Log($"Unhandled: {message}", LogType.Warning);

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

    /// <summary>Checks if a log message is an exception caused by this module, and prepares accordingly.</summary>
    /// <param name="condition">The message of the log.</param>
    /// <param name="stackTrace">The stack traces of the log.</param>
    /// <param name="type">The type of the log message.</param>
    void CheckForException([NotNull] string condition, [NotNull] string stackTrace, LogType type)
    {
        if (type is not LogType.Exception)
            return;

        var typeName = GetType().Name;
        var traces = stackTrace.Split('\n');

        if (!Array.Exists(traces, x => x.StartsWith(typeName, Ordinal)))
            return;

        Application.logMessageReceived -= CheckForException;
        Status.HasException = true;
        var rethrows = traces.TakeWhile(static s => s.StartsWith(ExceptionStackTrace, Ordinal)).ToArray();
        var innerExceptions = string.Join(Prefix, rethrows);
        var spacing = innerExceptions is "" ? "" : Prefix;
        var message = $"{condition}{spacing}{innerExceptions}";
        OnException(message);
    }

    /// <summary>Updates <see cref="Status"/> by marking it unsolved.</summary>
    void Revert() => Status.IsSolved = false;

    /// <summary>Updates <see cref="Status"/> by marking it solved.</summary>
    /// <returns>The value <see langword="false"/>.</returns>
    bool OnPass()
    {
        Status.IsSolved = true;
        return false;
    }

    /// <summary>Updates <see cref="Status"/> with a strike.</summary>
    /// <returns>The value <see langword="false"/>.</returns>
    bool OnStrike()
    {
        Status.HasStruck = true;
        Status.Strikes++;
        return false;
    }

    /// <summary>Gets the <see cref="KMSelectable"/> child row length.</summary>
    /// <returns>The number of elements in a row.</returns>
    [MustUseReturnValue]
    int GetChildSelectableRowLength() => Get<KMSelectable>().ChildRowLength;

    /// <summary>Gets the coroutine for solving the module and running the auto-solver.</summary>
    /// <returns>The coroutine for solving.</returns>
    [NotNull, Pure]
    IEnumerator WaitForSolve()
    {
        Solve();

        if (Needy)
            Needy.OnNeedyActivation += Needy.HandlePass;

        if (GetComponent<ISolvable>() is var solver && solver as Object)
            yield return solver.ForceTPSolve();
    }

    /// <summary>Gets the <see cref="KMSelectable"/> children.</summary>
    /// <returns>The children selectables.</returns>
    [ItemCanBeNull, MustUseReturnValue, NotNull]
    KMSelectable[] GetChildSelectables() => Get<KMSelectable>().Children;
}
