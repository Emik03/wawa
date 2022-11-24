// <copyright file="Twitch{TMod}.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
#pragma warning disable CA1033
namespace Wawa.TwitchPlays;

/// <summary>
/// Base class for TwitchPlays support for solvable and needy modded modules in Keep Talking and Nobody Explodes.
/// </summary>
/// <typeparam name="TMod">
/// The <see cref="Type"/> of <see cref="Mod"/> to implement Twitch Plays support for.
/// </typeparam>
[CLSCompliant(false), Serializable, RequireComponent(typeof(ModdedModule))]
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

    [CanBeNull]
    static IEnumerable<CommandInfo> s_commands;

    bool _isPrintingYields;

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

    [NotNull, SerializeField, UsedImplicitly]
    List<KMBombModule> TwitchAbandonModule = new();

    // ReSharper restore InconsistentNaming ReplaceWithFieldKeyword
#pragma warning restore IDE0044, SA1306

    /// <summary>
    /// Gets or sets an event invoked whenever any command (including <see cref="TwitchString.AutoSolve"/>) yields
    /// something and is processed. The value that it yielded is passed in.
    /// </summary>
    public event EventHandler<YieldEventArgs> OnYield = static (_, _) => { };

    /// <inheritdoc />
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
    public bool IsCancelCommand
    {
        [Pure] get => TwitchShouldCancelCommand;
    }

    /// <inheritdoc />
    public bool IsTime
    {
        [Pure] get => TimeModeActive;
    }

    /// <inheritdoc />
    public bool IsTimeSkippable
    {
        [Pure] get => TwitchPlaysSkipTimeAllowed;
    }

    /// <inheritdoc />
    public bool IsTP
    {
        [Pure] get => TwitchPlaysActive;
    }

    /// <inheritdoc />
    public bool IsZen
    {
        [Pure] get => ZenModeActive;
    }

    /// <inheritdoc />
    public string Help
    {
        [Pure] get => TwitchHelpMessage;
        set => TwitchHelpMessage = value;
    }

    /// <inheritdoc />
    public string Manual
    {
        [Pure] get => TwitchManualCode;
        set => TwitchManualCode = value;
    }

    /// <inheritdoc />
    public ReadOnlyCollection<KMBombModule> Abandons
    {
        [Pure] get => new(TwitchAbandonModule);
    }

    /// <inheritdoc />
    ModdedModule ITwitchDeclarable.Inner => Module;

    /// <summary>Gets the instance of the module.</summary>
    [NotNull]
    public TMod Module => Get<TMod>();

    /// <summary>Gets the suggested help command. This is a fallback value used when one isn't specified.</summary>
    protected string AutoImplementedHelp
    {
        [NotNull] get => s_autoImplementedHelp ??= GenerateHelp();
    }

    [NotNull]
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

    /// <inheritdoc />
    [Pure]
    public IEnumerator ProcessTwitchCommand(string command)
    {
        if (command is null || Match(command) is not { } match)
            yield break;

        var query = Flatten(match.GetEnumerator());

        while (query.MoveNext())
        {
            var current = query.Current;
            OnYield(this, new(current));

            yield return current?.Value;
        }
    }

    /// <inheritdoc />
    [Pure]
    public IEnumerator TwitchHandleForcedSolve()
    {
        var enumerator = Flatten(ForceSolve().GetEnumerator());

        while (enumerator.MoveNext())
        {
            var current = enumerator.Current;
            OnYield(this, new(current));

            yield return current?.Value;
        }
    }

    /// <inheritdoc />
    [Pure]
    public abstract IEnumerable<Instruction> ForceSolve();

    /// <inheritdoc/>
    [Pure]
    public override string ToString() => $@"{Module}";

    /// <summary>
    /// You can <see langword="yield"/> <see langword="return"/> this to repeatedly
    /// <see langword="yield"/> <see langword="return"/> <see langword="true"/> until the module is solved.
    /// </summary>
    /// <returns>
    /// Repeatedly <see langword="true"/>, halting when <see cref="State.IsSolved"/>
    /// from <see cref="Module"/> is <see langword="true"/>.
    /// </returns>
    [NotNull]
    public IEnumerable<bool> UntilSolve()
    {
        while (!Module.Status.IsSolved)
            yield return true;
    }

    /// <summary>
    /// You can <see langword="yield"/> <see langword="return"/> this to repeatedly
    /// <see langword="yield"/> <see langword="return"/> <see langword="true"/> until the module has struck.
    /// </summary>
    /// <returns>
    /// Repeatedly <see langword="true"/>, halting when <see cref="State.HasStruck"/>
    /// from <see cref="Module"/> is <see langword="true"/>.
    /// </returns>
    [NotNull]
    public IEnumerable<bool> UntilStrike()
    {
        while (!Module.Status.HasStruck)
            yield return true;

        Module.Status.HasStruck = false;
    }

    /// <summary>
    /// Presses a sequence of buttons in order of <paramref name="selectables"/>,
    /// waiting <paramref name="duration"/> seconds in-between each, and interrupting as soon as
    /// <see cref="State.HasStruck"/> is <see langword="true"/>.
    /// </summary>
    /// <param name="selectables">The array of selectables to interact with.</param>
    /// <param name="duration">The delay between each button press in seconds.</param>
    /// <returns>A sequence of button presses for Twitch Plays to process.</returns>
    [NotNull]
    public IEnumerable<WaitForSecondsRealtime> Sequence(
        [NotNull] IEnumerable<KMSelectable> selectables,
        float duration
    )
    {
        Module.Status.HasStruck = false;

        foreach (var selectable in selectables)
        {
            selectable.OnInteract();

            yield return new(duration);
        }

        Module.Status.HasStruck = false;
    }

    /// <summary>
    /// Presses a sequence of buttons according to <paramref name="indices"/> within <paramref name="selectables"/>,
    /// waiting <paramref name="duration"/> seconds in-between each, and interrupting as soon as
    /// <see cref="State.HasStruck"/> is true.
    /// </summary>
    /// <param name="selectables">The array of selectables to interact with.</param>
    /// <param name="duration">The delay between each button press in seconds.</param>
    /// <param name="indices">The indices to press within the array.</param>
    /// <returns>A sequence of button presses for Twitch Plays to process.</returns>
    [NotNull]
    public IEnumerable<WaitForSecondsRealtime> IndexedSequence(
        [NotNull] IList<KMSelectable> selectables,
        float duration,
        [NotNull] params int[] indices
    ) =>
        indices.Any(index => index < 0 || index < selectables.Count)
            ? Enumerable.Empty<WaitForSecondsRealtime>()
            : Sequence(indices.Select(x => selectables[x]), duration);

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
    IEnumerator ISolvable.ForceTPSolve() => TwitchHandleForcedSolve();

    /// <summary>
    /// Splits a <see cref="string"/> into an <see cref="Array"/> of <see cref="string"/> values based on a separator.
    /// </summary>
    /// <param name="instance">The <see cref="string"/> to split.</param>
    /// <param name="separator">The separator to split each <see cref="string"/> with.</param>
    /// <returns>
    /// An <see cref="Array"/> of <see cref="string"/> values which are substrings of <paramref name="instance"/>
    /// based on <paramref name="separator"/>. Empty entries are omitted.
    /// </returns>
    [NotNull]
    protected static string[] Split([NotNull] string instance, [NotNull] string separator = " ") =>
        instance.Split(separator.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

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
    [NotNull]
    protected static IEnumerable<T> YieldWhile<T>([NotNull] T item, [InstantHandle, NotNull] Func<bool> condition)
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
    [NotNull]
    protected static IEnumerable<T> YieldUntil<T>([NotNull] T item, [InstantHandle, NotNull] Func<bool> condition)
    {
        while (!condition())
            yield return item;
    }

    /// <summary>
    /// Logs version numbers and automatically sets <see cref="Help"/>.
    /// Be sure to call this method if you are implementing Awake.
    /// </summary>
    protected virtual void Awake()
    {
        AssemblyLog($@"The module ""{Module}"" uses this library.");

        if (string.IsNullOrEmpty(Help))
            Help = AutoImplementedHelp;
    }

    [NotNull]
    static string Combine([NotNull] in string main, [NotNull] params object[] toAppend)
    {
        StringBuilder builder = new(main);

        foreach (var o in toAppend)
            builder.Append(' ').Append(o);

        return builder.ToString();
    }

    [CanBeNull]
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

    [NotNull]
    static IEnumerator<Instruction?> Flatten([NotNull] IEnumerator<Instruction> source)
    {
        while (source.MoveNext())
        {
            var current = source.Current;
            var value = current?.Value;

            if (value is not IEnumerator<Instruction> nested)
            {
                yield return current;

                yield break;
            }

            var result = Flatten(nested);

            while (result.MoveNext())
                yield return result.Current;
        }
    }

    static IEnumerable<Instruction> FromFail([NotNull] in string reason) =>
        Enumerable.Repeat<Instruction>(TwitchString.SendToChatError(reason), 1);

    [NotNull]
    static IEnumerable<Instruction> FromFail(
        in int fail,
        [NotNull] in IList<object> args,
        [NotNull] in IList<ParameterInfo> parameters
    ) =>
        FromFail(
            $@"Invalid {fail.Nth(true)} parameter ""{parameters[fail].Name}"": " +
            ((ParseError)args[fail]).Reason(parameters[fail].ParameterType)
        );

    // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
    void OnPrint([NotNull] object sender, [NotNull] YieldEventArgs args) => Module.Log(args.Query.Stringify());

    [NotNull]
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
            return $@"!{{0}} {prefix} {args}".TrimEnd();
        }

        return Commands.Select(Selector).Conjoin(Separator).Trim();
    }

    [CanBeNull]
    [return: AllowNull]
    IEnumerable<Instruction> Match([NotNull] string command)
    {
        var trimmed = command.Trim();

        return Commands
           .Where(query => trimmed.StartsWith(query.Prefix, OrdinalIgnoreCase))
           .Select(query => ProcessCommand(query, trimmed.Substring(query.Prefix.Length)))
           .FirstOrDefault();
    }

    [CanBeNull]
    [return: AllowNull]
    IEnumerable<Instruction> ProcessCommand([NotNull] CommandInfo query, [NotNull] string message)
    {
        static bool IsParams(ICustomAttributeProvider x) =>
            x.GetCustomAttributes(typeof(ParamArrayAttribute), false).Length > 0;

        var method = query.Method;

        AssemblyLog($@"Captured ""{method.Name}""; sending ""{message}"".");

        var split = Split(message);
        var parameters = method.GetParameters();

        if (split.Length > parameters.Length && !parameters.Any(IsParams))
            return FromFail($@"Too many parameters, expected {parameters.Length}.");

        object Params(int skip)
        {
            var arrType = parameters[skip].ParameterType.GetElementType() ?? throw new();
            var arrLen = split.Length - skip;
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
}
