# Instruction Constructor

namespace: [wawa\.TwitchPlays\.Domains](../../wawa.TwitchPlays.Domains.md)<br />
assembly: [wawa\.TwitchPlays](../../../wawa.TwitchPlays.md)

Initializes a new instance of the [Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md) class\.

## Overloads

| Name | Summary |
|------|---------|
| Instruction\(string, string\) | Initializes a new instance of the [Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md) class\. |
| Instruction\(IEnumerable\<Instruction\>\) | Initializes a new instance of the [Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md) class\. |
| Instruction\(IEnumerator\<Instruction\>\) | Initializes a new instance of the [Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md) class\. |
| Instruction\(Quaternion, Quaternion\) | Initializes a new instance of the [Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md) class\. |
| Instruction\(TwitchString\) | Initializes a new instance of the [Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md) class\. |

## Instruction\(string, string\)

Initializes a new instance of the [Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md) class\.

```csharp
public Instruction(string reason = null ,string moduleName = null);
```

### Parameters

__reason__ : `string`

The optional reason for the explosion\.

__moduleName__ : `string`

The override of the module name that caused the explosion\.

## Instruction\(IEnumerable\<Instruction\>\)

Initializes a new instance of the [Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md) class\.

```csharp
public Instruction(IEnumerable<Instruction> enumerator);
```

### Parameters

__enumerator__ : `IEnumerable<Instruction>`

The value to pass in\.

## Instruction\(IEnumerator\<Instruction\>\)

Initializes a new instance of the [Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md) class\.

```csharp
public Instruction(IEnumerator<Instruction> enumerator);
```

### Parameters

__enumerator__ : `IEnumerator<Instruction>`

The value to pass in\.

## Instruction\(Quaternion, Quaternion\)

Initializes a new instance of the [Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md) class\.

```csharp
public Instruction(Quaternion first ,Quaternion second);
```

### Parameters

__first__ : `Quaternion`

For the Bomb\. The form of
`(Quaternion.Euler(x, 0, 0) * Quaternion.Euler(0, y, 0) * (Quaternion.Euler(0, 0, z))`\.


__second__ : `Quaternion`

For the camera side view\. The second one in the form of `Quaternion.Euler(x, y, z)`\.


## Instruction\(TwitchString\)

Initializes a new instance of the [Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md) class\.

```csharp
public Instruction(TwitchString value);
```

### Parameters

__value__ : [TwitchString](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/TwitchString.md)

The value to pass in\.

