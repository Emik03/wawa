#region Emik.MPL

// <copyright file="Lookup.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

namespace Wawa.DDL;

#region

using static BindingFlags;

#endregion

/// <summary>Allows for querying general data from the game.</summary>
// ReSharper disable Unity.PerformanceCriticalCodeInvocation
[PublicAPI]
public static class Lookup
{
    [NotNull]
    const string ModsName = "loadedMods";

    const BindingFlags ModsBindings = DeclaredOnly | Instance | NonPublic;

    /// <summary>Gets the dictionary of loaded mods.</summary>
    /// <remarks><para>
    /// In the editor, this value returns an instance of <see cref="Hashtable"/>, initialized as empty.
    /// </para></remarks>
    [NotNull, PublicAPI]
    public static IDictionary Mods { [Pure] get; } = FromGame(0, static _ => Factory(), new Hashtable());

    /// <summary>Gets the localized value of a <see cref="string"/> term.</summary>
    /// <remarks><para>In the editor, this value returns <see cref="Maybe.None{T}"/>.</para></remarks>
    /// <param name="term">The term to get the localized <see cref="string"/> of.</param>
    /// <returns>The localized <see cref="string"/> of <paramref name="term"/>.</returns>
    public static Maybe<string> Localized([NotNull] string term) =>
        FromGame(term, static v => Localization.GetLocalizedString(v));

    [NotNull]
    static IDictionary Factory() =>
        typeof(ModManager).GetField(ModsName, ModsBindings)?.GetValue(ModManager.Instance) as IDictionary ??
        throw new();
}
