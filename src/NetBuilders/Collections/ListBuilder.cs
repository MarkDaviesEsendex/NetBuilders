using System.Collections.Generic;

namespace NetBuilders.Collections
{
    public class ListBuilder<T> : IListBuilder<T>
    {
        private readonly IList<T> _list;

        public ListBuilder()
        {
            _list = new List<T>();
        }

        public ListBuilder(IList<T> list)
        {
            _list = list;
        }

        public IListBuilder<T> Add(T item)
        {
            _list.Add(item);
            return this;
        }

        public IListBuilder<T> Insert(int index, T item)
        {
            _list.Insert(index, item);
            return this;
        }

        public IListBuilder<T> RemoveAt(int index)
        {
            _list.RemoveAt(index);
            return this;
        }

        public IList<T> ToList() 
            => _list;
    }
}