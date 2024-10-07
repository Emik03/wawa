# wawa.DDL

Implements the [DDL pattern](https://github.com/Emik03/.DDL#chapter-23-the-ddl-pattern) to allow direct access to common
in-game values that are normally annoying to obtain.

### [Documentation](https://github.com/Emik03/wawa/blob/main/wawa.DDL/Documentation/wawa.DDL.md)

---

- [Dependencies](#dependencies)
- [Example](#example)
- [Contribute](#contribute)
- [License](#license)

---

## Dependencies

| Library                                                                       | Depends on... | Used in... |
|-------------------------------------------------------------------------------|---------------|------------|
| [wawa.Editors](https://github.com/Emik03/wawa/tree/main/wawa.Editors)         |               |            |
| [wawa.Extensions](https://github.com/Emik03/wawa/tree/main/wawa.Extensions)   |               |            |
| [wawa.IO](https://github.com/Emik03/wawa/tree/main/wawa.IO)                   |               | Yes        |
| [wawa.Modules](https://github.com/Emik03/wawa/tree/main/wawa.Modules)         |               | Yes        |
| [wawa.Optionals](https://github.com/Emik03/wawa/tree/main/wawa.Optionals)     | Yes           | ️          |
| [wawa.Recall](https://github.com/Emik03/wawa/tree/main/wawa.Recall)           |               | Yes        |
| [wawa.Schemas](https://github.com/Emik03/wawa/tree/main/wawa.Schemas)         |               |            |
| [wawa.TwitchPlays](https://github.com/Emik03/wawa/tree/main/wawa.TwitchPlays) |               | Yes        |
| [wawa.Unity](https://github.com/Emik03/wawa/tree/main/wawa.Unity)             |               | ️          |

## Example

```csharp
using UnityEngine;
using wawa.DDL;
using static System.Diagnostics.Debug;

Assert(GetComponent<KMBomb>().SetStrikes(2).GetStrikes() is 2);

string id = Missions.Id.UnwrapOr("<no id>");

#if UNITY_EDITOR
// Above will always return None in editor,
// so the explicit fallback value is returned.
Assert(id is "<no id>");
#endif

// Bye audio! (Can still be changed by user in settings)
Preferences.Sound = Preferences.Music = 0;
```

## Contribute

Issues and pull requests are welcome to help this repository be the best it can be.

## License

This repository falls under the [MPL-2 license](https://www.mozilla.org/en-US/MPL/2.0/).
