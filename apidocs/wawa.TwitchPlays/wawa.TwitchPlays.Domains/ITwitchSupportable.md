# ITwitchSupportable Interface

namespace: [wawa\.TwitchPlays\.Domains](../wawa.TwitchPlays.Domains.md)<br />
assembly: [wawa\.TwitchPlays](../../wawa.TwitchPlays.md)

Interface for Twitch Plays support\.

```csharp
public interface ITwitchSupportable;
```

## Methods

| Name | Summary |
|------|---------|
| [TwitchHandleForcedSolve\(\)](./ITwitchSupportable/TwitchHandleForcedSolve.md) | This method gets grabbed by Twitch Plays which is used whenever a thrown `Exception`is unhandled, a votesolve/solvebomb is performed, or when an admin forces this module to be solved\. |
| [ProcessTwitchCommand\(string\)](./ITwitchSupportable/ProcessTwitchCommand.md) | This method gets grabbed by Twitch Plays to process a user command\. |

