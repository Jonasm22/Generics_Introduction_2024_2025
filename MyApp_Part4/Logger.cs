//Section 21 - 335
//Generic methods without generic classes
namespace MyApp_Part4;

public class Logger
{
  public void Log<T>(T message)
  {
    Console.WriteLine(message.ToString());
  }
    
}