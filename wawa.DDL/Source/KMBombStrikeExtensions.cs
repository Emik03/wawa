// SPDX-License-Identifier: MPL-2.0
namespace Wawa.DDL;

using static Math;

/// <summary>Exposes strike-related methods that <see cref="KMBomb"/> instances can act on.</summary>
[PublicAPI]
public static class KMBombStrikeExtensions
{
    // ReSharper disable NullableWarningSuppressionIsUsed Unity.PerformanceCriticalCodeInvocation

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
        FromGame(new Dangerous(that, 0, signFlip), static x => x.GetRate(), 1);

    /// <summary>Detonates the bomb.</summary>
    /// <remarks><para>In the editor, this method does nothing.</para></remarks>
    /// <param name="that">The <see cref="KMBomb"/> module instance to detonate.</param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [CLSCompliant(false), NonNegativeValue, NotNull, PublicAPI]
    public static KMBomb Detonate([NotNull] this KMBomb that) =>
        FromGame(new Dangerous(that), static x => x.Detonate(), that)!;

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
        FromGame(new Dangerous(that, value, signFlip), static x => x.SetRate(), that)!;

    /// <summary>Sets the number of strikes.</summary>
    /// <remarks><para>In the editor, this method does nothing.</para></remarks>
    /// <param name="that">The <see cref="KMBomb"/> module instance to grab strikes from.</param>
    /// <param name="value">The value to set it to.</param>
    /// <param name="tryDetonate">When <see langword="true"/>, check for whether detonation should occur.</param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [CLSCompliant(false), NonNegativeValue, NotNull, PublicAPI]
    public static KMBomb SetStrikes([NotNull] this KMBomb that, int value, bool tryDetonate = false) =>
        FromGame(new Dangerous(that, value, tryDetonate), static x => x.SetStrikes(), that)!;

    /// <summary>Sets the number of max strikes.</summary>
    /// <remarks><para>In the editor, this method does nothing.</para></remarks>
    /// <param name="that">The <see cref="KMBomb"/> module instance to grab max strikes from.</param>
    /// <param name="value">The value to set it to.</param>
    /// <param name="tryDetonate">When <see langword="true"/>, check for whether detonation should occur.</param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [CLSCompliant(false), NonNegativeValue, NotNull, PublicAPI]
    public static KMBomb SetMaxStrikes([NotNull] this KMBomb that, int value, bool tryDetonate = false) =>
        FromGame(new Dangerous(that, value, tryDetonate), static x => x.SetMaxStrikes(), that)!;

    [StructLayout(LayoutKind.Auto)]
    readonly struct Dangerous([NotNull] KMBomb bomb, int value = 0, bool alter = false)
    {
        internal Dangerous(KMBomb bomb, float value, bool alter)
            : this(bomb, BitCast(value), alter) { }

        internal float GetRate()
        {
            var rate = bomb.GetComponent<Bomb>().GetTimer().GetRate();
            return rate < 0 && alter ? -rate : rate;
        }

        internal KMBomb Detonate()
        {
            bomb.GetComponent<Bomb>().Detonate();
            return bomb;
        }

        internal KMBomb SetStrikes()
        {
            var inner = bomb.GetComponent<Bomb>();

            if (alter && inner.NumStrikesToLose <= value)
                return Detonate();

            inner.StrikeIndicator.StrikeCount = inner.NumStrikes = value;

            // Reimplementation for tick rate found in [Assembly-CSharp]Bomb.OnStrike(MonoBehaviour)
            // The sign is set to match the current rate.
            var sign = Sign(inner.GetTimer().GetRate());

            // Maps 0..4 to 1..2, rounded to the nearest quarter.
            var clip = Mathf.Clamp(inner.NumStrikes / 4, 0, 1) + 1;

            bomb.SetRate(clip * sign);
            return bomb;
        }

        internal KMBomb SetMaxStrikes()
        {
            var inner = bomb.GetComponent<Bomb>();

            if (alter && inner.NumStrikesToLose <= value)
                return Detonate();

            inner.NumStrikesToLose = value;
            return bomb;
        }

        internal KMBomb SetRate()
        {
            bomb.GetComponent<Bomb>().GetTimer().SetRateModifier(BitCast(value));
            return bomb;
        }

        [Pure]
        static unsafe int BitCast(float value) => *(int*)&value;

        [Pure]
        static unsafe float BitCast(int value) => *(float*)&value;
    }
}
