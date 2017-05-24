using System.Drawing;
using System.Windows.Forms;

namespace DLLPolygon
{
    /// <summary>
    /// Описывают точку на поле
    /// </summary>
    public class Point
    {
        private int xPoint;
        private int yPoint;

        public Point(int x = 0, int y = 0)
        {
            this.xPoint = x;
            this.yPoint = y;
        }

        /// <summary>
        /// Геттер и сеттер по X
        /// </summary>
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
        /// Геттер и сеттер по Y
        /// </summary>
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

        /// <summary>
        /// Нарисовать точку на поле
        /// </summary>
        /// <param name="drawPanel"></param>
        /// <param name="brush"></param>
        /// <param name="height"></param>
        public void DrawPoint(Panel drawPanel, Brush brush, int height)
        {
            Graphics g = drawPanel.CreateGraphics();
            g.FillRectangle(brush, xPoint, height - yPoint, 5, 5);
        }
    }
}
