using System.Drawing;
using System.Windows.Forms;

///Создать DLL с классами Point и Rectangle, 
///описывающими точку и прямоугольник на плоскости со сторонами, 
///параллельными осям координат.Построить Windows проект, 
///предоставляющий пользователю интерфейс для работы с DLL.
///Среди методов класса Rectangle предусмотреть метод, 
///определяющий принадлежность заданной точки прямоугольнику.
namespace DLLExamination
{
    public class Rectangle
    {
        private Point rectangleStart;
        private Point rectangleFinish;
        private int height;
        private int lenght;
        private int width;

        public Point RectangleStart
        {
            get
            {
                return rectangleStart;
            }

            set
            {
                rectangleStart = value;
            }
        }

        public Point RectangleFinish
        {
            get
            {
                return rectangleFinish;
            }

            set
            {
                rectangleFinish = value;
            }
        }


        /// <summary>
        /// Конструктор прямоугольнака
        /// </summary>
        /// <param name="xPointStart"></param>
        /// <param name="yPointStart"></param>
        /// <param name="lenght"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Rectangle(int xPointStart, int yPointStart, int lenght, int width,int height)
        {
            RectangleStart = new Point(xPointStart, yPointStart, height);
            RectangleFinish = new Point(xPointStart + lenght, yPointStart-width, height);
            this.height = height;
            this.lenght = lenght;
            this.width = width;
        }

        /// <summary>
        /// Рисуем прямоугольник
        /// </summary>
        /// <param name="drawPanel"></param>
        /// <param name="pen"></param>
        /// <param name="brush"></param>
        public void DrawOnPanel(Panel drawPanel, Brush brush)
        {
            Graphics g = drawPanel.CreateGraphics();
            g.FillRectangle(brush, RectangleStart.XPoint, height - RectangleStart.YPoint
                , lenght, width);
        }

        /// <summary>
        /// Принадлежит ли точка квадрату?
        /// </summary>
        /// <param name="xPoint"></param>
        /// <param name="yPoint"></param>
        /// <returns></returns>
        public bool IsPointOnTheRectangle(int xPoint, int yPoint)
        {
            return ((xPoint >= RectangleStart.XPoint && xPoint <= RectangleFinish.XPoint)
                && (yPoint >= RectangleFinish.YPoint && yPoint <= RectangleStart.YPoint)) ? true : false;
        }
    }
}
