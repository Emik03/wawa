### [Wawa.Modules](Wawa.Modules.md 'Wawa.Modules').[Stringifier](Stringifier.md 'Wawa.Modules.Stringifier')

## Stringifier.Conjoin<T>(IEnumerable<T>, char) Method

Joins a set of values into one long [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').

```csharp
public static string Conjoin<T>(System.Collections.Generic.IEnumerable<T> values, char separator);
```
#### Type parameters

<a name='Wawa.Modules.Stringifier.Conjoin_T_(System.Collections.Generic.IEnumerable_T_,char).T'></a>

`T`

The type of each item in the collection.
#### Parameters

<a name='Wawa.Modules.Stringifier.Conjoin_T_(System.Collections.Generic.IEnumerable_T_,char).values'></a>

`values` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Stringifier.Conjoin(IEnumerable,Char).md#Wawa.Modules.Stringifier.Conjoin_T_(System.Collections.Generic.IEnumerable_T_,char).T 'Wawa.Modules.Stringifier.Conjoin<T>(System.Collections.Generic.IEnumerable<T>, char).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The values to join.

<a name='Wawa.Modules.Stringifier.Conjoin_T_(System.Collections.Generic.IEnumerable_T_,char).separator'></a>

`separator` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The separator between each item.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
One long [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').

### Remarks
  
This method is more efficient than using  
[Conjoin&lt;T&gt;(IEnumerable&lt;T&gt;, string)](Stringifier.Conjoin(IEnumerable,String).md 'Wawa.Modules.Stringifier.Conjoin<T>(System.Collections.Generic.IEnumerable<T>, string)') for [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char') separators.