#### [wawa.Schemas](index.md 'index')
### [wawa.Schemas](wawa.Schemas.md 'wawa.Schemas').[TweaksSetting](TweaksSetting.md 'wawa.Schemas.TweaksSetting').[DropdownAttribute](TweaksSetting.DropdownAttribute.md 'wawa.Schemas.TweaksSetting.DropdownAttribute')

## DropdownAttribute(string, string, object[]) Constructor

Indicates that the field or property is a setting serialized as one of a set of values.

```csharp
public DropdownAttribute(string description=null, string text=null, params object[] dropdownItems);
```
#### Parameters

<a name='wawa.Schemas.TweaksSetting.DropdownAttribute.DropdownAttribute(string,string,object[]).description'></a>

`description` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

A longer description of the setting.

<a name='wawa.Schemas.TweaksSetting.DropdownAttribute.DropdownAttribute(string,string,object[]).text'></a>

`text` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The short label describing the setting, defaulting to the field or property name.

<a name='wawa.Schemas.TweaksSetting.DropdownAttribute.DropdownAttribute(string,string,object[]).dropdownItems'></a>

`dropdownItems` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The set of possible values.