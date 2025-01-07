namespace MyApp_Part14;

internal class EmailTask : ITask<string>
{
    public string Message { get; set; }
    public string Recipient { get; set; }
    
    public string Perform()
    {
        return $"Email sent to {Recipient} with message {Message}";
    }
    
}