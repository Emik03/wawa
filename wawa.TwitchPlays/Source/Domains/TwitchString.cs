// SPDX-License-Identifier: MPL-2.0
namespace Wawa.TwitchPlays.Domains;

/// <summary>Represents a <see cref="string"/> query to send to Twitch Plays.</summary>
[PublicAPI]
public readonly struct TwitchString : ICloneable, IEquatable<TwitchString>, IEqualityComparer<TwitchString>
{
    TwitchString([NotNull] string message) => Message = message;

    /// <summary>Gets the auto-solving Twitch Plays query.</summary>
    /// <remarks><para>
    /// Yield return this to indicate automatically solving the module, as if it threw an exception while solving.
    /// </para></remarks>
    public static TwitchString AutoSolve { [Pure] get; } = new("autosolve");

    /// <summary>Gets the cancellation-of-detonation Twitch Plays query.</summary>
    /// <remarks><para>
    /// Yield return this to indicate cancelling a previously issued delayed detonation command on the same module.
    /// </para></remarks>
    public static TwitchString CancelDetonate { [Pure] get; } = new("cancel detonate");

    /// <summary>Gets the cancellation-of-processing Twitch Plays query.</summary>
    /// <remarks><para>
    /// Yield return this to indicate that you have stopped processing the command in response to the
    /// <see cref="Twitch{TMod}.TwitchShouldCancelCommand"/> bool being set to <see langword="true"/>.
    /// </para></remarks>
    public static TwitchString Cancelled { [Pure] get; } = new("cancelled");

    /// <summary>Gets the strike enabler Twitch Plays query.</summary>
    /// <remarks><para>
    /// Yield return this to indicate that the strike tracker should be enabled.
    /// If any strikes were issued during the time it was disabled,
    /// they will be awarded and the routine stopped at that point,
    /// otherwise, it will just cancel the "<c>VoteNay Mod {id} got 0 strikes! +0 strike to {Nickname}</c>"
    /// message that would otherwise be posted.
    /// Likewise, if the module was solved at the time this command is issued,
    /// the processing will be stopped as of that point as well.
    /// </para></remarks>
    public static TwitchString EndMultipleStrikes { [Pure] get; } = new("end multiple strikes");

    /// <summary>Gets the cancellation-of-music Twitch Plays query.</summary>
    /// <remarks><para>Yield return this to indicate stopping the waiting music mid-command.</para></remarks>
    public static TwitchString EndWaitingMusic { [Pure] get; } = new("end waiting music");

    /// <summary>Gets the camera hider Twitch Plays query.</summary>
    /// <remarks><para>
    /// Yield return this to hide the heads-up display and cameras while doing quaternion rotations,
    /// if it is expected that the camera/hud will get in the way.
    /// </para></remarks>
    public static TwitchString HideCamera { [Pure] get; } = new("hide camera");

    /// <summary>Gets the strike disabler Twitch Plays query.</summary>
    /// <remarks><para>
    /// Yield return this to indicate that the issued command is going to cause more than one strike,
    /// so should disable the internal strike tracker in order to avoid flooding the chat with
    /// "<c>VoteNay Mod {id} got a strike! +1 strike to {Nickname}</c>" for as many strikes as will be awarded.
    /// This also disables the internal solve tracker as well. This allows for sending
    /// additional messages or continue processing commands regardless of the solve/strike state.
    /// </para></remarks>
    public static TwitchString MultipleStrikes { [Pure] get; } = new("multiple strikes");

    /// <summary>Gets the solving Twitch Plays query.</summary>
    /// <remarks><para>
    /// Yield return this to indicate that this command will solve the module at some later point;
    /// all this does is tell Twitch Plays to attribute the solve to the author of this command.
    /// </para></remarks>
    public static TwitchString Solve { [Pure] get; } = new("solve");

    /// <summary>Gets the striking Twitch Plays query.</summary>
    /// <remarks><para>
    /// Yield return this to indicate that this command will cause a strike at some later point;
    /// all this does is tell Twitch Plays to attribute the strike to the author of this command.
    /// </para></remarks>
    public static TwitchString Strike { [Pure] get; } = new("strike");

    /// <summary>Gets the music toggle Twitch Plays query.</summary>
    /// <remarks><para>Yield return this to toggle the waiting music on and off mid-command.</para></remarks>
    public static TwitchString ToggleWaitingMusic { [Pure] get; } = new("toggle waiting music");

    /// <summary>Gets the allow cancel Twitch Plays query.</summary>
    /// <remarks><para>
    /// Yield return this to indicate that the <c>KMSelectable[]</c> sequence that follows this command should be
    /// cancelled if a "<c>!cancel</c>" or "<c>!stop</c>" is issued mid-way through that sequence.
    /// </para></remarks>
    public static TwitchString TryCancelSequence { [Pure] get; } = new("trycancelsequence");

    /// <summary>Gets the unsubmittable penalty Twitch Plays query.</summary>
    /// <remarks><para>
    /// Yield return this to indicate that the command couldn't submit an answer and should only be used to prevent
    /// users from guessing the answer. This should not be used if an answer could never be submittable for a module.
    /// </para></remarks>
    public static TwitchString UnsubmittablePenalty { [Pure] get; } = new("unsubmittablepenalty");

    /// <summary>Gets the music Twitch Plays query.</summary>
    /// <remarks><para>
    /// Yield return this to indicate playing the waiting music if a command will take long to finish.
    /// </para></remarks>
    public static TwitchString WaitingMusic { [Pure] get; } = new("waiting music");

    /// <summary>Gets the message to send to Twitch Plays.</summary>
    [NotNull]
    public string Message { [Pure] get; } = "";

    /// <summary>Implicitly calls the property <see cref="Message"/>.</summary>
    /// <param name="query">The <see cref="TwitchString"/> to access the property from.</param>
    [NotNull, Pure]
    public static implicit operator string(TwitchString query) => query.Message;

    /// <summary>Determines whether both instances contain the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>The value <see langword="true"/> if both instances contain the same values.</returns>
    [Pure]
    public static bool operator ==([InstantHandle] TwitchString left, [InstantHandle] TwitchString right) =>
        left.Message.Equals(right.Message, Ordinal);

    /// <summary>Determines whether both instances do not contain the same values.</summary>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>The value <see langword="true"/> if both instances do not contain the same values.</returns>
    [Pure]
    public static bool operator !=([InstantHandle] TwitchString left, [InstantHandle] TwitchString right) =>
        !(left == right);

    /// <summary>Yield return this to allow you to tell the user why they got a strike if it isn't clear.</summary>
    /// <param name="message">The message to send.</param>
    /// <returns>A formatted string for Twitch Plays.</returns>
    [Pure]
    public static TwitchString StrikeMessage([NotNull] string message) => new($"strikemessage {message}");

    /// <summary>
    /// Yield return this to indicate that this command is allowed to be cancelled at the given time of the yield.
    /// </summary>
    /// <remarks><para>
    /// Just know that you won't be able to clean up if you do your cancel this way,
    /// and there is a pending <c>!cancel</c> or <c>!stop</c>.
    /// </para></remarks>
    /// <param name="message">The message to send.</param>
    /// <returns>A formatted string for Twitch Plays.</returns>
    [Pure]
    public static TwitchString TryCancel([AllowNull, CanBeNull] string message = null) =>
        new(message is null ? "trycancel" : $"trycancel {message}");

    /// <summary>
    /// Yield return this to cause Twitch Plays to wait for the given time,
    /// and any time during the entire duration, the command may cancel.
    /// </summary>
    /// <remarks><para>
    /// Like <see cref="TryCancel"/>, you won't be able to clean up if you cancel this way.
    /// Also like <see cref="TryCancel"/>, <paramref name="message"/> is optional.
    /// </para></remarks>
    /// <param name="time">The amount of time to wait.</param>
    /// <param name="message">The message to send.</param>
    /// <returns>A formatted string for Twitch Plays.</returns>
    [Pure]
    public static TwitchString TryWaitCancel(float time, [AllowNull, CanBeNull] string message = null) =>
        new(message is null ? $"trywaitcancel {time}" : $"trywaitcancel {time} {message}");

    /// <summary>Yield return this to send a chat directly to twitch chat.</summary>
    /// <param name="message">The message to send.</param>
    /// <returns>A formatted string for Twitch Plays.</returns>
    [Pure]
    public static TwitchString SendToChat([NotNull] string message) => new($"sendtochat {message}");

    /// <summary>Yield return this to send a message to the chat about why a users' command was invalid.</summary>
    /// <param name="message">The message to send.</param>
    /// <returns>A formatted string for Twitch Plays.</returns>
    [Pure]
    public static TwitchString SendToChatError([NotNull] string message) => new($"sendtochaterror {message}");

    /// <summary>Yield return this to send a message to chat after <paramref name="time"/> seconds.</summary>
    /// <param name="time">The amount of time to wait before the message gets sent.</param>
    /// <param name="message">The message to send.</param>
    /// <returns>A formatted string for Twitch Plays.</returns>
    [Pure]
    public static TwitchString SendDelayedMessage(float time, [NotNull] string message) =>
        new($"sendtochat {time} {message}");

    /// <summary>Yield return this to explode the bomb instantly.</summary>
    /// <remarks><para>
    /// <paramref name="time"/> is specified in number of seconds before the bomb explodes.
    /// (Note, sending another detonate command will auto-cancel the previous one on
    /// the same module if it hasn't happened already.).
    /// <paramref name="message"/> is the message to send to chat upon detonation.
    /// Both of the parameters are optional.
    /// </para></remarks>
    /// <param name="time">The amount of time before the bomb blows up.</param>
    /// <param name="message">The message to send.</param>
    /// <returns>A formatted string for Twitch Plays.</returns>
    [Pure]
    public static TwitchString Detonate(float? time = null, [AllowNull, CanBeNull] string message = null) =>
        new($"detonate {time} {message}");

    /// <summary>Yield return this to try advancing the clock to the specified time.</summary>
    /// <remarks><para>
    /// You must put the full time you wish to skip to, and this time either needs to be less than the current time,
    /// if in normal/time mode, or greater than the current time, if in zen mode.
    /// Example, if you wanted to set the clock to 5:24, then you do "<c>SkipTime(324)</c>".
    /// You can target partway through the seconds, such as "<c>SkipTime(45.28f)</c>",
    /// which would then set the clock to 45.28, provided that time has NOT gone by already. You must also
    /// set <see cref="Twitch{TMod}.IsTimeSkippable"/> to <see langword="true"/>, for this function to work.
    /// </para></remarks>
    /// <param name="seconds">The time to skip to in seconds.</param>
    /// <returns>A formatted string for Twitch Plays.</returns>
    [Pure]
    public static TwitchString SkipTime(float seconds) => new($"skiptime {seconds}");

    /// <summary>Yield return this to award the user that sent the command points directly.</summary>
    /// <remarks><para>
    /// This is currently used for mods like Souvenir to give points to users that answered the questions equally.
    /// </para></remarks>
    /// <param name="points">The amount of points to award. Negatives supported.</param>
    /// <returns>A formatted string for Twitch Plays.</returns>
    [Pure]
    public static TwitchString AwardPoints(int points) => new($"awardpoints {points}");

    /// <summary>
    /// Yield return this to award the last user that sent the command points when the module is solved.
    /// </summary>
    /// <remarks><para>
    /// The module must prevent any user from sending commands afterward in order for Twitch Plays
    /// to award points to the correct user. This is currently used by the Twin module
    /// when extra points must be given but the module is not solved immediately.
    /// </para></remarks>
    /// <param name="points">The amount of points to award. Negatives supported.</param>
    /// <returns>A formatted string for Twitch Plays.</returns>
    [Pure]
    public static TwitchString AwardPointsOnSolve(int points) => new($"awardpointsonsolve {points}");

    /// <inheritdoc/>
    [Pure]
    public bool Equals(TwitchString other) => this == other;

    /// <inheritdoc/>
    [Pure]
    public bool Equals(TwitchString x, TwitchString y) => x == y;

    /// <inheritdoc/>
    [Pure]
    public override bool Equals([AllowNull] object obj) => obj is TwitchString query && Equals(query);

    /// <inheritdoc/>
    [Pure]
    public int GetHashCode(TwitchString obj) => obj.GetHashCode();

    /// <inheritdoc/>
    [Pure]
    public override int GetHashCode() => StringComparer.Ordinal.GetHashCode(Message);

    /// <inheritdoc/>
    [Pure]
    public override string ToString() => Message;

    /// <inheritdoc/>
    [Pure]
    public object Clone() => this;
}
