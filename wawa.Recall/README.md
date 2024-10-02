# wawa.Recall

Allows for hooking and unhooking of module controllers and its selectables. Supports hooking vanilla and modded components under the same API.

### [Documentation](https://github.com/Emik03/wawa/blob/main/wawa.Recall/Documentation/wawa.Recall.md)

---

- [Dependencies](#dependencies)
- [Example](#example)
- [Contribute](#contribute)
- [License](#license)

---

## Dependencies

| Library                                                                       | Depends on... | Used in... |
|-------------------------------------------------------------------------------|---------------|------------|
| [wawa.DDL](https://github.com/Emik03/wawa/tree/main/wawa.DDL)                 |               |            |
| [wawa.Editors](https://github.com/Emik03/wawa/tree/main/wawa.Editors)         |               |            |
| [wawa.Extensions](https://github.com/Emik03/wawa/tree/main/wawa.Extensions)   |               |            |
| [wawa.IO](https://github.com/Emik03/wawa/tree/main/wawa.IO)                   |               |            |
| [wawa.Modules](https://github.com/Emik03/wawa/tree/main/wawa.Modules)         |               |            |
| [wawa.Optionals](https://github.com/Emik03/wawa/tree/main/wawa.Optionals)     | ️Yes          |            |
| [wawa.TwitchPlays](https://github.com/Emik03/wawa/tree/main/wawa.TwitchPlays) |               |            |
| [wawa.Unity](https://github.com/Emik03/wawa/tree/main/wawa.Unity)             |               | ️          |

## Example

```csharp
using UnityEngine;
using wawa.Recall;

var allModules = GetComponent<KMBomb>().ToEntities();
var hasVanillaKeypad = allModules.Any(x => x.Kind is Modules.Keypad);

foreach (var module in allModules)
{
    var childLength = module.ToSelectable().Match(x => x.ChildLength).UnwrapOrDefault();
    var needyStatus = module.IsNeedy ? "needy" : "regular";

    Debug.Log($"The module {module.Name.Value} is a {needyStatus} module and has {childLength} child selectable(s).");
    module.Solve.Add(() => Debug.Log($"{module} solved."));
}

```

## Contribute

Issues and pull requests are welcome to help this repository be the best it can be.

## License

This repository falls under the [MPL-2 license](https://www.mozilla.org/en-US/MPL/2.0/).
