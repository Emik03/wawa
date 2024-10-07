### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.UnwrapOrDefault<T>(this Maybe<T>) Method

Gives the inner value, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').<p/>`[PublicAPI]`

```csharp
public static T UnwrapOrDefault<T>(this wawa.Optionals.Maybe<T> that)
    where T : struct, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='wawa.Optionals.Maybe.UnwrapOrDefault_T_(thiswawa.Optionals.Maybe_T_).T'></a>

`T`

The type of value stored within [that](Maybe.UnwrapOrDefault{T}(Maybe{T}).md#wawa.Optionals.Maybe.UnwrapOrDefault_T_(thiswawa.Optionals.Maybe_T_).that 'wawa.Optionals.Maybe.UnwrapOrDefault<T>(this wawa.Optionals.Maybe<T>).that').
#### Parameters

<a name='wawa.Optionals.Maybe.UnwrapOrDefault_T_(thiswawa.Optionals.Maybe_T_).that'></a>

`that` [wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.UnwrapOrDefault{T}(Maybe{T}).md#wawa.Optionals.Maybe.UnwrapOrDefault_T_(thiswawa.Optionals.Maybe_T_).T 'wawa.Optionals.Maybe.UnwrapOrDefault<T>(this wawa.Optionals.Maybe<T>).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').

#### Returns
[T](Maybe.UnwrapOrDefault{T}(Maybe{T}).md#wawa.Optionals.Maybe.UnwrapOrDefault_T_(thiswawa.Optionals.Maybe_T_).T 'wawa.Optionals.Maybe.UnwrapOrDefault<T>(this wawa.Optionals.Maybe<T>).T')  
The inner value, or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').