### [Wawa.Modules](Wawa.Modules.md 'Wawa.Modules').[Stringifier](Stringifier.md 'Wawa.Modules.Stringifier')

## Stringifier.Conjoin<T>(IEnumerable<T>, string) Method

Joins a set of values into one long [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').

```csharp
public static string Conjoin<T>(System.Collections.Generic.IEnumerable<T> values, string separator=", ");
```
#### Type parameters

<a name='Wawa.Modules.Stringifier.Conjoin_T_(System.Collections.Generic.IEnumerable_T_,string).T'></a>

`T`

The type of each item in the collection.
#### Parameters

<a name='Wawa.Modules.Stringifier.Conjoin_T_(System.Collections.Generic.IEnumerable_T_,string).values'></a>

`values` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Stringifier.Conjoin(IEnumerable,String).md#Wawa.Modules.Stringifier.Conjoin_T_(System.Collections.Generic.IEnumerable_T_,string).T 'Wawa.Modules.Stringifier.Conjoin<T>(System.Collections.Generic.IEnumerable<T>, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The values to join.

<a name='Wawa.Modules.Stringifier.Conjoin_T_(System.Collections.Generic.IEnumerable_T_,string).separator'></a>

`separator` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The separator between each item.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
One long [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').