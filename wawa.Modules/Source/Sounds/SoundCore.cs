#region Emik.MPL

// <copyright file="SoundCore.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

namespace Wawa.Modules;

/// <summary>Implementations for <see cref="Sound"/>.</summary>
[CLSCompliant(false), PublicAPI]
public static class SoundCore
{
    /// <summary>Plays the current sound that is stored.</summary>
    /// <param name="that">This instance of <see cref="Sound"/>.</param>
    /// <param name="audio">The <see cref="KMAudio"/> to play it from.</param>
    /// <param name="transform">The <see cref="Transform"/>, which is needed for the location of the sound.</param>
    /// <param name="isLooping">Indicates whether the sound should loop.</param>
    /// <returns>
    /// A <see cref="Maybe{T}"/>, consisting of either a <see cref="KMAudio.KMAudioRef"/>,
    /// or <see langword="default"/> if <see cref="KMAudio"/> is unable to play a sound,
    /// usually caused by playing too many sounds at once.
    /// </returns>
    [PublicAPI]
    public static Maybe<KMAudioRef> Play(
        [NotNull] this Sound that,
        [NotNull] KMAudio audio,
        [NotNull] Transform transform,
        bool isLooping = false
    )
    {
        try
        {
            return that.Reference = that.Modded.IsSome
                ? audio.HandlePlaySoundAtTransformWithRef?.Invoke(that.Modded.Value, transform, isLooping)
                : audio.HandlePlayGameSoundAtTransformWithRef?.Invoke(that.Vanilla.Unwrap(), transform);
        }
        catch (NullReferenceException)
        {
            return null;
        }
    }

    /// <summary>Creates an instance of <see cref="Sound"/> where <see cref="Sound.Modded"/> is set.</summary>
    /// <param name="sound">The <see cref="string"/> to pass in <see cref="Sound"/>.</param>
    /// <returns>A new instance of <see cref="Sound"/> which encapsulates <paramref name="sound"/>.</returns>
    [NotNull, PublicAPI, Pure]
    public static Sound AsSound([NotNull] this string sound) => new(sound);

    /// <summary>Creates an instance of <see cref="Sound"/> where <see cref="Sound.Vanilla"/> is set.</summary>
    /// <param name="sound">The <see cref="SoundEffect"/> to pass in <see cref="Sound"/>.</param>
    /// <returns>A new instance of <see cref="Sound"/> which encapsulates <paramref name="sound"/>.</returns>
    [NotNull, PublicAPI, Pure]
    public static Sound AsSound(this SoundEffect sound) => new(sound);

    /// <summary>Gets the <see cref="Sound.Reference"/> and stops the sound if it is playing.</summary>
    /// <param name="that">This instance of <see cref="Sound"/>.</param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [NotNull, PublicAPI]
    public static Sound Stop([NotNull] this Sound that)
    {
        that.Reference.Value?.StopSound();

        return that;
    }

    /// <summary>Creates an instance of <see cref="Sound"/> where <see cref="Sound.Modded"/> is set.</summary>
    /// <param name="sound">The <see cref="AudioClip"/> to pass in <see cref="Sound"/>.</param>
    /// <returns>
    /// A new instance of <see cref="Sound"/> which encapsulates the name of <paramref name="sound"/>.
    /// </returns>
    [NotNull, PublicAPI, Pure]
    public static Sound ToSound([NotNull] this AudioClip sound) => new(sound);

    /// <summary>Creates a <see cref="System.Collections.ObjectModel.ReadOnlyCollection{T}"/> where each element has been converted.</summary>
    /// <param name="sounds">The collection.</param>
    /// <returns>An immutable array.</returns>
    [NotNull, PublicAPI, Pure]
    public static ReadOnlyCollection<Sound> ToSounds([InstantHandle, NotNull] this IEnumerable<string> sounds) =>
        sounds.ToReadOnly(AsSound);

    /// <summary>Creates an <see cref="System.Collections.ObjectModel.ReadOnlyCollection{T}"/> where each element has been converted.</summary>
    /// <param name="sounds">The collection.</param>
    /// <returns>An immutable array.</returns>
    [NotNull, PublicAPI, Pure]
    public static ReadOnlyCollection<Sound> ToSounds([InstantHandle, NotNull] this IEnumerable<SoundEffect> sounds) =>
        sounds.ToReadOnly(AsSound);

    /// <summary>Creates a <see cref="System.Collections.ObjectModel.ReadOnlyCollection{T}"/> where each element has been converted.</summary>
    /// <param name="sounds">The collection.</param>
    /// <returns>An immutable array.</returns>
    [NotNull, PublicAPI, Pure]
    public static ReadOnlyCollection<Sound> ToSounds([InstantHandle, NotNull] this IEnumerable<AudioClip> sounds) =>
        sounds.ToReadOnly(ToSound);

    /// <summary>
    /// Gets the <see cref="Sound.Reference"/> of a collection of sounds and stops the sound if it is playing.
    /// </summary>
    /// <typeparam name="T">The type of iterator.</typeparam>
    /// <param name="sounds">The multiple <see cref="Sound"/> instances to each call <see cref="Stop"/> on.</param>
    /// <returns>The parameter <paramref name="sounds"/>.</returns>
    [NotNull, PublicAPI]
    public static T Stop<T>([InstantHandle, NotNull] this T sounds)
        where T : IEnumerable<Sound>
    {
        foreach (var sound in sounds)
            sound.Stop();

        return sounds;
    }

    /// <summary>Plays the current sound that is stored.</summary>
    /// <param name="that">This instance of <see cref="Sound"/>.</param>
    /// <param name="audio">The <see cref="KMAudio"/> to play it from.</param>
    /// <param name="transform">The <see cref="Transform"/>, which is needed for the location of the sound.</param>
    /// <param name="isLooping">Indicates whether the sound should loop.</param>
    /// <returns>
    /// A <see cref="Maybe{T}"/>, consisting of either a <see cref="KMAudio.KMAudioRef"/>,
    /// or <see langword="default"/> if <see cref="KMAudio"/> is unable to play a sound,
    /// usually caused by playing too many sounds at once.
    /// </returns>
    [LinqTunnel, NotNull, PublicAPI]
    public static IEnumerable<Maybe<KMAudioRef>> Play(
        [NotNull] this IEnumerable<Sound> that,
        [NotNull] KMAudio audio,
        [NotNull] Transform transform,
        bool isLooping = false
    ) =>
        that.Select(s => s.Play(audio, transform, isLooping));
}
