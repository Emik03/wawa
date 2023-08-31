### [Wawa.Callbacks](Wawa.Callbacks.md 'Wawa.Callbacks')

## Prop<T> Class

Encapsulates a getter [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') and a setter [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to get and set an inner value to provide a friendly and easy way to get or set one of multiple types with different [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') signatures by using a general [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') that acts as a bridge between them.

```csharp
public abstract class Prop<T> :
System.ICloneable
```
#### Type parameters

<a name='Wawa.Callbacks.Prop_T_.T'></a>

`T`

The generic which acts as the bridge between multiple types.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Prop<T>

Derived  
&#8627; [Hook&lt;T&gt;](Hook{T}.md 'Wawa.Callbacks.Hook<T>')  
&#8627; [PropDef&lt;T&gt;](PropDef{T}.md 'Wawa.Callbacks.PropDef<T>')  
&#8627; [PropMay&lt;T&gt;](PropMay{T}.md 'Wawa.Callbacks.PropMay<T>')

Implements [System.ICloneable](https://docs.microsoft.com/en-us/dotnet/api/System.ICloneable 'System.ICloneable')