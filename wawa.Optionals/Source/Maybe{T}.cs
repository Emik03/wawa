﻿// SPDX-License-Identifier: MPL-2.0
namespace wawa.Optionals;

using static CollectionAccessType;

/// <summary>
/// A type representing an optional value; Either <c>Some</c> and contains a value, or <c>None</c>, and does not.
/// </summary>
/// <param name="value">The value to encapsulate.</param>
/// <typeparam name="T">The type to encapsulate and project as an optional value.</typeparam>
[StructLayout(LayoutKind.Auto), PublicAPI]
public readonly struct Maybe<T>([AllowNull, CanBeNull] T value) :
    ICollection,
    IComparable<Maybe<T>>,
    IComparer<Maybe<T>>,
    ICloneable,
    IEquatable<Maybe<T>>,
    IEqualityComparer<Maybe<T>>,
    IFormattable,
    IList<T>
{
    [NotNull, PublicAPI]
    const string NoneMessage = "None";

    /// <summary>Gets a value indicating whether the value encapsulated is <see langword="null" />.</summary>
    [CollectionAccess(None), MemberNotNullWhen(false, nameof(Value)), PublicAPI]
    public bool IsNone
    {
        [Pure] get => !IsSome;
    }

    /// <summary>Gets a value indicating whether the value encapsulated is not <see langword="null" />.</summary>
    [CollectionAccess(None), MemberNotNullWhen(true, nameof(Value)), PublicAPI]
    public bool IsSome { [Pure] get; } = value is not null;

    /// <summary>Gets the value that is encapsulated. This value returned may be <see langword="null" />.</summary>
    [AllowNull, CanBeNull, CollectionAccess(Read), ProvidesContext, PublicAPI]
    public T Value { [Pure] get; } = value;

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
        [Pure] get => new();
    }

    /// <inheritdoc />
    [AllowNull, CanBeNull, PublicAPI]
    T IList<T>.this[int index]
    {
        [CollectionAccess(Read), Pure] get => this.Unwrap();
        [CollectionAccess(None)] set { }
    }

    /// <summary>Converts the <typeparamref name="T" /> to a <see langword="new" /> <see cref="Maybe{T}" />.</summary>
    /// <param name="value">The <typeparamref name="T" /> instance to convert.</param>
    /// <returns>
    /// A <see cref="Maybe{T}" /> that is Some or None depending on
    /// whether <paramref name="value" /> is <see langword="null" />.
    /// </returns>
    [PublicAPI, Pure]
    public static implicit operator Maybe<T>([AllowNull, CanBeNull] T value) => new(value);

    /// <summary>Converts the <see cref="Maybe{T}" /> to <typeparamref name="T" />.</summary>
    /// <param name="value">The <typeparamref name="T" /> instance to convert.</param>
    /// <returns>The inner value.</returns>
    /// <exception cref="InvalidOperationException">The parameter <paramref name="value" /> is a None value.</exception>
    [PublicAPI, Pure]
    public static explicit operator T(Maybe<T> value) => value.Unwrap();

    /// <inheritdoc cref="IsSome"/>
    [PublicAPI, Pure]
    public static bool operator true(Maybe<T> value) => value.IsSome;

    /// <inheritdoc cref="IsNone"/>
    [PublicAPI, Pure]
    public static bool operator false(Maybe<T> value) => value.IsNone;

    /// <summary>Determines whether both instances contain the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true" /> if both instances contain the same values,
    /// otherwise <see langword="false" />.
    /// </returns>
    [PublicAPI, Pure]
    public static bool operator ==(Maybe<T> left, Maybe<T> right) =>
        left.IsNone ? right.IsNone : EqualityComparer<T>.Default.Equals(left.Value, right.Value);

    /// <summary>Determines whether both instances do not contain the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true" /> if both instances do not contain the same values,
    /// otherwise <see langword="false" />.</returns>
    [PublicAPI, Pure]
    public static bool operator !=(Maybe<T> left, Maybe<T> right) => !(left == right);

    /// <summary>Determines whether the left-hand side is less than the right.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if the parameter <paramref name="left"/> is less
    /// than the parameter <paramref name="right"/>; otherwise, <see langword="false"/>.
    /// </returns>
    [PublicAPI, Pure]
    public static bool operator <(Maybe<T> left, Maybe<T> right) => left.CompareTo(right) < 0;

    /// <summary>Determines whether the left-hand side is equal to or less than the right.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if the parameter <paramref name="left"/> is equal to or less
    /// than the parameter <paramref name="right"/>; otherwise, <see langword="false"/>.
    /// </returns>
    [PublicAPI, Pure]
    public static bool operator <=(Maybe<T> left, Maybe<T> right) => left.CompareTo(right) <= 0;

    /// <summary>Determines whether the left-hand side is more than the right.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if the parameter <paramref name="left"/> is more
    /// than the parameter <paramref name="right"/>; otherwise, <see langword="false"/>.
    /// </returns>
    [PublicAPI, Pure]
    public static bool operator >(Maybe<T> left, Maybe<T> right) => left.CompareTo(right) > 0;

    /// <summary>Determines whether the left-hand side is equal to or more than the right.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if the parameter <paramref name="left"/> is equal to or more
    /// than the parameter <paramref name="right"/>; otherwise, <see langword="false"/>.
    /// </returns>
    [PublicAPI, Pure]
    public static bool operator >=(Maybe<T> left, Maybe<T> right) => left.CompareTo(right) >= 0;

    /// <inheritdoc cref="Maybe.UnwrapOr{T}(Maybe{T}, T)"/>
    [PublicAPI, Pure]
    public static T operator |(Maybe<T> value, T def) => value.UnwrapOr(def);

    /// <inheritdoc cref="Maybe.Or{T}(Maybe{T}, Maybe{T})"/>
    [PublicAPI, Pure]
    public static Maybe<T> operator |(Maybe<T> left, Maybe<T> right) => left.Or(right);

    /// <inheritdoc cref="Maybe.And{T}(Maybe{T}, Maybe{T})"/>
    [PublicAPI, Pure]
    public static Maybe<T> operator &(Maybe<T> left, Maybe<T> right) => left.And(right);

    /// <inheritdoc cref="Maybe.Xor{T}(Maybe{T}, Maybe{T})"/>
    [PublicAPI, Pure]
    public static Maybe<T> operator ^(Maybe<T> left, Maybe<T> right) => left.Xor(right);

    /// <inheritdoc />
    [CollectionAccess(Read), PublicAPI, Pure]
    public override bool Equals([AllowNull] object? obj) => obj is Maybe<T> may && Equals(may);

    /// <inheritdoc />
    [CollectionAccess(Read), PublicAPI, Pure]
    public override int GetHashCode() => -1598703110 + EqualityComparer<T>.Default.GetHashCode(Value);

    /// <inheritdoc />
    [CollectionAccess(Read), PublicAPI, Pure]
    public int CompareTo(Maybe<T> other) =>
        IsNone ? other.IsNone ? 0 : -1 :
        other.IsNone ? 1 : Comparer<T>.Default.Compare(Value, other.Value);

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
    [CollectionAccess(None), PublicAPI, Pure]
    public bool Equals(Maybe<T> x, Maybe<T> y) => x == y;

    /// <inheritdoc />
    [CollectionAccess(None), PublicAPI, Pure]
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

    /// <summary>Downcasts this instance to <typeparamref name="TResult"/>.</summary>
    /// <typeparam name="TResult">The type to value to downcast and return.</typeparam>
    /// <returns>Itself, downcast to <typeparamref name="TResult"/>.</returns>
    [CollectionAccess(Read), PublicAPI, Pure]
    public static Maybe<TResult> As<TResult>(Maybe<T> that)
        where TResult : class, T =>
        that.Value as TResult;

    /// <inheritdoc />
    [CollectionAccess(Read), PublicAPI, Pure]
    public IEnumerator<T> GetEnumerator() =>
        IsSome ? Enumerable.Repeat(Value, 1).GetEnumerator() : Enumerable.Empty<T>().GetEnumerator();

    /// <inheritdoc />
    [CollectionAccess(Read), PublicAPI, Pure]
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

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
    [CollectionAccess(None), Pure]
    int IComparer<Maybe<T>>.Compare(Maybe<T> x, Maybe<T> y) => x.CompareTo(y);

    /// <inheritdoc />
    [CollectionAccess(Read), Pure, ValueRange(-1, 0)]
    int IList<T>.IndexOf(T item) => Contains(item) ? 0 : -1;
}
