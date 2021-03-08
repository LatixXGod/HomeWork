using System;

namespace HomeWork_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числовое значение через пробел:");
            string lul = Console.ReadLine();
            Console.WriteLine(juj(lul));
        }       
        static int juj(string lul)
        {           
            string temp = "";
            int sum = 0;
            for (int i = 0; i < lul.Length; i++)
            {
                char Ver = lul[i];
                if (char.IsDigit(Ver))
                {
                    temp += Ver;
                }
                else
                {
                    sum += int.Parse(temp);
                    temp = "0";
                }
               
            }
            Console.WriteLine("Ваша сумма чисeл:");
            return sum + int.Parse(temp);
            

        } 
        
    }
}





//Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом
//возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести результат на экран.