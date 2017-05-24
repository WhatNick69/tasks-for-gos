using System;
using System.Threading;

namespace DLLFamilyBank
{
    /// <summary>
    /// Описывает поведение клиента
    /// </summary>
    public class Client
    {
        private int idThread;
        private string nameClient;
        private Random rnd;
        private int countOfTransactions;
        private int getSleepTime;
        private int putSleepTime;
        private long sumForTransaction;

        /// <summary>
        /// Геттер для имени клиента
        /// </summary>
        public string NameClient
        {
            get
            {
                return nameClient;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="_idThread"></param>
        public Client(int idThread)
        {
            rnd = new Random();
            this.idThread = idThread;
            nameClient = "Client" + idThread;
            countOfTransactions = rnd.Next(3, 11);
            getSleepTime = rnd.Next(50, 300);
            putSleepTime = rnd.Next(50, 300);
        }

        /// <summary>
        /// Имитирует активность клиента с банковским счетом
        /// </summary>
        public void Activity()
        {
            while (countOfTransactions > 0)
            {
                if (RandomEvent()) GetMoneyFromBank();
                else PutMoneyInBank();
                countOfTransactions--;
            }
        }

        /// <summary>
        /// Взять деньги со счета банка
        /// </summary>
        public void GetMoneyFromBank()
        {
            sumForTransaction = rnd.Next(10, 1000);

            Bank.GetMoney(sumForTransaction, this);
            Thread.Sleep(getSleepTime);
        }

        /// <summary>
        /// Положить деньги в банк
        /// </summary>
        public void PutMoneyInBank()
        {
            sumForTransaction = rnd.Next(10, 1000);

            Bank.PutMoney(sumForTransaction,this);
            Thread.Sleep(putSleepTime);
        }

        /// <summary>
        /// Случайным образом клиент либо берет деньги с банка, либо кладет их
        /// </summary>
        /// <returns></returns>
        private bool RandomEvent()
        {
            return rnd.Next(0, 2) == 0 ? false : true;
        }
    }
}
