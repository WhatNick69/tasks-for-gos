using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BernForm
{
    public class ClassBernulli
    {
        const double PI = Math.PI;

        // <summary>
        /// Нахождение числа Бернулли с заданным номером
        /// </summary>
        /// <param name="n">Номер числа Бернулли</param>
        /// <returns>Возвращает число Бернулли с заданным номером</returns>
        public double BernulliR(int n)
        {
            if (n == 0) return 1;
            else if (n % 2 == 1 & n > 3) //нечетные элементы - нули
            {
                return 0;
            }
            else
            {
                double Bn = 0;
                double c = (-1) / (double)(n + 1);  //число перед суммой
                Bn = c * Sum(n);
                return Bn;
            }
        }
        /// <summary>
        /// Вычисление суммы, входящей в состав рекурентной формулы чисел Бернулли
        /// </summary>
        /// <param name="n">Номер числа Бернулли</param>
        /// <returns>Возвращает значение искомой суммы</returns>
        private double Sum(int n)
        {
            double sum = 0;
            for (int k = 1; k <= n; k++)
            {
                sum += Combinations(n + 1, k + 1) * BernulliR(n - k); //число сочетаний на число Бернулли-k
            }
            return sum;
        }

        /// <summary>
        /// Число сочетаний..
        /// </summary>
        /// <param name="n">Из n</param>
        /// <param name="k">По k</param>
        /// <returns>Возвращает число сочетаний из n по k</returns>
        public int Combinations(int n, int k)
        {
            int res = 0, c1, c2;
            if (k == 0 || k == n)
                return 1;
            else
            {
                c1 = Combinations(n - 1, k - 1); //число сочетаний по формуле, реккурентно раскладывающейся
                c2 = Combinations(n - 1, k);
                return res = c1 + c2;
            }
        }
        //__________________________
        
        /// <summary>
        /// Метод позволяет посчитать значения модулей четных чисел Бернулли
        /// </summary>
        /// <param name="n">Номер числа</param>
        /// <returns>Возвращает модуль четного числа Бернулли</returns>
        public double BernulliRow(int n)
        {
            
            double Bnumber = 0;
                int m = 2*n;
                double Fact = Factorial(m);
                double p = Math.Pow(PI, m);
                double q = Math.Pow(2, m - 1);
                Bnumber = Fact/(p*q); //часть без суммы
                Bnumber *= Row(m);
            return Bnumber;
        }

        /// <summary>
        /// Метод позволяет посчитать факториал указанного числа
        /// </summary>
        /// <param name="m">Заданное число</param>
        /// <returns>Возвращает факториал указанного числа</returns>
        private double Factorial(int m)
        {
            if (m < 2)
            { return 1; }
            else
            { return m * Factorial(m - 1); } // при n = 4 следующее - 4! = 4*3! = 4*3*2! = 4*3*2*1! = 4*3*2*1
        }

        /// <summary>
        /// Позволяет посчитать сумму ряда в формуле
        /// </summary>
        /// <param name="m">Номер числа Бернулли</param>
        /// <returns>Возвращает сумму ряда</returns>
        private double Row(int m)
        {
            double Row = 0;
            int Select = 10; //10 проходов хватит для очень малых чисел
            
            for (int i = 0; i < Select-1; i++)
            {
                Row += 1 / Math.Pow(i+1, m);
            }
            return Row;
        }
    }
}
