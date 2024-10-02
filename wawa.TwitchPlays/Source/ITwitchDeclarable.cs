// SPDX-License-Identifier: MPL-2.0
namespace Wawa.TwitchPlays;

/// <summary>Interface for non-generic <see cref="Twitch{TModule}"/>.</summary>
[CLSCompliant(false), PublicAPI]
public interface ITwitchDeclarable : ISolvable, ITwitchSupportable
{
    /// <summary>
    /// Gets or sets a value indicating whether values yielded from a
    /// Twitch Plays <see cref="Coroutine"/> should be logged.
    /// </summary>
    /// <remarks><para>
    /// Particularily useful as a debugging tool, whether it be in the editor or in-game.
    /// </para></remarks>
    [PublicAPI]
    bool IsPrintingYields { [Pure] get; set; }

    /// <summary>
    /// Gets a value indicating whether it should cancel command processing.
    /// </summary>
    /// <remarks>
    /// <para>
    /// If this returns <see langword="true"/>,
    /// then stop processing the command, clean up, then do a <c><see langword="yield"/> <see langword="return"/>
    /// TwitchString.Cancelled;</c> to acknowledge the cancel.
    /// </para><para>
    /// These values are set by the Twitch Plays mod using reflection. This field is set in <c>Start()</c>,
    /// therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in
    /// <see cref="KMBombModule.OnActivate"/> or later.
    /// </para></remarks>
    [PublicAPI]
    bool IsCancelCommand { [Pure] get; }

    /// <summary>Gets a value indicating whether it is in Time Mode, where solves change the timer.</summary>
    /// <remarks><para>This is useful for modules that use the timer's value.
    /// </para><para>
    /// These values are set by the Twitch Plays mod using reflection. This field is set in <c>Start()</c>,
    /// therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in
    /// <see cref="KMBombModule.OnActivate"/> or later.
    /// </para></remarks>
    [PublicAPI]
    bool IsTime { [Pure] get; }

    /// <summary>
    /// Gets a value indicating whether it should allow for the timer to be skipped when the module it is in,
    /// as well as any other modules that would like to skip time, are the only unsolved modules left on the bomb.
    /// </summary>
    /// <remarks><para>
    /// These values are set by the Twitch Plays mod using reflection. This field is set in <c>Start()</c>,
    /// therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in
    /// <see cref="KMBombModule.OnActivate"/> or later.
    /// </para></remarks>
    [PublicAPI]
    bool IsTimeSkippable { [Pure] get; }

    /// <summary>
    /// Gets a value indicating whether the timer is counting up instead of down, for special cases,
    /// such as controlling how to sort button release times, or whether there is a low timer event or not.
    /// </summary>
    /// <remarks><para>
    /// These values are set by the Twitch Plays mod using reflection. This field is set in <c>Start()</c>,
    /// therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in
    /// <see cref="KMBombModule.OnActivate"/> or later.
    /// </para></remarks>
    [PublicAPI]
    bool IsZen { [Pure] get; }

    /// <summary>Gets or sets the help message that gets sent when typing <c>!{id} help</c>.</summary>
    [NotNull, PublicAPI]
    string Help { [Pure] get; set; }

    /// <summary>
    /// Gets or sets the manual that is looked up on The Manual Repository when
    /// <c>!{id} manual</c> is entered into chat.
    /// </summary>
    [NotNull, PublicAPI, StringSyntax(StringSyntaxAttribute.Uri), UriString]
    string Manual { [Pure] get; set; }

    /// <summary>Gets the list that contains modules that it should stop processing.</summary>
    /// <remarks><para>
    /// Currently, the only module that uses this capability is Souvenir.
    /// </para><para>
    /// These values are set by the Twitch Plays mod using reflection. This field is set in <c>Start()</c>,
    /// therefore there's no guarantee that it'll be available there, the field must be first accessed in a delegate in
    /// <see cref="KMBombModule.OnActivate"/> or later.
    /// </para></remarks>
    [NotNull, ItemCanBeNull, PublicAPI]
    ReadOnlyCollection<KMBombModule> Abandons { [Pure] get; }

    /// <summary>Gets the module that is attached to this instance.</summary>
    [NotNull, PublicAPI]
    ModdedModule Inner { [Pure] get; }

    /// <summary>
    /// When the module runs into an exception or the module is forced to be solved, this method is used.
    /// </summary>
    /// <remarks><para>
    /// Make sure that the module is solved before this method closes, otherwise it causes a forced-solve.
    /// </para></remarks>
    /// <returns>A series of instructions for the Twitch Plays mod to handle in order to guarantee solving.</returns>
    [NotNull, ItemCanBeNull, PublicAPI, Pure]
    IEnumerable<Instruction> ForceSolve();
}
