### [Wawa.DDL](Wawa.DDL.md 'Wawa.DDL').[KMBombStrikeExtensions](KMBombStrikeExtensions.md 'Wawa.DDL.KMBombStrikeExtensions')

## KMBombStrikeExtensions.GetRate(this KMBomb, bool) Method

Gets the rate in which the timer ticks.

```csharp
public static float GetRate(this KMBomb that, bool signFlip=false);
```
#### Parameters

<a name='Wawa.DDL.KMBombStrikeExtensions.GetRate(thisKMBomb,bool).that'></a>

`that` [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb')

The [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb') module instance to grab the rate from.

<a name='Wawa.DDL.KMBombStrikeExtensions.GetRate(thisKMBomb,bool).signFlip'></a>

`signFlip` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

When true, invert the returned value when the component from [that](KMBombStrikeExtensions.GetRate(KMBomb,bool).md#Wawa.DDL.KMBombStrikeExtensions.GetRate(thisKMBomb,bool).that 'Wawa.DDL.KMBombStrikeExtensions.GetRate(this KMBomb, bool).that') ticks backwards.

#### Returns
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The speed of the ticking.

### Remarks
  
In the editor, this value always returns 1.