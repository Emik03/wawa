### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[Generator](Generator.md 'Wawa.Recall.Generator')

## Generator.Do<T>(this T, Action<T>) Method

Executes the function, then returns the parameter [that](Generator.Do{T}(T,Action{T}).md#Wawa.Recall.Generator.Do_T_(thisT,System.Action_T_).that 'Wawa.Recall.Generator.Do<T>(this T, System.Action<T>).that').

```csharp
public static T Do<T>(this T that, System.Action<T> action)
    where T : Wawa.Recall.IVanilla;
```
#### Type parameters

<a name='Wawa.Recall.Generator.Do_T_(thisT,System.Action_T_).T'></a>

`T`

The type of context value.
#### Parameters

<a name='Wawa.Recall.Generator.Do_T_(thisT,System.Action_T_).that'></a>

`that` [T](Generator.Do{T}(T,Action{T}).md#Wawa.Recall.Generator.Do_T_(thisT,System.Action_T_).T 'Wawa.Recall.Generator.Do<T>(this T, System.Action<T>).T')

The value to pass into the callback.

<a name='Wawa.Recall.Generator.Do_T_(thisT,System.Action_T_).action'></a>

`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](Generator.Do{T}(T,Action{T}).md#Wawa.Recall.Generator.Do_T_(thisT,System.Action_T_).T 'Wawa.Recall.Generator.Do<T>(this T, System.Action<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The callback.

#### Returns
[T](Generator.Do{T}(T,Action{T}).md#Wawa.Recall.Generator.Do_T_(thisT,System.Action_T_).T 'Wawa.Recall.Generator.Do<T>(this T, System.Action<T>).T')  
The parameter [that](Generator.Do{T}(T,Action{T}).md#Wawa.Recall.Generator.Do_T_(thisT,System.Action_T_).that 'Wawa.Recall.Generator.Do<T>(this T, System.Action<T>).that').

### Remarks
  
Types that implement [IVanilla](IVanilla.md 'Wawa.Recall.IVanilla') generally expose lots of callbacks.  
As such it may be desired to pass a reference of [that](Generator.Do{T}(T,Action{T}).md#Wawa.Recall.Generator.Do_T_(thisT,System.Action_T_).that 'Wawa.Recall.Generator.Do<T>(this T, System.Action<T>).that') into the callback.  
This function acts as a Y-combinator, allowing you to assign a temporary variable that can bind to the callback.