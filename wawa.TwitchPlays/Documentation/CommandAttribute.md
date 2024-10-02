#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains')

## CommandAttribute Class

An [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') to attach to methods to signify that  
the command should be processed by [Twitch&lt;TMod&gt;](Twitch{TMod}.md 'wawa.TwitchPlays.Twitch<TMod>').

```csharp
public sealed class CommandAttribute : System.Attribute,
System.ICloneable,
System.IEquatable<wawa.TwitchPlays.Domains.CommandAttribute>,
System.Collections.Generic.IEqualityComparer<wawa.TwitchPlays.Domains.CommandAttribute>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; CommandAttribute

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[CommandAttribute](CommandAttribute.md 'wawa.TwitchPlays.Domains.CommandAttribute')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[CommandAttribute](CommandAttribute.md 'wawa.TwitchPlays.Domains.CommandAttribute')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

| Constructors | |
| :--- | :--- |
| [CommandAttribute(string, int)](CommandAttribute..ctor(string,int).md 'wawa.TwitchPlays.Domains.CommandAttribute.CommandAttribute(string, int)') | An [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') to attach to methods to signify that<br/>the command should be processed by [Twitch&lt;TMod&gt;](Twitch{TMod}.md 'wawa.TwitchPlays.Twitch<TMod>'). |

| Properties | |
| :--- | :--- |
| [Prefix](CommandAttribute.Prefix.md 'wawa.TwitchPlays.Domains.CommandAttribute.Prefix') | Gets the prefix of this command. If [wawa.Optionals.Maybe.None&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe.None--1 'wawa.Optionals.Maybe.None``1'), the prefix is inferred. |
| [Priority](CommandAttribute.Priority.md 'wawa.TwitchPlays.Domains.CommandAttribute.Priority') | Gets the priority. Higher means evaluated sooner. |

| Operators | |
| :--- | :--- |
| [operator ==(CommandAttribute, CommandAttribute)](CommandAttribute.op_Equality(CommandAttribute,CommandAttribute).md 'wawa.TwitchPlays.Domains.CommandAttribute.op_Equality(wawa.TwitchPlays.Domains.CommandAttribute, wawa.TwitchPlays.Domains.CommandAttribute)') | Determines whether both have the same values. |
| [operator !=(CommandAttribute, CommandAttribute)](CommandAttribute.op_Inequality(CommandAttribute,CommandAttribute).md 'wawa.TwitchPlays.Domains.CommandAttribute.op_Inequality(wawa.TwitchPlays.Domains.CommandAttribute, wawa.TwitchPlays.Domains.CommandAttribute)') | Determines whether both do not have the same values. |
