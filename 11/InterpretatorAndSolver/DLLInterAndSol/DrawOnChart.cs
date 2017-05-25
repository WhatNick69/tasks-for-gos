using System;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace DLLInterAndSol
{
    /// <summary>
    /// Отрисовывает график функции
    /// </summary>
    public class DrawOnChart
    {
        private static float[] arrayResultFunc;
        private static float[] arrayXValue;

        /// <summary>
        /// Геттер и сеттер для массива значений X
        /// </summary>
        public static float[] ArrayXValues
        {
            get
            {
                return arrayXValue;
            }

            set
            {
                arrayXValue = value;
            }
        }

        /// <summary>
        /// Геттер и сеттер для массива значений функции
        /// </summary>
        public static float[] ArrayFuncResults
        {
            get
            {
                return arrayResultFunc;
            }

            set
            {
                arrayResultFunc = value;
            }
        }

        /// <summary>
        /// Отрисовываем график
        /// </summary>
        /// <param name="charBox"></param>
        public static void PrintCharts(Chart charBox)
        {
            float min = float.MaxValue;
            float max = float.MinValue;

            Series series = new Series("f(x)")
            {
                ChartType = SeriesChartType.Spline
            };

            series.BorderWidth = 5;
            series.Color = Color.Red;

            for (int i = 0; i < arrayXValue.Length; i++)
            {
                series.Points.AddXY(arrayXValue[i], Math.Round(arrayResultFunc[i],3));

            }
            for (int i = 0;i< arrayResultFunc.Length;i++)
            {
                if (arrayResultFunc[i] > max) max = arrayResultFunc[i];
                if (arrayResultFunc[i] < min) min = arrayResultFunc[i];
            }


            if (series.Points.Count != 0)
            {
                charBox.Series.Clear();
                charBox.ChartAreas[0].AxisY.Minimum = min;
                charBox.ChartAreas[0].AxisY.Maximum = max;
                charBox.Series.Add(series);
            }
        }
    }
}
