#region Emik.MPL

// <copyright file="MoreAttributes.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

// ReSharper disable ArrangeStaticMemberQualifier CheckNamespace ClassNeverInstantiated.Global EmptyNamespace RedundantUsingDirective
#pragma warning disable CA1019, GlobalUsingsAnalyzer, MA0047, MA0048, SA1216, SA1402, SA1403, SA1649

#region

using static System.AttributeTargets;

#endregion

namespace NullGuard
{
    /// <summary>Prevents the injection of null checking (implicit mode only).</summary>
    [AttributeUsage(Parameter | ReturnValue | Property)]
    sealed class AllowNullAttribute : Attribute { }
}

namespace System.Diagnostics.CodeAnalysis
{
    /*
        /// <summary>Specifies that null is allowed as an input even if the corresponding type disallows it.</summary>
        [AttributeUsage(Field | Parameter | Property)]
        sealed class AllowNullAttribute : Attribute { }
    */

    /// <summary>Specifies that null is disallowed as an input even if the corresponding type allows it.</summary>
    [AttributeUsage(Field | Parameter | Property)]
    sealed class DisallowNullAttribute : Attribute { }

    /// <summary>Specifies that an output may be null even if the corresponding type disallows it.</summary>
    [AttributeUsage(Field | Parameter | Property | ReturnValue)]
    sealed class MaybeNullAttribute : Attribute { }

    /// <summary>Specifies that an output will not be null even if the corresponding type allows it. Specifies that an input argument was not null when the call returns.</summary>
    [AttributeUsage(Field | Parameter | Property | ReturnValue)]
    sealed class NotNullAttribute : Attribute { }

    /// <summary>Specifies that when a method returns <see cref="ReturnValue"/>, the parameter may be null even if the corresponding type disallows it.</summary>
    [AttributeUsage(Parameter)]
    sealed class MaybeNullWhenAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaybeNullWhenAttribute"/> class
        /// with the specified return value condition.
        /// </summary>
        /// <param name="returnValue">
        /// The return value condition. If the method returns this value, the associated parameter may be null.
        /// </param>
        public MaybeNullWhenAttribute(bool returnValue) => ReturnValue = returnValue;

        /// <summary>
        /// Gets a value indicating whether the return value condition is <see langword="true"/> or <see langword="false"/>.
        /// </summary>
        public bool ReturnValue { get; }
    }

    /// <summary>
    /// Specifies that when a method returns <see cref="ReturnValue"/>,
    /// the parameter will not be null even if the corresponding type allows it.
    /// </summary>
    [AttributeUsage(Parameter)]
    sealed class NotNullWhenAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotNullWhenAttribute"/> class
        /// with the specified return value condition.
        /// </summary>
        /// <param name="returnValue">
        /// The return value condition. If the method returns this value, the associated parameter will not be null.
        /// </param>
        public NotNullWhenAttribute(bool returnValue) => ReturnValue = returnValue;

        /// <summary>
        /// Gets a value indicating whether the return value condition is <see langword="true"/> or <see langword="false"/>.
        /// </summary>
        public bool ReturnValue { get; }
    }

    /// <summary>Specifies that the output will be non-null if the named parameter is non-null.</summary>
    [AttributeUsage(Parameter | Property | ReturnValue, AllowMultiple = true)]
    sealed class NotNullIfNotNullAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotNullIfNotNullAttribute"/> class
        /// with the associated parameter name.
        /// </summary>
        /// <param name="parameterName">
        /// The associated parameter name.  The output will be non-null if the argument to the parameter specified is non-null.
        /// </param>
        public NotNullIfNotNullAttribute(string parameterName) => ParameterName = parameterName;

        /// <summary>Gets the associated parameter name.</summary>
        public string ParameterName { get; }
    }

    /// <summary>Applied to a method that will never return under any circumstance.</summary>
    [AttributeUsage(Method, Inherited = false)]
    sealed class DoesNotReturnAttribute : Attribute { }

    /// <summary>Specifies that the method will not return if the associated Boolean parameter is passed the specified value.</summary>
    [AttributeUsage(Parameter)]
    sealed class DoesNotReturnIfAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoesNotReturnIfAttribute"/> class
        /// with the specified parameter value.
        /// </summary>
        /// <param name="parameterValue">
        /// The condition parameter value. Code after the method will be considered unreachable by diagnostics if the argument to
        /// the associated parameter matches this value.
        /// </param>
        public DoesNotReturnIfAttribute(bool parameterValue) => ParameterValue = parameterValue;

        /// <summary>
        /// Gets a value indicating whether the condition parameter value
        /// is <see langword="true"/> or <see langword="false"/>.
        /// </summary>
        public bool ParameterValue { get; }
    }

    /// <summary>Specifies that the method or property will ensure that the listed field and property members have not-null values.</summary>
    [AttributeUsage(Method | Property, Inherited = false, AllowMultiple = true)]
    sealed class MemberNotNullAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberNotNullAttribute"/> class with a field or property member.
        /// </summary>
        /// <param name="member">
        /// The field or property member that is promised to be not-null.
        /// </param>
        public MemberNotNullAttribute(string member) => Members = new[] { member };

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberNotNullAttribute"/> class
        /// with the list of field and property members.
        /// </summary>
        /// <param name="members">
        /// The list of field and property members that are promised to be not-null.
        /// </param>
        public MemberNotNullAttribute(params string[] members) => Members = members;

        /// <summary>Gets field or property member names.</summary>
        public string[] Members { get; }
    }

    /// <summary>Specifies that the method or property will ensure that the listed field and property members have not-null values when returning with the specified return value condition.</summary>
    [AttributeUsage(Method | Property, Inherited = false, AllowMultiple = true)]
    sealed class MemberNotNullWhenAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberNotNullWhenAttribute"/> class
        /// with the specified return value condition and a field or property member.
        /// </summary>
        /// <param name="returnValue">
        /// The return value condition. If the method returns this value, the associated parameter will not be null.
        /// </param>
        /// <param name="member">
        /// The field or property member that is promised to be not-null.
        /// </param>
        public MemberNotNullWhenAttribute(bool returnValue, string member)
        {
            ReturnValue = returnValue;
            Members = new[] { member };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberNotNullWhenAttribute"/> class
        /// with the specified return value condition and list of field and property members.
        /// </summary>
        /// <param name="returnValue">
        /// The return value condition. If the method returns this value, the associated parameter will not be null.
        /// </param>
        /// <param name="members">
        /// The list of field and property members that are promised to be not-null.
        /// </param>
        public MemberNotNullWhenAttribute(bool returnValue, params string[] members)
        {
            ReturnValue = returnValue;
            Members = members;
        }

        /// <summary>
        /// Gets a value indicating whether the return value condition is <see langword="true"/> or <see langword="false"/>.
        /// </summary>
        public bool ReturnValue { get; }

        /// <summary>Gets field or property member names.</summary>
        public string[] Members { get; }
    }
}

namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Reserved to be used by the compiler for tracking metadata.
    /// This class should not be used by developers in source code.
    /// </summary>
    [DebuggerNonUserCode]
    static class IsExternalInit { }

    /// <inheritdoc />
    [AttributeUsage(Parameter)]
    sealed class CallerFilePathAttribute : Attribute { }

    /// <inheritdoc />
    [AttributeUsage(Parameter)]
    sealed class CallerLineNumberAttribute : Attribute { }

    /// <inheritdoc />
    [AttributeUsage(Parameter)]
    sealed class CallerMemberNameAttribute : Attribute { }
}
