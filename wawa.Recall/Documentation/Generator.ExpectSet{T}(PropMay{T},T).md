### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[Generator](Generator.md 'Wawa.Callbacks.Generator')

## Generator.ExpectSet<T>(this PropMay<T>, T) Method

Sets the inner value with the provided [value](Generator.ExpectSet{T}(PropMay{T},T).md#Wawa.Callbacks.Generator.ExpectSet_T_(thisWawa.Callbacks.PropMay_T_,T).value 'Wawa.Callbacks.Generator.ExpectSet<T>(this Wawa.Callbacks.PropMay<T>, T).value'). Will throw on fail.

```csharp
public static Wawa.Callbacks.PropMay<T> ExpectSet<T>(this Wawa.Callbacks.PropMay<T> that, T value);
```
#### Type parameters

<a name='Wawa.Callbacks.Generator.ExpectSet_T_(thisWawa.Callbacks.PropMay_T_,T).T'></a>

`T`

The type parameter of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Callbacks.Prop<T>').
#### Parameters

<a name='Wawa.Callbacks.Generator.ExpectSet_T_(thisWawa.Callbacks.PropMay_T_,T).that'></a>

`that` [Wawa.Callbacks.PropMay&lt;](PropMay{T}.md 'Wawa.Callbacks.PropMay<T>')[T](Generator.ExpectSet{T}(PropMay{T},T).md#Wawa.Callbacks.Generator.ExpectSet_T_(thisWawa.Callbacks.PropMay_T_,T).T 'Wawa.Callbacks.Generator.ExpectSet<T>(this Wawa.Callbacks.PropMay<T>, T).T')[&gt;](PropMay{T}.md 'Wawa.Callbacks.PropMay<T>')

This instance of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Callbacks.Prop<T>').

<a name='Wawa.Callbacks.Generator.ExpectSet_T_(thisWawa.Callbacks.PropMay_T_,T).value'></a>

`value` [T](Generator.ExpectSet{T}(PropMay{T},T).md#Wawa.Callbacks.Generator.ExpectSet_T_(thisWawa.Callbacks.PropMay_T_,T).T 'Wawa.Callbacks.Generator.ExpectSet<T>(this Wawa.Callbacks.PropMay<T>, T).T')

The value to set the inner value with.

#### Returns
[Wawa.Callbacks.PropMay&lt;](PropMay{T}.md 'Wawa.Callbacks.PropMay<T>')[T](Generator.ExpectSet{T}(PropMay{T},T).md#Wawa.Callbacks.Generator.ExpectSet_T_(thisWawa.Callbacks.PropMay_T_,T).T 'Wawa.Callbacks.Generator.ExpectSet<T>(this Wawa.Callbacks.PropMay<T>, T).T')[&gt;](PropMay{T}.md 'Wawa.Callbacks.PropMay<T>')  
The parameter [that](Generator.ExpectSet{T}(PropMay{T},T).md#Wawa.Callbacks.Generator.ExpectSet_T_(thisWawa.Callbacks.PropMay_T_,T).that 'Wawa.Callbacks.Generator.ExpectSet<T>(this Wawa.Callbacks.PropMay<T>, T).that').

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
The parameter [that](Generator.ExpectSet{T}(PropMay{T},T).md#Wawa.Callbacks.Generator.ExpectSet_T_(thisWawa.Callbacks.PropMay_T_,T).that 'Wawa.Callbacks.Generator.ExpectSet<T>(this Wawa.Callbacks.PropMay<T>, T).that') is immutable.