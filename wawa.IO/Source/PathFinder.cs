// SPDX-License-Identifier: MPL-2.0
namespace wawa.IO;

/// <summary>Access to the paths and contents of files within folder mod directory.</summary>
[PublicAPI]
public static class PathFinder
{
    /// <summary>The number of bits in a byte.</summary>
    const int BitsInByte = 8;

    /// <summary>The various platforms.</summary>
    [NotNull]
    const string
        Android = "android",
        ARM64 = "arm64",
        ARMv7 = "armv7",
        Library = "lib",
        Linux = "linux",
        ModInfoEditor = "ModConfig",
        ModInfoInstanceEditor = "Instance",
        ModInfoSerializerEditor = "ToJson",
        OSX = "osx",
        UnityAssembly = "Assembly-CSharp-Editor",
        Version0 = "v0",
        Windows = "windows",
        X86 = "x86",
        X86_64 = "x86_64";

    /// <summary>The default binding flags.</summary>
    const BindingFlags
        InstanceBindings = DeclaredOnly | Static | Public,
        ToJsonBindings = DeclaredOnly | Instance | Public;

    /// <summary>The number of loaded mods. Used to determine if the directory cache needs to be updated.</summary>
    /// <remarks><para>
    /// There must be at least one loaded mod; The default value 0 can never be equal to the amount of mods loaded.
    /// </para></remarks>
    static int s_loadedMods;

    /// <summary>The loaded mod directories.</summary>
    [CanBeNull]
    static Dictionary<string, string> s_directories;

    /// <summary>Gets the <see cref="AssemblyName"/> of the caller that invoked the method calling this.</summary>
    /// <remarks><para>This is used by the library to log itself, and obtain information about callers.</para></remarks>
    [NotNull, PublicAPI]
    public static AssemblyName Caller
    {
        // ReSharper disable once NullableWarningSuppressionIsUsed
        [MustUseReturnValue] get => new StackFrame(3).GetMethod().ReflectedType?.Assembly.GetName()!;
    }

    /// <summary>Gets the name of <see cref="Caller"/>.</summary>
    [NotNull]
    internal static string Who
    {
        [MustUseReturnValue] get => Caller.Name;
    }

    /// <summary>Gets the version of <see cref="Caller"/>.</summary>
    [NotNull]
    static string Which
    {
        [MustUseReturnValue]
        get =>
            Caller.Version switch
            {
                { Minor: 0, Build: 0, Revision: 0 } v => $"v{v.Major}",
                { Build: 0, Revision: 0 } v => $"v{v.Major}.{v.Minor}",
                { Revision: 0 } v => $"v{v.Major}.{v.Minor}.{v.Build}",
                { } v => $"v{v.Major}.{v.Minor}.{v.Build}.{v.Revision}",
                _ => Version0,
            };
    }

    /// <summary>Logs a message to the Unity Console with the assembly's name that called this.</summary>
    /// <param name="message">The message to log.</param>
    /// <param name="logType">The log level.</param>
    /// <param name="member">The caller member.</param>
    [CLSCompliant(false), PublicAPI]
    public static void AssemblyLog(
        [AllowNull, CanBeNull] string message,
        LogType logType = LogType.Log,
        [AllowNull, CanBeNull, CallerMemberName] string member = null
    ) =>
        Debug.unityLogger.Log(
            logType,
            $"[{Who} ({Which})] {member} {(logType is LogType.Log ? "Trace" : logType)}: {message}"
        );

    /// <summary>Gets the absolute directory of the mod.</summary>
    /// <remarks><para>In the editor, this value returns <see cref="Maybe.None{T}"/>.</para></remarks>
    /// <param name="modId">
    /// The mod id to get the mod directory from.
    /// If <see langword="null"/>, implicitly gets the directory of the mod from the name of the assembly.
    /// </param>
    /// <returns>
    /// A <see cref="Maybe{T}"/>, consisting of either folder <see cref="string"/> of the absolute directory
    /// of the file if there is a folder mod id entry within the game's mod dictionary, or <see langword="default"/>.
    /// </returns>
    [MustUseReturnValue, PublicAPI]
    public static Maybe<string> GetDirectory([AllowNull, CanBeNull] string modId = null) =>
        (modId ?? Who).Get(FindDirectory);

    /// <summary>Gets the absolute directory of the file located inside the mod directory.</summary>
    /// <remarks><para>In the editor, this value returns <see cref="Maybe.None{T}"/>.</para></remarks>
    /// <param name="filePath">The file located inside folder mod directory.</param>
    /// <param name="modId">
    /// The mod id to get the mod directory from.
    /// If <see langword="null"/>, implicitly gets the directory of the mod from the name of the assembly.
    /// </param>
    /// <returns>
    /// A <see cref="Maybe{T}"/>, consisting of either folder <see cref="string"/> of the absolute directory
    /// of the file if the mod directory and file were found, or <see langword="default"/>.
    /// </returns>
    [MustUseReturnValue, PublicAPI]
    public static Maybe<string> GetFile(
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] string filePath,
        [AllowNull, CanBeNull] string modId = null
    ) =>
        (IsKtane || IsRewritten) && GetDirectory(modId).Value is { } dir ? Path.Combine(dir, filePath) : null;

    /// <summary>Gets and deserializes the <see cref="ModInfo"/> file located in every mod's root directory.</summary>
    /// <param name="modId">
    /// The mod id to get the mod directory from.
    /// If <see langword="null"/>, implicitly gets the directory of the mod from the name of the assembly.
    /// </param>
    /// <returns>
    /// A <see cref="Maybe{T}"/>, consisting of either folder <see cref="ModInfo"/> if the file was read
    /// and deserialized successfully, or <see langword="default"/>.
    /// </returns>
    [MustUseReturnValue, PublicAPI]
    public static Maybe<ModInfo> GetModInfo([AllowNull, CanBeNull] string modId = null) =>
        (modId ?? Who).Get(
            static x => GetDirectory(x).Value is { } dir &&
                ModManager.Instance.InstalledModInfos.TryGetValue(dir, out var value)
                    ? ModInfo.FromInternalModInfo(value)
                    : null,
            GetEditorModInfo
        );

    /// <summary>Loads and returns assets from disk.</summary>
    /// <remarks><para>In the editor, this value returns <see cref="Maybe.None{T}"/>.</para></remarks>
    /// <typeparam name="T">The type of asset to get.</typeparam>
    /// <param name="filePath">The file which contains the assets.</param>
    /// <param name="modId">
    /// The mod id to get the mod directory from.
    /// If <see langword="null"/>, implicitly gets the directory of the mod from the name of the assembly.
    /// </param>
    /// <returns>
    /// A <see cref="Maybe{T}"/>, consisting of either an <see cref="Array"/> of <typeparamref file="T"/>
    /// from the assets in the file specified, or <see langword="default"/> in the event of an error.
    /// </returns>
    [CLSCompliant(false), MustUseReturnValue, PublicAPI]
    public static Maybe<IList<T>> GetAssets<T>(
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] string filePath,
        [AllowNull, CanBeNull] string modId = null
    )
        where T : Object =>
        new KeyValuePair<string, string>(filePath, modId ?? Who).Get(
            static key => GetFile(key.Key, key.Value).Value is { } path
                ? AssetBundle.LoadFromFile(path)?.LoadAllAssets<T>()
                : null,
            overriden: null
        );

    /// <summary>Gets an unmanaged function from an external library.</summary>
    /// <typeparam name="T">The signature of the function.</typeparam>
    /// <param name="libPath">The external file.</param>
    /// <param name="ffiMethodName">The name of the method.</param>
    /// <param name="modId">
    /// The mod id to get the mod directory from.
    /// If <see langword="null"/>, implicitly gets the directory of the mod from the name of the assembly.
    /// </param>
    /// <returns>
    /// A <see cref="Maybe{T}"/>, consisting of either the <typeparamref file="T"/> which is linked
    /// to the requested unmanaged function, or <see langword="default"/> in the event of an error.
    /// </returns>
    [MustUseReturnValue, PublicAPI]
    public static Maybe<T> GetUnmanaged<T>(
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] string libPath,
        [NotNull] string ffiMethodName,
        [AllowNull, CanBeNull] string modId = null
    )
        where T : Delegate =>
        new KeyValuePair<string, KeyValuePair<string, string>>(libPath, new(ffiMethodName, modId ?? Who))
           .Get(Link<T>, Link<T>, overriden: null);

    /// <summary>Counts the number of loaded mods to determine if the directory cache needs to be updated.</summary>
    /// <returns>Whether the directory cache needs to be updated.</returns>
    [MemberNotNullWhen(false, nameof(s_directories)), MustUseReturnValue]
    static bool MapNeedsUpdating()
    {
        // Prevents double enumeration on the first call.
        if (s_directories is null)
            return true;

        var loadedMods = 0;

        // Inlined version of 'IsModLoaded' to keep the hot path allocation-free,
        // even if this results in the false branch eventually requiring double enumeration.
        // ReSharper disable once ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator
        foreach (var i in (Dictionary<string, Mod>)Mods)
            if (i.Value.ModObjects.Count is not 0)
                loadedMods++;

        var ret = loadedMods != s_loadedMods;
        s_loadedMods = loadedMods;
        return ret;
    }

    /// <summary>Enters the subdirectory if it exists.</summary>
    /// <param name="root">The root directory.</param>
    /// <param name="folder">The subdirectory.</param>
    /// <returns>The joined directory, or <paramref name="root"/> if <paramref name="folder"/> does not exist.</returns>
    [MustUseReturnValue, NotNull]
    static string Join(
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] this string root,
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] in string folder
    ) =>
        Path.Combine(root, folder) is var first && Directory.Exists(first) ? first : root;

    /// <summary>Finds the directory for the requested mod id.</summary>
    /// <param name="key">The mod id to find.</param>
    /// <returns>The directory for the requested mod id, or <see langword="null"/> if not found.</returns>
    [CanBeNull, MustUseReturnValue]
    [return: AllowNull]
    static string FindDirectory([NotNull] string key)
    {
        if ((MapNeedsUpdating() ? UpdateModIdToDirectoryMapping() : s_directories).TryGetValue(key, out var value))
            return value;

        AssemblyLog($"The following mod id was not found in the mod dictionary: {key}", LogType.Error);
        return null;
    }

    /// <summary>Finds the full path to the requested library.</summary>
    /// <param name="file">The name of the library to find.</param>
    /// <param name="root">The root directory to search from.</param>
    /// <returns>The full path to the requested library, or <see langword="null"/> if not found.</returns>
    [CanBeNull, MustUseReturnValue]
    [return: AllowNull]
    static string FindLibrary(
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] this string file,
        [AllowNull, CanBeNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] in string root
    )
    {
        if (!IsKtane && !IsRewritten)
            return file;

        if (root is null)
            return null;

        var architecture = Application.platform switch
        {
            RuntimePlatform.OSXPlayer => OSX,
            RuntimePlatform.Android => Android,
            RuntimePlatform.LinuxPlayer => Linux,
            RuntimePlatform.WindowsPlayer => Windows,
            _ => null,
        };

        var platform = SystemInfo.processorType.IndexOf("ARM", StringComparison.OrdinalIgnoreCase) >= 0
            ? IntPtr.Size switch
            {
                4 => ARMv7,
                8 => ARM64,
                _ => null,
            }
            : IntPtr.Size switch
            {
                4 => X86,
                8 => X86_64,
                _ => null,
            };

        if (architecture is null || platform is null)
        {
            AssemblyLog(
                $"{IntPtr.Size * BitsInByte}-bit {SystemInfo.processorType} on {Application.platform} is unsupported.",
                LogType.Error
            );

            return null;
        }

        var directory = root.Join(Library).Join(platform).Join(architecture);
        var source = Directory.GetFiles(directory, $"{file}*");

        switch (source.Length)
        {
            case 0:
                AssemblyLog(@$"Couldn't find the library ""{file}"" in the directory ""{directory}"".", LogType.Error);
                return null;
            case > 1:
                var others = string.Join(@""", """, source.Skip(1).ToArray());

                AssemblyLog(
                    @$"Multiple binaries were found, assuming ""{source[0]}"", but could have also used ""{others}"".",
                    LogType.Warning
                );

                goto default;
            default: return source[0];
        }
    }

    /// <summary>Updates the directory cache.</summary>
    /// <returns>The updated directory cache.</returns>
    [MustUseReturnValue, NotNull, Pure]
    static Dictionary<string, string> UpdateModIdToDirectoryMapping()
    {
        s_directories = new(StringComparer.Ordinal);

        foreach (var kvp in (Dictionary<string, Mod>)Mods)
            switch (kvp.Value.ModID)
            {
                case null:
                    AssemblyLog($"A null mod id found: {kvp.Key}", LogType.Warning);
                    break;
                case "":
                    AssemblyLog($"An empty mod id found: {kvp.Key}", LogType.Warning);
                    break;
                case var key when s_directories.TryGetValue(key, out var value):
                    AssemblyLog(
                        value is null
                            ? @$"An additional duplicate mod id has been found for ""{key}"": {kvp.Key}"
                            : @$"A duplicate mod id found for ""{key}"": ""{value}"" conflicts with ""{kvp.Key}"".",
                        LogType.Warning
                    );

                    s_directories[key] = null;
                    break;
                case var key:
                    s_directories[key] = kvp.Key;
                    break;
            }

        return s_directories;
    }

    /// <summary>Gets the <see cref="ModInfo"/> from the editor.</summary>
    /// <param name="_">Unused.</param>
    /// <returns>The <see cref="ModInfo"/> from the editor.</returns>
    [CanBeNull, MustUseReturnValue]
    [return: AllowNull]
    static ModInfo GetEditorModInfo(string _) =>
        Array.Find(AppDomain.CurrentDomain.GetAssemblies(), static a => a.GetName().Name is UnityAssembly)
          ?.GetType(ModInfoEditor) is { } type &&
        type.GetMethod(ModInfoSerializerEditor, ToJsonBindings)
          ?.Invoke(type.GetProperty(ModInfoInstanceEditor, InstanceBindings)?.GetValue(null, null), null) is string s
            ? ModInfo.Deserialize(s).Value
            : null;

    /// <summary>Creates the external method within the module.</summary>
    /// <param name="dynamicMod">The module to create the method in.</param>
    /// <param name="libPath">The path to the unmanaged library.</param>
    /// <param name="name">The name of the method and entry point.</param>
    /// <param name="returnType">The return type of the method.</param>
    /// <param name="parameters">The parameters of the method.</param>
    /// <returns>The parameter <paramref name="dynamicMod"/>.</returns>
    [NotNull, MustUseReturnValue]
    static ModuleBuilder DefineMethod(
        [NotNull] this ModuleBuilder dynamicMod,
        [NotNull] in string libPath,
        [NotNull] in string name,
        [NotNull] in Type returnType,
        [NotNull, ItemNotNull] in Type[] parameters
    )
    {
        const CallingConventions Convention = CallingConventions.Standard;
        const CallingConvention Call = CallingConvention.Cdecl;
        const CharSet CharSet = CharSet.Ansi;

        const MethodAttributes Attributes =
            MethodAttributes.Static | MethodAttributes.Public | MethodAttributes.PinvokeImpl;

        dynamicMod.DefinePInvokeMethod(name, libPath, Attributes, Convention, returnType, parameters, Call, CharSet);
        return dynamicMod;
    }

    /// <summary>Creates the delegate that wraps the external method linking to the unmanaged library.</summary>
    /// <typeparam name="T">The delegate type.</typeparam>
    /// <param name="libPath">The path to the library to link to.</param>
    /// <param name="name">The name of the method and entry point.</param>
    /// <returns>The delegate to the unmanaged method.</returns>
    [CanBeNull, MustUseReturnValue]
    [return: AllowNull]
    static T CreateUnmanagedMethod<T>(
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] this string libPath,
        [NotNull] in string name
    )
        where T : Delegate
    {
        if (typeof(T).GetMethod(nameof(Action.Invoke)) is not { } invoke)
            return null;

        var assembly = AppDomain.CurrentDomain.DefineDynamicAssembly(new(name), AssemblyBuilderAccess.Run);
        var module = assembly.DefineDynamicModule(name);
        var parameters = Array.ConvertAll(invoke.GetParameters(), static x => x.ParameterType);
        var returnType = invoke.ReturnType;

        module.DefineMethod(libPath, name, returnType, parameters).CreateGlobalFunctions();
        var method = module.GetMethod(name);
        return Delegate.CreateDelegate(typeof(T), method, false) as T;
    }

    [return: AllowNull]
    [CanBeNull, MustUseReturnValue]
    static T Link<T>(KeyValuePair<string, KeyValuePair<string, string>> x)
        where T : Delegate =>
        x.Key.FindLibrary(GetDirectory(x.Value.Value).Value)?.CreateUnmanagedMethod<T>(x.Value.Key);
}
