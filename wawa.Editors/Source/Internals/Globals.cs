// SPDX-License-Identifier: MPL-2.0
namespace wawa.Editors.Internals;

/// <summary>Contains static methods able to be accessed from anywhere within this library.</summary>
static class Globals
{
    /// <summary>The default string comparison throughout the library.</summary>
    internal const StringComparison Ordinal = StringComparison.Ordinal;

    /// <summary>Gets the name of <see cref="Caller"/>.</summary>
    [NotNull]
    internal static string Who => Caller.Name;

    /// <summary>Gets the <see cref="AssemblyName"/> of the caller that invoked the method calling this.</summary>
    /// <remarks><para>This is used by the library to log itself, and obtain information about callers.</para></remarks>
    [NotNull] // ReSharper disable once NullableWarningSuppressionIsUsed
    static AssemblyName Caller => new StackFrame(2).GetMethod().ReflectedType?.Assembly.GetName()!;

    /// <summary>Gets the version of <see cref="Caller"/>.</summary>
    [NotNull]
    static string Which =>
        Caller.Version is var ver && ver is { Minor: 0, Build: 0, Revision: 0 } ? $"v{ver.Major}" :
        ver is { Build: 0, Revision: 0 } ? $"v{ver.Major}.{ver.Minor}" :
        ver is { Revision: 0 } ? $"v{ver.Major}.{ver.Minor}.{ver.Build}" :
        $"v{ver.Major}.{ver.Minor}.{ver.Build}.{ver.Revision}";

    /// <summary>Logs a message to the Unity Console with the assembly's name that called this as an error.</summary>
    /// <param name="message">The message to log as an error.</param>
    internal static void AssemblyError([NotNull] string message) => Debug.LogError(Assembly(message));

    /// <summary>Logs a message to the Unity Console with the assembly's name that called this.</summary>
    /// <param name="message">The message to log.</param>
    internal static void AssemblyLog([NotNull] string message) => Debug.Log(Assembly(message));

    /// <summary>Determines if the request has failed.</summary>
    /// <param name="web">The <see cref="UnityWebRequest"/> to check.</param>
    /// <param name="data">The raw bytes from the request. Valid if method returns <see langword="false"/>.</param>
    /// <returns>
    /// The value <see langword="true"/> if a network or http error occured, otherwise <see langword="false"/>.
    /// </returns>
    internal static bool IsErr([NotNull] this UnityWebRequest web, [NotNull] out byte[] data)
    {
        var error = web.error;
        var code = web.responseCode;
        var downloadHandler = web.downloadHandler;
        data = downloadHandler.data;

        if (error is null &&
            code is >= 200 and < 300 &&
            data is { Length: not 0 })
            return false;

        AssemblyError($"Received {code} response code ({error})\n{downloadHandler.text}");
        data = [];
        return true;
    }

    [NotNull]
    static string Assembly([NotNull] this string message) => $"[{Who} ({Which})] {message}";
}
