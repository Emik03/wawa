### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.AsMaybe<T>(this Nullable<T>) Method

Creates a [System.Nullable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1') from a [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').

```csharp
public static Wawa.Optionals.Maybe<T> AsMaybe<T>(this System.Nullable<T> that)
    where T : struct, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.AsMaybe_T_(thisSystem.Nullable_T_).T'></a>

`T`

The type of parameter and generic in [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').
#### Parameters

<a name='Wawa.Optionals.Maybe.AsMaybe_T_(thisSystem.Nullable_T_).that'></a>

`that` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](Maybe.AsMaybe(Nullable).md#Wawa.Optionals.Maybe.AsMaybe_T_(thisSystem.Nullable_T_).T 'Wawa.Optionals.Maybe.AsMaybe<T>(this System.Nullable<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

This instance of [T](Maybe.AsMaybe(Nullable).md#Wawa.Optionals.Maybe.AsMaybe_T_(thisSystem.Nullable_T_).T 'Wawa.Optionals.Maybe.AsMaybe<T>(this System.Nullable<T>).T').

#### Returns
[Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.AsMaybe(Nullable).md#Wawa.Optionals.Maybe.AsMaybe_T_(thisSystem.Nullable_T_).T 'Wawa.Optionals.Maybe.AsMaybe<T>(this System.Nullable<T>).T')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')  
The [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>') representing [that](Maybe.AsMaybe(Nullable).md#Wawa.Optionals.Maybe.AsMaybe_T_(thisSystem.Nullable_T_).that 'Wawa.Optionals.Maybe.AsMaybe<T>(this System.Nullable<T>).that').

### Remarks
  
This is an extension method for calling [From&lt;T&gt;(T)](Maybe.From(T).md 'Wawa.Optionals.Maybe.From<T>(T)').