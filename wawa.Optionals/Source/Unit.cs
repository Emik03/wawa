﻿#region Emik.MPL

// <copyright file="Unit.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

namespace Wawa.Optionals;

/// <summary>
/// A type that has exactly one value, and is used when there is no other meaningful value that could be returned.
/// </summary>
[PublicAPI]
public readonly struct Unit : ICloneable, IEquatable<Unit>, IEqualityComparer<Unit>
{
    /// <summary>Gets the singular value.</summary>
    public static Unit Value
    {
        [Pure] get => default;
    }

    /// <summary>Returns <see langword="true" />.</summary>
    /// <remarks><para>Since this type has one value, any instance is the same as each other.</para></remarks>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>The value <see langword="true" />.</returns>
    [Pure]
#pragma warning disable IDE0060
    public static bool operator ==([InstantHandle] Unit left, [InstantHandle] Unit right) => true;
#pragma warning restore IDE0060

    /// <summary>Returns <see langword="false" />.</summary>
    /// <remarks><para>Since this type has one value, any instance is the same as each other.</para></remarks>
    /// <param name="left">The left-hand side.</param>
    /// <param name="right">The right-hand side.</param>
    /// <returns>The value <see langword="false" />.</returns>
    [Pure]
#pragma warning disable IDE0060
    public static bool operator !=([InstantHandle] Unit left, [InstantHandle] Unit right) => true;
#pragma warning restore IDE0060

    /// <inheritdoc />
    [Pure]
    public override int GetHashCode() => 0;

    /// <inheritdoc />
    [Pure]
    public override bool Equals(object obj) => obj is Unit;

    /// <inheritdoc />
    [Pure]
    bool IEquatable<Unit>.Equals([InstantHandle] Unit other) => true;

    /// <inheritdoc />
    [Pure]
    bool IEqualityComparer<Unit>.Equals([InstantHandle] Unit x, [InstantHandle] Unit y) => true;

    /// <inheritdoc />
    [Pure]
    int IEqualityComparer<Unit>.GetHashCode([InstantHandle] Unit obj) => 0;

    /// <inheritdoc />
    [Pure]
    object ICloneable.Clone() => this;
}
