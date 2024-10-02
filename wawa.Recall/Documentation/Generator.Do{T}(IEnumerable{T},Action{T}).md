### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[Generator](Generator.md 'wawa.Recall.Generator')

## Generator.Do<T>(this IEnumerable<T>, Action<T>) Method

Executes the function, then returns the parameter [that](Generator.Do{T}(IEnumerable{T},Action{T}).md#wawa.Recall.Generator.Do_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).that 'wawa.Recall.Generator.Do<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T>).that').

```csharp
public static System.Collections.Generic.IEnumerable<T> Do<T>(this System.Collections.Generic.IEnumerable<T>? that, System.Action<T> action)
    where T : wawa.Recall.IVanilla;
```
#### Type parameters

<a name='wawa.Recall.Generator.Do_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).T'></a>

`T`

The type of context value.
#### Parameters

<a name='wawa.Recall.Generator.Do_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).that'></a>

`that` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Generator.Do{T}(IEnumerable{T},Action{T}).md#wawa.Recall.Generator.Do_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).T 'wawa.Recall.Generator.Do<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The value to pass into the callback.

<a name='wawa.Recall.Generator.Do_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).action'></a>

`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](Generator.Do{T}(IEnumerable{T},Action{T}).md#wawa.Recall.Generator.Do_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).T 'wawa.Recall.Generator.Do<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The callback.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Generator.Do{T}(IEnumerable{T},Action{T}).md#wawa.Recall.Generator.Do_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).T 'wawa.Recall.Generator.Do<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The parameter [that](Generator.Do{T}(IEnumerable{T},Action{T}).md#wawa.Recall.Generator.Do_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).that 'wawa.Recall.Generator.Do<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T>).that').

### Remarks
  
Types that implement [IVanilla](IVanilla.md 'wawa.Recall.IVanilla') generally expose lots of callbacks.  
As such it may be desired to pass a reference of [that](Generator.Do{T}(IEnumerable{T},Action{T}).md#wawa.Recall.Generator.Do_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).that 'wawa.Recall.Generator.Do<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T>).that') into the callback.  
This function acts as a Y-combinator, allowing you to assign a temporary variable that can bind to the callback.