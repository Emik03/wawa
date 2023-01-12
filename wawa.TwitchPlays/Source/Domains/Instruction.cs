#region Emik.MPL

// <copyright file="Instruction.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

namespace Wawa.TwitchPlays.Domains;

/// <summary>Defines an instruction for Twitch Plays to process.</summary>
/// <remarks><para>
/// Based on the advanced implementation documentation:
/// https://github.com/samfundev/KtaneTwitchPlays/wiki/External-Mod-Module-Support#advanced-implementation.
/// </para></remarks>
[PublicAPI]
public sealed class Instruction : ICloneable, IEquatable<Instruction>, IEqualityComparer<Instruction>
{
    [NotNull]
    const string Detonate = "detonate";

    /// <summary>Initializes a new instance of the <see cref="Instruction"/> class.</summary>
    /// <remarks><para>Detonates the bomb when yielded.</para></remarks>
    /// <param name="reason">The optional reason for the explosion.</param>
    /// <param name="moduleName">The override of the module name that caused the explosion.</param>
    public Instruction([AllowNull, CanBeNull] string reason = null, [AllowNull, CanBeNull] string moduleName = null) =>
        Value = reason is null ? new[] { Detonate } :
            moduleName is null ? new[] { Detonate, reason } : new[] { Detonate, reason, moduleName };

    /// <summary>Initializes a new instance of the <see cref="Instruction"/> class.</summary>
    /// <remarks><para>Provides a nested enumeration.</para></remarks>
    /// <param name="enumerator">The value to pass in.</param>
    public Instruction([NotNull] IEnumerable<Instruction> enumerator) => Value = enumerator.GetEnumerator();

    /// <summary>Initializes a new instance of the <see cref="Instruction"/> class.</summary>
    /// <remarks><para>Provides a nested enumeration.</para></remarks>
    /// <param name="enumerator">The value to pass in.</param>
    public Instruction([NotNull] IEnumerator<Instruction> enumerator) => Value = enumerator;

    /// <summary>Initializes a new instance of the <see cref="Instruction"/> class.</summary>
    /// <remarks><para>Changes the orientation of the bomb when yielded.</para></remarks>
    /// <param name="first">
    /// For the Bomb. The form of <c>(Quaternion.Euler(x, 0, 0) * Quaternion.Euler(0, y, 0) * (Quaternion.Euler(0, 0, z))</c>.
    /// </param>
    /// <param name="second">For the camera side view. The second one in the form of <c>Quaternion.Euler(x, y, z)</c>.</param>
    [CLSCompliant(false)]
    public Instruction(Quaternion first, Quaternion second) => Value = new[] { first, second };

    /// <summary>Initializes a new instance of the <see cref="Instruction"/> class.</summary>
    /// <param name="value">The value to pass in.</param>
    public Instruction(TwitchString value) => Value = value.Message;

    /// <summary>Initializes a new instance of the <see cref="Instruction"/> class.</summary>
    /// <param name="value">The value to pass in.</param>
    internal Instruction([NotNull] object value) => Value = value;

    /// <summary>Gets the value that can be yielded to wait for the next frame.</summary>
    /// <remarks><para>This value is always null. Do not dereference.</para></remarks>
    [AllowNull, CanBeNull]
    public static Instruction FrameAdvance
    {
        [Pure] get => null;
    }

    /// <summary>Gets the value that can be yielded to allow other modules to be processed in Twitch Plays.</summary>
    [NotNull]
    public static Instruction Pause { [Pure] get; } = new(true);

    /// <summary>
    /// Gets a value indicating whether Twitch Plays should allow
    /// other modules to be interacted with for the current frame.
    /// </summary>
    [NotNull]
    internal object Value { [Pure] get; }

    /// <inheritdoc/>
    [Pure]
    public object Clone() => this;

    /// <inheritdoc/>
    [Pure]
    public bool Equals(Instruction x, Instruction y) => x == y;

    /// <inheritdoc/>
    [Pure]
    public int GetHashCode([AllowNull, CanBeNull] Instruction obj) => obj?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    [Pure]
    public bool Equals(Instruction other) => this == other;

    /// <summary>Implicitly calls the constructor.</summary>
    /// <param name="customYield">The <see cref="CustomYieldInstruction"/> to pass in to the constructor.</param>
    [CLSCompliant(false), NotNull, Pure]
    public static implicit operator Instruction([NotNull] CustomYieldInstruction customYield) => new(customYield);

    /// <summary>Implicitly calls the constructor.</summary>
    /// <param name="selectable">The <see cref="KMSelectable"/> to pass in to the constructor.</param>
    [CLSCompliant(false), NotNull, Pure]
    public static implicit operator Instruction([NotNull] KMSelectable selectable) => new(selectable);

    /// <summary>Implicitly calls the constructor.</summary>
    /// <param name="selectables">
    /// The <see cref="KMSelectable"/> <see cref="Array"/> to pass in to the constructor.
    /// </param>
    [CLSCompliant(false), NotNull, Pure]
    public static implicit operator Instruction([NotNull] KMSelectable[] selectables) => new(selectables);

    /// <summary>Implicitly calls the constructor.</summary>
    /// <param name="orientation">The <see cref="Quaternion"/> to pass in to the constructor.</param>
    [CLSCompliant(false), NotNull, Pure]
    public static implicit operator Instruction(Quaternion orientation) => new(orientation);

    /// <summary>Implicitly calls the constructor.</summary>
    /// <param name="query">The <see cref="TwitchString"/> to pass in to the constructor.</param>
    [CLSCompliant(false), NotNull, Pure]
    public static implicit operator Instruction(TwitchString query) => new(query);

    /// <summary>Implicitly calls the constructor.</summary>
    /// <param name="yield">The <see cref="YieldInstruction"/> to pass in to the constructor.</param>
    [CLSCompliant(false), NotNull, Pure]
    public static implicit operator Instruction([NotNull] YieldInstruction yield) => new(yield);

    /// <summary>Determines whether both instances contain the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>The value <see langword="true"/> if both instances contain the same values.</returns>
    [Pure]
    public static bool operator ==([AllowNull, CanBeNull] Instruction left, [AllowNull, CanBeNull] Instruction right) =>
        left is null ? right is null : right is not null && left.Value == right.Value;

    /// <summary>Determines whether both instances do not contain the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>The value <see langword="true"/> if both instances do not contain the same values.</returns>
    [Pure]
    public static bool operator !=([AllowNull, CanBeNull] Instruction left, [AllowNull, CanBeNull] Instruction right) =>
        !(left == right);

    /// <summary>
    /// Converts the <see cref="CustomYieldInstruction"/> to a <see langword="new"/> <see cref="Instruction"/>.
    /// </summary>
    /// <param name="customYield">The <see cref="CustomYieldInstruction"/> instance to convert.</param>
    /// <returns>
    /// A <see langword="new"/> <see cref="Instruction"/> instance encapsulating <paramref name="customYield"/>.
    /// </returns>
    [CLSCompliant(false), NotNull, Pure]
    public static Instruction FromCustomYieldInstruction([NotNull] CustomYieldInstruction customYield) => customYield;

    /// <summary>
    /// Converts the <see cref="IEnumerable{T}"/> to a <see langword="new"/> <see cref="Instruction"/>.
    /// </summary>
    /// <param name="enumerable">The <see cref="IEnumerable{T}"/> instance to convert.</param>
    /// <returns>
    /// A <see langword="new"/> <see cref="Instruction"/> instance encapsulating <paramref name="enumerable"/>.
    /// </returns>
    [NotNull, Pure]
    public static Instruction FromInstructions([NotNull] IEnumerable<Instruction> enumerable) => new(enumerable);

    /// <summary>
    /// Converts the <see cref="IEnumerator{T}"/> to a <see langword="new"/> <see cref="Instruction"/>.
    /// </summary>
    /// <param name="enumerator">The <see cref="IEnumerator{T}"/> instance to convert.</param>
    /// <returns>
    /// A <see langword="new"/> <see cref="Instruction"/> instance encapsulating <paramref name="enumerator"/>.
    /// </returns>
    [NotNull, Pure]
    public static Instruction FromInstructions([NotNull] IEnumerator<Instruction> enumerator) => new(enumerator);

    /// <summary>
    /// Converts the <see cref="Array"/> to a <see langword="new"/> <see cref="Instruction"/>.
    /// </summary>
    /// <param name="array">The <see cref="IEnumerable{T}"/> instance to convert.</param>
    /// <returns>
    /// A <see langword="new"/> <see cref="Instruction"/> instance encapsulating <paramref name="array"/>.
    /// </returns>
    [NotNull, Pure]
    public static Instruction FromInstructions([NotNull] params Instruction[] array) => new(array);

    /// <summary>Converts the <see cref="KMSelectable"/> to a <see langword="new"/> <see cref="Instruction"/>.</summary>
    /// <param name="selectable">The <see cref="KMSelectable"/> instance to convert.</param>
    /// <returns>
    /// A <see langword="new"/> <see cref="Instruction"/> instance encapsulating <paramref name="selectable"/>.
    /// </returns>
    [CLSCompliant(false), NotNull, Pure]

    // ReSharper disable once InconsistentNaming
    public static Instruction FromKMSelectable([NotNull] KMSelectable selectable) => selectable;

    /// <summary>
    /// Converts the <see cref="KMSelectable"/> <see cref="Array"/>
    /// to a <see langword="new"/> <see cref="Instruction"/>.
    /// </summary>
    /// <param name="selectable">The <see cref="KMSelectable"/> <see cref="Array"/> instance to convert.</param>
    /// <returns>
    /// A <see langword="new"/> <see cref="Instruction"/> instance encapsulating <paramref name="selectable"/>.
    /// </returns>
    [CLSCompliant(false), NotNull, Pure]

    // ReSharper disable once InconsistentNaming
    public static Instruction FromKMSelectableArray([NotNull] KMSelectable[] selectable) => selectable;

    /// <summary>Converts the <see cref="Quaternion"/> to a <see langword="new"/> <see cref="Instruction"/>.</summary>
    /// <param name="orientation">The <see cref="Quaternion"/> instance to convert.</param>
    /// <returns>
    /// A <see langword="new"/> <see cref="Instruction"/> instance encapsulating <paramref name="orientation"/>.
    /// </returns>
    [CLSCompliant(false), NotNull, Pure]
    public static Instruction FromQuaternion(Quaternion orientation) => orientation;

    /// <summary>
    /// Converts the <see cref="TwitchString"/> to a <see langword="new"/> <see cref="Instruction"/>.
    /// </summary>
    /// <param name="query">The <see cref="TwitchString"/> instance to convert.</param>
    /// <returns>
    /// A <see langword="new"/> <see cref="Instruction"/> instance encapsulating <paramref name="query"/>.
    /// </returns>
    [CLSCompliant(false), NotNull, Pure]
    public static Instruction FromTwitchString(TwitchString query) => query;

    /// <summary>
    /// Converts the <see cref="YieldInstruction"/> to a <see langword="new"/> <see cref="Instruction"/>.
    /// </summary>
    /// <param name="yield">The <see cref="YieldInstruction"/> instance to convert.</param>
    /// <returns>
    /// A <see langword="new"/> <see cref="Instruction"/> instance encapsulating <paramref name="yield"/>.
    /// </returns>
    [CLSCompliant(false), NotNull, Pure]
    public static Instruction FromYieldInstruction([NotNull] YieldInstruction yield) => yield;

    /// <inheritdoc/>
    [Pure]
    public override bool Equals([AllowNull] object obj) => Equals(obj as Instruction);

    /// <inheritdoc/>
    [Pure]
    public override int GetHashCode() => Value.GetHashCode();

    /// <inheritdoc/>
    [Pure]
    public override string ToString() => Stringifier.Stringify(Value);
}
