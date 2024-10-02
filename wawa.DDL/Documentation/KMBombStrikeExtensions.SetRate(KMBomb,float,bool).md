### [wawa.DDL](wawa.DDL.md 'wawa.DDL').[KMBombStrikeExtensions](KMBombStrikeExtensions.md 'wawa.DDL.KMBombStrikeExtensions')

## KMBombStrikeExtensions.SetRate(this KMBomb, float, bool) Method

Sets the rate in which the timer ticks.

```csharp
public static KMBomb SetRate(this KMBomb that, float value, bool signFlip=false);
```
#### Parameters

<a name='wawa.DDL.KMBombStrikeExtensions.SetRate(thisKMBomb,float,bool).that'></a>

`that` [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb')

The [KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb') module instance to grab the rate from.

<a name='wawa.DDL.KMBombStrikeExtensions.SetRate(thisKMBomb,float,bool).value'></a>

`value` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The value to set it to.

<a name='wawa.DDL.KMBombStrikeExtensions.SetRate(thisKMBomb,float,bool).signFlip'></a>

`signFlip` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

When [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'), invert [value](KMBombStrikeExtensions.SetRate(KMBomb,float,bool).md#wawa.DDL.KMBombStrikeExtensions.SetRate(thisKMBomb,float,bool).value 'wawa.DDL.KMBombStrikeExtensions.SetRate(this KMBomb, float, bool).value') when  
the component from [that](KMBombStrikeExtensions.SetRate(KMBomb,float,bool).md#wawa.DDL.KMBombStrikeExtensions.SetRate(thisKMBomb,float,bool).that 'wawa.DDL.KMBombStrikeExtensions.SetRate(this KMBomb, float, bool).that') ticks backwards.

#### Returns
[KMBomb](https://docs.microsoft.com/en-us/dotnet/api/KMBomb 'KMBomb')  
The parameter [that](KMBombStrikeExtensions.SetRate(KMBomb,float,bool).md#wawa.DDL.KMBombStrikeExtensions.SetRate(thisKMBomb,float,bool).that 'wawa.DDL.KMBombStrikeExtensions.SetRate(this KMBomb, float, bool).that').

### Remarks
  
In the editor, this method does nothing.