#region Emik.MPL

// <copyright file="ModInfo.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

namespace Wawa.IO;

/// <summary>
/// Contains the properties needed to perform JSON-deserialization
/// of a modInfo.json located in the root directory of a mod.
/// </summary>
[PublicAPI]
public sealed class ModInfo : ICloneable, IEquatable<ModInfo>, IEqualityComparer<ModInfo>
{
    /// <summary>The file name used for this type.</summary>
    [NotNull, PublicAPI]
    public const string FileName = "modInfo.json";

    static readonly ModInfo s_default = new();

    ModInfo() { }

    /// <summary>Gets the author(s) of the mod.</summary>
    [JsonProperty("author"), NotNull, PublicAPI]
    public string Author { [Pure] get; private set; } = "";

    /// <summary>Gets the description of the mod.</summary>
    [JsonProperty("description"), NotNull, PublicAPI]
    public string Description { [Pure] get; private set; } = "";

    /// <summary>Gets the id of the mod.</summary>
    [JsonProperty("id"), NotNull, PublicAPI]
    public string Id { [Pure] get; private set; } = "";

    /// <summary>Gets the title of the mod.</summary>
    [JsonProperty("title"), NotNull, PublicAPI]
    public string Title { [Pure] get; private set; } = "";

    /// <summary>Gets the Unity version used to compile the mod.</summary>
    [JsonProperty("unityVersion"), NotNull, PublicAPI]
    public string UnityVersion { [Pure] get; private set; } = "";

    /// <summary>Gets the version number of the mod.</summary>
    [JsonProperty("version"), NotNull, PublicAPI]
    public string Version { [Pure] get; private set; } = "";

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public object Clone() =>
        new ModInfo
        {
            Author = Author,
            Description = Description,
            Id = Id,
            Title = Title,
            UnityVersion = UnityVersion,
            Version = Version,
        };

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public bool Equals(ModInfo x, ModInfo y) => x == y;

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public int GetHashCode([AllowNull, CanBeNull] ModInfo obj) => obj?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public bool Equals(ModInfo other) => this == other;

    /// <summary>Determines whether both instances contain the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>The value <see langword="true"/> if both instances contain the same values.</returns>
    [PublicAPI, Pure]
    public static bool operator ==([AllowNull, CanBeNull] ModInfo left, [AllowNull, CanBeNull] ModInfo right) =>
        left is null
            ? right is null
            : right is not null &&
            left.Author.OrdinalEquals(right.Author) &&
            left.Description.OrdinalEquals(right.Description) &&
            left.Id.OrdinalEquals(right.Id) &&
            left.Title.OrdinalEquals(right.Title) &&
            left.UnityVersion.OrdinalEquals(right.UnityVersion) &&
            left.Version.OrdinalEquals(right.Version);

    /// <summary>Determines whether both instances do not contain the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>The value <see langword="true"/> if both instances do not contain the same values.</returns>
    [PublicAPI, Pure]
    public static bool operator !=([AllowNull, CanBeNull] ModInfo left, [AllowNull, CanBeNull] ModInfo right) =>
        !(left == right);

    /// <summary>Tries to deserialize the parameter as <see cref="ModInfo"/>.</summary>
    /// <param name="contents">The contents to a modInfo.json.</param>
    /// <returns>
    /// A <see cref="Maybe{T}"/> containing either a <see langword="new"/> instance
    /// of <see cref="ModInfo"/> which has the information of the file if the serialization is successful,
    /// or no value if the file couldn't be read/located.
    /// </returns>
    [PublicAPI]
    public static Maybe<ModInfo> Deserialize([AllowNull, CanBeNull] string contents) =>
        contents?.SuppressIO(JsonConvert.DeserializeObject<ModInfo>, true);

    /// <summary>
    /// Attempts to read the specified path to try to deserialize its contents as <see cref="ModInfo"/>.
    /// </summary>
    /// <param name="path">The contents to a modInfo.json.</param>
    /// <returns>
    /// A <see cref="Maybe{T}"/> containing either a <see langword="new"/> instance
    /// of <see cref="ModInfo"/> which has the information of the file if the serialization is successful,
    /// or no value if the file couldn't be read/located.
    /// </returns>
    [PublicAPI]
    public static Maybe<ModInfo> ReadThenDeserialize([AllowNull, CanBeNull, PathReference] string path) =>
        File.Exists(path)
            ? path?.SuppressIO(File.ReadAllText, true)?.SuppressIO(JsonConvert.DeserializeObject<ModInfo>, true)
            : default;

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public override bool Equals(object obj) => Equals(obj as ModInfo);

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public override int GetHashCode()
    {
        var hashCode = 1876013109;

        // The setters only exist for serialization means. This class is immutable otherwise.
        // ReSharper disable NonReadonlyMemberInGetHashCode
        hashCode = hashCode * -1521134295 + StringComparer.Ordinal.GetHashCode(Author);
        hashCode = hashCode * -1521134295 + StringComparer.Ordinal.GetHashCode(Description);
        hashCode = hashCode * -1521134295 + StringComparer.Ordinal.GetHashCode(Id);
        hashCode = hashCode * -1521134295 + StringComparer.Ordinal.GetHashCode(Title);
        hashCode = hashCode * -1521134295 + StringComparer.Ordinal.GetHashCode(UnityVersion);
        hashCode = hashCode * -1521134295 + StringComparer.Ordinal.GetHashCode(Version);

        // ReSharper restore NonReadonlyMemberInGetHashCode

        return hashCode;
    }

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public override string ToString() =>
        $"{{ {nameof(Author)}: {Author}, {nameof(Description)}: {Description}, {nameof(Id)}: {Id}, " +
        $"{nameof(Title)}: {Title}, {nameof(UnityVersion)}: {UnityVersion}, {nameof(Version)}: {Version} }}";

    /// <summary>Creates a <see cref="ModInfo"/> from the same type in the game.</summary>
    /// <param name="metadata">The instance containing the metadata of the mod.</param>
    /// <returns>
    /// A new <see cref="ModInfo"/> instance containing the same data as <paramref name="metadata"/>,
    /// or the default instance if <paramref name="metadata"/> isn't the type from the game.
    /// </returns>
    [NotNull, Pure]
    internal static ModInfo FromInternalModInfo([AllowNull, CanBeNull] object metadata) =>
        FromGame(
            metadata,
            static x => x is Assets.Scripts.Mods.ModInfo mod
                ? new ModInfo
                {
                    Author = mod.Author,
                    Description = mod.Description,
                    Id = mod.ID,
                    Title = mod.Title,
                    UnityVersion = mod.UnityVersion,
                    Version = mod.Version,
                }
                : null,
            s_default
        );
}
