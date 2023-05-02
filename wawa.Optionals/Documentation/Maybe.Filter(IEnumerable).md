### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.Filter<T>(this IEnumerable<Maybe<T>>) Method

Filters a collection with only that of items with a value.

```csharp
public static System.Collections.Generic.IEnumerable<T> Filter<T>(this System.Collections.Generic.IEnumerable<Wawa.Optionals.Maybe<T>> source);
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.Filter_T_(thisSystem.Collections.Generic.IEnumerable_Wawa.Optionals.Maybe_T__).T'></a>

`T`

The type of parameter and generic in [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').
#### Parameters

<a name='Wawa.Optionals.Maybe.Filter_T_(thisSystem.Collections.Generic.IEnumerable_Wawa.Optionals.Maybe_T__).source'></a>

`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.Filter(IEnumerable).md#Wawa.Optionals.Maybe.Filter_T_(thisSystem.Collections.Generic.IEnumerable_Wawa.Optionals.Maybe_T__).T 'Wawa.Optionals.Maybe.Filter<T>(this System.Collections.Generic.IEnumerable<Wawa.Optionals.Maybe<T>>).T')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

This collection of [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Maybe.Filter(IEnumerable).md#Wawa.Optionals.Maybe.Filter_T_(thisSystem.Collections.Generic.IEnumerable_Wawa.Optionals.Maybe_T__).T 'Wawa.Optionals.Maybe.Filter<T>(this System.Collections.Generic.IEnumerable<Wawa.Optionals.Maybe<T>>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A filtered collection only consisting of unwrapped [T](Maybe.Filter(IEnumerable).md#Wawa.Optionals.Maybe.Filter_T_(thisSystem.Collections.Generic.IEnumerable_Wawa.Optionals.Maybe_T__).T 'Wawa.Optionals.Maybe.Filter<T>(this System.Collections.Generic.IEnumerable<Wawa.Optionals.Maybe<T>>).T') values.