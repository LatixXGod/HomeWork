using System;

namespace HomeWork_4__1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Добрый день !");
            Console.WriteLine("Введите кол-во ФИО");
            int k = 1;
            while (k == 1)            
            {
                try
                {
                    int C = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < C; i++)

                    {
                        Console.WriteLine("Номер участника: - " + (i + 1) + " - Фио участника: - " + GetFullName());
                    }
                    k = 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Пожалуйста введите цифровое значение!");
                    Console.WriteLine("Попробуйте ещё раз,не повторяйте ошибок");
                    Console.WriteLine();


                }
            }
          

        }   
                

        static (string firstName, string lastName, string patronymic) GetFullName()
        {
            Console.WriteLine("Введите Имя:");
            Console.WriteLine();
            string firstName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Введите Фамилию:");
            Console.WriteLine();
            string lastName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Введите Отчество:");
            Console.WriteLine();
            string patronymic = Console.ReadLine();
            Console.WriteLine();
            return (firstName, lastName, patronymic);
        }
        
    }
}


//Написать метод GetFullName(string firstName, string lastName, string patronymic)
//принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку
//с ФИО. Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
