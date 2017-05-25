
namespace Labs
{
    public class Calculate
    {
        public static int m;

        /// <summary>
        /// Поиск средних значений
        /// </summary>
        /// <param name="tn">Массив времен/работ</param>
        /// <returns>Возвращает среднее время на интервалах</returns>
        private static int[] SrZnachN(int[,] tn)
        {
            int[] SrN = new int[m];
            SrN[0] = 0;
            for (int i = 1; i < m; i++)
            {
                SrN[i] = tn[1, m - 1] * tn[0, i] / tn[0, m - 1]; //считаем среднее значение для каждого интервала
            }
            return SrN;
        }

        /// <summary>
        /// Создание массива времен/работ
        /// </summary>
        /// <param name="tn">Массив времен/работ</param>
        /// <returns>Возвращает массив, где заметно превышение/недобор до средних значений</returns>
        private static int[] CreateArray(int[,] tn)
        {
            int[] SrN = SrZnachN(tn);
            int[] FinalArray = new int[m];
            for (int i = 0; i < m; i++)
            {
                FinalArray[i] = tn[1, i] - SrN[i];
            }
            return FinalArray;
        }

        /// <summary>
        /// Метод позволяет найти интервал, где происходит максимальное превышение плана
        /// </summary>
        /// <param name="tn">Массив времен-работ</param>
        /// <returns>Возвращает строку, в которой написан максимальный интервал</returns>
        public static string FindMaxInterval(int[,] tn)
        {
            int sum = 0, max, ires, jres;
            int[] Notkl = CreateArray(tn);
            int start = 0;
            while (Notkl[start] < 0) start++;
            int finish = m - 1;
            while (Notkl[finish] < 0) finish--;
            ires = start; //начало интервала
            jres = finish; //конец интервала
            int icur = start; 
            max = 0;
            for (int i = start; i <= finish; i++) //поиск максимальной суммы
            {
                sum += Notkl[i];
                if (max <= sum)
                {
                    jres = i;
                    ires = icur;
                    max = sum;
                }
                if (sum < 0)
                {
                    sum = 0;
                    icur = i + 1;
                }
            }
            return "Интервал с максимальным превышением плана - от " + ires.ToString() + " до " + jres.ToString();
        }
    }
}
