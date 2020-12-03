using System;
using System.IO;
using System.Linq;

namespace CSharpAdvance
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }

        private static void CustomExceptionMethod()
        {
            try
            {
                var youtubeApi = new YoutubeApi();
                var videos = youtubeApi.GetVideos();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ExceptionHandleMethod()
        {
            try
            {
                var calculator = new Calculator();
                calculator.Divide(5, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, an unexpected error occured");
            }
            finally
            {
                Console.WriteLine("Over");
            }

            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"c:\test.zip");
                var content = streamReader.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, an unexpected error occured");
            }
            finally
            {
                streamReader?.Dispose();
            }

            try
            {
                using (var streamReader1 = new StreamReader(@"c:\test.zip"))
                {
                    var content = streamReader1.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, an unexpected error occured");
            }
        }

        private static void DynamicMethod()
        {
            var i = 5;
            dynamic d = i;
            long l = d;
        }

        private static void NullableValueMethod()
        {
            DateTime? date = null;
            Console.WriteLine(date.GetValueOrDefault().ToString());
            Console.WriteLine(date.HasValue);
            // Console.WriteLine(date.Value);
            var date2 = date.GetValueOrDefault();
            DateTime? date3 = date2;
            Console.WriteLine(date3.GetValueOrDefault().ToString());
        }

        private static void LINQMethod()
        {
            var books = new BookRepository().GetBooks();
            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title);


            foreach (var cheapBook in cheapBooks)
            {
                Console.WriteLine("{0} : {1}", cheapBook.Title, cheapBook.Price.ToString());
            }

            Console.WriteLine();

            var bookTitles =
                from b in books
                where b.Price < 10
                orderby b.Price
                select b.Title;
            foreach (var bookTitle in bookTitles)
            {
                Console.WriteLine(bookTitle);
            }

            Console.WriteLine();
            
            Console.WriteLine(books.SingleOrDefault(b=> b.Title == "1") == null);
            Console.WriteLine(books.First(b=> b.Title == "C# Advanced Topics").Price.ToString());
            Console.WriteLine(books.Last(b=> b.Title == "C# Advanced Topics").Price.ToString());
            var pagedBooks = books.Skip(2).Take(3);
            foreach (var pagedBook in pagedBooks)
            {
                Console.WriteLine(pagedBook.Title);
            }

            var count = books.Count;
            Console.WriteLine(count);
            var maxPrice = books.Max(b => b.Price);
            Console.WriteLine(maxPrice);
            var minPrice = books.Min(b => b.Price);
            Console.WriteLine(minPrice);
            var sumPrice = books.Sum(b => b.Price);
            Console.WriteLine(sumPrice);
        }

        private static void ExtensionMethods()
        {
            var post = "This is going to be a really really really really long post";
            var shortenedPost = post.Shorten(5);
            Console.WriteLine(shortenedPost);
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