// SPDX-License-Identifier: MPL-2.0
namespace wawa.Recall;

/// <summary>An interface for all property-like class behaviors.</summary>
/// <typeparam name="T">The type of value to <see langword="return"/> from the getter.</typeparam>
[PublicAPI]
public interface IValued<out T>
{
    /// <summary>Gets the value.</summary>
    [NotNull, PublicAPI]
    T Value { [Pure] get; }
}
