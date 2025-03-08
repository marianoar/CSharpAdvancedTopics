using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class BookRepository
    {
        public List<Book> GetBooks() { 
            return new List<Book>
            {
                new Book(){Title="Title one", Price = 5},
                new Book(){Title="Title one", Price = 5},
                new Book(){Title="Title one", Price = 5},
            }; 
        }
    }
}
