### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[Generator](Generator.md 'Wawa.Callbacks.Generator')

## Generator.TrySet<T>(this HookMay<T>, T) Method

Attempts to set the inner value to the parameter [value](Generator.TrySet{T}(HookMay{T},T).md#Wawa.Callbacks.Generator.TrySet_T_(thisWawa.Callbacks.HookMay_T_,T).value 'Wawa.Callbacks.Generator.TrySet<T>(this Wawa.Callbacks.HookMay<T>, T).value').

```csharp
public static bool TrySet<T>(this Wawa.Callbacks.HookMay<T>? that, T value)
    where T : System.Delegate;
```
#### Type parameters

<a name='Wawa.Callbacks.Generator.TrySet_T_(thisWawa.Callbacks.HookMay_T_,T).T'></a>

`T`

The type parameter of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Callbacks.Prop<T>').
#### Parameters

<a name='Wawa.Callbacks.Generator.TrySet_T_(thisWawa.Callbacks.HookMay_T_,T).that'></a>

`that` [Wawa.Callbacks.HookMay&lt;](HookMay{T}.md 'Wawa.Callbacks.HookMay<T>')[T](Generator.TrySet{T}(HookMay{T},T).md#Wawa.Callbacks.Generator.TrySet_T_(thisWawa.Callbacks.HookMay_T_,T).T 'Wawa.Callbacks.Generator.TrySet<T>(this Wawa.Callbacks.HookMay<T>, T).T')[&gt;](HookMay{T}.md 'Wawa.Callbacks.HookMay<T>')

This instance of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Callbacks.Prop<T>').

<a name='Wawa.Callbacks.Generator.TrySet_T_(thisWawa.Callbacks.HookMay_T_,T).value'></a>

`value` [T](Generator.TrySet{T}(HookMay{T},T).md#Wawa.Callbacks.Generator.TrySet_T_(thisWawa.Callbacks.HookMay_T_,T).T 'Wawa.Callbacks.Generator.TrySet<T>(this Wawa.Callbacks.HookMay<T>, T).T')

The value to set the inner value with.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the value set was successful, otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').