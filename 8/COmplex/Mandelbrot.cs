using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COmplex
{
    class Mandelbrot
    {
       
        int Radius = 2;
        int Count_Iterations = 200;

        /// <summary>
        /// конструктор класса для множества Мандельброта
        /// </summary>
        /// <param name="Count">Число итераций</param>
        public Mandelbrot(int Count)
        {
          Count_Iterations = Count;
        }

        /// <summary>
        /// Вычисляет скорость
        /// </summary>
        /// <param name="c">комплексное число</param>
        /// <returns>Возвращает скорость</returns>
        public byte Speed(CNumber c)
        {
            CNumber a = new CNumber(2, 0);
            CNumber z = new CNumber(0, 0);
            int result = 0;
            for (int i = 1; i < Count_Iterations; i++)
            {
                z = c + (z^2);
                if (z.Modul > Radius)
                {
                    result = i;
                    break;
                }
            }
            if (result == 0) return 0;
            if (result < 11) return 1;
            if (result < 21) return 2;
            if (result < 51) return 3;
            if (result < 101) return 4;
            if (result < 151) return 5;
            else return 6;
        }
        
    }
}
