using System;

namespace Homework_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число чтобы узнать четное ли оно");
            string i = Console.ReadLine();
            try
            {
                int i2 = Convert.ToInt32(i);
                if (i2 % 2 == 0)
                {
                    Console.WriteLine("Ваше число кратно двум, ваше число было - " + i2);
                }
                else
                {
                    Console.WriteLine("Ваше число не кратно двум" );
                }









                
            }
            catch (Exception e)
            {
                Console.WriteLine("Введите числовое значение");
            }




        }







    }






}
    
    

       