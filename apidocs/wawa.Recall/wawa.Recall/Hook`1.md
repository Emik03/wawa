# Hook\<T\> Class

namespace: [wawa\.Recall](../wawa.Recall.md)<br />
assembly: [wawa\.Recall](../../wawa.Recall.md)

Encapsulates a getter `Delegate` and a setter `Delegate` to get and set an inner value to
provide a friendly and easy way to get or set one of multiple types with different `Type` signatures
by using a general `Type` that acts as a bridge between them\. The getter may `return``null`, and therefore is encapsulated in a [Maybe\<T\>](../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

```csharp
public abstract class Hook<T>;
```

## Type Parameters

__T__ : `Delegate`

The generic which acts as the bridge between multiple types\.

Inheritance: `ICloneable` > [Prop\<T\>](../../wawa.Recall/wawa.Recall/Prop\`1.md) > Hook<T>

