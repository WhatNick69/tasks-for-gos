namespace DLLFamilyBank
{
    /// <summary>
    /// Описывает банк
    /// </summary>
    public class Bank
    {
        private static long sum;
        private static object lock_object;
        private static bool safetyBool;
        private static int countOfClients;

        /// <summary>
        /// Геттер и сеттер для безопасного баланса
        /// </summary>
        public static bool SafetyBool
        {
            get
            {
                return safetyBool;
            }

            set
            {
                safetyBool = value;
            }
        }

        /// <summary>
        /// Геттер для баланса
        /// </summary>
        public static long Sum
        {
            get
            {
                return sum;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="countOfClients"></param>
        /// <param name="safetyBool"></param>
        public Bank(int countOfClients, bool safetyBool=false)
        {
            Bank.countOfClients = countOfClients;
            Bank.safetyBool = safetyBool;
            ResetBalance();
            lock_object = new object();
        }

        /// <summary>
        /// Сбрасывает баланс
        /// </summary>
        public static void ResetBalance()
        {
            sum = 3000;
        }

        /// <summary>
        /// Клиент снимает деньги со счета
        /// </summary>
        /// <param name="sumGet"></param>
        /// <returns></returns>
        public static void GetMoney(long sumGet,Client client)
        {
            if (safetyBool)
            {
                lock (lock_object)
                {
                    if (sum - sumGet > 0)
                    {
                        sum -= sumGet;
                        Information.GetMoneyTransaction(true, client, sumGet);
                    }
                    else Information.GetMoneyTransaction(false, client, sumGet);
                }
            }
            else
            {
                if (sum - sumGet > 0)
                {
                    sum -= sumGet;
                    Information.GetMoneyTransaction(true, client, sumGet);
                }
                else Information.GetMoneyTransaction(false, client, sumGet);
            }
        }

        /// <summary>
        /// Клиент кладет деньги на счет
        /// </summary>
        /// <param name="sumPut"></param>
        public static void PutMoney(long sumPut,Client client)
        {
            if (safetyBool)
                lock (lock_object)
                {
                    sum += sumPut;
                    Information.PutMoneyTransaction(client, sumPut);
                }
            else
            {
                sum += sumPut;
                Information.PutMoneyTransaction(client, sumPut);
            }
        }
    }
}
