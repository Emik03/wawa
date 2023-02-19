#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays](Wawa.TwitchPlays.md 'Wawa.TwitchPlays').[Twitch&lt;TMod&gt;](Twitch_TMod_.md 'Wawa.TwitchPlays.Twitch<TMod>')

## Twitch<TMod>.ProcessTwitchCommand(string) Method

This method gets grabbed by Twitch Plays to process a user command.

```csharp
public virtual System.Collections.IEnumerator ProcessTwitchCommand(string command);
```
#### Parameters

<a name='Wawa.TwitchPlays.Twitch_TMod_.ProcessTwitchCommand(string).command'></a>

`command` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The command of the user.

Implements [ProcessTwitchCommand(string)](ITwitchSupportable.ProcessTwitchCommand.gqwW8YCa6BJyzeHs/UqbcA.md 'Wawa.TwitchPlays.Domains.ITwitchSupportable.ProcessTwitchCommand(string)')

#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
A list of instructions for Twitch Plays.