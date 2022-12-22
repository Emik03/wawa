#region Emik.MPL

// <copyright file="Missions.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

namespace Wawa.DDL;

/// <summary>Allows access into current mission metadata.</summary>
[PublicAPI]
#pragma warning disable CA1724
public static class Missions
#pragma warning restore CA1724
{
    /// <summary>The default value for the respective property.</summary>
    [NotNull, PublicAPI]
    public const string
        ExampleDescription = @"Everybody has to start somewhere. Let's just hope it doesn't end here too.
Make sure your experts have the manual and are ready to help.",
        ExampleId = "firsttime",
        ExampleLanguageCode = "en",
        ExampleName = "First Bomb";

    /// <summary>Gets or sets a value indicating whether pacing events are enabled.</summary>
    /// <remarks><para>In the editor, this returns <see keyword="false"/>.</para></remarks>
    [PublicAPI]
    public static bool IsPacingEvents
    {
        [Pure] get => FromGame(0, static _ => SceneManager.Instance.GameplayState.Mission.PacingEventsEnabled);
        set => FromGame(value, static v => SceneManager.Instance.GameplayState.Mission.PacingEventsEnabled = v);
    }

    /// <summary>Gets the description as it appears in the bomb binder.</summary>
    /// <remarks><para>In the editor, this returns <see cref="ExampleDescription"/>.</para></remarks>
    [PublicAPI]
    public static Maybe<string> Description
    {
        [Pure]
        get =>
            FromGame(
                0,
                static _ => Lookup.Localized(SceneManager.Instance.GameplayState.Mission.DescriptionTerm),
                ExampleDescription
            );
    }

    /// <summary>Gets the ID of the mission.</summary>
    /// <remarks><para>In the editor, this returns <see cref="ExampleId"/>.</para></remarks>
    [PublicAPI]
    public static Maybe<string> Id
    {
        [Pure] get => FromGame(0, static _ => SceneManager.Instance.GameplayState.Mission.ID, ExampleId);
    }

    /// <summary>Gets the current language code.</summary>
    /// <remarks><para>In the editor, this returns <see cref="ExampleLanguageCode"/>.</para></remarks>
    [PublicAPI]
    public static Maybe<string> LanguageCode
    {
        [Pure]
        get =>
            FromGame(
                0,
                static _ => PlayerSettingsManager.Instance.PlayerSettings.LanguageCode,
                ExampleLanguageCode
            );
    }

    /// <summary>Gets the mission name as it appears in the bomb binder.</summary>
    /// <remarks><para>In the editor, this returns <see cref="ExampleName"/>.</para></remarks>
    [PublicAPI]
    public static Maybe<string> Name
    {
        [Pure]
        get =>
            FromGame(
                0,
                static _ => Lookup.Localized(SceneManager.Instance.GameplayState.Mission.DisplayNameTerm),
                ExampleName
            );
    }
}
