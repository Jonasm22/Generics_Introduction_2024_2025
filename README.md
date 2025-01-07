📜 **Using Generics eni C#**  

**ENGLISH**  
Generics enable creating classes, methods, and structures that work with any data type without duplicating code. They provide flexibility, type safety, and better performance.  

**DEUTSCH**  
Mit Generics können Klassen, Methoden und Strukturen erstellt werden, die mit jedem Datentyp arbeiten, ohne Code zu duplizieren. Sie bieten Flexibilität, Typsicherheit und bessere Leistung.  

**ESPANOL**
Generics permiten crear clases, métodos y estructuras que funcionan con cualquier tipo de dato sin duplicar código. Ofrecen flexibilidad, seguridad de tipo y mejor rendimiento.  

---

📚 **Example**


public class GenericList<T>
{
    private List<T> items = new List<T>();

    public void Add(T item) => items.Add(item);

    public T Get(int index) => items[index];

    public int Count => items.Count;
}

class Program
{
    static void Main()
    {
        
        var intList = new GenericList<int>();
        intList.Add(10);
        intList.Add(20);
        Console.WriteLine($"Int at index 0: {intList.Get(0)}"); // Output: 10
        
       
        var stringList = new GenericList<string>();
        stringList.Add("Hello");
        stringList.Add("World");
        Console.WriteLine($"String at index 1: {stringList.Get(1)}"); // Output: World
    }
}


**Key Benefits / Beneficios / Vorteile**  
- 🔒 **Type Safety:** Prevents runtime errors by checking types at compile time.  
- 📦 **Reusability:** Reduces code duplication.  
- ⚡ **Performance:** Avoids boxing/unboxing for value types.  
