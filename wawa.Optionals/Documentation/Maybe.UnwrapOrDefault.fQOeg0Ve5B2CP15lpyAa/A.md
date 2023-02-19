### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.UnwrapOrDefault<T>(this Maybe<T>) Method

Gives the inner value, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').

```csharp
public static T UnwrapOrDefault<T>(this Wawa.Optionals.Maybe<T> that)
    where T : struct, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.UnwrapOrDefault_T_(thisWawa.Optionals.Maybe_T_).T'></a>

`T`

The type of value stored within [that](Maybe.UnwrapOrDefault.fQOeg0Ve5B2CP15lpyAa/A.md#Wawa.Optionals.Maybe.UnwrapOrDefault_T_(thisWawa.Optionals.Maybe_T_).that 'Wawa.Optionals.Maybe.UnwrapOrDefault<T>(this Wawa.Optionals.Maybe<T>).that').
#### Parameters

<a name='Wawa.Optionals.Maybe.UnwrapOrDefault_T_(thisWawa.Optionals.Maybe_T_).that'></a>

`that` [Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.UnwrapOrDefault.fQOeg0Ve5B2CP15lpyAa/A.md#Wawa.Optionals.Maybe.UnwrapOrDefault_T_(thisWawa.Optionals.Maybe_T_).T 'Wawa.Optionals.Maybe.UnwrapOrDefault<T>(this Wawa.Optionals.Maybe<T>).T')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').

#### Returns
[T](Maybe.UnwrapOrDefault.fQOeg0Ve5B2CP15lpyAa/A.md#Wawa.Optionals.Maybe.UnwrapOrDefault_T_(thisWawa.Optionals.Maybe_T_).T 'Wawa.Optionals.Maybe.UnwrapOrDefault<T>(this Wawa.Optionals.Maybe<T>).T')  
The inner value, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').