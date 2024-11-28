# Play Method

namespace: [wawa\.Modules](../../wawa.Modules.md)<br />
assembly: [wawa\.Modules](../../../wawa.Modules.md)



## Overloads

| Name | Summary |
|------|---------|
| Play\(params Sound\[\]\) | Plays one or more sounds from the module `Transform`\. |
| Play\(Transform, params Sound\[\]\) | Plays one or more sounds from the specified `Transform`\. |

## Play\(params Sound\[\]\)

Plays one or more sounds from the module `Transform`\.

```csharp
public IList<Sound> Play(params Sound[] sounds);
```

### Parameters

__sounds__ : [Sound](../../../wawa.Modules/wawa.Modules/Sound.md)

The sounds to play\.

### Return Value

`IList<Sound>`

The parameter `sounds`\.

## Play\(Transform, params Sound\[\]\)

Plays one or more sounds from the specified `Transform`\.

```csharp
public IList<Sound> Play(Transform location ,params Sound[] sounds);
```

### Parameters

__location__ : `Transform`

The source of the sound\.

__sounds__ : [Sound](../../../wawa.Modules/wawa.Modules/Sound.md)

The sounds to play\.

### Return Value

`IList<Sound>`

The parameter `sounds`\.

