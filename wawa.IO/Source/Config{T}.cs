﻿// SPDX-License-Identifier: MPL-2.0
namespace wawa.IO;

/// <summary>Meant for information that needs to be deserialized within the mod settings folder.</summary>
/// <remarks><para>
/// Originally by samfundev: https://github.com/samfundev/KTANE-Utilities/blob/master/ModConfig.cs.
/// </para><para>
/// All constructors in this type have the following side effects:
/// </para><list type="bullet">
/// <item><description>A file will automatically be made if it doesn't exist.</description></item>
/// <item><description>
/// A JSON property defined in the type <typeparamref name="T"/> that doesn't exist in the file
/// will automatically be appended with a new default instance of <typeparamref name="T"/>'s values.
/// </description></item>
/// <item><description>
/// In the editor, this constructor will not merge the default of type <typeparamref name="T"/> with the file.
/// </description></item>
/// </list></remarks>
/// <typeparam name="T">The type to serialize and deserialize the file.</typeparam>
[PublicAPI]
public sealed class Config<T> : ICloneable, IEquatable<Config<T>>, IEqualityComparer<Config<T>>
    where T : new()
{
    [NotNull, StringSyntax(StringSyntaxAttribute.Uri), UriString]
    static readonly string s_folder = Path.Combine(Application.persistentDataPath, Config.Folder);

    static Config() => s_folder.SuppressIO(Directory.CreateDirectory);

    /// <summary>Initializes a new instance of the <see cref="Config{TSerialize}"/> class.</summary>
    /// <remarks><list type="bullet">
    /// <item><description>
    /// The target file name is implicitly gotten by the name of the assembly that called this constructor.
    /// </description></item>
    /// <item><description>A file will automatically be made if it doesn't exist.</description></item>
    /// <item><description>
    /// A JSON property defined in the type <typeparamref name="T"/> that doesn't exist in the file
    /// will automatically be appended with a new default instance of <typeparamref name="T"/>'s values.
    /// </description></item>
    /// <item><description>
    /// In the editor, this constructor will not merge the default of type <typeparamref name="T"/> with the file.
    /// </description></item>
    /// </list></remarks>
    [PublicAPI]
    public Config()
        : this($"{Who}{Config.Suffix}") { }

    /// <summary>Initializes a new instance of the <see cref="Config{TSerialize}"/> class.</summary>
    /// <remarks><list type="bullet">
    /// <item><description>Allows specification of the target file name.</description></item>
    /// <item><description>A file will automatically be made if it doesn't exist.</description></item>
    /// <item><description>
    /// A JSON property defined in the type <typeparamref name="T"/> that doesn't exist in the file
    /// will automatically be appended with a new default instance of <typeparamref name="T"/>'s values.
    /// </description></item>
    /// <item><description>
    /// In the editor, this constructor will not merge the default of type <typeparamref name="T"/> with the file.
    /// </description></item>
    /// </list></remarks>
    /// <param name="fileName">The file name to get.</param>
    [PublicAPI]
    public Config([NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] string fileName)
    {
        FilePath = Path.Combine(s_folder, fileName);
        this.Merge(new());
    }

    /// <summary>Gets a value indicating whether there has been a successful read of the settings file.</summary>
    /// <remarks><para>This value will always be false in the editor.</para></remarks>
    [JsonIgnore, PublicAPI]
    public bool HasRead { [Pure] get; internal set; }

    /// <summary>Gets the path of the file to read and write.</summary>
    [JsonIgnore, NotNull, PublicAPI, ProvidesContext, StringSyntax(StringSyntaxAttribute.Uri), UriString]
    public string FilePath { [Pure] get; }

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public object Clone() => this;

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public bool Equals([AllowNull] Config<T> x, [AllowNull] Config<T> y) => x == y;

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public int GetHashCode([AllowNull, CanBeNull] Config<T> obj) => obj?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public bool Equals([AllowNull] Config<T> other) => this == other;

    /// <summary>Determines whether both instances are both <see langword="null"/> or both instances.</summary>
    /// <param name="left">The left-hand side operator.</param>
    /// <param name="right">The right-hand side operator.</param>
    /// <returns>
    /// The value <see langword="true"/> if both share the same <see cref="FilePath"/>,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [PublicAPI, Pure]
    public static bool operator ==([AllowNull, CanBeNull] Config<T> left, [AllowNull, CanBeNull] Config<T> right) =>
        (left?.FilePath).OrdinalEquals(right?.FilePath);

    /// <summary>Determines whether both instances are one of <see langword="null"/> and the other instanced.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if both do not share the same <see cref="FilePath"/>,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [PublicAPI, Pure]
    public static bool operator !=([AllowNull, CanBeNull] Config<T> left, [AllowNull, CanBeNull] Config<T> right) =>
        !(left == right);

    /// <inheritdoc/>
    [PublicAPI, Pure] // ReSharper disable once AssignNullToNotNullAttribute
    public override bool Equals([AllowNull] object? obj) => Equals(obj as Config<T>);

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public override int GetHashCode() => StringComparer.Ordinal.GetHashCode(FilePath);

    /// <summary>
    /// Deserializes, then re-serializes the file according to <see cref="Config.Serialize{T}"/>.
    /// In the editor, this method serializes the default value of the constructor in <typeparamref name="T"/>.
    /// </summary>
    /// <returns>A string representation of the value from <see cref="Config.Read{T}"/>.</returns>
    [PublicAPI]
    public override string ToString() => Config.Serialize(this.Read());
}
