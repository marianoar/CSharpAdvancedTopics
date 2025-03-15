// See https://aka.ms/new-console-template for more information
using ExceptionHandling;

Console.WriteLine("Hello, Exception handling!");
StreamReader streamReader = null;
try
{
    //streamReader =  new StreamReader(@"c:\algo.txt");
    //var content = streamReader.ReadToEnd();
    //var calculator = new Calculator();
    //var result = calculator.Divide(5, 0);
    var api = new YouTubeApi();
    var videos = api.GetVideos("Mariano");
}
catch(DivideByZeroException ex)
{

}
catch(ArithmeticException ex)
{

}
catch (Exception ex)
{
    Console.WriteLine("Error error");
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("finally block");
    streamReader?.Dispose(); // reeemplazo el if
}