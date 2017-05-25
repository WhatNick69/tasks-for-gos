using System;
using System.Data;
using System.Text.RegularExpressions;

namespace DLLInterAndSol
{
    /// <summary>
    /// Находит значение функции.
    /// Парсит функцию
    /// </summary>
    class Interpretator
    {
        /// <summary>
        /// Заместо X подставить значение в формулу
        /// </summary>
        /// <param name="x"></param>
        /// <param name="formula"></param>
        /// <returns></returns>
        public static string FuncValue(float x, string formula)
        {
            formula = formula.Replace("x",x.ToString());

            return formula;
        }

        /// <summary>
        /// Сделать формулу пригодной для вычислений
        /// </summary>
        /// <param name="formula"></param>
        /// <returns></returns>
        public static string FuncReplace(string formula)
        {
            formula = formula.Replace(" ", "");
            formula = formula.Replace(",", ".");

            return formula;
        }

        /// <summary>
        /// Вычислить функцию
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static double Evaluate(string expression)
        {
            var loDataTable = new DataTable();
            var loDataColumn = new DataColumn("Eval", typeof(double), expression);
            loDataTable.Columns.Add(loDataColumn);
            loDataTable.Rows.Add(0);
            return (double)loDataTable.Rows[0]["Eval"];
        }
    }
}
