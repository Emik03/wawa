// SPDX-License-Identifier: MPL-2.0
namespace Wawa.TwitchPlays.Domains;

/// <summary>Interface for Twitch Plays support.</summary>
[PublicAPI]
public interface ITwitchSupportable
{
    /// <summary>
    /// This method gets grabbed by Twitch Plays which is used whenever a thrown <see cref="Exception"/>
    /// is unhandled, a votesolve/solvebomb is performed, or when an admin forces this module to be solved.
    /// </summary>
    /// <returns>A series of instructions for the Twitch Plays mod to handle in order to guarantee a solve.</returns>
    [NotNull, Pure]
    IEnumerator TwitchHandleForcedSolve();

    /// <summary>This method gets grabbed by Twitch Plays to process a user command.</summary>
    /// <param name="command">The command of the user.</param>
    /// <returns>A list of instructions for Twitch Plays.</returns>
    [NotNull, Pure]
    IEnumerator ProcessTwitchCommand([CanBeNull] string command);
}
