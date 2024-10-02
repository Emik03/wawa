### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[Generator](Generator.md 'wawa.Recall.Generator')

## Generator.TrySet<T>(this HookMay<T>, T) Method

Attempts to set the inner value to the parameter [value](Generator.TrySet{T}(HookMay{T},T).md#wawa.Recall.Generator.TrySet_T_(thiswawa.Recall.HookMay_T_,T).value 'wawa.Recall.Generator.TrySet<T>(this wawa.Recall.HookMay<T>, T).value').

```csharp
public static bool TrySet<T>(this wawa.Recall.HookMay<T>? that, T value)
    where T : System.Delegate;
```
#### Type parameters

<a name='wawa.Recall.Generator.TrySet_T_(thiswawa.Recall.HookMay_T_,T).T'></a>

`T`

The type parameter of [Prop&lt;T&gt;](Prop{T}.md 'wawa.Recall.Prop<T>').
#### Parameters

<a name='wawa.Recall.Generator.TrySet_T_(thiswawa.Recall.HookMay_T_,T).that'></a>

`that` [wawa.Recall.HookMay&lt;](HookMay{T}.md 'wawa.Recall.HookMay<T>')[T](Generator.TrySet{T}(HookMay{T},T).md#wawa.Recall.Generator.TrySet_T_(thiswawa.Recall.HookMay_T_,T).T 'wawa.Recall.Generator.TrySet<T>(this wawa.Recall.HookMay<T>, T).T')[&gt;](HookMay{T}.md 'wawa.Recall.HookMay<T>')

This instance of [Prop&lt;T&gt;](Prop{T}.md 'wawa.Recall.Prop<T>').

<a name='wawa.Recall.Generator.TrySet_T_(thiswawa.Recall.HookMay_T_,T).value'></a>

`value` [T](Generator.TrySet{T}(HookMay{T},T).md#wawa.Recall.Generator.TrySet_T_(thiswawa.Recall.HookMay_T_,T).T 'wawa.Recall.Generator.TrySet<T>(this wawa.Recall.HookMay<T>, T).T')

The value to set the inner value with.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the value set was successful, otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').