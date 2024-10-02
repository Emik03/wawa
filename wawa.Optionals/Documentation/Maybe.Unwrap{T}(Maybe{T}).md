### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.Unwrap<T>(this Maybe<T>) Method

Gets the value that is encapsulated. This value returned will not be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'),  
and consequentially if it is.

```csharp
public static T Unwrap<T>(this wawa.Optionals.Maybe<T> that);
```
#### Type parameters

<a name='wawa.Optionals.Maybe.Unwrap_T_(thiswawa.Optionals.Maybe_T_).T'></a>

`T`

The type of value stored within [that](Maybe.Unwrap{T}(Maybe{T}).md#wawa.Optionals.Maybe.Unwrap_T_(thiswawa.Optionals.Maybe_T_).that 'wawa.Optionals.Maybe.Unwrap<T>(this wawa.Optionals.Maybe<T>).that').
#### Parameters

<a name='wawa.Optionals.Maybe.Unwrap_T_(thiswawa.Optionals.Maybe_T_).that'></a>

`that` [wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.Unwrap{T}(Maybe{T}).md#wawa.Optionals.Maybe.Unwrap_T_(thiswawa.Optionals.Maybe_T_).T 'wawa.Optionals.Maybe.Unwrap<T>(this wawa.Optionals.Maybe<T>).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').

#### Returns
[T](Maybe.Unwrap{T}(Maybe{T}).md#wawa.Optionals.Maybe.Unwrap_T_(thiswawa.Optionals.Maybe_T_).T 'wawa.Optionals.Maybe.Unwrap<T>(this wawa.Optionals.Maybe<T>).T')  
The inner value.

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
The parameter [that](Maybe.Unwrap{T}(Maybe{T}).md#wawa.Optionals.Maybe.Unwrap_T_(thiswawa.Optionals.Maybe_T_).that 'wawa.Optionals.Maybe.Unwrap<T>(this wawa.Optionals.Maybe<T>).that') has [IsSome](Maybe{T}.IsSome.md 'wawa.Optionals.Maybe<T>.IsSome') set to [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').