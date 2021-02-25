using System;

namespace Homework_2_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите минимальную температуру за сегодня");
            string tempmin = Console.ReadLine();
            int x;
            try
            {
                x = Convert.ToInt32(tempmin);
            }
            catch (Exception e)
            {
                x = -999;
                Console.WriteLine("Нужно ввести числовое значение...мы тут не в игры играем");
            }
            {
                Console.WriteLine("Введите максимальную температуру за сегодня");
            }
            string tempmax = Console.ReadLine();
            int y;
            try
            {
                y = Convert.ToInt32(tempmax);
            }
            catch (Exception e)
            {
                y = 999;
                Console.WriteLine("Введите только числовое значение");
            }
            if (x > y)
            {
                Console.WriteLine("Каким образом температура минимальная больше чем максимальная за один день?");             
            }
            else
            {
               
                    Console.WriteLine("Средняя температура за день " + (x + y) / 2);
                
            }
            
            
                 
            
          


              
           









        }
    }
}
