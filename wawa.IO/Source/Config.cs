#region Emik.MPL

// <copyright file="Config.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

namespace Wawa.IO;

/// <summary>Implementations for <see cref="Config{TSerialize}"/>.</summary>
[PublicAPI]
public static class Config
{
    /// <summary>The name of the folder that contains locally stored mod settings.</summary>
    [NotNull]
    public const string Folder = "Modsettings";

    /// <summary>The key substring that is ignored in mod configs.</summary>
    [NotNull]
    public const string Tutorial = "HowToUse";

    /// <summary>Serializes settings the same way it's written to the file. Supports settings that use enums.</summary>
    /// <typeparam name="TSerialize">The type to serialize the value.</typeparam>
    /// <param name="value">The value to serialize.</param>
    /// <returns>A <see cref="string"/> representation of <paramref name="value"/> by serializing it as JSON.</returns>
    [NotNull]
    public static string Serialize<TSerialize>([NotNull] TSerialize value) =>
        JsonConvert.SerializeObject(
            value,
            Formatting.Indented,
            new StringEnumConverter()
        );

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
    [NotNull]
    public static Config<T> Write<T>([NotNull] this Config<T> that, [NotNull] string value)
        where T : new()
    {
        if (!that.HasRead)
            return that;

        AssemblyLog(@$"Writing to file ""{that.FilePath}"" the following contents: {value}");

        new
        {
            that.FilePath,
            value,
        }.SuppressIO(static t => File.WriteAllText(t.FilePath, t.value));

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
    [NotNull]
    public static Config<T> Write<T>([NotNull] this Config<T> that, [NotNull] T value)
        where T : new() =>
        that.Write(Serialize(value));

    /// <summary>Reads, merges, and writes the settings to the settings file.</summary>
    /// <remarks><para>
    /// To protect the user settings, this does nothing if the last read wasn't successful.
    /// </para><para>
    /// In the editor, this method does nothing.
    /// </para></remarks>
    /// <typeparam name="T">The generic used in <paramref name="that"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Config{T}"/>.</param>
    /// <param name="value">The value to merge the file with.</param>
    /// <param name="isDiscarding">Determines whether it should remove values from the original
    /// file that isn't contained within the type, or has the incorrect type.</param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [NotNull]
    public static Config<T> Merge<T>(
        [NotNull] this Config<T> that,
        [NotNull] T value,
        [InstantHandle] bool isDiscarding = false
    )
        where T : new()
    {
        var file = that.FilePath.SuppressIO(File.ReadAllText);

        if (file is null)
            return that;

        JObject
            toMerge = JObject.Parse(Serialize(value)),
            content = JObject.Parse(file);

        toMerge.Merge(content, new());

        if (isDiscarding)
            toMerge.Lint(content);

        that.Write(toMerge.ToString());

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
    [NotNull]
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
            AssemblyLog(@$"The original file has a redundant key ""{kvp.Key}"" which will be automatically removed.");
        }
    }

    [NotNull]
    static T Deserialized<T>([NotNull] Config<T> these)
        where T : new()
    {
        these.HasRead = false;

        if (!File.Exists(these.FilePath))
        {
            AssemblyLog(@$"File ""{these.FilePath}"" doesn't exist, writing default new instance.");
            File.WriteAllText(these.FilePath, Serialize(new T()));

            return new();
        }

        var deserialized =
            JsonConvert.DeserializeObject<T>(File.ReadAllText(these.FilePath), new JsonSerializerSettings()) ?? new();

        these.HasRead = true;

        var message = typeof(T).GetMethod(nameof(ToString), Type.EmptyTypes)?.DeclaringType == typeof(T)
            ? deserialized.ToString()
            : Serialize(deserialized);

        AssemblyLog($"Read was successful: {message}");

        return deserialized;
    }
}
