### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[Generator](Generator.md 'Wawa.Recall.Generator')

## Generator.ExpectSet<T>(this HookMay<T>, Action) Method

Sets the inner value with the provided [value](Generator.ExpectSet{T}(HookMay{T},Action).md#Wawa.Recall.Generator.ExpectSet_T_(thisWawa.Recall.HookMay_T_,System.Action).value 'Wawa.Recall.Generator.ExpectSet<T>(this Wawa.Recall.HookMay<T>, System.Action).value'). Will throw on fail.

```csharp
public static Wawa.Recall.HookMay<T> ExpectSet<T>(this Wawa.Recall.HookMay<T> that, System.Action? value)
    where T : System.Delegate;
```
#### Type parameters

<a name='Wawa.Recall.Generator.ExpectSet_T_(thisWawa.Recall.HookMay_T_,System.Action).T'></a>

`T`

The type parameter of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Recall.Prop<T>').
#### Parameters

<a name='Wawa.Recall.Generator.ExpectSet_T_(thisWawa.Recall.HookMay_T_,System.Action).that'></a>

`that` [Wawa.Recall.HookMay&lt;](HookMay{T}.md 'Wawa.Recall.HookMay<T>')[T](Generator.ExpectSet{T}(HookMay{T},Action).md#Wawa.Recall.Generator.ExpectSet_T_(thisWawa.Recall.HookMay_T_,System.Action).T 'Wawa.Recall.Generator.ExpectSet<T>(this Wawa.Recall.HookMay<T>, System.Action).T')[&gt;](HookMay{T}.md 'Wawa.Recall.HookMay<T>')

This instance of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Recall.Prop<T>').

<a name='Wawa.Recall.Generator.ExpectSet_T_(thisWawa.Recall.HookMay_T_,System.Action).value'></a>

`value` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The value to set the inner value with.

#### Returns
[Wawa.Recall.HookMay&lt;](HookMay{T}.md 'Wawa.Recall.HookMay<T>')[T](Generator.ExpectSet{T}(HookMay{T},Action).md#Wawa.Recall.Generator.ExpectSet_T_(thisWawa.Recall.HookMay_T_,System.Action).T 'Wawa.Recall.Generator.ExpectSet<T>(this Wawa.Recall.HookMay<T>, System.Action).T')[&gt;](HookMay{T}.md 'Wawa.Recall.HookMay<T>')  
The parameter [that](Generator.ExpectSet{T}(HookMay{T},Action).md#Wawa.Recall.Generator.ExpectSet_T_(thisWawa.Recall.HookMay_T_,System.Action).that 'Wawa.Recall.Generator.ExpectSet<T>(this Wawa.Recall.HookMay<T>, System.Action).that').

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
The parameter [that](Generator.ExpectSet{T}(HookMay{T},Action).md#Wawa.Recall.Generator.ExpectSet_T_(thisWawa.Recall.HookMay_T_,System.Action).that 'Wawa.Recall.Generator.ExpectSet<T>(this Wawa.Recall.HookMay<T>, System.Action).that') is immutable.