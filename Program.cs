using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork_2__1_1
{
    class Program
    {
        public class TestCase
        {

            public int d { get; set; }

            public int n { get; set; }

            public int Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }
        static void Testfunc(TestCase testCase)
        {
            try
            {
                var actual = Block(testCase.d);

                if (actual == testCase.Expected)
                {
                    Console.WriteLine("Валид");
                }
                else
                {
                    Console.WriteLine("Не валид");
                }
            }
            catch (Exception x)
            {
                if (testCase.ExpectedException != null)
                {                   
                    Console.WriteLine("Валид");
                }
                else
                {
                    Console.WriteLine("Не валид");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Введите n: ");
            var testCase1 = new TestCase()
            {
                n = 7,
                Expected = 0,
                ExpectedException = null
            };

            var testCase2 = new TestCase()
            {
                n = 5,
                Expected = 0,
                ExpectedException = null
            };

            Testfunc(testCase1);
            Testfunc(testCase2);

        }
        static int Block(int n)
        {
            
            
              
                int d = 0;
                int i = 2;
            // n = Convert.ToInt32(Console.ReadLine());
            while (i <= n)
                {
                    if (i < n)
                    {
                        if (n % i == 0)
                        {
                            d++;
                            i++;
                        }
                        else
                        {
                            i++;
                        }
                    }

                    else
                    {
                        if (d == 0)
                        {
                            Console.WriteLine("Простое ");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Не простое");
                            break;

                        }

                    }
            
                }
                          return n;



        }        




    }      

}
    

