// <copyright file="KMBombStrikeExtensions.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Wawa.DDL;

using static Math;

/// <summary>Allows a <see cref="KMBomb"/> to control strikes.</summary>
[PublicAPI]
public static class KMBombStrikeExtensions
{
    // ReSharper disable Unity.PerformanceCriticalCodeInvocation

    /// <summary>Gets the number of strikes.</summary>
    /// <remarks><para>In the editor, this value always returns 0.</para></remarks>
    /// <param name="that">The <see cref="KMBomb"/> module instance to grab strikes from.</param>
    /// <returns>The number of strikes.</returns>
    [CLSCompliant(false), PublicAPI]
    public static int GetStrikes([NotNull] this KMBomb that) =>
        FromGame(that, static v => v.GetComponent<Bomb>().NumStrikes);

    /// <summary>Gets the rate in which the timer ticks.</summary>
    /// <remarks><para>In the editor, this value always returns 1.</para></remarks>
    /// <param name="that">The <see cref="KMBomb"/> module instance to grab the rate from.</param>
    /// <returns>The speed of the ticking.</returns>
    [CLSCompliant(false), PublicAPI]
    public static float GetRate([NotNull] this KMBomb that) =>
        FromGame(that, static x => x.GetComponent<Bomb>().GetTimer().GetRate(), 1);

    /// <summary>Sets the rate in which the timer ticks.</summary>
    /// <remarks><para>In the editor, this method does nothing.</para></remarks>
    /// <param name="that">The <see cref="KMBomb"/> module instance to grab the rate from.</param>
    /// <param name="value">The value to set it to.</param>
    /// <returns>The parameter <see cref="KMBomb"/>.</returns>
    [CLSCompliant(false), NotNull, PublicAPI]
    public static KMBomb SetRate([NotNull] this KMBomb that, float value)
    {
        static byte Hidden(Mutation<float> x)
        {
            var (that, value) = x;
            that.GetComponent<Bomb>().GetTimer().SetRateModifier(value);
            return 0;
        }

        FromGame(new Mutation<float>(that, value), static x => Hidden(x));
        return that;
    }

    /// <summary>Sets the number of strikes.</summary>
    /// <remarks><para>In the editor, this method does nothing.</para></remarks>
    /// <param name="that">The <see cref="KMBomb"/> module instance to grab strikes from.</param>
    /// <param name="value">The value to set it to.</param>
    /// <returns>The parameter <see cref="KMBomb"/>.</returns>
    [CLSCompliant(false), NotNull, PublicAPI]
    public static KMBomb SetStrikes([NotNull] this KMBomb that, int value)
    {
        static byte Hidden(Mutation<int> x)
        {
            var (that, value) = x;
            var inner = that.GetComponent<Bomb>();
            inner.StrikeIndicator.StrikeCount = inner.NumStrikes = value;

            // Reimplementation for tick rate found in [Assembly-CSharp]Bomb.OnStrike(MonoBehavior)
            // The sign is set to match the current rate.
            var sign = Sign(that.GetRate());

            // Maps 0..4 to 1..2, rounded to the nearest quarter.
            var clip = (value / 4f).Clip(0, 1) + 1;

            that.SetRate(clip * sign);
            return 0;
        }

        FromGame(new Mutation<int>(that, value), static x => Hidden(x));
        return that;
    }

    static float Clip(this float value, float min, float max) =>
        value <= min ? min :
        value >= max ? max : value;

    sealed class Mutation<T>
    {
        readonly KMBomb _bomb;

        readonly T _value;

        internal Mutation(KMBomb bomb, T value)
        {
            _bomb = bomb;
            _value = value;
        }

        internal void Deconstruct(out KMBomb bomb, out T value)
        {
            bomb = _bomb;
            value = _value;
        }
    }
}
