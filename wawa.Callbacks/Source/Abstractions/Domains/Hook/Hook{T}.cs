// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Callbacks;

/// <summary>
/// Encapsulates a getter <see cref="Delegate"/> and a setter <see cref="Delegate"/> to get and set an inner value to
/// provide a friendly and easy way to get or set one of multiple types with different <see cref="Type"/> signatures
/// by using a general <see cref="Type"/> that acts as a bridge between them. The getter may <see langword="return"/>
/// <see langword="null"/>, and therefore is encapsulated in a <see cref="Maybe{T}"/>.
/// </summary>
/// <typeparam name="T">The generic which acts as the bridge between multiple types.</typeparam>
public abstract class Hook<T> : Prop<T>
    where T : Delegate
{
    [NotNull]
    static readonly Func<T, T> s_id = x => x;

    [NotNull]
    static readonly Func<Action, T> s_as = t => t as T;

    /// <summary>Initializes a new instance of the <see cref="Hook{T}"/> class.</summary>
    /// <param name="instance">The instance to get the value from.</param>
    /// <param name="name">The name of <see cref="FieldInfo"/> to get the value of.</param>
    /// <param name="getterOverride">Overrides the getter in the event that the field cannot be found.</param>
    /// <param name="converter">The converter from <see cref="Action"/> to <typeparamref name="T"/>.</param>
    /// <param name="wrapper">Specifies the transformation before storing in the <see cref="Chest"/>.</param>
    private protected Hook(
        [NotNull] object instance,
        [NotNull] string name,
        [AllowNull, CanBeNull] Func<object, T> getterOverride,
        [AllowNull, CanBeNull] Func<Action, T> converter,
        [AllowNull, CanBeNull] Func<T, T> wrapper = null
    )
        : base(instance, name, getterOverride)
    {
        Container = Info is null ? null : new();
        Converter = converter ?? s_as;
        Wrapper = wrapper ?? s_id;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Hook{T}"/> class.
    /// </summary>
    /// <param name="instance">The instance to get the value from.</param>
    /// <param name="info">The <see cref="FieldInfo"/> to access.</param>
    /// <param name="getterOverride">Overrides the getter in the event that the field cannot be found.</param>
    /// <param name="converter">The converter from <see cref="Action"/> to <typeparamref name="T"/>.</param>
    private protected Hook(
        [NotNull] object instance,
        [AllowNull, CanBeNull] FieldInfo info,
        [AllowNull, CanBeNull] Func<object, T> getterOverride,
        [AllowNull, CanBeNull] Func<Action, T> converter
    )
        : base(instance, info, getterOverride)
    {
        Converter = converter ?? s_as;
        Wrapper = s_id;
    }

    /// <summary>Gets the container.</summary>
    [AllowNull, CanBeNull]
    internal Chest? Container { [Pure] get; }

    /// <summary>Gets the converter from <see cref="Action"/> to <typeparamref name="T"/>.</summary>
    [NotNull]
    internal Func<Action, T> Converter { [Pure] get; }

    /// <summary>Gets the wrapper, used to intercept how the underlying function gets invoked.</summary>
    [NotNull]
    internal Func<T, T> Wrapper { [Pure] get; }
}
