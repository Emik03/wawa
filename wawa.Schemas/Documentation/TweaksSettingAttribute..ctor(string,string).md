#### [wawa.Schemas](index.md 'index')
### [wawa.Schemas](wawa.Schemas.md 'wawa.Schemas').[TweaksSettingAttribute](TweaksSettingAttribute.md 'wawa.Schemas.TweaksSettingAttribute')

## TweaksSettingAttribute(string, string) Constructor

Indicates that the field or property is a setting for [TweaksEditorSettings](TweaksEditorSettings.md 'wawa.Schemas.TweaksEditorSettings').

```csharp
public TweaksSettingAttribute(string description=null, string text=null);
```
#### Parameters

<a name='wawa.Schemas.TweaksSettingAttribute.TweaksSettingAttribute(string,string).description'></a>

`description` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

A longer description of the setting.<p/>`[CanBeNull]`

<a name='wawa.Schemas.TweaksSettingAttribute.TweaksSettingAttribute(string,string).text'></a>

`text` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The short label describing the setting, defaulting to the field or property name.<p/>`[CanBeNull]`