namespace L1_MyApp;

public class Box<T>
{
    public T content { get; set; }

    public string Log()
    {
        return $"Box Contains {content}";
    }
}