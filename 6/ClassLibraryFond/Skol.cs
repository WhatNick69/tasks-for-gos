using System;

namespace ClassLibraryFond
{
    public class Skol
    {
        /// <summary>
        /// Метод создать строку с информацией о проектах
        /// </summary>
        /// <param name="dannye">Входная строка с данными о проектах</param>
        /// <returns>Возрвращает информацию о проектах, которые укладываются в стоимость</returns>
        public string BestProjects(string dannye)
        {
            string resylt = "";
            string[] Arr = dannye.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            int Money = int.Parse(Arr[0]); //кол-во денег
            int Gran = int.Parse(Arr[1]); //граница отбираемых проектов
            int Projects = int.Parse(Arr[2]); //всего проектов
            int[] IDs = new int[(Arr.Length - 3) / 3];
            int[] Moneys = new int[(Arr.Length - 3) / 3];
            //string[] Decriptions = new string[(Arr.Length - 3) / 3]; - описания выводить не надо
            for (int i = 0; i < (Arr.Length-3)/3; i++)
            {
                Moneys[i] = int.Parse(Arr[3*i+3]);
                IDs[i] = int.Parse(Arr[3*i + 4]);
                //Decriptions[i] = Arr[3*i + 5]; - описания не нужны
            }
            Bubble(IDs, Moneys); //сортировка проектов по возрастанию стоимости
            int sum = 0;
            int numb = Numbers(Moneys, Money, ref sum,  Gran);
            if (numb > Gran)
                numb = Gran;
            resylt += numb + "\r\n" + sum + "\r\n";
            for (int i = 0; i < numb; i++)
            {
                resylt += IDs[i] + "\r\n";
            }
            return resylt;
        }

        /// <summary>
        /// Сортировка пузырьком по возрастанию стоимости проекта
        /// </summary>
        /// <param name="IDs">ID проектов</param>
        /// <param name="Money">Стоимость проектов</param>
        private void Bubble(int[] IDs, int[] Money)
        {
            int n = Money.Length, obm;
            //string obmen; строки нас не интересуют, но  если надо и их выводить, то можно еще посортировать
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > 0; j--)
                {
                    if (Money[j] < Money[j - 1]) //обмен элементов массивов
                    {
                        obm = Money[j];
                        Money[j] = Money[j - 1];
                        Money[j - 1] = obm;
                        obm = IDs[j];
                        IDs[j] = IDs[j - 1];
                        IDs[j - 1] = obm;
                        /*obmen = Descr[j]; //описания не нужны
                        Descr[j] = Descr[j - 1];
                        Descr[j - 1] = obmen; */
                    }
                }
            }
        }

        /// <summary>
        /// Расчет максимального кол-ва проектов
        /// </summary>
        /// <param name="Money">Стоимости проектов</param>
        /// <param name="Predel">Предел стоимостей</param>
        /// <param name="sum">Конечная сумма стоимости проектов</param>
        /// <returns>Возвращат число проектов, проходящих по сумме</returns>
        private int Numbers(int[] Money, int Predel, ref int sum, int Gran)
        {
            int Number = 0;
            sum = 0;
            while (sum < Predel && Gran != Number)
            {
                sum += Money[Number];
                Number++;
            }
            return Number;
        }



        /// <summary>
        /// Метод позволяет более эффективно отобрать проекты для фонда
        /// </summary>
        /// <param name="dannye">Строка с данными</param>
        /// <returns>Возвращает информацию о проектах, которые укладываются в стоимость</returns>
        public string ProjectsBest(string dannye)
        {
            string result = "";
            string[] Arr = dannye.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            int Money = int.Parse(Arr[0]); //число денег
            int Gran = int.Parse(Arr[1]); //кол-во отбираемых проектов
            int Projects = int.Parse(Arr[2]); //всего проектов
            int[] ArrMoney = new int[Gran];
            int[] ArrIDs = new int[Gran];
            result += Gran + "\r\n";
            for (int j = 0; j < Gran; j++)
            {
                ArrMoney[j] = int.Parse(Arr[3+j*3]); 
                ArrIDs[j] = int.Parse(Arr[4+j*3]);
            }
            Bubble(ArrIDs, ArrMoney); //сортировка первых проектов, число которых равно заданной границе числа проектов (Gran)

            for (int i = Gran+1; i < Arr.Length / 3; i++)
            {
                int NewMoney = int.Parse(Arr[3*i]);
                int NewID = int.Parse(Arr[3*i+1]);
                if (ArrMoney[Gran-1] > NewMoney)
                {
                    ArrMoney[Gran-1] = NewMoney;
                    ArrIDs[Gran-1] = NewID;
                    Bubble(ArrIDs, ArrMoney); //после добавления нового элемента производим сортировку
                }
            }
            int sum = 0;
            for (int i = 0; i < Gran; i++)
                sum += ArrMoney[i];
            result += sum + "\r\n";
            for (int k = 0; k < Gran; k++)
            {
                result += ArrIDs[k]+ "\r\n";
            }
            return result;
        }
        
    }
}
