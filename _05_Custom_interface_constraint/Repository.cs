//Section 21 - 337
//Custmon interface constraint

namespace MyApp_Part5;

internal interface IEntity
{
    int Id { get; }
    
}

internal class Repository <T> where T : IEntity
{
    private List<T> _values = new List<T>();

    public void Add(T entity)
    {
        _values.Add(entity);
    }
    
    
}