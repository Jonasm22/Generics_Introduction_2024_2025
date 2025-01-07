namespace MyApp_Part14;

internal interface ITask<TResult>
{
    TResult Perform();
}