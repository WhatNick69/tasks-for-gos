using System;
using System.Drawing;
using System.Windows.Forms;

/// Создать DLL с классами Point и Line, описывающими точку и линию на плоскости. 
/// Построить Windows проект, предоставляющий пользователю интерфейс для работы с DLL. 
/// Среди методов класса Line предусмотреть метод, определяющий принадлежность заданной точки линии.
namespace DLLExamination
{
    /// <summary>
    /// Рисует точку
    /// </summary>
    public class Point
    {
        private int xPoint;
        private int yPoint;
        private int height;

        public int YPoint
        {
            get
            {
                return yPoint;
            }

            set
            {
                yPoint = value;
            }
        }

        public int XPoint
        {
            get
            {
                return xPoint;
            }

            set
            {
                xPoint = value;
            }
        }

        /// <summary>
        /// Конструктор точки
        /// </summary>
        /// <param name="xPoint"></param>
        /// <param name="yPoint"></param>
        /// <param name="height"></param>
        public Point(int xPoint,int yPoint,int height=0)
        {
            this.xPoint = xPoint;
            this.yPoint = yPoint;
            this.height = height;
        }

        /// <summary>
        /// Рисуем точку
        /// </summary>
        /// <param name="drawPanel"></param>
        /// <param name="pen"></param>
        /// <param name="brush"></param>
        public void DrawOnPanel(Panel drawPanel,Brush brush)
        {
            Graphics g = drawPanel.CreateGraphics();
            g.FillRectangle(brush, xPoint, height-yPoint, 5, 5);
        }
    }

    /// <summary>
    /// Рисует линию.
    /// Проверяет, лежит ли точка на линии.
    /// </summary>
    public class Line
    {
        private Point start;
        private Point finish;
        private int height;

        public Point Finish
        {
            get
            {
                return finish;
            }

            set
            {
                finish = value;
            }
        }

        public Point Start
        {
            get
            {
                return start;
            }

            set
            {
                start = value;
            }
        }

        /// <summary>
        /// Конструктор линии
        /// </summary>
        /// <param name="xLine1"></param>
        /// <param name="yLine1"></param>
        /// <param name="xLine2"></param>
        /// <param name="yLine2"></param>
        /// <param name="theshold"></param>
        /// <param name="height"></param>
        public Line(int xLine1, int yLine1, int xLine2, int yLine2, int height)
        {
            start = new Point(xLine1,yLine1,height);
            finish = new Point(xLine2, yLine2, height);
            this.height = height;
        }

        /// <summary>
        /// Принадлежит ли точка линии?
        /// </summary>
        /// <returns></returns>
        public bool IsPointOnTheLine(int xPoint, int yPoint)
        {
            double b = (Start.XPoint / (double)(Finish.XPoint - Start.XPoint) *
                (Finish.YPoint - Start.YPoint) - Start.YPoint) * - 1;
            double a = (Finish.YPoint - Start.YPoint) / (double)(Finish.XPoint - Start.XPoint);
            double d = ((Math.Abs(a * xPoint - yPoint + b)) / Math.Sqrt(Math.Pow(a, 2) + 1));

            return d <= 1f ? true : false;
        }

        /// <summary>
        /// Рисуем линию
        /// </summary>
        /// <param name="drawPanel"></param>
        /// <param name="pen"></param>
        /// <param name="brush"></param>
        public void DrawOnPanel(Panel drawPanel, Pen pen)
        {
            Graphics g = drawPanel.CreateGraphics();
            g.DrawLine(pen, Start.XPoint, height - Start.YPoint, Finish.XPoint, height - Finish.YPoint);
        }
    }
}