#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[CommandAttribute](CommandAttribute.md 'wawa.TwitchPlays.Domains.CommandAttribute')

## CommandAttribute(string, int) Constructor

An [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') to attach to methods to signify that  
the command should be processed by [Twitch&lt;TMod&gt;](Twitch{TMod}.md 'wawa.TwitchPlays.Twitch<TMod>').

```csharp
public CommandAttribute(string prefix=null, int priority=0);
```
#### Parameters

<a name='wawa.TwitchPlays.Domains.CommandAttribute.CommandAttribute(string,int).prefix'></a>

`prefix` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The prefix of this command.

<a name='wawa.TwitchPlays.Domains.CommandAttribute.CommandAttribute(string,int).priority'></a>

`priority` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The priority of the command. A higher value means it will be evaluated sooner.