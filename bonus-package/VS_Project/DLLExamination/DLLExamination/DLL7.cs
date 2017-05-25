using System;
using System.Drawing;
using System.Windows.Forms;

/// Создать DLL с классами Point и Tetragon, описывающими точку и четырехугольник на плоскости. 
/// Построить Windows проект, предоставляющий пользователю интерфейс для работы с DLL.
/// Среди методов класса Tetragon предусмотреть метод, определяющий принадлежность заданной точки четырехугольнику.
namespace DLLExamination
{
    public class Tetragon
    {
        private Point[] tetraArray;
        private int height;

        public Point[] TetraArray
        {
            get
            {
                return tetraArray;
            }

            set
            {
                tetraArray = value;
            }
        }

        /// <summary>
        /// Конструктор тетрагона
        /// </summary>
        /// <param name="points"></param>
        /// <param name="height"></param>
        public Tetragon(Point[] points,int height)
        {
            this.tetraArray = points;
            this.height = height;
        }

        /// <summary>
        /// Рисуем тетрагон
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
            PointF[] pointsF = new PointF[tetraArray.Length];
            for (int i = 0; i < pointsF.Length; i++)
                pointsF[i] = new PointF(tetraArray[i].XPoint, height - tetraArray[i].YPoint);
               
            return pointsF;
        }

        /// <summary>
        /// Лежит ли точка в тетрагоне?
        /// </summary>
        /// <param name="xPoint"></param>
        /// <param name="yPoint"></param>
        /// <returns></returns>
        public bool IsPointOnTheTetragon(int xPoint, int yPoint)
        {
            bool b1, b2, b3, b4;
            Point pointField = new Point(xPoint, yPoint);
            Point[] points = tetraArray;
            b1 = Sign(pointField, points[0], points[1]) < 0;
            b2 = Sign(pointField, points[1], points[2]) < 0;
            b3 = Sign(pointField, points[2], points[3]) < 0;
            b4 = Sign(pointField, points[3], points[0]) < 0;

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
            float x = (p1.XPoint - p3.XPoint) * (p2.YPoint - p3.YPoint) - (p2.XPoint - p3.XPoint) * (p1.YPoint - p3.YPoint);
            return x;
        }
    }

    /// <summary>
    /// На плоскости задан выпуклый N-угольник – D и точка P. 
    /// Определить является ли точка P внешней или внутренней (граничной) точкой многоугольника D. 
    /// </summary>
    public class Polygon
    {
        private Point[] pointsArray; // массив точек
    }
}
