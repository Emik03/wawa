#### [wawa.Schemas](index.md 'index')
### [wawa.Schemas.Fluent](wawa.Schemas.Fluent.md 'wawa.Schemas.Fluent').[CanCreateSeparateListingOrBuild](CanCreateSeparateListingOrBuild.md 'wawa.Schemas.Fluent.CanCreateSeparateListingOrBuild')

## CanCreateSeparateListingOrBuild.BuildAndClear() Method

Clears the builder and returns the finalized [TweaksEditorSettings](TweaksEditorSettings.md 'wawa.Schemas.TweaksEditorSettings').<p/>`[NotNull, PublicAPI]`

```csharp
public abstract wawa.Schemas.TweaksEditorSettings BuildAndClear();
```

#### Returns
[TweaksEditorSettings](TweaksEditorSettings.md 'wawa.Schemas.TweaksEditorSettings')

### Remarks
  
If you want to re-use it after this method is invoked, [CreateSeparateListing(string, string)](CanCreateSeparateListingOrBuild.CreateSeparateListing(string,string).md 'wawa.Schemas.Fluent.CanCreateSeparateListingOrBuild.CreateSeparateListing(string, string)') needs  
to be first invoked before registering again with [Register&lt;T&gt;()](CanRegister.Register{T}.md 'wawa.Schemas.Fluent.CanRegister.Register<T>()').