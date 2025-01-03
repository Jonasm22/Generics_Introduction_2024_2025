//Section 21 - 338
//Constraints for generic methods

namespace MyApp_Part6;

class Program
{
    static void Main(string[] args)
    {
        var productOne = new Product();
        var productTwo = new Product();
        
        var result= Comparer.AreEqual(productOne, productOne);
        var result2= Comparer.AreEqual(productOne, productTwo);

        Console.WriteLine(result);
        
    }

    public class Product()
    {
        
    }
}