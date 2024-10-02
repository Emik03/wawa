### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[Generator](Generator.md 'wawa.Recall.Generator')

## Generator.ExpectRemove<T>(this HookMay<T>, Action) Method

Removes the parameter [value](Generator.ExpectRemove{T}(HookMay{T},Action).md#wawa.Recall.Generator.ExpectRemove_T_(thiswawa.Recall.HookMay_T_,System.Action).value 'wawa.Recall.Generator.ExpectRemove<T>(this wawa.Recall.HookMay<T>, System.Action).value') from the inner value. Will throw on fail.

```csharp
public static wawa.Recall.HookMay<T> ExpectRemove<T>(this wawa.Recall.HookMay<T> that, System.Action value)
    where T : System.Delegate;
```
#### Type parameters

<a name='wawa.Recall.Generator.ExpectRemove_T_(thiswawa.Recall.HookMay_T_,System.Action).T'></a>

`T`

The type parameter of [Prop&lt;T&gt;](Prop{T}.md 'wawa.Recall.Prop<T>').
#### Parameters

<a name='wawa.Recall.Generator.ExpectRemove_T_(thiswawa.Recall.HookMay_T_,System.Action).that'></a>

`that` [wawa.Recall.HookMay&lt;](HookMay{T}.md 'wawa.Recall.HookMay<T>')[T](Generator.ExpectRemove{T}(HookMay{T},Action).md#wawa.Recall.Generator.ExpectRemove_T_(thiswawa.Recall.HookMay_T_,System.Action).T 'wawa.Recall.Generator.ExpectRemove<T>(this wawa.Recall.HookMay<T>, System.Action).T')[&gt;](HookMay{T}.md 'wawa.Recall.HookMay<T>')

This instance of [Prop&lt;T&gt;](Prop{T}.md 'wawa.Recall.Prop<T>').

<a name='wawa.Recall.Generator.ExpectRemove_T_(thiswawa.Recall.HookMay_T_,System.Action).value'></a>

`value` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The value to set the inner value with.

#### Returns
[wawa.Recall.HookMay&lt;](HookMay{T}.md 'wawa.Recall.HookMay<T>')[T](Generator.ExpectRemove{T}(HookMay{T},Action).md#wawa.Recall.Generator.ExpectRemove_T_(thiswawa.Recall.HookMay_T_,System.Action).T 'wawa.Recall.Generator.ExpectRemove<T>(this wawa.Recall.HookMay<T>, System.Action).T')[&gt;](HookMay{T}.md 'wawa.Recall.HookMay<T>')  
The parameter [that](Generator.ExpectRemove{T}(HookMay{T},Action).md#wawa.Recall.Generator.ExpectRemove_T_(thiswawa.Recall.HookMay_T_,System.Action).that 'wawa.Recall.Generator.ExpectRemove<T>(this wawa.Recall.HookMay<T>, System.Action).that').

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
The parameter [that](Generator.ExpectRemove{T}(HookMay{T},Action).md#wawa.Recall.Generator.ExpectRemove_T_(thiswawa.Recall.HookMay_T_,System.Action).that 'wawa.Recall.Generator.ExpectRemove<T>(this wawa.Recall.HookMay<T>, System.Action).that') is immutable.