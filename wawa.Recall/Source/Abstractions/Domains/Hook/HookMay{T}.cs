// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Recall;

/// <summary>
/// Encapsulates a getter <see cref="Delegate"/> and a setter <see cref="Delegate"/> to get and set an inner value to
/// provide a friendly and easy way to get or set one of multiple types with different <see cref="Type"/> signatures
/// by using a general <see cref="Type"/> that acts as a bridge between them. The getter may <see langword="return"/>
/// <see langword="null"/>, and therefore is encapsulated in a <see cref="Maybe{T}"/>.
/// </summary>
/// <typeparam name="T">The generic which acts as the bridge between multiple types.</typeparam>
public sealed class HookMay<T> : Hook<T>, IValued<Maybe<T>>
    where T : Delegate
{
    /// <summary>Initializes a new instance of the <see cref="HookMay{T}"/> class.</summary>
    /// <param name="instance">The instance to get the value from.</param>
    /// <param name="name">The name of <see cref="FieldInfo"/> to get the value of.</param>
    /// <param name="getterOverride">Overrides the getter in the event that the field cannot be found.</param>
    /// <param name="converter">The converter from <see cref="Action"/> to <typeparamref name="T"/>.</param>
    internal HookMay(
        [NotNull] object instance,
        [NotNull] string name,
        [AllowNull, CanBeNull] Func<object, T> getterOverride = null,
        [AllowNull, CanBeNull] Func<Action, T> converter = null
    )
        : base(instance, name, getterOverride, converter) { }

    HookMay(
        [NotNull] object instance,
        [AllowNull, CanBeNull] FieldInfo info,
        [AllowNull, CanBeNull] Func<object, T> getterOverride,
        [AllowNull, CanBeNull] Func<Action, T> converter
    )
        : base(instance, info, getterOverride, converter) { }

    /// <inheritdoc/>
    public Maybe<T> Value
    {
        // ReSharper disable NullableWarningSuppressionIsUsed
        [Pure] get => (Info is null ? GetterOverride?.Invoke(Instance) : this.Get())!;
    }

    /// <inheritdoc/>
    [Pure]
    public override object Clone() => new HookMay<T>(Instance, Info, GetterOverride, Converter);
}
