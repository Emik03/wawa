### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks')

## HookMay<T> Class

Encapsulates a getter [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') and a setter [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to get and set an inner value to  
provide a friendly and easy way to get or set one of multiple types with different [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') signatures  
by using a general [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') that acts as a bridge between them. The getter may [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), and therefore is encapsulated in a [Wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1').

```csharp
public sealed class HookMay<T> : Wawa.Callbacks.Hook<T>,
Wawa.Callbacks.IValued<Wawa.Optionals.Maybe<T>>
    where T : System.Delegate
```
#### Type parameters

<a name='Wawa.Callbacks.HookMay_T_.T'></a>

`T`

The generic which acts as the bridge between multiple types.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Wawa.Callbacks.Prop&lt;](Prop{T}.md 'Wawa.Callbacks.Prop<T>')[T](HookMay{T}.md#Wawa.Callbacks.HookMay_T_.T 'Wawa.Callbacks.HookMay<T>.T')[&gt;](Prop{T}.md 'Wawa.Callbacks.Prop<T>') &#129106; [Wawa.Callbacks.Hook&lt;](Hook{T}.md 'Wawa.Callbacks.Hook<T>')[T](HookMay{T}.md#Wawa.Callbacks.HookMay_T_.T 'Wawa.Callbacks.HookMay<T>.T')[&gt;](Hook{T}.md 'Wawa.Callbacks.Hook<T>') &#129106; HookMay<T>

Implements [Wawa.Callbacks.IValued&lt;](IValued{T}.md 'Wawa.Callbacks.IValued<T>')[Wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[T](HookMay{T}.md#Wawa.Callbacks.HookMay_T_.T 'Wawa.Callbacks.HookMay<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Wawa.Optionals.Maybe-1 'Wawa.Optionals.Maybe`1')[&gt;](IValued{T}.md 'Wawa.Callbacks.IValued<T>')

| Properties | |
| :--- | :--- |
| [Value](HookMay{T}.Value.md 'Wawa.Callbacks.HookMay<T>.Value') | Gets the value. |
