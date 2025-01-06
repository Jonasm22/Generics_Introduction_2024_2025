//Section 21 - 341
//Combing generic classes and generic interfaces

namespace MyApp_part9;

class Example1
{
   public static void Example_One()
    {
        // Ejemplo de uso del repositorio
        IRepository<Product> productRepo = new Repository<Product>();

        // Agregar productos
        Product product1 = new Product { Id = 1, Name = "Laptop" };
        Product product2 = new Product { Id = 2, Name = "Mouse" };

        productRepo.Add(product1);
        productRepo.Add(product2);

        // Remover un producto
        productRepo.Remove(product1);
    }

    public interface IRepository<T>
    {
        void Add(T entity);
        void Remove(T entity);
    }

    public class Product 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Name}";
        }
    }

    public class Repository<T> : IRepository<T>
    {
        private readonly List<T> _entities = new List<T>();

        public void Add(T entity)
        {
            _entities.Add(entity);
            Console.WriteLine($"Added: {entity}");
        }

        public void Remove(T entity)
        {
            if (_entities.Remove(entity))
            {
                Console.WriteLine($"Removed: {entity}");
            }
            else
            {
                Console.WriteLine("Entity not found in repository.");
            }
        }

        public override string ToString()
        {
            return string.Join(", ", _entities);
        }
    }
}
