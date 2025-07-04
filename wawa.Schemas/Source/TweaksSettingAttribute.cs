// SPDX-License-Identifier: MPL-2.0
namespace wawa.Schemas;

using static TweaksSetting;

/// <summary>Indicates that the field or property is a setting for <see cref="TweaksEditorSettings"/>.</summary>
/// <param name="description">A longer description of the setting.</param>
/// <param name="text">The short label describing the setting, defaulting to the field or property name.</param>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class TweaksSettingAttribute([Allow, CanBe] string description = null, [Allow, CanBe] string text = null)
    : Attribute
{
    /// <summary>The names of overriding keys.</summary>
    const string
        Key = nameof(Key),
        KeyProperty = "PropertyName",
        KeyType = "JsonPropertyAttribute";

    /// <summary>Gets the longer description of the setting.</summary>
    [Allow, CanBe]
    public string Description
    {
        [Pure] get => description;
    }

    /// <summary>Gets the short label describing the setting.</summary>
    [Allow, CanBe]
    public string Text
    {
        [Pure] get => text;
    }

    /// <summary>Converts the <see cref="TweaksSettingAttribute"/> to the <see cref="Dictionary{TKey, TValue}"/>.</summary>
    /// <param name="member">The member to use to infer <see cref="Key"/> and <see cref="Text"/>.</param>
    /// <returns>The dictionary for the <see cref="TweaksEditorSettings"/>.</returns>
    internal Dictionary<string, object> ToDictionary(MemberInfo member)
    {
        Dictionary<string, object> dictionary = new(StringComparer.Ordinal)
        {
            [Key] = member.GetCustomAttributes(true).FirstOrDefault(x => x.GetType().Name is KeyType) is { } instance &&
                instance.GetType().GetProperty(KeyProperty) is { CanRead: true } property &&
                property.GetValue(instance, null) is string propertyName
                    ? propertyName
                    : member.Name,
            [nameof(Text)] = text ?? member.Name,
        };

        if (description is not null)
            dictionary[nameof(Description)] = description;

        if (this is DropdownAttribute { DropdownItems: var items })
            dictionary[nameof(DropdownAttribute.DropdownItems)] = (items ?? []).ToList();

        if (GetType() is var type && type != typeof(TweaksSettingAttribute) && type.Name.EndsWith(nameof(Attribute)))
            dictionary[nameof(Type)] = type.Name.Substring(0, type.Name.Length - nameof(Attribute).Length);

        return dictionary;
    }
}
