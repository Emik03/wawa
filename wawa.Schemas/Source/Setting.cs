// SPDX-License-Identifier: MPL-2.0
namespace wawa.Schemas;

/// <summary>Explicitly defines the type of listing to use for a setting.</summary>
public static class TweaksSetting
{
    /// <summary>The default <see cref="TweaksSettingAttribute"/>.</summary>
    static readonly TweaksSettingAttribute s_empty = new();

    /// <summary>Indicates that the field or property is a setting serialized as an array.</summary>
    /// <param name="description">A longer description of the setting.</param>
    /// <param name="text">The short label describing the setting, defaulting to the field or property name.</param>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class ArrayAttribute([Allow, CanBe] string description = null, [Allow, CanBe] string text = null)
        : TweaksSettingAttribute(text, description);

    /// <summary>Indicates that the field or property is a setting serialized as a boolean.</summary>
    /// <param name="description">A longer description of the setting.</param>
    /// <param name="text">The short label describing the setting, defaulting to the field or property name.</param>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class CheckboxAttribute([Allow, CanBe] string description = null, [Allow, CanBe] string text = null)
        : TweaksSettingAttribute(text, description);

    /// <summary>Indicates that the field or property is a setting serialized as one of a set of values.</summary>
    /// <param name="description">A longer description of the setting.</param>
    /// <param name="text">The short label describing the setting, defaulting to the field or property name.</param>
    /// <param name="dropdownItems">The set of possible values.</param>
    [CLSCompliant(false)]
    public sealed class DropdownAttribute(
        [Allow, CanBe] string description = null,
        [Allow, CanBe] string text = null,
        [Allow, CanBe] params object[] dropdownItems
    ) : TweaksSettingAttribute(text, description)
    {
        /// <summary>Gets the set of possible values.</summary>
        [Allow, CanBe]
        public object[] DropdownItems { get; } = dropdownItems;
    }

    /// <summary>Indicates that the field or property is a setting serialized as one of a set of values.</summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class HiddenAttribute : TweaksSettingAttribute;

    /// <summary>Indicates that the field or property is a setting serialized as a number.</summary>
    /// <param name="description">A longer description of the setting.</param>
    /// <param name="text">The short label describing the setting, defaulting to the field or property name.</param>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class NumberAttribute([Allow, CanBe] string description = null, [Allow, CanBe] string text = null)
        : TweaksSettingAttribute(text, description);

    /// <summary>Indicates that the field or property is a setting serialized as a string.</summary>
    /// <param name="description">A longer description of the setting.</param>
    /// <param name="text">The short label describing the setting, defaulting to the field or property name.</param>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class StringAttribute([Allow, CanBe] string description = null, [Allow, CanBe] string text = null)
        : TweaksSettingAttribute(text, description);

    /// <summary>Indicates that the field or property is a setting serialized as a submenu.</summary>
    /// <param name="description">A longer description of the setting.</param>
    /// <param name="text">The short label describing the setting, defaulting to the field or property name.</param>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class SubmenuAttribute([Allow, CanBe] string description = null, [Allow, CanBe] string text = null)
        : TweaksSettingAttribute(text, description);

    /// <summary>Gets the <see cref="TweaksSettingAttribute"/> for the <paramref name="member"/>.</summary>
    /// <param name="member"></param>
    /// <exception cref="AmbiguousMatchException">
    /// The member provided has more than one <see cref="TweaksSettingAttribute"/> annotated.
    /// </exception>
    /// <returns>
    /// The <see cref="TweaksSettingAttribute"/> for the parameter <paramref name="member"/>. If the <see cref="MemberInfo"/>
    /// has no <see cref="TweaksSettingAttribute"/> annotations, then the default instance is returned. If the parameter
    /// <paramref name="member"/> is not a field or property, then <see langword="null"/> is returned instead.
    /// </returns>
    [CanBe]
    [return: Allow]
    public static TweaksSettingAttribute From(MemberInfo member) =>
        member.MemberType is not MemberTypes.Field and not MemberTypes.Property
            ? null
            : member.GetCustomAttributes(true).OfType<TweaksSettingAttribute>().ToList() switch
            {
                { Count: 0 } => s_empty,
                { Count: 1 } list => list[0],
                _ => throw new AmbiguousMatchException($"{member.Name} has multiple [Setting] annotations."),
            };
}
