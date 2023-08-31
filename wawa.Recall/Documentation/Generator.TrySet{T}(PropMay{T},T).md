### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[Generator](Generator.md 'Wawa.Recall.Generator')

## Generator.TrySet<T>(this PropMay<T>, T) Method

Attempts to set the inner value to the parameter [value](Generator.TrySet{T}(PropMay{T},T).md#Wawa.Recall.Generator.TrySet_T_(thisWawa.Recall.PropMay_T_,T).value 'Wawa.Recall.Generator.TrySet<T>(this Wawa.Recall.PropMay<T>, T).value').

```csharp
public static bool TrySet<T>(this Wawa.Recall.PropMay<T>? that, T value);
```
#### Type parameters

<a name='Wawa.Recall.Generator.TrySet_T_(thisWawa.Recall.PropMay_T_,T).T'></a>

`T`

The type parameter of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Recall.Prop<T>').
#### Parameters

<a name='Wawa.Recall.Generator.TrySet_T_(thisWawa.Recall.PropMay_T_,T).that'></a>

`that` [Wawa.Recall.PropMay&lt;](PropMay{T}.md 'Wawa.Recall.PropMay<T>')[T](Generator.TrySet{T}(PropMay{T},T).md#Wawa.Recall.Generator.TrySet_T_(thisWawa.Recall.PropMay_T_,T).T 'Wawa.Recall.Generator.TrySet<T>(this Wawa.Recall.PropMay<T>, T).T')[&gt;](PropMay{T}.md 'Wawa.Recall.PropMay<T>')

This instance of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Recall.Prop<T>').

<a name='Wawa.Recall.Generator.TrySet_T_(thisWawa.Recall.PropMay_T_,T).value'></a>

`value` [T](Generator.TrySet{T}(PropMay{T},T).md#Wawa.Recall.Generator.TrySet_T_(thisWawa.Recall.PropMay_T_,T).T 'Wawa.Recall.Generator.TrySet<T>(this Wawa.Recall.PropMay<T>, T).T')

The value to set the inner value with.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the value set was successful, otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').