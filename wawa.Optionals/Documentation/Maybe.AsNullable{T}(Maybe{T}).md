### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.AsNullable<T>(this Maybe<T>) Method

Creates a [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>') from a [System.Nullable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1').<p/>`[PublicAPI]`

```csharp
public static System.Nullable<T> AsNullable<T>(this wawa.Optionals.Maybe<T> that)
    where T : struct, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='wawa.Optionals.Maybe.AsNullable_T_(thiswawa.Optionals.Maybe_T_).T'></a>

`T`

The type of parameter and generic in [System.Nullable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1').
#### Parameters

<a name='wawa.Optionals.Maybe.AsNullable_T_(thiswawa.Optionals.Maybe_T_).that'></a>

`that` [wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.AsNullable{T}(Maybe{T}).md#wawa.Optionals.Maybe.AsNullable_T_(thiswawa.Optionals.Maybe_T_).T 'wawa.Optionals.Maybe.AsNullable<T>(this wawa.Optionals.Maybe<T>).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')

This instance of [T](Maybe.AsNullable{T}(Maybe{T}).md#wawa.Optionals.Maybe.AsNullable_T_(thiswawa.Optionals.Maybe_T_).T 'wawa.Optionals.Maybe.AsNullable<T>(this wawa.Optionals.Maybe<T>).T').

#### Returns
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](Maybe.AsNullable{T}(Maybe{T}).md#wawa.Optionals.Maybe.AsNullable_T_(thiswawa.Optionals.Maybe_T_).T 'wawa.Optionals.Maybe.AsNullable<T>(this wawa.Optionals.Maybe<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The [System.Nullable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1') representing [that](Maybe.AsNullable{T}(Maybe{T}).md#wawa.Optionals.Maybe.AsNullable_T_(thiswawa.Optionals.Maybe_T_).that 'wawa.Optionals.Maybe.AsNullable<T>(this wawa.Optionals.Maybe<T>).that').

### Remarks
  
This is an extension method for a ternary [IsSome](Maybe{T}.IsSome.md 'wawa.Optionals.Maybe<T>.IsSome').