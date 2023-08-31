// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Editors.Internals;

/// <summary>Adds a simple UI to download and update this family of libraries.</summary>
[UsedImplicitly]
#pragma warning disable CA1812
sealed class WawaEditor : Editor
#pragma warning restore CA1812
{
    /// <summary>The name of this library.</summary>
    [NotNull, ProvidesContext]
    internal const string This = $"{Wawa}Editors";

    [NotNull]
    const string
        All = "All wawa libraries",
        DDL = $"{Wawa}{nameof(DDL)}",
        Extensions = $"{Wawa}{nameof(Extensions)}",
        IO = $"{Wawa}{nameof(IO)}",
        Modules = $"{Wawa}{nameof(Modules)}",
        Optionals = $"{Wawa}{nameof(Optionals)}",
        Prefix = "wawa/",
        Scaffold = $"{Prefix}{nameof(Scaffold)}/",
        Suffix = " & deps",
        Recall = $"{Wawa}{nameof(Recall)}",
        TwitchPlays = $"{Wawa}{nameof(TwitchPlays)}",
        Update = $"{Prefix}{nameof(Update)}/",
        Unity = $"{Wawa}{nameof(Unity)}",
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
    static void FetchModules() => Fetch(Optionals, DDL, IO, Unity, Modules);

    [MenuItem($"{Update}{Recall}{Suffix}"), UsedImplicitly]
    static void FetchRecall() => Fetch(Optionals, Recall);

    [MenuItem($"{Update}{TwitchPlays}{Suffix}"), UsedImplicitly]
    static void FetchTwitchPlays() => Fetch(Optionals, DDL, IO, Modules, Unity, TwitchPlays);

    [MenuItem($"{Update}{All}"), UsedImplicitly]
    static void FetchAll() => Fetch(Optionals, Unity, DDL, Recall, IO, Modules, TwitchPlays, Extensions, This);
}
