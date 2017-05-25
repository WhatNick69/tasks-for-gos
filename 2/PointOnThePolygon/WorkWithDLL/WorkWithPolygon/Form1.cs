using WorkWithDLL;
using System;
using System.Drawing;
using System.Windows.Forms;
using DLLPolygon;

namespace WorkWithDLL
{
    public partial class Form1 : Form
    {
        private SolidBrush greenBrush; // цвет многоугольника
        private SolidBrush blueBrush; // цвет точки
        private int indexX; // индекс элемента из листа X
        private int indexY; // индекс элемета из листа Y
        private int indexBool = -1; // индекс какого листа

        /// <summary>
        /// Предзагрузка
        /// </summary>
        private void Initialisation()
        {
            this.greenBrush = new SolidBrush(Color.Green);
            this.blueBrush = new SolidBrush(Color.Blue);
        }

        public Form1()
        {
            InitializeComponent();
            Initialisation();
        }

        /// <summary>
        /// Заполняем листы
        /// </summary>
        private void CreateLists(bool flag)
        {
            ClearDrawPanel();
            Random rnd = new Random();
            int n = int.Parse(nPoints.Text);

            if (flag)
            {
                xList.Items.Add(rnd.Next(5, drawPanel.Width));
                yList.Items.Add(rnd.Next(5, drawPanel.Height));
                n++;
            }
            else
            {
                if (xList.Items.Count > 0)
                {
                    xList.Items.RemoveAt(xList.Items.Count - 1);
                    yList.Items.RemoveAt(yList.Items.Count - 1);
                    n--;
                }
            }
            nPoints.Text = n.ToString();
        }

        /// <summary>
        /// Очистить панель для рисования
        /// </summary>
        private void ClearDrawPanel()
        {
            Graphics g = drawPanel.CreateGraphics();
            g.Clear(Color.White);
        }

        /// <summary>
        /// Удалить точку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minusButtonStart_click(object sender, EventArgs e)
        {
            CreateLists(false);
        }

        /// <summary>
        /// Рисовать!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawButton_Click(object sender, EventArgs e)
        {
            ClearDrawPanel();
            CheckPointCoordinates();
            Polygon polyN = 
                new Polygon(CreateArrayOfPoints(), drawPanel.Height);
            polyN.DrawOnPanel(drawPanel,greenBrush);
            new DLLPolygon.Point(Convert.ToInt32(pointX.Text.ToString())
                , Convert.ToInt32(pointY.Text.ToString()))
                .DrawPoint(drawPanel, blueBrush, drawPanel.Height);

            if (polyN.IsPointOnThePolgon(Convert.ToInt32(pointX.Text),
                Convert.ToInt32(pointY.Text)))
                dll2Result.Text = "На линии";
            else dll2Result.Text = "Не в линии";
        }

        /// <summary>
        /// Если коориданыт точки не введены - рандомно задаем её
        /// </summary>
        private void CheckPointCoordinates()
        {
           if (pointY.Text == "" || pointX.Text == "")
            {
                pointX.Text = new Random().Next(5, drawPanel.Width).ToString();
                pointY.Text = new Random().Next(5, drawPanel.Height).ToString();
            }
        }

        /// <summary>
        /// Создаем массив поинтов
        /// </summary>
        /// <returns></returns>
        private DLLPolygon.Point[] CreateArrayOfPoints()
        {
            DLLPolygon.Point[] pointArray 
                = new DLLPolygon.Point[xList.Items.Count];

            for (int i = 0;i<xList.Items.Count;i++)
            {
                pointArray[i] = new DLLPolygon.Point();
                pointArray[i].XPoint = Convert.ToInt32(xList.Items[i].ToString());
                pointArray[i].YPoint = Convert.ToInt32(yList.Items[i].ToString());

            }
            return pointArray;
        }

        /// <summary>
        /// Обновляем значения поинтов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshButtotn_Click(object sender, EventArgs e)
        {
            if (tempBox.Text != "")
            {
                if (indexBool == 0) xList.Items[indexX] = tempBox.Text;
                else if (indexBool == 1) yList.Items[indexY] = tempBox.Text;
                indexBool = -1;
            }
        }

        /// <summary>
        /// Получить значение по X из массива поинтов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeValueXBySelectedItem(object sender, MouseEventArgs e)
        {
            indexBool = 0;
            indexX = xList.SelectedIndex;
            tempBox.Text = xList.Items[indexX].ToString();
        }

        /// <summary>
        /// Получить значение по Y из массива поинтов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeValueYBySelectedItem(object sender, MouseEventArgs e)
        {
            indexBool = 1;
            indexY = yList.SelectedIndex;
            tempBox.Text = yList.Items[indexY].ToString();
        }

        /// <summary>
        /// Прибавить точку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plusButtonStart_Click(object sender, EventArgs e)
        {
            CreateLists(true);
        }
    }
}
