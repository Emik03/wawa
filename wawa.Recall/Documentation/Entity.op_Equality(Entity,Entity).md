### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks').[Entity](Entity.md 'Wawa.Callbacks.Entity')

## Entity.operator ==(Entity, Entity) Operator

Determines whether both instances point to the same component.

```csharp
public static bool operator ==(Wawa.Callbacks.Entity? left, Wawa.Callbacks.Entity? right);
```
#### Parameters

<a name='Wawa.Callbacks.Entity.op_Equality(Wawa.Callbacks.Entity,Wawa.Callbacks.Entity).left'></a>

`left` [Entity](Entity.md 'Wawa.Callbacks.Entity')

The left-hand side.

<a name='Wawa.Callbacks.Entity.op_Equality(Wawa.Callbacks.Entity,Wawa.Callbacks.Entity).right'></a>

`right` [Entity](Entity.md 'Wawa.Callbacks.Entity')

The right-hand side.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if both of them point to the same component, otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').