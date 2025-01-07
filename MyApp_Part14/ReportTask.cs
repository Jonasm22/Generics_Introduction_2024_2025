namespace MyApp_Part14;

internal class ReportTask : ITask<string>
{
    public string ReportName {get; set;}
    public string Recipient {get; set;}
    
    public string Perform()
    {
        return  $"Report {ReportName} generated successfully";
    }
}