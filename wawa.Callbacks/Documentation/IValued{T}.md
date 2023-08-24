### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks')

## IValued<T> Interface

An interface for all property-like class behaviors.

```csharp
public interface IValued<out T>
```
#### Type parameters

<a name='Wawa.Callbacks.IValued_T_.T'></a>

`T`

The type of value to [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') from the getter.

Derived  
&#8627; [HookDef&lt;T&gt;](HookDef{T}.md 'Wawa.Callbacks.HookDef<T>')  
&#8627; [HookMay&lt;T&gt;](HookMay{T}.md 'Wawa.Callbacks.HookMay<T>')  
&#8627; [PropDef&lt;T&gt;](PropDef{T}.md 'Wawa.Callbacks.PropDef<T>')  
&#8627; [PropMay&lt;T&gt;](PropMay{T}.md 'Wawa.Callbacks.PropMay<T>')

| Properties | |
| :--- | :--- |
| [Value](IValued{T}.Value.md 'Wawa.Callbacks.IValued<T>.Value') | Gets the value. |
