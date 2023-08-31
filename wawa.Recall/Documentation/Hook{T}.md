### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall')

## Hook<T> Class

Encapsulates a getter [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') and a setter [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to get and set an inner value to  
provide a friendly and easy way to get or set one of multiple types with different [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') signatures  
by using a general [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') that acts as a bridge between them. The getter may [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), and therefore is encapsulated in a [Wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1').

```csharp
public abstract class Hook<T> : Wawa.Recall.Prop<T>
    where T : System.Delegate
```
#### Type parameters

<a name='Wawa.Recall.Hook_T_.T'></a>

`T`

The generic which acts as the bridge between multiple types.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Wawa.Recall.Prop&lt;](Prop{T}.md 'Wawa.Recall.Prop<T>')[T](Hook{T}.md#Wawa.Recall.Hook_T_.T 'Wawa.Recall.Hook<T>.T')[&gt;](Prop{T}.md 'Wawa.Recall.Prop<T>') &#129106; Hook<T>

Derived  
&#8627; [HookDef&lt;T&gt;](HookDef{T}.md 'Wawa.Recall.HookDef<T>')  
&#8627; [HookMay&lt;T&gt;](HookMay{T}.md 'Wawa.Recall.HookMay<T>')