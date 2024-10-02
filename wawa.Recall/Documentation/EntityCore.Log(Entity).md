### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[EntityCore](EntityCore.md 'wawa.Recall.EntityCore')

## EntityCore.Log(this Entity) Method

Hooks the logger to each instance.

```csharp
public static wawa.Recall.Entity Log(this wawa.Recall.Entity that);
```
#### Parameters

<a name='wawa.Recall.EntityCore.Log(thiswawa.Recall.Entity).that'></a>

`that` [Entity](Entity.md 'wawa.Recall.Entity')

This instance of [Selected](Selected.md 'wawa.Recall.Selected').

#### Returns
[Entity](Entity.md 'wawa.Recall.Entity')  
The parameter [that](EntityCore.Log(Entity).md#wawa.Recall.EntityCore.Log(thiswawa.Recall.Entity).that 'wawa.Recall.EntityCore.Log(this wawa.Recall.Entity).that').

### Remarks
  
Since the logger is implicitly created within this function, the logging cannot easily  
be reversed without using the nuclear option [Clear&lt;T&gt;(this Hook&lt;T&gt;)](Generator.Clear{T}(Hook{T}).md 'wawa.Recall.Generator.Clear<T>(this wawa.Recall.Hook<T>)').