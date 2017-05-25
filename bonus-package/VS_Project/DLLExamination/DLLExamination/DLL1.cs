using System;

/// Создать DLL с классом Point, описывающим точку на плоскости, 
/// заданную декартовыми и полярными координатами.
/// Среди методов класса Point предусмотреть метод Distance,
/// вычисляющий расстояние до заданной точки.Построить Windows проект, 
/// предоставляющий пользователю интерфейс для работы с классом Point.
namespace DLLExamination
{
    // Ну да, называется DPoint. Потому что класс Point уже определен
    public class DPoint
    {
        public static Point PolarPointToCartPoint(int r, int gradus)
        {
            double gradusInRadians = gradus * (Math.PI / 180.0);
            double x = r * Math.Cos(gradusInRadians);
            double y = r * Math.Sin(gradusInRadians);
            return new Point((int)x, (int)y);
        }

        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.XPoint - p1.XPoint, 2) + Math.Pow(p2.YPoint - p1.YPoint, 2));
        }
    }
}
