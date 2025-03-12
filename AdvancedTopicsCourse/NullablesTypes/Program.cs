// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Nullables!");

DateTime? date = null;

Nullable<DateTime> dateNullable = null;

Console.WriteLine("GetValueOrDefault(): "+ date.GetValueOrDefault());
Console.WriteLine("HasValue: "+date.HasValue);
//Console.WriteLine("Value: "+date.Value); //-> here we'll have an exception, because that we need to use the method value or default

DateTime? dt = new DateTime(2025, 03, 11);
DateTime date2 = dt.GetValueOrDefault();

DateTime? date3 = null;
if(date3 != null)
    date2 = date3.GetValueOrDefault();
else
    date2=DateTime.Now;

// Lo mismo pero en Null Coalescing operator
date2 = date3 ?? DateTime.Now;

// Tambien se podria castear pero daria error si es Null
//date2 = (DateTime)date3.Value;

DateTime? date4 = null;
DateTime date5 = date4.GetValueOrDefault();
Console.WriteLine(date5);

DateTime? date6 = null;
DateTime date7 = (DateTime)date6;


