using System;

namespace HomeWork_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int h = 0;
            int otstup = 0;
            int[,] array = new int[5, 5];
            Console.WriteLine("Заполняем массив");
            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = h++;
                    Console.Write($"{ array[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Выводим диагональ массива при этом заполняем остальные эллементы массивая нулями " );


            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                     if(i == j)
                    {
                        Console.Write($"{ array[i, j]} ");
                    } else
                    {
                        array[i, j] = 0;
                        Console.Write($"{ array[i, j]} ");
                    }
              
                }
                Console.WriteLine();
            }   

        }
            




    }










}

    
    
     





        
          
            










        
    

