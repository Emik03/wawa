// SPDX-License-Identifier: MPL-2.0
namespace wawa.IO.Internals;

/// <summary>Provides an <see cref="IEqualityComparer{T}"/> for <see cref="KeyValuePair{T, Type}"/>.</summary>
/// <typeparam name="T">The key type.</typeparam>
sealed class TypePairEqualityComparer<T> : IEqualityComparer<KeyValuePair<T, Type>>
{
    TypePairEqualityComparer() { }

    /// <summary>Gets the singleton instance.</summary>
    [NotNull]
    internal static IEqualityComparer<KeyValuePair<T, Type>> Instance { [Pure] get; } =
        new TypePairEqualityComparer<T>();

    /// <inheritdoc />
    [Pure]
    bool IEqualityComparer<KeyValuePair<T, Type>>.Equals(KeyValuePair<T, Type> x, KeyValuePair<T, Type> y) =>
        EqualityComparer<T>.Default.Equals(x.Key, y.Key) && x.Value == y.Value;

    /// <inheritdoc />
    [Pure]
    int IEqualityComparer<KeyValuePair<T, Type>>.GetHashCode(KeyValuePair<T, Type> obj) =>
        unchecked(EqualityComparer<T>.Default.GetHashCode(obj.Key) * 397 ^ obj.Value.GetHashCode());
}
