using System;
using Thiefs;
using System.Diagnostics;

namespace ConsoleApplicationCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            //на вход подается длина одной части пароля
            Bank func = new Bank();
            Stopwatch time = new Stopwatch();
           // time.Restart();
           // func.Perebor(3); //переборный алгоритм
           // time.Stop();
           // Console.WriteLine(time.Elapsed + "\r\n");
            time.Restart();
            func.RecFind(2); //рекурсивный алгоритм
            time.Stop();
            Console.WriteLine(time.Elapsed);
            Console.ReadKey();
        }
    }
}
