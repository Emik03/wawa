### [wawa.DDL](wawa.DDL.md 'wawa.DDL').[KMBombStrikeExtensions](KMBombStrikeExtensions.md 'wawa.DDL.KMBombStrikeExtensions')

## KMBombStrikeExtensions.GetRate(this KMBomb, bool) Method

Gets the rate in which the timer ticks.<p/>`[MustUseReturnValue]`

```csharp
public static float GetRate(this KMBomb that, bool signFlip=false);
```
#### Parameters

<a name='wawa.DDL.KMBombStrikeExtensions.GetRate(thisKMBomb,bool).that'></a>

`that` [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb')

The [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb') module instance to grab the rate from.

<a name='wawa.DDL.KMBombStrikeExtensions.GetRate(thisKMBomb,bool).signFlip'></a>

`signFlip` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), invert the returned value when  
the component from [that](KMBombStrikeExtensions.GetRate(KMBomb,bool).md#wawa.DDL.KMBombStrikeExtensions.GetRate(thisKMBomb,bool).that 'wawa.DDL.KMBombStrikeExtensions.GetRate(this KMBomb, bool).that') ticks backwards.

#### Returns
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The speed of the ticking.

### Remarks
  
In the editor, this value always returns `1`.