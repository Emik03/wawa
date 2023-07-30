// SPDX-License-Identifier: MPL-2.0
namespace Wawa.DDL;

using static Math;

/// <summary>Allows a <see cref="KMBomb"/> to control strikes.</summary>
[PublicAPI]
public static class KMBombStrikeExtensions
{
    // ReSharper disable NullableWarningSuppressionIsUsed Unity.PerformanceCriticalCodeInvocation

    /// <summary>Gets the number of strikes.</summary>
    /// <remarks><para>In the editor, this value always returns 0.</para></remarks>
    /// <param name="that">The <see cref="KMBomb"/> module instance to grab strikes from.</param>
    /// <returns>The number of strikes.</returns>
    [CLSCompliant(false), NonNegativeValue, PublicAPI]
    public static int GetStrikes([NotNull] this KMBomb that) =>
        FromGame(that, static x => x.GetComponent<Bomb>().NumStrikes);

    /// <summary>Gets the rate in which the timer ticks.</summary>
    /// <remarks><para>In the editor, this value always returns 1.</para></remarks>
    /// <param name="that">The <see cref="KMBomb"/> module instance to grab the rate from.</param>
    /// <param name="signFlip">
    /// When true, invert the returned value when the component from <paramref name="that"/> ticks backwards.
    /// </param>
    /// <returns>The speed of the ticking.</returns>
    [CLSCompliant(false), PublicAPI]
    public static float GetRate([NotNull] this KMBomb that, bool signFlip = false) =>
        FromGame(new Dangerous(that, 0, signFlip), static x => x.GetRate(), 1);

    /// <summary>Sets the rate in which the timer ticks.</summary>
    /// <remarks><para>In the editor, this method does nothing.</para></remarks>
    /// <param name="that">The <see cref="KMBomb"/> module instance to grab the rate from.</param>
    /// <param name="value">The value to set it to.</param>
    /// <param name="signFlip">
    /// When true, invert <paramref name="value"/> when the component from <paramref name="that"/> ticks backwards.
    /// </param>
    /// <returns>The parameter <see cref="KMBomb"/>.</returns>
    [CLSCompliant(false), NotNull, PublicAPI]
    public static KMBomb SetRate([NotNull] this KMBomb that, float value, bool signFlip = false) =>
        FromGame(new Dangerous(that, value, signFlip), static x => x.SetRate(), that)!;

    /// <summary>Sets the number of strikes.</summary>
    /// <remarks><para>In the editor, this method does nothing.</para></remarks>
    /// <param name="that">The <see cref="KMBomb"/> module instance to grab strikes from.</param>
    /// <param name="value">The value to set it to.</param>
    /// <returns>The parameter <see cref="KMBomb"/>.</returns>
    [CLSCompliant(false), NonNegativeValue, NotNull, PublicAPI]
    public static KMBomb SetStrikes([NotNull] this KMBomb that, int value) =>
        FromGame(new Dangerous(that, value), static x => x.SetStrikes(), that)!;

    [StructLayout(LayoutKind.Auto)]
    readonly struct Dangerous([NotNull] KMBomb bomb, int value, bool signFlip = false)
    {
        internal unsafe Dangerous(KMBomb bomb, float value, bool signFlip)
            : this(bomb, *(int*)&value, signFlip) { }

        internal float GetRate()
        {
            var rate = bomb.GetComponent<Bomb>().GetTimer().GetRate();
            return rate < 0 && signFlip ? -rate : rate;
        }

        internal KMBomb SetStrikes()
        {
            var inner = bomb.GetComponent<Bomb>();
            inner.StrikeIndicator.StrikeCount = inner.NumStrikes = value;

            // Reimplementation for tick rate found in [Assembly-CSharp]Bomb.OnStrike(MonoBehaviour)
            // The sign is set to match the current rate.
            var sign = Sign(inner.GetTimer().GetRate());

            // Maps 0..4 to 1..2, rounded to the nearest quarter.
            var clip = Mathf.Clamp(inner.NumStrikes / 4, 0, 1) + 1;

            bomb.SetRate(clip * sign);
            return bomb;
        }

        internal unsafe KMBomb SetRate()
        {
            bomb.GetComponent<Bomb>().GetTimer().SetRateModifier(*(float*)&value);
            return bomb;
        }
    }
}
