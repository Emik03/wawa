#### [wawa.Schemas](index.md 'index')
### [wawa.Schemas](wawa.Schemas.md 'wawa.Schemas').[TweaksEditorSettings](TweaksEditorSettings.md 'wawa.Schemas.TweaksEditorSettings').[Builder](TweaksEditorSettings.Builder.md 'wawa.Schemas.TweaksEditorSettings.Builder')

## TweaksEditorSettings.Builder.Register<T>() Method

Adds the schema of [T](Builder.Register{T}.md#wawa.Schemas.TweaksEditorSettings.Builder.Register_T_().T 'wawa.Schemas.TweaksEditorSettings.Builder.Register<T>().T') to the [TweaksEditorSettings](TweaksEditorSettings.md 'wawa.Schemas.TweaksEditorSettings').

```csharp
public override wawa.Schemas.Fluent.CanCreateSeparateListingOrBuild Register<T>();
```
#### Type parameters

<a name='wawa.Schemas.TweaksEditorSettings.Builder.Register_T_().T'></a>

`T`

The type to register.

#### Returns
[CanCreateSeparateListingOrBuild](CanCreateSeparateListingOrBuild.md 'wawa.Schemas.Fluent.CanCreateSeparateListingOrBuild')  
Itself.

#### Exceptions

[System.Reflection.AmbiguousMatchException](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.AmbiguousMatchException 'System.Reflection.AmbiguousMatchException')  
A member within [T](Builder.Register{T}.md#wawa.Schemas.TweaksEditorSettings.Builder.Register_T_().T 'wawa.Schemas.TweaksEditorSettings.Builder.Register<T>().T') has more than one [TweaksSettingAttribute](TweaksSettingAttribute.md 'wawa.Schemas.TweaksSettingAttribute') annotated.