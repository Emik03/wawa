// SPDX-License-Identifier: MPL-2.0
namespace wawa.Editors.Internals;

/// <summary>Adds a simple UI to download and update this family of libraries.</summary>
[UsedImplicitly]
#pragma warning disable CA1812
sealed class WawaEditor : Editor
#pragma warning restore CA1812
{
    /// <summary>The name of this library.</summary>
    [NotNull, ProvidesContext]
    internal const string This = $"{Wawa}Editors";

    /// <summary>The name of the label.</summary>
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
        Schemas = $"{Wawa}{nameof(Schemas)}",
        TwitchPlays = $"{Wawa}{nameof(TwitchPlays)}",
        Update = $"{Prefix}{nameof(Update)}/",
        Unity = $"{Wawa}{nameof(Unity)}",
        Wawa = "wawa.";

    /// <summary>Creates a new solvable module.</summary>
    [MenuItem($"{Scaffold}{nameof(Solvable)}"), UsedImplicitly]
    static void CreateSolvable() => Solvable();

    /// <summary>Creates a new needy module.</summary>
    [MenuItem($"{Scaffold}{nameof(Needy)}"), UsedImplicitly]
    static void CreateNeedy() => Needy();

    /// <summary>Fetches the optionals package.</summary>
    [MenuItem($"{Update}{Optionals}"), UsedImplicitly]
    static void FetchOptionals() => Fetch(Optionals);

    /// <summary>Fetches the unity package.</summary>
    [MenuItem($"{Update}{Unity}"), UsedImplicitly]
    static void FetchUnity() => Fetch(Unity);

    /// <summary>Fetches this package.</summary>
    [MenuItem($"{Update}{This}"), UsedImplicitly]
    static void FetchThis() => Fetch(This);

    /// <summary>Fetches the extensions package.</summary>
    [MenuItem($"{Update}{Extensions}"), UsedImplicitly]
    static void FetchExtensions() => Fetch(Extensions);

    /// <summary>Fetches the schemas package.</summary>
    [MenuItem($"{Update}{Schemas}"), UsedImplicitly]
    static void FetchSchemas() => Fetch(Schemas);

    /// <summary>Fetches the DDL package and its dependencies.</summary>
    [MenuItem($"{Update}{DDL}{Suffix}"), UsedImplicitly]
    static void FetchDDL() => Fetch(Optionals, DDL);

    /// <summary>Fetches the IO package and its dependencies.</summary>
    [MenuItem($"{Update}{IO}{Suffix}"), UsedImplicitly]
    static void FetchIO() => Fetch(Optionals, DDL, IO);

    /// <summary>Fetches the modules package and its dependencies.</summary>
    [MenuItem($"{Update}{Modules}{Suffix}"), UsedImplicitly]
    static void FetchModules() => Fetch(Optionals, DDL, IO, Unity, Modules);

    /// <summary>Fetches the recall package and its dependencies.</summary>
    [MenuItem($"{Update}{Recall}{Suffix}"), UsedImplicitly]
    static void FetchRecall() => Fetch(Optionals, DDL, Recall);

    /// <summary>Fetches the twitch plays package and its dependencies.</summary>
    [MenuItem($"{Update}{TwitchPlays}{Suffix}"), UsedImplicitly]
    static void FetchTwitchPlays() => Fetch(Optionals, DDL, IO, Modules, Unity, TwitchPlays);

    /// <summary>Fetches all packages.</summary>
    [MenuItem($"{Update}{All}"), UsedImplicitly]
    static void FetchAll() => Fetch(Optionals, Schemas, Unity, DDL, Recall, IO, Modules, TwitchPlays, Extensions, This);
}
