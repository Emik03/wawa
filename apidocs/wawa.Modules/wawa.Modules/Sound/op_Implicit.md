# op\\_Implicit Method

namespace: [wawa\.Modules](../../wawa.Modules.md)<br />
assembly: [wawa\.Modules](../../../wawa.Modules.md)



## Overloads

| Name | Summary |
|------|---------|
| implicit operator Sound\(string\) | Implicitly calls the constructor\. |
| implicit operator Sound\(SoundEffect\) | Implicitly calls the constructor\. |

## implicit operator Sound\(string\)

Implicitly calls the constructor\.

```csharp
public static Sound op_Implicit(string sound);
```

### Parameters

__sound__ : `string`

The `System.String` to pass in to the constructor\.

### Return Value

[Sound](../../../wawa.Modules/wawa.Modules/Sound.md)



## implicit operator Sound\(SoundEffect\)

Implicitly calls the constructor\.

```csharp
public static Sound op_Implicit(SoundEffect sound);
```

### Parameters

__sound__ : `SoundEffect`

The `SoundEffect` to pass in to the constructor\.

### Return Value

[Sound](../../../wawa.Modules/wawa.Modules/Sound.md)



