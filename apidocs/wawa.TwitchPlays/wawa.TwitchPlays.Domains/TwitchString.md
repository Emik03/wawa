# TwitchString Struct

namespace: [wawa\.TwitchPlays\.Domains](../wawa.TwitchPlays.Domains.md)<br />
assembly: [wawa\.TwitchPlays](../../wawa.TwitchPlays.md)

Represents a `System.String` query to send to Twitch Plays\.

```csharp
public struct TwitchString;
```

Inheritance: `ValueType` > TwitchString

Implements: `ICloneable`, `IEquatable<TwitchString>`, `IEqualityComparer<TwitchString>`

## Methods

| Name | Summary |
|------|---------|
| [implicit operator string\(TwitchString\)](./TwitchString/op_Implicit.md) | Implicitly calls the property [Message](../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/TwitchString/Message.md)\. |
| [operator ==\(TwitchString, TwitchString\)](./TwitchString/op_Equality.md) | Determines whether both instances contain the same values\. |
| [operator \!=\(TwitchString, TwitchString\)](./TwitchString/op_Inequality.md) | Determines whether both instances do not contain the same values\. |
| [StrikeMessage\(string, bool, bool\)](./TwitchString/StrikeMessage.md) | Yield return this to allow you to tell the user why they got a strike if it isn't clear\. |
| [TryCancel\(string\)](./TwitchString/TryCancel.md) | Yield return this to indicate that this command is allowed to be cancelled at the given time of the yield\. |
| [TryWaitCancel\(float, string\)](./TwitchString/TryWaitCancel.md) | Yield return this to cause Twitch Plays to wait for the given time,and any time during the entire duration, the command may cancel\. |
| [SendToChat\(string, bool, bool\)](./TwitchString/SendToChat.md) | Yield return this to send a chat directly to twitch chat\. |
| [SendToChatError\(string, bool, bool\)](./TwitchString/SendToChatError.md) | Yield return this to send a message to the chat about why a users' command was invalid\. |
| [SendDelayedMessage\(float, string, bool, bool\)](./TwitchString/SendDelayedMessage.md) | Yield return this to send a message to chat after `time` seconds\. |
| [Detonate\(float?, string\)](./TwitchString/Detonate.md) | Yield return this to explode the bomb instantly\. |
| [SkipTime\(float\)](./TwitchString/SkipTime.md) | Yield return this to try advancing the clock to the specified time\. |
| [AwardPoints\(int\)](./TwitchString/AwardPoints.md) | Yield return this to award the user that sent the command points directly\. |
| [AwardPointsOnSolve\(int\)](./TwitchString/AwardPointsOnSolve.md) | Yield return this to award the last user that sent the command points when the module is solved\. |
| [Equals\(TwitchString\)](./TwitchString/Equals.md) |  |
| [Equals\(TwitchString, TwitchString\)](./TwitchString/Equals.md) |  |
| [Equals\(object\)](./TwitchString/Equals.md) |  |
| [GetHashCode\(TwitchString\)](./TwitchString/GetHashCode.md) |  |
| [GetHashCode\(\)](./TwitchString/GetHashCode.md) |  |
| [ToString\(\)](./TwitchString/ToString.md) |  |
| [Clone\(\)](./TwitchString/Clone.md) |  |

## Properties

| Name | Summary |
|------|---------|
| [AutoSolve](./TwitchString/AutoSolve.md) | Gets the auto\-solving Twitch Plays query\. |
| [CancelDetonate](./TwitchString/CancelDetonate.md) | Gets the cancellation\-of\-detonation Twitch Plays query\. |
| [Cancelled](./TwitchString/Cancelled.md) | Gets the cancellation\-of\-processing Twitch Plays query\. |
| [EndMultipleStrikes](./TwitchString/EndMultipleStrikes.md) | Gets the strike enabler Twitch Plays query\. |
| [EndWaitingMusic](./TwitchString/EndWaitingMusic.md) | Gets the cancellation\-of\-music Twitch Plays query\. |
| [HideCamera](./TwitchString/HideCamera.md) | Gets the camera hider Twitch Plays query\. |
| [MultipleStrikes](./TwitchString/MultipleStrikes.md) | Gets the strike disabler Twitch Plays query\. |
| [Solve](./TwitchString/Solve.md) | Gets the solving Twitch Plays query\. |
| [Strike](./TwitchString/Strike.md) | Gets the striking Twitch Plays query\. |
| [ToggleWaitingMusic](./TwitchString/ToggleWaitingMusic.md) | Gets the music toggle Twitch Plays query\. |
| [TryCancelSequence](./TwitchString/TryCancelSequence.md) | Gets the allow cancel Twitch Plays query\. |
| [UnsubmittablePenalty](./TwitchString/UnsubmittablePenalty.md) | Gets the unsubmittable penalty Twitch Plays query\. |
| [WaitingMusic](./TwitchString/WaitingMusic.md) | Gets the music Twitch Plays query\. |
| [IsSendMessage](./TwitchString/IsSendMessage.md) | Gets a value indicating whether this instance contains an instruction to send a message to the Twitch chat\. |
| [Message](./TwitchString/Message.md) | Gets the message to send to Twitch Plays\. |

