// SPDX-License-Identifier: MPL-2.0
namespace wawa.Recall;

/// <summary>The different kinds of status lights.</summary>
/// <remarks><para>The game uses separate game objects for each status light kind.</para></remarks>
[Flags, PublicAPI]
public enum StatusLights
{
    /// <summary>No status light.</summary>
    [PublicAPI]
    None,

    /// <summary>The status light that is off.</summary>
    [PublicAPI]
    Off,

    /// <summary>The status light that is green, representing a solve.</summary>
    [PublicAPI]
    Solve,

    /// <summary>The status light that is red, representing a strike.</summary>
    [PublicAPI]
    Strike = 1 << 2,
}
