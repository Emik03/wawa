# Config\<T\> Class

namespace: [wawa\.IO](../wawa.IO.md)<br />
assembly: [wawa\.IO](../../wawa.IO.md)

Meant for information that needs to be deserialized within the mod settings folder\.

```csharp
public sealed class Config<T> where T : new();
```

## Type Parameters

__T__ : `new()`

The type to serialize and deserialize the file\.

Inheritance: `ICloneable` > Config<T>

Implements: `IEquatable<Config<T>>`, `IEqualityComparer<Config<T>>`

## Remarks



Originally by samfundev: https://github\.com/samfundev/KTANE\-Utilities/blob/master/ModConfig\.cs\.



All constructors in this type have the following side effects:


- A file will automatically be made if it doesn't exist\.
- 
A JSON property defined in the type `T` that doesn't exist in the file
will automatically be appended with a new default instance of `T`'s values\.

- 
In the editor, this constructor will not merge the default of type `T` with the file\.




## Constructors

| Name | Summary |
|------|---------|
| [Config\(\)](./Config\`1/$ctor.md) | Initializes a new instance of the [Config\<T\>](../../wawa.IO/wawa.IO/Config\`1.md) class\. |
| [Config\(string\)](./Config\`1/$ctor.md) | Initializes a new instance of the [Config\<T\>](../../wawa.IO/wawa.IO/Config\`1.md) class\. |

## Methods

| Name | Summary |
|------|---------|
| [Clone\(\)](./Config\`1/Clone.md) |  |
| [Equals\(Config\<T\>, Config\<T\>\)](./Config\`1/Equals.md) |  |
| [GetHashCode\(Config\<T\>\)](./Config\`1/GetHashCode.md) |  |
| [Equals\(Config\<T\>\)](./Config\`1/Equals.md) |  |
| [operator ==\(Config\<T\>, Config\<T\>\)](./Config\`1/op_Equality.md) | Determines whether both instances are both `null` or both instances\. |
| [operator \!=\(Config\<T\>, Config\<T\>\)](./Config\`1/op_Inequality.md) | Determines whether both instances are one of `null` and the other instanced\. |
| [Equals\(object\)](./Config\`1/Equals.md) |  |
| [GetHashCode\(\)](./Config\`1/GetHashCode.md) |  |
| [ToString\(\)](./Config\`1/ToString.md) | Deserializes, then re\-serializes the file according to [Serialize\<TSerialize\>\(TSerialize\)](../../wawa.IO/wawa.IO/Config/Serialize.md)\.In the editor, this method serializes the default value of the constructor in `T`\. |

## Properties

| Name | Summary |
|------|---------|
| [HasRead](./Config\`1/HasRead.md) | Gets a value indicating whether there has been a successful read of the settings file\. |
| [FilePath](./Config\`1/FilePath.md) | Gets the path of the file to read and write\. |

