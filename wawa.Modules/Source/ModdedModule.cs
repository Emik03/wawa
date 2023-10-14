// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Modules;

/// <summary>
/// A <see cref="Component"/> that handles general Keep Talking and Nobody Explodes modded module behaviour.
/// </summary>
// ReSharper disable Unity.PerformanceCriticalCodeInvocation
[CLSCompliant(false), PublicAPI]
public abstract class ModdedModule : CachedBehaviour
{
    [NotNull]
    const string
        ExceptionStackTrace = "Rethrow as ",
        NoComponent = $"There is no attached {nameof(KMBombModule)} or {nameof(KMNeedyModule)}.",
        NotFound = "[[HYPERLINK BLOCKED]]",
        LengthNotSet =
            $"The {nameof(KMSelectable)} attached to this {nameof(GameObject)} has a " +
            $"{nameof(KMSelectable.ChildRowLength)} set to 0 or less. Be sure to set this to a natural number so " +
            "that the matrix can be instantiated properly.",
        Prefix = @"
| ",
        TooFewAudioSources = $"You need a {nameof(KMAudio)} component to play a sound. " +
            "It cannot be instantiated by this library, since the game could hook before this library can create one.",
        TooManyAudioSources =
            $"There is more than one {nameof(KMAudio)} component. " +
            "This is considered a mistake because the game will only add the sounds to one of the " +
            $"{nameof(KMAudio)} components, which gives no certainty on the {nameof(KMAudio)} having sounds assigned.",
        Unspecified = "There is no version. Press [F5] or go to [Keep Talking ModKit > Configure Mod] to specify one.";

    [CanBeNull]
    string _id;

    [CanBeNull]
    IList<IList<KMSelectable>>? _matrix;

    [CanBeNull]
    KMNeedyModule _needy;

    [CanBeNull]
    KMBombModule _solvable;

    [CanBeNull]
    State _status;

    /// <summary>Gets the children of the top-level selectable.</summary>
    /// <exception cref="MissingComponentException">
    /// There is no <see cref="KMSelectable"/> <see cref="Component"/> attached to this <see cref="GameObject"/>.
    /// </exception>
    [PublicAPI]
    public IList<KMSelectable> Children
    {
        [ItemCanBeNull, NotNull, MustUseReturnValue] get => Get<KMSelectable>().Children;
    }

    /// <summary>Gets the children of the top-level selectable.</summary>
    /// <remarks><para>
    /// Unlike <see cref="Children"/>, this returns a 2-dimensional list by mapping
    /// it with inference from <see cref="KMSelectable.ChildRowLength"/>.
    /// </para></remarks>
    /// <exception cref="InvalidOperationException">
    /// The <see cref="KMSelectable"/> <see cref="Component"/> attached to this <see cref="GameObject"/> has a
    /// <see cref="KMSelectable.ChildRowLength"/> value of 0.
    /// </exception>
    /// <exception cref="MissingComponentException">
    /// There is no <see cref="KMSelectable"/> <see cref="Component"/> attached to this <see cref="GameObject"/>.
    /// </exception>
    [PublicAPI]
    public IList<IList<KMSelectable>> Matrix
    {
        [ItemCanBeNull, NotNull, MustUseReturnValue]
        get =>
            _matrix ??= Get<KMSelectable>().ChildRowLength > 0
                ? new Matrix<KMSelectable>(() => Children, () => Get<KMSelectable>().ChildRowLength)
                : throw new InvalidOperationException(LengthNotSet);
    }

    /// <summary>Gets the current solve/strike status of the module.</summary>
    [NotNull]
    public State Status
    {
        [Pure] get => _status ??= new(Name);
    }

    /// <summary>
    /// Gets the mod id. Override this if you are working with an assembly with a different name than your mod id.
    /// </summary>
    [NotNull]
    protected virtual string Id
    {
        [MustUseReturnValue] get => _id ??= Lookup.ModNameOf(this).Value ?? GetType().Assembly.GetName().Name;
    }

    // DO NOT REMOVE. The mod 'Tweaks' uses reflection to get any field/property named "moduleId". (case-insensitive)
    [UsedImplicitly]
    int ModuleId
    {
        [Pure] get => Status.Id;
    }

    [NotNull]
    string Name
    {
        [Pure]
        get =>
            Solvable ? Solvable.ModuleDisplayName :
            Needy ? Needy.ModuleDisplayName : throw new MissingComponentException(NoComponent);
    }

    [AllowNull, CanBeNull]
    KMBombModule Solvable
    {
        [Pure] get => _solvable ??= GetComponent<KMBombModule>();
    }

    [AllowNull, CanBeNull]
    KMNeedyModule Needy
    {
        [Pure] get => _needy ??= GetComponent<KMNeedyModule>();
    }

    /// <summary>Logs version numbers. Be sure to call this method if you are implementing Awake.</summary>
    /// <exception cref="InvalidOperationException">
    /// A loaded mod has a null mod id, or has an id that conflicts with another loaded mod.
    /// </exception>
    protected virtual void Awake()
    {
        var version = $"Version: {GetModInfo(Id).Value?.Version switch
        {
            null => NotFound,
            "" => Unspecified,
            var x => x,
        }}";

        AssemblyLog(@$"The module ""{Name}"" uses this library.");
        Log(version);
    }

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
            Solvable.OnActivate -= OnActivate;
            Solvable.OnPass -= OnPass;
            Solvable.OnStrike -= OnStrike;
        }

        if (!Needy)
            return;

        Needy.OnActivate -= OnActivate;
        Needy.OnPass -= OnPass;
        Needy.OnStrike -= OnStrike;
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
            Solvable.OnActivate += OnActivate;
            Solvable.OnPass += OnPass;
            Solvable.OnStrike += OnStrike;
        }

        if (!Needy)
            return;

        Needy.OnActivate += OnActivate;
        Needy.OnPass += OnPass;
        Needy.OnStrike += OnStrike;
    }

    /// <inheritdoc/>
    [Pure]
    public override string ToString() => Name;

    /// <summary>Plays one or more sounds from the module <see cref="Transform"/>.</summary>
    /// <exception cref="InvalidOperationException">
    /// There isn't exactly 1 <see cref="KMAudio"/> <see cref="Component"/> attached to this <see cref="GameObject"/>.
    /// </exception>
    /// <param name="sounds">The sounds to play.</param>
    /// <returns>The parameter <paramref name="sounds"/>.</returns>
    [ItemCanBeNull, NotNull]
    public IList<Sound> Play([InstantHandle, ItemCanBeNull, NotNull] params Sound[] sounds) =>
        PlayEnum(sounds, transform);

    /// <summary>Plays one or more sounds from a specified <see cref="Transform"/>.</summary>
    /// <exception cref="InvalidOperationException">
    /// There isn't exactly 1 <see cref="KMAudio"/> <see cref="Component"/> attached to this <see cref="GameObject"/>.
    /// </exception>
    /// <param name="location">The source of the sound.</param>
    /// <param name="sounds">The sounds to play.</param>
    /// <returns>The parameter <paramref name="sounds"/>.</returns>
    [ItemCanBeNull, NotNull]
    public IList<Sound> Play(
        [NotNull] Transform location,
        [InstantHandle, ItemCanBeNull, NotNull] params Sound[] sounds
    ) =>
        PlayEnum(sounds, location);

    /// <summary>Plays one or more sounds from a specified <see cref="Transform"/>.</summary>
    /// <typeparam name="T">The type of iterator.</typeparam>
    /// <exception cref="InvalidOperationException">
    /// There isn't exactly 1 <see cref="KMAudio"/> <see cref="Component"/> attached to this <see cref="GameObject"/>.
    /// </exception>
    /// <param name="sounds">The sounds to play.</param>
    /// <param name="location">The source of the sound.</param>
    /// <returns>The parameter <paramref name="sounds"/>.</returns>
    [ItemCanBeNull, NotNull]
    public T PlayEnum<T>(
        [InstantHandle, ItemCanBeNull, NotNull] T sounds,
        [AllowNull, CanBeNull] Transform location = null
    )
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
        [ItemCanBeNull, NotNull] params Sound[] sounds
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
    [PublicAPI, StringFormatMethod(nameof(format))]
    public Unit Solve(
        [AllowNull, CanBeNull, StringSyntax(StringSyntaxAttribute.CompositeFormat)] string format = null,
        [ItemCanBeNull, NotNull] params object[] args
    )
    {
        if (Status.IsSolved)
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
        var stringify = Stringifier.Stringify(format);
        var message = $"[{Name} #{id}] {stringify}";

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
    public T Log<T>(
        [AllowNull, CanBeNull, StringSyntax(StringSyntaxAttribute.CompositeFormat)] T format = default,
        [ItemCanBeNull, NotNull] params object[] args
    )
    {
        var convertAll = Array.ConvertAll(args, static o => (object)Stringifier.Stringify(o));
        var stringify = Stringifier.Stringify(format);
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
        var message = $"<{Name} #{Status.Id}> {Stringifier.Stringify(format)}";

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
    [CanBeNull, StringFormatMethod(nameof(format))]
    [return: AllowNull]
    public T LogLower<T>(
        [AllowNull, CanBeNull, StringSyntax(StringSyntaxAttribute.CompositeFormat)] T format = default,
        [ItemCanBeNull, NotNull] params object[] args
    )
    {
        var convertAll = Array.ConvertAll(args, static o => (object)Stringifier.Stringify(o));
        var stringify = Stringifier.Stringify(format);
        var provider = CultureInfo.InvariantCulture;
        var message = string.Format(provider, stringify, convertAll);

        LogLower(message);

        return format;
    }

    /// <summary>The method that is called when the lights are turned on. Automatically hooked in Awake.</summary>
    /// <remarks><para>The base method doesn't do anything; Calling this base method is a no-op.</para></remarks>
    protected virtual void OnActivate() { }

    /// <summary>
    /// The method that is called when an unhandled <see cref="Exception"/> is thrown by this module type.
    /// </summary>
    /// <param name="message">The message of the <see cref="Exception"/>.</param>
    protected virtual void OnException([NotNull] string message)
    {
        var formatted = $"Unhandled: {message}";

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

    [ItemCanBeNull, NotNull]
    static T Play<T>([NotNull] in Transform location, [ItemCanBeNull, NotNull] in T sounds, [NotNull] in KMAudio source)
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

        if (Array.Exists(traces, x => x.StartsWith(typeName, Ordinal)))
            PrepareException(condition, traces);
    }

    void PrepareException([NotNull] string condition, [ItemNotNull, NotNull] IEnumerable<string> traces)
    {
        Application.logMessageReceived -= CheckForException;
        Status.HasException = true;

        var rethrows = traces.TakeWhile(static s => s.StartsWith(ExceptionStackTrace, Ordinal)).ToArray();
        var innerExceptions = string.Join(Prefix, rethrows);
        var spacing = innerExceptions is "" ? "" : Prefix;
        var message = $"{condition}{spacing}{innerExceptions}";

        OnException(message);
    }

    bool OnPass()
    {
        Status.IsSolved = true;
        return false;
    }

    bool OnStrike()
    {
        Status.HasStruck = true;
        Status.Strikes++;
        return false;
    }

    [NotNull]
    IEnumerator WaitForSolve()
    {
        Solve();

        // ReSharper disable once SuspiciousTypeConversion.Global
        if (GetComponent<ISolvable>() is var solver && solver as Object)
            yield return solver.ForceTPSolve();
    }
}
