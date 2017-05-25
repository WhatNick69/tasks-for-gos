using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThreadedInterface
{
    class Worker
    {
        MainForm correctForm;
        bool stop = false;
        bool change = false;
        int minLimit = 0, maxLimit = 10;
        string val = "";
        string quality = "";
        int numer = 0;
        Random rnd = new Random();
        public Worker(MainForm form)
        {
            correctForm = form;
        }
        public bool Stop
        {
            set { stop = value; }
        }
        public bool IsChanged
        {
            set { change = value; }
        }
        public int Number
        {
            set { numer = value; }
        }
        public string Value
        {
            get { return val; }
        }
        public string Quality
        {
            get { return quality; }
        }

        /// <summary>
        /// Основной метод, реализующий логику проекта
        /// В цикле моделируется значений наблюдаемого параметра,
        /// передаваемого в список, отображаемый в интерфейсе проекта
        /// Завершение цикла вычислений зависит от пользователя
        /// и происходит при нажатии кнопки "Стоп"
        /// </summary>
        public void Run()
        {
            /*string res = "";
            int i = 1;
            while (!stop)
            {
                Thread.Sleep(5);
                //Вычисление наблюдаемого параметра
                res = i.ToString() + "." + rnd.Next(100).ToString();
                i++;
                //Наблюдаемый параметр передается основному потоку
                correctForm.Invoke(correctForm.myDelegate, new object[] { res });
            }*/
            GetControlParams();
            while (!stop)
            {
                Thread.Sleep(155);
                if (change)
                {
                    GetControlParams();
                    change = false;
                }
                SetVisionParams();
            }
        }

        void GetControlParams()
        {
            correctForm.Invoke(new MethodInvoker(correctForm.GetLimits));
            minLimit = correctForm.lowLimit;
            maxLimit = correctForm.highLimit;
        }

        public void SetVisionParams()
        {
            int vali = rnd.Next(minLimit, maxLimit + 1);
            if (vali == minLimit)
                quality = "Ниже нормы";
            else if (vali == maxLimit)
                quality = "Выше нормы";
            else
                quality = "Норма";
            numer++;
            val = numer + "." + vali;
            quality = numer + "." + quality;
            correctForm.Invoke(new MethodInvoker(correctForm.SetVisions));
        }
    }
}
