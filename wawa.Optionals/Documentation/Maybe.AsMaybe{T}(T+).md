### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.AsMaybe<T>(this Nullable<T>) Method

Creates a [System.Nullable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1') from a [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').

```csharp
public static wawa.Optionals.Maybe<T> AsMaybe<T>(this System.Nullable<T> that)
    where T : struct, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='wawa.Optionals.Maybe.AsMaybe_T_(thisSystem.Nullable_T_).T'></a>

`T`

The type of parameter and generic in [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').
#### Parameters

<a name='wawa.Optionals.Maybe.AsMaybe_T_(thisSystem.Nullable_T_).that'></a>

`that` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](Maybe.AsMaybe{T}(T+).md#wawa.Optionals.Maybe.AsMaybe_T_(thisSystem.Nullable_T_).T 'wawa.Optionals.Maybe.AsMaybe<T>(this System.Nullable<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

This instance of [T](Maybe.AsMaybe{T}(T+).md#wawa.Optionals.Maybe.AsMaybe_T_(thisSystem.Nullable_T_).T 'wawa.Optionals.Maybe.AsMaybe<T>(this System.Nullable<T>).T').

#### Returns
[wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.AsMaybe{T}(T+).md#wawa.Optionals.Maybe.AsMaybe_T_(thisSystem.Nullable_T_).T 'wawa.Optionals.Maybe.AsMaybe<T>(this System.Nullable<T>).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')  
The [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>') representing [that](Maybe.AsMaybe{T}(T+).md#wawa.Optionals.Maybe.AsMaybe_T_(thisSystem.Nullable_T_).that 'wawa.Optionals.Maybe.AsMaybe<T>(this System.Nullable<T>).that').

### Remarks
  
This is an extension method for calling [From&lt;T&gt;(T)](Maybe.From{T}(T).md 'wawa.Optionals.Maybe.From<T>(T)').