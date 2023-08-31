// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Callbacks;

/// <summary>
/// Encapsulates a getter <see cref="Delegate"/> and a setter <see cref="Delegate"/> to get and set an inner value to
/// provide a friendly and easy way to get or set one of multiple types with different <see cref="Type"/> signatures
/// by using a general <see cref="Type"/> that acts as a bridge between them. The getter may <see langword="return"/>
/// <see langword="null"/>, and therefore is encapsulated in a <see cref="Maybe{T}"/>.
/// </summary>
/// <typeparam name="T">The generic which acts as the bridge between multiple types.</typeparam>
public sealed class PropMay<T> : Prop<T>, IValued<Maybe<T>>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PropMay{T}"/> class.
    /// </summary>
    /// <param name="instance">The instance to get the value from.</param>
    /// <param name="name">The name of <see cref="FieldInfo"/> to get the value of.</param>
    /// <param name="getterOverride">Overrides the getter in the event that the field cannot be found.</param>
    internal PropMay(
        [NotNull] object instance,
        [NotNull] string name,
        [AllowNull, CanBeNull] Func<object, T> getterOverride = null
    )
        : base(instance, name, getterOverride) { }

    PropMay(
        [NotNull] object instance,
        [AllowNull, CanBeNull] FieldInfo info,
        [AllowNull, CanBeNull] Func<object, T> getterOverride = null
    )
        : base(instance, info, getterOverride) { }

    /// <inheritdoc/>
    // ReSharper disable NullableWarningSuppressionIsUsed
    public Maybe<T> Value
    {
        [Pure] get => (Info is null ? GetterOverride is null ? default : GetterOverride.Invoke(Instance) : this.Get())!;
    }

    /// <inheritdoc/>
    [Pure]
    public override object Clone() => new PropMay<T>(Instance, Info, GetterOverride);
}
