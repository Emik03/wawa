// SPDX-License-Identifier: MPL-2.0
namespace wawa.DDL;

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

    static bool s_lightsOn;

    static Missions() => FromGame(OnLightsChanged, Hook, null, nameof(OnLightsChanged));

    /// <summary>Gets or sets a value indicating whether pacing events are enabled.</summary>
    /// <remarks><para>In the editor, this returns <see keyword="false"/>.</para></remarks>
    [PublicAPI]
    public static bool HasPacingEvents
    {
        [Pure] get => FromGame(static _ => SceneManager.Instance.GameplayState.Mission.PacingEventsEnabled);
        set => FromGame(value, static v => SceneManager.Instance.GameplayState.Mission.PacingEventsEnabled = v);
    }

    /// <summary>Gets or sets a value indicating whether the lights are on.</summary>
    [PublicAPI]
    public static bool LightsOn
    {
        [Pure] get => s_lightsOn;
        set => FromGame(value, FlipTheSwitch);
    }

    /// <summary>Gets the description as it appears in the bomb binder.</summary>
    /// <remarks><para>In the editor, this returns <see cref="ExampleDescription"/>.</para></remarks>
    [PublicAPI]
    public static Maybe<string> Description
    {
        [Pure]
        get =>
            FromGame(
                static _ =>
                    Localization.GetLocalizedString(SceneManager.Instance.GameplayState.Mission.DescriptionTerm),
                ExampleDescription
            );
    }

    /// <summary>Gets the ID of the mission.</summary>
    /// <remarks><para>In the editor, this returns <see cref="ExampleId"/>.</para></remarks>
    [PublicAPI]
    public static Maybe<string> Id
    {
        [Pure] get => FromGame(static _ => SceneManager.Instance.GameplayState.Mission.ID, ExampleId);
    }

    /// <summary>Gets the current language code.</summary>
    /// <remarks><para>In the editor, this returns <see cref="ExampleLanguageCode"/>.</para></remarks>
    [PublicAPI]
    public static Maybe<string> LanguageCode
    {
        [Pure]
        get => FromGame(static _ => PlayerSettingsManager.Instance.PlayerSettings.LanguageCode, ExampleLanguageCode);
    }

    /// <summary>Gets the mission name as it appears in the bomb binder.</summary>
    /// <remarks><para>In the editor, this returns <see cref="ExampleName"/>.</para></remarks>
    [PublicAPI]
    public static Maybe<string> Name
    {
        [Pure]
        get =>
            FromGame(
                static _ => Lookup.Localized(SceneManager.Instance.GameplayState.Mission.DisplayNameTerm),
                ExampleName
            );
    }

    static void OnLightsChanged(bool value) => s_lightsOn = value;

    static bool FlipTheSwitch(bool v)
    {
        if (SceneManager.Instance is var instance && !instance ||
            instance.GameplayState is var gameplayState && !gameplayState ||
            gameplayState.Room is var room && !room ||
            room.CeilingLight is var ceilingLight && !ceilingLight)
            return v;

        if (v)
            ceilingLight.TurnOn(true);
        else
            ceilingLight.TurnOff(false);

        return v;
    }

    [NotNull]
    static Action<bool> Hook(Action<bool> x)
    {
        EnvironmentEvents.OnLightsOn += _ => x(true);
        EnvironmentEvents.OnLightsOff += _ => x(false);
        return x;
    }
}
