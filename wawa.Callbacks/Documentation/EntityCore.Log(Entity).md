### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[EntityCore](EntityCore.md 'Wawa.Callbacks.EntityCore')

## EntityCore.Log(this Entity) Method

Hooks the logger to each instance.

```csharp
public static Wawa.Callbacks.Entity Log(this Wawa.Callbacks.Entity that);
```
#### Parameters

<a name='Wawa.Callbacks.EntityCore.Log(thisWawa.Callbacks.Entity).that'></a>

`that` [Entity](Entity.md 'Wawa.Callbacks.Entity')

This instance of [Selected](Selected.md 'Wawa.Callbacks.Selected').

#### Returns
[Entity](Entity.md 'Wawa.Callbacks.Entity')  
The parameter [that](EntityCore.Log(Entity).md#Wawa.Callbacks.EntityCore.Log(thisWawa.Callbacks.Entity).that 'Wawa.Callbacks.EntityCore.Log(this Wawa.Callbacks.Entity).that').

### Remarks
  
Since the logger is implicitly created within this function, the logging cannot easily  
be reversed without using the nuclear option [Clear&lt;T&gt;(this Hook&lt;T&gt;)](Generator.Clear{T}(Hook{T}).md 'Wawa.Callbacks.Generator.Clear<T>(this Wawa.Callbacks.Hook<T>)').