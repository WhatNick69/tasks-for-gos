using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BernForm
{
    class Row
    {
        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();
            ClassBernulli func = new ClassBernulli();
            int n = 0;
            Console.WriteLine("Введите кол-во рассчитываемых четных чисел Бернулли");
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
            if (n < 1)
            {
                Console.WriteLine("Введите число больше единицы!");
                Console.ReadKey(); //чтоб прочитали
                return;
            }
            time.Stop();
            time.Restart();
            Console.WriteLine("Числа Бернулли:");
            for (int i = 0; i < n; i++)
            {
                if (i != 0)
                Console.WriteLine("n{"+i+"}= "+func.BernulliRow(i));
            }
            time.Stop();
            Console.WriteLine("\r\n Затраченное время - " + time.Elapsed.ToString());
            Console.ReadKey();
        }
    }
}
