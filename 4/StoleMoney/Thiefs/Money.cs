using System;

namespace Thiefs
{
    public class Bank
    {
        int ThiefsMnoz = 10;
        /// <summary>
        /// Подсчёт количества комбинаций с одинаковой суммой цифр, используя перебор
        /// </summary>
        /// <param name="n">Кол-во цифр в куске пароля</param>
        public void Perebor(int n)
        {
            int i, j;
            int isum = 0; //переменная для суммы чисел
            long max = (long)Math.Pow(10, n) - 1; //предел вычислений, 10^n -1, будет 9,99,999...
            long sum = 0; //кол-во комбинаций
            for (i = 0; i <= max / 2; i++) //смотрим половину, вторая - зеркальна
            { 
                isum = Isum(i);
                for (j = 0; j <= max; j++)
                {
                    if (isum == Isum(j)) sum++;
                }
            }
            //Console.WriteLine("Воры будут перебирать комбинации пароля длиной " + 2*n + " символа(-ов) " + (sum * 2)/ThiefsMnoz + " минут.\r\n Число комбинаций - " + 2*sum);
        }
        /// <summary>
        /// Вычисляет сумму цифр в числе
        /// </summary>
        /// <param name="Number">число</param>
        /// <returns>сумма цифр</returns>
        private int Isum(int Number)
        {
            int sum = 0;
            while (Number > 0) //пока от числа ничего не останется
            {
                sum += Number % 10;
                Number = Number / 10;
            }
            return sum;
        }


        /// <summary>
        /// Подсчёт количества количества комбинаций с одинаковой суммой чисел, используя рекурсию
        /// </summary>
        /// <param name="n">Кол-во цифр в куске пароля</param>
        public void RecFind(int n)
        {
            int i; 
            long sum = 0, icnt;
            for (i = 0; i <= 9 * n; i++)
            {
                icnt = NumCount(n, i); //кол-во комбинаций
                sum += icnt * icnt; //кол-во комбинаций перемножается, для учета комбинаций с "двух сторон" по типу если есть
                                    //10 и 01, то будет 4 комбинации во всем пароле
            }
            //Прикрутить текст, я думаю, не проблема.
            //Console.WriteLine("Воры будут перебирать комбинации пароля длиной " + 2*n + " " + sum/ThiefsMnoz + " минут.\r\n Число комбинаций - " + sum);
        }


        /// <summary>
        /// Находит количество комбинаций из куска пароля, в которых сумма цифр равна заданной
        /// </summary>
        /// <param name="n">Кол-во цифр в куске пароля</param>
        /// <param name="k">Заданная сумма</param>
        /// <returns>Количество номеров</returns>
        private long NumCount(int n, int k)
        {
            long sum = 0; //кол-во комбинаций
            if (n == 1)   //когда цифра одна
                if (k <= 9)   //если сумма меньше 9
                    return 1; //комбинация только 1 для 1 цифры
                else         
                    return 0; //иначе их вообще нет

            for (int l = 0; l <= 9; l++)
            {
                if (l > k) return sum; //когда цифра больше остатка суммы
                sum += NumCount(n - 1, k - l); //отбрасываем 1 цифру, вычитаем из суммы
            }
            return sum;
        }
    }
}
