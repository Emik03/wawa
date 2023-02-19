### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.From<T>(Nullable<T>) Method

Wraps [T](Maybe.From.mHwYLGGFoysvlB1kaVyKhA.md#Wawa.Optionals.Maybe.From_T_(System.Nullable_T_).T 'Wawa.Optionals.Maybe.From<T>(System.Nullable<T>).T') in a [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').

```csharp
public static Wawa.Optionals.Maybe<T> From<T>(System.Nullable<T> that)
    where T : struct, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.From_T_(System.Nullable_T_).T'></a>

`T`

The type of parameter and generic in [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').
#### Parameters

<a name='Wawa.Optionals.Maybe.From_T_(System.Nullable_T_).that'></a>

`that` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](Maybe.From.mHwYLGGFoysvlB1kaVyKhA.md#Wawa.Optionals.Maybe.From_T_(System.Nullable_T_).T 'Wawa.Optionals.Maybe.From<T>(System.Nullable<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

This instance of [T](Maybe.From.mHwYLGGFoysvlB1kaVyKhA.md#Wawa.Optionals.Maybe.From_T_(System.Nullable_T_).T 'Wawa.Optionals.Maybe.From<T>(System.Nullable<T>).T').

#### Returns
[Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.From.mHwYLGGFoysvlB1kaVyKhA.md#Wawa.Optionals.Maybe.From_T_(System.Nullable_T_).T 'Wawa.Optionals.Maybe.From<T>(System.Nullable<T>).T')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')  
A new instance of [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').