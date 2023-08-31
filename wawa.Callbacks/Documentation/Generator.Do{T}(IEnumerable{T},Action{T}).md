### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[Generator](Generator.md 'Wawa.Callbacks.Generator')

## Generator.Do<T>(this IEnumerable<T>, Action<T>) Method

Executes the function, then returns the parameter [that](Generator.Do{T}(IEnumerable{T},Action{T}).md#Wawa.Callbacks.Generator.Do_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).that 'Wawa.Callbacks.Generator.Do<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T>).that').

```csharp
public static System.Collections.Generic.IEnumerable<T> Do<T>(this System.Collections.Generic.IEnumerable<T>? that, System.Action<T> action)
    where T : Wawa.Callbacks.IVanilla;
```
#### Type parameters

<a name='Wawa.Callbacks.Generator.Do_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).T'></a>

`T`

The type of context value.
#### Parameters

<a name='Wawa.Callbacks.Generator.Do_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).that'></a>

`that` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Generator.Do{T}(IEnumerable{T},Action{T}).md#Wawa.Callbacks.Generator.Do_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).T 'Wawa.Callbacks.Generator.Do<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The value to pass into the callback.

<a name='Wawa.Callbacks.Generator.Do_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).action'></a>

`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](Generator.Do{T}(IEnumerable{T},Action{T}).md#Wawa.Callbacks.Generator.Do_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).T 'Wawa.Callbacks.Generator.Do<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The callback.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Generator.Do{T}(IEnumerable{T},Action{T}).md#Wawa.Callbacks.Generator.Do_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).T 'Wawa.Callbacks.Generator.Do<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The parameter [that](Generator.Do{T}(IEnumerable{T},Action{T}).md#Wawa.Callbacks.Generator.Do_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).that 'Wawa.Callbacks.Generator.Do<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T>).that').

### Remarks
  
Types that implement [IVanilla](IVanilla.md 'Wawa.Callbacks.IVanilla') generally expose lots of callbacks.  
As such it may be desired to pass a reference of [that](Generator.Do{T}(IEnumerable{T},Action{T}).md#Wawa.Callbacks.Generator.Do_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).that 'Wawa.Callbacks.Generator.Do<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T>).that') into the callback.  
This function acts as a Y-combinator, allowing you to assign a temporary variable that can bind to the callback.