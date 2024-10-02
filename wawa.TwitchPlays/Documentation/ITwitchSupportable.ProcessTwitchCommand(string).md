#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[ITwitchSupportable](ITwitchSupportable.md 'wawa.TwitchPlays.Domains.ITwitchSupportable')

## ITwitchSupportable.ProcessTwitchCommand(string) Method

This method gets grabbed by Twitch Plays to process a user command.

```csharp
System.Collections.IEnumerator ProcessTwitchCommand(string command);
```
#### Parameters

<a name='wawa.TwitchPlays.Domains.ITwitchSupportable.ProcessTwitchCommand(string).command'></a>

`command` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The command of the user.

#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
A list of instructions for Twitch Plays.