#region Emik.MPL

// <copyright file="CommandInfo.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

namespace Wawa.TwitchPlays.Domains;

/// <summary>Combines <see cref="CommandAttribute"/> and <see cref="MethodInfo"/> into one data type.</summary>
sealed class CommandInfo : ICloneable, IEquatable<CommandInfo>, IEqualityComparer<CommandInfo>
{
    CommandInfo([NotNull] MethodInfo method, [NotNull] CommandAttribute command)
    {
        Command = command;
        Method = method;
    }

    /// <summary>
    /// Gets the prefix for the command, inferring from <see cref="Method"/> if <see cref="Command"/> doesn't have one.
    /// </summary>
    internal string Prefix
    {
        [Pure] get => Command.Prefix.UnwrapOr(Method.Name);
    }

    /// <summary>Gets the <see cref="CommandAttribute"/>.</summary>
    [NotNull]
    internal CommandAttribute Command { [Pure] get; }

    /// <summary>Gets the <see cref="MethodInfo"/> to allow for invoking.</summary>
    [NotNull]
    internal MethodInfo Method { [Pure] get; }

    /// <inheritdoc/>
    public object Clone() => new CommandInfo(Method, Command);

    /// <inheritdoc />
    [Pure]
    public bool Equals(CommandInfo x, CommandInfo y) => x == y;

    /// <inheritdoc />
    [Pure]
    public int GetHashCode(CommandInfo obj) => obj.GetHashCode();

    /// <inheritdoc />
    [Pure]
    public bool Equals(CommandInfo other) => this == other;

    /// <summary>Determines whether both have the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if both of them contain the same values,
    /// otherwise <see langword="false"/>.</returns>
    public static bool operator ==([AllowNull, CanBeNull] CommandInfo left, [AllowNull, CanBeNull] CommandInfo right) =>
        left is null ? right is null : right is not null && left.Method == right.Method;

    /// <summary>Determines whether both do not have the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if both of them do not contain the same values,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool operator !=([AllowNull, CanBeNull] CommandInfo left, [AllowNull, CanBeNull] CommandInfo right) =>
        !(left == right);

    /// <inheritdoc />
    [Pure]
    public override bool Equals([AllowNull] object obj) => Equals(obj as CommandInfo);

    /// <inheritdoc />
    [Pure]
    public override int GetHashCode() => Method.GetHashCode();

    /// <inheritdoc />
    [Pure]
    public override string ToString() => Method.ToString();

    /// <summary>Attempts to create an instance of <see cref="CommandInfo"/>.</summary>
    /// <param name="method">The method to use to attempt to create an instance.</param>
    /// <returns>
    /// A <see cref="CommandInfo"/> if a <see cref="CommandAttribute"/> can be obtained
    /// from the parameter <paramref name="method"/> and <paramref name="method"/> has an
    /// appropriate return type, otherwise <see langword="null"/>.
    /// </returns>
    [CanBeNull]
    [return: AllowNull]
    internal static CommandInfo TryFrom(MethodInfo method) =>
        method.ReturnType == typeof(IEnumerable<Instruction>) &&
        Attribute.GetCustomAttribute(method, typeof(CommandAttribute)) is CommandAttribute command
            ? new(method, command)
            : null;
}
