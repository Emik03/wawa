// SPDX-License-Identifier: MPL-2.0
namespace wawa.Modules;

/// <summary>
/// Interface for Twitch Plays auto-solvers. Used by <see cref="Module"/> to abstractly
/// communicate with Twitch Plays solvers without importing the namespace.
/// </summary>
[PublicAPI]
public interface ISolvable
{
    /// <summary>Gets a value indicating whether Twitch Plays is currently active.</summary>
    /// <remarks><para>
    /// This is for modules that need to display different items, or use different rules if Twitch Plays is active.
    /// </para><para>
    /// These values are set by the Twitch Plays mod using reflection. This field is set in <c>Start()</c>,
    /// therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in
    /// <see cref="KMBombModule.OnActivate"/> or later.
    /// </para></remarks>
    [PublicAPI]
    bool IsTP { [Pure] get; }

    /// <summary>
    /// When the module runs into an exception or the module is forced to be solved, it calls this method.
    /// </summary>
    /// <remarks><para>
    /// Make sure that the module is solved before this method closes, otherwise it causes a forced-solve.
    /// </para></remarks>
    /// <returns>A series of instructions for the Twitch Plays mod to handle in order to guarantee a solve.</returns>
    [NotNull, PublicAPI, Pure]
    IEnumerator ForceTPSolve();
}
