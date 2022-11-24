// <copyright file="WawaEditor.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Wawa.Editors.Internals;

/// <summary>Adds a simple UI to download and update this family of libraries.</summary>
[UsedImplicitly]
#pragma warning disable CA1812
sealed class WawaEditor : Editor
#pragma warning restore CA1812
{
    /// <summary>The name of this library.</summary>
    [NotNull]
    internal const string This = $"{Wawa}Editors";

    [NotNull]
    const string
        DDL = $"{Wawa}{nameof(DDL)}",
        Emik = "Emik.",
        Extensions = $"{Wawa}{nameof(Extensions)}",
        IO = $"{Wawa}{nameof(IO)}",
        Modules = $"{Wawa}{nameof(Modules)}",
        Optionals = $"{Emik}{nameof(Optionals)}",
        Prefix = "wawa/",
        Scaffold = $"{Prefix}{nameof(Scaffold)}/",
        Suffix = " & deps",
        TwitchPlays = $"{Wawa}{nameof(TwitchPlays)}",
        Update = $"{Prefix}{nameof(Update)}/",
        Unity = $"{Emik}{nameof(Unity)}",
        Wawa = "wawa.";

    [MenuItem($"{Scaffold}{nameof(Solvable)}"), UsedImplicitly]
    static void CreateSolvable() => Solvable();

    [MenuItem($"{Scaffold}{nameof(Needy)}"), UsedImplicitly]
    static void CreateNeedy() => Needy();

    [MenuItem($"{Update}{Optionals}"), UsedImplicitly]
    static void FetchOptionals() => Fetch(Optionals);

    [MenuItem($"{Update}{Unity}"), UsedImplicitly]
    static void FetchUnity() => Fetch(Unity);

    [MenuItem($"{Update}{This}"), UsedImplicitly]
    static void FetchThis() => Fetch(This);

    [MenuItem($"{Update}{Extensions}"), UsedImplicitly]
    static void FetchExtensions() => Fetch(Extensions);

    [MenuItem($"{Update}{DDL}{Suffix}"), UsedImplicitly]
    static void FetchDDL() => Fetch(Optionals, DDL);

    [MenuItem($"{Update}{IO}{Suffix}"), UsedImplicitly]
    static void FetchIO() => Fetch(Optionals, DDL, IO);

    [MenuItem($"{Update}{Modules}{Suffix}"), UsedImplicitly]
    static void FetchModules() => Fetch(Optionals, DDL, IO, Modules);

    [MenuItem($"{Update}{TwitchPlays}{Suffix}"), UsedImplicitly]
    static void FetchTwitchPlays() => Fetch(Optionals, DDL, IO, Modules, TwitchPlays);
}
