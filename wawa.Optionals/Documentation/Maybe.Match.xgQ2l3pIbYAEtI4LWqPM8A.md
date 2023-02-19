### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.Match<T,TResult>(this Maybe<T>, TResult) Method

Gives the parameter corresponding to the inner value of [that](Maybe.Match.xgQ2l3pIbYAEtI4LWqPM8A.md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult).that 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, TResult).that').

```csharp
public static Wawa.Optionals.Maybe<TResult> Match<T,TResult>(this Wawa.Optionals.Maybe<T> that, TResult some);
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult).T'></a>

`T`

The type of value stored within [that](Maybe.Match.xgQ2l3pIbYAEtI4LWqPM8A.md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult).that 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, TResult).that').

<a name='Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult).TResult'></a>

`TResult`

The [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') value of both callbacks.
#### Parameters

<a name='Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult).that'></a>

`that` [Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.Match.xgQ2l3pIbYAEtI4LWqPM8A.md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult).T 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, TResult).T')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').

<a name='Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult).some'></a>

`some` [TResult](Maybe.Match.xgQ2l3pIbYAEtI4LWqPM8A.md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult).TResult 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, TResult).TResult')

The value to return if [IsSome](Maybe_T_.IsSome.md 'Wawa.Optionals.Maybe<T>.IsSome') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Returns
[Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[TResult](Maybe.Match.xgQ2l3pIbYAEtI4LWqPM8A.md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,TResult).TResult 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, TResult).TResult')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')  
The parameter, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').