// SPDX-License-Identifier: MPL-2.0
namespace wawa.Schemas;

/// <summary>Explicitly defines the type of listing to use for a setting.</summary>
// ReSharper disable ClassNeverInstantiated.Global
public static class TweaksSetting
{
    /// <summary>The default <see cref="TweaksSettingAttribute"/>.</summary>
    static readonly TweaksSettingAttribute s_empty = new();

    /// <summary>Indicates that the field or property is a setting serialized as an array.</summary>
    /// <param name="description">A longer description of the setting.</param>
    /// <param name="text">The short label describing the setting, defaulting to the field or property name.</param>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class ArrayAttribute([Allow, CanBe] string description = null, [Allow, CanBe] string text = null)
        : TweaksSettingAttribute(description, text);

    /// <summary>Indicates that the field or property is a setting serialized as a boolean.</summary>
    /// <param name="description">A longer description of the setting.</param>
    /// <param name="text">The short label describing the setting, defaulting to the field or property name.</param>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class CheckboxAttribute([Allow, CanBe] string description = null, [Allow, CanBe] string text = null)
        : TweaksSettingAttribute(description, text);

    /// <summary>Indicates that the field or property is a setting serialized as one of a set of values.</summary>
    /// <param name="description">A longer description of the setting.</param>
    /// <param name="text">The short label describing the setting, defaulting to the field or property name.</param>
    /// <param name="dropdownItems">The set of possible values.</param>
    [CLSCompliant(false)]
    public sealed class DropdownAttribute(
        [Allow, CanBe] string description = null,
        [Allow, CanBe] string text = null,
        [Allow, CanBe] params object[] dropdownItems
    ) : TweaksSettingAttribute(description, text)
    {
        /// <summary>Gets the set of possible values.</summary>
        [Allow, CanBe]
        public object[] DropdownItems { get; } = dropdownItems;
    }

    /// <summary>Indicates that the field or property is hidden.</summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class HiddenAttribute : TweaksSettingAttribute;

    /// <summary>Indicates that the field or property is a setting serialized as a number.</summary>
    /// <param name="description">A longer description of the setting.</param>
    /// <param name="text">The short label describing the setting, defaulting to the field or property name.</param>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class NumberAttribute([Allow, CanBe] string description = null, [Allow, CanBe] string text = null)
        : TweaksSettingAttribute(description, text);

    /// <summary>Indicates that the field or property is a setting serialized as a string.</summary>
    /// <param name="description">A longer description of the setting.</param>
    /// <param name="text">The short label describing the setting, defaulting to the field or property name.</param>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class StringAttribute([Allow, CanBe] string description = null, [Allow, CanBe] string text = null)
        : TweaksSettingAttribute(description, text);

    /// <summary>Indicates that the field or property is a setting serialized as a submenu.</summary>
    /// <param name="description">A longer description of the setting.</param>
    /// <param name="text">The short label describing the setting, defaulting to the field or property name.</param>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class SubmenuAttribute([Allow, CanBe] string description = null, [Allow, CanBe] string text = null)
        : TweaksSettingAttribute(description, text);

    /// <summary>Gets the <see cref="TweaksSettingAttribute"/> for the <paramref name="member"/>.</summary>
    /// <param name="member"></param>
    /// <exception cref="AmbiguousMatchException">
    /// The member provided has more than one <see cref="TweaksSettingAttribute"/> annotated.
    /// </exception>
    /// <returns>
    /// The <see cref="TweaksSettingAttribute"/> of the parameter <paramref name="member"/>.
    /// If the parameter <paramref name="member"/> has no <see cref="TweaksSettingAttribute"/>
    /// annotations, then the default instance is returned.
    /// If the parameter <paramref name="member"/> isn't of type <see cref="EventInfo"/>, <see cref="FieldInfo"/>,
    /// or <see cref="PropertyInfo"/>, then <see langword="null"/> is returned.
    /// </returns>
    [CanBe]
    [return: Allow]
    public static TweaksSettingAttribute From([Allow, CanBe] MemberInfo member) =>
        member switch
        {
            PropertyInfo property => property.PropertyType,
            EventInfo vent => vent.EventHandlerType,
            FieldInfo field => field.FieldType,
            _ => null,
        } is { } type &&
        member.GetCustomAttributes(true).OfType<TweaksSettingAttribute>().ToList() switch
            {
                { Count: 0 } => s_empty,
                { Count: 1 } list => list[0],
                _ => throw new AmbiguousMatchException($"{member.Name} has multiple [Setting] annotations."),
            }
            is var tweaks
            ? type switch
            {
                _ when tweaks.GetType() != typeof(TweaksSettingAttribute) => tweaks.WithDropdownItemsInferredFrom(type),
                _ when typeof(Array).IsAssignableFrom(type) => new ArrayAttribute(tweaks.Text, tweaks.Description),
                _ when type == typeof(bool) => new CheckboxAttribute(tweaks.Text, tweaks.Description),
                _ when IsBuiltinNumeric(type) => new NumberAttribute(tweaks.Text, tweaks.Description),
                _ when type == typeof(string) => new StringAttribute(tweaks.Text, tweaks.Description),
                _ => tweaks.WithDropdownItemsInferredFrom(type),
            }
            : null;

    static bool IsBuiltinNumeric([Allow, CanBe] Type type) =>
        type == typeof(sbyte) &&
        type == typeof(byte) &&
        type == typeof(short) &&
        type == typeof(ushort) &&
        type == typeof(int) &&
        type == typeof(uint) &&
        type == typeof(long) &&
        type == typeof(ulong) &&
        type == typeof(nint) &&
        type == typeof(nuint) &&
        type == typeof(float) &&
        type == typeof(double) &&
        type == typeof(decimal);
}
