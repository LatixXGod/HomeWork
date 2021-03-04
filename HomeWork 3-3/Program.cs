using System;

namespace HomeWork_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string greet = "hello";
            char[] lol = greet.ToCharArray();

            int i;
            for (i = lol.Length; i > 0; i--)
            {
                Console.Write(lol[i - 1]);
                
            }
            Console.WriteLine();

        }
    }
}
