### [wawa.DDL](wawa.DDL.md 'wawa.DDL').[KMBombStrikeExtensions](KMBombStrikeExtensions.md 'wawa.DDL.KMBombStrikeExtensions')

## KMBombStrikeExtensions.SetMaxStrikes(this KMBomb, int, bool) Method

Sets the number of max strikes.

```csharp
public static KMBomb SetMaxStrikes(this KMBomb that, int value, bool tryDetonate=false);
```
#### Parameters

<a name='wawa.DDL.KMBombStrikeExtensions.SetMaxStrikes(thisKMBomb,int,bool).that'></a>

`that` [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb')

The [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb') module instance to grab max strikes from.

<a name='wawa.DDL.KMBombStrikeExtensions.SetMaxStrikes(thisKMBomb,int,bool).value'></a>

`value` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The value to set it to.

<a name='wawa.DDL.KMBombStrikeExtensions.SetMaxStrikes(thisKMBomb,int,bool).tryDetonate'></a>

`tryDetonate` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), check for whether detonation should occur.

#### Returns
[KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb')  
The parameter [that](KMBombStrikeExtensions.SetMaxStrikes(KMBomb,int,bool).md#wawa.DDL.KMBombStrikeExtensions.SetMaxStrikes(thisKMBomb,int,bool).that 'wawa.DDL.KMBombStrikeExtensions.SetMaxStrikes(this KMBomb, int, bool).that').

### Remarks
  
In the editor, this method does nothing.