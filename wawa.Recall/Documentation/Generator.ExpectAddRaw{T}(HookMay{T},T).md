### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[Generator](Generator.md 'Wawa.Recall.Generator')

## Generator.ExpectAddRaw<T>(this HookMay<T>, T) Method

Adds the parameter [value](Generator.ExpectAddRaw{T}(HookMay{T},T).md#Wawa.Recall.Generator.ExpectAddRaw_T_(thisWawa.Recall.HookMay_T_,T).value 'Wawa.Recall.Generator.ExpectAddRaw<T>(this Wawa.Recall.HookMay<T>, T).value') from the inner value. Will throw on fail.

```csharp
public static Wawa.Recall.HookMay<T> ExpectAddRaw<T>(this Wawa.Recall.HookMay<T> that, T value)
    where T : System.Delegate;
```
#### Type parameters

<a name='Wawa.Recall.Generator.ExpectAddRaw_T_(thisWawa.Recall.HookMay_T_,T).T'></a>

`T`

The type parameter of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Recall.Prop<T>').
#### Parameters

<a name='Wawa.Recall.Generator.ExpectAddRaw_T_(thisWawa.Recall.HookMay_T_,T).that'></a>

`that` [Wawa.Recall.HookMay&lt;](HookMay{T}.md 'Wawa.Recall.HookMay<T>')[T](Generator.ExpectAddRaw{T}(HookMay{T},T).md#Wawa.Recall.Generator.ExpectAddRaw_T_(thisWawa.Recall.HookMay_T_,T).T 'Wawa.Recall.Generator.ExpectAddRaw<T>(this Wawa.Recall.HookMay<T>, T).T')[&gt;](HookMay{T}.md 'Wawa.Recall.HookMay<T>')

This instance of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Recall.Prop<T>').

<a name='Wawa.Recall.Generator.ExpectAddRaw_T_(thisWawa.Recall.HookMay_T_,T).value'></a>

`value` [T](Generator.ExpectAddRaw{T}(HookMay{T},T).md#Wawa.Recall.Generator.ExpectAddRaw_T_(thisWawa.Recall.HookMay_T_,T).T 'Wawa.Recall.Generator.ExpectAddRaw<T>(this Wawa.Recall.HookMay<T>, T).T')

The value to set the inner value with.

#### Returns
[Wawa.Recall.HookMay&lt;](HookMay{T}.md 'Wawa.Recall.HookMay<T>')[T](Generator.ExpectAddRaw{T}(HookMay{T},T).md#Wawa.Recall.Generator.ExpectAddRaw_T_(thisWawa.Recall.HookMay_T_,T).T 'Wawa.Recall.Generator.ExpectAddRaw<T>(this Wawa.Recall.HookMay<T>, T).T')[&gt;](HookMay{T}.md 'Wawa.Recall.HookMay<T>')  
The parameter [that](Generator.ExpectAddRaw{T}(HookMay{T},T).md#Wawa.Recall.Generator.ExpectAddRaw_T_(thisWawa.Recall.HookMay_T_,T).that 'Wawa.Recall.Generator.ExpectAddRaw<T>(this Wawa.Recall.HookMay<T>, T).that').

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
The parameter [that](Generator.ExpectAddRaw{T}(HookMay{T},T).md#Wawa.Recall.Generator.ExpectAddRaw_T_(thisWawa.Recall.HookMay_T_,T).that 'Wawa.Recall.Generator.ExpectAddRaw<T>(this Wawa.Recall.HookMay<T>, T).that') is immutable.