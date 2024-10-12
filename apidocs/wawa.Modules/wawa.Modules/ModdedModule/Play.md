# Play Method

namespace: [wawa\.Modules](../../wawa.Modules.md)<br />
assembly: [wawa\.Modules](../../../wawa.Modules.md)



## Overloads

| Name | Summary |
|------|---------|
| Play\(params Sound\[\]\) | Plays one or more sounds from the module `Transform`\. |
| Play\(Transform, params Sound\[\]\) | Plays one or more sounds from a specified `Transform`\. |
| Play\<T\>\(T, Transform\) | Plays one or more sounds from a specified `Transform`\. |

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

Plays one or more sounds from a specified `Transform`\.

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

## Play\<T\>\(T, Transform\)

Plays one or more sounds from a specified `Transform`\.

```csharp
public T Play<T>(T sounds ,Transform location = null);
```

### Type Parameters

__T__ : `IEnumerable<Sound>`

The type of iterator\.

### Parameters

__sounds__ : `T`

The sounds to play\.

__location__ : `Transform`

The source of the sound\.

### Return Value

`T`

The parameter `sounds`\.

