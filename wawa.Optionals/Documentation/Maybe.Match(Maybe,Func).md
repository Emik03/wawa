### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.Match<T,TResult>(this Maybe<T>, Func<T,TResult>) Method

Uses the callback corresponding to the inner value of [that](Maybe.Match(Maybe,Func).md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_).that 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, System.Func<T,TResult>).that').

```csharp
public static Wawa.Optionals.Maybe<TResult> Match<T,TResult>(this Wawa.Optionals.Maybe<T> that, System.Func<T,TResult> some);
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_).T'></a>

`T`

The type of value stored within [that](Maybe.Match(Maybe,Func).md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_).that 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, System.Func<T,TResult>).that').

<a name='Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_).TResult'></a>

`TResult`

The [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') value of both callbacks.
#### Parameters

<a name='Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_).that'></a>

`that` [Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.Match(Maybe,Func).md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_).T 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, System.Func<T,TResult>).T')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').

<a name='Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_).some'></a>

`some` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Maybe.Match(Maybe,Func).md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_).T 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, System.Func<T,TResult>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](Maybe.Match(Maybe,Func).md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_).TResult 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, System.Func<T,TResult>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The callback to run if [IsSome](Maybe_T_.IsSome().md 'Wawa.Optionals.Maybe<T>.IsSome') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Returns
[Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[TResult](Maybe.Match(Maybe,Func).md#Wawa.Optionals.Maybe.Match_T,TResult_(thisWawa.Optionals.Maybe_T_,System.Func_T,TResult_).TResult 'Wawa.Optionals.Maybe.Match<T,TResult>(this Wawa.Optionals.Maybe<T>, System.Func<T,TResult>).TResult')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')  
The value returned from the callback, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').