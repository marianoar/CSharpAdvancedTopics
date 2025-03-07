// See https://aka.ms/new-console-template for more information
using Generics;
using System.Reflection;
using Delegates;

# region Generics
//Console.WriteLine("Hello, World!");

//Book book = new Book { Isbn = "123", Title = "C# Sarasa" };

//var numbers = new List<int>();
//numbers.Add(1);

//var books = new BookList();
//books.Equals(book);

//var numbersGen = new GenericList<int>();
//numbers.Add(1);

//var booksGen = new GenericList<Book>();
//booksGen.Add(book);

//var dictionay = new GenericDictionary<string, Book>();
//dictionay.Add("222", new Book());

//var number = new Generics.Nullable<int>(5);
//Console.WriteLine("Has value ?" + number.HasValue);
//Console.WriteLine("VAlue: "+number.GetValueOrDefault());
#endregion

#region Delegates

var process = new PhotoProcessor();
var filters = new PhotoFilters();
PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
filterHandler += filters.ApplyContrast;
filterHandler += RemoveRedEyeFilter;

process.Process("photo.jpg", filterHandler);

Action<Photo> filterPlus = filters.Resize;
filterPlus += filters.ApplyContrast;

process.Process("photo.jpg", filterPlus);


static void RemoveRedEyeFilter(Photo photo)
{
    Console.WriteLine("Removing red eyes");
}
#endregion


