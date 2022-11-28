# wawa

A collection of libraries to help with the creation of mods in the game [Keep Talking and Nobody Explodes](https://keeptalkinggame.com/).

This project has a dependency to [Emik.Morsels](https://github.com/Emik03/Emik.Morsels), if you are building this project, refer to its [README](https://github.com/Emik03/Emik.Morsels/blob/main/README.md) first.

---

- [Quick Start](#quick-start)
- [Libraries](#libraries)
- [Contribute](#contribute)
- [License](#license)

---

## Quick Start

1. Go to [Releases](https://github.com/Emik03/wawa/releases) and download the latest [wawa.Editors](https://github.com/Emik03/wawa/tree/main/Releases](https://github.com/Emik03/wawa/releases) and download the latest [wawa.Editors).

2. Place the `.dll` in `Assets/Plugins/`, **not** `Assets/Plugins/Managed/`.

3. Wait for Unity to reload, a new tab should appear called `wawa`.

4. Hover over it, and download additional components as needed under `Update`.

## Libraries

- [Emik.Optionals](https://github.com/Emik03/wawa/tree/main/Emik.Optionals) - Shared `Maybe` type. These libraries don't return `null` without wrapping it in this type.
- [Emik.Unity](https://github.com/Emik03/wawa/tree/main/Emik.Unity) - Adds `CachedBehavior`, eliminates overhead of Unity API calls without the need for explicit fields.
- [wawa.DDL](https://github.com/Emik03/wawa/tree/main/wawa.DDL) - Implements the [DDL pattern](https://github.com/Emik03/.DDL#chapter-23-the-ddl-pattern) to safely expose game values, such as missions or strikes.
- [wawa.Editors](https://github.com/Emik03/wawa/tree/main/wawa.Editors) - Editor-only assembly that adds a scaffolder to quickly create new modules, and an updater/downloader.
- [wawa.Extensions](https://github.com/Emik03/wawa/tree/main/wawa.Extensions) - Adds extension methods for `KMFramework` types to make hooking easier.
- [wawa.IO](https://github.com/Emik03/wawa/tree/main/wawa.IO) - Adds methods for KTaNE-related IO operations, such as Mod Settings, loading AssetBundles from the mod directory, or loading external libraries.
- [wawa.Modules](https://github.com/Emik03/wawa/tree/main/wawa.Modules) - Adds `ModdedModule`, a base class that implements essential module behavior.
- [wawa.TwitchPlays](https://github.com/Emik03/wawa/tree/main/wawa.TwitchPlays) - Adds `Twitch`, a base class that hooks on a `ModdedModule` to add essential TwitchPlays behavior.

## Contribute

Issues and pull requests are welcome to help this repository be the best it can be.

## License

This repository falls under the [MPL-2 license](https://www.mozilla.org/en-US/MPL/2.0/).
