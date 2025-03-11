using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){Title = "ADO.Net Step by Step", Price = 5},
                new Book(){Title = "Robin Hood", Price = 9.99f},
                new Book(){Title = "Alice in wonderland", Price = 11},
                new Book(){Title = "Bahia Blanca", Price = 8.5f},
                new Book(){Title = "C# Advanced topics", Price = 17},
                new Book(){Title = "ASP.NET", Price = 9}
            };
        }
    }
}
