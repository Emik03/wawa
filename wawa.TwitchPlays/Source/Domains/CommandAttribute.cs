// <copyright file="CommandAttribute.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Wawa.TwitchPlays.Domains;

/// <summary>
/// An <see cref="Attribute"/> to attach to methods to signify that
/// the command should be processed by <see cref="Twitch{T}"/>.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true), CLSCompliant(false), PublicAPI]
public sealed class CommandAttribute : Attribute,
    ICloneable,
    IEquatable<CommandAttribute>,
    IEqualityComparer<CommandAttribute>
{
    const string Null = "<inferred>";

    /// <summary>Initializes a new instance of the <see cref="CommandAttribute"/> class.</summary>
    /// <param name="prefix">The prefix of this command.</param>
    /// <param name="priority">The priority of the command. A higher value means it will be evaluated sooner.</param>
    public CommandAttribute([CanBeNull] string prefix = null, int priority = 0)
    {
        Prefix = prefix;
        Priority = priority;
    }

    /// <summary>Gets the priority. Higher means evaluated sooner.</summary>
    public int Priority { get; }

    /// <summary>Gets the prefix of this command. If <see cref="Maybe.None{T}"/>, the prefix is inferred.</summary>
    public Maybe<string> Prefix { [Pure] get; }

    /// <summary>Determines whether both have the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if both of them contain the same values,
    /// otherwise <see langword="false"/>.</returns>
    [Pure]
    public static bool operator ==([CanBeNull] CommandAttribute left, [CanBeNull] CommandAttribute right) =>
        left?.Prefix == right?.Prefix && left?.Priority == right?.Priority;

    /// <summary>Determines whether both do not have the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if both of them do not contain the same values,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool operator !=([CanBeNull] CommandAttribute left, [CanBeNull] CommandAttribute right) =>
        !(left == right);

    /// <inheritdoc/>
    [Pure]
    public bool Equals(CommandAttribute other) => this == other;

    /// <inheritdoc/>
    [Pure]
    public bool Equals(CommandAttribute x, CommandAttribute y) => x == y;

    /// <inheritdoc/>
    [Pure]
    public int GetHashCode([CanBeNull] CommandAttribute obj) => obj?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    [Pure]
    public object Clone() => new CommandAttribute(Prefix.Value, Priority);

    /// <inheritdoc/>
    [Pure]
    public override bool Equals(object obj) => Equals(obj as CommandAttribute);

    /// <inheritdoc/>
    [Pure]
    public override int GetHashCode() => Prefix.GetHashCode() + Priority;

    /// <inheritdoc/>
    [Pure]
    public override string ToString() => Prefix.UnwrapOr(Null);
}
