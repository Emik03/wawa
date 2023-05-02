### [Wawa.IO](Wawa.IO.md 'Wawa.IO').[Config](Config.md 'Wawa.IO.Config')

## Config.Serialize<TSerialize>(TSerialize) Method

Serializes settings the same way it's written to the file. Supports settings that use enums.

```csharp
public static string Serialize<TSerialize>(TSerialize value);
```
#### Type parameters

<a name='Wawa.IO.Config.Serialize_TSerialize_(TSerialize).TSerialize'></a>

`TSerialize`

The type to serialize the value.
#### Parameters

<a name='Wawa.IO.Config.Serialize_TSerialize_(TSerialize).value'></a>

`value` [TSerialize](Config.Serialize(TSerialize).md#Wawa.IO.Config.Serialize_TSerialize_(TSerialize).TSerialize 'Wawa.IO.Config.Serialize<TSerialize>(TSerialize).TSerialize')

The value to serialize.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') representation of [value](Config.Serialize(TSerialize).md#Wawa.IO.Config.Serialize_TSerialize_(TSerialize).value 'Wawa.IO.Config.Serialize<TSerialize>(TSerialize).value') by serializing it as JSON.