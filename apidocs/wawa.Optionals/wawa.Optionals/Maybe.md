# Maybe Class

namespace: [wawa\.Optionals](../wawa.Optionals.md)<br />
assembly: [wawa\.Optionals](../../wawa.Optionals.md)

Implementations for [Maybe\<T\>](../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\.

```csharp
public static class Maybe;
```

Inheritance: `object` > Maybe

## Methods

| Name | Summary |
|------|---------|
| [TryGet\<T\>\(Maybe\<T\>, out T\)](./Maybe/TryGet.md) | Assigns a value with the inner value, or a `default` value if none exists\. |
| [Filter\<T\>\(IEnumerable\<Maybe\<T\>\>\)](./Maybe/Filter.md) | Filters a collection with only that of items with a value\. |
| [None\<T\>\(\)](./Maybe/None.md) | Gets an empty [Maybe\<T\>](../../wawa.Optionals/wawa.Optionals/Maybe\`1.md) of the desired type\. |
| [Match\<T\>\(Maybe\<T\>, Action\<T\>, Action\<Unit\>\)](./Maybe/Match.md) | Uses the callback corresponding to the inner value of `that`\. |
| [And\<T\>\(Maybe\<T\>, Maybe\<T\>\)](./Maybe/And.md) | Gives itself, or the parameter\. |
| [And\<T\>\(Maybe\<T\>, Func\<Unit, Maybe\<T\>\>\)](./Maybe/And.md) | Gives itself, or the parameter\. |
| [Or\<T\>\(Maybe\<T\>, Maybe\<T\>\)](./Maybe/Or.md) | Gives itself, or the parameter\. |
| [Or\<T\>\(Maybe\<T\>, Func\<Unit, Maybe\<T\>\>\)](./Maybe/Or.md) | Gives itself, or the parameter\. |
| [Xor\<T\>\(Maybe\<T\>, Maybe\<T\>\)](./Maybe/Xor.md) | Gives itself, or the parameter\. |
| [Some\<T\>\(T\)](./Maybe/Some.md) | Wraps `T` in a [Maybe\<T\>](../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\. |
| [Flatten\<T\>\(Maybe\<Maybe\<T\>\>\)](./Maybe/Flatten.md) | Flattens a nested [Maybe\<T\>](../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\. |
| [Flatten\<T\>\(Maybe\<Maybe\<Maybe\<T\>\>\>\)](./Maybe/Flatten.md) | Flattens a nested [Maybe\<T\>](../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\. |
| [Flatten\<T\>\(Maybe\<Maybe\<Maybe\<Maybe\<T\>\>\>\>\)](./Maybe/Flatten.md) | Flattens a nested [Maybe\<T\>](../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\. |
| [From\<T\>\(T\)](./Maybe/From.md) | Wraps `T` in a [Maybe\<T\>](../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\. |
| [From\<T\>\(T?\)](./Maybe/From.md) | Wraps `T` in a [Maybe\<T\>](../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\. |
| [AsMaybe\<T\>\(T?\)](./Maybe/AsMaybe.md) | Creates a `Nullable<T>` from a [Maybe\<T\>](../../wawa.Optionals/wawa.Optionals/Maybe\`1.md)\. |
| [As\<T, TResult\>\(Maybe\<T\>\)](./Maybe/As.md) | Upcasts this instance to `TResult`\. |
| [Match\<T, TResult\>\(Maybe\<T\>, Func\<T, Maybe\<TResult\>\>\)](./Maybe/Match.md) | Uses the callback corresponding to the inner value of `that`\. |
| [Match\<T, TResult\>\(Maybe\<T\>, Func\<T, TResult\>\)](./Maybe/Match.md) | Uses the callback corresponding to the inner value of `that`\. |
| [Match\<T, TResult\>\(Maybe\<T\>, TResult\)](./Maybe/Match.md) | Gives the parameter corresponding to the inner value of `that`\. |
| [Unwrap\<T\>\(Maybe\<T\>\)](./Maybe/Unwrap.md) | Gets the value that is encapsulated\. This value returned will not be `null`,and consequentially if it is\. |
| [UnwrapOr\<T\>\(Maybe\<T\>, T\)](./Maybe/UnwrapOr.md) | Gives the inner value, or the parameter\. |
| [UnwrapOr\<T\>\(Maybe\<T\>, Func\<Unit, T\>\)](./Maybe/UnwrapOr.md) | Gives the inner value, or the returned value from the callback\. |
| [UnwrapOrDefault\<T\>\(Maybe\<T\>\)](./Maybe/UnwrapOrDefault.md) | Gives the inner value, or `default`\. |
| [UnwrapOrNew\<T\>\(Maybe\<T\>\)](./Maybe/UnwrapOrNew.md) | Gives the inner value, or a `new` instance\. |
| [AsNullable\<T\>\(Maybe\<T\>\)](./Maybe/AsNullable.md) | Creates a [Maybe\<T\>](../../wawa.Optionals/wawa.Optionals/Maybe\`1.md) from a `Nullable<T>`\. |
| [Match\<T, TResult\>\(Maybe\<T\>, Func\<T, TResult\>, Func\<Unit, TResult\>\)](./Maybe/Match.md) | Uses the callback corresponding to the inner value of `that`\. |
| [Match\<T, TResult\>\(Maybe\<T\>, TResult, TResult\)](./Maybe/Match.md) | Gives the parameter corresponding to the inner value of `that`\. |

