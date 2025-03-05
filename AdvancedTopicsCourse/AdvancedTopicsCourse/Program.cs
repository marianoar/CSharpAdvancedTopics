// See https://aka.ms/new-console-template for more information
using Generics;
using System.Reflection;

Console.WriteLine("Hello, World!");

Book book = new Book { Isbn = "123", Title = "C# Sarasa" };

var numbers = new List<int>();
numbers.Add(1);

var books = new BookList();
books.Equals(book);

var numbersGen = new GenericList<int>();
numbers.Add(1);

var booksGen = new GenericList<Book>();
booksGen.Add(book);

var dictionay = new GenericDictionary<string, Book>();
dictionay.Add("222", new Book());

var number = new Generics.Nullable<int>(5);
Console.WriteLine("Has value ?" + number.HasValue);
Console.WriteLine("VAlue: "+number.GetValueOrDefault());


