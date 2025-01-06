//Section 21 - 343
//Action<> generic delegate


namespace MyApp_part11;

class Program
{
    static void Main(string[] args)
    {
        Action action = () =>
        {
            Console.WriteLine("Hello World!");
        };
        action();
        
        
        
        Action<int>numPrint =(x)=>
        {
            Console.WriteLine(x);
        };

        numPrint(10);

        Action<float, float, float> floatPrint = (x,y,z) =>
        {
            Console.WriteLine(x + y + z);
        };

        floatPrint(1.1f, 2.2f, 3.3f);
        
    }
    
    
    
}