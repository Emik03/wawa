// <copyright file="InstructionCore.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Wawa.TwitchPlays.Domains;

/// <summary>Implementations for <see cref="Instruction"/>.</summary>
[PublicAPI]
public static class InstructionCore
{
    /// <summary>Flattens the enumeration for coroutine use.</summary>
    /// <param name="that">This instance of <see cref="IEnumerable{T}"/>.</param>
    /// <returns>
    /// An <see cref="IEnumerator{T}"/> of <see cref="object"/> that is friendly to be used for coroutines,
    /// containing the values from <paramref name="that"/>.
    /// </returns>
    [NotNull, Pure]
    public static IEnumerator<object> Flatten([InstantHandle, NotNull] this IEnumerable<Instruction> that) =>
        that.GetEnumerator().Recursive();

    [NotNull, Pure]
    static IEnumerator<object?> Recursive([CanBeNull] this IEnumerator<Instruction> that)
    {
        if (that is null)
            yield break;

        while (that.MoveNext())
        {
            if (that.Current?.Value is not IEnumerator<Instruction> enumerable)
            {
                yield return that.Current?.Value;

                continue;
            }

            var these = enumerable.Recursive();

            while (these.MoveNext())
                yield return these.Current;
        }
    }
}
