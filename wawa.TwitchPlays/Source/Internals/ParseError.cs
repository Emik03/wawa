// SPDX-License-Identifier: MPL-2.0
namespace wawa.TwitchPlays.Internals;

/// <summary>Defines parse errors.</summary>
enum ParseError : byte
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
