// SPDX-License-Identifier: MPL-2.0
#pragma warning disable CA1033
namespace Wawa.TwitchPlays;

/// <summary>
/// Base class for TwitchPlays support for solvable and needy modded modules in Keep Talking and Nobody Explodes.
/// </summary>
/// <typeparam name="TMod">
/// The <see cref="Type"/> of <see cref="Mod"/> to implement Twitch Plays support for.
/// </typeparam>
[CLSCompliant(false), PublicAPI, RequireComponent(typeof(ModdedModule)), Serializable]
public abstract class Twitch<TMod> : CachedBehaviour, ITwitchMutable
    where TMod : ModdedModule
{
    [NotNull]
    const string
        None = "There is no suitable method! Make sure you have at least one method with a return type " +
            $"{nameof(IEnumerable)} of {nameof(Instruction)} and a {nameof(CommandAttribute)} attached to said method!",
        Separator = " | ";

    [CanBeNull]
    static string s_autoImplementedHelp;

    [CanBeNull, ItemNotNull, ProvidesContext]
    static IEnumerable<CommandInfo> s_commands;

    bool _isPrintingYields;

    /// <summary>Gets the instance of the module.</summary>
    [NotNull, PublicAPI]
    public TMod Module => Get<TMod>();

    /// <summary>Gets the suggested help command. This is a fallback value used when one isn't specified.</summary>
    [PublicAPI]
    protected string AutoImplementedHelp
    {
        [NotNull] get => s_autoImplementedHelp ??= GenerateHelp();
    }

    [ItemNotNull, NotNull]
    IEnumerable<CommandInfo> Commands =>
        s_commands ??=
            GetType()
               .GetMethods(Bindings)
               .Select(CommandInfo.TryFrom)
               .Where(static c => c is not null)
               .OrderByDescending(static c => c.Command.Priority)
               .ToArray() is { Length: > 0 } query
                ? query
                : throw new MissingMethodException(None);

    /// <summary>
    /// Logs version numbers and automatically sets <see cref="Help"/>.
    /// Be sure to call this method if you are implementing Awake.
    /// </summary>
    [PublicAPI]
    protected virtual void Awake()
    {
        AssemblyLog(@$"The module ""{Module}"" uses this library.");

        if (string.IsNullOrEmpty(Help))
            Help = AutoImplementedHelp;
    }

    /// <inheritdoc />
    [PublicAPI]
    public bool IsPrintingYields
    {
        [Pure] get => _isPrintingYields;
        set
        {
            if (_isPrintingYields == value)
                return;

            if (value)
                OnYield += OnPrint;
            else
                OnYield -= OnPrint;

            _isPrintingYields = value;
        }
    }

    /// <inheritdoc />
    [PublicAPI]
    public bool IsCancelCommand
    {
        [Pure] get => TwitchShouldCancelCommand;
    }

    /// <inheritdoc />
    [PublicAPI]
    public bool IsTime
    {
        [Pure] get => TimeModeActive;
    }

    /// <inheritdoc />
    [PublicAPI]
    public bool IsTimeSkippable
    {
        [Pure] get => TwitchPlaysSkipTimeAllowed;
    }

    /// <inheritdoc />
    [PublicAPI]
    public bool IsTP
    {
        [Pure] get => TwitchPlaysActive;
    }

    /// <inheritdoc />
    [PublicAPI]
    public bool IsZen
    {
        [Pure] get => ZenModeActive;
    }

    /// <inheritdoc />
    [PublicAPI]
    public string Help
    {
        [Pure] get => TwitchHelpMessage;
        set => TwitchHelpMessage = value;
    }

    /// <inheritdoc />
    [PublicAPI, StringSyntax(StringSyntaxAttribute.Uri), UriString]
    public string Manual
    {
        [Pure] get => TwitchManualCode;
        set => TwitchManualCode = value;
    }

    /// <inheritdoc />
    [PublicAPI]
    public ReadOnlyCollection<KMBombModule> Abandons
    {
        [Pure] get => new(TwitchAbandonModule);
    }

    /// <inheritdoc />
    ModdedModule ITwitchDeclarable.Inner
    {
        [Pure] get => Module;
    }

    /// <inheritdoc />
    [PublicAPI, Pure]
    public IEnumerator ProcessTwitchCommand(string? command)
    {
        if (command is null || Match(command, out var isEmpty) is not { } match)
            yield break;

        using var e = match.GetEnumerator();
        var query = Flatten(e);

        if (!isEmpty)
            yield return null;

        while (query.MoveNext())
        {
            var current = query.Current;
            OnYield(this, new(current));

            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            if (isEmpty && !(isEmpty = false))
                yield return null;

            yield return current?.Value;
        }
    }

    /// <inheritdoc />
    [PublicAPI, Pure]
    public IEnumerator TwitchHandleForcedSolve()
    {
        using var e = ForceSolve().GetEnumerator();
        using var enumerator = Flatten(e);

        while (enumerator.MoveNext())
        {
            var current = enumerator.Current; // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
            OnYield(this, new(current));
            yield return current?.Value;
        }
    }

    /// <inheritdoc />
    [PublicAPI, Pure]
    public abstract IEnumerable<Instruction?> ForceSolve();

    /// <inheritdoc />
    void ITwitchMutable.SetIsCancelCommand(in bool value) => TwitchShouldCancelCommand = value;

    /// <inheritdoc />
    void ITwitchMutable.SetIsTime(in bool value) => TimeModeActive = value;

    /// <inheritdoc />
    void ITwitchMutable.SetIsTimeSkippable(in bool value) => TwitchPlaysSkipTimeAllowed = value;

    /// <inheritdoc />
    void ITwitchMutable.SetIsTP(in bool value) => TwitchPlaysActive = value;

    /// <inheritdoc />
    void ITwitchMutable.SetIsZen(in bool value) => ZenModeActive = value;

    /// <inheritdoc/>
    [PublicAPI, Pure] // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
    IEnumerator ISolvable.ForceTPSolve() => TwitchHandleForcedSolve();

    /// <summary>
    /// Gets or sets an event invoked whenever any command (including <see cref="TwitchString.AutoSolve"/>) yields
    /// something and is processed. The value that it yielded is passed in.
    /// </summary>
    [PublicAPI]
    public event EventHandler<YieldEventArgs> OnYield = static (_, _) => { };

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public override string ToString() => Module.ToString();

    /// <summary>
    /// You can <see langword="yield"/> <see langword="return"/> this to
    /// allow interactions of other modules until the module is solved.
    /// </summary>
    /// <returns>
    /// Repeatedly <see langword="true"/>, halting when <see cref="Modules.State.IsSolved"/>
    /// from <see cref="Module"/> is <see langword="true"/>.
    /// </returns>
    [NotNull, PublicAPI, Pure]
    public IEnumerable<Instruction> UntilSolve()
    {
        while (!Module.Status.IsSolved)
            yield return Instruction.Pause;
    }

    /// <summary>
    /// You can <see langword="yield"/> <see langword="return"/> this to
    /// allow interactions of other modules until the module has struck.
    /// </summary>
    /// <returns>
    /// Repeatedly <see langword="true"/>, halting when <see cref="Modules.State.HasStruck"/>
    /// from <see cref="Module"/> is <see langword="true"/>.
    /// </returns>
    [NotNull, PublicAPI, Pure]
    public IEnumerable<Instruction> UntilStrike()
    {
        while (!Module.Status.HasStruck)
            yield return Instruction.Pause;

        Module.Status.HasStruck = false;
    }

    /// <summary>
    /// Presses a sequence of buttons in order of <paramref name="selectables"/>,
    /// waiting <paramref name="duration"/> seconds in-between each, and interrupting as soon as
    /// <see cref="Modules.State.HasStruck"/> is <see langword="true"/>.
    /// </summary>
    /// <param name="selectables">The array of selectables to interact with.</param>
    /// <param name="duration">The delay between each button press in seconds.</param>
    /// <returns>A sequence of button presses for Twitch Plays to process.</returns>
    [ItemNotNull, NotNull, PublicAPI, Pure]
    public IEnumerable<Instruction> Sequence(
        [ItemCanBeNull, NotNull] IEnumerable<KMSelectable> selectables,
        float duration
    )
    {
        Module.Status.HasStruck = false;

        foreach (var selectable in selectables.Where(x => x))
        {
            selectable.OnInteract();
            yield return new(duration);
        }

        Module.Status.HasStruck = false;
    }

    /// <summary>
    /// Presses a sequence of buttons according to <paramref name="indices"/> within <paramref name="selectables"/>,
    /// waiting <paramref name="duration"/> seconds in-between each, and interrupting as soon as
    /// <see cref="Modules.State.HasStruck"/> is true.
    /// </summary>
    /// <param name="selectables">The array of selectables to interact with.</param>
    /// <param name="duration">The delay between each button press in seconds.</param>
    /// <param name="indices">The indices to press within the list <paramref name="selectables"/>.</param>
    /// <returns>A sequence of button presses for Twitch Plays to process.</returns>
    [ItemNotNull, NotNull, PublicAPI, Pure]
    public IEnumerable<Instruction> IndexedSequence(
        [ItemCanBeNull, NotNull] IList<KMSelectable> selectables,
        float duration,
        [NotNull] params int[] indices
    ) =>
        Array.Exists(indices, index => index < 0 || index < selectables.Count)
            ? Enumerable.Empty<Instruction>()
            : Sequence(indices.Select(x => selectables[x]), duration);

    /// <summary>
    /// Presses a sequence of buttons according to <paramref name="indices"/> within <paramref name="selectables"/>,
    /// waiting <paramref name="duration"/> seconds in-between each, and interrupting as soon as
    /// <see cref="Modules.State.HasStruck"/> is true.
    /// </summary>
    /// <param name="selectables">The array of selectables to interact with.</param>
    /// <param name="duration">The delay between each button press in seconds.</param>
    /// <param name="indices">The indices to press within the list <paramref name="selectables"/>.</param>
    /// <returns>A sequence of button presses for Twitch Plays to process.</returns>
    [ItemNotNull, NotNull, PublicAPI, Pure]
    public IEnumerable<Instruction> IndexedSequence(
        [ItemCanBeNull, NotNull] IList<KMSelectable> selectables,
        float duration,
        [NotNull] IEnumerable<int> indices
    ) =>
        IndexedSequence(selectables, duration, indices.ToArray());

    /// <summary>
    /// You can <see langword="yield"/> <see langword="return"/> this to repeatedly
    /// <see langword="yield"/> <see langword="return"/> an item until a condition is no longer met.
    /// </summary>
    /// <typeparam name="T">The <see cref="Type"/> of the items that are yielded.</typeparam>
    /// <param name="item">The item to yield repeatedly.</param>
    /// <param name="condition">The condition to repeatedly check until it returns <see langword="false"/>.</param>
    /// <returns>
    /// <paramref name="item"/> continuously until <paramref name="condition"/> is <see langword="false"/>.
    /// </returns>
    [ItemNotNull, NotNull, PublicAPI, Pure]
    protected static IEnumerable<T> YieldWhile<T>(
        [DisallowNull, NotNull] T item,
        [InstantHandle, NotNull] Func<bool> condition
    )
    {
        while (condition())
            yield return item;
    }

    /// <summary>
    /// You can <see langword="yield"/> <see langword="return"/> this to repeatedly
    /// <see langword="yield"/> <see langword="return"/> an item until a condition is met.
    /// </summary>
    /// <typeparam name="T">The <see cref="Type"/> of the items that are yielded.</typeparam>
    /// <param name="item">The item to yield repeatedly.</param>
    /// <param name="condition">The condition to repeatedly check until it returns <see langword="false"/>.</param>
    /// <returns>
    /// <paramref name="item"/> continuously until <paramref name="condition"/> is <see langword="true"/>.
    /// </returns>
    [ItemNotNull, NotNull, PublicAPI, Pure]
    protected static IEnumerable<T> YieldUntil<T>(
        [DisallowNull, NotNull] T item,
        [InstantHandle, NotNull] Func<bool> condition
    )
    {
        while (!condition())
            yield return item;
    }

    /// <summary>
    /// Splits a <see cref="string"/> into an <see cref="Array"/> of <see cref="string"/> values based on a separator.
    /// </summary>
    /// <param name="instance">The <see cref="string"/> to split.</param>
    /// <param name="separator">The separator to split each <see cref="string"/> with.</param>
    /// <returns>
    /// An <see cref="Array"/> of <see cref="string"/> values which are substrings of <paramref name="instance"/>
    /// based on <paramref name="separator"/>. Empty entries are omitted.
    /// </returns>
    [NotNull, PublicAPI, Pure]
    protected static IList<string> Split([NotNull] string instance, [NotNull] string separator = " ") =>
        instance.Split(separator.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

    [CanBeNull, MustUseReturnValue]
    [return: AllowNull]
    static object Parse([NotNull] string value, [NotNull] Type type)
    {
        bool? MatchesAlias(FieldInfo x) =>
            x.GetCustomAttributes(true)
               .OfType<AliasAttribute>()
               .FirstOrDefault()
              ?.Aliases
               .Contains(value, StringComparer.OrdinalIgnoreCase);

        bool MatchesName(FieldInfo x) => string.Equals(x.Name, value, OrdinalIgnoreCase) || (MatchesAlias(x) ?? false);

        bool IsValid(FieldInfo x) => x.Name is not InternalField && type == x.FieldType;

        object Field() =>
            type.GetFields(FieldBindings).Where(IsValid).ToArray() is { Length: > 0 } arr
                ? Array.Find(arr, MatchesName) is { } info
                    ? info.GetValue(null)
                    : ParseError.Field
                : ParseError.Unserializable;

        if (type == typeof(string) || type == typeof(object))
            return value;

        var arr = new[] { typeof(string), type.MakeByRefType() };

        if (type.GetMethod(nameof(int.TryParse), arr) is not { IsStatic: true } method ||
            method.ReturnType != typeof(bool))
            return Field();

        var args = new object[] { value, null };
        var ret = (bool)method.Invoke(null, args);

        return ret ? args[1] : ParseError.NoMatch;
    }

    [NotNull, Pure]
    static IEnumerator<Instruction?> Flatten([NotNull] IEnumerator<Instruction> source)
    {
        while (source.MoveNext())
        {
            var current = source.Current;
            var value = current?.Value;

            if (value is not IEnumerator<Instruction> nested)
            {
                yield return current;

                continue;
            }

            using var result = Flatten(nested);

            while (result.MoveNext())
                yield return result.Current;
        }
    }

    [ItemNotNull, NotNull]
    static IEnumerable<Instruction> FromFail([NotNull] in string reason) =>
        Enumerable.Repeat<Instruction>(TwitchString.SendToChatError(reason), 1);

    [ItemNotNull, MustUseReturnValue, NotNull]
    static IEnumerable<Instruction> FromFail(
        in int fail,
        [ItemNotNull, NotNull] in IList<object> args,
        [ItemNotNull, NotNull] in IList<ParameterInfo> parameters
    ) =>
        FromFail(
            @$"Invalid {Stringifier.Nth(fail, true)} parameter ""{parameters[fail].Name}"": " +
            ((ParseError)args[fail]).Reason(parameters[fail].ParameterType)
        );

    // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
    void OnPrint([NotNull] object sender, [NotNull] YieldEventArgs args) =>
        Module.Log(Stringifier.Stringify(args.Query));

    [NotNull, Pure]
    string GenerateHelp()
    {
        [NotNull, Pure]
        static string Selector([NotNull] CommandInfo x)
        {
#pragma warning disable CA1308
            var inferred = x.Method.Name.ToLowerInvariant();
#pragma warning restore CA1308
            var prefix = x.Command.Prefix.UnwrapOr(inferred);
            var args = x.Method.GetParameters().Show();
            return $"!{{0}} {prefix} {args}".TrimEnd();
        }

        return Stringifier.Conjoin(Commands.Select(Selector), Separator).Trim();
    }

    [CanBeNull, ItemNotNull, MustUseReturnValue]
    [return: AllowNull]
    IEnumerable<Instruction> Match([NotNull] string command, out bool isQueryEmpty)
    {
        var trimmed = command.Trim();
        var temp = true;

        [CanBeNull, ItemNotNull]
        [return: AllowNull]
        IEnumerable<Instruction> Locate(CommandInfo query)
        {
            var prefix = query.Prefix;
            temp = prefix is "";
            var after = trimmed.Substring(prefix.Length);
            return ProcessCommand(query, after);
        }

        var ret = Commands
           .Where(query => trimmed.StartsWith(query.Prefix, OrdinalIgnoreCase))
           .Select(Locate)
           .FirstOrDefault();

        isQueryEmpty = temp;
        return ret;
    }

    [CanBeNull, ItemNotNull, MustUseReturnValue]
    [return: AllowNull]
    IEnumerable<Instruction> ProcessCommand([NotNull] CommandInfo query, [NotNull] string message)
    {
        static bool IsParams(ICustomAttributeProvider x) =>
            x.GetCustomAttributes(typeof(ParamArrayAttribute), false).Length > 0;

        var method = query.Method;

        AssemblyLog(@$"Captured ""{method.Name}""; sending ""{message}"".");

        var split = Split(message);
        var parameters = method.GetParameters();

        if (split.Count > parameters.Length && !Array.Exists(parameters, IsParams))
            return FromFail($"Too many parameters, expected {parameters.Length}.");

        [NotNull]
        object Params(int skip)
        {
            // ReSharper disable once NullableWarningSuppressionIsUsed
            var arrType = parameters[skip].ParameterType.GetElementType()!;
            var arrLen = split.Count - skip;
            var arr = Array.CreateInstance(arrType, arrLen);

            for (var i = 0; i < arrLen; i++)
            {
                var str = split[i + skip];
                var value = Parse(str, arrType);

                if (value is ParseError)
                    return value;

                arr.SetValue(value, i);
            }

            return arr;
        }

        [CanBeNull]
        [return: AllowNull]
        object Selector([NotNull] ParameterInfo x, int i) =>
            IsParams(x) ?
                Params(i) :
                split.ElementAtOrDefault(i) is { } s ? Parse(s, x.ParameterType) :
                    x.DefaultValue is not DBNull and var o ? o : ParseError.Empty;

        var args = parameters.Select(Selector).ToArray();

        if (Array.FindIndex(args, static x => x is ParseError) is not -1 and var fail)
            return FromFail(fail, args, parameters);

        var instance = method.IsStatic ? null : this;

        return method.Invoke(instance, args) as IEnumerable<Instruction>;
    }

    // ReSharper disable InconsistentNaming ReplaceWithFieldKeyword
#pragma warning disable IDE0044, SA1306
    [UsedImplicitly]
    bool TwitchShouldCancelCommand;

    [UsedImplicitly]
    bool TimeModeActive;

    [UsedImplicitly]
    bool TwitchPlaysSkipTimeAllowed;

    [UsedImplicitly]
    bool TwitchPlaysActive;

    [UsedImplicitly]
    bool ZenModeActive;

    [NotNull, SerializeField, UsedImplicitly]
    string TwitchHelpMessage = "";

    [NotNull, SerializeField, UsedImplicitly]
    string TwitchManualCode = "";

    [ItemCanBeNull, NotNull, SerializeField, UsedImplicitly]
    List<KMBombModule> TwitchAbandonModule = new();

    // ReSharper restore InconsistentNaming ReplaceWithFieldKeyword
#pragma warning restore IDE0044, SA1306
}
