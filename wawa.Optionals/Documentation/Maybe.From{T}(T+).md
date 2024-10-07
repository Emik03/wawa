### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.From<T>(Nullable<T>) Method

Wraps [T](Maybe.From{T}(T+).md#wawa.Optionals.Maybe.From_T_(System.Nullable_T_).T 'wawa.Optionals.Maybe.From<T>(System.Nullable<T>).T') in a [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').<p/>`[PublicAPI]`

```csharp
public static wawa.Optionals.Maybe<T> From<T>(System.Nullable<T> that)
    where T : struct, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='wawa.Optionals.Maybe.From_T_(System.Nullable_T_).T'></a>

`T`

The type of parameter and generic in [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').
#### Parameters

<a name='wawa.Optionals.Maybe.From_T_(System.Nullable_T_).that'></a>

`that` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](Maybe.From{T}(T+).md#wawa.Optionals.Maybe.From_T_(System.Nullable_T_).T 'wawa.Optionals.Maybe.From<T>(System.Nullable<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

This instance of [T](Maybe.From{T}(T+).md#wawa.Optionals.Maybe.From_T_(System.Nullable_T_).T 'wawa.Optionals.Maybe.From<T>(System.Nullable<T>).T').

#### Returns
[wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.From{T}(T+).md#wawa.Optionals.Maybe.From_T_(System.Nullable_T_).T 'wawa.Optionals.Maybe.From<T>(System.Nullable<T>).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')  
A new instance of [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').