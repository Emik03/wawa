// SPDX-License-Identifier: MPL-2.0
namespace wawa.Optionals;

using static CollectionAccessType;

/// <summary>
/// A type that has exactly one value, and is used when there is no other meaningful value that could be returned.
/// </summary>
[PublicAPI]
public readonly struct Unit : IComparable<Unit>,
    IComparer<Unit>,
    ICloneable,
    IEnumerable<Unit>,
    IEquatable<Unit>,
    IEqualityComparer<Unit>,
    IFormattable
{
    /// <summary>Gets the string representation of <see cref="Unit"/>.</summary>
    [NotNull, PublicAPI]
    public const string AsString = "()";

    /// <summary>Gets the singular value.</summary>
    [CollectionAccess(None), PublicAPI]
    public static Unit Value
    {
        [Pure] get => default;
    }

    /// <summary>Returns <see langword="true" />.</summary>
    /// <remarks><para>Since this type has one value, any instance is the same as each other.</para></remarks>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>The value <see langword="true" />.</returns>
    [PublicAPI, Pure]
    public static bool operator ==([InstantHandle] Unit left, [InstantHandle] Unit right) => true;

    /// <summary>Returns <see langword="false" />.</summary>
    /// <remarks><para>Since this type has one value, any instance is the same as each other.</para></remarks>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>The value <see langword="false" />.</returns>
    [PublicAPI, Pure]
    public static bool operator !=([InstantHandle] Unit left, [InstantHandle] Unit right) => false;

    /// <summary>Returns <see langword="false" />.</summary>
    /// <remarks><para>Since this type has one value, any instance is the same as each other.</para></remarks>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>The value <see langword="false" />.</returns>
    [PublicAPI, Pure]
    public static bool operator <([InstantHandle] Unit left, [InstantHandle] Unit right) => false;

    /// <summary>Returns <see langword="true" />.</summary>
    /// <remarks><para>Since this type has one value, any instance is the same as each other.</para></remarks>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>The value <see langword="true" />.</returns>
    [PublicAPI, Pure]
    public static bool operator <=([InstantHandle] Unit left, [InstantHandle] Unit right) => true;

    /// <summary>Returns <see langword="false" />.</summary>
    /// <remarks><para>Since this type has one value, any instance is the same as each other.</para></remarks>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>The value <see langword="false" />.</returns>
    [PublicAPI, Pure]
    public static bool operator >([InstantHandle] Unit left, [InstantHandle] Unit right) => false;

    /// <summary>Returns <see langword="true" />.</summary>
    /// <remarks><para>Since this type has one value, any instance is the same as each other.</para></remarks>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>The value <see langword="true" />.</returns>
    [PublicAPI, Pure]
    public static bool operator >=([InstantHandle] Unit left, [InstantHandle] Unit right) => true;

    /// <inheritdoc />
    [CollectionAccess(None), PublicAPI, Pure, ValueRange(0)]
    public override int GetHashCode() => 0;

    /// <inheritdoc />
    [CollectionAccess(None), PublicAPI, Pure]
    public string ToString(string format, IFormatProvider formatProvider) => AsString;

    /// <inheritdoc />
    [CollectionAccess(None), PublicAPI, Pure]
    public override string ToString() => AsString;

    /// <inheritdoc />
    [CollectionAccess(None), PublicAPI, Pure]
    public override bool Equals([AllowNull] object obj) => obj is Unit;

    /// <inheritdoc />
    [CollectionAccess(None), PublicAPI, Pure]
    public IEnumerator<Unit> GetEnumerator() => Enumerable.Empty<Unit>().GetEnumerator();

    /// <inheritdoc />
    [CollectionAccess(None), PublicAPI, Pure]
    bool IEquatable<Unit>.Equals([InstantHandle] Unit other) => true;

    /// <inheritdoc />
    [CollectionAccess(None), PublicAPI, Pure]
    bool IEqualityComparer<Unit>.Equals([InstantHandle] Unit x, [InstantHandle] Unit y) => true;

    /// <inheritdoc />
    [CollectionAccess(None), PublicAPI, Pure, ValueRange(0)]
    int IEqualityComparer<Unit>.GetHashCode([InstantHandle] Unit obj) => 0;

    /// <inheritdoc />
    [CollectionAccess(None), PublicAPI, Pure]
    object ICloneable.Clone() => this;

    /// <inheritdoc />
    [CollectionAccess(None), Pure, ValueRange(0)]
    int IComparable<Unit>.CompareTo(Unit other) => 0;

    /// <inheritdoc />
    [CollectionAccess(None), Pure, ValueRange(0)]
    int IComparer<Unit>.Compare(Unit x, Unit y) => 0;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
