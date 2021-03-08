using System;

namespace Homework_4_3
{
    class Program
    {

        public enum Months
        {
            Junuary = 1,
            Febuary,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December

        }
        static void Main(string[] args)
        {
            WhichM();                  
        }

        static int WhichM()
        {
            
            {
                Console.Write("Введите порядковый номер месяца - ");
                int C = Convert.ToInt32(Console.ReadLine());
                int C2 = Convert.ToInt32(C);
                if (C2 <= 12 && C2 >= 1)
                {
                    if (C2 >= 9 && C2 <= 11)
                    {
                        Console.WriteLine("Ваш месяц под вашей цифрой - " + (Months)C2 + "  || Ваш сезон года - Осень");
                    }  else if (C2 >= 6 && C2 <= 8)
                    {
                        Console.WriteLine("Ваш месяц под вашей цифрой - " + (Months)C2 + "  || Ваш сезон года - Лето");
                    } else if (C2 >= 3 && C2 <= 5)
                    {
                        Console.WriteLine("Ваш месяц под вашей цифрой - " + (Months)C2 + "  || Ваш сезон года - Весна");
                    } else if (C2 == 12 || C2 == 1 || C2 == 2)
                    {
                        Console.WriteLine("Ваш месяц под вашей цифрой - " + (Months)C2 + "  || Ваш сезон года - Зима");
                    }
                }
                else
                {
                    Console.Write("Вам нужно ввести цифровое значение от 1 до 12.");
                }
                return (C2);


            }
                      

            
        }

    }
}


//Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. На выходе — значение из перечисления (enum)
//— Winter, Spring, Summer
//Autumn. Написать метод, принимающий на вход значение из этого перечисления и возвращающий
//название времени года (зима, весна, лето, осень). Используя эти методы, ввести
//с клавиатуры номер месяца и вывести название времени года. Если введено 
//некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
//
//
