// SPDX-License-Identifier: MPL-2.0
namespace wawa.Modules;

/// <summary>
/// Provides an interpolated string handler that builds a list of objects and formatted strings,
/// exposing enumeration of the backing list through its <see cref="GetEnumerator"/>.
/// </summary>
/// <param name="literalLength">
/// The number of constant characters outside of interpolation expressions in the interpolated string.
/// </param>
/// <param name="formattedCount">The number of interpolation expressions in the interpolated string.</param>
[InterpolatedStringHandler, PublicAPI]
public readonly struct InterpolatedStringHandlerEnumerable(
    [NonNegativeValue] int literalLength,
    [NonNegativeValue] int formattedCount
)
    : IEnumerable<KeyValuePair<object, string>>
{
    /// <summary>The list to append and enumerate through.</summary>
    readonly List<KeyValuePair<object, string>> _list = new(formattedCount * 2 + 1);

    /// <summary>Gets the recommended string size for concatenating all values in this instance.</summary>
    /// <remarks><para>
    /// This value is only a guess, the resulting string can end up larger or lesser than this property.
    /// </para></remarks>
    public int RecommendedLength
    {
        [NonNegativeValue, PublicAPI, Pure]
        get => literalLength + formattedCount * 11;
    }

    /// <summary>Writes the specified value to the handler.</summary>
    /// <param name="value">The value to write.</param>
    /// <param name="format">The format string.</param>
    [PublicAPI]
    public void AppendFormatted([AllowNull, CanBeNull] object value, [AllowNull, CanBeNull] string format = null) =>
        _list.Add(new(value, format));

    /// <summary>Writes the specified string to the handler.</summary>
    /// <param name="value">The string to write.</param>
    [PublicAPI]
    public void AppendLiteral([AllowNull, CanBeNull] string value) => _list.Add(new(value, null));

    /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
    [PublicAPI, Pure]
    List<KeyValuePair<object, string>>.Enumerator GetEnumerator() => _list.GetEnumerator();

    /// <inheritdoc />
    [PublicAPI, Pure]
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <inheritdoc />
    [PublicAPI, Pure]
    IEnumerator<KeyValuePair<object, string>> IEnumerable<KeyValuePair<object, string>>.GetEnumerator() =>
        GetEnumerator();
}
