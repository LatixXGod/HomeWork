using System;
using System.IO;
using System.Data;

namespace HomeWork_5_1
{
    public class Class1
    {
        static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;
            string filename = "startup.txt";          
            File.WriteAllText(path: filename, contents: "Актуальное время - " + localDate);
            File.AppendAllText(filename, Environment.NewLine);
            File.AppendAllLines(filename, new[] { "-------------------------------------" });
            File.AppendAllLines(filename, new[] { "Приятного времяпровождения"}); 

        }

    }
}
