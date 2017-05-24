
namespace Merge
{
    public class ClassMerge
    {
        private int T;
        private int K;

        /// <summary>
        /// Инициализация элементов
        /// </summary>
        public ClassMerge()
        {
            T = 0;
            K = 0;
        }

        /// <summary>
        ///Добавление информации об элементе 
        /// </summary>
        /// <param name="T">инф. поле</param>
        /// <param name="K">ключ. поле</param>
        public ClassMerge(int T, int K)
        {
            this.K = K;
            this.T = T;
        }
        /// <summary>
        /// Добавление элемента
        /// </summary>
        /// <param name="T">инф. поле</param>
        /// <param name="K">ключ. поле</param>
        /// <returns>Возвращает новый элемент</returns>
        public ClassMerge AddElement( int T, int K)
        {
           ClassMerge Element = new ClassMerge(T, K);
           return Element;
        }

        /// <summary>
        /// Отображение всех элементов массива
        /// </summary>
        /// <param name="Array"></param>
        /// <returns></returns>
        public string Display(ClassMerge[] Array)
        {
            string result = "";
            int i = Array.Length;
            for (int j = 0; j < i; j++)
            {
                result += Array[j].K + ", " + Array[j].T + "\r\n";
            }
            return result;
        }

        /// <summary>
        /// Метод всеобщей сортировки слиянием. Постепенно происходит слияние массива из нескольких упорядоченных подмассивов
        /// </summary>
        /// <param name="Array">Массив всех элементов</param>
        /// <param name="start">Массив, обозначающий разделение подпоследовательностей</param>
        /// <returns>Возвращает отсортированный массив</returns>
        public ClassMerge[] BigMerge(ClassMerge[] Array, int[] start)
        {
            int ArrNum = start.Length;
            int Numbers = Array.Length;
            int[] end = new int[ArrNum]; //массив будущих концов интервалов - изначально равен массиву стартовых разделителей
            for (int o = 0; o < ArrNum; o++)
            {
                end[o] = start[o];
            }
            ClassMerge[] Temp = new ClassMerge[Numbers]; //новый массив, куда будут помещаться отсортированные элементы
            int Zapoln = 0;
            while (Zapoln != Numbers) //пока новый массив не заполнится
            {
                int[] sravn = new int[ArrNum]; //массив для сравнения элементов подмассивов
                int k=0;
                for (k = 0; k < ArrNum-1; k++)
                {
                    if (end[k] < start[k + 1])
                    {
                        sravn[k] = Array[end[k]].K; //добавляем в массив для сравнений элемент, если данный интервал себя не исчерпал
                    }
                }
                if (end[ArrNum - 1] < Array.Length)
                {
                    sravn[ArrNum-1] = Array[end[end.Length-1]].K; //последний элемент проверяем отдельно
                }
                int small = WhoisSmallest(sravn); //ищем номер подмассива, где элемент минимален
                Temp[Zapoln] = Array[end[small]]; //добавляем новый элемент
                end[small]++; //конец подинтервала продвигается
                Zapoln++;
            }
            return Temp;
        }

        /// <summary>
        /// Метод позволяет определить минимальный элемент для слияния
        /// </summary>
        /// <param name="arr">Массив элементов из подмассивов</param>
        /// <returns>Возвращает номер минимального элемента</returns>
        public int WhoisSmallest(int[] arr)
        {
            int res = 0;
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++) //поиск мин. элемента
            {
                if (arr[i] != 0)
                {
                    if (min != 0)
                    {
                        if (arr[i] < min)
                        {
                            min = arr[i];
                            res = i;
                        }
                    }
                    else
                    {
                       min = arr[i];
                       res = i;
                    }
                }
            }
            return res;
        }
    }
}
