# StrikeMessage\(string, bool, bool\) Method

namespace: [wawa\.TwitchPlays\.Domains](../../wawa.TwitchPlays.Domains.md)<br />
assembly: [wawa\.TwitchPlays](../../../wawa.TwitchPlays.md)

Yield return this to allow you to tell the user why they got a strike if it isn't clear\.

```csharp
public static TwitchString StrikeMessage(string message ,bool format = True ,bool halt = False);
```

## Parameters

__message__ : `string`

The message to send\.

__format__ : `bool`

When `false`, treats `{` and `}` as plaintext\.

__halt__ : `bool`

When `true`, halts the command processing after the message is sent\.

## Return Value

[TwitchString](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/TwitchString.md)

A formatted string for Twitch Plays\.

