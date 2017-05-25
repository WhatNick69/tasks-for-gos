using System;
using System.Windows.Forms;

namespace DLLInterAndSol
{
    /// <summary>
    /// Находит корни функции, заданной аналитически
    /// </summary>
    public class Solver
    {
        private static string formula;
        private static float eps;
        private static float xValue;
        private static float leftValue;
        private static float rightValue;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="formula"></param>
        /// <param name="eps"></param>
        public Solver(string formula,float eps)
        {
            Solver.formula = formula;
            Solver.eps = eps;
        }

        /// <summary>
        /// Запуск вычислений
        /// </summary>
        public float Calculate()
        {
            float result = float.MaxValue;
            int countOfIterations = 10000;
            formula = Interpretator.FuncReplace(formula);
            SetStartLimits();

            while (Math.Abs(result) >= eps)
            {
                xValue = DivLimit();
                result = Iteration(xValue);
                if (Iteration(leftValue) * result > 0)
                    leftValue = xValue;
                else
                    rightValue = xValue;
                countOfIterations--;
                if (countOfIterations <= 0)
                {
                    MessageBox.Show("Expression do not have any solution!");
                    return 0;
                }
            }

            return xValue;
        }

        /// <summary>
        /// Передать массивы в класс для отрисовки
        /// </summary>
        private static void DrawArrayPanel()
        {
            DrawOnChart.ArrayXValues = CalculateXValues();
            DrawOnChart.ArrayFuncResults = CalculateFuncResults(DrawOnChart.ArrayXValues);
        }

        /// <summary>
        /// Сгенерить массив значений функции
        /// </summary>
        /// <param name="valuesX"></param>
        /// <returns></returns>
        private static float[] CalculateFuncResults(float[] valuesX)
        {
            float[] arrayFuncValues = 
               new float[50];
            for (int i = 0; i < valuesX.Length; i++)
            {
                arrayFuncValues[i] = Iteration(valuesX[i]);
                if (float.IsInfinity(arrayFuncValues[i]))
                {
                    if (i != 0) arrayFuncValues[i] = arrayFuncValues[i - 1];
                    else arrayFuncValues[i] = 0;
                }
            }
                

            return arrayFuncValues;
        }

        /// <summary>
        /// Сгенерить массив значений X для отрисовки
        /// </summary>
        /// <returns></returns>
        private static float[] CalculateXValues()
        {
            float[] arrayXValue = 
                new float[50];
            float temp = -200;
            for (int i = 0;i<arrayXValue.Length;i++)
            {
                arrayXValue[i] = temp;
                temp+= 10;
            }
            return arrayXValue;
        }

        /// <summary>
        /// Вычислить границы
        /// </summary>
        /// <returns></returns>
        private static float DivLimit()
        {
            return (leftValue + rightValue) / 2;
        }

        /// <summary>
        /// Устанавливаем границы вычислений
        /// </summary>
        private static void SetStartLimits()
        {
            leftValue = -100;
            rightValue = 100;

            DrawArrayPanel();
        }

        /// <summary>
        /// Вычислительная итерация
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static float Iteration(float x)
        {
            return (float)Interpretator.Evaluate(Interpretator.FuncValue(x, formula));
        }
    }
}
