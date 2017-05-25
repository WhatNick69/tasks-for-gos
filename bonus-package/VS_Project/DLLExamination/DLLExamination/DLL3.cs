using System.Drawing;
using System.Windows.Forms;

/// Создать DLL с классами Point и Square, описывающими точку и квадрат на плоскости со сторонами, 
/// параллельными осям координат. Построить Windows проект, 
/// предоставляющий пользователю интерфейс для работы с DLL. 
/// Среди методов класса Square предусмотреть метод, определяющий принадлежность заданной точки квадрату.
namespace DLLExamination
{
    /// <summary>
    /// Рисует линию.
    /// Проверяет, лежит ли точка на линии.
    /// </summary>
    public class Square
    {
        private Point squareStart;
        private int height;
        private int lenght;

        public Point SquareStart
        {
            get
            {
                return squareStart;
            }

            set
            {
                squareStart = value;
            }
        }

        /// <summary>
        /// Конструктор квадрата
        /// </summary>
        /// <param name="xPoint"></param>
        /// <param name="yPoint"></param>
        /// <param name="lenght"></param>
        /// <param name="height"></param>
        public Square(int xPoint, int yPoint, int lenght, int height)
        {
            squareStart = new Point(xPoint, yPoint, height);
            this.lenght = lenght;
            this.height = height;
        }

        /// <summary>
        /// Рисуем квадрат
        /// </summary>
        /// <param name="drawPanel"></param>
        /// <param name="pen"></param>
        /// <param name="brush"></param>
        public void DrawOnPanel(Panel drawPanel, Brush brush)
        {
            Graphics g = drawPanel.CreateGraphics();
            g.FillRectangle(brush, squareStart.XPoint, height-squareStart.YPoint
                , lenght, lenght);
        }

        /// <summary>
        /// Принадлежит ли точка квадрату?
        /// </summary>
        /// <param name="xPoint"></param>
        /// <param name="yPoint"></param>
        /// <returns></returns>
        public bool IsPointOnTheSquare(int xPoint, int yPoint)
        {
            return ((xPoint >= SquareStart.XPoint && xPoint <= SquareStart.XPoint + lenght)
                && (yPoint >= SquareStart.YPoint - lenght && yPoint <= SquareStart.YPoint)) ? true : false;
        } 
    }
}
