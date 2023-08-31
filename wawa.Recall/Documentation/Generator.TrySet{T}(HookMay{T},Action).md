### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[Generator](Generator.md 'Wawa.Recall.Generator')

## Generator.TrySet<T>(this HookMay<T>, Action) Method

Attempts to set the inner value to the parameter [value](Generator.TrySet{T}(HookMay{T},Action).md#Wawa.Recall.Generator.TrySet_T_(thisWawa.Recall.HookMay_T_,System.Action).value 'Wawa.Recall.Generator.TrySet<T>(this Wawa.Recall.HookMay<T>, System.Action).value').

```csharp
public static bool TrySet<T>(this Wawa.Recall.HookMay<T>? that, System.Action? value)
    where T : System.Delegate;
```
#### Type parameters

<a name='Wawa.Recall.Generator.TrySet_T_(thisWawa.Recall.HookMay_T_,System.Action).T'></a>

`T`

The type parameter of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Recall.Prop<T>').
#### Parameters

<a name='Wawa.Recall.Generator.TrySet_T_(thisWawa.Recall.HookMay_T_,System.Action).that'></a>

`that` [Wawa.Recall.HookMay&lt;](HookMay{T}.md 'Wawa.Recall.HookMay<T>')[T](Generator.TrySet{T}(HookMay{T},Action).md#Wawa.Recall.Generator.TrySet_T_(thisWawa.Recall.HookMay_T_,System.Action).T 'Wawa.Recall.Generator.TrySet<T>(this Wawa.Recall.HookMay<T>, System.Action).T')[&gt;](HookMay{T}.md 'Wawa.Recall.HookMay<T>')

This instance of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Recall.Prop<T>').

<a name='Wawa.Recall.Generator.TrySet_T_(thisWawa.Recall.HookMay_T_,System.Action).value'></a>

`value` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The value to set the inner value with.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the value set was successful, otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').