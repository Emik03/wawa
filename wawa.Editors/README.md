# wawa.Editors

Editor-only dependency that extends the editor to integrate an installer and scaffolder into the editor.

When installed, `wawa` is shown at the top with the following options...

- `Scaffold`: Creates a template prefab and script. Uses a `wawa.Modules` and/or `wawa.TwitchPlays` template if the library exists, otherwise a generic template.
- `Updater`: Downloads the latest of that library, as well as all dependencies.

---

- [Dependencies](#dependencies)
- [Contribute](#contribute)
- [License](#license)

---

## Dependencies

Completely stand-alone library, and not used as a dependency in another library.

| Library                                                                       | Depends on... | Used in... |
|-------------------------------------------------------------------------------|---------------|------------|
| [Emik.Optionals](https://github.com/Emik03/wawa/tree/main/Emik.Optionals)     | ❌             | ️❌         |
| [Emik.Unity](https://github.com/Emik03/wawa/tree/main/Emik.Unity)             | ❌             | ️❌         |
| [wawa.DDL](https://github.com/Emik03/wawa/tree/main/wawa.DDL)                 | ❌             | ❌️         |
| [wawa.Extensions](https://github.com/Emik03/wawa/tree/main/wawa.Extensions)   | ❌             | ❌          |
| [wawa.IO](https://github.com/Emik03/wawa/tree/main/wawa.IO)                   | ❌             | ❌️         |
| [wawa.Modules](https://github.com/Emik03/wawa/tree/main/wawa.Modules)         | ❌             | ❌️         |
| [wawa.TwitchPlays](https://github.com/Emik03/wawa/tree/main/wawa.TwitchPlays) | ❌             | ❌️         |

## Contribute

Issues and pull requests are welcome to help this repository be the best it can be.

## License

This repository falls under the [MPL-2 license](https://www.mozilla.org/en-US/MPL/2.0/).