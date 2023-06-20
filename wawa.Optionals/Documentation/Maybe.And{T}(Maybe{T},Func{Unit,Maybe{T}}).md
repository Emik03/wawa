### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe](Maybe.md 'Wawa.Optionals.Maybe')

## Maybe.And<T>(this Maybe<T>, Func<Unit,Maybe<T>>) Method

Gives itself, or the parameter.

```csharp
public static Wawa.Optionals.Maybe<T> And<T>(this Wawa.Optionals.Maybe<T> that, System.Func<Wawa.Optionals.Unit,Wawa.Optionals.Maybe<T>> otherwise);
```
#### Type parameters

<a name='Wawa.Optionals.Maybe.And_T_(thisWawa.Optionals.Maybe_T_,System.Func_Wawa.Optionals.Unit,Wawa.Optionals.Maybe_T__).T'></a>

`T`

The type of value stored within [that](Maybe.And{T}(Maybe{T},Func{Unit,Maybe{T}}).md#Wawa.Optionals.Maybe.And_T_(thisWawa.Optionals.Maybe_T_,System.Func_Wawa.Optionals.Unit,Wawa.Optionals.Maybe_T__).that 'Wawa.Optionals.Maybe.And<T>(this Wawa.Optionals.Maybe<T>, System.Func<Wawa.Optionals.Unit,Wawa.Optionals.Maybe<T>>).that').
#### Parameters

<a name='Wawa.Optionals.Maybe.And_T_(thisWawa.Optionals.Maybe_T_,System.Func_Wawa.Optionals.Unit,Wawa.Optionals.Maybe_T__).that'></a>

`that` [Wawa.Optionals.Maybe&lt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.And{T}(Maybe{T},Func{Unit,Maybe{T}}).md#Wawa.Optionals.Maybe.And_T_(thisWawa.Optionals.Maybe_T_,System.Func_Wawa.Optionals.Unit,Wawa.Optionals.Maybe_T__).T 'Wawa.Optionals.Maybe.And<T>(this Wawa.Optionals.Maybe<T>, System.Func<Wawa.Optionals.Unit,Wawa.Optionals.Maybe<T>>).T')[&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>').

<a name='Wawa.Optionals.Maybe.And_T_(thisWawa.Optionals.Maybe_T_,System.Func_Wawa.Optionals.Unit,Wawa.Optionals.Maybe_T__).otherwise'></a>

`otherwise` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[Unit](Unit.md 'Wawa.Optionals.Unit')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[Wawa.Optionals.Maybe&lt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.And{T}(Maybe{T},Func{Unit,Maybe{T}}).md#Wawa.Optionals.Maybe.And_T_(thisWawa.Optionals.Maybe_T_,System.Func_Wawa.Optionals.Unit,Wawa.Optionals.Maybe_T__).T 'Wawa.Optionals.Maybe.And<T>(this Wawa.Optionals.Maybe<T>, System.Func<Wawa.Optionals.Unit,Wawa.Optionals.Maybe<T>>).T')[&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The callback to execute if [IsSome](Maybe{T}.IsSome.md 'Wawa.Optionals.Maybe<T>.IsSome') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Returns
[Wawa.Optionals.Maybe&lt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')[T](Maybe.And{T}(Maybe{T},Func{Unit,Maybe{T}}).md#Wawa.Optionals.Maybe.And_T_(thisWawa.Optionals.Maybe_T_,System.Func_Wawa.Optionals.Unit,Wawa.Optionals.Maybe_T__).T 'Wawa.Optionals.Maybe.And<T>(this Wawa.Optionals.Maybe<T>, System.Func<Wawa.Optionals.Unit,Wawa.Optionals.Maybe<T>>).T')[&gt;](Maybe{T}.md 'Wawa.Optionals.Maybe<T>')  
The inner value, or the parameter [otherwise](Maybe.And{T}(Maybe{T},Func{Unit,Maybe{T}}).md#Wawa.Optionals.Maybe.And_T_(thisWawa.Optionals.Maybe_T_,System.Func_Wawa.Optionals.Unit,Wawa.Optionals.Maybe_T__).otherwise 'Wawa.Optionals.Maybe.And<T>(this Wawa.Optionals.Maybe<T>, System.Func<Wawa.Optionals.Unit,Wawa.Optionals.Maybe<T>>).otherwise').