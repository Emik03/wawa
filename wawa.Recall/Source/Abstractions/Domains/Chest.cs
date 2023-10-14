// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Recall;

/// <summary>Internal storage of events used by <see cref="Hook{T}"/> to remove delegates.</summary>
sealed class Chest : ICloneable, IEnumerable<Delegate>
{
    [NotNull]
    const string
        ElementSeparator = ", ",
        KeyValueSeparator = ": ";

    [NotNull]
    readonly Dictionary<Delegate, Delegate> _dictionary = [];

    /// <inheritdoc/>
    [Pure]
    public object Clone()
    {
        Chest instance = [];

        foreach (var item in _dictionary)
            instance._dictionary[item.Key] = item.Value;

        return instance;
    }

    /// <inheritdoc/>
    [Pure]
    public override string ToString()
    {
        StringBuilder sb = new();

        using var e = _dictionary.GetEnumerator();

        if (e.MoveNext())
            sb.Append(e.Current.Key).Append(KeyValueSeparator).Append(e.Current.Value);

        while (e.MoveNext())
            sb.Append(ElementSeparator).Append(e.Current.Key).Append(KeyValueSeparator).Append(e.Current.Value);

        return sb.ToString();
    }

    /// <inheritdoc />
    public IEnumerator<Delegate> GetEnumerator() => _dictionary.Keys.AsEnumerable().GetEnumerator();

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <summary>Clears the dictionary.</summary>
    internal void Clear() => _dictionary.Clear();

    /// <summary>Adds an entry to the dictionary.</summary>
    /// <param name="key">The key of the key-value-pair to add.</param>
    /// <param name="value">The value of the key-value-pair to add.</param>
    /// <returns>The value <see langword="true"/> if the mutation succeeds, otherwise <see langword="false"/>.</returns>
    internal bool Add([AllowNull, CanBeNull, NotNullWhen(true)] in Delegate? key, [NotNull] in Delegate value)
    {
        if (key is null || !_dictionary.ContainsKey(key))
            return false;

        _dictionary[key] = value;
        return true;
    }

    /// <summary>
    /// Removes an entry to the dictionary, if the value doesn't exist in the dictionary, nothing happens.
    /// </summary>
    /// <param name="key">The key to remove from the dictionary.</param>
    /// <returns>The value <see langword="true"/> if the mutation succeeds, otherwise <see langword="false"/>.</returns>
    internal bool Remove([AllowNull, CanBeNull, NotNullWhen(true)] in Delegate? key) =>
        key is not null && _dictionary.Remove(key);

    /// <summary>
    /// Gets the value from the inner dictionary.
    /// If the value doesn't exist in the dictionary, then <see langword="null"/> is returned instead.
    /// </summary>
    /// <param name="key">The key to use on the dictionary.</param>
    /// <returns>The key <paramref name="key"/> indexed into the inner dictionary, or <see langword="null"/>.</returns>
    [Pure]
    internal Delegate? Get([AllowNull, CanBeNull] in Delegate? key) =>
        key is not null && _dictionary.TryGetValue(key, out var value) ? value : null;
}
