### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.Match<T>(this Maybe<T>, Action<T>, Action<Unit>) Method

Uses the callback corresponding to the inner value of [that](Maybe.Match(Maybe,Action,Action).md#Wawa.Optionals.Maybe.Match_T_(thisWawa.Optionals.Maybe_T_,System.Action_T_,System.Action_Wawa.Optionals.Unit_).that 'Wawa.Optionals.Maybe.Match<T>(this Wawa.Optionals.Maybe<T>, System.Action<T>, System.Action<Wawa.Optionals.Unit>).that').

```csharp
public static Wawa.Optionals.Maybe<T> Match<T>(this Wawa.Optionals.Maybe<T> that, System.Action<T> some=null, System.Action<Wawa.Optionals.Unit> none=null);
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.Match_T_(thisWawa.Optionals.Maybe_T_,System.Action_T_,System.Action_Wawa.Optionals.Unit_).T'></a>

`T`

The type of value stored within [that](Maybe.Match(Maybe,Action,Action).md#Wawa.Optionals.Maybe.Match_T_(thisWawa.Optionals.Maybe_T_,System.Action_T_,System.Action_Wawa.Optionals.Unit_).that 'Wawa.Optionals.Maybe.Match<T>(this Wawa.Optionals.Maybe<T>, System.Action<T>, System.Action<Wawa.Optionals.Unit>).that').
#### Parameters

<a name='Wawa.Optionals.Maybe.Match_T_(thisWawa.Optionals.Maybe_T_,System.Action_T_,System.Action_Wawa.Optionals.Unit_).that'></a>

`that` [Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.Match(Maybe,Action,Action).md#Wawa.Optionals.Maybe.Match_T_(thisWawa.Optionals.Maybe_T_,System.Action_T_,System.Action_Wawa.Optionals.Unit_).T 'Wawa.Optionals.Maybe.Match<T>(this Wawa.Optionals.Maybe<T>, System.Action<T>, System.Action<Wawa.Optionals.Unit>).T')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').

<a name='Wawa.Optionals.Maybe.Match_T_(thisWawa.Optionals.Maybe_T_,System.Action_T_,System.Action_Wawa.Optionals.Unit_).some'></a>

`some` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](Maybe.Match(Maybe,Action,Action).md#Wawa.Optionals.Maybe.Match_T_(thisWawa.Optionals.Maybe_T_,System.Action_T_,System.Action_Wawa.Optionals.Unit_).T 'Wawa.Optionals.Maybe.Match<T>(this Wawa.Optionals.Maybe<T>, System.Action<T>, System.Action<Wawa.Optionals.Unit>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The callback to run if [IsSome](Maybe_T_.IsSome().md 'Wawa.Optionals.Maybe<T>.IsSome') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

<a name='Wawa.Optionals.Maybe.Match_T_(thisWawa.Optionals.Maybe_T_,System.Action_T_,System.Action_Wawa.Optionals.Unit_).none'></a>

`none` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[Unit](Unit.md 'Wawa.Optionals.Unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The callback to run if [IsSome](Maybe_T_.IsSome().md 'Wawa.Optionals.Maybe<T>.IsSome') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Returns
[Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.Match(Maybe,Action,Action).md#Wawa.Optionals.Maybe.Match_T_(thisWawa.Optionals.Maybe_T_,System.Action_T_,System.Action_Wawa.Optionals.Unit_).T 'Wawa.Optionals.Maybe.Match<T>(this Wawa.Optionals.Maybe<T>, System.Action<T>, System.Action<Wawa.Optionals.Unit>).T')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')  
The parameter [that](Maybe.Match(Maybe,Action,Action).md#Wawa.Optionals.Maybe.Match_T_(thisWawa.Optionals.Maybe_T_,System.Action_T_,System.Action_Wawa.Optionals.Unit_).that 'Wawa.Optionals.Maybe.Match<T>(this Wawa.Optionals.Maybe<T>, System.Action<T>, System.Action<Wawa.Optionals.Unit>).that').