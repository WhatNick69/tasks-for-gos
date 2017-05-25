using System.Drawing;
using System.Windows.Forms;

/// Создать DLL с классами Point и Triangle, описывающими точку и треугольник на плоскости. 
/// Построить Windows проект, предоставляющий пользователю интерфейс для работы с DLL.
/// Среди методов класса Triangle предусмотреть метод, определяющий принадлежность заданной точки треугольнику.
namespace DLLExamination
{
    public class Triangle
    {
        private Point triangleFirstPoint;
        private Point triangleSecondPoint;
        private Point triangleThirdPoint;
        private int height;

        public Point TriangleFirstPoint
        {
            get
            {
                return triangleFirstPoint;
            }

            set
            {
                triangleFirstPoint = value;
            }
        }

        public Point TriangleSecondPoint
        {
            get
            {
                return triangleSecondPoint;
            }

            set
            {
                triangleSecondPoint = value;
            }
        }

        public Point TriangleThirdPoint
        {
            get
            {
                return triangleThirdPoint;
            }

            set
            {
                triangleThirdPoint = value;
            }
        }

        /// <summary>
        /// Конструктор треугольника
        /// </summary>
        /// <param name="xFirst"></param>
        /// <param name="yFirst"></param>
        /// <param name="xSecond"></param>
        /// <param name="ySecond"></param>
        /// <param name="xThird"></param>
        /// <param name="yThird"></param>
        /// <param name="height"></param>
        public Triangle(int xFirst,int yFirst, int xSecond, int ySecond, int xThird, int yThird,int height)
        {
            TriangleFirstPoint = new Point(xFirst,yFirst,height);
            TriangleSecondPoint = new Point(xSecond, ySecond, height);
            TriangleThirdPoint = new Point(xThird, yThird, height);
            this.height = height;
        }

        /// <summary>
        /// Рисуем треугольник
        /// </summary>
        /// <param name="drawPanel"></param>
        /// <param name="pen"></param>
        /// <param name="brush"></param>
        public void DrawOnPanel(Panel drawPanel, Brush brush)
        {
            Graphics g = drawPanel.CreateGraphics();
            g.FillPolygon(brush, GenerateTriangle());
        }

        /// <summary>
        /// Генерация полигона
        /// </summary>
        /// <returns></returns>
        public PointF[] GenerateTriangle()
        {
            PointF[] points = new PointF[3];
            points[0] = new PointF(TriangleFirstPoint.XPoint, height- TriangleFirstPoint.YPoint);
            points[1] = new PointF(TriangleSecondPoint.XPoint, height-TriangleSecondPoint.YPoint);
            points[2] = new PointF(TriangleThirdPoint.XPoint, height-TriangleThirdPoint.YPoint);

            return points;
        }

        /// <summary>
        /// Лежит ли точка в треугольнике?
        /// </summary>
        /// <param name="xPoint"></param>
        /// <param name="yPoint"></param>
        /// <returns></returns>
        public bool IsPointOnTheTriangle(int xPoint, int yPoint)
        {
            bool b1, b2, b3;
            Point pointField = new Point(xPoint, yPoint);
            b1 = Sign(pointField,TriangleFirstPoint,TriangleSecondPoint) < 0.0f;
            b2 = Sign(pointField, TriangleSecondPoint,TriangleThirdPoint) < 0.0f;
            b3 = Sign(pointField, TriangleThirdPoint,TriangleFirstPoint) < 0.0f;

            return ((b1 == b2) && (b2 == b3));
        }

        /// <summary>
        /// Проверка
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <returns></returns>
        private float Sign(Point p1, Point p2, Point p3)
        {
            return (p1.XPoint - p3.XPoint) * (p2.YPoint - p3.YPoint) - (p2.XPoint - p3.XPoint) * (p1.YPoint - p3.YPoint);
        }
    }
}
