### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.Xor<T>(this Maybe<T>, Maybe<T>) Method

Gives itself, or the parameter.

```csharp
public static Wawa.Optionals.Maybe<T> Xor<T>(this Wawa.Optionals.Maybe<T> that, Wawa.Optionals.Maybe<T> otherwise);
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.Xor_T_(thisWawa.Optionals.Maybe_T_,Wawa.Optionals.Maybe_T_).T'></a>

`T`

The type of value stored within [that](Maybe.Xor{T}(Maybe{T},Maybe{T}).md#Wawa.Optionals.Maybe.Xor_T_(thisWawa.Optionals.Maybe_T_,Wawa.Optionals.Maybe_T_).that 'Wawa.Optionals.Maybe.Xor<T>(this Wawa.Optionals.Maybe<T>, Wawa.Optionals.Maybe<T>).that').
#### Parameters

<a name='Wawa.Optionals.Maybe.Xor_T_(thisWawa.Optionals.Maybe_T_,Wawa.Optionals.Maybe_T_).that'></a>

`that` [Wawa.Optionals.Maybe&lt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.Xor{T}(Maybe{T},Maybe{T}).md#Wawa.Optionals.Maybe.Xor_T_(thisWawa.Optionals.Maybe_T_,Wawa.Optionals.Maybe_T_).T 'Wawa.Optionals.Maybe.Xor<T>(this Wawa.Optionals.Maybe<T>, Wawa.Optionals.Maybe<T>).T')[&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>').

<a name='Wawa.Optionals.Maybe.Xor_T_(thisWawa.Optionals.Maybe_T_,Wawa.Optionals.Maybe_T_).otherwise'></a>

`otherwise` [Wawa.Optionals.Maybe&lt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.Xor{T}(Maybe{T},Maybe{T}).md#Wawa.Optionals.Maybe.Xor_T_(thisWawa.Optionals.Maybe_T_,Wawa.Optionals.Maybe_T_).T 'Wawa.Optionals.Maybe.Xor<T>(this Wawa.Optionals.Maybe<T>, Wawa.Optionals.Maybe<T>).T')[&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')

The value to return if [IsSome](Maybe{T}.IsSome.md 'Wawa.Optionals.Maybe<T>.IsSome') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Returns
[Wawa.Optionals.Maybe&lt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.Xor{T}(Maybe{T},Maybe{T}).md#Wawa.Optionals.Maybe.Xor_T_(thisWawa.Optionals.Maybe_T_,Wawa.Optionals.Maybe_T_).T 'Wawa.Optionals.Maybe.Xor<T>(this Wawa.Optionals.Maybe<T>, Wawa.Optionals.Maybe<T>).T')[&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')  
The inner value, or the parameter [otherwise](Maybe.Xor{T}(Maybe{T},Maybe{T}).md#Wawa.Optionals.Maybe.Xor_T_(thisWawa.Optionals.Maybe_T_,Wawa.Optionals.Maybe_T_).otherwise 'Wawa.Optionals.Maybe.Xor<T>(this Wawa.Optionals.Maybe<T>, Wawa.Optionals.Maybe<T>).otherwise').