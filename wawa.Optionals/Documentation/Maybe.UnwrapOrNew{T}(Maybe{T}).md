### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.UnwrapOrNew<T>(this Maybe<T>) Method

Gives the inner value, or a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new') instance.

```csharp
public static T UnwrapOrNew<T>(this wawa.Optionals.Maybe<T> that)
    where T : new();
```
#### Type parameters

<a name='wawa.Optionals.Maybe.UnwrapOrNew_T_(thiswawa.Optionals.Maybe_T_).T'></a>

`T`

The type of value stored within [that](Maybe.UnwrapOrNew{T}(Maybe{T}).md#wawa.Optionals.Maybe.UnwrapOrNew_T_(thiswawa.Optionals.Maybe_T_).that 'wawa.Optionals.Maybe.UnwrapOrNew<T>(this wawa.Optionals.Maybe<T>).that').
#### Parameters

<a name='wawa.Optionals.Maybe.UnwrapOrNew_T_(thiswawa.Optionals.Maybe_T_).that'></a>

`that` [wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.UnwrapOrNew{T}(Maybe{T}).md#wawa.Optionals.Maybe.UnwrapOrNew_T_(thiswawa.Optionals.Maybe_T_).T 'wawa.Optionals.Maybe.UnwrapOrNew<T>(this wawa.Optionals.Maybe<T>).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').

#### Returns
[T](Maybe.UnwrapOrNew{T}(Maybe{T}).md#wawa.Optionals.Maybe.UnwrapOrNew_T_(thiswawa.Optionals.Maybe_T_).T 'wawa.Optionals.Maybe.UnwrapOrNew<T>(this wawa.Optionals.Maybe<T>).T')  
The inner value, or a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new') instance.