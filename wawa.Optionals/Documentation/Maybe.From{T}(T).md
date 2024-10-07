### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe](Maybe.md 'wawa.Optionals.Maybe')

## Maybe.From<T>(T) Method

Wraps [T](Maybe.From{T}(T).md#wawa.Optionals.Maybe.From_T_(T).T 'wawa.Optionals.Maybe.From<T>(T).T') in a [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').<p/>`[PublicAPI]`

```csharp
public static wawa.Optionals.Maybe<T> From<T>(T that)
    where T : class;
```
#### Type parameters

<a name='wawa.Optionals.Maybe.From_T_(T).T'></a>

`T`

The type of parameter and generic in [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').
#### Parameters

<a name='wawa.Optionals.Maybe.From_T_(T).that'></a>

`that` [T](Maybe.From{T}(T).md#wawa.Optionals.Maybe.From_T_(T).T 'wawa.Optionals.Maybe.From<T>(T).T')

This instance of [T](Maybe.From{T}(T).md#wawa.Optionals.Maybe.From_T_(T).T 'wawa.Optionals.Maybe.From<T>(T).T').<p/>`[CanBeNull]`

#### Returns
[wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe.From{T}(T).md#wawa.Optionals.Maybe.From_T_(T).T 'wawa.Optionals.Maybe.From<T>(T).T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')  
A new instance of [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').