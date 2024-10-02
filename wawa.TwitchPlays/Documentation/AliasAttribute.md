#### [wawa.TwitchPlays](index.md 'index')
### [wawa.TwitchPlays.Domains](wawa.TwitchPlays.Domains.md 'wawa.TwitchPlays.Domains')

## AliasAttribute Class

An [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') to attach to a field to signify alternative ways to spell it.

```csharp
public sealed class AliasAttribute : System.Attribute,
System.ICloneable,
System.IEquatable<wawa.TwitchPlays.Domains.AliasAttribute>,
System.Collections.Generic.IEqualityComparer<wawa.TwitchPlays.Domains.AliasAttribute>,
System.IFormattable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; AliasAttribute

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[AliasAttribute](AliasAttribute.md 'wawa.TwitchPlays.Domains.AliasAttribute')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[AliasAttribute](AliasAttribute.md 'wawa.TwitchPlays.Domains.AliasAttribute')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1'), [System.IFormattable](https://docs.microsoft.com/en-us/dotnet/api/System.IFormattable 'System.IFormattable')

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
A [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') in aliases contain at least one [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char') that is whitespace,  
according to [System.Char.IsWhiteSpace(System.Char)](https://docs.microsoft.com/en-us/dotnet/api/System.Char.IsWhiteSpace#System_Char_IsWhiteSpace_System_Char_ 'System.Char.IsWhiteSpace(System.Char)').

| Constructors | |
| :--- | :--- |
| [AliasAttribute(string[])](AliasAttribute..ctor(string[]).md 'wawa.TwitchPlays.Domains.AliasAttribute.AliasAttribute(string[])') | Initializes a new instance of the [AliasAttribute](AliasAttribute.md 'wawa.TwitchPlays.Domains.AliasAttribute') class. |
| [AliasAttribute(IList&lt;string&gt;)](AliasAttribute..ctor(IList{string}).md 'wawa.TwitchPlays.Domains.AliasAttribute.AliasAttribute(System.Collections.Generic.IList<string>)') | An [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') to attach to a field to signify alternative ways to spell it. |

| Properties | |
| :--- | :--- |
| [Aliases](AliasAttribute.Aliases.md 'wawa.TwitchPlays.Domains.AliasAttribute.Aliases') | Gets the alternative representations. |

| Methods | |
| :--- | :--- |
| [ToString(string)](AliasAttribute.ToString(string).md 'wawa.TwitchPlays.Domains.AliasAttribute.ToString(string)') | Gets a [string](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/string 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/string') representation showing every alias. |
| [ToString(FieldInfo)](AliasAttribute.ToString(FieldInfo).md 'wawa.TwitchPlays.Domains.AliasAttribute.ToString(System.Reflection.FieldInfo)') | Gets a [string](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/string 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/string') representation showing every alias. |

| Operators | |
| :--- | :--- |
| [operator ==(AliasAttribute, AliasAttribute)](AliasAttribute.op_Equality(AliasAttribute,AliasAttribute).md 'wawa.TwitchPlays.Domains.AliasAttribute.op_Equality(wawa.TwitchPlays.Domains.AliasAttribute, wawa.TwitchPlays.Domains.AliasAttribute)') | Determines whether both have the same values. |
| [operator !=(AliasAttribute, AliasAttribute)](AliasAttribute.op_Inequality(AliasAttribute,AliasAttribute).md 'wawa.TwitchPlays.Domains.AliasAttribute.op_Inequality(wawa.TwitchPlays.Domains.AliasAttribute, wawa.TwitchPlays.Domains.AliasAttribute)') | Determines whether both do not have the same values. |
