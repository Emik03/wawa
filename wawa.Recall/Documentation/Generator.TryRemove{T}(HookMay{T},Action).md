### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[Generator](Generator.md 'Wawa.Recall.Generator')

## Generator.TryRemove<T>(this HookMay<T>, Action) Method

Attempts to remove the parameter [value](Generator.TryRemove{T}(HookMay{T},Action).md#Wawa.Recall.Generator.TryRemove_T_(thisWawa.Recall.HookMay_T_,System.Action).value 'Wawa.Recall.Generator.TryRemove<T>(this Wawa.Recall.HookMay<T>, System.Action).value') from the inner value.

```csharp
public static bool TryRemove<T>(this Wawa.Recall.HookMay<T>? that, System.Action? value)
    where T : System.Delegate;
```
#### Type parameters

<a name='Wawa.Recall.Generator.TryRemove_T_(thisWawa.Recall.HookMay_T_,System.Action).T'></a>

`T`

The type parameter of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Recall.Prop<T>').
#### Parameters

<a name='Wawa.Recall.Generator.TryRemove_T_(thisWawa.Recall.HookMay_T_,System.Action).that'></a>

`that` [Wawa.Recall.HookMay&lt;](HookMay{T}.md 'Wawa.Recall.HookMay<T>')[T](Generator.TryRemove{T}(HookMay{T},Action).md#Wawa.Recall.Generator.TryRemove_T_(thisWawa.Recall.HookMay_T_,System.Action).T 'Wawa.Recall.Generator.TryRemove<T>(this Wawa.Recall.HookMay<T>, System.Action).T')[&gt;](HookMay{T}.md 'Wawa.Recall.HookMay<T>')

This instance of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Recall.Prop<T>').

<a name='Wawa.Recall.Generator.TryRemove_T_(thisWawa.Recall.HookMay_T_,System.Action).value'></a>

`value` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The value to set the inner value with.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if mutation succeeded, otherwise; [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').