# TweaksEditorSettings\.Builder Class

namespace: [wawa\.Schemas](../wawa.Schemas.md)<br />
assembly: [wawa\.Schemas](../../wawa.Schemas.md)

The builder class for creating the settings schema object used by tweaks for the mod settings\.

```csharp
public sealed class TweaksEditorSettings.Builder;
```

Inheritance: `object` > [CanRegister](../../wawa.Schemas/wawa.Schemas.Fluent/CanRegister.md) > [CanSection](../../wawa.Schemas/wawa.Schemas.Fluent/CanSection.md) > [CanCreateSeparateListingOrBuild](../../wawa.Schemas/wawa.Schemas.Fluent/CanCreateSeparateListingOrBuild.md) > TweaksEditorSettings.Builder

Implements: `IEnumerable`

## Methods

| Name | Summary |
|------|---------|
| [BuildAndClear\(\)](./Builder/BuildAndClear.md) | Clears the builder and returns the finalized [TweaksEditorSettings](../../wawa.Schemas/wawa.Schemas/TweaksEditorSettings.md)\. |
| [CreateSeparateListing\(string, string\)](./Builder/CreateSeparateListing.md) | Creates a new listing in the [TweaksEditorSettings](../../wawa.Schemas/wawa.Schemas/TweaksEditorSettings.md)\. |
| [Section\(string\)](./Builder/Section.md) | Creates a new section in the [TweaksEditorSettings](../../wawa.Schemas/wawa.Schemas/TweaksEditorSettings.md)\. |
| [Register\<T\>\(\)](./Builder/Register.md) | Adds the schema of `T` to the [TweaksEditorSettings](../../wawa.Schemas/wawa.Schemas/TweaksEditorSettings.md)\. |

