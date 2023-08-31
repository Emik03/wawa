### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[EntityCore](EntityCore.md 'Wawa.Callbacks.EntityCore')

## EntityCore.Log(this IEnumerable<Entity>) Method

Hooks the logger to each instance.

```csharp
public static System.Collections.Generic.IEnumerable<Wawa.Callbacks.Entity> Log(this System.Collections.Generic.IEnumerable<Wawa.Callbacks.Entity> that);
```
#### Parameters

<a name='Wawa.Callbacks.EntityCore.Log(thisSystem.Collections.Generic.IEnumerable_Wawa.Callbacks.Entity_).that'></a>

`that` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Entity](Entity.md 'Wawa.Callbacks.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

This instance of [Selected](Selected.md 'Wawa.Callbacks.Selected').

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Entity](Entity.md 'Wawa.Callbacks.Entity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The parameter [that](EntityCore.Log(IEnumerable{Entity}).md#Wawa.Callbacks.EntityCore.Log(thisSystem.Collections.Generic.IEnumerable_Wawa.Callbacks.Entity_).that 'Wawa.Callbacks.EntityCore.Log(this System.Collections.Generic.IEnumerable<Wawa.Callbacks.Entity>).that').

### Remarks
  
Since the logger is implicitly created within this function, the logging cannot easily  
be reversed without using the nuclear option [Clear&lt;T&gt;(this Hook&lt;T&gt;)](Generator.Clear{T}(Hook{T}).md 'Wawa.Callbacks.Generator.Clear<T>(this Wawa.Callbacks.Hook<T>)').