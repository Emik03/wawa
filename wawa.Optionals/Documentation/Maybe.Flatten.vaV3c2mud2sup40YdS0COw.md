### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.Flatten<T>(this Maybe<Maybe<T>>) Method

Flattens a nested [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').

```csharp
public static Wawa.Optionals.Maybe<T> Flatten<T>(this Wawa.Optionals.Maybe<Wawa.Optionals.Maybe<T>> that);
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.Flatten_T_(thisWawa.Optionals.Maybe_Wawa.Optionals.Maybe_T__).T'></a>

`T`

The type of value stored within [that](Maybe.Flatten.vaV3c2mud2sup40YdS0COw.md#Wawa.Optionals.Maybe.Flatten_T_(thisWawa.Optionals.Maybe_Wawa.Optionals.Maybe_T__).that 'Wawa.Optionals.Maybe.Flatten<T>(this Wawa.Optionals.Maybe<Wawa.Optionals.Maybe<T>>).that').
#### Parameters

<a name='Wawa.Optionals.Maybe.Flatten_T_(thisWawa.Optionals.Maybe_Wawa.Optionals.Maybe_T__).that'></a>

`that` [Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.Flatten.vaV3c2mud2sup40YdS0COw.md#Wawa.Optionals.Maybe.Flatten_T_(thisWawa.Optionals.Maybe_Wawa.Optionals.Maybe_T__).T 'Wawa.Optionals.Maybe.Flatten<T>(this Wawa.Optionals.Maybe<Wawa.Optionals.Maybe<T>>).T')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').

#### Returns
[Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.Flatten.vaV3c2mud2sup40YdS0COw.md#Wawa.Optionals.Maybe.Flatten_T_(thisWawa.Optionals.Maybe_Wawa.Optionals.Maybe_T__).T 'Wawa.Optionals.Maybe.Flatten<T>(this Wawa.Optionals.Maybe<Wawa.Optionals.Maybe<T>>).T')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')  
The nested [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>'), or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').