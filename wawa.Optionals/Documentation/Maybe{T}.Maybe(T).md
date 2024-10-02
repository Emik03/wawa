### [wawa.Optionals](wawa.Optionals.md 'wawa.Optionals').[Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')

## Maybe<T>.implicit operator Maybe<T>(T) Operator

Converts the [T](Maybe{T}.md#wawa.Optionals.Maybe_T_.T 'wawa.Optionals.Maybe<T>.T') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>').

```csharp
public static wawa.Optionals.Maybe<T> implicit operator Maybe<T>(T value);
```
#### Parameters

<a name='wawa.Optionals.Maybe_T_.op_Implicitwawa.Optionals.Maybe_T_(T).value'></a>

`value` [T](Maybe{T}.md#wawa.Optionals.Maybe_T_.T 'wawa.Optionals.Maybe<T>.T')

The [T](Maybe{T}.md#wawa.Optionals.Maybe_T_.T 'wawa.Optionals.Maybe<T>.T') instance to convert.

#### Returns
[wawa.Optionals.Maybe&lt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')[T](Maybe{T}.md#wawa.Optionals.Maybe_T_.T 'wawa.Optionals.Maybe<T>.T')[&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>')  
A [Maybe&lt;T&gt;](Maybe{T}.md 'wawa.Optionals.Maybe<T>') that is Some or None depending on  
whether [value](Maybe{T}.Maybe(T).md#wawa.Optionals.Maybe_T_.op_Implicitwawa.Optionals.Maybe_T_(T).value 'wawa.Optionals.Maybe<T>.op_Implicit wawa.Optionals.Maybe<T>(T).value') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').