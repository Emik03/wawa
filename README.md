# wawa

[![License](https://img.shields.io/github/license/Emik03/wawa.svg?style=flat)](https://github.com/Emik03/wawa/blob/main/LICENSE)

A collection of libraries to help with the creation of mods in the game [Keep Talking and Nobody Explodes](https://keeptalkinggame.com/).

Named after the respective [toki pona](https://tokipona.org/) word, meaning roughly "[strong, powerful; confident, sure; energetic, intense](https://linku.la)".

This project has a dependency to [Emik.Morsels](https://github.com/Emik03/Emik.Morsels), if you are building this project, refer to its [README](https://github.com/Emik03/Emik.Morsels/blob/main/README.md) first.

---

- [Quick Start](#quick-start)
- [Libraries](#libraries)
- [Building](#building)
- [Contribute](#contribute)
- [License](#license)

---

## Quick Start

If you are using [Qkrisi's modkit](https://github.com/Qkrisi/ktanemodkit), install it from `Keep Talking ModKit > Plugins > wawa.Editors (By Emik) > Install`.

Otherwise, you can install it manually by going to [Releases](https://github.com/Emik03/wawa/releases), downloading the latest [wawa.Editors](https://github.com/Emik03/wawa/tree/main/wawa.Editors) `.dll` file, and placing it in `./Assets/Editor/Plugins/Managed/`, **not** `./Assets/Plugins/Managed/`.

Whichever method is used, wait for Unity to reload, and a new tab should appear named `wawa`. Hover over it, and download additional libraries as needed under `Update`.

## Libraries

- [wawa.DDL](https://github.com/Emik03/wawa/tree/main/wawa.DDL) - Implements the [DDL pattern](https://github.com/Emik03/.DDL#chapter-23-the-ddl-pattern) to safely expose game values, such as missions or strikes.
- [wawa.Editors](https://github.com/Emik03/wawa/tree/main/wawa.Editors) - Editor-only assembly that adds a scaffolder to quickly create new modules, and an updater/downloader.
- [wawa.Extensions](https://github.com/Emik03/wawa/tree/main/wawa.Extensions) - Adds extension methods for `KMFramework` types to make hooking easier.
- [wawa.IO](https://github.com/Emik03/wawa/tree/main/wawa.IO) - Adds methods for KTaNE-related IO operations, such as Mod Settings, loading AssetBundles from the mod directory, or loading external libraries.
- [wawa.Modules](https://github.com/Emik03/wawa/tree/main/wawa.Modules) - Adds `ModdedModule`, a base class that implements essential module behavior.
- [wawa.Optionals](https://github.com/Emik03/wawa/tree/main/wawa.Optionals) - Shared `Maybe` type. These libraries don't return `null` without wrapping it in this type.
- [wawa.TwitchPlays](https://github.com/Emik03/wawa/tree/main/wawa.TwitchPlays) - Adds `Twitch`, a base class that hooks on a `ModdedModule` to add essential TwitchPlays behavior.
- [wawa.Unity](https://github.com/Emik03/wawa/tree/main/wawa.Unity) - Adds `CachedBehavior`, eliminates overhead of Unity API calls without the need for explicit fields.

## Building

1. Set up [Emik.Morsels](https://github.com/Emik03/Emik.Morsels#usage).

2. **WINDOWS ONLY**: You are required to [extend the maximum path length](https://learn.microsoft.com/en-us/windows/win32/fileio/maximum-file-path-limitation?tabs=registry) and run this command:
    ```shell
    git config --global core.longpaths true
    ```

3. Download and extract the full source code, or clone the repository:
    ```shell
    git clone https://github.com/Emik03/wawa.git
    ```

4. Open the solution in your favorite IDE, or use the command-line directly to build it.
    ```shell
    dotnet build
    ```

## Contribute

Issues and pull requests are welcome to help this repository be the best it can be.

## License

This repository falls under the [MPL-2 license](https://www.mozilla.org/en-US/MPL/2.0/).
