#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays](wawa.TwitchPlays.md 'wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch{TMod}.md 'wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.ProcessTwitchCommand(string) Method

This method gets grabbed by Twitch Plays to process a user command.

```csharp
public System.Collections.IEnumerator ProcessTwitchCommand(string command);
```
#### Parameters

<a name='wawa.TwitchPlays.Twitch_TMod_.ProcessTwitchCommand(string).command'></a>

`command` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The command of the user.

Implements [ProcessTwitchCommand(string)](ITwitchSupportable.ProcessTwitchCommand(string).md 'wawa.TwitchPlays.Domains.ITwitchSupportable.ProcessTwitchCommand(string)')

#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
A list of instructions for Twitch Plays.