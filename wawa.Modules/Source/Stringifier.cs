#region Emik.MPL

// <copyright file="Stringifier.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

namespace Wawa.Modules;

/// <summary>Provides stringification methods.</summary>
[PublicAPI]
public static class Stringifier
{
    [NotNull]
    const string
        Else = "th",
        False = "false",
        First = "st",
        KeyValueSeparator = ": ",
        Negative = "-",
        Null = "null",
        Second = "nd",
        Separator = ", ",
        Third = "rd",
        True = "true";

    [NotNull]
    static readonly Dictionary<Type, bool> s_hasMethods = new();

    [NotNull]
    static readonly Dictionary<Type, Delegate> s_stringifiers = new();

    [NotNull]
    static readonly ConstantExpression
        s_exEmpty = Expression.Constant(""),
        s_exFalse = Expression.Constant(false),
        s_exSeparator = Expression.Constant(Separator),
        s_exTrue = Expression.Constant(true);

    [NotNull]
    static readonly MethodInfo
        s_combine = ((Func<string, string, string>)string.Concat).Method,
        s_stringify = ((Func<bool, bool, bool, string>)Stringify).Method.GetGenericMethodDefinition();

    /// <summary>Joins a set of values into one long <see cref="string"/>.</summary>
    /// <remarks><para>
    /// This method is more efficient than using
    /// <see cref="Conjoin{T}(IEnumerable{T}, string)"/> for <see cref="char"/> separators.
    /// </para></remarks>
    /// <typeparam name="T">The type of each item in the collection.</typeparam>
    /// <param name="values">The values to join.</param>
    /// <param name="separator">The separator between each item.</param>
    /// <returns>One long <see cref="string"/>.</returns>
    [Pure]
    public static string Conjoin<T>([ItemCanBeNull, NotNull] IEnumerable<T> values, char separator)
    {
        StringBuilder build = new();
        using var enumerator = values.GetEnumerator();

        if (enumerator.MoveNext())
            build.Append(enumerator.Current);
        else
            return "";

        while (enumerator.MoveNext())
            build.Append(separator).Append(enumerator.Current);

        return build.ToString();
    }

    /// <summary>Joins a set of values into one long <see cref="string"/>.</summary>
    /// <typeparam name="T">The type of each item in the collection.</typeparam>
    /// <param name="values">The values to join.</param>
    /// <param name="separator">The separator between each item.</param>
    /// <returns>One long <see cref="string"/>.</returns>
    [Pure]
    public static string Conjoin<T>(
        [ItemCanBeNull, NotNull] IEnumerable<T> values,
        [NotNull] string separator = Separator
    )
    {
        StringBuilder build = new();
        using var enumerator = values.GetEnumerator();

        if (enumerator.MoveNext())
            build.Append(enumerator.Current);
        else
            return "";

        while (enumerator.MoveNext())
            build.Append(separator).Append(enumerator.Current);

        return build.ToString();
    }

    /// <summary>Converts a number to an ordinal.</summary>
    /// <param name="i">The number to convert.</param>
    /// <param name="indexByZero">Determines whether to index from zero or one.</param>
    /// <returns>The parameter <paramref name="i"/> as an ordinal.</returns>
    [Pure]
    public static string Nth(int i, bool indexByZero = false) => indexByZero ? (i + 1).ToOrdinal() : i.ToOrdinal();

    /// <summary>
    /// Converts <paramref name="source"/> into a <see cref="string"/> representation of <paramref name="source"/>.
    /// </summary>
    /// <remarks><para>
    /// Unlike <see cref="object.ToString"/>, the values of all properties are printed out,
    /// unless they explicitly define a <see cref="object.ToString"/>, or inherit <see cref="IEnumerable"/>,
    /// in which case each item within is printed out separately.
    /// </para></remarks>
    /// <typeparam name="T">The type of the source.</typeparam>
    /// <param name="source">The item to get a <see cref="string"/> representation of.</param>
    /// <returns><paramref name="source"/> as <see cref="string"/>.</returns>
    [MustUseReturnValue]
    public static string Stringify<T>([AllowNull, CanBeNull] T source) => Stringify(source, false, true);

    /// <summary>
    /// Converts <paramref name="source"/> into a <see cref="string"/> representation of <paramref name="source"/>.
    /// </summary>
    /// <remarks><para>
    /// Unlike <see cref="object.ToString"/>, the values of all properties are printed out,
    /// unless they explicitly define a <see cref="object.ToString"/>, or inherit <see cref="IEnumerable"/>,
    /// in which case each item within is printed out separately.
    /// </para></remarks>
    /// <typeparam name="T">The type of the source.</typeparam>
    /// <param name="source">The item to get a <see cref="string"/> representation of.</param>
    /// <param name="isSurrounded">
    /// Determines whether <see cref="string"/> and <see cref="char"/> have a " and ' surrounding them.
    /// </param>
    /// <param name="isRecursive">
    /// Determines whether it re-calls <see cref="Stringify{T}(T, bool, bool)"/>
    /// on each property in <paramref name="source"/>.
    /// </param>
    /// <returns><paramref name="source"/> as <see cref="string"/>.</returns>
    [MustUseReturnValue]
    public static string Stringify<T>([AllowNull, CanBeNull] T source, bool isSurrounded, bool isRecursive) =>
        source switch
        {
            null => Null,
            bool b => b ? True : False,
            char c => isSurrounded ? $"'{c}'" : $"{c}",
            string s => isSurrounded ? @$"""{s}""" : s,
            IFormattable i => i.ToString(null, CultureInfo.InvariantCulture),
            IDictionary d => $"{{ {d.DictionaryStringifier()} }}",
            ICollection l => $"{l.Count} [{l.GetEnumerator().EnumeratorStringifier()}]",
            IEnumerable e => $"[{e.GetEnumerator().EnumeratorStringifier()}]",
            _ => source.StringifyObject(isRecursive),
        };

    static void AppendKeyValuePair([NotNull] this StringBuilder build, [NotNull] string key, [NotNull] string value) =>
        build.Append(key).Append(KeyValueSeparator).Append(value);

    [Pure]
    static int Mod(this in int i) => Math.Abs(i) / 10 % 10 == 1 ? 0 : Math.Abs(i) % 10;

    [NotNull, Pure]
    static string ToOrdinal(this int i) =>
        @$"{(i < 0 ? Negative : "")}{i}{Mod(i) switch
        {
            1 => First,
            2 => Second,
            3 => Third,
            _ => Else,
        }}";

    [NotNull, Pure]
    static StringBuilder DictionaryStringifier([NotNull] this IDictionary dictionary)
    {
        var iterator = dictionary.GetEnumerator();
        StringBuilder builder = new();

        if (iterator.MoveNext())
            builder.AppendKeyValuePair(Stringify(iterator.Key), Stringify(iterator.Value));

        while (iterator.MoveNext())
            builder.Append(Separator).AppendKeyValuePair(Stringify(iterator.Key), Stringify(iterator.Value));

        return builder;
    }

    [NotNull, Pure]
    static StringBuilder EnumeratorStringifier([NotNull] this IEnumerator iterator)
    {
        StringBuilder builder = new();

        if (iterator.MoveNext())
            builder.Append(Stringify(iterator.Current));

        while (iterator.MoveNext())
            builder.Append(Separator).Append(Stringify(iterator.Current));

        return builder;
    }

    [MustUseReturnValue, NotNull]
    static string StringifyObject<T>([AllowNull, CanBeNull] this T source, bool isRecursive)
    {
        if (typeof(T) == typeof(object))
            return source?.ToString() ?? Null;

        if (!s_hasMethods.ContainsKey(typeof(T)))
#pragma warning disable CS0253
            s_hasMethods[typeof(T)] =
                typeof(object) == typeof(T).GetMethod(nameof(ToString), Type.EmptyTypes)?.DeclaringType;
#pragma warning restore CS0253

        if (s_hasMethods[typeof(T)] || !isRecursive)
            return source?.ToString() ?? Null;

        if (!s_stringifiers.ContainsKey(typeof(T)))
            s_stringifiers[typeof(T)] = GenerateStringifier<T>();

        return $"{typeof(T).Name} {{ {((Func<T, string>)s_stringifiers[typeof(T)])(source)} }}";
    }

    [MustUseReturnValue, NotNull]
    static Func<T, string> GenerateStringifier<T>()
    {
        var exParam = Expression.Parameter(typeof(T), nameof(T));

        var array = typeof(T) // ReSharper disable ArrangeStaticMemberQualifier
           .GetProperties(BindingFlags.Instance | BindingFlags.Public)
           .Where(p => p.CanRead && p.GetCustomAttributes(true).All(x => x?.GetType() != typeof(ObsoleteAttribute)))
           .Select(p => GetMethodCaller(p, exParam))
           .ToList();

        [NotNull, Pure]
        static MethodCallExpression Combine([NotNull] MethodCallExpression prev, [NotNull] MethodCallExpression curr)
        {
            var call = Expression.Call(s_combine, prev, s_exSeparator);
            return Expression.Call(s_combine, call, curr);
        }

        Expression exResult = array.Any()
            ? array.Aggregate(Combine)
            : s_exEmpty;

        return Expression
           .Lambda<Func<T, string>>(exResult, exParam)
           .Compile();
    }

    [MustUseReturnValue, NotNull]
    static MethodCallExpression GetMethodCaller([NotNull] PropertyInfo info, [NotNull] Expression param)
    {
        var exConstant = Expression.Constant($"{info.Name}{KeyValueSeparator}");
        var method = s_stringify.MakeGenericMethod(info.PropertyType);

        Expression
            exMember = Expression.MakeMemberAccess(param, info),
            exCall = Expression.Call(method, exMember, s_exTrue, s_exFalse);

        return Expression.Call(s_combine, exConstant, exCall);
    }
}
