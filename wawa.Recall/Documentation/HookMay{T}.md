### [Wawa.Recall](Wawa.Recall.md 'Wawa.Recall')

## HookMay<T> Class

Encapsulates a getter [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') and a setter [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to get and set an inner value to  
provide a friendly and easy way to get or set one of multiple types with different [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') signatures  
by using a general [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') that acts as a bridge between them. The getter may [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), and therefore is encapsulated in a [Wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1').

```csharp
public sealed class HookMay<T> : Wawa.Recall.Hook<T>,
Wawa.Recall.IValued<Wawa.Optionals.Maybe<T>>
    where T : System.Delegate
```
#### Type parameters

<a name='Wawa.Recall.HookMay_T_.T'></a>

`T`

The generic which acts as the bridge between multiple types.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Wawa.Recall.Prop&lt;](Prop{T}.md 'Wawa.Recall.Prop<T>')[T](HookMay{T}.md#Wawa.Recall.HookMay_T_.T 'Wawa.Recall.HookMay<T>.T')[&gt;](Prop{T}.md 'Wawa.Recall.Prop<T>') &#129106; [Wawa.Recall.Hook&lt;](Hook{T}.md 'Wawa.Recall.Hook<T>')[T](HookMay{T}.md#Wawa.Recall.HookMay_T_.T 'Wawa.Recall.HookMay<T>.T')[&gt;](Hook{T}.md 'Wawa.Recall.Hook<T>') &#129106; HookMay<T>

Implements [Wawa.Recall.IValued&lt;](IValued{T}.md 'Wawa.Recall.IValued<T>')[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[T](HookMay{T}.md#Wawa.Recall.HookMay_T_.T 'Wawa.Recall.HookMay<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[&gt;](IValued{T}.md 'Wawa.Recall.IValued<T>')

| Properties | |
| :--- | :--- |
| [Value](HookMay{T}.Value.md 'Wawa.Recall.HookMay<T>.Value') | Gets the value. |
