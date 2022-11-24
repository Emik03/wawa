// <copyright file="MoreIReadOnly.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
// ReSharper disable CheckNamespace EmptyNamespace UnusedParameter.Global
namespace System.Collections.Generic;
#pragma warning disable CA1710, SA1649, MA0048
/// <summary>Provides a read-only, covariant view of a generic list.</summary>
/// <typeparam name="T">The type of item on the list.</typeparam>
interface IReadOnlyCollection<T> : IEnumerable<T>
{
    /// <summary>Gets the amount of items on the list.</summary>
    int Count { get; }
}

/// <summary>Provides a read-only view of a generic dictionary.</summary>
/// <typeparam name="TKey">The type of key in the dictionary.</typeparam>
/// <typeparam name="TValue">The type of value in the dictionary.</typeparam>
interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>
{
    /// <summary>Gets all enumeration of all keys.</summary>
    IEnumerable<TKey> Keys { get; }

    /// <summary>Gets an enumeration of all values.</summary>
    IEnumerable<TValue> Values { get; }

    /// <summary>Gets the value of the key.</summary>
    /// <param name="key">The key to index.</param>
    TValue this[TKey key] { get; }

    /// <summary>Determines whether a key exists in this dictionary.</summary>
    /// <param name="key">The key to check.</param>
    /// <returns>
    /// The value <see langword="true"/> if the key exists in the dictionary, otherwise <see langword="false"/>.
    /// </returns>
    bool ContainsKey(TKey key);

    /// <summary>Determines whether a key exists in this dictionary and extracts the value.</summary>
    /// <param name="key">The key to check.</param>
    /// <param name="value">The value to output.</param>
    /// <returns>
    /// The value <see langword="true"/> if the key exists in the dictionary, otherwise <see langword="false"/>.
    /// </returns>
    bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value);
}

/// <summary>Represents a read-only collection of elements that can be accessed by index.</summary>
/// <typeparam name="T">The type of elements in the read-only list.</typeparam>
interface IReadOnlyList<T> : IReadOnlyCollection<T>
{
    /// <summary>Performs an index operation on the list.</summary>
    /// <param name="index">The item to retrieve.</param>
    T this[int index] { get; }
}

/// <summary>Provides a readonly abstraction of a set.</summary>
/// <typeparam name="T">The type of elements in the set.</typeparam>
interface IReadOnlySet<T> : IReadOnlyCollection<T>
{
    /// <summary>Determines if the set contains a specific item.</summary>
    /// <param name="item">The item to check if the set contains.</param>
    /// <returns><see langword="true"/> if found; otherwise <see langword="false"/>.</returns>
    [Pure]
    bool Contains(T item);

    /// <summary>Determines whether the current set is a proper (strict) subset of a specified collection.</summary>
    /// <param name="other">The collection to compare to the current set.</param>
    /// <returns>
    /// <see langword="true"/> if the current set is a proper subset of other; otherwise <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">other is <see langword="null"/>.</exception>
    bool IsProperSubsetOf(IEnumerable<T> other);

    /// <summary>Determines whether the current set is a proper (strict) superset of a specified collection.</summary>
    /// <param name="other">The collection to compare to the current set.</param>
    /// <returns>
    /// <see langword="true"/> if the collection is a proper superset of other; otherwise <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">other is <see langword="null"/>.</exception>
    bool IsProperSupersetOf(IEnumerable<T> other);

    /// <summary>Determine whether the current set is a subset of a specified collection.</summary>
    /// <param name="other">The collection to compare to the current set.</param>
    /// <returns><see langword="true"/> if the current set is a subset of other; otherwise <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException">other is <see langword="null"/>.</exception>
    bool IsSubsetOf(IEnumerable<T> other);

    /// <summary>Determine whether the current set is a super set of a specified collection.</summary>
    /// <param name="other">The collection to compare to the current set.</param>
    /// <returns><see langword="true"/> if the current set is a subset of other; otherwise <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException">other is <see langword="null"/>.</exception>
    bool IsSupersetOf(IEnumerable<T> other);

    /// <summary>Determines whether the current set overlaps with the specified collection.</summary>
    /// <param name="other">The collection to compare to the current set.</param>
    /// <returns>
    /// <see langword="true"/> if the current set and other share at least one common element;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">other is <see langword="null"/>.</exception>
    bool Overlaps(IEnumerable<T> other);

    /// <summary>Determines whether the current set and the specified collection contain the same elements.</summary>
    /// <param name="other">The collection to compare to the current set.</param>
    /// <returns>
    /// <see langword="true"/> if the current set is equal to other; otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">other is <see langword="null"/>.</exception>
    bool SetEquals(IEnumerable<T> other);
}

/// <summary>
/// Generic collection that guarantees the uniqueness of its elements, as defined by some comparer.
/// It also supports basic set operations such as Union, Intersection, Complement and Exclusive Complement.
/// </summary>
/// <typeparam name="T">The type of element in the set.</typeparam>
interface ISet<T> : ICollection<T>
{
    /// <summary>
    /// Transforms this set so it contains no elements that are also in an <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <param name="other">The <see cref="IEnumerable{T}"/> to transform with.</param>
    void ExceptWith(IEnumerable<T> other);

    /// <summary>Transforms this set into its intersection with an <see cref="IEnumerable{T}"/>.</summary>
    /// <param name="other">The <see cref="IEnumerable{T}"/> to transform with.</param>
    void IntersectWith(IEnumerable<T> other);

    /// <summary>
    /// Transforms this set so it contains elements initially in this or an <see cref="IEnumerable{T}"/>, but not both.
    /// </summary>
    /// <param name="other">The <see cref="IEnumerable{T}"/> to transform with.</param>
    void SymmetricExceptWith(IEnumerable<T> other);

    /// <summary>Transforms this set into its union with an <see cref="IEnumerable{T}"/>.</summary>
    /// <param name="other">The <see cref="IEnumerable{T}"/> to transform with.</param>
    void UnionWith(IEnumerable<T> other);

    /// <summary>Adds an item to the set.</summary>
    /// <param name="item">The item to add.</param>
    /// <returns>The value <see langword="true"/> if added, <see langword="false"/> if duplicate.</returns>
    new bool Add(T item);

    /// <summary>Checks if this set is a subset of an <see cref="IEnumerable{T}"/>, but not the same as it.</summary>
    /// <param name="other">The <see cref="IEnumerable{T}"/> to transform with.</param>
    /// <returns>The value <see langword="true"/> if a match is found, otherwise <see langword="false"/>.</returns>
    bool IsProperSubsetOf(IEnumerable<T> other);

    /// <summary>Checks if this set is a superset of an <see cref="IEnumerable{T}"/>, but not the same as it.</summary>
    /// <param name="other">The <see cref="IEnumerable{T}"/> to transform with.</param>
    /// <returns>The value <see langword="true"/> if a match is found, otherwise <see langword="false"/>.</returns>
    bool IsProperSupersetOf(IEnumerable<T> other);

    /// <summary>Checks if this set is a subset of an <see cref="IEnumerable{T}"/>.</summary>
    /// <param name="other">The <see cref="IEnumerable{T}"/> to transform with.</param>
    /// <returns>The value <see langword="true"/> if a match is found, otherwise <see langword="false"/>.</returns>
    bool IsSubsetOf(IEnumerable<T> other);

    /// <summary>Checks if this set is a superset of an <see cref="IEnumerable{T}"/>.</summary>
    /// <param name="other">The <see cref="IEnumerable{T}"/> to transform with.</param>
    /// <returns>The value <see langword="true"/> if a match is found, otherwise <see langword="false"/>.</returns>
    bool IsSupersetOf(IEnumerable<T> other);

    /// <summary>Checks if this set has any elements in common with an <see cref="IEnumerable{T}"/>.</summary>
    /// <param name="other">The <see cref="IEnumerable{T}"/> to transform with.</param>
    /// <returns>The value <see langword="true"/> if a match is found, otherwise <see langword="false"/>.</returns>
    bool Overlaps(IEnumerable<T> other);

    /// <summary>
    /// Checks if this set contains the same and only the same elements as an <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <param name="other">The <see cref="IEnumerable{T}"/> to transform with.</param>
    /// <returns>The value <see langword="true"/> if a match is found, otherwise <see langword="false"/>.</returns>
    bool SetEquals(IEnumerable<T> other);
}
