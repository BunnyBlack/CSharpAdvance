using System;

namespace CSharpAdvance
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }

        private static void MyNullable()
        {
            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value ?: {0}", number.HasValue);
            Console.WriteLine("Value: {0}", number.GetValueOrDefault());
        }

        private static void GenericCreate()
        {
            var list = new GenericList<int>();
            list.Add(1);
            Console.WriteLine(list[0]);
        }
    }
}