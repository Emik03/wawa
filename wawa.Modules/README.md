# wawa.Modules

Adds a base type for modules.

---

- [Dependencies](#dependencies)
- [Example](#example)
- [Contribute](#contribute)
- [License](#license)

---

## Dependencies

| Library              | Depends on... | Used in... |
|----------------------|---------------|------------|
| [Emik.Optionals]()   | ✔️            | ️❌         |
| [Emik.Unity]()       | ❌             | ️❌         |
| [wawa.DDL]()         | ✔️            | ❌️         |
| [wawa.Editors]()     | ❌             | ❌          |
| [wawa.Extensions]()  | ❌             | ❌          |
| [wawa.IO]()          | ✔️            | ❌️         |
| [wawa.TwitchPlays]() | ❌             | ✔️         |

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
