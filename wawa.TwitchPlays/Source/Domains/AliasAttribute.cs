#region Emik.MPL

// <copyright file="AliasAttribute.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

namespace Wawa.TwitchPlays.Domains;

/// <summary>An <see cref="Attribute"/> to attach to a field to signify alternative ways to spell it.</summary>
[AttributeUsage(AttributeTargets.Field), CLSCompliant(false), PublicAPI]
public sealed class AliasAttribute : Attribute,
    ICloneable,
    IEquatable<AliasAttribute>,
    IEqualityComparer<AliasAttribute>,
    IFormattable
{
    const string Whitespace =
        "One or more aliases contain whitespace. " +
        "Since commands are split by whitespace, this makes those aliases unreachable.";

    /// <summary>Initializes a new instance of the <see cref="AliasAttribute"/> class.</summary>
    /// <exception cref="InvalidOperationException">
    /// A <see cref="string"/> in <paramref name="aliases"/> contain at least one <see cref="char"/> that is whitespace,
    /// according to <see cref="char.IsWhiteSpace(char)"/>.
    /// </exception>
    /// <param name="aliases">The prefix of this command.</param>
    public AliasAttribute([NotNull] params string[] aliases)
        : this((IList<string>)aliases) { }

    /// <summary>Initializes a new instance of the <see cref="AliasAttribute"/> class.</summary>
    /// <exception cref="InvalidOperationException">
    /// A <see cref="string"/> in <paramref name="aliases"/> contain at least one <see cref="char"/> that is whitespace,
    /// according to <see cref="char.IsWhiteSpace(char)"/>.
    /// </exception>
    /// <param name="aliases">The prefix of this command.</param>
    public AliasAttribute([NotNull] IList<string> aliases) =>
        Aliases = aliases.Any(static x => x.Any(char.IsWhiteSpace))
            ? throw new InvalidOperationException(Whitespace)
            : aliases;

    /// <summary>Gets the alternative representations.</summary>
    [NotNull]
    public IList<string> Aliases { [Pure] get; }

    /// <inheritdoc/>
    [Pure]
    public object Clone() => new AliasAttribute(Aliases);

    /// <inheritdoc/>
    [Pure]
    public bool Equals(AliasAttribute x, AliasAttribute y) => x == y;

    /// <inheritdoc/>
    [Pure]
    public int GetHashCode([AllowNull, CanBeNull] AliasAttribute obj) => obj?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    [Pure]
    public bool Equals(AliasAttribute other) => this == other;

    /// <inheritdoc />
    public string ToString([NotNull] string format, [AllowNull, CanBeNull] IFormatProvider formatProvider) =>
        ToString(format);

    /// <summary>Determines whether both have the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if both of them contain the same values,
    /// otherwise <see langword="false"/>.</returns>
    [Pure]
    public static bool operator ==(
        [AllowNull, CanBeNull] AliasAttribute left,
        [AllowNull, CanBeNull] AliasAttribute right
    ) =>
        left is null
            ? right is null
            : right is not null && left.Aliases.SequenceEqual(right.Aliases, StringComparer.OrdinalIgnoreCase);

    /// <summary>Determines whether both do not have the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if both of them do not contain the same values,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool operator !=(
        [AllowNull, CanBeNull] AliasAttribute left,
        [AllowNull, CanBeNull] AliasAttribute right
    ) =>
        !(left == right);

    /// <summary>Gets a <see langword="string"/> representation showing every alias.</summary>
    /// <param name="x">The field.</param>
    /// <returns>A concatenation of the parameter <paramref name="x"/> with <see cref="Aliases"/>.</returns>
    [NotNull]
    public static string ToString([NotNull] FieldInfo x) =>
        x.GetCustomAttributes(true).OfType<AliasAttribute>().FirstOrDefault()?.ToString(x.Name) ?? x.Name;

    /// <inheritdoc/>
    [Pure]
    public override bool Equals(object obj) => Equals(obj as AliasAttribute);

    /// <inheritdoc/>
    [Pure]
    public override int GetHashCode() =>
        Aliases.Aggregate(0, static (x, y) => x ^ StringComparer.OrdinalIgnoreCase.GetHashCode(y));

    /// <inheritdoc/>
    [Pure]
    public override string ToString() => Stringifier.Stringify(Aliases);

    /// <summary>Gets a <see langword="string"/> representation showing every alias.</summary>
    /// <param name="x">The original name of the field.</param>
    /// <returns>A concatenation of the parameter <paramref name="x"/> with <see cref="Aliases"/>.</returns>
    [NotNull]
    public string ToString([NotNull] string x) => Stringifier.Conjoin(Enumerable.Repeat(x, 1).Concat(Aliases), '/');
}
