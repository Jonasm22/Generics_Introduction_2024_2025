//Section 21 - 333
//Using a generic class type in a method

namespace MyApp_Part2;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Box<string> to store a string.
        Box<string> boxStr = new Box<string>("Hello World"); // Initialize with "Hello World".
        boxStr.UpdateContent("Learning C# is Fun"); // Update the content to a new string.
        var myVar = boxStr.GetContent(); // Retrieve the current content of the box.
        Console.WriteLine(myVar); // Print the current content.

        // Create an instance of Box<int> to store an integer.
        Box<int> boxInt = new Box<int>(14); // Initialize with the value 14.
        boxInt.UpdateContent(15); // Update the content to 15.
        var myVar2 = boxInt.GetContent(); // Retrieve the current content of the box.
        Console.WriteLine(myVar2); // Print the current content.

    }
}