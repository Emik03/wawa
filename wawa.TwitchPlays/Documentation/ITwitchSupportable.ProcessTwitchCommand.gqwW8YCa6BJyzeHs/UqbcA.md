#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays.Domains](Wawa.TwitchPlays.Domains.md 'Wawa.TwitchPlays.Domains').[ITwitchSupportable](ITwitchSupportable.md 'Wawa.TwitchPlays.Domains.ITwitchSupportable')

## ITwitchSupportable.ProcessTwitchCommand(string) Method

This method gets grabbed by Twitch Plays to process a user command.

```csharp
System.Collections.IEnumerator ProcessTwitchCommand(string command);
```
#### Parameters

<a name='Wawa.TwitchPlays.Domains.ITwitchSupportable.ProcessTwitchCommand(string).command'></a>

`command` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The command of the user.

#### Returns
[System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')  
A list of instructions for Twitch Plays.