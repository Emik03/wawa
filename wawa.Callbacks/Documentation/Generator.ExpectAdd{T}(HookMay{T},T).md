### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[Generator](Generator.md 'Wawa.Callbacks.Generator')

## Generator.ExpectAdd<T>(this HookMay<T>, T) Method

Adds the parameter [value](Generator.ExpectAdd{T}(HookMay{T},T).md#Wawa.Callbacks.Generator.ExpectAdd_T_(thisWawa.Callbacks.HookMay_T_,T).value 'Wawa.Callbacks.Generator.ExpectAdd<T>(this Wawa.Callbacks.HookMay<T>, T).value') from the inner value. Will throw on fail.

```csharp
public static Wawa.Callbacks.HookMay<T>? ExpectAdd<T>(this Wawa.Callbacks.HookMay<T>? that, T value)
    where T : System.Delegate;
```
#### Type parameters

<a name='Wawa.Callbacks.Generator.ExpectAdd_T_(thisWawa.Callbacks.HookMay_T_,T).T'></a>

`T`

The type parameter of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Callbacks.Prop<T>').
#### Parameters

<a name='Wawa.Callbacks.Generator.ExpectAdd_T_(thisWawa.Callbacks.HookMay_T_,T).that'></a>

`that` [Wawa.Callbacks.HookMay&lt;](HookMay{T}.md 'Wawa.Callbacks.HookMay<T>')[T](Generator.ExpectAdd{T}(HookMay{T},T).md#Wawa.Callbacks.Generator.ExpectAdd_T_(thisWawa.Callbacks.HookMay_T_,T).T 'Wawa.Callbacks.Generator.ExpectAdd<T>(this Wawa.Callbacks.HookMay<T>, T).T')[&gt;](HookMay{T}.md 'Wawa.Callbacks.HookMay<T>')

This instance of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Callbacks.Prop<T>').

<a name='Wawa.Callbacks.Generator.ExpectAdd_T_(thisWawa.Callbacks.HookMay_T_,T).value'></a>

`value` [T](Generator.ExpectAdd{T}(HookMay{T},T).md#Wawa.Callbacks.Generator.ExpectAdd_T_(thisWawa.Callbacks.HookMay_T_,T).T 'Wawa.Callbacks.Generator.ExpectAdd<T>(this Wawa.Callbacks.HookMay<T>, T).T')

The value to set the inner value with.

#### Returns
[Wawa.Callbacks.HookMay&lt;](HookMay{T}.md 'Wawa.Callbacks.HookMay<T>')[T](Generator.ExpectAdd{T}(HookMay{T},T).md#Wawa.Callbacks.Generator.ExpectAdd_T_(thisWawa.Callbacks.HookMay_T_,T).T 'Wawa.Callbacks.Generator.ExpectAdd<T>(this Wawa.Callbacks.HookMay<T>, T).T')[&gt;](HookMay{T}.md 'Wawa.Callbacks.HookMay<T>')  
The parameter [that](Generator.ExpectAdd{T}(HookMay{T},T).md#Wawa.Callbacks.Generator.ExpectAdd_T_(thisWawa.Callbacks.HookMay_T_,T).that 'Wawa.Callbacks.Generator.ExpectAdd<T>(this Wawa.Callbacks.HookMay<T>, T).that').

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
The parameter [that](Generator.ExpectAdd{T}(HookMay{T},T).md#Wawa.Callbacks.Generator.ExpectAdd_T_(thisWawa.Callbacks.HookMay_T_,T).that 'Wawa.Callbacks.Generator.ExpectAdd<T>(this Wawa.Callbacks.HookMay<T>, T).that') is immutable.