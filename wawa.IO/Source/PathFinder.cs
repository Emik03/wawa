// SPDX-License-Identifier: MPL-2.0
namespace Wawa.IO;

/// <summary>Access to the paths and contents of files within folder mod directory.</summary>
[PublicAPI]
public static class PathFinder
{
    const int BitsInByte = 8;

    [NotNull]
    const string
        Library = "lib",
        Linux = "linux",
        ModInfoEditor = "ModConfig",
        ModInfoSerializerEditor = "ToJson",
        ModInfoInstanceEditor = "Instance",
        OSX = "darwin",
        Windows = "win32",
        X86 = "x86",
        X86Wide = "x86_64",
        UnityAssembly = "Assembly-CSharp-Editor",
        Version0 = "v0";

    const BindingFlags
        InstanceBindings = DeclaredOnly | Static | Public,
        ToJsonBindings = DeclaredOnly | Instance | Public;

    // There must be at least one loaded mod; The default value 0 will always be unequal to the amount of mods loaded.
    static int s_loadedMods;

    [CanBeNull]
    static Dictionary<string, string> s_directories;

    /// <summary>Gets the <see cref="AssemblyName"/> of the caller that invoked the method calling this.</summary>
    /// <remarks><para>This is used by the library to log itself, and obtain information about callers.</para></remarks>
    [NotNull, PublicAPI]
    public static AssemblyName Caller
    {
#pragma warning disable CA1065 // ReSharper disable once NullableWarningSuppressionIsUsed
        [MustUseReturnValue] get => new StackFrame(3).GetMethod().ReflectedType?.Assembly.GetName()!;
#pragma warning restore CA1065
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
    [PublicAPI] // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
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
    /// <param name="modId">
    /// The mod id to get the mod directory from.
    /// If <see langword="null" />, implicitly gets the directory of the mod from the file of the assembly.
    /// </param>
    /// <returns>
    /// A <see cref="Maybe{T}" />, consisting of either folder <see cref="string" /> of the absolute directory
    /// of the file if there is a folder mod id entry within the game's mod dictionary, or <see langword="default" />.
    /// </returns>
    [MustUseReturnValue, PublicAPI]
    public static Maybe<string> GetDirectory([AllowNull, CanBeNull] string modId = null) =>
        (modId ?? Who).Get(FindDirectory);

    /// <summary>Gets the absolute directory of the file located inside the mod directory.</summary>
    /// <param name="filePath">The file located inside folder mod directory.</param>
    /// <param name="modId">
    /// The mod id to get the mod directory from.
    /// If <see langword="null" />, implicitly gets the directory of the mod from the file of the assembly.
    /// </param>
    /// <returns>
    /// A <see cref="Maybe{T}" />, consisting of either folder <see cref="string" /> of the absolute directory
    /// of the file if the mod directory and file were found, or <see langword="default" />.
    /// </returns>
    [MustUseReturnValue, PublicAPI]
    public static Maybe<string> GetFile(
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] string filePath,
        [AllowNull, CanBeNull] string modId = null
    ) =>
        new
        {
            FilePath = filePath,
            ModId = modId ?? Who,
        }.Get(
            static key => key.SuppressIO(
                k => GetDirectory(k.FilePath).Value is { } directory ? Path.Combine(directory, key.ModId) : null
            )
        );

    /// <summary>Gets and deserializes the <see cref="ModInfo" /> file located in every mod's root directory.</summary>
    /// <param name="modId">
    /// The mod id to get the mod directory from.
    /// If <see langword="null" />, implicitly gets the directory of the mod from the file of the assembly.
    /// </param>
    /// <returns>
    /// A <see cref="Maybe{T}" />, consisting of either folder <see cref="ModInfo" /> if the file was read
    /// and deserialized successfully, or <see langword="default" />.
    /// </returns>
    [MustUseReturnValue, PublicAPI]
    public static Maybe<ModInfo> GetModInfo([AllowNull, CanBeNull] string modId = null) =>
        (modId ?? Who).Get(
            static x => GetDirectory(x).Value is { } dir &&
                ModManager.Instance.InstalledModInfos.TryGetValue(dir, out var value)
                    ? ModInfo.FromInternalModInfo(value)
                    : null,
            static _ => GetEditorModInfo()
        );

    /// <summary>Loads and returns assets from disk.</summary>
    /// <typeparam name="T">The type of asset to get.</typeparam>
    /// <param name="filePath">The file which contains the assets.</param>
    /// <param name="modId">
    /// The mod id to get the mod directory from.
    /// If <see langword="null" />, implicitly gets the directory of the mod from the file of the assembly.
    /// </param>
    /// <returns>
    /// A <see cref="Maybe{T}" />, consisting of either an <see cref="Array" /> of <typeparamref file="T" />
    /// from the assets in the file specified, or <see langword="default" /> in the event of an error.
    /// </returns>
    [CLSCompliant(false), MustUseReturnValue, PublicAPI]
    public static Maybe<IList<T>> GetAssets<T>(
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] string filePath,
        [AllowNull, CanBeNull] string modId = null
    )
        where T : Object =>
        new
        {
            FilePath = filePath,
            ModId = modId ?? Who,
        }.Get(
            static key => GetFile(key.FilePath, key.ModId).Value is { } path
                ? AssetBundle.LoadFromFile(path)?.LoadAllAssets<T>()
                : null
        );

    /// <summary>Gets an unmanaged function from an external library.</summary>
    /// <typeparam name="T">The signature of the function.</typeparam>
    /// <param name="libPath">The external file.</param>
    /// <param name="ffiMethodName">The name of the method.</param>
    /// <param name="modId">
    /// The mod id to get the mod directory from.
    /// If <see langword="null" />, implicitly gets the directory of the mod from the file of the assembly.
    /// </param>
    /// <returns>
    /// The value <see langword="true" /> if copying the file was successful, otherwise <see langword="false" />.
    /// </returns>
    [MustUseReturnValue, PublicAPI]
    public static Maybe<T> GetUnmanaged<T>(
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] string libPath,
        [NotNull] string ffiMethodName,
        [AllowNull, CanBeNull] string modId = null
    )
        where T : Delegate =>
        new
            {
                LibPath = libPath,
                FFIMethodName = ffiMethodName,
                ModId = modId ?? Who,
            }
           .Get(
                static key => GetDirectory(key.ModId).Value is { } directory
                    ? key.LibPath.FindLibrary(directory)?.CreateUnmanagedMethod<T>(key.FFIMethodName)
                    : null
            );

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

    [MustUseReturnValue, NotNull]
    static string Join(
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] this string root,
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] in string folder
    ) =>
        Path.Combine(root, folder) is var first && Directory.Exists(first) ? first : root;

    [CanBeNull, MustUseReturnValue]
    [return: AllowNull]
    static string FindDirectory([NotNull] string key)
    {
        if ((MapNeedsUpdating() ? UpdateModIdToDirectoryMapping() : s_directories).TryGetValue(key, out var value))
            return value;

        AssemblyLog($"The following mod id was not found in the mod dictionary: {key}", LogType.Error);
        return null;
    }

    [CanBeNull, MustUseReturnValue]
    [return: AllowNull]
    static string FindLibrary(
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] this string file,
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] in string root
    )
    {
        var architecture = Application.platform switch
        {
            RuntimePlatform.LinuxPlayer => Linux,
            RuntimePlatform.OSXPlayer => OSX,
            RuntimePlatform.WindowsPlayer => Windows,
            _ => null,
        };

        var platform = IntPtr.Size switch
        {
            4 => X86,
            8 => X86Wide,
            _ => null,
        };

        if (architecture is null || platform is null)
        {
            AssemblyLog($"{IntPtr.Size * BitsInByte}-bit {Application.platform} is unsupported.", LogType.Error);
            return null;
        }

        var directory = root.Join(Library).Join(platform).Join(architecture);
        Directory.CreateDirectory(directory);

        if (Directory.GetFiles(directory, $"{file}*") is var source && source.Length is 0 || File.Exists(source[0]))
        {
            AssemblyLog(@$"Couldn't find the library ""{file}"" in the directory ""{directory}"".", LogType.Error);
            return null;
        }

#pragma warning disable CI0003
        if (source.Length > 1 && string.Join(@""", """, source.Skip(1).ToArray()) is var others)
#pragma warning restore CI0003
            AssemblyLog(
                @$"Multiple binaries were found, assuming ""{source[0]}"", but could have also used ""{others}"".",
                LogType.Error
            );

        return source[0];
    }

    // Boxing required; Avoids creating closures with the 'Mod' type.
    // Collected as list due to multiple enumerations.
    [MustUseReturnValue, NotNull, Pure]
    static Dictionary<string, string> UpdateModIdToDirectoryMapping()
    {
        s_directories = new(StringComparer.Ordinal);

        foreach (var kvp in (Dictionary<string, Mod>)Mods)
            switch (kvp.Value.ModID)
            {
                case null:
                    AssemblyLog($"Null mod id found: {kvp.Key}", LogType.Warning);
                    break;
                case "":
                    AssemblyLog($"Empty mod id found: {kvp.Key}", LogType.Warning);
                    break;
                case var key when s_directories.TryGetValue(key, out var value):
                    AssemblyLog($"Duplicate mod id found. \"{value}\" conflicts with \"{kvp.Key}\".", LogType.Warning);
                    break;
                case var key:
                    s_directories.Add(key, kvp.Key);
                    break;
            }

        return s_directories;
    }

    [CanBeNull, MustUseReturnValue]
    [return: AllowNull]
    static ModInfo GetEditorModInfo() =>
        Array.Find(AppDomain.CurrentDomain.GetAssemblies(), static a => a.GetName().Name is UnityAssembly)
          ?.GetType(ModInfoEditor) is { } type &&
        type.GetMethod(ModInfoSerializerEditor, ToJsonBindings)
          ?.Invoke(type.GetProperty(ModInfoInstanceEditor, InstanceBindings)?.GetValue(null, null), null) is string s
            ? ModInfo.Deserialize(s).Value
            : null;

    [NotNull, MustUseReturnValue]
    static ModuleBuilder DefineMethod(
        [NotNull] this ModuleBuilder dynamicMod,
        [NotNull] in string dllName,
        [NotNull] in string name,
        [NotNull] in Type returnType,
        [NotNull, ItemNotNull] in Type[] parameters
    )
    {
        const CallingConvention NativeCall = CallingConvention.Cdecl;
        const CallingConventions Convention = CallingConventions.Standard;
        const CharSet NativeCharSet = CharSet.Ansi;

        const MethodAttributes Attributes =
            MethodAttributes.Static | MethodAttributes.Public | MethodAttributes.PinvokeImpl;

        dynamicMod.DefinePInvokeMethod(
            name,
            dllName,
            Attributes,
            Convention,
            returnType,
            parameters,
            NativeCall,
            NativeCharSet
        );

        return dynamicMod;
    }

    [CanBeNull, MustUseReturnValue]
    [return: AllowNull]
    static T CreateUnmanagedMethod<T>(
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] this string dllName,
        [NotNull] in string name
    )
        where T : Delegate
    {
        if (typeof(T).GetMethod(nameof(Action<T>.Invoke)) is not { } invoke)
            return null;

        var assembly = AppDomain.CurrentDomain.DefineDynamicAssembly(new(name), AssemblyBuilderAccess.Run);
        var module = assembly.DefineDynamicModule(name);
        var parameters = Array.ConvertAll(invoke.GetParameters(), static x => x.ParameterType);
        var returnType = invoke.ReturnType;

        module.DefineMethod(dllName, name, returnType, parameters).CreateGlobalFunctions();
        var method = module.GetMethod(name);
        return Delegate.CreateDelegate(typeof(T), method, false) as T;
    }
}
