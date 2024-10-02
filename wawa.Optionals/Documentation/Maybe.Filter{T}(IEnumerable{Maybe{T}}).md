### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.Filter<T>(this IEnumerable<Maybe<T>>) Method

Filters a collection with only that of items with a value.

```csharp
public static System.Collections.Generic.IEnumerable<T> Filter<T>(this System.Collections.Generic.IEnumerable<wawa.Optionals.Maybe<T>> source);
```
#### Type parameters

<a name='wawa.Optionals.Maybe.Filter_T_(thisSystem.Collections.Generic.IEnumerable_wawa.Optionals.Maybe_T__).T'></a>

`T`

The type of parameter and generic in [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').
#### Parameters

<a name='wawa.Optionals.Maybe.Filter_T_(thisSystem.Collections.Generic.IEnumerable_wawa.Optionals.Maybe_T__).source'></a>

`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.Filter{T}(IEnumerable{Maybe{T}}).md#wawa.Optionals.Maybe.Filter_T_(thisSystem.Collections.Generic.IEnumerable_wawa.Optionals.Maybe_T__).T 'wawa.Optionals.Maybe.Filter<T>(this System.Collections.Generic.IEnumerable<wawa.Optionals.Maybe<T>>).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

This collection of [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Maybe.Filter{T}(IEnumerable{Maybe{T}}).md#wawa.Optionals.Maybe.Filter_T_(thisSystem.Collections.Generic.IEnumerable_wawa.Optionals.Maybe_T__).T 'wawa.Optionals.Maybe.Filter<T>(this System.Collections.Generic.IEnumerable<wawa.Optionals.Maybe<T>>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
A filtered collection only consisting of unwrapped [T](Maybe.Filter{T}(IEnumerable{Maybe{T}}).md#wawa.Optionals.Maybe.Filter_T_(thisSystem.Collections.Generic.IEnumerable_wawa.Optionals.Maybe_T__).T 'wawa.Optionals.Maybe.Filter<T>(this System.Collections.Generic.IEnumerable<wawa.Optionals.Maybe<T>>).T') values.