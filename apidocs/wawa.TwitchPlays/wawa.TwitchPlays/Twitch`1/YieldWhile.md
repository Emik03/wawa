# YieldWhile\<T\>\(T, Func\<bool\>\) Method

namespace: [wawa\.TwitchPlays](../../wawa.TwitchPlays.md)<br />
assembly: [wawa\.TwitchPlays](../../../wawa.TwitchPlays.md)

You can `yield``return` this to repeatedly
`yield``return` an item until a condition is no longer met\.

```csharp
protected static IEnumerable<T> YieldWhile<T>(T item ,Func<bool> condition);
```

## Type Parameters

__T__

The `Type` of the items that are yielded\.

## Parameters

__item__ : `T`

The item to yield repeatedly\.

__condition__ : `Func<bool>`

The condition to repeatedly check until it returns `false`\.

## Return Value

`IEnumerable<T>`

`item` continuously until `condition` is `false`\.

