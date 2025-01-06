//Section 21 - 344
//Func<> generic delegate

using System.Threading.Channels;

namespace MyApp_Part12;

class Program
{
    static void Main(string[] args)
    {
        Func<int, int ,string> sum = (x, y) =>
        {
            return (x + y).ToString();
        };

        Console.WriteLine(sum(10, 20));
        
    }
    
    
    
    
}