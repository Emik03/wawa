#region Emik.MPL

// <copyright file="Sound.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

namespace Wawa.Modules;

/// <summary>
/// Encapsulates a modded or vanilla sound effect, with methods to play the sound, and allowing you to extend
/// into the <see cref="KMAudio.KMAudioRef"/> instance that spawns from playing a sound effect.
/// </summary>
[CLSCompliant(false), PublicAPI]
public sealed partial class Sound : ICloneable, IEquatable<Sound>, IEqualityComparer<Sound>
{
    /// <summary>Initializes a new instance of the <see cref="Sound"/> class.</summary>
    /// <param name="sound">The name of the modded sound to use.</param>
    [PublicAPI]
    public Sound([NotNull] string sound) => Modded = sound;

    /// <summary>
    /// Initializes a new instance of the <see cref="Sound"/> class. Uses the name of the <see cref="AudioClip"/>.
    /// </summary>
    /// <param name="sound">The <see cref="Object"/> of the modded sound to use, getting its name.</param>
    [PublicAPI]
    public Sound([NotNull] Object sound)
        : this(sound.name) { }

    /// <summary>Initializes a new instance of the <see cref="Sound"/> class.</summary>
    /// <param name="sound">The vanilla sound to use.</param>
    [PublicAPI]
    public Sound(SoundEffect sound) => Vanilla = sound;

    /// <summary>
    /// Gets the modded sound passed in as <see cref="Maybe{T}"/> due to ambiguity in this value being set.
    /// </summary>
    [PublicAPI]
    public Maybe<string> Modded { [Pure] get; }

    /// <summary>
    /// Gets the vanilla sound passed in as <see cref="Maybe{T}"/> due to ambiguity in this value being set.
    /// </summary>
    [PublicAPI]
    public Maybe<SoundEffect> Vanilla { [Pure] get; }

    /// <summary>Gets the instance of the <see cref="KMAudio.KMAudioRef"/> created from playing a sound.</summary>
    [PublicAPI]
    public Maybe<KMAudioRef> Reference { [Pure] get; internal set; }

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public object Clone() => Vanilla.IsSome ? new Sound(Vanilla.Value) : new(Modded.Unwrap());

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public bool Equals(Sound x, Sound y) => x == y;

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public int GetHashCode([AllowNull, CanBeNull] Sound obj) => obj?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public bool Equals(Sound other) => this == other;

    /// <summary>Implicitly calls the constructor.</summary>
    /// <param name="sound">The <see cref="string"/> to pass in to the constructor.</param>
    [NotNull, PublicAPI, Pure]
    public static implicit operator Sound([NotNull] string sound) => new(sound);

    /// <summary>Explicitly calls the constructor.</summary>
    /// <param name="sound">The <see cref="Object"/> to pass in to the constructor.</param>
    [NotNull, PublicAPI, Pure]
    public static explicit operator Sound([NotNull] Object sound) => new(sound);

    /// <summary>Implicitly calls the constructor.</summary>
    /// <param name="sound">The <see cref="SoundEffect"/> to pass in to the constructor.</param>
    [NotNull, PublicAPI, Pure]
    public static implicit operator Sound(SoundEffect sound) => new(sound);

    /// <summary>Determines whether both instances contain the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if both instances contain the same values, otherwise <see langword="false"/>.
    /// </returns>
    [PublicAPI, Pure]
    public static bool operator ==([AllowNull, CanBeNull] Sound left, [AllowNull, CanBeNull] Sound right) =>
        left is null
            ? right is null
            : right is not null &&
            left.Modded == right.Modded &&
            left.Vanilla == right.Vanilla;

    /// <summary>Determines whether both instances do not contain the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>
    /// The value <see langword="true"/> if both instances do not contain the same values,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [PublicAPI, Pure]
    public static bool operator !=([AllowNull, CanBeNull] Sound left, [AllowNull, CanBeNull] Sound right) =>
        !(left == right);

    /// <summary>Converts the <see cref="string"/> to a <see langword="new"/> <see cref="Sound"/>.</summary>
    /// <param name="sound">The <see cref="string"/> instance to convert.</param>
    /// <returns>A <see langword="new"/> <see cref="Sound"/> instance encapsulating <paramref name="sound"/>.</returns>
    [NotNull, PublicAPI, Pure]
    public static Sound FromString([NotNull] string sound) => new(sound);

    /// <summary>Converts the <see cref="Object"/> to a <see langword="new"/> <see cref="Sound"/>.</summary>
    /// <param name="sound">The <see cref="Object"/> instance to convert.</param>
    /// <returns>A <see langword="new"/> <see cref="Sound"/> instance encapsulating <paramref name="sound"/>.</returns>
    [NotNull, PublicAPI, Pure]
    public static Sound FromObject([NotNull] Object sound) => new(sound);

    /// <summary>Converts the <see cref="SoundEffect"/> to a <see langword="new"/> <see cref="Sound"/>.</summary>
    /// <param name="sound">The <see cref="SoundEffect"/> instance to convert.</param>
    /// <returns>A <see langword="new"/> <see cref="Sound"/> instance encapsulating <paramref name="sound"/>.</returns>
    [NotNull, PublicAPI, Pure]
    public static Sound FromSoundEffect(SoundEffect sound) => new(sound);

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public override bool Equals(object obj) => Equals(obj as Sound);

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public override int GetHashCode()
    {
        var hashCode = -200150852;

        hashCode = hashCode * -1521134295 + Modded.GetHashCode();
        hashCode = hashCode * -1521134295 + Vanilla.GetHashCode();

        return hashCode;
    }

    /// <inheritdoc/>
    [PublicAPI, Pure]
    public override string ToString() =>
        $"{(Vanilla.IsSome ? nameof(Vanilla) : nameof(Modded))} ({(Vanilla.IsSome ? Vanilla.Value : Modded.Unwrap())})";
}
