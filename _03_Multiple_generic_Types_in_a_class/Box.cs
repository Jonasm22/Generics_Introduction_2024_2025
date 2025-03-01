//Section 21 - 334
//Multiple generic Types in a class
namespace MyApp_Part3;
public class Box<TFirst, TSecond>
{
    public TFirst First { get; set; }
    public TSecond Second { get; set; }

    public Box(TFirst first, TSecond second )
    {
        First = first;
        Second = second;
        
    }

    public void Display()
    {
        Console.WriteLine($"First: {First} , Second: {Second}");
    }
    
    
    
}