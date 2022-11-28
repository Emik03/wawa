// <copyright file="PathFinder.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
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
        UnityAssembly = "Assembly-CSharp-Editor";

    const BindingFlags
        InstanceBindings = DeclaredOnly | Static | Public,
        ToJsonBindings = DeclaredOnly | Instance | Public;

    /// <summary>Gets the <see cref="AssemblyName"/> of the caller that invoked the method calling this.</summary>
    /// <remarks><para>This is used by the library to log itself, and obtain information about callers.</para></remarks>
    [NotNull]
#pragma warning disable CA1065
    public static AssemblyName Caller => new StackFrame(2).GetMethod().ReflectedType?.Assembly.GetName() ?? throw new();
#pragma warning restore CA1065

    /// <summary>Gets the name of <see cref="Caller"/>.</summary>
    [NotNull]
    internal static string Who => Caller.Name;

    /// <summary>Gets the version of <see cref="Caller"/>.</summary>
    [NotNull]
    static string Which =>
        Caller.Version is { Minor: 0, Build: 0, Revision: 0 } ver ? $"{ver.Major}" : $"{Caller.Version}";

    /// <summary>Logs a message to the Unity Console with the assembly's name that called this.</summary>
    /// <param name="message">The message to log.</param>
    public static void AssemblyLog([NotNull] string message) => Debug.Log($"[{Who} (v{Which})] {message}");

    /// <summary>Gets the absolute dir of the directory from folder mod.</summary>
    /// <param name="assembly">
    /// The name of the assembly which is used to get the mod directory of the mod.
    /// If <see langword="null" />, implicitly gets the directory of the mod from the file of the assembly.
    /// </param>
    /// <returns>
    /// A <see cref="Maybe{T}" />, consisting of either folder <see cref="string" /> of the absolute directory
    /// of the file if there is a folder mod id entry within the game's mod dictionary, or <see langword="default" />.
    /// </returns>
    public static Maybe<string> GetDirectory([AllowNull, CanBeNull] string assembly = null) =>
        (assembly ?? Who).Get(static asm => Mods.Contains(asm) ? (Mods[asm] as Mod)?.ModID : null);

    /// <summary>Gets the absolute dir of folder file located inside folder mod.</summary>
    /// <param name="file">The file located inside folder mod directory.</param>
    /// <param name="assembly">
    /// The name of the assembly which is used to get the mod directory of the mod.
    /// If <see langword="null" />, implicitly gets the directory of the mod from the file of the assembly.
    /// </param>
    /// <returns>
    /// A <see cref="Maybe{T}" />, consisting of either folder <see cref="string" /> of the absolute directory
    /// of the file if the mod directory and file were found, or <see langword="default" />.
    /// </returns>
    public static Maybe<string> GetFile([NotNull] string file, [AllowNull, CanBeNull] string assembly = null) =>
        new
        {
            file,
            asm = assembly ?? Who,
        }.Get(
            static key => key.SuppressIO(
                k => GetDirectory(k.asm).Value is { } directory
                    ? Directory.GetFiles(directory, key.file).FirstOrDefault()
                    : null
            )
        );

    /// <summary>Gets and deserializes the <see cref="ModInfo" /> file located in every mod's root directory.</summary>
    /// <param name="assembly">
    /// The name of the assembly which is used to get the mod directory of the mod.
    /// If <see langword="null" />, implicitly gets the directory of the mod from the file of the assembly.
    /// </param>
    /// <returns>
    /// A <see cref="Maybe{T}" />, consisting of either folder <see cref="ModInfo" /> if the file was read
    /// and deserialized successfully, or <see langword="default" />.
    /// </returns>
    public static Maybe<ModInfo> GetModInfo([AllowNull, CanBeNull] string assembly = null) =>
        (assembly ?? Who).Get(
            static asm => GetFile(ModInfo.FileName, asm).Match(ModInfo.ReadThenDeserialize).Value,
            static _ => GetEditorModInfo()
        );

    /// <summary>Loads and returns assets from disk.</summary>
    /// <typeparam name="T">The type of asset to get.</typeparam>
    /// <param name="file">The file which contains the assets.</param>
    /// <param name="assembly">
    /// The name of the assembly which is used to get the mod directory of the mod.
    /// If <see langword="null" />, implicitly gets the directory of the mod from the file of the assembly.
    /// </param>
    /// <returns>
    /// A <see cref="Maybe{T}" />, consisting of either an <see cref="Array" /> of <typeparamref file="T" />
    /// from the assets in the file specified, or <see langword="default" /> in the event of an error.
    /// </returns>
    [CLSCompliant(false)]
    public static Maybe<T[]> GetAssets<T>([NotNull] string file, [AllowNull, CanBeNull] string assembly = null)
        where T : Object =>
        new
        {
            file,
            asm = assembly ?? Who,
        }.Get(
            static key => GetFile(key.file, key.asm).Value is not { } path ? null :
                AssetBundle.LoadFromFileAsync(path).assetBundle is not { } bundle ||
                bundle.LoadAllAssets<T>() is not { } assets ? null : assets
        );

    /// <summary>Gets an unmanaged function from an external library.</summary>
    /// <typeparam name="T">The signature of the function.</typeparam>
    /// <param name="file">The external file.</param>
    /// <param name="method">The name of the method.</param>
    /// <param name="assembly">
    /// The name of the assembly which is used to get the mod directory of the mod. If <see langword="null" />,
    /// implicitly gets the directory of the mod from the file of the assembly.
    /// </param>
    /// <returns>
    /// The value <see langword="true" /> if copying the file was successful, otherwise <see langword="false" />.
    /// </returns>
    public static Maybe<T> GetUnmanaged<T>(
        [NotNull] string file,
        [NotNull] string method,
        [AllowNull, CanBeNull] string assembly = null
    )
        where T : Delegate =>
        new
            {
                asm = assembly ?? Who,
                file,
                method,
            }
           .Get(
                key => GetDirectory(key.asm).Value is { } directory
                    ? key.file.FindLibrary(directory)?.CreateUnmanagedMethod<T>(method)
                    : null
            );

    [NotNull]
    static string Join([NotNull] this string dir, [NotNull] in string folder) =>
        Path.Combine(dir, folder) is var first && Directory.Exists(first) ? first : dir;

    [CanBeNull]
    [return: AllowNull]
    static string FindLibrary([NotNull] this string file, [NotNull] in string dir)
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

        Directory.CreateDirectory(platform);

        var directory = dir.Join(Library).Join(platform).Join(architecture);
        var source = Directory.GetFiles(directory, $"{file}*").SingleOrDefault();

        if (source is not null && File.Exists(source))
            return source;

        AssemblyLog($"{nameof(FindLibrary)} Error: Couldn't find appropriate library in directory {directory}.");

        return null;
    }

    [CanBeNull]
    [return: AllowNull]
    static ModInfo GetEditorModInfo() =>
        AppDomain
           .CurrentDomain
           .GetAssemblies()
           .FirstOrDefault(static a => a.GetName().Name is UnityAssembly)
          ?.GetType(ModInfoEditor) is { } type &&
        type
           .GetMethod(ModInfoSerializerEditor, ToJsonBindings)
          ?.Invoke(type.GetProperty(ModInfoInstanceEditor, InstanceBindings)?.GetValue(null, null), null) is string s
            ? ModInfo.Deserialize(s).Value
            : null;

    [NotNull]
    static ModuleBuilder DefineMethod(
        [NotNull] this ModuleBuilder dynamicMod,
        [NotNull] in string dllName,
        [NotNull] in string name,
        [NotNull] in Type returnType,
        [NotNull] in Type[] parameters
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
    static T CreateUnmanagedMethod<T>([NotNull] this string dllName, [NotNull] in string name)
        where T : Delegate
    {
        if (typeof(T).GetMethod(nameof(Action<T>.Invoke)) is not { } invoke)
            return null;

        var assembly =
            AppDomain
               .CurrentDomain
               .DefineDynamicAssembly(new(name), AssemblyBuilderAccess.Run);

        var module = assembly.DefineDynamicModule(name);
        var parameters = Array.ConvertAll(invoke.GetParameters(), static x => x.ParameterType);
        var returnType = invoke.ReturnType;

        module
           .DefineMethod(dllName, name, returnType, parameters)
           .CreateGlobalFunctions();

        var method = module.GetMethod(name);

        return Delegate.CreateDelegate(typeof(T), method, false) as T;
    }
}
