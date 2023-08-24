### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[Generator](Generator.md 'Wawa.Callbacks.Generator')

## Generator.ExpectAdd<T>(this HookMay<T>, Action) Method

Adds the parameter [value](Generator.ExpectAdd{T}(HookMay{T},Action).md#Wawa.Callbacks.Generator.ExpectAdd_T_(thisWawa.Callbacks.HookMay_T_,System.Action).value 'Wawa.Callbacks.Generator.ExpectAdd<T>(this Wawa.Callbacks.HookMay<T>, System.Action).value') from the inner value. Will throw on fail.

```csharp
public static Wawa.Callbacks.HookMay<T> ExpectAdd<T>(this Wawa.Callbacks.HookMay<T> that, System.Action value)
    where T : System.Delegate;
```
#### Type parameters

<a name='Wawa.Callbacks.Generator.ExpectAdd_T_(thisWawa.Callbacks.HookMay_T_,System.Action).T'></a>

`T`

The type parameter of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Callbacks.Prop<T>').
#### Parameters

<a name='Wawa.Callbacks.Generator.ExpectAdd_T_(thisWawa.Callbacks.HookMay_T_,System.Action).that'></a>

`that` [Wawa.Callbacks.HookMay&lt;](HookMay{T}.md 'Wawa.Callbacks.HookMay<T>')[T](Generator.ExpectAdd{T}(HookMay{T},Action).md#Wawa.Callbacks.Generator.ExpectAdd_T_(thisWawa.Callbacks.HookMay_T_,System.Action).T 'Wawa.Callbacks.Generator.ExpectAdd<T>(this Wawa.Callbacks.HookMay<T>, System.Action).T')[&gt;](HookMay{T}.md 'Wawa.Callbacks.HookMay<T>')

This instance of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Callbacks.Prop<T>').

<a name='Wawa.Callbacks.Generator.ExpectAdd_T_(thisWawa.Callbacks.HookMay_T_,System.Action).value'></a>

`value` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The value to set the inner value with.

#### Returns
[Wawa.Callbacks.HookMay&lt;](HookMay{T}.md 'Wawa.Callbacks.HookMay<T>')[T](Generator.ExpectAdd{T}(HookMay{T},Action).md#Wawa.Callbacks.Generator.ExpectAdd_T_(thisWawa.Callbacks.HookMay_T_,System.Action).T 'Wawa.Callbacks.Generator.ExpectAdd<T>(this Wawa.Callbacks.HookMay<T>, System.Action).T')[&gt;](HookMay{T}.md 'Wawa.Callbacks.HookMay<T>')  
The parameter [that](Generator.ExpectAdd{T}(HookMay{T},Action).md#Wawa.Callbacks.Generator.ExpectAdd_T_(thisWawa.Callbacks.HookMay_T_,System.Action).that 'Wawa.Callbacks.Generator.ExpectAdd<T>(this Wawa.Callbacks.HookMay<T>, System.Action).that').

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
The parameter [that](Generator.ExpectAdd{T}(HookMay{T},Action).md#Wawa.Callbacks.Generator.ExpectAdd_T_(thisWawa.Callbacks.HookMay_T_,System.Action).that 'Wawa.Callbacks.Generator.ExpectAdd<T>(this Wawa.Callbacks.HookMay<T>, System.Action).that') is immutable.