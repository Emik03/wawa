### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.Match<T,TResult>(this Maybe<T>, TResult, TResult) Method

Gives the parameter corresponding to the inner value of [that](Maybe.Match(Maybe,TResult,TResult).md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult,TResult).that 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, TResult, TResult).that').

```csharp
public static TResult Match<T,TResult>(this Wawa.Optionals.Maybe<T> that, TResult some, TResult none);
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult,TResult).T'></a>

`T`

The type of value stored within [that](Maybe.Match(Maybe,TResult,TResult).md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult,TResult).that 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, TResult, TResult).that').

<a name='Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult,TResult).TResult'></a>

`TResult`

The [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') value of both callbacks.
#### Parameters

<a name='Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult,TResult).that'></a>

`that` [Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.Match(Maybe,TResult,TResult).md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult,TResult).T 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, TResult, TResult).T')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').

<a name='Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult,TResult).some'></a>

`some` [TResult](Maybe.Match(Maybe,TResult,TResult).md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult,TResult).TResult 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, TResult, TResult).TResult')

The value to return if [IsSome](Maybe_T_.IsSome().md 'Wawa.Optionals.Maybe<T>.IsSome') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

<a name='Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult,TResult).none'></a>

`none` [TResult](Maybe.Match(Maybe,TResult,TResult).md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult,TResult).TResult 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, TResult, TResult).TResult')

The value to return if [IsSome](Maybe_T_.IsSome().md 'Wawa.Optionals.Maybe<T>.IsSome') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Returns
[TResult](Maybe.Match(Maybe,TResult,TResult).md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult,TResult).TResult 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, TResult, TResult).TResult')  
The corresponding parameter.