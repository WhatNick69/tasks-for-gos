using System.Windows.Forms;

namespace DLLFamilyBank
{
    /// <summary>
    /// Выводит информацию клиентов о транзакциях
    /// </summary>
    public class Information
    {
        private static ListBox transactionList;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="transactionList"></param>
        public Information(ListBox transactionList)
        {
            Information.transactionList = transactionList;
           
        }

        /// <summary>
        /// Транзакция по выводу денежных средств
        /// </summary>
        /// <param name="succesfully"></param>
        /// <param name="client"></param>
        /// <param name="sumForTransaction"></param>
        public static void GetMoneyTransaction(bool succesfully,
            Client client,long sumForTransaction)
        { 
            if (transactionList.InvokeRequired)
            {
                transactionList.Invoke(new MethodInvoker(delegate
                {
                    if (succesfully) transactionList.Items.Add
                        (transactionList.Items.Count + ") " + client.NameClient
                        + " has get " + sumForTransaction + "$" + CheckBalanceInBank());
                    else transactionList.Items.Add
                        (transactionList.Items.Count + ") " + client.NameClient
                        + " has`t get " + sumForTransaction + "$ from bank." + CheckBalanceInBank());
                }));
            }
        }

        /// <summary>
        /// Транзакция по вводу денежных средств
        /// </summary>
        /// <param name="client"></param>
        /// <param name="sumForTransaction"></param>
        public static void PutMoneyTransaction(Client client, long sumForTransaction)
        {
            if (transactionList.InvokeRequired)
            {
                transactionList.Invoke(new MethodInvoker(delegate 
                {
                    transactionList.Items.Add
                        (transactionList.Items.Count + ") " + client.NameClient
                        + " has put " + sumForTransaction + "$ in bank." + CheckBalanceInBank());
                }));
            }
        }

        /// <summary>
        /// Проверить баланс на счете в банке
        /// </summary>
        /// <returns></returns>
        public static string CheckBalanceInBank()
        {
            return " Balance: " + Bank.Sum;
        }

        /// <summary>
        /// Инициализация счета в банке
        /// </summary>
        public static void StartAndEndBalanceInBank(bool flag)
        {
            if (flag) transactionList.Items.Add("Transactions has started. Balance: " + Bank.Sum);
            else
            {
                if (transactionList.InvokeRequired)
                {
                    transactionList.Invoke(new MethodInvoker(delegate
                    {
                        transactionList.Items.Add("Transactions has finished. Balance: " + Bank.Sum);
                    }));
                }
            }
        }
    }
}
