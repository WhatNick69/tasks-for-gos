using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using ClassLibraryBernulliNumbers;

namespace ConsoleApplicationBernulliEnter
{
    class RecEnter
    {
        
        static void Main(string[] args)
        {
            ClassBernulli func = new ClassBernulli();
            Stopwatch time = new Stopwatch();
            int n = 0;
            Console.WriteLine("Введите n");
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введите нормальное число!");
                Console.ReadKey(); //чтоб прочитали
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("Введите число больше нуля!");
                Console.ReadKey(); //чтоб прочитали
                return;
            }
            time.Stop();
            time.Restart();
            Console.WriteLine("Числа Бернулли:");
            for (int i = 0; i <= n; i++)
            {

                Console.WriteLine("n{" + i + "}= " + func.BernulliR(i));
            }
            time.Stop();
            Console.WriteLine("\r\n Затраченное время - " + time.Elapsed.ToString());
            Console.ReadKey();
        }
    }
}
