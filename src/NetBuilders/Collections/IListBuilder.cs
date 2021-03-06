﻿using System.Collections.Generic;

namespace NetBuilders.Collections
{
    public interface IListBuilder<T>
    {
        IListBuilder<T> Add(T item);
        IListBuilder<T> Insert(int index, T item);
        IListBuilder<T> RemoveAt(int index);
        IList<T> ToList();
    }
}