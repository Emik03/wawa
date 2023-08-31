// SPDX-License-Identifier: MPL-2.0
namespace Wawa.Callbacks;

/// <summary>
/// Encapsulates a getter <see cref="Delegate"/> and a setter <see cref="Delegate"/> to get and set an inner value to provide a friendly and easy way to get or set one of multiple types with different <see cref="Type"/> signatures by using a general <see cref="Type"/> that acts as a bridge between them.
/// </summary>
/// <typeparam name="T">The generic which acts as the bridge between multiple types.</typeparam>
public abstract class Prop<T> : ICloneable
{
    [NotNull]
    const string Null = "null";

    [NotNull]
    static readonly Dictionary<Type, Dictionary<string, FieldInfo>> s_fields = new();

    /// <summary>Initializes a new instance of the <see cref="Prop{T}"/> class.</summary>
    /// <param name="instance">The instance to get the value from.</param>
    /// <param name="name">The name of <see cref="FieldInfo"/> to get the value of.</param>
    /// <param name="getterOverride">Overrides the getter in the event that the field cannot be found.</param>
    private protected Prop(
        [NotNull] object instance,
        [NotNull] string name,
        [AllowNull, CanBeNull] Func<object, T> getterOverride
    )
    {
        Instance = instance;
        GetterOverride = getterOverride;
        var type = instance.GetType();
        var dict = s_fields.TryGetValue(type, out var field) ? field : s_fields[type] = new(StringComparer.Ordinal);
        Info = dict.TryGetValue(name, out var value) ? value : dict[name] = type.GetField(name);
    }

    /// <summary>Initializes a new instance of the <see cref="Prop{T}"/> class.</summary>
    /// <param name="instance">The instance to get the value from.</param>
    /// <param name="info">The <see cref="FieldInfo"/> to access.</param>
    /// <param name="getterOverride">Overrides the getter in the event that the field cannot be found.</param>
    private protected Prop(
        [NotNull] object instance,
        [AllowNull, CanBeNull] FieldInfo info,
        [AllowNull, CanBeNull] Func<object, T> getterOverride
    )
    {
        Instance = instance;
        Info = info;
        GetterOverride = getterOverride;
    }

    /// <summary>Gets the instance which contains the values.</summary>
    internal object Instance { [NotNull, Pure] get; }

    /// <summary>Gets the field to access.</summary>
    [AllowNull, CanBeNull]
    internal FieldInfo Info { [Pure] get; }

    /// <summary>Gets the overriden getter that is used when the field couldn't be found.</summary>
    [AllowNull, CanBeNull]
    private protected Func<object, T> GetterOverride { [Pure] get; }

    /// <inheritdoc/>
    [Pure]
    public abstract object Clone();

    /// <inheritdoc/>
    [Pure]
    public sealed override string ToString() => $"{GetType().Name}: {Info?.ToString() ?? Null}";
}
