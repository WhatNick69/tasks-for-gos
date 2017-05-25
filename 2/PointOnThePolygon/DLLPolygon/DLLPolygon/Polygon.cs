using System;
using System.Drawing;
using System.Windows.Forms;

namespace DLLPolygon
{
    /// <summary>
    /// Многоугольник
    /// </summary>
    public class Polygon
    {
        private Point[] tetraArray; // массив точек
        private int height; // высота поля для рисования

        /// <summary>
        /// Геттер и сеттер массива поинтов
        /// </summary>
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
        /// Конструктор многоугольника
        /// </summary>
        /// <param name="points"></param>
        /// <param name="height"></param>
        public Polygon(Point[] points, int height)
        {
            Array.Reverse(points);
            this.tetraArray = points;
            this.height = height;
        }

        /// <summary>
        /// Рисуем многоугольник
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
        /// Лежит ли точка в полигоне?
        /// </summary>
        /// <param name="xPoint"></param>
        /// <param name="yPoint"></param>
        /// <returns></returns>
        public bool IsPointOnThePolgon(int xPoint, int yPoint)
        {
            bool[] b = new bool[tetraArray.Length];
            Point pointField = new Point(xPoint, yPoint);
            Point[] points = tetraArray;
            for (int i = 0; i < tetraArray.Length; i++)
            {
                if (i == tetraArray.Length - 1) b[i] = Sign(pointField, points[i], points[0]) < 0;
                else b[i] = Sign(pointField, points[i], points[i + 1]) < 0;
            }
            int trueCounter = 0;
            for (int i = 0; i < b.Length; i++)
                if (b[i]) trueCounter++;
            if (trueCounter == b.Length) return true;

            for (int i = 0; i < b.Length - 1; i++)
            {
                if (b[i] != b[i + 1]) return false;
            }

            for (int i = 0; i < tetraArray.Length; i++)
            {
                if (i == b.Length - 1)
                {
                    if (PointInLine(points[i], points[0], pointField)) return true;
                }
                else
                {
                    if (PointInLine(points[i], points[i + 1], pointField)) return true;
                }

            }
            return false;
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
            float a = (p1.XPoint - p3.XPoint) * (p2.YPoint - p3.YPoint) - (p2.XPoint - p3.XPoint) * (p1.YPoint - p3.YPoint);
            return a;
        }
    }
}

