// SPDX-License-Identifier: MPL-2.0
namespace wawa.DDL;

extern alias core;
using static Math;

/// <summary>Exposes strike-related methods that <see cref="KMBomb"/> instances can act on.</summary>
[PublicAPI]
public static class KMBombStrikeExtensions
{
    /// <summary>Gets the number of strikes.</summary>
    /// <remarks><para>In the editor, this value always returns <c>0</c>.</para></remarks>
    /// <param name="that">The <see cref="KMBomb"/> module instance to grab strikes from.</param>
    /// <returns>The number of strikes.</returns>
    [CLSCompliant(false), MustUseReturnValue, NonNegativeValue, PublicAPI]
    public static int GetStrikes([NotNull] this KMBomb that) =>
        FromGame(that, static x => x.GetComponent<Bomb>().NumStrikes);

    /// <summary>Gets the number of max strikes.</summary>
    /// <remarks><para>In the editor, this value always returns <c>0</c>.</para></remarks>
    /// <param name="that">The <see cref="KMBomb"/> module instance to grab max strikes from.</param>
    /// <returns>The number of max strikes.</returns>
    [CLSCompliant(false), MustUseReturnValue, NonNegativeValue, PublicAPI]
    public static int GetMaxStrikes([NotNull] this KMBomb that) =>
        FromGame(that, static x => x.GetComponent<Bomb>().NumStrikesToLose);

    /// <summary>Gets the rate in which the timer ticks.</summary>
    /// <remarks><para>In the editor, this value always returns <c>1</c>.</para></remarks>
    /// <param name="that">The <see cref="KMBomb"/> module instance to grab the rate from.</param>
    /// <param name="signFlip">
    /// When <see langword="true"/>, invert the returned value when
    /// the component from <paramref name="that"/> ticks backwards.
    /// </param>
    /// <returns>The speed of the ticking.</returns>
    [CLSCompliant(false), MustUseReturnValue, PublicAPI]
    public static float GetRate([NotNull] this KMBomb that, bool signFlip = false) =>
        FromGame(
            new KeyValuePair<KMBomb, bool>(that, signFlip),
            static x =>
            {
                var rate = x.Key.GetComponent<Bomb>().GetTimer().GetRate();
                return rate < 0 && x.Value ? -rate : rate;
            },
            1
        );

    /// <summary>Detonates the bomb.</summary>
    /// <remarks><para>In the editor, this method does nothing.</para></remarks>
    /// <param name="that">The <see cref="KMBomb"/> module instance to detonate.</param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [CLSCompliant(false), NonNegativeValue, NotNull, PublicAPI]
    public static KMBomb Detonate([NotNull] this KMBomb that) =>
        FromGame(
            that,
            static x =>
            {
                x.GetComponent<Bomb>().Detonate();
                return x;
            },
            that // ReSharper disable NullableWarningSuppressionIsUsed
        )!;

    /// <summary>Sets the rate in which the timer ticks.</summary>
    /// <remarks><para>In the editor, this method does nothing.</para></remarks>
    /// <param name="that">The <see cref="KMBomb"/> module instance to grab the rate from.</param>
    /// <param name="value">The value to set it to.</param>
    /// <param name="signFlip">
    /// When <see langword="true"/>, invert <paramref name="value"/> when
    /// the component from <paramref name="that"/> ticks backwards.
    /// </param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [CLSCompliant(false), NotNull, PublicAPI]
    public static KMBomb SetRate([NotNull] this KMBomb that, float value, bool signFlip = false) =>
        FromGame(
            new KeyValuePair<KMBomb, KeyValuePair<float, bool>>(that, new(value, signFlip)),
            static x =>
            {
                var timer = x.Key.GetComponent<Bomb>().GetTimer();
                timer.SetRateModifier(x.Value.Value && timer.GetRate() < 0 ? -x.Value.Key : x.Value.Key);
                return x.Key;
            },
            that
        )!;

    /// <summary>Sets the number of strikes.</summary>
    /// <remarks><para>In the editor, this method does nothing.</para></remarks>
    /// <param name="that">The <see cref="KMBomb"/> module instance to grab strikes from.</param>
    /// <param name="value">The value to set it to.</param>
    /// <param name="tryDetonate">When <see langword="true"/>, check for whether detonation should occur.</param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [CLSCompliant(false), NonNegativeValue, NotNull, PublicAPI]
    public static KMBomb SetStrikes([NotNull] this KMBomb that, int value, bool tryDetonate = false) =>
        FromGame(
            new KeyValuePair<KMBomb, KeyValuePair<int, bool>>(that, new(value, tryDetonate)),
            static x =>
            {
                var inner = x.Key.GetComponent<Bomb>();

                if (x.Value.Value && inner.NumStrikesToLose <= x.Value.Key)
                {
                    x.Key.GetComponent<Bomb>().Detonate();
                    return x.Key;
                }

                inner.StrikeIndicator.StrikeCount = inner.NumStrikes = x.Value.Key;

                // Reimplementation for tick rate found in [Assembly-CSharp]Bomb.OnStrike(MonoBehaviour)
                // The sign is set to match the current rate.
                var sign = Sign(inner.GetTimer().GetRate());

                // Maps 0..4 to 1..2, rounded to the nearest quarter.
                var clip = Mathf.Clamp(inner.NumStrikes / 4, 0, 1) + 1;

                x.Key.SetRate(clip * sign);
                return x.Key;
            },
            that
        )!;

    /// <summary>Sets the number of max strikes.</summary>
    /// <remarks><para>In the editor, this method does nothing.</para></remarks>
    /// <param name="that">The <see cref="KMBomb"/> module instance to grab max strikes from.</param>
    /// <param name="value">The value to set it to.</param>
    /// <param name="tryDetonate">When <see langword="true"/>, check for whether detonation should occur.</param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [CLSCompliant(false), NonNegativeValue, NotNull, PublicAPI]
    public static KMBomb SetMaxStrikes([NotNull] this KMBomb that, int value, bool tryDetonate = false) =>
        FromGame(
            new KeyValuePair<KMBomb, KeyValuePair<int, bool>>(that, new(value, tryDetonate)),
            static x =>
            {
                var inner = x.Key.GetComponent<Bomb>();

                if (x.Value.Value && inner.NumStrikesToLose <= x.Value.Key)
                {
                    x.Key.GetComponent<Bomb>().Detonate();
                    return x.Key;
                }

                inner.NumStrikesToLose = x.Value.Key;
                return x.Key;
            },
            that
        )!;
}
