# FromInstructions Method

namespace: [wawa\.TwitchPlays\.Domains](../../wawa.TwitchPlays.Domains.md)<br />
assembly: [wawa\.TwitchPlays](../../../wawa.TwitchPlays.md)



## Overloads

| Name | Summary |
|------|---------|
| FromInstructions\(IEnumerable\<Instruction\>\) | Converts the `IEnumerable<T>` to a `new`[Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)\. |
| FromInstructions\(IEnumerator\<Instruction\>\) | Converts the `IEnumerator<T>` to a `new`[Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)\. |
| FromInstructions\(params Instruction\[\]\) | Converts the `Array` to a `new`[Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)\. |

## FromInstructions\(IEnumerable\<Instruction\>\)

Converts the `IEnumerable<T>` to a `new`[Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)\.

```csharp
public static Instruction FromInstructions(IEnumerable<Instruction> enumerable);
```

### Parameters

__enumerable__ : `IEnumerable<Instruction>`

The `IEnumerable<T>` instance to convert\.

### Return Value

[Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)

A `new`[Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md) instance encapsulating `enumerable`\.

## FromInstructions\(IEnumerator\<Instruction\>\)

Converts the `IEnumerator<T>` to a `new`[Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)\.

```csharp
public static Instruction FromInstructions(IEnumerator<Instruction> enumerator);
```

### Parameters

__enumerator__ : `IEnumerator<Instruction>`

The `IEnumerator<T>` instance to convert\.

### Return Value

[Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)

A `new`[Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md) instance encapsulating `enumerator`\.

## FromInstructions\(params Instruction\[\]\)

Converts the `Array` to a `new`[Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)\.

```csharp
public static Instruction FromInstructions(params Instruction[] array);
```

### Parameters

__array__ : [Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)

The `IEnumerable<T>` instance to convert\.

### Return Value

[Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)

A `new`[Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md) instance encapsulating `array`\.

