//Section 21 - 334
//Multiple generic Types in a class

namespace MyApp_Part3;

class Program
{
    static void Main(string[] args)
    {
        Box<int, string> box = new Box<int, string>(1000, "One Tousend");
        
        box.Display();
    }
}