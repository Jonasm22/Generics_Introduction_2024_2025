//Section 21 - 345
//Predicate<> generic delegate


namespace MyApp_Part13;

class Program
{
    static void Main(string[] args)
    {
        Predicate<int> isEven = (x) =>
        {
            return x % 2 == 0;
        };

        Console.WriteLine(isEven(43));
        
        List<int> intList = new List<int>(){1,2,3,4,5,6,7,8,9,10};
        var eventsInt = intList.FindAll(isEven);
    }
    
}