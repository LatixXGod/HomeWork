using System;
using System.IO;
using System.Diagnostics;

namespace TaskManager
{
    class Program
    {

        static void Main(string[] args)
        {
            int i = 1;
            while( i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Вот ваши все процессы");
                    Process[] processes;
                    processes = Process.GetProcesses();
                    foreach (Process process in Process.GetProcesses())
                    Console.WriteLine($"ID: {process.Id}  Name: {process.ProcessName}");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Введите ID или Название процесса который хотите завершить");
                    KillProcessByNameID();
                    Console.WriteLine("Если хотите повторить попытку или продолжить то нажмите 1");
                    Console.WriteLine("Если же хотите завершить программу,то нажмите любую другую цифру и нажмите Enter");
                    i = Convert.ToInt32(Console.ReadLine());
                }      
        }
        static void KillProcessByNameID()
        {
             string index = Console.ReadLine();
            try
            {
                try
                {
                    Process proc = Process.GetProcessById(Int32.Parse(index));
                    proc.Kill();
                }
                catch (Exception p)
                {
                    Console.WriteLine("Данная программа не может быть закрыта,т.к введено некорректное число и т.п");
                }
            }
            catch(Exception e)
            {
                try
                {
                    Process[] processes = Process.GetProcessesByName(index);
                    foreach (Process process in processes)
                    {
                        process.Kill();
                    }
                } 
                catch(Exception x)
                {
                    Console.WriteLine("Данная программа не может быть закрыта");//Если Kill выдаст ошибку из-за недостатка прав доступа и т.п
                }                                            
            }
        }
        
    }
}
