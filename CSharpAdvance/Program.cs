using System;

namespace CSharpAdvance
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filter = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filter.ApplyBrightness;
            filterHandler += filter.ApplyContrast;
            filterHandler += filter.Resize;
            processor.Process("photo.jpg",filterHandler);
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