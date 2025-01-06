//Section 21 - 342
//Generic  reflections

using System.Reflection;
namespace MyApp_part10;


class Program
{
    static void Main(string[] args)
    {
        Type type = typeof(ConfigurationManager<>);
    }




    internal class ConfigurationManager<T>
    {
        public T LoadedConfig { get; private set; }

        public ConfigurationManager(T config)
        {
            LoadedConfig = config;
        }


        public static void SaveConfig(T ConfigToSave)
        {
            //Logic
        }
        
        
    }
}

