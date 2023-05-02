#### [wawa.TwitchPlays](index.md 'index')
### [Wawa.TwitchPlays.Domains](Wawa.TwitchPlays.Domains.md 'Wawa.TwitchPlays.Domains').[AliasAttribute](AliasAttribute.md 'Wawa.TwitchPlays.Domains.AliasAttribute')

## AliasAttribute(IList<string>) Constructor

Initializes a new instance of the [AliasAttribute](AliasAttribute.md 'Wawa.TwitchPlays.Domains.AliasAttribute') class.

```csharp
public AliasAttribute(System.Collections.Generic.IList<string?> aliases);
```
#### Parameters

<a name='Wawa.TwitchPlays.Domains.AliasAttribute.AliasAttribute(System.Collections.Generic.IList_string_).aliases'></a>

`aliases` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')

The prefix of this command.

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
A [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') in [aliases](AliasAttribute..ctor(IList).md#Wawa.TwitchPlays.Domains.AliasAttribute.AliasAttribute(System.Collections.Generic.IList_string_).aliases 'Wawa.TwitchPlays.Domains.AliasAttribute.AliasAttribute(System.Collections.Generic.IList<string>).aliases') contain at least one [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char') that is whitespace,  
according to [System.Char.IsWhiteSpace(System.Char)](https://docs.microsoft.com/en-us/dotnet/api/System.Char.IsWhiteSpace#System_Char_IsWhiteSpace_System_Char_ 'System.Char.IsWhiteSpace(System.Char)').