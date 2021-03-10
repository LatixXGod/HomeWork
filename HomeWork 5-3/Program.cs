using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace HelloWorld
{
    class Program
    {                                                      
        static void Main()
        {
            Console.WriteLine("Введите любые цифры которые хотят занести в бинарный файл");
            string Numbers = Console.ReadLine();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("Number.bin", FileMode.OpenOrCreate), Numbers);
        }

      
    }
}

