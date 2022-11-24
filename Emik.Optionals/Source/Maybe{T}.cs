// <copyright file="Maybe{T}.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Emik.Optionals;

/// <summary>A type representing an optional value; Either Some and contains a value, or None, and does not.</summary>
/// <typeparam name="T">The type to encapsulate and project as an optional value.</typeparam>
[StructLayout(LayoutKind.Auto), PublicAPI]
public readonly struct Maybe<T> : ICloneable, IEquatable<Maybe<T>>, IEqualityComparer<Maybe<T>>
{
    [NotNull]
    const string NoneMessage = "None";

    /// <summary>Initializes a new instance of the <see cref="Maybe{T}" /> struct.</summary>
    /// <param name="value">The value to encapsulate.</param>
    public Maybe([AllowNull, CanBeNull] T value)
    {
        Value = value;
        IsSome = value is not null;
    }

    /// <summary>Gets a value indicating whether the value encapsulated is <see langword="null" />.</summary>
    [MemberNotNullWhen(false, nameof(Value))]
    public bool IsNone
    {
        [Pure] get => !IsSome;
    }

    /// <summary>Gets a value indicating whether the value encapsulated is not <see langword="null" />.</summary>
    [MemberNotNullWhen(true, nameof(Value))]
    public bool IsSome { [Pure] get; }

    /// <summary>Gets the value that is encapsulated. This value returned may be <see langword="null" />.</summary>
    [AllowNull, CanBeNull]
    public T Value { [Pure] get; }

    /// <summary>Converts the <typeparamref name="T" /> to a <see langword="new" /> <see cref="Maybe{T}" />.</summary>
    /// <param name="value">The <typeparamref name="T" /> instance to convert.</param>
    /// <returns>
    /// A <see cref="Maybe{T}" /> that is Some or None depending on
    /// whether <paramref name="value" /> is <see langword="null" />.
    /// </returns>
    [Pure]
    public static implicit operator Maybe<T>([AllowNull, CanBeNull] T value) => new(value);

    /// <summary>Converts the <see cref="Maybe{T}" /> to <typeparamref name="T" />.</summary>
    /// <param name="value">The <typeparamref name="T" /> instance to convert.</param>
    /// <returns>The inner value.</returns>
    /// <exception cref="InvalidOperationException">The parameter <paramref name="value" /> is a None value.</exception>
    [Pure]
    public static explicit operator T(Maybe<T> value) => value.Unwrap();

    /// <summary>Determines whether both instances contain the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true" /> if both instances contain the same values,
    /// otherwise <see langword="false" />.
    /// </returns>
    [Pure]
    public static bool operator ==(Maybe<T> left, Maybe<T> right) =>
        left.IsNone ? right.IsNone : EqualityComparer<T>.Default.Equals(left.Value, right.Value);

    /// <summary>Determines whether both instances do not contain the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true" /> if both instances do not contain the same values,
    /// otherwise <see langword="false" />.</returns>
    [Pure]
    public static bool operator !=(Maybe<T> left, Maybe<T> right) => !(left == right);

    /// <inheritdoc />
    [Pure]
    public object Clone() => this;

    /// <inheritdoc />
    [Pure]
    public bool Equals(Maybe<T> other) => this == other;

    /// <inheritdoc />
    [Pure]
    public bool Equals(Maybe<T> x, Maybe<T> y) => x == y;

    /// <inheritdoc />
    [Pure]
    public int GetHashCode(Maybe<T> obj) => obj.GetHashCode();

    /// <inheritdoc />
    [Pure]
    public override bool Equals(object obj) => obj is Maybe<T> may && Equals(may);

    /// <inheritdoc />
    [Pure]
    public override int GetHashCode() => -1598703110 + EqualityComparer<T>.Default.GetHashCode(Value);

    /// <inheritdoc />
    [Pure]
    public override string ToString() => IsSome ? $@"Some({Value})" : NoneMessage;
}
