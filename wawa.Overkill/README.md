# wawa.Overkill

A compiler tool that allows you to directly link your library with the game's, while keeping Unity's editor happy.

---

- [Setup](#setup)
- [Dependencies](#dependencies)
- [Example](#example)
- [Contribute](#contribute)
- [License](#license)

---

## Setup

(todo)

## Dependencies

Completely stand-alone executable, and not used as a dependency in another library.

| Library                                                                       | Depends on... | Used in... |
|-------------------------------------------------------------------------------|---------------|------------|
| [wawa.DDL](https://github.com/Emik03/wawa/tree/main/wawa.DDL)                 | ❌             | ❌️         |
| [wawa.Editors](https://github.com/Emik03/wawa/tree/main/wawa.Editors)         | ❌             | ❌          |
| [wawa.IO](https://github.com/Emik03/wawa/tree/main/wawa.IO)                   | ❌             | ❌️         |
| [wawa.Modules](https://github.com/Emik03/wawa/tree/main/wawa.Modules)         | ❌             | ❌️         |
| [wawa.Optionals](https://github.com/Emik03/wawa/tree/main/wawa.Optionals)     | ❌             | ️❌         |
| [wawa.TwitchPlays](https://github.com/Emik03/wawa/tree/main/wawa.TwitchPlays) | ❌             | ❌️         |
| [wawa.Unity](https://github.com/Emik03/wawa/tree/main/wawa.Unity)             | ❌             | ️❌         |

## Example

```csharp
// Everything from the game is imported with a prefix 'Wawa.Overkill'.
// This is to avoid one of many conflicts with both the editor and wawa itself.
using KTModInfo = Wawa.Overkill.Assets.Scripts.Mods.ModInfo;

// All types are purely definitions, and therefore this will run fine on the editor.
// This is essentially a blueprint for the compiler to link it with the real thing post-compilation.
KTModInfo? modInfo = null;
```

## Contribute

Issues and pull requests are welcome to help this repository be the best it can be.

## License

This repository falls under the [MPL-2 license](https://www.mozilla.org/en-US/MPL/2.0/).
