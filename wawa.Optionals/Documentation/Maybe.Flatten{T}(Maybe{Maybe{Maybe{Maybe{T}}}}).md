### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.Flatten<T>(this Maybe<Maybe<Maybe<Maybe<T>>>>) Method

Flattens a nested [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').<p/>`[PublicAPI]`

```csharp
public static wawa.Optionals.Maybe<T> Flatten<T>(this wawa.Optionals.Maybe<wawa.Optionals.Maybe<wawa.Optionals.Maybe<wawa.Optionals.Maybe<T>>>> that);
```
#### Type parameters

<a name='wawa.Optionals.Maybe.Flatten_T_(thiswawa.Optionals.Maybe_wawa.Optionals.Maybe_wawa.Optionals.Maybe_wawa.Optionals.Maybe_T____).T'></a>

`T`

The type of value stored within [that](Maybe.Flatten{T}(Maybe{Maybe{Maybe{Maybe{T}}}}).md#wawa.Optionals.Maybe.Flatten_T_(thiswawa.Optionals.Maybe_wawa.Optionals.Maybe_wawa.Optionals.Maybe_wawa.Optionals.Maybe_T____).that 'wawa.Optionals.Maybe.Flatten<T>(this wawa.Optionals.Maybe<wawa.Optionals.Maybe<wawa.Optionals.Maybe<wawa.Optionals.Maybe<T>>>>).that').
#### Parameters

<a name='wawa.Optionals.Maybe.Flatten_T_(thiswawa.Optionals.Maybe_wawa.Optionals.Maybe_wawa.Optionals.Maybe_wawa.Optionals.Maybe_T____).that'></a>

`that` [wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.Flatten{T}(Maybe{Maybe{Maybe{Maybe{T}}}}).md#wawa.Optionals.Maybe.Flatten_T_(thiswawa.Optionals.Maybe_wawa.Optionals.Maybe_wawa.Optionals.Maybe_wawa.Optionals.Maybe_T____).T 'wawa.Optionals.Maybe.Flatten<T>(this wawa.Optionals.Maybe<wawa.Optionals.Maybe<wawa.Optionals.Maybe<wawa.Optionals.Maybe<T>>>>).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')

This instance of [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').

#### Returns
[wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.Flatten{T}(Maybe{Maybe{Maybe{Maybe{T}}}}).md#wawa.Optionals.Maybe.Flatten_T_(thiswawa.Optionals.Maybe_wawa.Optionals.Maybe_wawa.Optionals.Maybe_wawa.Optionals.Maybe_T____).T 'wawa.Optionals.Maybe.Flatten<T>(this wawa.Optionals.Maybe<wawa.Optionals.Maybe<wawa.Optionals.Maybe<wawa.Optionals.Maybe<T>>>>).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')  
The nested [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>'), or [default](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/default').