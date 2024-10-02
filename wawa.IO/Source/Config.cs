// SPDX-License-Identifier: MPL-2.0
namespace wawa.IO;

/// <summary>Implementations for <see cref="Config{TSerialize}"/>.</summary>
[PublicAPI]
public static class Config
{
    /// <summary>The name of the folder that contains locally stored mod settings.</summary>
    [NotNull, PublicAPI, StringSyntax(StringSyntaxAttribute.Uri), UriString]
    public const string Folder = "Modsettings";

    /// <summary>The suffix for the default file name for mod settings.</summary>
    [NotNull, PublicAPI, StringSyntax(StringSyntaxAttribute.Uri), UriString]
    public const string Suffix = "-settings.json";

    /// <summary>The key substring that is ignored in mod configs.</summary>
    [NotNull, PublicAPI]
    public const string Tutorial = "HowToUse";

    /// <summary>Serializes settings the same way it's written to the file. Supports settings that use enums.</summary>
    /// <typeparam name="TSerialize">The type to serialize the value.</typeparam>
    /// <param name="value">The value to serialize.</param>
    /// <returns>A <see cref="string"/> representation of <paramref name="value"/> by serializing it as JSON.</returns>
    [NotNull, PublicAPI]
    public static string Serialize<TSerialize>([DisallowNull, NotNull] TSerialize value) =>
        JsonConvert.SerializeObject(value, Formatting.Indented, new StringEnumConverter());

    /// <summary>Writes the string to the settings file.</summary>
    /// <remarks><para>
    /// To protect the user settings, this does nothing if the last read wasn't successful.
    /// </para><para>
    /// In the editor, this method does nothing.
    /// </para></remarks>
    /// <typeparam name="T">The generic used in <paramref name="that"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Config{T}"/>.</param>
    /// <param name="value">The contents to write.</param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [NotNull, PublicAPI]
    public static Config<T> Write<T>(
        [NotNull] this Config<T> that,
        [NotNull, StringSyntax(StringSyntaxAttribute.Json)] string value
    )
        where T : new()
    {
        if (!IsKtane && !IsRewritten || !that.HasRead)
            return that;

        AssemblyLog(@$"Writing to the file ""{that.FilePath}"" with the following contents: {value}");

        new
        {
            that.FilePath,
            Contents = value,
        }.SuppressIO(static t => File.WriteAllText(t.FilePath, t.Contents));

        return that;
    }

    /// <summary>Writes the settings to the settings file.</summary>
    /// <remarks><para>
    /// To protect the user settings, this does nothing if the last read wasn't successful.
    /// </para><para>
    /// In the editor, this method does nothing.
    /// </para></remarks>
    /// <typeparam name="T">The generic used in <paramref name="that"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Config{T}"/>.</param>
    /// <param name="value">The value to overwrite the settings file with.</param>
    /// <returns>The value <see langword="default"/>.</returns>
    [NotNull, PublicAPI]
    public static Config<T> Write<T>([NotNull] this Config<T> that, [AllowNull, CanBeNull] T value)
        where T : new() => // ReSharper disable once ConstantNullCoalescingCondition
        that.Write(Serialize(value ?? new()));

    /// <summary>Reads, merges, and writes the settings to the settings file.</summary>
    /// <remarks><para>
    /// To protect the user settings, this does nothing if the last read wasn't successful.
    /// </para><para>
    /// In the editor, this method does nothing.
    /// </para></remarks>
    /// <typeparam name="T">The generic used in <paramref name="that"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Config{T}"/>.</param>
    /// <param name="value">The value to merge the file with.</param>
    /// <param name="isDiscarding">
    /// Determines whether it should remove values from the original
    /// file that isn't contained within the type, or has the incorrect type.
    /// </param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [NotNull, PublicAPI]
    public static Config<T> Merge<T>(
        [NotNull] this Config<T> that,
        [AllowNull, CanBeNull] T value,
        [InstantHandle] bool isDiscarding = false
    )
        where T : new()
    {
        that.HasRead = false;

        if (TryCreateNewFile(that) || that.FilePath.SuppressIO(File.ReadAllText) is not { } contents)
            return that;

        JObject
            toMerge = Parse(Serialize(value ?? new())),
            content = Parse(contents);

        toMerge.Merge(content, new());

        if (isDiscarding)
            toMerge.Lint(content);

        that.Write(toMerge.ToString());
        that.HasRead = true;
        return that;
    }

    /// <summary>Reads the settings from the settings file.</summary>
    /// <remarks><para>
    /// If the settings couldn't be read, the default settings will be returned.
    /// </para><para>
    /// In the editor, this method returns the default value of the constructor in <typeparamref name="T"/>.
    /// </para></remarks>
    /// <typeparam name="T">The generic used in <paramref name="that"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Config{T}"/>.</param>
    /// <returns>
    /// If the read and deserialization was successful, a <typeparamref name="T"/> containing the values from the file,
    /// otherwise a new instance of <typeparamref name="T"/>.
    /// </returns>
    [NotNull, PublicAPI]
    public static T Read<T>([NotNull] this Config<T> that)
        where T : new() =>
        that.SuppressIO(Deserialized) ?? new();

    static void Lint([NotNull] this JObject toMerge, [NotNull] in JObject content)
    {
        foreach (var kvp in toMerge)
        {
            if (!kvp.Key.StartsWith(Tutorial, Ordinal) && toMerge[kvp.Key].Type != content[kvp.Key].Type)
                continue;

            toMerge.Remove(kvp.Key);
            AssemblyLog(@$"The original file has a redundant key ""{kvp.Key}"" which has been removed.");
        }
    }

    static bool TryCreateNewFile<T>([NotNull] Config<T> that)
        where T : new()
    {
        if (!IsKtane && !IsRewritten)
        {
            AssemblyLog("In the editor; Nothing will be performed on the file system.");
            return true;
        }

        if (File.Exists(that.FilePath))
            return false;

        AssemblyLog(@$"The file ""{that.FilePath}"" doesn't exist, writing new instance.");
        File.WriteAllText(that.FilePath, Serialize(new T()));
        return true;
    }

    [NotNull, Pure]
    static JObject Parse(string file)
    {
        try
        {
            return JObject.Parse(file);
        }
        catch (JsonReaderException)
        {
            return [];
        }
    }

    [NotNull]
    static T Deserialized<T>([NotNull] Config<T> that)
        where T : new()
    {
        that.HasRead = false;

        if (TryCreateNewFile(that))
            return new();

        var contents = File.ReadAllText(that.FilePath);
        var deserialized = JsonConvert.DeserializeObject<T>(contents, new JsonSerializerSettings()) ?? new();

        var message = typeof(T).GetMethod(nameof(ToString), Type.EmptyTypes)?.DeclaringType == typeof(T)
            ? deserialized.ToString()
            : Serialize(deserialized);

        AssemblyLog($"Read was successful: {message}");
        that.HasRead = true;
        return deserialized;
    }
}
