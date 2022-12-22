#region Emik.MPL

// <copyright file="Globals.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

#region

global using Wawa.DDL;
global using Wawa.Optionals;
global using Wawa.Unity;
global using static KMAudio;
global using static KMSoundOverride;
global using static Wawa.DDL.Access;
global using static Wawa.IO.PathFinder;
global using static Wawa.Modules.Internals.Globals;

#endregion

namespace Wawa.Modules.Internals;

/// <summary>Contains static methods able to be accessed from anywhere within this library.</summary>
static class Globals
{
    /// <summary>The default string comparison throughout the library.</summary>
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
