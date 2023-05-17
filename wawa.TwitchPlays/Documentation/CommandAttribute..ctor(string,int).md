#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays.Domains](Wawa.TwitchPlays.Domains.md 'Wawa.TwitchPlays.Domains').[CommandAttribute](CommandAttribute.md 'Wawa.TwitchPlays.Domains.CommandAttribute')

## CommandAttribute(string, int) Constructor

Initializes a new instance of the [CommandAttribute](CommandAttribute.md 'Wawa.TwitchPlays.Domains.CommandAttribute') class.

```csharp
public CommandAttribute(string prefix=null, int priority=0);
```
#### Parameters

<a name='Wawa.TwitchPlays.Domains.CommandAttribute.CommandAttribute(string,int).prefix'></a>

`prefix` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The prefix of this command.

<a name='Wawa.TwitchPlays.Domains.CommandAttribute.CommandAttribute(string,int).priority'></a>

`priority` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The priority of the command. A higher value means it will be evaluated sooner.