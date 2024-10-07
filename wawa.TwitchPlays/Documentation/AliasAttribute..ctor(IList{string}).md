#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains').[AliasAttribute](AliasAttribute.md 'wawa.TwitchPlays.Domains.AliasAttribute')

## AliasAttribute(IList<string>) Constructor

An [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') to attach to a field to signify alternative ways to spell it.

```csharp
public AliasAttribute(System.Collections.Generic.IList<string> aliases);
```
#### Parameters

<a name='wawa.TwitchPlays.Domains.AliasAttribute.AliasAttribute(System.Collections.Generic.IList_string_).aliases'></a>

`aliases` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')

The prefix of this command.<p/>`[ItemCanBeNull]`

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
A [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') in [aliases](AliasAttribute..ctor(IList{string}).md#wawa.TwitchPlays.Domains.AliasAttribute.AliasAttribute(System.Collections.Generic.IList_string_).aliases 'wawa.TwitchPlays.Domains.AliasAttribute.AliasAttribute(System.Collections.Generic.IList<string>).aliases') contain at least one [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char') that is whitespace,  
according to [System.Char.IsWhiteSpace(System.Char)](https://docs.microsoft.com/en-us/dotnet/api/System.Char.IsWhiteSpace#System_Char_IsWhiteSpace_System_Char_ 'System.Char.IsWhiteSpace(System.Char)').