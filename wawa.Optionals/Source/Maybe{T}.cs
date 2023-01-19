// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Optionals;

using static CollectionAccessType;

/// <summary>A type representing an optional value; Either Some and contains a value, or None, and does not.</summary>
/// <typeparam name="T">The type to encapsulate and project as an optional value.</typeparam>
[StructLayout(LayoutKind.Auto), PublicAPI]
#pragma warning disable CA1710
public readonly struct Maybe<T> : ICollection,
#pragma warning restore CA1710
    ICloneable,
    IEquatable<Maybe<T>>,
    IEqualityComparer<Maybe<T>>,
    IFormattable,
    IList<T>
{
    [NotNull, PublicAPI]
    const string NoneMessage = "None";

    /// <summary>Initializes a new instance of the <see cref="Maybe{T}" /> struct.</summary>
    /// <param name="value">The value to encapsulate.</param>
    [PublicAPI]
    public Maybe([AllowNull, CanBeNull] T value)
    {
        Value = value;
        IsSome = value is not null;
    }

    /// <summary>Gets a value indicating whether the value encapsulated is <see langword="null" />.</summary>
    [CollectionAccess(None), MemberNotNullWhen(false, nameof(Value)), PublicAPI]
    public bool IsNone
    {
        [Pure] get => !IsSome;
    }

    /// <summary>Gets a value indicating whether the value encapsulated is not <see langword="null" />.</summary>
    [CollectionAccess(None), MemberNotNullWhen(true, nameof(Value)), PublicAPI]
    public bool IsSome { [Pure] get; }

    /// <summary>Gets the value that is encapsulated. This value returned may be <see langword="null" />.</summary>
    [AllowNull, CanBeNull, CollectionAccess(Read), ProvidesContext, PublicAPI]
    public T Value { [Pure] get; }

    /// <inheritdoc />
    [CollectionAccess(None), PublicAPI]
    bool ICollection<T>.IsReadOnly
    {
        [Pure] get => true;
    }

    /// <inheritdoc />
    [CollectionAccess(None), PublicAPI]
    bool ICollection.IsSynchronized
    {
        [Pure] get => false;
    }

    /// <inheritdoc />
    [CollectionAccess(None), PublicAPI]
    int ICollection.Count
    {
        [Pure, ValueRange(0, 1)] get => IsSome ? 1 : 0;
    }

    /// <inheritdoc />
    [CollectionAccess(None), PublicAPI]
    int ICollection<T>.Count
    {
        [Pure, ValueRange(0, 1)] get => IsSome ? 1 : 0;
    }

    /// <inheritdoc />
    [CollectionAccess(None), PublicAPI]
    object ICollection.SyncRoot
    {
        [Pure] get => this;
    }

    /// <inheritdoc />
    [AllowNull, CanBeNull, PublicAPI]
    T IList<T>.this[int index]
    {
        [CollectionAccess(Read), Pure] get => Value;
        [CollectionAccess(None)] set { }
    }

    /// <summary>Converts the <typeparamref name="T" /> to a <see langword="new" /> <see cref="Maybe{T}" />.</summary>
    /// <param name="value">The <typeparamref name="T" /> instance to convert.</param>
    /// <returns>
    /// A <see cref="Maybe{T}" /> that is Some or None depending on
    /// whether <paramref name="value" /> is <see langword="null" />.
    /// </returns>
    [CollectionAccess(None), PublicAPI, Pure]
    public static implicit operator Maybe<T>([AllowNull, CanBeNull] T value) => new(value);

    /// <summary>Converts the <see cref="Maybe{T}" /> to <typeparamref name="T" />.</summary>
    /// <param name="value">The <typeparamref name="T" /> instance to convert.</param>
    /// <returns>The inner value.</returns>
    /// <exception cref="InvalidOperationException">The parameter <paramref name="value" /> is a None value.</exception>
    [CollectionAccess(Read), PublicAPI, Pure]
    public static explicit operator T(Maybe<T> value) => value.Unwrap();

    /// <summary>Determines whether both instances contain the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true" /> if both instances contain the same values,
    /// otherwise <see langword="false" />.
    /// </returns>
    [CollectionAccess(Read), PublicAPI, Pure]
    public static bool operator ==(Maybe<T> left, Maybe<T> right) =>
        left.IsNone ? right.IsNone : EqualityComparer<T>.Default.Equals(left.Value, right.Value);

    /// <summary>Determines whether both instances do not contain the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true" /> if both instances do not contain the same values,
    /// otherwise <see langword="false" />.</returns>
    [CollectionAccess(Read), PublicAPI, Pure]
    public static bool operator !=(Maybe<T> left, Maybe<T> right) => !(left == right);

    /// <inheritdoc />
    [CollectionAccess(Read), PublicAPI, Pure]
    public override bool Equals([AllowNull] object obj) => obj is Maybe<T> may && Equals(may);

    /// <inheritdoc />
    [CollectionAccess(Read), PublicAPI, Pure]
    public override int GetHashCode() => -1598703110 + EqualityComparer<T>.Default.GetHashCode(Value);

    /// <inheritdoc />
    [CollectionAccess(Read), PublicAPI, Pure]
    public override string ToString() => IsSome ? $"Some({Value})" : NoneMessage;

    /// <inheritdoc />
    [CollectionAccess(Read), PublicAPI]
    public void CopyTo(Array array, int index) => array.SetValue(Value, index);

    /// <inheritdoc />
    [CollectionAccess(Read), PublicAPI]
    public void CopyTo(T[] array, [NonNegativeValue] int arrayIndex) => array[arrayIndex] = Value;

    /// <inheritdoc />
    [CollectionAccess(Read), MemberNotNullWhen(true, nameof(Value)), PublicAPI, Pure]
    public bool Contains(T item) => IsSome && EqualityComparer<T>.Default.Equals(Value, item);

    /// <inheritdoc />
    [CollectionAccess(Read), PublicAPI, Pure]
    public bool Equals(Maybe<T> other) => this == other;

    /// <inheritdoc />
    [CollectionAccess(Read), PublicAPI, Pure]
    public bool Equals(Maybe<T> x, Maybe<T> y) => x == y;

    /// <inheritdoc />
    [CollectionAccess(Read), PublicAPI, Pure]
    public int GetHashCode(Maybe<T> obj) => obj.GetHashCode();

    /// <inheritdoc />
    [CollectionAccess(Read), PublicAPI, Pure]
    public string ToString(
        [AllowNull, CanBeNull] string format,
        [AllowNull, CanBeNull] IFormatProvider formatProvider
    ) =>
        ToString();

    /// <inheritdoc />
    [CollectionAccess(None), PublicAPI, Pure]
    public object Clone() => this;

    /// <inheritdoc />
    [CollectionAccess(Read), PublicAPI, Pure]
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <inheritdoc />
    [CollectionAccess(Read), PublicAPI, Pure]
    public IEnumerator<T> GetEnumerator() =>
        IsSome ? Enumerable.Repeat(Value, 1).GetEnumerator() : Enumerable.Empty<T>().GetEnumerator();

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ICollection<T>.Add([AllowNull] T item) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ICollection<T>.Clear() { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void IList<T>.Insert(int index, [AllowNull] T item) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void IList<T>.RemoveAt(int index) { }

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ICollection<T>.Remove(T item) => false;

    /// <inheritdoc />
    [CollectionAccess(Read), Pure, ValueRange(-1, 0)]
    int IList<T>.IndexOf(T item) => Contains(item) ? 0 : -1;
}
