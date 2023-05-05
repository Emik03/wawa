### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.AsNullable<T>(this Maybe<T>) Method

Creates a [Maybe&lt;T&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>') from a [System.Nullable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1').

```csharp
public static System.Nullable<T> AsNullable<T>(this Wawa.Optionals.Maybe<T> that)
    where T : struct, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.AsNullable_T_(thisWawa.Optionals.Maybe_T_).T'></a>

`T`

The type of parameter and generic in [System.Nullable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1').
#### Parameters

<a name='Wawa.Optionals.Maybe.AsNullable_T_(thisWawa.Optionals.Maybe_T_).that'></a>

`that` [Wawa.Optionals.Maybe&lt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.AsNullable{T}(Maybe{T}).md#Wawa.Optionals.Maybe.AsNullable_T_(thisWawa.Optionals.Maybe_T_).T 'Wawa.Optionals.Maybe.AsNullable<T>(this Wawa.Optionals.Maybe<T>).T')[&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')

This instance of [T](Maybe.AsNullable{T}(Maybe{T}).md#Wawa.Optionals.Maybe.AsNullable_T_(thisWawa.Optionals.Maybe_T_).T 'Wawa.Optionals.Maybe.AsNullable<T>(this Wawa.Optionals.Maybe<T>).T').

#### Returns
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](Maybe.AsNullable{T}(Maybe{T}).md#Wawa.Optionals.Maybe.AsNullable_T_(thisWawa.Optionals.Maybe_T_).T 'Wawa.Optionals.Maybe.AsNullable<T>(this Wawa.Optionals.Maybe<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The [System.Nullable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1') representing [that](Maybe.AsNullable{T}(Maybe{T}).md#Wawa.Optionals.Maybe.AsNullable_T_(thisWawa.Optionals.Maybe_T_).that 'Wawa.Optionals.Maybe.AsNullable<T>(this Wawa.Optionals.Maybe<T>).that').

### Remarks
  
This is an extension method for a ternary [IsSome](Maybe{T}.IsSome.md 'Wawa.Optionals.Maybe<T>.IsSome').