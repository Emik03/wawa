﻿// SPDX-License-Identifier: MPL-2.0
namespace wawa.TwitchPlays;

/// <summary>
/// Base class for TwitchPlays support for solvable and needy modded modules in Keep Talking and Nobody Explodes.
/// </summary>
/// <typeparam name="TMod">
/// The <see cref="Type"/> of <see cref="Mod"/> to implement Twitch Plays support for.
/// </typeparam>
// ReSharper disable InconsistentNaming
[CLSCompliant(false), PublicAPI, RequireComponent(typeof(ModdedModule)), Serializable]
public abstract class Twitch<TMod> : CachedBehaviour, ITwitchMutable
    where TMod : ModdedModule
{
    /// <summary>The message shown when an error occurs.</summary>
    [NotNull]
    const string
        MessageThenCancel = $"The first yield of the command is a {nameof(TwitchString)} that is true on " +
            $"{nameof(TwitchString.IsSendMessage)}. This is usually an indication that the command was invalid, " +
            "and therefore the command will stop processing. If this behavior is undesired, then yield return null, " +
            $"{nameof(Instruction.FrameAdvance)}, or anything else before the afforementioned {nameof(TwitchString)}.",
        None = "There is no suitable method! Make sure you have at least one method with a return type " +
            $"{nameof(IEnumerable)} of {nameof(Instruction)} and a {nameof(CommandAttribute)} attached to said method!",
        Separator = " | ",
        WrongType = "A value was yielded in which the Twitch Plays autosolver currently doesn't support. " +
            "You will need to use a workaround, such as modifying the transform directly or invoking the callback.";

    /// <summary>Contains the cached help message.</summary>
    [CanBeNull]
    static string s_autoImplementedHelp;

    /// <summary>Contains the cached available commands.</summary>
    [CanBeNull, ItemNotNull]
    static CommandInfo[] s_commands;

    /// <summary>Determines whether to print the yields.</summary>
    bool _isPrintingYields;

    /// <summary>Declared for reflection interop with Twitch Plays.</summary>
    [UsedImplicitly]
    bool TwitchShouldCancelCommand, TimeModeActive, TwitchPlaysSkipTimeAllowed, TwitchPlaysActive, ZenModeActive;

    /// <summary>Declared for reflection interop with Twitch Plays.</summary>
    [NotNull, SerializeField, UsedImplicitly]
    string TwitchHelpMessage = "", TwitchManualCode = "";

    /// <summary>Declared for reflection interop with Twitch Plays.</summary>
    [ItemCanBeNull, NotNull, SerializeField, UsedImplicitly]
#pragma warning disable IDE0044
    List<KMBombModule> TwitchAbandonModule = [];
#pragma warning restore IDE0044
    /// <summary>Gets the suggested help command. This is a fallback value used when one isn't specified.</summary>
    [PublicAPI]
    public string AutoImplementedHelp
    {
        [NotNull] get => s_autoImplementedHelp ??= GenerateHelp();
    }

    /// <summary>Gets the instance of the module.</summary>
    [NotNull, PublicAPI]
    public TMod Module => Get<TMod>();

    /// <summary>Gets the available commands.</summary>
    [ItemNotNull, NotNull]
    IEnumerable<CommandInfo> Commands
    {
        get
        {
            if (s_commands is not null)
                return s_commands;

            s_commands =
            [
                ..GetType()
                   .GetMethods(Bindings)
                   .Select(CommandInfo.TryFrom)
                   .Where(static c => c is not null)
                   .OrderByDescending(static c => c.Command.Priority),
            ];

            if (s_commands.Length is 0)
                AssemblyLog(None, LogType.Error);

            return s_commands;
        }
    }

    /// <summary>
    /// Logs version numbers and automatically sets <see cref="Help"/>.
    /// Be sure to call this method if you are implementing Awake.
    /// </summary>
    [PublicAPI]
    protected virtual void Awake()
    {
        AssemblyLog($"""The module "{Module}" uses this library.""");

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
    [PublicAPI, Pure] // ReSharper disable once AnnotationRedundancyInHierarchy
    public IEnumerator ProcessTwitchCommand([AllowNull, CanBeNull] string command)
    {
        if (command is null || Match(command, out var isWildcard) is not { } match)
            yield break;

        using var enumerator = match.GetEnumerator();
        using var flattened = enumerator.Flatten();

        switch (flattened.Current?.Value)
        {
            case var _ when !flattened.MoveNext():
                if (!isWildcard)
                    yield break;

                OnYield(this, new(null));
                yield return null;

                yield break;
            case TwitchString { IsSendMessage: true }:
                if (!Access.IsKtane)
                    AssemblyLog(MessageThenCancel);

                yield break;
            case not null:
                OnYield(this, new(null));
                yield return null;

                break;
        }

        do
        {
            var current = flattened.Current;
            OnYield(this, new(current));
            yield return current?.Value;
        } while (flattened.MoveNext());
    }

    /// <inheritdoc />
    [PublicAPI, Pure]
    public IEnumerator TwitchHandleForcedSolve()
    {
        using var enumerator = ForceSolve().GetEnumerator();
        using var flattened = enumerator.Flatten();

        while (flattened.MoveNext())
        {
            if (!Access.IsKtane && flattened.Current is { UsableInForcedSolve: false })
                AssemblyLog(WrongType, LogType.Error);

            var current = flattened.Current;
            OnYield(this, new(current));
            yield return current?.Value;
        }
    }

    /// <inheritdoc />
    [PublicAPI, Pure]
    public abstract IEnumerable<Instruction?> ForceSolve();

    /// <inheritdoc />
    void ITwitchMutable.SetIsCancelCommand(bool value) => TwitchShouldCancelCommand = value;

    /// <inheritdoc />
    void ITwitchMutable.SetIsTime(bool value) => TimeModeActive = value;

    /// <inheritdoc />
    void ITwitchMutable.SetIsTimeSkippable(bool value) => TwitchPlaysSkipTimeAllowed = value;

    /// <inheritdoc />
    void ITwitchMutable.SetIsTP(bool value) => TwitchPlaysActive = value;

    /// <inheritdoc />
    void ITwitchMutable.SetIsZen(bool value) => ZenModeActive = value;

    /// <inheritdoc/>
    [PublicAPI, Pure]
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

        foreach (var selectable in selectables.Where(x => x).TakeWhile(_ => !Module.Status.HasStruck))
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
            ? []
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
        IndexedSequence(selectables, duration, [..indices]);

    /// <summary>Determines whether two strings are equal, without accounting for case.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if the parameters <paramref name="left"/> and
    /// <paramref name="right"/> are equal to each other according to the comparison type
    /// <see cref="StringComparison.OrdinalIgnoreCase"/>; otherwise, <see langword="false"/>.
    /// </returns>
    [PublicAPI, Pure]
    protected static bool Equal([AllowNull, CanBeNull] string left, [AllowNull, CanBeNull] string right) =>
        string.Equals(left, right, StringComparison.OrdinalIgnoreCase);

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

    [NotNull, Pure]
    static string Ordinal([NonNegativeValue] int i) =>
        (i % 10) switch
        {
            _ when i / 10 % 10 is 1 => "th",
            1 => "st",
            2 => "nd",
            3 => "rd",
            _ => "th",
        };

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
                ? Array.Find(arr, MatchesName) is { } info ? info.GetValue(null) : ParseError.Field
                : ParseError.Unserializable;

        if (type == typeof(string) || type == typeof(object))
            return value;

        Type[] signature = [typeof(string), type.MakeByRefType()];

        if (type.GetMethod(nameof(int.TryParse), signature) is not { IsStatic: true } method ||
            method.ReturnType != typeof(bool))
            return Field();

        object[] args = [value, null];
        return method.Invoke(null, args) is true ? args[1] : ParseError.NoMatch;
    }

    [ItemNotNull, NotNull]
    static IEnumerable<Instruction> FromFail([NotNull] in string reason) =>
        Enumerable.Repeat<Instruction>(TwitchString.SendToChatError(reason), 1);

    [ItemNotNull, MustUseReturnValue, NotNull]
    static IEnumerable<Instruction> FromFail(
        [NonNegativeValue] int fail,
        [ItemNotNull, NotNull] in object[] args,
        [ItemNotNull, NotNull] in ParameterInfo[] parameters
    ) =>
        FromFail(
            $"""Invalid {Ordinal(fail + 1)} parameter "{parameters[fail].Name}": {
                ((ParseError)args[fail]).Reason(parameters[fail].ParameterType)
            }"""
        );

    /// <summary>Prints the yielded instruction.</summary>
    /// <param name="sender">The sender.</param>
    /// <param name="args">The yielded instruction.</param>
    void OnPrint([NotNull] object sender, [NotNull] YieldEventArgs args) =>
        Module.Log(Module.Stringify(args.Query));

    /// <summary>Generates the help text.</summary>
    /// <returns>The help text.</returns>
    [NotNull, Pure]
    string GenerateHelp()
    {
        [NotNull, Pure]
        static string Selector([NotNull] CommandInfo x)
        {
            var inferred = x.Method.Name.ToLowerInvariant();
            var prefix = x.Command.Prefix.UnwrapOr(inferred);
            var args = x.Method.GetParameters().Show();
            return $"!{{0}} {prefix} {args}".TrimEnd();
        }

        return string.Join(Separator, [..Commands.Select(Selector)]).Trim();
    }

    /// <summary>Finds the set of instructions corresponding to the command.</summary>
    /// <param name="command">The contents of the command.</param>
    /// <param name="isWildcard">Whether the instructions returned came from a wildcard method.</param>
    /// <returns>The instructions to send.</returns>
    [CanBeNull, ItemNotNull, MustUseReturnValue]
    [return: AllowNull]
    IEnumerable<Instruction> Match([NotNull] string command, out bool isWildcard)
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

        isWildcard = temp;
        return ret;
    }

    /// <summary>Processes the command.</summary>
    /// <param name="query">The query.</param>
    /// <param name="message">The contents of the command.</param>
    /// <returns>The instructions to send.</returns>
    [CanBeNull, ItemNotNull, MustUseReturnValue]
    [return: AllowNull] // ReSharper disable once CognitiveComplexity
    IEnumerable<Instruction> ProcessCommand([NotNull] CommandInfo query, [NotNull] string message)
    {
        static bool IsParams(ICustomAttributeProvider x) => x.IsDefined(typeof(ParamArrayAttribute), false);

        var method = query.Method;
        AssemblyLog($"""Captured "{method.Name}"; sending "{message}".""");
        var split = Split(message);
        var parameters = method.GetParameters();

        if (split.Count > parameters.Length && !Array.Exists(parameters, IsParams))
            return FromFail($"Too many parameters, expected {parameters.Length}.");

        [CanBeNull]
        [return: AllowNull]
        object Selector([NotNull] ParameterInfo x, int i) =>
            IsParams(x) ? x.ParameterType.IsArray ? ParamsArray(i) : ParamsCollections(x, i) :
            split.ElementAtOrDefault(i) is { } s ? Parse(s, x.ParameterType) :
            x.DefaultValue is not DBNull and var o ? o : ParseError.Empty;

        [NotNull]
        object ParamsArray(int skip)
        {
            // ReSharper disable once NullableWarningSuppressionIsUsed
            var arrType = parameters[skip].ParameterType.GetElementType()!;
            var arr = Array.CreateInstance(arrType, split.Count - skip);

            for (var i = skip; i < split.Count; i++)
                if (Parse(split[i], arrType) is var value && value is ParseError)
                    return value;
                else
                    arr.SetValue(value, i);

            return arr;
        }

        [NotNull]
        object ParamsCollections(ParameterInfo x, int skip)
        {
            var col = Activator.CreateInstance(x.ParameterType);

            if (x.ParameterType.GetMethod(nameof(IList.Add), Public | Instance) is not { } add ||
                add.GetParameters().FirstOrDefault() is not { ParameterType: var colType })
                return col;

            for (var i = skip; i < split.Count; i++)
                if (Parse(split[i], colType) is var value && value is ParseError)
                    return value;
                else
                    add.Invoke(col, [value]);

            return col;
        }

        var args = parameters.Select(Selector).ToArray();

        if (Array.FindIndex(args, static x => x is ParseError) is not -1 and var fail)
            return FromFail(fail, args, parameters);

        var instance = method.IsStatic ? null : this;
        return method.Invoke(instance, args) as IEnumerable<Instruction>;
    }
}
