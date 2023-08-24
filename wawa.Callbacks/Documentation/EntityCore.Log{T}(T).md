### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[EntityCore](EntityCore.md 'Wawa.Callbacks.EntityCore')

## EntityCore.Log<T>(this T) Method

Hooks the logger to each instance.

```csharp
public static T Log<T>(this T that)
    where T : System.Collections.Generic.IEnumerable<Wawa.Callbacks.Entity>;
```
#### Type parameters

<a name='Wawa.Callbacks.EntityCore.Log_T_(thisT).T'></a>

`T`
#### Parameters

<a name='Wawa.Callbacks.EntityCore.Log_T_(thisT).that'></a>

`that` [T](EntityCore.Log{T}(T).md#Wawa.Callbacks.EntityCore.Log_T_(thisT).T 'Wawa.Callbacks.EntityCore.Log<T>(this T).T')

This instance of [Selected](Selected.md 'Wawa.Callbacks.Selected').

#### Returns
[T](EntityCore.Log{T}(T).md#Wawa.Callbacks.EntityCore.Log_T_(thisT).T 'Wawa.Callbacks.EntityCore.Log<T>(this T).T')  
The parameter [that](EntityCore.Log{T}(T).md#Wawa.Callbacks.EntityCore.Log_T_(thisT).that 'Wawa.Callbacks.EntityCore.Log<T>(this T).that').

### Remarks
  
Since the logger is implicitly created within this function, the logging cannot easily  
be reversed without using the nuclear option [Clear&lt;T&gt;(this Hook&lt;T&gt;)](Generator.Clear{T}(Hook{T}).md 'Wawa.Callbacks.Generator.Clear<T>(this Wawa.Callbacks.Hook<T>)').