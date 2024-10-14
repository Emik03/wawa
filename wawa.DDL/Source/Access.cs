// SPDX-License-Identifier: MPL-2.0
namespace wawa.DDL;

/// <summary>A class for accessing things from the game.</summary>
[PublicAPI]
public static class Access
{
    /// <summary>The class for accessing external methods specifically exported for use in this library.</summary>
    /// <typeparam name="T">The type of the parameter.</typeparam>
    /// <typeparam name="TResult">The type of return.</typeparam>
    static class Overrides<T, TResult>
    {
        /// <summary>The cache of delegates.</summary>
        static readonly Dictionary<string, Converter<T, TResult>> s_cache = [];

        /// <summary>Gets or adds the method with the specified name.</summary>
        /// <param name="name">The name of the method.</param>
        /// <returns>The method.</returns>
        [CanBeNull]
        [return: AllowNull]
        public static Converter<T, TResult> GetOrAdd(string name)
        {
            if (s_cache.TryGetValue(name, out var cache))
                return cache;

            if ((typeof(TResult).Name is nameof(ModInfo) && Create<string>(name) is { } toJson
                ? x => JsonConvert.DeserializeObject<TResult>(toJson(x), new JsonSerializerSettings())
                : Create<TResult>(name)) is { } add)
            {
                s_cache.Add(name, add);
                return add;
            }

            s_type?.InvokeMember("Error", Binds, null, null, [typeof(T), typeof(TResult), name]);
            s_cache.Add(name, null);
            return null;
        }

        /// <summary>Creates the delegate around the method with the specified name.</summary>
        /// <typeparam name="TO">The return type.</typeparam>
        /// <param name="name">The name of the method.</param>
        /// <returns>The delegate.</returns>
        [CanBeNull, Pure]
        static Converter<T, TO> Create<TO>(string name) =>
            s_type is null ? null : Delegate.CreateDelegate(typeof(Converter<T, TO>), s_type, name) as Converter<T, TO>;
    }

    /// <summary>The flags for binding methods.</summary>
    const BindingFlags Binds =
        BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod;

    /// <summary>The type that contains the requested overrides.</summary>
    static readonly Type? s_type = AppDomain.CurrentDomain.GetAssemblies()
       .OrderByDescending(x => x.GetName().Name is "Assembly-CSharp")
       .Select(x => x.GetType("wawa.DDL.Overrides", false, false))
       .FirstOrDefault(x => x is not null);

    /// <summary>Gets a value indicating whether the runtime is in a non-official game.</summary>
    [PublicAPI]
    public static bool IsRewritten { [Pure] get; } = Application.productName is not "Keep Talking and Nobody Explodes";

    /// <summary>Gets a value indicating whether the runtime is in-game.</summary>
    [PublicAPI]
    public static bool IsKtane { [Pure] get; } = !IsRewritten && !Application.isEditor;

    /// <summary>Method for obtaining something from the game, ensuring that the Unity editor stays happy.</summary>
    /// <remarks><para>
    /// This API primarily exists for if you already have a reference to Assembly-CSharp.dll, typically involving using
    /// a class library to allow such a reference. If you do not use a class library, then this method can be ignored in
    /// favor of wrappers such as <see cref="Lookup"/>, <see cref="Missions"/>, or <see cref="Preferences"/>.
    /// </para><para>
    /// Unlike the other APIs exposed by these libraries, the return value of <typeparamref name="T"/>'s
    /// nullability may not be trusted if it is a reference type or <see cref="Nullable{T}"/>, even when
    /// <paramref name="def"/> itself is non-null. As such, enable nullable reference types or use
    /// <see cref="Maybe.AsMaybe{T}"/> to enforce type safety.
    /// </para><para>
    /// To guarantee the DDL pattern, ensure that <typeparamref name="T"/> is not from a potentially
    /// unavailable reference, and avoid creating closures that capture state without first
    /// downcasting to <see cref="object"/> beforehand, and recasting within the closure.
    /// </para><para>
    /// Never assume functions or fields pulled directly from Assembly-CSharp.dll are safe and guaranteed non-null.
    /// </para></remarks>
    /// <typeparam name="T">The type of the return, be sure that this doesn't come from the game.</typeparam>
    /// <param name="ktane">The factory containing one or more references that may be unavailable.</param>
    /// <param name="def">The value to return instead, since <paramref name="ktane"/> is for in-game only.</param>
    /// <param name="overriden">The name of the factory to invoke.</param>
    /// <returns>The value from <paramref name="ktane"/>, or <see langword="default"/>.</returns>
    [CanBeNull, PublicAPI]
    [return: AllowNull]
    public static T FromGame<T>(
        [InstantHandle, NotNull, RequireStaticDelegate(IsError = true)] Converter<DBNull, T> ktane,
        [AllowNull, CanBeNull] T def = default,
        [CallerMemberName, NotNull] string overriden = ""
    ) =>
        FromGame(DBNull.Value, ktane, def, overriden);

    /// <summary>Method for obtaining something from the game, ensuring that the Unity editor stays happy.</summary>
    /// <remarks><para>
    /// This API primarily exists for if you already have a reference to Assembly-CSharp.dll, typically involving using
    /// a class library to allow such a reference. If you do not use a class library, then this method can be ignored in
    /// favor of wrappers such as <see cref="Lookup"/>, <see cref="Missions"/>, or <see cref="Preferences"/>.
    /// </para><para>
    /// Unlike the other APIs exposed by these libraries, the return value of <typeparamref name="TResult"/>'s
    /// nullability may not be trusted if it is a reference type or <see cref="Nullable{T}"/>, even when
    /// <paramref name="def"/> itself is non-null. As such, enable nullable reference types or use
    /// <see cref="Maybe.AsMaybe{T}"/> to enforce type safety.
    /// </para><para>
    /// To guarantee the DDL pattern, ensure that <typeparamref name="T"/> and <typeparamref name="TResult"/> are not
    /// from a potentially unavailable reference, and avoid creating closures that capture state without first
    /// downcasting to <see cref="object"/> beforehand, and recasting within the closure.
    /// </para><para>
    /// Never assume functions or fields pulled directly from Assembly-CSharp.dll are safe and guaranteed non-null.
    /// </para></remarks>
    /// <typeparam name="T">The context item, be sure that this doesn't come from the game.</typeparam>
    /// <typeparam name="TResult">The type of the return, be sure that this doesn't come from the game.</typeparam>
    /// <param name="context">The context element to pass into the callback.</param>
    /// <param name="ktane">The factory containing one or more references that may be unavailable.</param>
    /// <param name="def">The value to return instead, since <paramref name="ktane"/> is for in-game only.</param>
    /// <param name="overriden">The name of the factory to invoke.</param>
    /// <returns>The value from <paramref name="ktane"/>, or <see langword="default" />.</returns>
    [CanBeNull, PublicAPI]
    [return: AllowNull]
    public static TResult FromGame<T, TResult>(
        [AllowNull, CanBeNull] T context,
        [InstantHandle, NotNull, RequireStaticDelegate(IsError = true)] Converter<T, TResult> ktane,
        [AllowNull, CanBeNull] TResult def = default,
        [CallerMemberName, NotNull] string overriden = ""
    ) =>
        IsKtane ? ktane(context) :
        Overrides<T, TResult>.GetOrAdd(overriden) is { } method ? method(context) : def;
}
