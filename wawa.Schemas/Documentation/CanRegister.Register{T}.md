#### [wawa.Schemas](index.md 'index')
### [wawa.Schemas.Fluent](wawa.Schemas.Fluent.md 'wawa.Schemas.Fluent').[CanRegister](CanRegister.md 'wawa.Schemas.Fluent.CanRegister')

## CanRegister.Register<T>() Method

Adds the schema of [T](CanRegister.Register{T}.md#wawa.Schemas.Fluent.CanRegister.Register_T_().T 'wawa.Schemas.Fluent.CanRegister.Register<T>().T') to the [TweaksEditorSettings](TweaksEditorSettings.md 'wawa.Schemas.TweaksEditorSettings').

```csharp
public abstract wawa.Schemas.Fluent.CanCreateSeparateListingOrBuild Register<T>();
```
#### Type parameters

<a name='wawa.Schemas.Fluent.CanRegister.Register_T_().T'></a>

`T`

The type to register.

#### Returns
[CanCreateSeparateListingOrBuild](CanCreateSeparateListingOrBuild.md 'wawa.Schemas.Fluent.CanCreateSeparateListingOrBuild')  
Itself.

#### Exceptions

[System.Reflection.AmbiguousMatchException](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.AmbiguousMatchException 'System.Reflection.AmbiguousMatchException')  
A member within [T](CanRegister.Register{T}.md#wawa.Schemas.Fluent.CanRegister.Register_T_().T 'wawa.Schemas.Fluent.CanRegister.Register<T>().T') has more than one [TweaksSettingAttribute](TweaksSettingAttribute.md 'wawa.Schemas.TweaksSettingAttribute') annotated.