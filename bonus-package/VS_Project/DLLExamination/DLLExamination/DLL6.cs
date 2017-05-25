using System;
using System.Drawing;
using System.Windows.Forms;

/// Создать DLL с классами Point и Rhomb, описывающими точку и ромб на плоскости с осями, 
/// параллельными осям координат. Построить Windows проект, предоставляющий пользователю 
/// интерфейс для работы с DLL. Среди методов класса Rhomb предусмотреть метод, 
/// определяющий принадлежность заданной точки ромбу.
namespace DLLExamination
{
    public class Rhomb
    {
        private Point rhombStart;
        private Point rhombFinish;
        private int height;

        public Point RhombStart
        {
            get
            {
                return rhombStart;
            }

            set
            {
                rhombStart = value;
            }
        }

        public Point RhombFinish
        {
            get
            {
                return rhombFinish;
            }

            set
            {
                rhombFinish = value;
            }
        }


        /// <summary>
        /// Конструктор ромба
        /// </summary>
        /// <param name="xPointStart"></param>
        /// <param name="yPointStart"></param>
        /// <param name="len"></param>
        /// <param name="wid"></param>
        /// <param name="height"></param>
        public Rhomb(int xPointStart, int yPointStart, int len, int wid, int height)
        {
            RhombStart = new Point(xPointStart, height-yPointStart, height);
            RhombFinish = new Point(xPointStart+len, height-yPointStart + wid, height);
            this.height = height;
        }

        /// <summary>
        /// Рисуем ромб
        /// </summary>
        /// <param name="drawPanel"></param>
        /// <param name="pen"></param>
        /// <param name="brush"></param>
        public void DrawOnPanel(Panel drawPanel, Brush brush)
        {
            Graphics g = drawPanel.CreateGraphics();
            g.FillPolygon(brush, GeneratePolygon());
        }

        /// <summary>
        /// Генерация координат для отрисовки
        /// </summary>
        /// <returns></returns>
        public PointF[] GeneratePolygon()
        {
            PointF[] points = new PointF[4];
            points[0] = new PointF(RhombFinish.XPoint-(RhombFinish.XPoint-RhombStart.XPoint)/2, 
                RhombStart.YPoint);
            points[1] = new PointF(RhombFinish.XPoint, 
                 RhombStart.YPoint-(RhombStart.YPoint-RhombFinish.YPoint)/2);
            points[2] = new PointF(RhombFinish.XPoint-(RhombFinish.XPoint - RhombStart.XPoint) / 2,
                RhombFinish.YPoint);
            points[3] = new PointF(RhombStart.XPoint, 
                RhombStart.YPoint-(RhombStart.YPoint - RhombFinish.YPoint) / 2);

            return points;
        }

        /// <summary>
        /// Генерация координат для проверки на вхождение
        /// </summary>
        /// <returns></returns>
        public Point[] GeneratePolygonForEquals()
        {
            Point[] points = new Point[4];
            int po0 = height - RhombStart.YPoint;
            int po2 = height - RhombFinish.YPoint;
            points[0] = new Point(RhombFinish.XPoint - (RhombFinish.XPoint - RhombStart.XPoint) / 2,
                po0);
            points[1] = new Point(RhombFinish.XPoint,
                 po0-(po0-po2)/2);
            points[2] = new Point(RhombFinish.XPoint - (RhombFinish.XPoint - RhombStart.XPoint) / 2,
                po2);
            points[3] = new Point(RhombStart.XPoint,
                po0-(po0-po2)/2);

            return points;
        }

        /// <summary>
        /// Лежит ли точка в ромбе?
        /// </summary>
        /// <param name="xPoint"></param>
        /// <param name="yPoint"></param>
        /// <returns></returns>
        public bool IsPointOnTheRhomb(int xPoint, int yPoint)
        {
            bool b1, b2, b3,b4;
            Point pointField = new Point(xPoint, yPoint);
            Point[] points = GeneratePolygonForEquals();
            b1 = Sign(pointField, points[0], points[1]) < 0f;
            b2 = Sign(pointField, points[1], points[2]) < 0f;
            b3 = Sign(pointField, points[2], points[3]) < 0f;
            b4 = Sign(pointField, points[3], points[0]) < 0f;

            if ((b1 == b2) && (b2 == b3) && (b3 == b4)) return true;
            return PointInLine(points[0], points[1], pointField) || PointInLine(points[1], points[2], pointField) 
                || PointInLine(points[2], points[3], pointField) || PointInLine(points[3], points[0], pointField);
        }

        /// <summary>
        /// Если точка находится на границе фигуры
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <param name="pl"></param>
        /// <returns></returns>
        private bool PointInLine(Point l1, Point l2, Point pl)
        {
            double b = (l1.XPoint / (double)(l2.XPoint - l1.XPoint) * (l2.YPoint - l1.YPoint) - l1.YPoint) * -1;
            double a = (l2.YPoint - l1.YPoint) / (double)(l2.XPoint - l1.XPoint);
            double d = Math.Abs(a * pl.XPoint - pl.YPoint + b) / Math.Sqrt(Math.Pow(a, 2) + 1);
            return d <= 0.1f ? true : false;
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
