# wawa.Modules

Adds a base type for modules.

---

- [Dependencies](#dependencies)
- [Example](#example)
- [Contribute](#contribute)
- [License](#license)

---

## Dependencies

| Library                                                                       | Depends on... | Used in... |
|-------------------------------------------------------------------------------|---------------|------------|
| [wawa.DDL](https://github.com/Emik03/wawa/tree/main/wawa.DDL)                 | ✔️            | ❌️         |
| [wawa.Editors](https://github.com/Emik03/wawa/tree/main/wawa.Editors)         | ❌             | ❌          |
| [wawa.Extensions](https://github.com/Emik03/wawa/tree/main/wawa.Extensions)   | ❌             | ❌          |
| [wawa.IO](https://github.com/Emik03/wawa/tree/main/wawa.IO)                   | ✔️            | ❌️         |
| [wawa.Optionals](https://github.com/Emik03/wawa/tree/main/wawa.Optionals)     | ✔️            | ️❌         |
| [wawa.TwitchPlays](https://github.com/Emik03/wawa/tree/main/wawa.TwitchPlays) | ❌             | ✔️         |
| [wawa.Unity](https://github.com/Emik03/wawa/tree/main/wawa.Unity)             | ✔️            | ️❌         |

## Example

```csharp
using UnityEngine;
using Wawa.Modules;

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
