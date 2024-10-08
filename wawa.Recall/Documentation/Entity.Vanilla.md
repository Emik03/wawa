### [wawa.Recall](wawa.Recall.md 'wawa.Recall').[Entity](Entity.md 'wawa.Recall.Entity')

## Entity.Vanilla Property

Gets the encapsulated `BombComponent` from this instance, if it exists.

```csharp
public wawa.Optionals.Maybe<MonoBehaviour> Vanilla { get; }
```

Implements [Vanilla](IVanilla.Vanilla.md 'wawa.Recall.IVanilla.Vanilla')

#### Property Value
[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')

### Remarks
  
If [wawa.DDL.Access.IsRewritten](https://docs.microsoft.com/en-us/dotnet/api/wawa.DDL.Access.IsRewritten 'wawa.DDL.Access.IsRewritten') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), then it is possible for  
[KMBombModule](https://docs.microsoft.com/en-us/dotnet/api/KMBombModule 'KMBombModule') or [KMNeedyModule](https://docs.microsoft.com/en-us/dotnet/api/KMNeedyModule 'KMNeedyModule') instances to be returned instead.