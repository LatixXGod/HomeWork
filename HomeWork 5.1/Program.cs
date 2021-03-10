using System;
using System.IO;

namespace HomeWork_5_1
{
    public class Class1
    {
        static void Main(string[] args)
        {
            string filename = "Результат дз 5-1.txt";
            File.WriteAllText(path: filename, contents: "Типо произвольный ввод данных");
        }

    }
}
