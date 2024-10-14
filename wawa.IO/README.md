# wawa.IO

Adds types for KTaNE-related IO operations.

### [Documentation](https://github.com/Emik03/wawa/blob/main/apidocs/wawa.IO/wawa.IO.md)

---

- [Dependencies](#dependencies)
- [Example](#example)
- [Linker](#linker)
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
| [wawa.Modules](https://github.com/Emik03/wawa/tree/main/wawa.Modules)         |               | Yes        |
| [wawa.Optionals](https://github.com/Emik03/wawa/tree/main/wawa.Optionals)     | Yes           | ️          |
| [wawa.Recall](https://github.com/Emik03/wawa/tree/main/wawa.Recall)           |               |            |
| [wawa.Schemas](https://github.com/Emik03/wawa/tree/main/wawa.Schemas)         |               |            |
| [wawa.TwitchPlays](https://github.com/Emik03/wawa/tree/main/wawa.TwitchPlays) |               | Yes        |
| [wawa.Unity](https://github.com/Emik03/wawa/tree/main/wawa.Unity)             |               |            |

## Example

```csharp
using System;
using UnityEngine;
using wawa.IO;

ModInfo m = PathFinder.GetModInfo();

var path = PathFinder.GetFile("someFile.txt");

var action = PathFinder.GetUnmanaged<Action>("ffi_lib", "name_of_method");
action(); // Invoke FFI methods easily!

var conf = new Config<Foo>();

int someValue = conf.Read().Bar;

// Serialize then write.
conf.Write(new());

// Write directly.
conf.Write(
    """
    { "Foo": 1 }
    """
);

[Serializable]
public sealed class Foo
{
    public int Bar { get; set; }
}
```

## Linker

If you use [`wawa.IO.PathFinder.GetUnmanaged<T>`](https://github.com/Emik03/wawa/blob/main/apidocs/wawa.IO/wawa.IO/PathFinder/GetUnmanaged.md), then you need to conform to a specific structure to ensure the right library is linked. Which library is linked is determined by the following steps:

1. Start from the root of the mod, usually within the `workshop` directory or the local `mods` directory.
2. Enter the `lib/` directory, if it exists.
3. Enter the current operating system directory (`android`/`linux`/`macos`/`windows`), if it exists.
4. Enter the current architecture directory (`arm64`/`armv7`/`x86`/`x86_64`), if it exists.
5. If not on windows, find any file that starts with `lib` followed by the name of the library specified, ignoring the extension.
6. If no such file exists, or it's running on Windows, find any file that matches the name of the library specified, ignoring the extension.

As a result, it is not necessary to have the correct file extension or to prefix your Unix libraries with `lib`, but they offer a clear naming convention. When fully extended out, these are all possible branches:

```
.
└── lib
    ├── android
    │   ├── arm64
    │   │   └── libextern.so
    │   ├── armv7
    │   │   └── libextern.so
    │   ├── x86
    │   │   └── libextern.so
    │   └── x86_64
    │       └── libextern.so
    ├── linux
    │   ├── arm64
    │   │   └── libextern.so
    │   ├── armv7
    │   │   └── libextern.so
    │   ├── x86
    │   │   └── libextern.so
    │   └── x86_64
    │       └── libextern.so
    ├── macos
    │   ├── arm64
    │   │   └── libextern.dylib
    │   ├── armv7
    │   │   └── libextern.dylib
    │   ├── x86
    │   │   └── libextern.dylib
    │   └── x86_64
    │       └── libextern.dylib
    └── windows
        ├── arm64
        │   └── extern.dll
        ├── armv7
        │   └── extern.dll
        ├── x86
        │   └── extern.dll
        └── x86_64
            └── extern.dll
```

Understandably, this can be a lot to target, so you are allowed to disregard a portion of it. 32-bit computers (`armv7` and `x86_64`) are very unlikely to be anyone's native architecture when running a Unity game, which prunes the file tree to be:

```
.
└── lib
    ├── android
    │   ├── arm64
    │   │   └── libextern.so
    │   └── x86_64
    │       └── libextern.so
    ├── linux
    │   ├── arm64
    │   │   └── libextern.so
    │   └── x86_64
    │       └── libextern.so
    ├── macos
    │   ├── arm64
    │   │   └── libextern.dylib
    │   └── x86_64
    │       └── libextern.dylib
    └── windows
        ├── arm64
        │   └── extern.dll
        └── x86_64
            └── extern.dll
```

This is the recommended file structure, although `android` is redundant if you do not care to support KTaNE: Rewritten or other potential Unity remakes/demakes, as the original game does not support modding in its Android build.

## Non-KTaNE Interop

For more information on what this means, see [wawa.DDL](https://github.com/Emik03/wawa/tree/main/wawa.DDL#non-ktane-interop).

```csharp
// These functions are assumed to validate the file paths themselves.
public static string? GetDirectory(string modId);

// Return as json blob of `ModInfo`.
public static string? GetModInfo(string modId);

// Assets are expected to both be loaded from file,
// such as AssetBundle.LoadFromFile(path)?.LoadAllAssets<T>().
// Do not assume the path always exists: return null if path is invalid.
public static IList<T>? GetAssets<T>(KeyValuePair<string /* filePath */, string /* modId */> args);

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
