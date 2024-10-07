#### [wawa.Schemas](index.md 'index')
### [wawa.Schemas](wawa.Schemas.md 'wawa.Schemas')

## TweaksSettingAttribute Class

Indicates that the field or property is a setting for [TweaksEditorSettings](TweaksEditorSettings.md 'wawa.Schemas.TweaksEditorSettings').

```csharp
public class TweaksSettingAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; TweaksSettingAttribute

Derived  
&#8627; [ArrayAttribute](TweaksSetting.ArrayAttribute.md 'wawa.Schemas.TweaksSetting.ArrayAttribute')  
&#8627; [CheckboxAttribute](TweaksSetting.CheckboxAttribute.md 'wawa.Schemas.TweaksSetting.CheckboxAttribute')  
&#8627; [DropdownAttribute](TweaksSetting.DropdownAttribute.md 'wawa.Schemas.TweaksSetting.DropdownAttribute')  
&#8627; [HiddenAttribute](TweaksSetting.HiddenAttribute.md 'wawa.Schemas.TweaksSetting.HiddenAttribute')  
&#8627; [NumberAttribute](TweaksSetting.NumberAttribute.md 'wawa.Schemas.TweaksSetting.NumberAttribute')  
&#8627; [StringAttribute](TweaksSetting.StringAttribute.md 'wawa.Schemas.TweaksSetting.StringAttribute')  
&#8627; [SubmenuAttribute](TweaksSetting.SubmenuAttribute.md 'wawa.Schemas.TweaksSetting.SubmenuAttribute')

| Constructors | |
| :--- | :--- |
| [TweaksSettingAttribute(string, string)](TweaksSettingAttribute..ctor(string,string).md 'wawa.Schemas.TweaksSettingAttribute.TweaksSettingAttribute(string, string)') | Indicates that the field or property is a setting for [TweaksEditorSettings](TweaksEditorSettings.md 'wawa.Schemas.TweaksEditorSettings'). |

| Properties | |
| :--- | :--- |
| [Description](TweaksSettingAttribute.Description.md 'wawa.Schemas.TweaksSettingAttribute.Description') | Gets the longer description of the setting.<p/>`[CanBeNull]` |
| [Text](TweaksSettingAttribute.Text.md 'wawa.Schemas.TweaksSettingAttribute.Text') | Gets the short label describing the setting.<p/>`[CanBeNull]` |
