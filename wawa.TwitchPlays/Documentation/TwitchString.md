#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains')

## TwitchString Struct

Represents a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') query to send to Twitch Plays.

```csharp
public readonly struct TwitchString :
System.ICloneable,
System.IEquatable<wawa.TwitchPlays.Domains.TwitchString>,
System.Collections.Generic.IEqualityComparer<wawa.TwitchPlays.Domains.TwitchString>
```

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[TwitchString](TwitchString.md 'wawa.TwitchPlays.Domains.TwitchString')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

| Properties | |
| :--- | :--- |
| [AutoSolve](TwitchString.AutoSolve.md 'wawa.TwitchPlays.Domains.TwitchString.AutoSolve') | Gets the auto-solving Twitch Plays query. |
| [CancelDetonate](TwitchString.CancelDetonate.md 'wawa.TwitchPlays.Domains.TwitchString.CancelDetonate') | Gets the cancellation-of-detonation Twitch Plays query. |
| [Cancelled](TwitchString.Cancelled.md 'wawa.TwitchPlays.Domains.TwitchString.Cancelled') | Gets the cancellation-of-processing Twitch Plays query. |
| [EndMultipleStrikes](TwitchString.EndMultipleStrikes.md 'wawa.TwitchPlays.Domains.TwitchString.EndMultipleStrikes') | Gets the strike enabler Twitch Plays query. |
| [EndWaitingMusic](TwitchString.EndWaitingMusic.md 'wawa.TwitchPlays.Domains.TwitchString.EndWaitingMusic') | Gets the cancellation-of-music Twitch Plays query. |
| [HideCamera](TwitchString.HideCamera.md 'wawa.TwitchPlays.Domains.TwitchString.HideCamera') | Gets the camera hider Twitch Plays query. |
| [IsSendMessage](TwitchString.IsSendMessage.md 'wawa.TwitchPlays.Domains.TwitchString.IsSendMessage') | Gets a value indicating whether this instance contains an instruction to send a message to the Twitch chat. |
| [Message](TwitchString.Message.md 'wawa.TwitchPlays.Domains.TwitchString.Message') | Gets the message to send to Twitch Plays. |
| [MultipleStrikes](TwitchString.MultipleStrikes.md 'wawa.TwitchPlays.Domains.TwitchString.MultipleStrikes') | Gets the strike disabler Twitch Plays query. |
| [Solve](TwitchString.Solve.md 'wawa.TwitchPlays.Domains.TwitchString.Solve') | Gets the solving Twitch Plays query. |
| [Strike](TwitchString.Strike.md 'wawa.TwitchPlays.Domains.TwitchString.Strike') | Gets the striking Twitch Plays query. |
| [ToggleWaitingMusic](TwitchString.ToggleWaitingMusic.md 'wawa.TwitchPlays.Domains.TwitchString.ToggleWaitingMusic') | Gets the music toggle Twitch Plays query. |
| [TryCancelSequence](TwitchString.TryCancelSequence.md 'wawa.TwitchPlays.Domains.TwitchString.TryCancelSequence') | Gets the allow cancel Twitch Plays query. |
| [UnsubmittablePenalty](TwitchString.UnsubmittablePenalty.md 'wawa.TwitchPlays.Domains.TwitchString.UnsubmittablePenalty') | Gets the unsubmittable penalty Twitch Plays query. |
| [WaitingMusic](TwitchString.WaitingMusic.md 'wawa.TwitchPlays.Domains.TwitchString.WaitingMusic') | Gets the music Twitch Plays query. |

| Methods | |
| :--- | :--- |
| [AwardPoints(int)](TwitchString.AwardPoints(int).md 'wawa.TwitchPlays.Domains.TwitchString.AwardPoints(int)') | Yield return this to award the user that sent the command points directly. |
| [AwardPointsOnSolve(int)](TwitchString.AwardPointsOnSolve(int).md 'wawa.TwitchPlays.Domains.TwitchString.AwardPointsOnSolve(int)') | Yield return this to award the last user that sent the command points when the module is solved. |
| [Detonate(Nullable&lt;float&gt;, string)](TwitchString.Detonate(float+,string).md 'wawa.TwitchPlays.Domains.TwitchString.Detonate(System.Nullable<float>, string)') | Yield return this to explode the bomb instantly. |
| [SendDelayedMessage(float, string, bool, bool)](TwitchString.SendDelayedMessage(float,string,bool,bool).md 'wawa.TwitchPlays.Domains.TwitchString.SendDelayedMessage(float, string, bool, bool)') | Yield return this to send a message to chat after [time](TwitchString.SendDelayedMessage(float,string,bool,bool).md#wawa.TwitchPlays.Domains.TwitchString.SendDelayedMessage(float,string,bool,bool).time 'wawa.TwitchPlays.Domains.TwitchString.SendDelayedMessage(float, string, bool, bool).time') seconds. |
| [SendToChat(string, bool, bool)](TwitchString.SendToChat(string,bool,bool).md 'wawa.TwitchPlays.Domains.TwitchString.SendToChat(string, bool, bool)') | Yield return this to send a chat directly to twitch chat. |
| [SendToChatError(string, bool, bool)](TwitchString.SendToChatError(string,bool,bool).md 'wawa.TwitchPlays.Domains.TwitchString.SendToChatError(string, bool, bool)') | Yield return this to send a message to the chat about why a users' command was invalid. |
| [SkipTime(float)](TwitchString.SkipTime(float).md 'wawa.TwitchPlays.Domains.TwitchString.SkipTime(float)') | Yield return this to try advancing the clock to the specified time. |
| [StrikeMessage(string, bool, bool)](TwitchString.StrikeMessage(string,bool,bool).md 'wawa.TwitchPlays.Domains.TwitchString.StrikeMessage(string, bool, bool)') | Yield return this to allow you to tell the user why they got a strike if it isn't clear. |
| [TryCancel(string)](TwitchString.TryCancel(string).md 'wawa.TwitchPlays.Domains.TwitchString.TryCancel(string)') | Yield return this to indicate that this command is allowed to be cancelled at the given time of the yield. |
| [TryWaitCancel(float, string)](TwitchString.TryWaitCancel(float,string).md 'wawa.TwitchPlays.Domains.TwitchString.TryWaitCancel(float, string)') | Yield return this to cause Twitch Plays to wait for the given time,<br/>and any time during the entire duration, the command may cancel. |

| Operators | |
| :--- | :--- |
| [operator ==(TwitchString, TwitchString)](TwitchString.op_Equality(TwitchString,TwitchString).md 'wawa.TwitchPlays.Domains.TwitchString.op_Equality(wawa.TwitchPlays.Domains.TwitchString, wawa.TwitchPlays.Domains.TwitchString)') | Determines whether both instances contain the same values. |
| [implicit operator string(TwitchString)](TwitchString.String(TwitchString).md 'wawa.TwitchPlays.Domains.TwitchString.op_Implicit string(wawa.TwitchPlays.Domains.TwitchString)') | Implicitly calls the property [Message](TwitchString.Message.md 'wawa.TwitchPlays.Domains.TwitchString.Message'). |
| [operator !=(TwitchString, TwitchString)](TwitchString.op_Inequality(TwitchString,TwitchString).md 'wawa.TwitchPlays.Domains.TwitchString.op_Inequality(wawa.TwitchPlays.Domains.TwitchString, wawa.TwitchPlays.Domains.TwitchString)') | Determines whether both instances do not contain the same values. |
