# op\\_Implicit Method

namespace: [wawa\.TwitchPlays\.Domains](../../wawa.TwitchPlays.Domains.md)<br />
assembly: [wawa\.TwitchPlays](../../../wawa.TwitchPlays.md)



## Overloads

| Name | Summary |
|------|---------|
| implicit operator Instruction\(CustomYieldInstruction\) | Implicitly calls the constructor\. |
| implicit operator Instruction\(KMSelectable\) | Implicitly calls the constructor\. |
| implicit operator Instruction\(KMSelectable\[\]\) | Implicitly calls the constructor\. |
| implicit operator Instruction\(Quaternion\) | Implicitly calls the constructor\. |
| implicit operator Instruction\(TwitchString\) | Implicitly calls the constructor\. |
| implicit operator Instruction\(YieldInstruction\) | Implicitly calls the constructor\. |

## implicit operator Instruction\(CustomYieldInstruction\)

Implicitly calls the constructor\.

```csharp
public static Instruction op_Implicit(CustomYieldInstruction customYield);
```

### Parameters

__customYield__ : `CustomYieldInstruction`

The `CustomYieldInstruction` to pass in to the constructor\.

### Return Value

[Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)



## implicit operator Instruction\(KMSelectable\)

Implicitly calls the constructor\.

```csharp
public static Instruction op_Implicit(KMSelectable selectable);
```

### Parameters

__selectable__ : `KMSelectable`

The `KMSelectable` to pass in to the constructor\.

### Return Value

[Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)



## implicit operator Instruction\(KMSelectable\[\]\)

Implicitly calls the constructor\.

```csharp
public static Instruction op_Implicit(KMSelectable[] selectables);
```

### Parameters

__selectables__ : `KMSelectable`

The `KMSelectable``Array` to pass in to the constructor\.


### Return Value

[Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)



## implicit operator Instruction\(Quaternion\)

Implicitly calls the constructor\.

```csharp
public static Instruction op_Implicit(Quaternion orientation);
```

### Parameters

__orientation__ : `Quaternion`

The `Quaternion` to pass in to the constructor\.

### Return Value

[Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)



## implicit operator Instruction\(TwitchString\)

Implicitly calls the constructor\.

```csharp
public static Instruction op_Implicit(TwitchString query);
```

### Parameters

__query__ : [TwitchString](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/TwitchString.md)

The [TwitchString](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/TwitchString.md) to pass in to the constructor\.

### Return Value

[Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)



## implicit operator Instruction\(YieldInstruction\)

Implicitly calls the constructor\.

```csharp
public static Instruction op_Implicit(YieldInstruction yield);
```

### Parameters

__yield__ : `YieldInstruction`

The `YieldInstruction` to pass in to the constructor\.

### Return Value

[Instruction](../../../wawa.TwitchPlays/wawa.TwitchPlays.Domains/Instruction.md)



