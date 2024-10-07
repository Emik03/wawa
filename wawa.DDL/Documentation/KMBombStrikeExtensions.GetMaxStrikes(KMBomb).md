### [wawa.DDL](wawa.DDL.md 'wawa.DDL').[KMBombStrikeExtensions](KMBombStrikeExtensions.md 'wawa.DDL.KMBombStrikeExtensions')

## KMBombStrikeExtensions.GetMaxStrikes(this KMBomb) Method

Gets the number of max strikes.<p/>`[MustUseReturnValue, NonNegativeValue]`

```csharp
public static int GetMaxStrikes(this KMBomb that);
```
#### Parameters

<a name='wawa.DDL.KMBombStrikeExtensions.GetMaxStrikes(thisKMBomb).that'></a>

`that` [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb')

The [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb') module instance to grab max strikes from.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number of max strikes.

### Remarks
  
In the editor, this value always returns `0`.