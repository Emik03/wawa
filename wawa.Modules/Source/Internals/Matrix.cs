// SPDX-License-Identifier: MPL-2.0
namespace wawa.Modules.Internals;

/// <summary>Maps a 1-dimensional collection as 2-dimensional.</summary>
/// <typeparam name="T">The type of item within the list.</typeparam>
// ReSharper disable once ArrangeTypeMemberModifiers
sealed partial class Matrix<T> : IList<IList<T>>
{
    /// <summary>Represents a slice of a matrix.</summary>
    /// <param name="matrix">The matrix to reference.</param>
    /// <param name="ordinal">The first index of the matrix.</param>
    sealed class Slice([ProvidesContext] Matrix<T> matrix, [NonNegativeValue] int ordinal) : IList<T>
    {
        /// <inheritdoc />
        public T this[[NonNegativeValue] int index]
        {
            [Pure] get => matrix.List[Count * ordinal + index];
            set => matrix.List[Count * ordinal + index] = value;
        }

        /// <inheritdoc />
        public bool IsReadOnly
        {
            [Pure] get => matrix.List.IsReadOnly;
        }

        /// <inheritdoc />
        public int Count
        {
            [Pure] get => matrix.CountPerList;
        }

        /// <inheritdoc />
        public void Add(T item) => matrix.List.Insert(Count * (ordinal + 1), item);

        /// <inheritdoc />
        public void Clear()
        {
            for (int i = 0, count = Count; i < count; i++)
                matrix.List.RemoveAt(count * ordinal);
        }

        /// <inheritdoc />
        public void CopyTo(T[] array, [NonNegativeValue] int arrayIndex)
        {
            for (int i = 0, count = Count; i < count; i++)
                array[arrayIndex + i] = matrix.List[count * ordinal + i];
        }

        /// <inheritdoc />
        public void Insert([NonNegativeValue] int index, T item)
        {
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            if (Count is var count && index >= 0 && index < count)
                matrix.List.Insert(Count * ordinal + index, item);
        }

        /// <inheritdoc />
        public void RemoveAt([NonNegativeValue] int index)
        {
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            if (Count is var count && index >= 0 && index < count)
                matrix.List.RemoveAt(Count * ordinal + index);
        }

        /// <inheritdoc />
        [Pure]
        public bool Contains(T item) => IndexOf(item) is not -1;

        /// <inheritdoc />
        public bool Remove(T item)
        {
            for (int i = 0, count = Count; i < count; i++)
                if (count * ordinal + i is var view && EqualityComparer<T>.Default.Equals(matrix.List[view], item))
                {
                    matrix.List.RemoveAt(view);
                    return true;
                }

            return false;
        }

        /// <inheritdoc />
        [Pure, ValueRange(-1, int.MaxValue)]
        public int IndexOf(T item)
        {
            for (int i = 0, count = Count; i < count; i++)
                if (EqualityComparer<T>.Default.Equals(matrix.List[count * ordinal + i], item))
                    return i;

            return -1;
        }

        /// <inheritdoc />
        [Pure]
        public IEnumerator<T> GetEnumerator()
        {
            var count = Count;
            return matrix.List.Skip(count * ordinal).Take(count).GetEnumerator();
        }

        /// <inheritdoc />
        [Pure]
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    readonly Func<int> _countPerList;

    readonly Func<IList<T>> _list;

    /// <summary>Initializes a new instance of the <see cref="Matrix{T}"/> class.</summary>
    /// <param name="list">The list to encapsulate.</param>
    /// <param name="countPerList">The length per count.</param>
    public Matrix(Func<IList<T>> list, Func<int> countPerList)
    {
        _countPerList = countPerList;
        _list = list;
    }

    /// <inheritdoc cref="IList{T}.this"/>
    public IList<T> this[[NonNegativeValue] int index]
    {
        [Pure] get => new Slice(this, index);
        set => Add(value);
    }

    /// <inheritdoc />
    public bool IsReadOnly
    {
        [Pure] get => List.IsReadOnly;
    }

    /// <inheritdoc cref="ICollection{T}.Count" />
    [NonNegativeValue]
    public int Count
    {
        [Pure] get => List.Count / CountPerList;
    }

    /// <summary>Gets the amount of items per list.</summary>
    public int CountPerList
    {
        [Pure] get => _countPerList.Invoke();
    }

    /// <summary>Gets the encapsulated list.</summary>
    [ProvidesContext]
    public IList<T> List
    {
        [Pure] get => _list.Invoke();
    }

    /// <inheritdoc />
    public void Add(IList<T>? item)
    {
        if (item is null)
            return;

        // ReSharper disable once ForCanBeConvertedToForeach
        for (int i = 0, count = item.Count; i < count; i++)
            List.Add(item[i]);
    }

    /// <inheritdoc />
    public void Clear() => List.Clear();

    /// <inheritdoc />
    [Pure]
    public bool Contains(IList<T>? item) => IndexOf(item) is not -1;

    /// <inheritdoc />
    public void CopyTo(IList<T>[] array, [NonNegativeValue] int arrayIndex)
    {
        for (var i = 0; i < Count; i++)
            array[arrayIndex + i] = this[i];
    }

    /// <inheritdoc />
    public void Insert([NonNegativeValue] int index, IList<T>? item)
    {
        if (item is not null)
            this[index] = item;
    }

    /// <inheritdoc />
    public void RemoveAt([NonNegativeValue] int index) => this[index].Clear();

    /// <inheritdoc />
    public bool Remove(IList<T>? item)
    {
        if (item is null)
            return false;

        for (int i = 0, count = Count; i < count; i++)
            if (this[i].SequenceEqual(item))
            {
                RemoveAt(i);
                return true;
            }

        return false;
    }

    /// <inheritdoc />
    [Pure, ValueRange(-1, int.MaxValue)]
    public int IndexOf(IList<T>? item)
    {
        if (item is null)
            return -1;

        for (int i = 0, count = Count; i < count; i++)
            if (this[i].SequenceEqual(item))
                return i;

        return -1;
    }

    /// <inheritdoc />
    [Pure]
    public IEnumerator<IList<T>> GetEnumerator() =>
        Enumerable.Range(0, Count).Select(IList<T> (x) => new Slice(this, x)).GetEnumerator();

    /// <inheritdoc />
    [Pure]
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
