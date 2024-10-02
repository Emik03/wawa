// SPDX-License-Identifier: MPL-2.0
namespace wawa.Recall;

/// <summary>Implementations for <see cref="Prop{T}"/> and its derivatives.</summary>
// ReSharper disable NullableWarningSuppressionIsUsed
[PublicAPI]
public static class Generator
{
    [NotNull]
    static readonly Dictionary<FieldInfo, Delegate>
        s_adders = [],
        s_getters = [],
        s_setters = [],
        s_removers = [];

    [NotNull]
    static readonly Dictionary<Type, Delegate> s_casters = [];

    [NotNull]
    static readonly MethodInfo
        s_caster = ((Func<Type, Func<Delegate, Delegate>>)Caster<Delegate>).Method,
        s_combine = ((Func<Delegate, Delegate, Delegate>)Delegate.Combine).Method,
        s_remove = ((Delegate)Delegate.Remove).Method;

    /// <inheritdoc cref="TrySet{T}(Hook{T}, T)"/>
    [PublicAPI]
    public static bool TrySet<T>(
        [AllowNull, CanBeNull, NotNullWhen(true)] this HookMay<T>? that,
        [AllowNull, CanBeNull, NotNullWhen(true)] T value
    )
        where T : Delegate =>
        (that as Hook<T>).TrySet(value);

    /// <inheritdoc cref="TrySet{T}(Hook{T}, Action)"/>
    [PublicAPI]
    public static bool TrySet<T>(
        [AllowNull, CanBeNull, NotNullWhen(true)] this HookMay<T>? that,
        [AllowNull, CanBeNull, NotNullWhen(true)] Action? value
    )
        where T : Delegate =>
        (that as Hook<T>).TrySet(value);

    /// <inheritdoc cref="TryAdd{T}(Hook{T}, T)"/>
    [PublicAPI]
    public static bool TryAdd<T>(
        [AllowNull, CanBeNull, NotNullWhen(true)] this HookMay<T>? that,
        [AllowNull, CanBeNull, NotNullWhen(true)] T value
    )
        where T : Delegate =>
        (that as Hook<T>).TryAdd(value);

    /// <inheritdoc cref="TryAdd{T}(Hook{T}, Action)"/>
    [PublicAPI]
    public static bool TryAdd<T>(
        [AllowNull, CanBeNull, NotNullWhen(true)] this HookMay<T>? that,
        [AllowNull, CanBeNull, NotNullWhen(true)] Action? value
    )
        where T : Delegate =>
        (that as Hook<T>).TryAdd(value);

    /// <inheritdoc cref="TryRemove{T}(Hook{T}, Delegate)"/>
    [PublicAPI]
    public static bool TryRemove<T>(
        [AllowNull, CanBeNull, NotNullWhen(true)] this HookMay<T>? that,
        [AllowNull, CanBeNull, NotNullWhen(true)] T value
    )
        where T : Delegate =>
        (that as Hook<T>).TryRemove(value);

    /// <inheritdoc cref="TryRemove{T}(Hook{T}, Delegate)"/>
    [PublicAPI]
    public static bool TryRemove<T>(
        [AllowNull, CanBeNull, NotNullWhen(true)] this HookMay<T>? that,
        [AllowNull, CanBeNull, NotNullWhen(true)] Action? value
    )
        where T : Delegate =>
        (that as Hook<T>).TryRemove(value);

    /// <summary>Sets the inner value to the parameter <paramref name="value"/>.</summary>
    /// <typeparam name="T">The type parameter of <see cref="Prop{T}"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Prop{T}"/>.</param>
    /// <param name="value">The value to set the inner value with.</param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    // ReSharper disable InvocationIsSkipped RedundantAssignment
    [NotNull, PublicAPI]
    public static PropDef<T> Set<T>(
        [NotNull] this PropDef<T> that,
        [AllowNull, CanBeNull, NotNullWhen(true)] T value
    )
    {
        var assertion = that.TrySet(value);
        Debug.Assert(assertion);
        return that;
    }

    /// <inheritdoc cref="TrySet{T}(Prop{T}, T)"/>
    [PublicAPI]
    public static bool TrySet<T>(
        [AllowNull, CanBeNull, NotNullWhen(true)] this PropMay<T>? that,
        [AllowNull, CanBeNull, NotNullWhen(true)] T value
    ) =>
        (that as Prop<T>).TrySet(value);

    /// <summary>Sets the inner value with the provided <paramref name="value"/>. Will throw on fail.</summary>
    /// <typeparam name="T">The type parameter of <see cref="Prop{T}"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Prop{T}"/>.</param>
    /// <param name="value">The value to set the inner value with.</param>
    /// <exception cref="InvalidOperationException">The parameter <paramref name="that"/> is immutable.</exception>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [NotNull, PublicAPI]
    public static PropMay<T> ExpectSet<T>(
        [NotNull] this PropMay<T> that,
        [AllowNull, CanBeNull, NotNullWhen(true)] T value
    ) =>
        (that as Prop<T>).TrySet(value).ShouldBeTrue(that);

    /// <inheritdoc cref="Set{T}(PropDef{T}, T)"/>
    [NotNull, PublicAPI]
    public static HookDef<T> SetRaw<T>(
        [NotNull] this HookDef<T> that,
        [AllowNull, CanBeNull, NotNullWhen(true)] T value
    )
        where T : Delegate
    {
        var assertion = that.TrySet(value);
        Debug.Assert(assertion);
        return that;
    }

    /// <inheritdoc cref="Set{T}(PropDef{T}, T)"/>
    [NotNull, PublicAPI]
    public static HookDef<T> Set<T>(
        [NotNull] this HookDef<T> that,
        [AllowNull, CanBeNull, NotNullWhen(true)] Action? value
    )
        where T : Delegate
    {
        var assertion = that.TrySet(value);
        Debug.Assert(assertion);
        return that;
    }

    /// <inheritdoc cref="ExpectSet{T}(PropMay{T}, T)"/>
    [NotNull, PublicAPI]
    public static HookMay<T> ExpectSetRaw<T>([NotNull] this HookMay<T> that, [AllowNull, CanBeNull] T value)
        where T : Delegate =>
        (that as Hook<T>).TrySet(value).ShouldBeTrue(that);

    /// <inheritdoc cref="ExpectSet{T}(PropMay{T}, T)"/>
    [NotNull, PublicAPI]
    public static HookMay<T> ExpectSet<T>([NotNull] this HookMay<T> that, [AllowNull, CanBeNull] Action? value)
        where T : Delegate =>
        (that as Hook<T>).TrySet(value).ShouldBeTrue(that)!;

    /// <summary>Adds the parameter <paramref name="value"/> from the inner value.</summary>
    /// <typeparam name="T">The type parameter of <see cref="Prop{T}"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Prop{T}"/>.</param>
    /// <param name="value">The value to set the inner value with.</param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [NotNull, PublicAPI]
    public static HookDef<T> AddRaw<T>(
        [NotNull] this HookDef<T> that,
        [AllowNull, CanBeNull, NotNullWhen(true)] T value
    )
        where T : Delegate
    {
        var assertion = that.TryAdd(value);
        Debug.Assert(assertion);
        return that;
    }

    /// <inheritdoc cref="AddRaw{T}"/>
    [NotNull, PublicAPI]
    public static HookDef<T> Add<T>(
        [NotNull] this HookDef<T> that,
        [AllowNull, CanBeNull, NotNullWhen(true)] Action? value
    )
        where T : Delegate
    {
        var assertion = that.TryAdd(value);
        Debug.Assert(assertion);
        return that;
    }

    /// <summary>Adds the parameter <paramref name="value"/> from the inner value. Will throw on fail.</summary>
    /// <typeparam name="T">The type parameter of <see cref="Prop{T}"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Prop{T}"/>.</param>
    /// <param name="value">The value to set the inner value with.</param>
    /// <exception cref="InvalidOperationException">The parameter <paramref name="that"/> is immutable.</exception>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [NotNull, PublicAPI]
    public static HookMay<T> ExpectAddRaw<T>([NotNull] this HookMay<T> that, [NotNull] T value)
        where T : Delegate =>
        (that as Hook<T>).TryAdd(value).ShouldBeTrue(that);

    /// <inheritdoc cref="ExpectAddRaw{T}"/>
    [NotNull, PublicAPI]
    public static HookMay<T> ExpectAdd<T>([NotNull] this HookMay<T> that, [NotNull] Action value)
        where T : Delegate =>
        (that as Hook<T>).TryAdd(value).ShouldBeTrue(that)!;

    /// <summary>Removes the parameter <paramref name="value"/> from the inner value.</summary>
    /// <typeparam name="T">The type parameter of <see cref="Prop{T}"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Prop{T}"/>.</param>
    /// <param name="value">The value to set the inner value with.</param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [NotNull, PublicAPI]
    public static HookDef<T> RemoveRaw<T>(
        [NotNull] this HookDef<T> that,
        [AllowNull, CanBeNull, NotNullWhen(true)] T value
    )
        where T : Delegate
    {
        var assertion = that.TryRemove(value);
        Debug.Assert(assertion);
        return that;
    }

    /// <inheritdoc cref="RemoveRaw{T}"/>
    [NotNull, PublicAPI]
    public static HookDef<T> Remove<T>(
        [NotNull] this HookDef<T> that,
        [AllowNull, CanBeNull, NotNullWhen(true)] Action? value
    )
        where T : Delegate
    {
        var assertion = that.TryRemove(value);
        Debug.Assert(assertion);
        return that;
    }

    /// <summary>Clears all hooks set by this instance.</summary>
    /// <typeparam name="T">The type parameter of <see cref="Prop{T}"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Hook{T}"/>.</param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [NotNull, PublicAPI]
    public static Hook<T> Clear<T>([NotNull] this Hook<T> that)
        where T : Delegate
    {
        if (that.Container is not { } container)
            return that;

        foreach (var next in container)
            that.TryRemove(next);

        return that;
    }

    /// <inheritdoc cref="Clear{T}(Hook{T})"/>
    [NotNull, PublicAPI]
    public static HookDef<T> Clear<T>([NotNull] this HookDef<T> that)
        where T : Delegate
    {
        (that as Hook<T>).Clear();
        return that;
    }

    /// <inheritdoc cref="Clear{T}(Hook{T})"/>
    [NotNull, PublicAPI]
    public static HookMay<T> Clear<T>([NotNull] this HookMay<T> that)
        where T : Delegate
    {
        (that as Hook<T>).Clear();
        return that;
    }

    /// <summary>Removes the parameter <paramref name="value"/> from the inner value. Will throw on fail.</summary>
    /// <typeparam name="T">The type parameter of <see cref="Prop{T}"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Prop{T}"/>.</param>
    /// <param name="value">The value to set the inner value with.</param>
    /// <exception cref="InvalidOperationException">The parameter <paramref name="that"/> is immutable.</exception>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [NotNull, PublicAPI]
    public static HookMay<T>? ExpectRemoveRaw<T>([NotNull] this HookMay<T> that, [NotNull] T value)
        where T : Delegate =>
        (that as Hook<T>).TryRemove(value).ShouldBeTrue(that);

    /// <inheritdoc cref="ExpectRemoveRaw{T}"/>
    [NotNull, PublicAPI]
    public static HookMay<T> ExpectRemove<T>([NotNull] this HookMay<T> that, [NotNull] Action value)
        where T : Delegate =>
        (that as Hook<T>).TryRemove(value).ShouldBeTrue(that)!;

    /// <summary>Gets the logger of the <see cref="IVanilla"/>.</summary>
    /// <param name="vanilla">The current <see cref="IVanilla"/>.</param>
    /// <param name="label">An additional label to attach to the end.</param>
    /// <returns>The callable function that logs the current path of the encapsulated value.</returns>
    [CLSCompliant(false), NotNull, PublicAPI, Pure]
    public static Action Logger([NotNull] this IVanilla vanilla, [AllowNull, CanBeNull] string label = null) =>
        () => Debug.LogFormat(vanilla.Value.GetPath(label));

    /// <inheritdoc cref="Do{T}(T, Action{T})"/>
    [CLSCompliant(false), NotNull]
    public static IEnumerable<T> Do<T>(
        [AllowNull, CanBeNull, InstantHandle] this IEnumerable<T>? that,
        [InstantHandle] Action<T> action
    )
        where T : IVanilla // ReSharper disable PossibleMultipleEnumeration
    {
        if (that is null)
            return Enumerable.Empty<T>();

        foreach (var next in that)
            next.Do(action);

        return that; // ReSharper restore PossibleMultipleEnumeration
    }

    /// <summary>Executes the function, then returns the parameter <paramref name="that"/>.</summary>
    /// <remarks><para>
    /// Types that implement <see cref="IVanilla"/> generally expose lots of callbacks.
    /// As such it may be desired to pass a reference of <paramref name="that"/> into the callback.
    /// This function acts as a Y-combinator, allowing you to assign a temporary variable that can bind to the callback.
    /// </para></remarks>
    /// <typeparam name="T">The type of context value.</typeparam>
    /// <param name="that">The value to pass into the callback.</param>
    /// <param name="action">The callback.</param>
    /// <returns>The parameter <paramref name="that"/>.</returns>
    [CLSCompliant(false), NotNull]
    public static T Do<T>([NotNull] this T that, [InstantHandle] Action<T> action)
        where T : IVanilla
    {
        action(that);
        return that;
    }

    /// <summary>Gets the inner value.</summary>
    /// <typeparam name="T">The type parameter of <see cref="Prop{T}"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Prop{T}"/>.</param>
    /// <returns>The value returned from the callback, or <see langword="default"/>.</returns>
    [return: AllowNull]
    [CanBeNull]
    internal static T Get<T>([AllowNull, CanBeNull, NotNullWhen(true)] this Prop<T>? that) =>
        that?.Info is null ? default : that.Info.Getter<T>()(that.Instance);

    /// <summary>Attempts to set the inner value to the parameter <paramref name="value"/>.</summary>
    /// <typeparam name="T">The type parameter of <see cref="Prop{T}"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Prop{T}"/>.</param>
    /// <param name="value">The value to set the inner value with.</param>
    /// <returns>The value <see langword="true"/> if the value set was successful, otherwise <see langword="false"/>.</returns>
    static bool TrySet<T>(
        [AllowNull, CanBeNull, NotNullWhen(true)] this Prop<T>? that,
        [AllowNull, CanBeNull, NotNullWhen(true)] T value
    )
    {
        if (that is null or { Info: null } || that.GetType().GetGenericTypeDefinition() == typeof(Hook<>))
            return false;

        that.Info.Setter<T>()(that.Instance, value);
        return true;
    }

    /// <inheritdoc cref="TrySet{T}(Prop{T}, T)"/>
    static bool TrySet<T>(
        [AllowNull, CanBeNull, NotNullWhen(true)] this Hook<T>? that,
        [AllowNull, CanBeNull] T value
    )
        where T : Delegate
    {
        if (that is null or { Container: null } or { Info: null })
            return false;

        var del = that.Info.FieldType.Caster<T>()(that.Wrapper(value));
        that.Info.Setter<Delegate>()(that.Instance, del);
        that.Container.Clear();

        if (del is not null)
            that.Container.Add(value, del);

        return true;
    }

    /// <inheritdoc cref="TrySet{T}(Hook{T}, T)"/>
    static bool TrySet<T>(
        [AllowNull, CanBeNull, NotNullWhen(true)] this Hook<T>? that,
        [AllowNull, CanBeNull] Action? value
    )
        where T : Delegate
    {
        if (that is null or { Container: null } or { Info: null })
            return false;

        var del = that.Info.FieldType.Caster<T>()(that.Wrapper(that.Converter!(value)));
        that.Info.Setter<Delegate>()(that.Instance, del);
        that.Container.Clear();

        if (del is not null)
            that.Container.Add(value, del);

        return true;
    }

    /// <summary>Attempts to add the parameter <paramref name="value"/> from the inner value.</summary>
    /// <typeparam name="T">The type parameter of <see cref="Prop{T}"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Prop{T}"/>.</param>
    /// <param name="value">The value to set the inner value with.</param>
    /// <returns>The value <see langword="true"/> if mutation succeeded, otherwise; <see langword="false"/>.</returns>
    static bool TryAdd<T>(
        [AllowNull, CanBeNull, NotNullWhen(true)] this Hook<T>? that,
        [AllowNull, CanBeNull, NotNullWhen(true)] T? value
    )
        where T : Delegate
    {
        if (that is null or { Container: null } or { Info: null } || value is null)
            return false;

        var del = that.Info.FieldType.Caster<T>()(that.Wrapper(value));
        that.Info.Adder()(that.Instance, del);
        that.Container.Add(value, del);
        return true;
    }

    /// <inheritdoc cref="TryAdd{T}(Hook{T}, T)"/>
    static bool TryAdd<T>(
        [AllowNull, CanBeNull, NotNullWhen(true)] this Hook<T>? that,
        [AllowNull, CanBeNull, NotNullWhen(true)] Action? value
    )
        where T : Delegate
    {
        if (that is null or { Container: null } or { Info: null } || value is null)
            return false;

        var del = that.Info.FieldType.Caster<T>()(that.Wrapper(that.Converter!(value)));
        that.Info.Adder()(that.Instance, del);
        that.Container.Add(value, del);
        return true;
    }

    /// <summary>Attempts to remove the parameter <paramref name="value"/> from the inner value.</summary>
    /// <typeparam name="T">The type parameter of <see cref="Prop{T}"/>.</typeparam>
    /// <param name="that">This instance of <see cref="Prop{T}"/>.</param>
    /// <param name="value">The value to set the inner value with.</param>
    /// <returns>The value <see langword="true"/> if mutation succeeded, otherwise; <see langword="false"/>.</returns>
    static bool TryRemove<T>(
        [AllowNull, CanBeNull, NotNullWhen(true)] this Hook<T>? that,
        [AllowNull, CanBeNull, NotNullWhen(true)] Delegate? value
    )
        where T : Delegate
    {
        if (that is null or { Container: null } or { Info: null } || that.Container.Get(value) is not { } del)
            return false;

        that.Info.Remover()(that.Instance, del);
        that.Container.Remove(value);
        return true;
    }

    [NotNull]
    static Action<object, T> Mutator<T>(
        [NotNull] this FieldInfo info,
        [NotNull] in Dictionary<FieldInfo, Delegate> cache,
        [AllowNull, CanBeNull] in Func<MemberExpression, UnaryExpression, Expression> mutator = null
    )
    {
        if (cache.TryGetValue(info, out var value) && value is Action<object, T> fun)
            return fun;

        var act = mutator is null ? GenerateSetter<T>(info) : GenerateSetter<T>(info, mutator);
        cache[info] = act;
        return act;
    }

    [NotNull]
    static InvocationExpression Caller<T>([NotNull] this FieldInfo info, [NotNull] Expression exField)
    {
        var exT = Expression.Constant(typeof(T));
        var caster = s_caster.MakeGenericMethod(info.FieldType);
        var fun = Expression.Call(caster, exT);
        return Expression.Invoke(fun, exField);
    }

    [NotNull]
    static Action<object, T> GenerateSetter<T>(
        [NotNull] FieldInfo info,
        [NotNull, InstantHandle] Func<MemberExpression, UnaryExpression, Expression> mutator
    )
    {
        var exReference = Expression.Parameter(typeof(object), "o");
        var exValue = Expression.Parameter(typeof(T), "t");
        var exReferenceCast = Expression.Convert(exReference, info.DeclaringType!);
        var exValueCast = Expression.Convert(exValue, info.FieldType);
        var exField = Expression.Field(exReferenceCast, info);
        var exFieldCast = Expression.Convert(mutator(exField, exValueCast), info.FieldType);
        var exResult = Expression.Call(info.GenerateSetter<T>().Method, exReference, exFieldCast);
        return Expression.Lambda<Action<object, T>>(exResult, exReference, exValue).Compile();
    }

    [NotNull]
    static Action<object, T> GenerateSetter<T>([NotNull] this FieldInfo field)
    {
        var m = new DynamicMethod(nameof(GenerateSetter), typeof(void), [typeof(object), typeof(T)]);
        var cg = m.GetILGenerator();

        // arg0.<field> = arg1
        cg.Emit(OpCodes.Ldarg_0);
        cg.Emit(OpCodes.Castclass, field.DeclaringType!);
        cg.Emit(OpCodes.Ldarg_1);
        cg.Emit(OpCodes.Stfld, field);
        cg.Emit(OpCodes.Ret);

        return (Action<object, T>)m.CreateDelegate(typeof(Action<object, T?>));
    }

    [NotNull]
    static Action<object, Delegate> Adder([NotNull] this FieldInfo info) =>
        info.Mutator<Delegate>(s_adders, (m, v) => Expression.Call(s_combine, m, v));

    [NotNull]
    static Action<object, Delegate> Remover([NotNull] this FieldInfo info) =>
        info.Mutator<Delegate>(s_removers, (m, v) => Expression.Call(s_remove, m, v));

    [NotNull]
    static Action<object, T> Setter<T>([NotNull] this FieldInfo info) => info.Mutator<T>(s_setters);

    [NotNull]
    static Func<T, Delegate> Caster<T>([NotNull] this Type type)
        where T : Delegate
    {
        if (typeof(T) == type)
            return DelegateLot<T>.Id;

        if (s_casters.TryGetValue(type, out var value) && value is Func<T, Delegate> fun)
            return fun;

        var exNull = Expression.Constant(null, typeof(T));
        var exOtherNull = Expression.Constant(null, type);
        var exParameter = Expression.Parameter(typeof(T), nameof(T));
        var method = type.GetMethod(nameof(Action.Invoke))!;
        var exArgs = method.GetParameters().Select((x, i) => Expression.Parameter(x.ParameterType, $"a{i}")).ToArray();
        var exDest = typeof(T).GetMethod(nameof(Action.Invoke))!.GetParameters().Length is 0 ? [] : exArgs;
        var exInvoke = Expression.Invoke(exParameter, exDest.Cast<Expression>());
        var exLambda = Expression.Lambda(type, exInvoke, exArgs);
        var exIsNull = Expression.Equal(exParameter, exNull);
        var exCondition = Expression.Condition(exIsNull, exOtherNull, exLambda);
        var func = Expression.Lambda<Func<T, Delegate>>(exCondition, exParameter).Compile();
        s_casters[type] = func;
        return func;
    }

    [NotNull]
    static Func<object, T> Getter<T>([NotNull] this FieldInfo info)
    {
        if (s_getters.TryGetValue(info, out var value) && value is Func<object, T> fun)
            return fun;

        var exReference = Expression.Parameter(typeof(object), "x");
        var exCast = Expression.Convert(exReference, info.DeclaringType!);
        var exField = Expression.Field(exCast, info);

        Expression exDelegate = typeof(T) != info.FieldType && typeof(Delegate).IsAssignableFrom(typeof(T))
            ? info.Caller<T>(exField)
            : exField;

        var exResult = Expression.Convert(exDelegate, typeof(T));
        var func = Expression.Lambda<Func<object, T>>(exResult, exReference).Compile();
        s_getters[info] = func;
        return func;
    }

    [NotNull]
    static T ShouldBeTrue<T>(this bool assert, [NotNull] T consequent) =>
        assert ? consequent : throw new InvalidOperationException(Message(consequent));

    [NotNull, Pure]
    static string Message([NotNull] object consequent) =>
        $"Assertion failed while calling {new StackTrace().GetFrame(1).GetMethod().Name}; cannot operate on current object \"{consequent}\"";
}
