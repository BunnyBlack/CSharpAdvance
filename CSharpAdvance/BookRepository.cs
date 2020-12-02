using System.Collections.Generic;

namespace CSharpAdvance
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book(){Title = "1",Price = 5},
                new Book(){Title = "2",Price = 7},
                new Book(){Title = "3",Price = 17}
            };
        }
    }
}