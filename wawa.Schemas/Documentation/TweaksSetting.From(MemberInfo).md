#### [wawa.Schemas](index.md 'index')
### [wawa.Schemas](wawa.Schemas.md 'wawa.Schemas').[TweaksSetting](TweaksSetting.md 'wawa.Schemas.TweaksSetting')

## TweaksSetting.From(MemberInfo) Method

Gets the [TweaksSettingAttribute](TweaksSettingAttribute.md 'wawa.Schemas.TweaksSettingAttribute') for the [member](TweaksSetting.From(MemberInfo).md#wawa.Schemas.TweaksSetting.From(System.Reflection.MemberInfo).member 'wawa.Schemas.TweaksSetting.From(System.Reflection.MemberInfo).member').

```csharp
public static wawa.Schemas.TweaksSettingAttribute From(System.Reflection.MemberInfo member);
```
#### Parameters

<a name='wawa.Schemas.TweaksSetting.From(System.Reflection.MemberInfo).member'></a>

`member` [System.Reflection.MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MemberInfo 'System.Reflection.MemberInfo')

#### Returns
[TweaksSettingAttribute](TweaksSettingAttribute.md 'wawa.Schemas.TweaksSettingAttribute')  
The [TweaksSettingAttribute](TweaksSettingAttribute.md 'wawa.Schemas.TweaksSettingAttribute') for the parameter [member](TweaksSetting.From(MemberInfo).md#wawa.Schemas.TweaksSetting.From(System.Reflection.MemberInfo).member 'wawa.Schemas.TweaksSetting.From(System.Reflection.MemberInfo).member'). If the [System.Reflection.MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MemberInfo 'System.Reflection.MemberInfo')  
has no [TweaksSettingAttribute](TweaksSettingAttribute.md 'wawa.Schemas.TweaksSettingAttribute') annotations, then the default instance is returned. If the parameter  
[member](TweaksSetting.From(MemberInfo).md#wawa.Schemas.TweaksSetting.From(System.Reflection.MemberInfo).member 'wawa.Schemas.TweaksSetting.From(System.Reflection.MemberInfo).member') is not a field or property, then [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') is returned instead.

#### Exceptions

[System.Reflection.AmbiguousMatchException](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.AmbiguousMatchException 'System.Reflection.AmbiguousMatchException')  
The member provided has more than one [TweaksSettingAttribute](TweaksSettingAttribute.md 'wawa.Schemas.TweaksSettingAttribute') annotated.