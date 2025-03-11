// See https://aka.ms/new-console-template for more information
using Linq;

Console.WriteLine("Hello, LInQ!");

var books =  new BookRepository().GetBooks();

var noCheap = new List<Book>();
foreach (var book in books)
{
    if (book.Price > 10)
    {
        noCheap.Add(book);
    }
}
foreach (var book in noCheap)
    Console.WriteLine(book.Title+ " - "+book.Price);

Console.WriteLine("With LInQ");
// LINQ Query Operators

var cheaperBooks = from b in books 
                   where b.Price < 10 
                   orderby b.Title 
                   select b;

// LINQ Extension Methods
var cheapBooks = books
                    .Where(b => b.Price < 10)
                    .OrderBy(b => b.Title)
                    .Select(b=> b.Title);

foreach (var book in cheapBooks)
    //Console.WriteLine(book.Title + " - " + book.Price); Now I only have the title property
    Console.WriteLine(book);

var ABook = books.SingleOrDefault(b => b.Title == "ASP.NETxxx");
Console.WriteLine(ABook == null);

//others extension methods -> First, LastorDefault, etc

var moreBooks = books.Skip(2).Take(2);
var count = books.Count();
var max = books.Max(b => b.Price); // or minimo

//books.Sum();
//books.Average(b => b.Price);



