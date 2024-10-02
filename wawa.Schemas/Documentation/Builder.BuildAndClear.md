#### [wawa.Schemas](index.md 'index')
### [wawa.Schemas](wawa.Schemas.md 'wawa.Schemas').[TweaksEditorSettings](TweaksEditorSettings.md 'wawa.Schemas.TweaksEditorSettings').[Builder](TweaksEditorSettings.Builder.md 'wawa.Schemas.TweaksEditorSettings.Builder')

## TweaksEditorSettings.Builder.BuildAndClear() Method

Clears the builder and returns the finalized [TweaksEditorSettings](TweaksEditorSettings.md 'wawa.Schemas.TweaksEditorSettings').

```csharp
public override wawa.Schemas.TweaksEditorSettings BuildAndClear();
```

#### Returns
[TweaksEditorSettings](TweaksEditorSettings.md 'wawa.Schemas.TweaksEditorSettings')

### Remarks
  
If you want to re-use it after this method is invoked, [CreateSeparateListing(string, string)](CanCreateSeparateListingOrBuild.CreateSeparateListing(string,string).md 'wawa.Schemas.Fluent.CanCreateSeparateListingOrBuild.CreateSeparateListing(string, string)') needs  
to be first invoked before registering again with [Register&lt;T&gt;()](CanRegister.Register{T}.md 'wawa.Schemas.Fluent.CanRegister.Register<T>()').