# ProcessTwitchCommand\(string\) Method

namespace: [wawa\.TwitchPlays\.Domains](../../wawa.TwitchPlays.Domains.md)<br />
assembly: [wawa\.TwitchPlays](../../../wawa.TwitchPlays.md)

This method gets grabbed by Twitch Plays to process a user command\.

```csharp
public abstract IEnumerator ProcessTwitchCommand(string command);
```

## Parameters

__command__ : `string`

The command of the user\.

## Return Value

`IEnumerator`

A list of instructions for Twitch Plays\.

