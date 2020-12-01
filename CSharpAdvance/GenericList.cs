using System;
using System.Collections.Generic;

namespace CSharpAdvance
{
    public class GenericList<T>
    {
        private List<T> _list;

        public GenericList()
        {
            _list = new List<T>();
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public T this[int index]
        {
            get { return _list[index]; }
        }
    }

    public class GenericDic<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
            
        }
    }
}