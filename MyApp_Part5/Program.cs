//Section 21 - 337
//Custmon interface constraint
namespace MyApp_Part5;

class Program
{
    static void Main(string[] args)
    {
        Repository<Product> productRepository = new Repository<Product>();
        var product = new Product();
        productRepository.Add(product);
    }


    class Product : IEntity
    {
        public int Id { get; }
    }
    
    
}

