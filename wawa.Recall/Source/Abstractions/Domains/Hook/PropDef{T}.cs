// SPDX-License-Identifier: MPL-2.0
namespace wawa.Recall;

/// <summary>
/// Encapsulates a getter <see cref="Delegate"/> and a setter <see cref="Delegate"/> to get and set an inner value to
/// provide a friendly and easy way to get or set one of multiple types with different <see cref="Type"/> signatures
/// by using a general <see cref="Type"/> that acts as a bridge between them. The getter may <see langword="return"/>
/// <see langword="null"/>, and therefore is encapsulated in a <see cref="Maybe{T}"/>.
/// </summary>
/// <typeparam name="T">The generic which acts as the bridge between multiple types.</typeparam>
public sealed class PropDef<T> : Prop<T>, IValued<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PropDef{T}"/> class.
    /// </summary>
    /// <param name="instance">The instance to get the value from.</param>
    /// <param name="name">The name of <see cref="FieldInfo"/> to get the value of.</param>
    /// <param name="getterOverride">Overrides the getter in the event that the field cannot be found.</param>
    internal PropDef(
        [NotNull] object instance,
        [NotNull] string name,
        [AllowNull, CanBeNull] Func<object, T> getterOverride = null
    )
        : base(instance, name, getterOverride) { }

    PropDef(
        [NotNull] object instance,
        [AllowNull, CanBeNull] FieldInfo info,
        [AllowNull, CanBeNull] Func<object, T>
            getterOverride
    )
        : base(instance, info, getterOverride) { }

    /// <inheritdoc/>
    public T Value
    {
        // ReSharper disable once NullableWarningSuppressionIsUsed
        [Pure] get => (Info is null ? GetterOverride is null ? default : GetterOverride.Invoke(Instance) : this.Get())!;
    }

    /// <inheritdoc/>
    [Pure]
    public override object Clone() => new PropDef<T>(Instance, Info, GetterOverride);
}
