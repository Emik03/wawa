// SPDX-License-Identifier: MPL-2.0
namespace Wawa.DDL;

using static BindingFlags;

/// <summary>Allows for querying general data from the game.</summary>
// ReSharper disable Unity.PerformanceCriticalCodeInvocation
[PublicAPI]
public static class Lookup
{
    [NotNull]
    const string Name = "loadedMods";

    const BindingFlags Bindings = DeclaredOnly | Instance | NonPublic;

    /// <summary>Gets the dictionary of loaded mods.</summary>
    /// <remarks><para>
    /// In the editor, this value returns an instance of <see cref="Hashtable"/>, initialized as empty.
    /// </para></remarks>
    [NotNull, PublicAPI] // ReSharper disable once AssignNullToNotNullAttribute
    public static IDictionary Mods { [Pure] get; } = FromGame(0, static _ => Factory(), new Hashtable());

    /// <summary>Gets the localized value of a <see cref="string"/> term.</summary>
    /// <remarks><para>In the editor, this value returns <see cref="Maybe.None{T}"/>.</para></remarks>
    /// <param name="term">The term to get the localized <see cref="string"/> of.</param>
    /// <returns>The localized <see cref="string"/> of the parameter <paramref name="term"/>.</returns>
    [PublicAPI]
    public static Maybe<string> Localized([NotNull] string term) =>
        FromGame(term, static x => Localization.GetLocalizedString(x));

    /// <summary>Gets the mod name attached to the component.</summary>
    /// <remarks><para>In the editor, this value returns <see cref="Maybe.None{T}"/>.</para></remarks>
    /// <param name="component">The component to get the mod source from.</param>
    /// <returns>The mod name attached to the parameter <paramref name="component"/>.</returns>
    [CLSCompliant(false), PublicAPI]
    public static Maybe<string> ModNameOf([NotNull] Component component) =>
        FromGame(component, static o => o.GetComponent<ModSource>() is var m && m ? m.ModName : null);

    // ReSharper disable once NullableWarningSuppressionIsUsed
    [NotNull, PublicAPI]
    static IDictionary Factory() =>
        (typeof(ModManager).GetField(Name, Bindings)?.GetValue(ModManager.Instance) as IDictionary)!;
}
