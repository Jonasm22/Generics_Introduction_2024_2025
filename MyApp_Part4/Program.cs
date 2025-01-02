//Section 21 - 335
//Generic methods without generic classes
namespace MyApp_Part4;

class Program
{
    static void Main(string[] args)
    {
        Logger logger = new Logger();
        logger.Log<int>(10);
        logger.Log<string>("Hello World");
        
        logger.Log(new {Name = "John Doe", Age = 20});
      
    }
}