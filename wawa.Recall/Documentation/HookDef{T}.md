### [wawa.Recall](wawa.Recall.md 'wawa.Recall')

## HookDef<T> Class

Encapsulates a getter [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') and a setter [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to get and set an inner value to  
provide a friendly and easy way to get or set one of multiple types with different [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') signatures  
by using a general [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') that acts as a bridge between them. The getter may [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), and therefore is encapsulated in a [wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1').

```csharp
public sealed class HookDef<T> : wawa.Recall.Hook<T>,
wawa.Recall.IValued<T>
    where T : System.Delegate
```
#### Type parameters

<a name='wawa.Recall.HookDef_T_.T'></a>

`T`

The generic which acts as the bridge between multiple types.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [wawa.Recall.Prop&lt;](Prop{T}.md 'wawa.Recall.Prop<T>')[T](HookDef{T}.md#wawa.Recall.HookDef_T_.T 'wawa.Recall.HookDef<T>.T')[&gt;](Prop{T}.md 'wawa.Recall.Prop<T>') &#129106; [wawa.Recall.Hook&lt;](Hook{T}.md 'wawa.Recall.Hook<T>')[T](HookDef{T}.md#wawa.Recall.HookDef_T_.T 'wawa.Recall.HookDef<T>.T')[&gt;](Hook{T}.md 'wawa.Recall.Hook<T>') &#129106; HookDef<T>

Implements [wawa.Recall.IValued&lt;](IValued{T}.md 'wawa.Recall.IValued<T>')[T](HookDef{T}.md#wawa.Recall.HookDef_T_.T 'wawa.Recall.HookDef<T>.T')[&gt;](IValued{T}.md 'wawa.Recall.IValued<T>')

| Properties | |
| :--- | :--- |
| [Value](HookDef{T}.Value.md 'wawa.Recall.HookDef<T>.Value') | Gets the value. |
