using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamWorker
{
    [Flags]
    public enum Dream_Properties { Знает_CSharp = 1, Знает_CPP = 2, Знает_ASPNET = 4, Знает_1С = 8, Знает_Бухучёт = 16, Не_курит = 32 };
    public class Person
    {
        Dream_Properties properties;
        public Dream_Properties Properties
        {
            get { return (properties); }
            set { properties = value; }
        }

        //Должен знать 1С, бухучёт и не курить
        Dream_Properties pattern1c = Dream_Properties.Знает_1С |
                Dream_Properties.Знает_Бухучёт| Dream_Properties.Не_курит;
        //Должен знать C#, C++. ASP.NET и не курить
        Dream_Properties patterncprog = Dream_Properties.Знает_CSharp |
                Dream_Properties.Знает_CPP | Dream_Properties.Знает_ASPNET | Dream_Properties.Не_курит;

        public string priem1c()
        {
            string res = "";
            Dream_Properties temp = properties & pattern1c;
            bool query1, query2;
            query1 = temp == pattern1c;
            query2 = temp > 0 && temp < pattern1c;
            res = " Результаты запросов:\r\n";
            res +=" (все свойства) = " + query1.ToString() + "\r\n";
            res += " (часть свойств) = " + query2.ToString() + "\r\n";
            if (query1)
                res += "Можем принять на работу!";
            else
            {
                if (query2)
                    res += "Вы не совсем подходите нам!";
                else
                    res += "Вы совершенно не подходите нам!";
            }
            return res;
        }

        public string priemCprog()
        {
            string res = "";
            Dream_Properties temp = properties & patterncprog;
            bool query1, query2;
            query1 = temp == patterncprog;
            query2 = temp > 0 && temp < patterncprog;
            res = " Результаты запросов:\r\n";
            res += " (все свойства) = " + query1.ToString() + "\r\n";
            res += " (часть свойств) = " + query2.ToString() + "\r\n";
            if (query1)
                res += "Можем принять на работу!";
            else
            {
                if (query2)
                    res += "Вы не совсем подходите нам!";
                else
                    res += "Вы совершенно не подходите нам!";
            }
            return res;
        }
    }
}
