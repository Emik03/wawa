# wawa.Modules

Adds a base type for modules.

### [Documentation](https://github.com/Emik03/wawa/blob/main/wawa.Modules/Documentation/wawa.Modules.md)

---

- [Dependencies](#dependencies)
- [Example](#example)
- [Contribute](#contribute)
- [License](#license)

---

## Dependencies

| Library                                                                       | Depends on... | Used in... |
|-------------------------------------------------------------------------------|---------------|------------|
| [wawa.DDL](https://github.com/Emik03/wawa/tree/main/wawa.DDL)                 | Yes           |            |
| [wawa.Editors](https://github.com/Emik03/wawa/tree/main/wawa.Editors)         |               |            |
| [wawa.Extensions](https://github.com/Emik03/wawa/tree/main/wawa.Extensions)   |               |            |
| [wawa.IO](https://github.com/Emik03/wawa/tree/main/wawa.IO)                   | Yes           |            |
| [wawa.Optionals](https://github.com/Emik03/wawa/tree/main/wawa.Optionals)     | Yes           | ️          |
| [wawa.Recall](https://github.com/Emik03/wawa/tree/main/wawa.Recall)           |               |            |
| [wawa.Schemas](https://github.com/Emik03/wawa/tree/main/wawa.Schemas)         |               |            |
| [wawa.TwitchPlays](https://github.com/Emik03/wawa/tree/main/wawa.TwitchPlays) |               | Yes        |
| [wawa.Unity](https://github.com/Emik03/wawa/tree/main/wawa.Unity)             | Yes           | ️          |

## Example

```csharp
using UnityEngine;
using wawa.Modules;

/// <summary>On the Subject of <see cref="Foo"/>.</summary>
public sealed class Foo : ModdedModule
{
    protected override void OnActivate()
    {
        Log("Hello, World! ma o, toki!");
    }
}
```

## Contribute

Issues and pull requests are welcome to help this repository be the best it can be.

## License

This repository falls under the [MPL-2 license](https://www.mozilla.org/en-US/MPL/2.0/).
