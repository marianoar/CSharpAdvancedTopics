// See https://aka.ms/new-console-template for more information
using Generics;
using System.Reflection;
using Delegates;
using System.Linq.Expressions;
using LambdaExpression;
using EventsAndDelegates;
using ExthensionMethods;

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

//var process = new PhotoProcessor();
//var filters = new PhotoFilters();
//PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
//filterHandler += filters.ApplyContrast;
//filterHandler += RemoveRedEyeFilter;

//process.Process("photo.jpg", filterHandler);

//Action<Photo> filterPlus = filters.Resize;
//filterPlus += filters.ApplyContrast;

//process.Process("photo.jpg", filterPlus);


//static void RemoveRedEyeFilter(Photo photo)
//{
//    Console.WriteLine("Removing red eyes");
//}
#endregion
#region Lambda Expression

//// args => expression
//Console.WriteLine(MyLambdaExpression.Square(5));

//// delegate <parameter, value salida>
//Func<int, int> square = number => number * number;

//Console.WriteLine(square(5));

//const int factor = 5;

//Func<int, int> multiplier = n => n * factor;

//Console.WriteLine(multiplier(5));

//var books = new BookRepository().GetBooks();

//var cheapBooks = books.FindAll(IsCheaperThan10);

//var cheapers = books.FindAll( b => b.Price < 10); //same but lambda expression

//foreach (var book in cheapBooks)
//{
//    Console.WriteLine(book.Title);
//}
//foreach (var book in cheapers)
//{
//    Console.WriteLine(book.Title);
//}

//static bool IsCheaperThan10(LambdaExpression.Book obj)
//{
//    return obj.Price < 10;
//}

#endregion
#region Events
//var video = new Video()
//{
//    Title = "Title video one",
//};
//var videoEncoder = new VideoEncoder(); //publisher
//var mailService =  new MailService(); // suscriber
//var messageService = new MessageService(); // subscriber

//videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
//videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

//videoEncoder.Encode(video);

#endregion
#region Exthension Methods

string post = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec vel egestas dolor, nec dignissim metus...";

var shorthedPost = post.Shorten(5); //exthension methods debe estar en el mismo Namespace
Console.WriteLine(shorthedPost);

IEnumerable<int> numbers = new List<int>() { 1,4,7,44,8,0,99,12};
var max = numbers.Max();
Console.WriteLine(max);
#endregion
