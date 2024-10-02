### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[Generator](Generator.md 'wawa.Recall.Generator')

## Generator.ExpectSet<T>(this PropMay<T>, T) Method

Sets the inner value with the provided [value](Generator.ExpectSet{T}(PropMay{T},T).md#wawa.Recall.Generator.ExpectSet_T_(thiswawa.Recall.PropMay_T_,T).value 'wawa.Recall.Generator.ExpectSet<T>(this wawa.Recall.PropMay<T>, T).value'). Will throw on fail.

```csharp
public static wawa.Recall.PropMay<T> ExpectSet<T>(this wawa.Recall.PropMay<T> that, T value);
```
#### Type parameters

<a name='wawa.Recall.Generator.ExpectSet_T_(thiswawa.Recall.PropMay_T_,T).T'></a>

`T`

The type parameter of [Prop&lt;T&gt;](Prop{T}.md 'wawa.Recall.Prop<T>').
#### Parameters

<a name='wawa.Recall.Generator.ExpectSet_T_(thiswawa.Recall.PropMay_T_,T).that'></a>

`that` [wawa.Recall.PropMay&lt;](PropMay{T}.md 'wawa.Recall.PropMay<T>')[T](Generator.ExpectSet{T}(PropMay{T},T).md#wawa.Recall.Generator.ExpectSet_T_(thiswawa.Recall.PropMay_T_,T).T 'wawa.Recall.Generator.ExpectSet<T>(this wawa.Recall.PropMay<T>, T).T')[&gt;](PropMay{T}.md 'wawa.Recall.PropMay<T>')

This instance of [Prop&lt;T&gt;](Prop{T}.md 'wawa.Recall.Prop<T>').

<a name='wawa.Recall.Generator.ExpectSet_T_(thiswawa.Recall.PropMay_T_,T).value'></a>

`value` [T](Generator.ExpectSet{T}(PropMay{T},T).md#wawa.Recall.Generator.ExpectSet_T_(thiswawa.Recall.PropMay_T_,T).T 'wawa.Recall.Generator.ExpectSet<T>(this wawa.Recall.PropMay<T>, T).T')

The value to set the inner value with.

#### Returns
[wawa.Recall.PropMay&lt;](PropMay{T}.md 'wawa.Recall.PropMay<T>')[T](Generator.ExpectSet{T}(PropMay{T},T).md#wawa.Recall.Generator.ExpectSet_T_(thiswawa.Recall.PropMay_T_,T).T 'wawa.Recall.Generator.ExpectSet<T>(this wawa.Recall.PropMay<T>, T).T')[&gt;](PropMay{T}.md 'wawa.Recall.PropMay<T>')  
The parameter [that](Generator.ExpectSet{T}(PropMay{T},T).md#wawa.Recall.Generator.ExpectSet_T_(thiswawa.Recall.PropMay_T_,T).that 'wawa.Recall.Generator.ExpectSet<T>(this wawa.Recall.PropMay<T>, T).that').

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
The parameter [that](Generator.ExpectSet{T}(PropMay{T},T).md#wawa.Recall.Generator.ExpectSet_T_(thiswawa.Recall.PropMay_T_,T).that 'wawa.Recall.Generator.ExpectSet<T>(this wawa.Recall.PropMay<T>, T).that') is immutable.