### [wawa.Recall](wawa.Recall.md 'wawa.Recall')

## IValued<T> Interface

An interface for all property-like class behaviors.

```csharp
public interface IValued<out T>
```
#### Type parameters

<a name='wawa.Recall.IValued_T_.T'></a>

`T`

The type of value to [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') from the getter.

Derived  
&#8627; [HookDef&lt;T&gt;](HookDef{T}.md 'wawa.Recall.HookDef<T>')  
&#8627; [HookMay&lt;T&gt;](HookMay{T}.md 'wawa.Recall.HookMay<T>')  
&#8627; [PropDef&lt;T&gt;](PropDef{T}.md 'wawa.Recall.PropDef<T>')  
&#8627; [PropMay&lt;T&gt;](PropMay{T}.md 'wawa.Recall.PropMay<T>')

| Properties | |
| :--- | :--- |
| [Value](IValued{T}.Value.md 'wawa.Recall.IValued<T>.Value') | Gets the value. |
