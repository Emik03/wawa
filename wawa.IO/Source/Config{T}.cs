// SPDX-License-Identifier: MPL-2.0
namespace Wawa.IO;

/// <summary>Meant for information that needs to be deserialized within the mod settings folder.</summary>
/// <remarks><para>
/// Originally by samfundev: https://github.com/Qkrisi/ktanemodkit/blob/master/Assets/Scripts/ModConfig.cs.
/// </para></remarks>
/// <typeparam name="T">The type to serialize and deserialize the file.</typeparam>
[PublicAPI]
public sealed class Config<T> : ICloneable, IEquatable<Config<T>>, IEqualityComparer<Config<T>>
    where T : new()
{
    const string Suffix = "-settings.json";

    [NotNull]
    static readonly string s_folder = Path.Combine(Application.persistentDataPath, Config.Folder);

    static Config() => s_folder.SuppressIO(Directory.CreateDirectory);

    /// <summary>
    /// Initializes a new instance of the <see cref="Config{TSerialize}"/> class.
    /// The target file name is implicitly gotten by the name of the assembly that called this.
    /// Allows specification of an optional event of when the file is read.
    /// A file will automatically be made if it doesn't exist.
    /// A JSON property defined in the type <typeparamref name="T"/>
    /// that isn't in the file will automatically write to the file with said property.
    /// In the editor, the constructor will not merge the default values of the type with the file.
    /// </summary>
    [PublicAPI]
    public Config()
        : this($"{Who}{Suffix}") { }

    /// <summary>
    /// Initializes a new instance of the <see cref="Config{TSerialize}"/> class.
    /// Allows specification of the target file name.
    /// A file will automatically be made if it doesn't exist.
    /// A JSON property defined in the type <typeparamref name="T"/>
    /// that isn't in the file will automatically write to the file with said property.
    /// In the editor, the constructor will not merge the default values of the type with the file.
    /// </summary>
    /// <param name="fileName">The file name to get.</param>
    [PublicAPI]
    public Config([NotNull, PathReference] string fileName)
    {
        FilePath = Path.Combine(s_folder, fileName);
        this.Merge(new());
    }

    /// <summary>Gets a value indicating whether or not there has been a successful read of the settings file.</summary>
    /// <remarks><para>This value will always be false in the editor.</para></remarks>
    [JsonIgnore, PublicAPI]
    public bool HasRead { [Pure] get; internal set; }

    /// <summary>Gets the path of the file to read and write.</summary>
    [JsonIgnore, NotNull, PublicAPI, ProvidesContext]
    public string FilePath { [Pure] get; }

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public object Clone() => this;

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public bool Equals(Config<T> x, Config<T> y) => x == y;

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public int GetHashCode([AllowNull, CanBeNull] Config<T> obj) => obj?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public bool Equals(Config<T> other) => this == other;

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
    [PublicAPI, Pure]
    public override bool Equals([AllowNull] object obj) => Equals(obj as Config<T>);

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
