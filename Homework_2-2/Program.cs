using System;

namespace Homework_2_2
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
            Console.WriteLine("Введите число месяца который вы хотите узнать");
            Console.WriteLine("Число месяца должно быть от 1 до 12.");
            string i = Console.ReadLine();
            try
            {
                int i2 = Convert.ToInt32(i);
                if (i2 >= 1 && i2 <= 12)
                {
                    Console.WriteLine("Месяц под данным номером который вы указали - " + (Months)i2);
                }
                else
                {
                    Console.WriteLine("Повторите попытку (Но уже в новом окне Хехе)");
                   

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Введите числовое значение!");
            }

            

            

                                      
                
            
         
            

        }






    }
}
