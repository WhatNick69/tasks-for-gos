using System.Drawing;

namespace WindowsFormsHowAreYou
{
    public class DrawGrafics
    {
        private Graphics dr;

        public DrawGrafics(Graphics gr)
        {
            this.dr = gr;
        }
        /// <summary>
        /// рисование оси координат
        /// </summary>
        private void scale()
        {
            dr.DrawString("N", new Font("Arial", 12), new SolidBrush(Color.Blue), new Point(26, 9));
            dr.DrawString("T", new Font("Arial", 12), new SolidBrush(Color.Blue), new Point(640, 260));
            Pen pen = new Pen(Color.Black, 1);
            dr.DrawLine(pen, new Point(50, 10), new Point(50, 250));
            dr.DrawLine(pen, new Point(50, 250), new Point(650, 250));
            dr.DrawLine(pen, new Point(50, 10), new Point(47, 20));
            dr.DrawLine(pen, new Point(50, 10), new Point(53, 20));
            dr.DrawLine(pen, new Point(650, 250), new Point(640, 253));
            dr.DrawLine(pen, new Point(650, 250), new Point(640, 247));
        }

        /// <summary>
        /// Рисование средней оси
        /// </summary>
        private void drawSrGrafics()
        {
            Pen pen = new Pen(Color.Violet, 2);
            Point[] points = { new Point(50, 250), new Point(620, 50) };
            dr.DrawCurve(pen, points);
            pen.Dispose();
            dr.Dispose();
        }

        /// <summary>
        /// Рисование "графика" работ
        /// </summary>
        /// <param name="array">Массив значений времени и работ</param>
        /// <param name="m">Кол-во работ и "времени"</param>
        private void drawGrafics(int[,] array, int m)
        {
            Pen pen = new Pen(Color.Green, 2);
            Point[] points = new Point[m];
            points[0] = new Point(50, 250); //начало
            points[m - 1] = new Point(620, 50); //конец
            for (int k = 1; k < m - 1; k++)
            {
                points[k] = new Point(50 + 600 * k / (m), 250 - array[1, k] * 2); //создание массива точек
                dr.DrawLine(pen, points[k - 1], points[k]);
            }
            dr.DrawLine(pen, points[m - 2], points[m - 1]);
            DrawPoints(points, m);
            pen.Dispose();
        }

        /// <summary>
        /// Рисование точек
        /// </summary>
        /// <param name="points">Массив точек</param>
        /// <param name="m">ЧИсло точек</param>
        private void DrawPoints(Point[] points, int m)
        {
            Pen pen = new Pen(Color.DarkGreen, 2);
            for (int k = 0; k < m; k++)
            {
                dr.DrawRectangle(pen, new Rectangle(points[k], new Size(1, 1)));
            }
            pen.Dispose();
        }

        /// <summary>
        /// Изначальный метод рисования, инициализирует прочие методы рисования
        /// </summary>
        /// <param name="tn">Массив времени и работ</param>
        /// <param name="m">Кол-во работ</param>
        public void drawAll(int[,] tn,int m )
        {
            scale();
            drawGrafics(tn, m);
            drawSrGrafics();
        }
    }
}
