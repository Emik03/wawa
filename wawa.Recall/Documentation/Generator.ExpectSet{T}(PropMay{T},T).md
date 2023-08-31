### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[Generator](Generator.md 'Wawa.Recall.Generator')

## Generator.ExpectSet<T>(this PropMay<T>, T) Method

Sets the inner value with the provided [value](Generator.ExpectSet{T}(PropMay{T},T).md#Wawa.Recall.Generator.ExpectSet_T_(thisWawa.Recall.PropMay_T_,T).value 'Wawa.Recall.Generator.ExpectSet<T>(this Wawa.Recall.PropMay<T>, T).value'). Will throw on fail.

```csharp
public static Wawa.Recall.PropMay<T> ExpectSet<T>(this Wawa.Recall.PropMay<T> that, T value);
```
#### Type parameters

<a name='Wawa.Recall.Generator.ExpectSet_T_(thisWawa.Recall.PropMay_T_,T).T'></a>

`T`

The type parameter of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Recall.Prop<T>').
#### Parameters

<a name='Wawa.Recall.Generator.ExpectSet_T_(thisWawa.Recall.PropMay_T_,T).that'></a>

`that` [Wawa.Recall.PropMay&lt;](PropMay{T}.md 'Wawa.Recall.PropMay<T>')[T](Generator.ExpectSet{T}(PropMay{T},T).md#Wawa.Recall.Generator.ExpectSet_T_(thisWawa.Recall.PropMay_T_,T).T 'Wawa.Recall.Generator.ExpectSet<T>(this Wawa.Recall.PropMay<T>, T).T')[&gt;](PropMay{T}.md 'Wawa.Recall.PropMay<T>')

This instance of [Prop&lt;T&gt;](Prop{T}.md 'Wawa.Recall.Prop<T>').

<a name='Wawa.Recall.Generator.ExpectSet_T_(thisWawa.Recall.PropMay_T_,T).value'></a>

`value` [T](Generator.ExpectSet{T}(PropMay{T},T).md#Wawa.Recall.Generator.ExpectSet_T_(thisWawa.Recall.PropMay_T_,T).T 'Wawa.Recall.Generator.ExpectSet<T>(this Wawa.Recall.PropMay<T>, T).T')

The value to set the inner value with.

#### Returns
[Wawa.Recall.PropMay&lt;](PropMay{T}.md 'Wawa.Recall.PropMay<T>')[T](Generator.ExpectSet{T}(PropMay{T},T).md#Wawa.Recall.Generator.ExpectSet_T_(thisWawa.Recall.PropMay_T_,T).T 'Wawa.Recall.Generator.ExpectSet<T>(this Wawa.Recall.PropMay<T>, T).T')[&gt;](PropMay{T}.md 'Wawa.Recall.PropMay<T>')  
The parameter [that](Generator.ExpectSet{T}(PropMay{T},T).md#Wawa.Recall.Generator.ExpectSet_T_(thisWawa.Recall.PropMay_T_,T).that 'Wawa.Recall.Generator.ExpectSet<T>(this Wawa.Recall.PropMay<T>, T).that').

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
The parameter [that](Generator.ExpectSet{T}(PropMay{T},T).md#Wawa.Recall.Generator.ExpectSet_T_(thisWawa.Recall.PropMay_T_,T).that 'Wawa.Recall.Generator.ExpectSet<T>(this Wawa.Recall.PropMay<T>, T).that') is immutable.