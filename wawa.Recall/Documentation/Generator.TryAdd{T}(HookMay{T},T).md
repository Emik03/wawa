### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[Generator](Generator.md 'wawa.Recall.Generator')

## Generator.TryAdd<T>(this HookMay<T>, T) Method

Attempts to add the parameter [value](Generator.TryAdd{T}(HookMay{T},T).md#wawa.Recall.Generator.TryAdd_T_(thiswawa.Recall.HookMay_T_,T).value 'wawa.Recall.Generator.TryAdd<T>(this wawa.Recall.HookMay<T>, T).value') from the inner value.

```csharp
public static bool TryAdd<T>(this wawa.Recall.HookMay<T>? that, T value)
    where T : System.Delegate;
```
#### Type parameters

<a name='wawa.Recall.Generator.TryAdd_T_(thiswawa.Recall.HookMay_T_,T).T'></a>

`T`

The type parameter of [Prop&lt;T&gt;](Prop{T}.md 'wawa.Recall.Prop<T>').
#### Parameters

<a name='wawa.Recall.Generator.TryAdd_T_(thiswawa.Recall.HookMay_T_,T).that'></a>

`that` [wawa.Recall.HookMay&lt;](HookMay{T}.md 'wawa.Recall.HookMay<T>')[T](Generator.TryAdd{T}(HookMay{T},T).md#wawa.Recall.Generator.TryAdd_T_(thiswawa.Recall.HookMay_T_,T).T 'wawa.Recall.Generator.TryAdd<T>(this wawa.Recall.HookMay<T>, T).T')[&gt;](HookMay{T}.md 'wawa.Recall.HookMay<T>')

This instance of [Prop&lt;T&gt;](Prop{T}.md 'wawa.Recall.Prop<T>').

<a name='wawa.Recall.Generator.TryAdd_T_(thiswawa.Recall.HookMay_T_,T).value'></a>

`value` [T](Generator.TryAdd{T}(HookMay{T},T).md#wawa.Recall.Generator.TryAdd_T_(thiswawa.Recall.HookMay_T_,T).T 'wawa.Recall.Generator.TryAdd<T>(this wawa.Recall.HookMay<T>, T).T')

The value to set the inner value with.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if mutation succeeded, otherwise; [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').