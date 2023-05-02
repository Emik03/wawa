### [Wawa.Optionals](Wawa.Optionals.md 'Wawa.Optionals').[Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')

## Maybe<T>.implicit operator Maybe<T>(T) Operator

Converts the [T](Maybe_T_.md#Wawa.Optionals.Maybe_T_.T 'Wawa.Optionals.Maybe<T>.T') to a [new](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new')[Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>').

```csharp
public static Wawa.Optionals.Maybe<T> implicit operator Maybe<T>(T value);
```
#### Parameters

<a name='Wawa.Optionals.Maybe_T_.op_ImplicitWawa.Optionals.Maybe_T_(T).value'></a>

`value` [T](Maybe_T_.md#Wawa.Optionals.Maybe_T_.T 'Wawa.Optionals.Maybe<T>.T')

The [T](Maybe_T_.md#Wawa.Optionals.Maybe_T_.T 'Wawa.Optionals.Maybe<T>.T') instance to convert.

#### Returns
[Wawa.Optionals.Maybe&lt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')[T](Maybe_T_.md#Wawa.Optionals.Maybe_T_.T 'Wawa.Optionals.Maybe<T>.T')[&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>')  
A [Maybe&lt;T&gt;](Maybe_T_.md 'Wawa.Optionals.Maybe<T>') that is Some or None depending on  
whether [value](Maybe_T_.op_Implicit(T).md#Wawa.Optionals.Maybe_T_.op_ImplicitWawa.Optionals.Maybe_T_(T).value 'Wawa.Optionals.Maybe<T>.op_Implicit Wawa.Optionals.Maybe<T>(T).value') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').