using DLLExamination;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WorkWithDLL
{
    public partial class Form1 : Form
    {
        private SolidBrush greenBrush;
        private SolidBrush blueBrush;
        private Graphics panelGraphics;
        private Pen redPen;

        /// <summary>
        /// Предзагрузка
        /// </summary>
        private void Initialisation()
        {
            this.redPen = new Pen(Color.Red, 5);
            this.greenBrush = new SolidBrush(Color.Green);
            this.blueBrush = new SolidBrush(Color.Blue);
        }

        public Form1()
        {
            InitializeComponent();
            Initialisation();
        }

        /// <summary>
        /// Проверяем, какую библиотеку мы выбрали
        /// и отображаем нужную панель
        /// </summary>
        private void CheckDLLForPanel()
        {
            switch (dllBox.Text)
            {
                case "DLL1":
                    dll1Panel.Visible = true;
                    break;
                case "DLL2":
                    dll2Panel.Visible = true;
                    break;
                case "DLL3":
                    dll3Panel.Visible = true;
                    break;
                case "DLL4":
                    dll4Panel.Visible = true;
                    break;
                case "DLL5":
                    dll5Panel.Visible = true;
                    break;
                case "DLL6":
                    dll6Panel.Visible = true;
                    break;
                case "DLL7":
                    dll7Panel.Visible = true;
                    dll7Panel.TabIndex = 1;
                    break;
                case "DLL8":
                    dll8Panel.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// Проверяем, какую библиотеку мы выбрали
        /// и отображаем нужную панель
        /// </summary>
        private void CheckDLLMethod()
        {
            ClearDrawPanel();
            switch (dllBox.Text)
            {
                case "DLL1":
                    DLL1Method();
                    break;
                case "DLL2":
                    DLL2Method();
                    break;
                case "DLL3":
                    DLL3Method();
                    break;
                case "DLL4":
                    DLL4Method();
                    break;
                case "DLL5":
                    DLL5Method();
                    break;
                case "DLL6":
                    DLL6Method();
                    break;
                case "DLL7":
                    DLL7Method();
                    break;
                case "DLL8":
                    DLL8Method();
                    break;
            }
        }

        /// <summary>
        /// Очистить панель для рисования
        /// </summary>
        private void ClearDrawPanel()
        {
            Graphics g = drawPanel.CreateGraphics();
            g.Clear(Color.White);
        }

        #region Обработка выбранной DLL
        private void DLL1Method()
        {
            DLLExamination.Point first;
            DLLExamination.Point second;
            if (dll1Check1.Checked)
                first = new DLLExamination.Point(Convert.ToInt32(dll1X1.Text), Convert.ToInt32(dll1Y1.Text));
            else
                first = DPoint.PolarPointToCartPoint(Convert.ToInt32(dll1X1.Text), Convert.ToInt32(dll1Y1.Text));

            if (dll1Check2.Checked)
                second = new DLLExamination.Point(Convert.ToInt32(dll1X2.Text), Convert.ToInt32(dll1Y2.Text));
            else
                second = DPoint.PolarPointToCartPoint(Convert.ToInt32(dll1X2.Text), Convert.ToInt32(dll1Y2.Text));

            dll1Result.Text = "Дистанция: " + Math.Round(DPoint.Distance(first,second),3);
        }

        private void DLL2Method()
        {
            Line line = new Line(Convert.ToInt32(dll2LineX1.Text), Convert.ToInt32(dll2LineY1.Text)
                        , Convert.ToInt32(dll2LineX2.Text), Convert.ToInt32(dll2LineY2.Text)
                        , drawPanel.Size.Height);
            DLLExamination.Point point = new DLLExamination.Point
                (Convert.ToInt32(dll2PointX.Text), Convert.ToInt32(dll2PointY.Text),
                drawPanel.Size.Height);

            line.DrawOnPanel(drawPanel, redPen);
            point.DrawOnPanel(drawPanel, greenBrush);

            if (line.IsPointOnTheLine(Convert.ToInt32(dll2PointX.Text),
                Convert.ToInt32(dll2PointY.Text)))
                dll2Result.Text = "На линии";
            else dll2Result.Text = "Не в линии";
        }

        private void DLL3Method()
        {
            DLLExamination.Point point = new DLLExamination.Point
                        (Convert.ToInt32(dll3PointX.Text), Convert.ToInt32(dll3PointY.Text),
                        drawPanel.Size.Height);
            Square square = new Square(Convert.ToInt32(dll3SquareX.Text), Convert.ToInt32(dll3SquareY.Text),
                Convert.ToInt32(dll3Lenght.Text), drawPanel.Size.Height);

            square.DrawOnPanel(drawPanel, greenBrush);
            point.DrawOnPanel(drawPanel, blueBrush);

            if (square.IsPointOnTheSquare(Convert.ToInt32(dll3PointX.Text),
                Convert.ToInt32(dll3PointY.Text)))
                dll3result.Text = "В квадрате";
            else dll3result.Text = "За квадратом";
        }

        private void DLL4Method()
        {
            DLLExamination.Point point = new DLLExamination.Point
                (Convert.ToInt32(dll4PoX.Text), Convert.ToInt32(dll4PoY.Text),
                drawPanel.Size.Height);

            DLLExamination.Circle circle = new DLLExamination.Circle(Convert.ToInt32(dll4RadX.Text),
                Convert.ToInt32(dll4RadY.Text), Convert.ToInt32(dll4Radius.Text),
                drawPanel.Size.Height);

            circle.DrawOnPanel(drawPanel, greenBrush);
            point.DrawOnPanel(drawPanel, blueBrush);

            if (circle.IsPointOnTheCircle(Convert.ToInt32(dll4PoX.Text),
                Convert.ToInt32(dll4PoY.Text)))
                dll4Result.Text = "В окружности";
            else dll4Result.Text = "За окружностью";
        }

        private void DLL5Method()
        {
            DLLExamination.Point point = new DLLExamination.Point
                       (Convert.ToInt32(dll5PoX.Text), Convert.ToInt32(dll5PoY.Text),
                       drawPanel.Size.Height);

            DLLExamination.Rectangle rect = new DLLExamination.Rectangle(Convert.ToInt32(dll5RectangleX1.Text),
                Convert.ToInt32(dll5RectangleY1.Text), Convert.ToInt32(dll5Lenght.Text),
                Convert.ToInt32(dll5Width.Text), drawPanel.Size.Height);

            rect.DrawOnPanel(drawPanel, greenBrush);
            point.DrawOnPanel(drawPanel, blueBrush);

            if (rect.IsPointOnTheRectangle(Convert.ToInt32(dll5PoX.Text),
                Convert.ToInt32(dll5PoY.Text)))
                dll5Result.Text = "В прямоугольнике";
            else dll5Result.Text = "За прямоугольником";
        }

        private void DLL6Method()
        {
            DLLExamination.Point point = new DLLExamination.Point
                (Convert.ToInt32(dll6PoX.Text), Convert.ToInt32(dll6PoY.Text),
                drawPanel.Size.Height);

            DLLExamination.Rhomb rhomb = new DLLExamination.Rhomb(Convert.ToInt32(dll6RomX1.Text), Convert.ToInt32(dll6RomY1.Text),
                Convert.ToInt32(dll6Len.Text), Convert.ToInt32(dll6Wid.Text), drawPanel.Size.Height);

            rhomb.DrawOnPanel(drawPanel, greenBrush);
            point.DrawOnPanel(drawPanel, blueBrush);

            if (rhomb.IsPointOnTheRhomb(Convert.ToInt32(dll6PoX.Text),
                Convert.ToInt32(dll6PoY.Text)))
                dll6Result.Text = "В ромбе";
            else dll6Result.Text = "За ромбом";
        }

        private void DLL7Method()
        {
            DLLExamination.Point point = new DLLExamination.Point
               (Convert.ToInt32(dll7PoX.Text), Convert.ToInt32(dll7PoY.Text),
               drawPanel.Size.Height);

            DLLExamination.Tetragon tetragon 
                = new DLLExamination.Tetragon(DLL7GeneratePointsArray(), drawPanel.Size.Height);

            tetragon.DrawOnPanel(drawPanel, greenBrush);
            point.DrawOnPanel(drawPanel, blueBrush);

            if (tetragon.IsPointOnTheTetragon(Convert.ToInt32(dll7PoX.Text),
                Convert.ToInt32(dll7PoY.Text)))
                dll7Result.Text = "В тетрагоне";
            else dll7Result.Text = "За тетрагоном";
        }

        private DLLExamination.Point[] DLL7GeneratePointsArray()
        {
            DLLExamination.Point[] points = new DLLExamination.Point[4];
            points[0] = new DLLExamination.Point(Convert.ToInt32(dll7X1.Text), 
                Convert.ToInt32(dll7Y1.Text), drawPanel.Size.Height);
            points[1] = new DLLExamination.Point(Convert.ToInt32(dll7X2.Text),
                Convert.ToInt32(dll7Y2.Text), drawPanel.Size.Height);
            points[2] = new DLLExamination.Point(Convert.ToInt32(dll7X3.Text),
                Convert.ToInt32(dll7Y3.Text), drawPanel.Size.Height);
            points[3] = new DLLExamination.Point(Convert.ToInt32(dll7X4.Text),
                Convert.ToInt32(dll7Y4.Text), drawPanel.Size.Height);
            return points;
        } 

        private void DLL8Method()
        {
            DLLExamination.Point point = new DLLExamination.Point
                (Convert.ToInt32(dll8PoX.Text), Convert.ToInt32(dll8PoY.Text),
                drawPanel.Size.Height);

            DLLExamination.Triangle triangle = new DLLExamination.Triangle(Convert.ToInt32(dll8TriX1.Text), 
                Convert.ToInt32(dll8TriY1.Text), Convert.ToInt32(dll8TriX2.Text), Convert.ToInt32(dll8TriY2.Text),
                Convert.ToInt32(dll8TriX3.Text), Convert.ToInt32(dll8TriY3.Text), drawPanel.Size.Height);

            triangle.DrawOnPanel(drawPanel, greenBrush);
            point.DrawOnPanel(drawPanel, blueBrush);

            if (triangle.IsPointOnTheTriangle(Convert.ToInt32(dll8PoX.Text),
                Convert.ToInt32(dll8PoY.Text)))
                dll8Result.Text = "В треугольнике";
            else dll8Result.Text = "За треугольником";
        }

        #endregion

        #region Рандомная генерация значений для выбранной DLL
        private void RandomPanelDLL1()
        {
            Random rnd = new Random();
            if (dll1Check1.Checked)
            {
                dll1X1.Text = rnd.Next(-100, 100).ToString();
                dll1Y1.Text = rnd.Next(-100, 100).ToString();

            }
            else
            {
                dll1X1.Text = rnd.Next(0, 180).ToString();
                dll1Y1.Text = rnd.Next(0, 180).ToString();
            }

            if (dll1Check2.Checked)
            {
                dll1X2.Text = rnd.Next(-100, 100).ToString();
                dll1Y2.Text = rnd.Next(-100, 100).ToString();
            }
            else
            {
                dll1Y2.Text = rnd.Next(0, 180).ToString();
                dll1X2.Text = rnd.Next(0, 180).ToString();
            }
            CheckDLLMethod();
        }

        private void RandomPanelDLL2()
        {
            Random rnd = new Random();
            dll2PointX.Text = rnd.Next(10, 564).ToString();
            dll2LineX1.Text = rnd.Next(10, 564).ToString();
            dll2LineX2.Text = rnd.Next(10, 564).ToString();
            dll2LineY1.Text = rnd.Next(10, 354).ToString();
            dll2LineY2.Text = rnd.Next(10, 354).ToString();
            dll2PointY.Text = rnd.Next(10, 354).ToString();
            CheckDLLMethod();
        }

        private void RandomPanelDLL3()
        {
            Random rnd = new Random();
            dll3SquareX.Text = rnd.Next(10, 564).ToString();
            dll3SquareY.Text = rnd.Next(10, 354).ToString();
            dll3Lenght.Text = rnd.Next(10, 200).ToString();
            dll3PointX.Text = rnd.Next(10, 564).ToString();
            dll3PointY.Text = rnd.Next(10, 354).ToString();
            CheckDLLMethod();
        }

        private void RandomPanelDLL4()
        {
            Random rnd = new Random();
            dll4RadX.Text = rnd.Next(10, 564).ToString();
            dll4RadY.Text = rnd.Next(10, 354).ToString();
            dll4PoX.Text = rnd.Next(10, 564).ToString();
            dll4PoY.Text = rnd.Next(10, 354).ToString();
            dll4Radius.Text = rnd.Next(10, 200).ToString();
            CheckDLLMethod();
        }

        private void RandomPanelDLL5()
        {
            Random rnd = new Random();
            dll5RectangleX1.Text = rnd.Next(10, 564).ToString();
            dll5RectangleY1.Text = rnd.Next(10, 354).ToString();
            dll5Lenght.Text = rnd.Next(10, 200).ToString();
            dll5Width.Text = rnd.Next(10, 200).ToString();
            dll5PoX.Text = rnd.Next(10, 564).ToString();
            dll5PoY.Text = rnd.Next(10, 354).ToString();
            CheckDLLMethod();
        }
        private void RandomPanelDLL6()
        {
            Random rnd = new Random();
            dll6RomX1.Text = rnd.Next(10, 564).ToString();
            dll6Len.Text = rnd.Next(10, 564).ToString();
            dll6PoX.Text = rnd.Next(10, 564).ToString();
            dll6RomY1.Text = rnd.Next(10, 354).ToString();
            dll6Wid.Text = rnd.Next(10, 354).ToString();
            dll6PoY.Text = rnd.Next(10, 354).ToString();
            CheckDLLMethod();
        }
        private void RandomPanelDLL7()
        {
            DLL7RandomValues(drawPanel.Width,drawPanel.Height);
            CheckDLLMethod();
        }

        private void DLL7RandomValues(int x,int y)
        {
            Random rnd = new Random();
            int yt = y / 6;
            int xt = x / 6;

            dll7X1.Text = rnd.Next(xt, xt * 2).ToString();
            dll7Y1.Text = rnd.Next(yt, yt * 2).ToString();
            dll7X2.Text = rnd.Next(xt, xt * 2).ToString();
            dll7Y2.Text = rnd.Next(yt * 4, yt * 5).ToString();
            dll7X4.Text = rnd.Next(xt * 4, xt * 5).ToString();
            dll7Y4.Text = rnd.Next(yt, yt * 2).ToString();
            dll7X3.Text = rnd.Next(xt * 4, xt * 5).ToString();
            dll7Y3.Text = rnd.Next(yt * 4, yt * 5).ToString();
            dll7PoX.Text = rnd.Next(10, x).ToString();
            dll7PoY.Text = rnd.Next(10, y).ToString();
        }

        private void RandomPanelDLL8()
        {
            Random rnd = new Random();
            dll8TriX1.Text = rnd.Next(10, 564).ToString();
            dll8TriX2.Text = rnd.Next(10, 564).ToString();
            dll8TriX3.Text = rnd.Next(10, 564).ToString();
            dll8PoX.Text = rnd.Next(10, 564).ToString();
            dll8TriY1.Text = rnd.Next(10, 354).ToString();
            dll8TriY2.Text = rnd.Next(10, 354).ToString();
            dll8TriY3.Text = rnd.Next(10, 354).ToString();
            dll8PoY.Text = rnd.Next(10, 354).ToString();
            CheckDLLMethod();
        }
        #endregion

        #region События для интерфейса
        /// <summary>
        /// Выбираем библиотеку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dllBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckDLLForPanel();
        }

        /// <summary>
        /// Смотрим, какая библиотека выбрана и далее решаем, что делать 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startButton_Click(object sender, EventArgs e)
        {
            CheckDLLMethod();
        }

        private void dll1RandomButton_Click(object sender, EventArgs e)
        {
            RandomPanelDLL1();
        }

        private void dll2RandomButton_Click(object sender, EventArgs e)
        {
            RandomPanelDLL2();
        }

        private void dll3randomButton_Click(object sender, EventArgs e)
        {
            RandomPanelDLL3();
        }
        private void dllBox_DropDown(object sender, EventArgs e)
        {
            dll1Panel.Visible = false;
            dll2Panel.Visible = false;
            dll3Panel.Visible = false;
            dll4Panel.Visible = false;
            dll5Panel.Visible = false;
            dll6Panel.Visible = false;
            dll7Panel.Visible = false;
            dll8Panel.Visible = false;
        }

        private void dll5RandomButton_Click(object sender, EventArgs e)
        {
            RandomPanelDLL5();
        }
        private void dll6RandomButton_Click(object sender, EventArgs e)
        {
            RandomPanelDLL6();
        }
        private void dll4RandomButton_Click(object sender, EventArgs e)
        {
            RandomPanelDLL4();
        }

        private void dll7RandomButton_Click(object sender, EventArgs e)
        {
            RandomPanelDLL7();
        }
        private void dll8RandomButton_Click(object sender, EventArgs e)
        {
            RandomPanelDLL8();
        }
        #endregion
    }
}
