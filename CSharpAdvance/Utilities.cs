using System;

namespace CSharpAdvance
{
    public class Utilities<T> where T : IComparable, new()
    {
        public void DoSomething(T value)
        {
            var obj = new T();
        }
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}