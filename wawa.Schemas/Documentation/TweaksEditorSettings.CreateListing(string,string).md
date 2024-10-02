#### [wawa.Schemas](index.md 'index')
### [wawa.Schemas](wawa.Schemas.md 'wawa.Schemas').[TweaksEditorSettings](TweaksEditorSettings.md 'wawa.Schemas.TweaksEditorSettings')

## TweaksEditorSettings.CreateListing(string, string) Method

Creates the new builder.

```csharp
public static wawa.Schemas.Fluent.CanSection CreateListing(string name, string modId=null);
```
#### Parameters

<a name='wawa.Schemas.TweaksEditorSettings.CreateListing(string,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the initial listing.

<a name='wawa.Schemas.TweaksEditorSettings.CreateListing(string,string).modId'></a>

`modId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The mod id to get the file name from.  
If [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'), implicitly gets the file name of the mod from the name of the assembly.

#### Returns
[CanSection](CanSection.md 'wawa.Schemas.Fluent.CanSection')  
Itself.