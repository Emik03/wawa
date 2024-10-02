### [wawa.Recall](wawa.Recall.md 'wawa.Recall')

## PropMay<T> Class

Encapsulates a getter [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') and a setter [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to get and set an inner value to  
provide a friendly and easy way to get or set one of multiple types with different [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') signatures  
by using a general [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') that acts as a bridge between them. The getter may [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), and therefore is encapsulated in a [wawa.Optionals.Maybe&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1').

```csharp
public sealed class PropMay<T> : wawa.Recall.Prop<T>,
wawa.Recall.IValued<wawa.Optionals.Maybe<T>>
```
#### Type parameters

<a name='wawa.Recall.PropMay_T_.T'></a>

`T`

The generic which acts as the bridge between multiple types.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [wawa.Recall.Prop&lt;](Prop{T}.md 'wawa.Recall.Prop<T>')[T](PropMay{T}.md#wawa.Recall.PropMay_T_.T 'wawa.Recall.PropMay<T>.T')[&gt;](Prop{T}.md 'wawa.Recall.Prop<T>') &#129106; PropMay<T>

Implements [wawa.Recall.IValued&lt;](IValued{T}.md 'wawa.Recall.IValued<T>')[wawa.Optionals.Maybe&lt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[T](PropMay{T}.md#wawa.Recall.PropMay_T_.T 'wawa.Recall.PropMay<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/wawa.Optionals.Maybe-1 'wawa.Optionals.Maybe`1')[&gt;](IValued{T}.md 'wawa.Recall.IValued<T>')

| Properties | |
| :--- | :--- |
| [Value](PropMay{T}.Value.md 'wawa.Recall.PropMay<T>.Value') | Gets the value. |
