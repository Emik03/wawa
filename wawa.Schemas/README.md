# wawa.Optionals

Defines the `Maybe<T>` type, which is used throughout these libraries to represent a value that may be optional.

All returned values from these libraries can be assumed to be always non-null, as a fallback value, or this type is used
to explicitly mark optional values.

### [Documentation](https://github.com/Emik03/wawa/blob/main/wawa.Optionals/Documentation/wawa.Optionals.md)

---

- [Dependencies](#dependencies)
- [Example](#example)
- [Contribute](#contribute)
- [License](#license)

---

## Dependencies

<table>
    <thead>
        <tr>
            <th>Library</th>
            <th>Depends on...</th>
            <th>Used in...</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td><a href="https://github.com/Emik03/wawa/tree/main/wawa.DDL">wawa.DDL</a></td>
            <td align="center" colspan="2" rowspan="9" style="text-align: center;">None</td>
        </tr>
        <tr>
            <td><a href="https://github.com/Emik03/wawa/tree/main/wawa.Editors">wawa.Editors</a></td>
        </tr>
        <tr>
            <td><a href="https://github.com/Emik03/wawa/tree/main/wawa.Extensions">wawa.Extensions</a></td>
        </tr>
        <tr>
            <td><a href="https://github.com/Emik03/wawa/tree/main/wawa.IO">wawa.IO</a></td>
        </tr>
        <tr>
            <td><a href="https://github.com/Emik03/wawa/tree/main/wawa.Modules">wawa.Modules</a></td>
        </tr>
        <tr>
            <td><a href="https://github.com/Emik03/wawa/tree/main/wawa.Optionals">wawa.Optionals</a></td>
        </tr>
        <tr>
            <td><a href="https://github.com/Emik03/wawa/tree/main/wawa.Recall">wawa.Recall</a></td>
        </tr>
        <tr>
            <td><a href="https://github.com/Emik03/wawa/tree/main/wawa.TwitchPlays">wawa.TwitchPlays</a></td>
        </tr>
        <tr>
            <td><a href="https://github.com/Emik03/wawa/tree/main/wawa.Unity">wawa.Unity</a></td>
        </tr>
    </tbody>
</table>

## Example

```csharp
using System;
using Newtonsoft.Json;
using wawa.Schemas;

static class TweaksWillReadThisClass
{
    // Tweaks will try to find any field in any class called `TweaksEditorSettings`, regardless of accessibility.
    // `wawa.Schemas.TweaksEditorSettings` implements `IEnumerable<Dictionary<string, object>>` to make this work.
    // A `wawa.Schemas.TweaksEditorSettings` instance is not very useful as a consumer, so you can leave it private. 
    static readonly TweaksEditorSettings TweaksEditorSettings = TweaksEditorSettings 
        .CreateListing("Mod Name") 
        .Register<ModuleModSetting>()
        .CreateSeparateListing("Mod Name 2", "modName2Id")
        .Register<ModuleModSetting2>()
        .BuildAndClear();
}

[Serializable]
sealed class ModuleModSetting
{
    // This will be included as a tweaks setting, but without a description, and the title be `Boolean`.
    public bool Boolean { get; set; }

    [TweaksSetting("This is the description")] // Title is inferred to be `Number`.
    public int Number { get; set; }
}

[Serializable]
struct ModuleModSetting2
{
    [JsonProperty("string"), TweaksSetting("This is the description", "Title")]
    public string String { get; set; }

    [TweaksSetting.Dropdown("This is the description", "Title", "Option 1", "Option 2", "Option 3")]
    public object Object { get; set; }
}
```

## Contribute

Issues and pull requests are welcome to help this repository be the best it can be.

## License

This repository falls under the [MPL-2 license](https://www.mozilla.org/en-US/MPL/2.0/).
