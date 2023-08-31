### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall').[EntityCore](EntityCore.md 'Wawa.Recall.EntityCore')

## EntityCore.Log(this Entity) Method

Hooks the logger to each instance.

```csharp
public static Wawa.Recall.Entity Log(this Wawa.Recall.Entity that);
```
#### Parameters

<a name='Wawa.Recall.EntityCore.Log(thisWawa.Recall.Entity).that'></a>

`that` [Entity](Entity.md 'Wawa.Recall.Entity')

This instance of [Selected](Selected.md 'Wawa.Recall.Selected').

#### Returns
[Entity](Entity.md 'Wawa.Recall.Entity')  
The parameter [that](EntityCore.Log(Entity).md#Wawa.Recall.EntityCore.Log(thisWawa.Recall.Entity).that 'Wawa.Recall.EntityCore.Log(this Wawa.Recall.Entity).that').

### Remarks
  
Since the logger is implicitly created within this function, the logging cannot easily  
be reversed without using the nuclear option [Clear&lt;T&gt;(this Hook&lt;T&gt;)](Generator.Clear{T}(Hook{T}).md 'Wawa.Recall.Generator.Clear<T>(this Wawa.Recall.Hook<T>)').