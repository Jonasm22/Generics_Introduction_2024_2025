//Section 21 - 333
//Using a generic class type in a method

namespace MyApp_Part2;

// A generic class `Box<T>` that can store and manage content of any type `T`.
public class Box<T>
{
    // A private field to hold the content of the box.
    private T _content;

    // Constructor to initialize the box with an initial value.
    public Box(T initialValue)
    {
        _content = initialValue; // Set the initial value to the `_content` field.
    }

    // Method to update the content of the box.
    public void UpdateContent(T newContent)
    {
        _content = newContent; // Replace the current content with the new value.
        Console.WriteLine($"Updated content: {_content}"); // Display the updated content.
    }

    // Method to retrieve the current content of the box.
    public T GetContent()
    {
        return _content; // Return the value stored in `_content`.
    }
}