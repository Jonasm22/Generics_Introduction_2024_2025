namespace MyApp_Part14;
// EXERCISE

class Program
{
    static void Main(string[] args)
    {
        var EmailTask = new EmailTask()
        {
            Message = "Hello World!",
            Recipient = "test@test.com",

        };
        var reportTask = new ReportTask()
        {
            ReportName = "Anual Report"
        };
        
        var emailProcessor = new TaskProcessor<EmailTask, string> (EmailTask);
        var reportProcessor = new TaskProcessor<ReportTask, string> (reportTask);

        Console.WriteLine(emailProcessor.Execute());

        Console.WriteLine(reportProcessor.Execute());
    }
        
}