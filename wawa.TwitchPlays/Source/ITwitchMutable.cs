// SPDX-License-Identifier: MPL-2.0
namespace Wawa.TwitchPlays;

/// <summary>Interface to access internal editing of boolean values.</summary>
interface ITwitchMutable : ITwitchDeclarable
{
    /// <summary>Sets the inner field of <see cref="ITwitchDeclarable.IsCancelCommand"/>.</summary>
    /// <remarks><para>Intended for use in <see cref="TwitchEditor"/>.</para></remarks>
    /// <param name="value">The value to set the field.</param>
    void SetIsCancelCommand(bool value);

    /// <summary>Sets the inner field of <see cref="ITwitchDeclarable.IsTime"/>.</summary>
    /// <remarks><para>Intended for use in <see cref="TwitchEditor"/>.</para></remarks>
    /// <param name="value">The value to set the field.</param>
    void SetIsTime(bool value);

    /// <summary>Sets the inner field of <see cref="ITwitchDeclarable.IsTimeSkippable"/>.</summary>
    /// <remarks><para>Intended for use in <see cref="TwitchEditor"/>.</para></remarks>
    /// <param name="value">The value to set the field.</param>
    void SetIsTimeSkippable(bool value);

    /// <summary>Sets the inner field of <see cref="ISolvable.IsTP"/>.</summary>
    /// <remarks><para>Intended for use in <see cref="TwitchEditor"/>.</para></remarks>
    /// <param name="value">The value to set the field.</param>
    // ReSharper disable once InconsistentNaming
    void SetIsTP(bool value);

    /// <summary>Sets the inner field of <see cref="ITwitchDeclarable.IsZen"/>.</summary>
    /// <remarks><para>Intended for use in <see cref="TwitchEditor"/>.</para></remarks>
    /// <param name="value">The value to set the field.</param>
    void SetIsZen(bool value);
}
