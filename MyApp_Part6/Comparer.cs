//Section 21 - 338
//Constraints for generic methods
namespace MyApp_Part6;

public class Comparer
{
    public static bool AreEqual<T>(T first, T second) where T : class
    {
        return first == second;
    }
    
    
}