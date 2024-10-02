// SPDX-License-Identifier: MPL-2.0
namespace wawa.Modules.Internals;

/// <summary>Contains static methods able to be accessed from anywhere within this library.</summary>
static class Globals
{
    /// <summary>The default string comparison throughout this library.</summary>
    internal const StringComparison Ordinal = StringComparison.Ordinal;

    /// <summary>Enumerates a sequence twice with a selector and produces an immutable array of its contents.</summary>
    /// <typeparam name="TSource">The type of element in the inputting sequence.</typeparam>
    /// <typeparam name="TResult">The type of element in the resulting sequence.</typeparam>
    /// <param name="items">The sequence to enumerate.</param>
    /// <param name="selector">The selector for each item.</param>
    /// <returns>An immutable array.</returns>
    [Pure]
    internal static ReadOnlyCollection<TResult> ToReadOnly<TSource, TResult>(
        [InstantHandle, NotNull] this IEnumerable<TSource> items,
        [InstantHandle, NotNull] in Func<TSource, TResult> selector
    ) =>
        new(items.Select(selector).ToList());
}
