# wawa.Recall

Allows for hooking and unhooking of module controllers and its selectables. Supports hooking vanilla and modded components under the same API.

### [Documentation](https://github.com/Emik03/wawa/blob/main/apidocs/wawa.Recall/wawa.Recall.md)

---

- [Dependencies](#dependencies)
- [Example](#example)
- [Non-KTaNE Interop](#non-ktane-interop)
- [Contribute](#contribute)
- [License](#license)

---

## Dependencies

| Library                                                                       | Depends on... | Used in... |
|-------------------------------------------------------------------------------|---------------|------------|
| [wawa.DDL](https://github.com/Emik03/wawa/tree/main/wawa.DDL)                 | Yes           |            |
| [wawa.Editors](https://github.com/Emik03/wawa/tree/main/wawa.Editors)         |               |            |
| [wawa.Extensions](https://github.com/Emik03/wawa/tree/main/wawa.Extensions)   |               |            |
| [wawa.IO](https://github.com/Emik03/wawa/tree/main/wawa.IO)                   |               |            |
| [wawa.Modules](https://github.com/Emik03/wawa/tree/main/wawa.Modules)         |               |            |
| [wawa.Optionals](https://github.com/Emik03/wawa/tree/main/wawa.Optionals)     | ️Yes          |            |
| [wawa.Schemas](https://github.com/Emik03/wawa/tree/main/wawa.Schemas)         |               |            |
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

## Non-KTaNE Interop

For more information on what this means, see [wawa.DDL](https://github.com/Emik03/wawa/tree/main/wawa.DDL#non-ktane-interop).

```csharp
// public enum StatusLights : byte
// {
//     None = 0,
//     Off = 1,
//     Solve = 2,
//     Strike = 4,
// }

// Changes which of the 3 status lights are visible. All are set according to the bitmask
public static KeyValuePair<MonoBehaviour, byte> Change(KeyValuePair<MonoBehaviour /* `KMBombModule` or `KMNeedyModule` */, byte /* bitmask */> arg);

// Plays the strike sound effect and flashes the status light red, without registering a strike.
public static MonoBehaviour FakeStrike(/* KMBombModule or KMNeedyModule */ MonoBehaviour that);
```

## Contribute

Issues and pull requests are welcome to help this repository be the best it can be.

## License

This repository falls under the [MPL-2 license](https://www.mozilla.org/en-US/MPL/2.0/).
