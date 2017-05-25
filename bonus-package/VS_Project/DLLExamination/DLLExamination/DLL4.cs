using System;
using System.Drawing;
using System.Windows.Forms;

///Создать DLL с классами Point и Circle, описывающими точку и круг на плоскости.
///Построить Windows проект, предоставляющий пользователю 
///интерфейс для работы с DLL.Среди методов класса Circle предусмотреть метод, 
///определяющий принадлежность заданной точки кругу.
namespace DLLExamination
{
    public class Circle
    {
        private Point circleStart;
        private int radius;
        private int height;

        public Point CircleStart
        {
            get
            {
                return circleStart;
            }

            set
            {
                circleStart = value;
            }
        }

        /// <summary>
        /// Конструктор круга
        /// </summary>
        /// <param name="xPointStart"></param>
        /// <param name="yPointStart"></param>
        /// <param name="radius"></param>
        /// <param name="height"></param>
        public Circle(int xPointStart, int yPointStart, int radius,int height)
        {
            CircleStart = new Point(xPointStart, yPointStart, height);
            this.height = height;
            this.radius = radius;
        }

        /// <summary>
        /// Рисуем круг
        /// </summary>
        /// <param name="drawPanel"></param>
        /// <param name="pen"></param>
        /// <param name="brush"></param>
        public void DrawOnPanel(Panel drawPanel, Brush brush)
        {
            Graphics g = drawPanel.CreateGraphics();
            g.FillEllipse(brush, new RectangleF(CircleStart.XPoint,height-CircleStart.YPoint,radius,radius));
        }

        /// <summary>
        /// Принадлежит ли точка кругу?
        /// </summary>
        /// <param name="xPoint"></param>
        /// <param name="yPoint"></param>
        /// <returns></returns>
        public bool IsPointOnTheCircle(int xPoint, int yPoint)
        {   
            return CalculateCenter(xPoint,yPoint) <= radius/2 ? true : false;
        }

        /// <summary>
        /// Вычисляем дистанцию и центр
        /// </summary>
        public float CalculateCenter(int xPoint, int yPoint)
        {
            CircleStart.XPoint = CircleStart.XPoint + (radius / 2);
            CircleStart.YPoint = CircleStart.YPoint - (radius / 2);
            return (float)Math.Sqrt(Math.Pow(Math.Abs(xPoint - CircleStart.XPoint), 2)
                + Math.Pow(Math.Abs(yPoint - CircleStart.YPoint), 2));
        }
    }
}
