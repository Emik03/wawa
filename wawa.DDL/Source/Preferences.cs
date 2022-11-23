// <copyright file="Preferences.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Wawa.DDL;

/// <summary>Allows access into current user preferences.</summary>
[PublicAPI]
public static class Preferences
{
    /// <summary>The maximum volume allowed by the game and default value for the respective properties.</summary>
    [PublicAPI]
    public const int MaxVolume = 100;

    /// <summary>Gets a value indicating whether the game is being played on VR.</summary>
    /// <remarks><para>In the editor, this value always returns <see langword="false"/>.</para></remarks>
    [PublicAPI]
    public static bool IsVR
    {
        [Pure] get => FromGame(0, static _ => KTInputManager.Instance.CurrentControlType is ControlType.Motion);
    }

    /// <summary>Gets or sets the current music volume from the dossier menu. Ranges 0 to 100.</summary>
    /// <remarks><para>In the editor, this returns <see cref="MaxVolume"/>.</para></remarks>
    [PublicAPI]
    public static int Music
    {
        [Pure] get => FromGame(0, static _ => PlayerSettingsManager.Instance.PlayerSettings.MusicVolume, MaxVolume);
        set => FromGame(value, static v => PlayerSettingsManager.Instance.PlayerSettings.MusicVolume = v);
    }

    /// <summary>Gets or sets the current sound effect volume from the dossier menu. Ranges 0 to 100.</summary>
    /// <remarks><para>In the editor, this returns <see cref="MaxVolume"/>.</para></remarks>
    [PublicAPI]
    public static int Sound
    {
        [Pure] get => FromGame(0, static _ => PlayerSettingsManager.Instance.PlayerSettings.SFXVolume, MaxVolume);
        set => FromGame(value, static v => PlayerSettingsManager.Instance.PlayerSettings.SFXVolume = v);
    }
}
