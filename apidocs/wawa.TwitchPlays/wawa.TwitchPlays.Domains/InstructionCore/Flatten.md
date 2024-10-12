# Flatten\(IEnumerable\<Instruction\>\) Method

namespace: [wawa\.TwitchPlays\.Domains](../../wawa.TwitchPlays.Domains.md)<br />
assembly: [wawa\.TwitchPlays](../../../wawa.TwitchPlays.md)

Flattens the enumeration for coroutine use\.

```csharp
public static IEnumerator<object> Flatten(this IEnumerable<Instruction> that);
```

## Parameters

__that__ : `IEnumerable<Instruction>`

This instance of `IEnumerable<T>`\.

## Return Value

`IEnumerator<object>`

An `IEnumerator<T>` of `System.Object` that is friendly to be used for coroutines,
containing the values from `that`\.

