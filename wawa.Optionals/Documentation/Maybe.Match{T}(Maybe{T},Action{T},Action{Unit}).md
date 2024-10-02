### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.Match<T>(this Maybe<T>, Action<T>, Action<Unit>) Method

Uses the callback corresponding to the inner value of [that](Maybe.Match{T}(Maybe{T},Action{T},Action{Unit}).md#wawa.Optionals.Maybe.Match_T_(thiswawa.Optionals.Maybe_T_,System.Action_T_,System.Action_wawa.Optionals.Unit_).that 'wawa.Optionals.Maybe.Match<T>(this wawa.Optionals.Maybe<T>, System.Action<T>, System.Action<wawa.Optionals.Unit>).that').

```csharp
public static wawa.Optionals.Maybe<T> Match<T>(this wawa.Optionals.Maybe<T> that, System.Action<T> some=null, System.Action<wawa.Optionals.Unit> none=null);
```
#### Type parameters

<a name='wawa.Optionals.Maybe.Match_T_(thiswawa.Optionals.Maybe_T_,System.Action_T_,System.Action_wawa.Optionals.Unit_).T'></a>

`T`

The type of value stored within [that](Maybe.Match{T}(Maybe{T},Action{T},Action{Unit}).md#wawa.Optionals.Maybe.Match_T_(thiswawa.Optionals.Maybe_T_,System.Action_T_,System.Action_wawa.Optionals.Unit_).that 'wawa.Optionals.Maybe.Match<T>(this wawa.Optionals.Maybe<T>, System.Action<T>, System.Action<wawa.Optionals.Unit>).that').
#### Parameters

<a name='wawa.Optionals.Maybe.Match_T_(thiswawa.Optionals.Maybe_T_,System.Action_T_,System.Action_wawa.Optionals.Unit_).that'></a>

`that` [wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.Match{T}(Maybe{T},Action{T},Action{Unit}).md#wawa.Optionals.Maybe.Match_T_(thiswawa.Optionals.Maybe_T_,System.Action_T_,System.Action_wawa.Optionals.Unit_).T 'wawa.Optionals.Maybe.Match<T>(this wawa.Optionals.Maybe<T>, System.Action<T>, System.Action<wawa.Optionals.Unit>).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').

<a name='wawa.Optionals.Maybe.Match_T_(thiswawa.Optionals.Maybe_T_,System.Action_T_,System.Action_wawa.Optionals.Unit_).some'></a>

`some` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](Maybe.Match{T}(Maybe{T},Action{T},Action{Unit}).md#wawa.Optionals.Maybe.Match_T_(thiswawa.Optionals.Maybe_T_,System.Action_T_,System.Action_wawa.Optionals.Unit_).T 'wawa.Optionals.Maybe.Match<T>(this wawa.Optionals.Maybe<T>, System.Action<T>, System.Action<wawa.Optionals.Unit>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The callback to run if [IsSome](Maybe{T}.IsSome.md 'wawa.Optionals.Maybe<T>.IsSome') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

<a name='wawa.Optionals.Maybe.Match_T_(thiswawa.Optionals.Maybe_T_,System.Action_T_,System.Action_wawa.Optionals.Unit_).none'></a>

`none` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[Unit](Unit.md 'wawa.Optionals.Unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The callback to run if [IsSome](Maybe{T}.IsSome.md 'wawa.Optionals.Maybe<T>.IsSome') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Returns
[wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.Match{T}(Maybe{T},Action{T},Action{Unit}).md#wawa.Optionals.Maybe.Match_T_(thiswawa.Optionals.Maybe_T_,System.Action_T_,System.Action_wawa.Optionals.Unit_).T 'wawa.Optionals.Maybe.Match<T>(this wawa.Optionals.Maybe<T>, System.Action<T>, System.Action<wawa.Optionals.Unit>).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')  
The parameter [that](Maybe.Match{T}(Maybe{T},Action{T},Action{Unit}).md#wawa.Optionals.Maybe.Match_T_(thiswawa.Optionals.Maybe_T_,System.Action_T_,System.Action_wawa.Optionals.Unit_).that 'wawa.Optionals.Maybe.Match<T>(this wawa.Optionals.Maybe<T>, System.Action<T>, System.Action<wawa.Optionals.Unit>).that').