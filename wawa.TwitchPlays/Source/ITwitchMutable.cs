#region Emik.MPL

// <copyright file="ITwitchMutable.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

namespace Wawa.TwitchPlays;

/// <summary>Interface to access internal editing of boolean values.</summary>
interface ITwitchMutable : ITwitchDeclarable
{
    /// <summary>Sets the inner field of <see cref="ITwitchDeclarable.IsCancelCommand"/>.</summary>
    /// <remarks><para>Intended for use in <see cref="TwitchEditor"/>.</para></remarks>
    /// <param name="value">The value to set the field.</param>
    void SetIsCancelCommand(in bool value);

    /// <summary>Sets the inner field of <see cref="ITwitchDeclarable.IsTime"/>.</summary>
    /// <remarks><para>Intended for use in <see cref="TwitchEditor"/>.</para></remarks>
    /// <param name="value">The value to set the field.</param>
    void SetIsTime(in bool value);

    /// <summary>Sets the inner field of <see cref="ITwitchDeclarable.IsTimeSkippable"/>.</summary>
    /// <remarks><para>Intended for use in <see cref="TwitchEditor"/>.</para></remarks>
    /// <param name="value">The value to set the field.</param>
    void SetIsTimeSkippable(in bool value);

    /// <summary>Sets the inner field of <see cref="ISolvable.IsTP"/>.</summary>
    /// <remarks><para>Intended for use in <see cref="TwitchEditor"/>.</para></remarks>
    /// <param name="value">The value to set the field.</param>
    // ReSharper disable once InconsistentNaming
    void SetIsTP(in bool value);

    /// <summary>Sets the inner field of <see cref="ITwitchDeclarable.IsZen"/>.</summary>
    /// <remarks><para>Intended for use in <see cref="TwitchEditor"/>.</para></remarks>
    /// <param name="value">The value to set the field.</param>
    void SetIsZen(in bool value);
}
