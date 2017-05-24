using DLLFamilyBank;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace FamilyBank
{
    public partial class Form1 
        : Form
    {
        private Bank bank;
        private Information information;
        private List<Thread> clientPool;

        /// <summary>
        /// Инициализация
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.information = new Information(transactionsList);
            this.bank = new Bank(Convert.ToInt32(threadCount.Text));
        }

        /// <summary>
        /// Безопасная работа со счетом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void safetyStart_Click(object sender, EventArgs e)
        {
            transactionsList.Items.Clear();
            Information.StartAndEndBalanceInBank(true);
            Bank.ResetBalance();
            Bank.SafetyBool = true;
            StartClientWork();
        }

        /// <summary>
        /// Запуск клиентов
        /// </summary>
        private void StartClientWork()
        {
            clientPool = new List<Thread>();
            for (int i = 0; i < Convert.ToInt32(threadCount.Text); i++)
            {
                clientPool.Add(new Thread(new Client(i).Activity));
                clientPool[i].Start();
            }
            WaiterAllClients();
        }

        /// <summary>
        /// Ждет завершения всех клиентов и выводит баланс банка
        /// </summary>
        private void WaiterAllClients()
        {
            new Thread(delegate ()
            {
                foreach (Thread client in clientPool)
                    client.Join();
                Information.StartAndEndBalanceInBank(false);
            }).Start();
        }

        /// <summary>
        /// Небезопасная работа со счетом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unsafetyStart_Click(object sender, EventArgs e)
        {
            transactionsList.Items.Clear();
            Information.StartAndEndBalanceInBank(true);
            Bank.ResetBalance();
            Bank.SafetyBool = false;
            StartClientWork();
        }

        /// <summary>
        /// Обновить лист с транзакциями
        /// </summary>
        /// <param name="transaction"></param>
        public void RefreshTransactionsList(string transaction)
        {
            transactionsList.Items.Add(transaction.ToString());
        }
    }
}
