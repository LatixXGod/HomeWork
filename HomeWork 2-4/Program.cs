using System;

namespace HomeWork_2_4
{
    class Program
    {
        static void Main(string[] args)

        {
            Random rnd = new Random();           
            int value2 = rnd.Next(000000, 9999999);
            int value3 = rnd.Next(00000, 99999);
            int Oper = rnd.Next(1, 5);// т.к допустим всего 5 касс и оператор это номер той кассы которая выдала чек

            Console.WriteLine("  |---------------------------|");
            Console.WriteLine("  |       ИП СОБОЛЕВ А.А      |");
            Console.WriteLine("  |***************************|");
            Console.WriteLine("  |       УПН 3921382184      |");
            Console.WriteLine("  |       РН  0000021388      |");
            Console.WriteLine("  |Оператор " + Oper +"                 |");
            Console.WriteLine("  |       Плетежный документ  |");
            Console.WriteLine("  |       Чек продажи         |");
            Console.WriteLine("  |Тов_1            19,95 А   |");
            Console.WriteLine("  |A = 20,00%           3.33  |");
            Console.WriteLine("  |Cумма налогов        3.33  |");
            Console.WriteLine("  |Итог                19.95  |");
            Console.WriteLine("  |Наличными           19.95  |");
            Console.WriteLine("  |" + value2 + "         Номер чека |");
            Console.WriteLine("  |" + value3 + "     Номер посетителя |");
            Console.WriteLine($"  |[{DateTime.Now}]      |");
            Console.WriteLine("  |***************************|");
            Console.WriteLine("  |---------------------------|");
        }
    }
}
