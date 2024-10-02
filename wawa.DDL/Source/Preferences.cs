// SPDX-License-Identifier: MPL-2.0
namespace wawa.DDL;

/// <summary>Allows access into current user preferences.</summary>
[PublicAPI]
public static class Preferences
{
    /// <summary>The maximum volume allowed by the game and default value for the respective properties.</summary>
    [PublicAPI]
    public const byte MaxVolume = 100;

    /// <summary>Gets a value indicating whether the game is being played on VR.</summary>
    /// <remarks><para>In the editor, this value always returns <see langword="false"/>.</para></remarks>
    [PublicAPI]
    public static bool IsVR
    {
        [Pure]
        get => FromGame(static _ => KTInputManager.Instance.CurrentControlType is ControlType.Motion);
    }

    /// <summary>Gets or sets the current music volume from the dossier menu. Ranges 0 to 100.</summary>
    /// <remarks><para>In the editor, this returns <see cref="MaxVolume"/>.</para></remarks>
    [PublicAPI, ValueRange(0, MaxVolume)]
    public static byte Music
    {
        [Pure]
        get => FromGame(static _ => (byte)PlayerSettingsManager.Instance.PlayerSettings.MusicVolume, MaxVolume);
        set => FromGame(value, static v => PlayerSettingsManager.Instance.PlayerSettings.MusicVolume = v);
    }

    /// <summary>Gets or sets the current sound effect volume from the dossier menu. Ranges 0 to 100.</summary>
    /// <remarks><para>In the editor, this returns <see cref="MaxVolume"/>.</para></remarks>
    [PublicAPI, ValueRange(0, MaxVolume)]
    public static byte Sound
    {
        [Pure]
        get => FromGame(static _ => (byte)PlayerSettingsManager.Instance.PlayerSettings.SFXVolume, MaxVolume);
        set => FromGame(value, static v => PlayerSettingsManager.Instance.PlayerSettings.SFXVolume = v);
    }
}
