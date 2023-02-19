#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays.Domains](Wawa.TwitchPlays.Domains.md 'Wawa.TwitchPlays.Domains')

## CommandAttribute Class

An [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') to attach to methods to signify that  
the command should be processed by [Twitch&lt;TMod&gt;](Twitch_TMod_.md 'Wawa.TwitchPlays.Twitch<TMod>').

```csharp
public sealed class CommandAttribute : System.Attribute,
System.ICloneable,
System.IEquatable<Wawa.TwitchPlays.Domains.CommandAttribute>,
System.Collections.Generic.IEqualityComparer<Wawa.TwitchPlays.Domains.CommandAttribute>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; CommandAttribute

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[CommandAttribute](CommandAttribute.md 'Wawa.TwitchPlays.Domains.CommandAttribute')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[CommandAttribute](CommandAttribute.md 'Wawa.TwitchPlays.Domains.CommandAttribute')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

| Constructors | |
| :--- | :--- |
| [CommandAttribute(string, int)](CommandAttribute..ctor.ug5Skh62zvc96usuZjkPNw.md 'Wawa.TwitchPlays.Domains.CommandAttribute.CommandAttribute(string, int)') | Initializes a new instance of the [CommandAttribute](CommandAttribute.md 'Wawa.TwitchPlays.Domains.CommandAttribute') class. |

| Properties | |
| :--- | :--- |
| [Prefix](CommandAttribute.Prefix.md 'Wawa.TwitchPlays.Domains.CommandAttribute.Prefix') | Gets the prefix of this command. If [Wawa.Optionals.Maybe.None&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe.None--1 'Wawa.Optionals.Maybe.None``1'), the prefix is inferred. |
| [Priority](CommandAttribute.Priority.md 'Wawa.TwitchPlays.Domains.CommandAttribute.Priority') | Gets the priority. Higher means evaluated sooner. |

| Operators | |
| :--- | :--- |
| [operator ==(CommandAttribute, CommandAttribute)](CommandAttribute.op_Equality.BkpC9z4gYV07QzEFgTWcgQ.md 'Wawa.TwitchPlays.Domains.CommandAttribute.op_Equality(Wawa.TwitchPlays.Domains.CommandAttribute, Wawa.TwitchPlays.Domains.CommandAttribute)') | Determines whether both have the same values. |
| [operator !=(CommandAttribute, CommandAttribute)](CommandAttribute.op_Inequality.Ion6jwSJd+N2GvZ0fDmJVQ.md 'Wawa.TwitchPlays.Domains.CommandAttribute.op_Inequality(Wawa.TwitchPlays.Domains.CommandAttribute, Wawa.TwitchPlays.Domains.CommandAttribute)') | Determines whether both do not have the same values. |
