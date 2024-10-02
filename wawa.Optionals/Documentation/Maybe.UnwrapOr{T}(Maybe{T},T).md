### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.UnwrapOr<T>(this Maybe<T>, T) Method

Gives the inner value, or the parameter.

```csharp
public static T UnwrapOr<T>(this wawa.Optionals.Maybe<T> that, T otherwise);
```
#### Type parameters

<a name='wawa.Optionals.Maybe.UnwrapOr_T_(thiswawa.Optionals.Maybe_T_,T).T'></a>

`T`

The type of value stored within [that](Maybe.UnwrapOr{T}(Maybe{T},T).md#wawa.Optionals.Maybe.UnwrapOr_T_(thiswawa.Optionals.Maybe_T_,T).that 'wawa.Optionals.Maybe.UnwrapOr<T>(this wawa.Optionals.Maybe<T>, T).that').
#### Parameters

<a name='wawa.Optionals.Maybe.UnwrapOr_T_(thiswawa.Optionals.Maybe_T_,T).that'></a>

`that` [wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.UnwrapOr{T}(Maybe{T},T).md#wawa.Optionals.Maybe.UnwrapOr_T_(thiswawa.Optionals.Maybe_T_,T).T 'wawa.Optionals.Maybe.UnwrapOr<T>(this wawa.Optionals.Maybe<T>, T).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').

<a name='wawa.Optionals.Maybe.UnwrapOr_T_(thiswawa.Optionals.Maybe_T_,T).otherwise'></a>

`otherwise` [T](Maybe.UnwrapOr{T}(Maybe{T},T).md#wawa.Optionals.Maybe.UnwrapOr_T_(thiswawa.Optionals.Maybe_T_,T).T 'wawa.Optionals.Maybe.UnwrapOr<T>(this wawa.Optionals.Maybe<T>, T).T')

The value to return if [IsSome](Maybe{T}.IsSome.md 'wawa.Optionals.Maybe<T>.IsSome') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Returns
[T](Maybe.UnwrapOr{T}(Maybe{T},T).md#wawa.Optionals.Maybe.UnwrapOr_T_(thiswawa.Optionals.Maybe_T_,T).T 'wawa.Optionals.Maybe.UnwrapOr<T>(this wawa.Optionals.Maybe<T>, T).T')  
The inner value, or the parameter [otherwise](Maybe.UnwrapOr{T}(Maybe{T},T).md#wawa.Optionals.Maybe.UnwrapOr_T_(thiswawa.Optionals.Maybe_T_,T).otherwise 'wawa.Optionals.Maybe.UnwrapOr<T>(this wawa.Optionals.Maybe<T>, T).otherwise').