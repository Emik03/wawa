### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[Generator](Generator.md 'wawa.Recall.Generator')

## Generator.TryAdd<T>(this HookMay<T>, Action) Method

Attempts to add the parameter [value](Generator.TryAdd{T}(HookMay{T},Action).md#wawa.Recall.Generator.TryAdd_T_(thiswawa.Recall.HookMay_T_,System.Action).value 'wawa.Recall.Generator.TryAdd<T>(this wawa.Recall.HookMay<T>, System.Action).value') from the inner value.

```csharp
public static bool TryAdd<T>(this wawa.Recall.HookMay<T>? that, System.Action? value)
    where T : System.Delegate;
```
#### Type parameters

<a name='wawa.Recall.Generator.TryAdd_T_(thiswawa.Recall.HookMay_T_,System.Action).T'></a>

`T`

The type parameter of [Prop&lt;T&gt;](Prop{T}.md 'wawa.Recall.Prop<T>').
#### Parameters

<a name='wawa.Recall.Generator.TryAdd_T_(thiswawa.Recall.HookMay_T_,System.Action).that'></a>

`that` [wawa.Recall.HookMay&lt;](HookMay{T}.md 'wawa.Recall.HookMay<T>')[T](Generator.TryAdd{T}(HookMay{T},Action).md#wawa.Recall.Generator.TryAdd_T_(thiswawa.Recall.HookMay_T_,System.Action).T 'wawa.Recall.Generator.TryAdd<T>(this wawa.Recall.HookMay<T>, System.Action).T')[&gt;](HookMay{T}.md 'wawa.Recall.HookMay<T>')

This instance of [Prop&lt;T&gt;](Prop{T}.md 'wawa.Recall.Prop<T>').

<a name='wawa.Recall.Generator.TryAdd_T_(thiswawa.Recall.HookMay_T_,System.Action).value'></a>

`value` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The value to set the inner value with.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if mutation succeeded, otherwise; [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').