namespace MyApp_Part7;
//Section 21 - 339
//Generic Interfaces.
//Generic Interfaces is not the same as Generic Classes
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

internal interface IRepository<T>
{
    
    void Add(T entity);
    void Remove(T entity);
    
}

internal class Product
{
    public int Id{get;set;}
    public string Name {get;set;}
    
}

internal class ProductRepository : IRepository<Product>
{
    public void Add(Product entity)
    {
        
        
        
    }
    public void Remove(Product entity)
    {
        
        
        
    }
    
    
    
    
}