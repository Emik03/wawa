### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[Generator](Generator.md 'Wawa.Callbacks.Generator')

## Generator.TrySet<T>(this PropMay<T>, T) Method

Attempts to set the inner value to the parameter [value](Generator.TrySet{T}(PropMay{T},T).md#Wawa.Callbacks.Generator.TrySet_T_(thisWawa.Callbacks.PropMay_T_,T).value 'Wawa.Callbacks.Generator.TrySet<T>(this Wawa.Callbacks.PropMay<T>, T).value').

```csharp
public static bool TrySet<T>(this Wawa.Callbacks.PropMay<T>? that, T value);
```
#### Type parameters

<a name='Wawa.Callbacks.Generator.TrySet_T_(thisWawa.Callbacks.PropMay_T_,T).T'></a>

`T`

The type parameter of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Callbacks.Prop<T>').
#### Parameters

<a name='Wawa.Callbacks.Generator.TrySet_T_(thisWawa.Callbacks.PropMay_T_,T).that'></a>

`that` [Wawa.Callbacks.PropMay&lt;](PropMay{T}.md 'Wawa.Callbacks.PropMay<T>')[T](Generator.TrySet{T}(PropMay{T},T).md#Wawa.Callbacks.Generator.TrySet_T_(thisWawa.Callbacks.PropMay_T_,T).T 'Wawa.Callbacks.Generator.TrySet<T>(this Wawa.Callbacks.PropMay<T>, T).T')[&gt;](PropMay{T}.md 'Wawa.Callbacks.PropMay<T>')

This instance of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Callbacks.Prop<T>').

<a name='Wawa.Callbacks.Generator.TrySet_T_(thisWawa.Callbacks.PropMay_T_,T).value'></a>

`value` [T](Generator.TrySet{T}(PropMay{T},T).md#Wawa.Callbacks.Generator.TrySet_T_(thisWawa.Callbacks.PropMay_T_,T).T 'Wawa.Callbacks.Generator.TrySet<T>(this Wawa.Callbacks.PropMay<T>, T).T')

The value to set the inner value with.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the value set was successful, otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').