### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[Generator](Generator.md 'wawa.Recall.Generator')

## Generator.ExpectSetRaw<T>(this HookMay<T>, T) Method

Sets the inner value with the provided [value](Generator.ExpectSetRaw{T}(HookMay{T},T).md#wawa.Recall.Generator.ExpectSetRaw_T_(thiswawa.Recall.HookMay_T_,T).value 'wawa.Recall.Generator.ExpectSetRaw<T>(this wawa.Recall.HookMay<T>, T).value'). Will throw on fail.

```csharp
public static wawa.Recall.HookMay<T> ExpectSetRaw<T>(this wawa.Recall.HookMay<T> that, T value)
    where T : System.Delegate;
```
#### Type parameters

<a name='wawa.Recall.Generator.ExpectSetRaw_T_(thiswawa.Recall.HookMay_T_,T).T'></a>

`T`

The type parameter of [Prop&lt;T&gt;](Prop{T}.md 'wawa.Recall.Prop<T>').
#### Parameters

<a name='wawa.Recall.Generator.ExpectSetRaw_T_(thiswawa.Recall.HookMay_T_,T).that'></a>

`that` [wawa.Recall.HookMay&lt;](HookMay{T}.md 'wawa.Recall.HookMay<T>')[T](Generator.ExpectSetRaw{T}(HookMay{T},T).md#wawa.Recall.Generator.ExpectSetRaw_T_(thiswawa.Recall.HookMay_T_,T).T 'wawa.Recall.Generator.ExpectSetRaw<T>(this wawa.Recall.HookMay<T>, T).T')[&gt;](HookMay{T}.md 'wawa.Recall.HookMay<T>')

This instance of [Prop&lt;T&gt;](Prop{T}.md 'wawa.Recall.Prop<T>').

<a name='wawa.Recall.Generator.ExpectSetRaw_T_(thiswawa.Recall.HookMay_T_,T).value'></a>

`value` [T](Generator.ExpectSetRaw{T}(HookMay{T},T).md#wawa.Recall.Generator.ExpectSetRaw_T_(thiswawa.Recall.HookMay_T_,T).T 'wawa.Recall.Generator.ExpectSetRaw<T>(this wawa.Recall.HookMay<T>, T).T')

The value to set the inner value with.

#### Returns
[wawa.Recall.HookMay&lt;](HookMay{T}.md 'wawa.Recall.HookMay<T>')[T](Generator.ExpectSetRaw{T}(HookMay{T},T).md#wawa.Recall.Generator.ExpectSetRaw_T_(thiswawa.Recall.HookMay_T_,T).T 'wawa.Recall.Generator.ExpectSetRaw<T>(this wawa.Recall.HookMay<T>, T).T')[&gt;](HookMay{T}.md 'wawa.Recall.HookMay<T>')  
The parameter [that](Generator.ExpectSetRaw{T}(HookMay{T},T).md#wawa.Recall.Generator.ExpectSetRaw_T_(thiswawa.Recall.HookMay_T_,T).that 'wawa.Recall.Generator.ExpectSetRaw<T>(this wawa.Recall.HookMay<T>, T).that').

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
The parameter [that](Generator.ExpectSetRaw{T}(HookMay{T},T).md#wawa.Recall.Generator.ExpectSetRaw_T_(thiswawa.Recall.HookMay_T_,T).that 'wawa.Recall.Generator.ExpectSetRaw<T>(this wawa.Recall.HookMay<T>, T).that') is immutable.