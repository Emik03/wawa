#region Emik.MPL

// <copyright file="Sound.EffectTypes.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

namespace Wawa.Modules;

/// <inheritdoc cref="Sound"/>
public sealed partial class Sound
{
    /// <summary>Gets all vanilla sounds from the base game.</summary>
    [NotNull]
    public static ReadOnlyCollection<Sound> Vanillas { [Pure] get; } = new(
        new[]
        {
            AlarmClockBeep,
            AlarmClockSnooze,
            BigButtonPress,
            BigButtonRelease,
            CapacitorPop,
            CorrectChime,
            DossierOptionPressed,
            EmergencyAlarm,
            FastestTimerBeep,
            FastTimerBeep,
            FreeplayDeviceDrop,
            GameOverFanfare,
            LightBuzz,
            LightBuzzShort,
            MenuButtonPressed,
            MenuDrop,
            NeedyActivated,
            NeedyWarning,
            NormalTimerBeep,
            PageTurn,
            SelectionTick,
            Stamp,
            Strike,
            Switch,
            TitleMenuPressed,
            TypewriterKey,
            WireSequenceMechanism,
            WireSnip,
        }
    );

    /// <summary>Gets the sound that plays when the alarm clock goes off. This sound loops.</summary>
    [NotNull]
    public static Sound AlarmClockBeep
    {
        [Pure] get => new(SoundEffect.AlarmClockBeep);
    }

    /// <summary>Gets the sound that plays when you hit snooze button on the alarm clock.</summary>
    [NotNull]
    public static Sound AlarmClockSnooze
    {
        [Pure] get => new(SoundEffect.AlarmClockSnooze);
    }

    /// <summary>Gets the sound that plays when pressing down the button on the Big Button vanilla module.</summary>
    [NotNull]
    public static Sound BigButtonPress
    {
        [Pure] get => new(SoundEffect.BigButtonPress);
    }

    /// <summary>Gets the sound that plays when releasing the button on the Big Button vanilla module.</summary>
    [NotNull]
    public static Sound BigButtonRelease
    {
        [Pure] get => new(SoundEffect.BigButtonRelease);
    }

    /// <summary>Gets the sound that plays as the mission binder hits the desk.</summary>
    [NotNull]
    public static Sound BinderDrop
    {
        [Pure] get => new(SoundEffect.BinderDrop);
    }

    /// <summary>
    /// Gets the sound that plays immediately after a bomb is defused
    /// and before <see cref="SoundEffect.GameOverFanfare"/>.
    /// </summary>
    [NotNull]
    public static Sound BombDefused
    {
        [Pure] get => new(SoundEffect.BombDefused);
    }

    /// <summary>Gets the sound that plays when the bomb is set down on the desk.</summary>
    [NotNull]
    public static Sound BombDrop
    {
        [Pure] get => new(SoundEffect.BombDrop);
    }

    /// <summary>Gets the sound that plays when the bomb explodes.</summary>
    [NotNull]
    public static Sound BombExplode
    {
        [Pure] get => new(SoundEffect.BombExplode);
    }

    /// <summary>Gets the sound that plays when the freeplay briefcase is closed.</summary>
    [NotNull]
    public static Sound BriefcaseClose
    {
        [Pure] get => new(SoundEffect.BriefcaseClose);
    }

    /// <summary>Gets the sound that plays when the freeplay briefcase is opened.</summary>
    [NotNull]
    public static Sound BriefcaseOpen
    {
        [Pure] get => new(SoundEffect.BriefcaseOpen);
    }

    /// <summary>Gets the sound that plays when pressing down a button.</summary>
    [NotNull]
    public static Sound ButtonPress
    {
        [Pure] get => new(SoundEffect.ButtonPress);
    }

    /// <summary>Gets the sound that plays when releasing a button.</summary>
    [NotNull]
    public static Sound ButtonRelease
    {
        [Pure] get => new(SoundEffect.ButtonRelease);
    }

    /// <summary>Gets the sound that plays when Capacitor Discharge fills up completely.</summary>
    [NotNull]
    public static Sound CapacitorPop
    {
        [Pure] get => new(SoundEffect.CapacitorPop);
    }

    /// <summary>Gets the sound that plays in the tutorial for completing a step correctly.</summary>
    [NotNull]
    public static Sound CorrectChime
    {
        [Pure] get => new(SoundEffect.CorrectChime);
    }

    /// <summary>Gets the sound that plays when you change a setting in the menu folder.</summary>
    [NotNull]
    public static Sound DossierOptionPressed
    {
        [Pure] get => new(SoundEffect.DossierOptionPressed);
    }

    /// <summary>
    /// Gets the sound that plays when there is less than a minute left on the bomb, this sound loops.
    /// </summary>
    [NotNull]
    public static Sound EmergencyAlarm
    {
        [Pure] get => new(SoundEffect.EmergencyAlarm);
    }

    /// <summary>Gets the sound that plays when the bomb has at least 2 or more strikes.</summary>
    [NotNull]
    public static Sound FastestTimerBeep
    {
        [Pure] get => new(SoundEffect.FastestTimerBeep);
    }

    /// <summary>Gets the sound that plays when the bomb has 1 strike.</summary>
    [NotNull]
    public static Sound FastTimerBeep
    {
        [Pure] get => new(SoundEffect.FastTimerBeep);
    }

    /// <summary>Gets the sound that plays as the freeplay briefcase hits the desk.</summary>
    [NotNull]
    public static Sound FreeplayDeviceDrop
    {
        [Pure] get => new(SoundEffect.FreeplayDeviceDrop);
    }

    /// <summary>Gets the sound that plays when all bombs are defused. Finishes before the post game screen.</summary>
    [NotNull]
    public static Sound GameOverFanfare
    {
        [Pure] get => new(SoundEffect.GameOverFanfare);
    }

    /// <summary>Gets the sound that plays when the lights go out.</summary>
    [NotNull]
    public static Sound LightBuzz
    {
        [Pure] get => new(SoundEffect.LightBuzz);
    }

    /// <summary>Gets the sound that plays when the lights start to come back on.</summary>
    [NotNull]
    public static Sound LightBuzzShort
    {
        [Pure] get => new(SoundEffect.LightBuzzShort);
    }

    /// <summary>Gets the sound that plays when you start a mission from the mission binder.</summary>
    [NotNull]
    public static Sound MenuButtonPressed
    {
        [Pure] get => new(SoundEffect.MenuButtonPressed);
    }

    /// <summary>Gets the sound that plays as the mission folder hits the desk.</summary>
    [NotNull]
    public static Sound MenuDrop
    {
        [Pure] get => new(SoundEffect.MenuDrop);
    }

    /// <summary>Gets the sound that plays when a needy gets activated.</summary>
    [NotNull]
    public static Sound NeedyActivated
    {
        [Pure] get => new(SoundEffect.NeedyActivated);
    }

    /// <summary>Gets the sound that plays when a needy is running out of time. This sound loops.</summary>
    [NotNull]
    public static Sound NeedyWarning
    {
        [Pure] get => new(SoundEffect.NeedyWarning);
    }

    /// <summary>Gets the sound that plays when the bomb has no strikes.</summary>
    [NotNull]
    public static Sound NormalTimerBeep
    {
        [Pure] get => new(SoundEffect.NormalTimerBeep);
    }

    /// <summary>Gets the sound that plays when a page is turned in the Missions binder.</summary>
    [NotNull]
    public static Sound PageTurn
    {
        [Pure] get => new(SoundEffect.PageTurn);
    }

    /// <summary>Gets the sound that plays as you hover over something interactable.</summary>
    [NotNull]
    public static Sound SelectionTick
    {
        [Pure] get => new(SoundEffect.SelectionTick);
    }

    /// <summary>
    /// Gets the sound that plays during the post game screen, when either the defused
    /// or exploded text is stamped onto the binder.
    /// </summary>
    [NotNull]
    public static Sound Stamp
    {
        [Pure] get => new(SoundEffect.Stamp);
    }

    /// <summary>Gets the sound that plays when you get a strike.</summary>
    [NotNull]
    public static Sound Strike
    {
        [Pure] get => new(SoundEffect.Strike);
    }

    /// <summary>Gets the sound that plays when a switch is toggled.</summary>
    [NotNull]
    public static Sound Switch
    {
        [Pure] get => new(SoundEffect.Switch);
    }

    /// <summary>Gets the sound that plays when pressing a button in one of the tutorials.</summary>
    [NotNull]
    public static Sound TitleMenuPressed
    {
        [Pure] get => new(SoundEffect.TitleMenuPressed);
    }

    /// <summary>
    /// Gets the sound that plays during the post game screen as the mission information gets typed out.
    /// </summary>
    [NotNull]
    public static Sound TypewriterKey
    {
        [Pure] get => new(SoundEffect.TypewriterKey);
    }

    /// <summary>Gets the sound that plays when switching between sets of wires in Wire Sequence.</summary>
    [NotNull]
    public static Sound WireSequenceMechanism
    {
        [Pure] get => new(SoundEffect.WireSequenceMechanism);
    }

    /// <summary>Gets the sound that plays when a wire is cut on a module like Complicated Wires.</summary>
    [NotNull]
    public static Sound WireSnip
    {
        [Pure] get => new(SoundEffect.WireSnip);
    }
}
