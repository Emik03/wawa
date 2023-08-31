### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[Generator](Generator.md 'Wawa.Callbacks.Generator')

## Generator.ExpectSet<T>(this HookMay<T>, Action) Method

Sets the inner value with the provided [value](Generator.ExpectSet{T}(HookMay{T},Action).md#Wawa.Callbacks.Generator.ExpectSet_T_(thisWawa.Callbacks.HookMay_T_,System.Action).value 'Wawa.Callbacks.Generator.ExpectSet<T>(this Wawa.Callbacks.HookMay<T>, System.Action).value'). Will throw on fail.

```csharp
public static Wawa.Callbacks.HookMay<T> ExpectSet<T>(this Wawa.Callbacks.HookMay<T> that, System.Action? value)
    where T : System.Delegate;
```
#### Type parameters

<a name='Wawa.Callbacks.Generator.ExpectSet_T_(thisWawa.Callbacks.HookMay_T_,System.Action).T'></a>

`T`

The type parameter of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Callbacks.Prop<T>').
#### Parameters

<a name='Wawa.Callbacks.Generator.ExpectSet_T_(thisWawa.Callbacks.HookMay_T_,System.Action).that'></a>

`that` [Wawa.Callbacks.HookMay&lt;](HookMay{T}.md 'Wawa.Callbacks.HookMay<T>')[T](Generator.ExpectSet{T}(HookMay{T},Action).md#Wawa.Callbacks.Generator.ExpectSet_T_(thisWawa.Callbacks.HookMay_T_,System.Action).T 'Wawa.Callbacks.Generator.ExpectSet<T>(this Wawa.Callbacks.HookMay<T>, System.Action).T')[&gt;](HookMay{T}.md 'Wawa.Callbacks.HookMay<T>')

This instance of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Callbacks.Prop<T>').

<a name='Wawa.Callbacks.Generator.ExpectSet_T_(thisWawa.Callbacks.HookMay_T_,System.Action).value'></a>

`value` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The value to set the inner value with.

#### Returns
[Wawa.Callbacks.HookMay&lt;](HookMay{T}.md 'Wawa.Callbacks.HookMay<T>')[T](Generator.ExpectSet{T}(HookMay{T},Action).md#Wawa.Callbacks.Generator.ExpectSet_T_(thisWawa.Callbacks.HookMay_T_,System.Action).T 'Wawa.Callbacks.Generator.ExpectSet<T>(this Wawa.Callbacks.HookMay<T>, System.Action).T')[&gt;](HookMay{T}.md 'Wawa.Callbacks.HookMay<T>')  
The parameter [that](Generator.ExpectSet{T}(HookMay{T},Action).md#Wawa.Callbacks.Generator.ExpectSet_T_(thisWawa.Callbacks.HookMay_T_,System.Action).that 'Wawa.Callbacks.Generator.ExpectSet<T>(this Wawa.Callbacks.HookMay<T>, System.Action).that').

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
The parameter [that](Generator.ExpectSet{T}(HookMay{T},Action).md#Wawa.Callbacks.Generator.ExpectSet_T_(thisWawa.Callbacks.HookMay_T_,System.Action).that 'Wawa.Callbacks.Generator.ExpectSet<T>(this Wawa.Callbacks.HookMay<T>, System.Action).that') is immutable.