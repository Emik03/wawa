// SPDX-License-Identifier: MPL-2.0
namespace Wawa.IO;

/// <summary>Access to the paths and contents of files within folder mod directory.</summary>
[PublicAPI]
public static class PathFinder
{
    const int BitsInByte = 8;

    [NotNull]
    const string
        DuplicateReason = "duplicate mod ids",
        Library = "lib",
        Linux = "linux",
        ModInfoEditor = "ModConfig",
        ModInfoSerializerEditor = "ToJson",
        ModInfoInstanceEditor = "Instance",
        NullReason = "null mod ids",
        OSX = "darwin",
        Separator = ", ",
        Windows = "win32",
        X86 = "x86",
        X86Wide = "x86_64",
        UnityAssembly = "Assembly-CSharp-Editor";

    const BindingFlags
        InstanceBindings = DeclaredOnly | Static | Public,
        ToJsonBindings = DeclaredOnly | Instance | Public;

    [CanBeNull]
    static IDictionary<string, string> s_directories;

    /// <summary>Gets the <see cref="AssemblyName"/> of the caller that invoked the method calling this.</summary>
    /// <remarks><para>This is used by the library to log itself, and obtain information about callers.</para></remarks>
    [NotNull, PublicAPI]
#pragma warning disable CA1065 // ReSharper disable once NullableWarningSuppressionIsUsed
    public static AssemblyName Caller => new StackFrame(3).GetMethod().ReflectedType?.Assembly.GetName()!;
#pragma warning restore CA1065

    /// <summary>Gets the name of <see cref="Caller"/>.</summary>
    [NotNull]
    internal static string Who => Caller.Name;

    /// <summary>Gets the version of <see cref="Caller"/>.</summary>
    [NotNull]
    static string Which =>
        Caller.Version is var ver && ver is { Minor: 0, Build: 0, Revision: 0 } ? $"v{ver.Major}" :
        ver is { Build: 0, Revision: 0 } ? $"v{ver.Major}.{ver.Minor}" :
        ver is { Revision: 0 } ? $"v{ver.Major}.{ver.Minor}.{ver.Build}" :
        $"v{ver.Major}.{ver.Minor}.{ver.Build}.{ver.Revision}";

    /// <summary>Logs a message to the Unity Console with the assembly's name that called this.</summary>
    /// <param name="message">The message to log.</param>
    [PublicAPI]
    public static void AssemblyLog([NotNull] string message) => Debug.Log($"[{Who} ({Which})] {message}");

    /// <summary>Gets the absolute directory of the mod.</summary>
    /// <param name="modId">
    /// The mod id to get the mod directory from.
    /// If <see langword="null" />, implicitly gets the directory of the mod from the file of the assembly.
    /// </param>
    /// <exception cref="InvalidOperationException">
    /// A loaded mod has a null mod id, or has an id that conflicts with another loaded mod.
    /// </exception>
    /// <returns>
    /// A <see cref="Maybe{T}" />, consisting of either folder <see cref="string" /> of the absolute directory
    /// of the file if there is a folder mod id entry within the game's mod dictionary, or <see langword="default" />.
    /// </returns>
    [PublicAPI, Pure]
    public static Maybe<string> GetDirectory([AllowNull, CanBeNull] string modId = null) =>
        (modId ?? Who).Get(
            static asm =>
                (s_directories?.Count == Mods.Count
                    ? s_directories
                    : s_directories = CreateModIdToDirectoryMapping())?[asm]
        );

    /// <summary>Gets the absolute directory of the file located inside the mod directory.</summary>
    /// <param name="filePath">The file located inside folder mod directory.</param>
    /// <param name="modId">
    /// The mod id to get the mod directory from.
    /// If <see langword="null" />, implicitly gets the directory of the mod from the file of the assembly.
    /// </param>
    /// <exception cref="InvalidOperationException">
    /// A loaded mod has a null mod id, or has an id that conflicts with another loaded mod.
    /// </exception>
    /// <returns>
    /// A <see cref="Maybe{T}" />, consisting of either folder <see cref="string" /> of the absolute directory
    /// of the file if the mod directory and file were found, or <see langword="default" />.
    /// </returns>
    [PublicAPI, Pure]
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
                k => GetDirectory(k.FilePath).Value is { } directory
                    ? Path.Combine(directory, key.ModId)
                    : null
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
    [PublicAPI, Pure]
    public static Maybe<ModInfo> GetModInfo([AllowNull, CanBeNull] string modId = null) =>
        (modId ?? Who).Get(
            static asm => GetDirectory(asm).Value is { } dir &&
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
    [CLSCompliant(false), PublicAPI]
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
    /// <exception cref="InvalidOperationException">
    /// A loaded mod has a null mod id, or has an id that conflicts with another loaded mod.
    /// </exception>
    /// <returns>
    /// The value <see langword="true" /> if copying the file was successful, otherwise <see langword="false" />.
    /// </returns>
    [PublicAPI]
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

    [NotNull]
    static string Join(
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] this string root,
        [NotNull, PathReference, StringSyntax(StringSyntaxAttribute.Uri), UriString] in string folder
    ) =>
        Path.Combine(root, folder) is var first && Directory.Exists(first) ? first : root;

    [CanBeNull]
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
            AssemblyLog($"{IntPtr.Size * BitsInByte}-bit {Application.platform} is unsupported.");

            return null;
        }

        var directory = root.Join(Library).Join(platform).Join(architecture);

        Directory.CreateDirectory(directory);

        if (Directory.GetFiles(directory, $"{file}*").SingleOrDefault() is { } source && File.Exists(source))
            return source;

        AssemblyLog($"{nameof(FindLibrary)} Error: Couldn't find {file} library in directory {directory}.");

        return null;
    }

    [NotNull, ItemNotNull]
    static string[] CollectModsWithDuplicateIds([NotNull, ItemNotNull] this IEnumerable<ValueType> mods) =>
        mods
           .Select(static x => ((KeyValuePair<string, Mod>)x).Value.ModID)
           .GroupBy(x => x, StringComparer.Ordinal)
           .Where(x => x.Skip(1).Any())
           .Select(x => x.Key)
           .ToArray();

    [NotNull, ItemNotNull]
    static string[] CollectModsWithNullIds([NotNull, ItemNotNull] this IEnumerable<ValueType> mods) =>
        mods
           .Where(static x => ((KeyValuePair<string, Mod>)x).Value.ModID is null)
           .Select(static x => ((KeyValuePair<string, Mod>)x).Key)
           .ToArray();

    // Boxing required; Avoids creating closures with the 'Mod' type.
    // Collected as list due to multiple enumerations.
    [NotNull]
    static Dictionary<string, string> CreateModIdToDirectoryMapping() =>
        Mods.Cast<ValueType>().ToList() is var mods && mods.CollectModsWithNullIds() is { Length: > 0 } filteredByNull ?
            throw filteredByNull.InvalidBecause(NullReason) :
            mods.CollectModsWithDuplicateIds() is { Length: > 0 } filteredByDuplicate ?
                throw filteredByDuplicate.InvalidBecause(DuplicateReason) :
                mods.InvertModDictionary();

    [NotNull]
    static Dictionary<string, string> InvertModDictionary([NotNull, ItemNotNull] this IEnumerable<ValueType> mods) =>
        mods.ToDictionary(
            static x => ((KeyValuePair<string, Mod>)x).Value.ModID,
            static x => ((KeyValuePair<string, Mod>)x).Key,
            StringComparer.Ordinal
        );

    [NotNull]
    static InvalidOperationException InvalidBecause(
        [NotNull, ItemNotNull] this string[] ids,
        [NotNull] string reason
    ) =>
        new($"The following mod directories have {reason}: {string.Join(Separator, ids)}");

    [CanBeNull]
    [return: AllowNull]
    static ModInfo GetEditorModInfo() =>
        Array.Find(AppDomain.CurrentDomain.GetAssemblies(), static a => a.GetName().Name is UnityAssembly)
          ?.GetType(ModInfoEditor) is { } type &&
        type.GetMethod(ModInfoSerializerEditor, ToJsonBindings)
          ?.Invoke(type.GetProperty(ModInfoInstanceEditor, InstanceBindings)?.GetValue(null, null), null) is string s
            ? ModInfo.Deserialize(s).Value
            : null;

    [NotNull]
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

    [CanBeNull]
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
