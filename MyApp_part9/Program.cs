namespace MyApp_part9;

//this project was created in Spanish Language
//The english version is not currently available 
class Program
{
    static void Main(string[] args)
    {
        IRepository<Product> productRepo = new Repository<Product>();
        bool running = true;

        while (running)
        {
            Console.Clear(); // Limpiar la pantalla para mostrar el menú actualizado
            Console.WriteLine("Gestión de Productos");
            Console.WriteLine("1. Agregar Producto");
            Console.WriteLine("2. Eliminar Producto");
            Console.WriteLine("3. Mostrar Productos");
            Console.WriteLine("4. Salir");

            Console.Write("Seleccione una opción: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddProduct(productRepo);
                    break;
                case "2":
                    RemoveProduct(productRepo);
                    break;
                case "3":
                    ShowProducts(productRepo);
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    static void AddProduct(IRepository<Product> productRepo)
    {
        Console.Write("Ingrese el ID del producto: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el nombre del producto: ");
        string name = Console.ReadLine();

        Product product = new Product { Id = id, Name = name };
        productRepo.Add(product);

        Console.WriteLine("Producto agregado con éxito.");
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void RemoveProduct(IRepository<Product> productRepo)
    {
        Console.Write("Ingrese el ID del producto a eliminar: ");
        int id = int.Parse(Console.ReadLine());

        Product productToRemove = null;
        foreach (var product in productRepo.GetAll())
        {
            if (product.Id == id)
            {
                productToRemove = product;
                break;
            }
        }

        if (productToRemove != null)
        {
            productRepo.Remove(productToRemove);
            Console.WriteLine("Producto eliminado con éxito.");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }

        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ShowProducts(IRepository<Product> productRepo)
    {
        Console.WriteLine("Productos en el repositorio:");
        Console.WriteLine(productRepo);
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    internal interface IRepository<T>
    {
        void Add(T entity);
        void Remove(T entity);
        IEnumerable<T> GetAll();
    }

    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Name}";
        }
    }

    internal class Repository<T> : IRepository<T>
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
                Console.WriteLine($"Entity not found in repository: {entity}");
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _entities;
        }

        public override string ToString()
        {
            return string.Join("\n", _entities);
        }
    }
}
