using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COmplex
{
    /// <summary>
    /// Класс комплексных чисел
    /// </summary>
    public class CNumber
    {
        public double re, im;

        /// <summary>
        /// Задание нового комплексного числа
        /// </summary>
        /// <param name="re">Действительная часть</param>
        /// <param name="im">Мнимая часть</param>
        public CNumber(double re, double im)
        {
            this.re = re;
            this.im = im;

        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public CNumber()
        {
            this.re = 0;
            this.im = 0;
        }

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="z">прибавляемое комплексное число</param>
        /// <returns>Возвращает результат сложения</returns>
        public CNumber Plus(CNumber z)
        {
            double x = this.re + z.re;
            double y = this.im + z.im;
            return new CNumber(x, y);
        }
        
        /// <summary>
        /// Вычитание комплексных чисел
        /// </summary>
        /// <param name="z">вычитаемое комплексное число</param>
        /// <returns>Возвращает результат вычитания</returns>
        public CNumber Minus(CNumber z)
        {
            double x = this.re - z.re;
            double y = this.im - z.im;
            return new CNumber(x, y);
        }

        /// <summary>
        /// Умножение комплексных чисел
        /// </summary>
        /// <param name="z">Умножаемое комплексное число</param>
        /// <returns>Возвращает результат умножения</returns>
        public CNumber Umn(CNumber z)
        {
            double x = this.re * z.re - this.im * z.im;
            double y = this.re * z.im + this.im * z.re;
            return new CNumber(x, y);
        }
        public CNumber Del(CNumber z)
        {
            double u = z.re * z.re + z.im * z.im;
            double x = (this.re * z.re + this.im * z.im)/u;
            double y = (this.re * z.im - this.im * z.re)/u;
            return new CNumber(x,y);
        }
        public double Modul
        {
            get { return(Math.Sqrt(this.im * this.im + this.re * this.re)); }
        }
        
        public static CNumber operator -(CNumber x, CNumber y)
        {
            return x.Minus(y);
        }

        public static CNumber operator + (CNumber x, CNumber y)
        {
            return x.Plus(y);
        }
        public static CNumber operator * (CNumber x, CNumber y)
        {
            return x.Umn(y);
        }

        public static CNumber operator / (CNumber x, CNumber y)
        {
            return x.Del(y);
        }

        public static CNumber operator ^ (CNumber x, byte n)
        {
            if (n == 0)
                return new CNumber(1, 0);
            CNumber y = x;
            for (int i = 1; i < n; i++)
                y = y * x;
            return y;
        }
    }
}
