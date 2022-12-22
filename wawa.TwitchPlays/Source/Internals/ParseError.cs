#region Emik.MPL

// <copyright file="ParseError.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

namespace Wawa.TwitchPlays.Internals;

/// <summary>Defines parse errors.</summary>
enum ParseError
{
    /// <summary>Indicates that the query is empty.</summary>
    Empty,

    /// <summary>Indicates that a field of the same name or alias could not be found.</summary>
    Field,

    /// <summary>Indicates that the <see cref="int.TryParse(string, out int)"/> method returned false.</summary>
    NoMatch,

    /// <summary>Indicates that the type is unserializable.</summary>
    Unserializable,
}
