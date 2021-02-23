using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Привет,давай познакомимся? Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}. Cегодня [{DateTime.Now}]");





        }
    }

}
