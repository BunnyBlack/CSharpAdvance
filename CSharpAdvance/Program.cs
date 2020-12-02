using System;

namespace CSharpAdvance
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }

        private static void EventMethod()
        {
            var video = new Video {Title = "Video 1"};
            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();
            var messageService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.VideoEncoded;
            videoEncoder.Encode(video);
        }

        private static void LambdaMethod2()
        {
            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            foreach (var cheapBook in cheapBooks)
            {
                Console.WriteLine(cheapBook.Title);
            }

            Console.WriteLine();

            cheapBooks = books.FindAll(b => b.Price < 10f);
            foreach (var cheapBook in cheapBooks)
            {
                Console.WriteLine(cheapBook.Title);
            }
        }

        private static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10f;
        }

        private static void LambdaMethod()
        {
            Func<int, int> square = Square;
            square += n => n * n;
            Console.WriteLine(square(5));
        }

        private static int Square(int n)
        {
            return n * n;
        }

        private static void DelegateMethod()
        {
            var processor = new PhotoProcessor();
            var filter = new PhotoFilters();
            Action<Photo> filterHandler = filter.ApplyBrightness;
            filterHandler += filter.ApplyContrast;
            filterHandler += filter.Resize;
            processor.Process("photo.jpg", filterHandler);
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