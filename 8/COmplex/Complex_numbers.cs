using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COmplex
{
    public partial class Complex_numbers : Form
    {
        public Complex_numbers()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, x2, y1, y2;
            try
            {
                x1 = double.Parse(textBoxRe_1.Text);
                x2 = double.Parse(textBoxRe_2.Text);
                y1 = double.Parse(textBoxIm_1.Text);
                y2 = double.Parse(textBoxIm_2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Не все поля заполены!");
                return;
            }
            CNumber x = new CNumber(x1, y1);
            CNumber y = new CNumber(x2, y2);
            x = x.Plus(y);
            textBoxRes_Re.Text = x.re.ToString();
            textBoxRes_Im.Text = x.im.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x1, x2, y1, y2;
            try
            {
                x1 = double.Parse(textBoxRe_1.Text);
                x2 = double.Parse(textBoxRe_2.Text);
                y1 = double.Parse(textBoxIm_1.Text);
                y2 = double.Parse(textBoxIm_2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Не все поля заполены!");
                return;
            }
            CNumber x = new CNumber(x1, y1);
            CNumber y = new CNumber(x2, y2);
            x = x.Minus(y);
            textBoxRes_Re.Text = x.re.ToString();
            textBoxRes_Im.Text = x.im.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x1, x2, y1, y2;
            try
            {
                x1 = double.Parse(textBoxRe_1.Text);
                x2 = double.Parse(textBoxRe_2.Text);
                y1 = double.Parse(textBoxIm_1.Text);
                y2 = double.Parse(textBoxIm_2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Не все поля заполены!");
                return;
            }
            CNumber x = new CNumber(x1, y1);
            CNumber y = new CNumber(x2, y2);
            x = x.Umn(y);
            textBoxRes_Re.Text = x.re.ToString();
            textBoxRes_Im.Text = x.im.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x1, x2, y1, y2;
            try
            {
                x1 = double.Parse(textBoxRe_1.Text);
                x2 = double.Parse(textBoxRe_2.Text);
                y1 = double.Parse(textBoxIm_1.Text);
                y2 = double.Parse(textBoxIm_2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Не все поля заполены!");
                return;
            }
            CNumber x = new CNumber(x1, y1);
            CNumber y = new CNumber(x2, y2);
            x = x.Del(y);
            textBoxRes_Re.Text = x.re.ToString();
            textBoxRes_Im.Text = x.im.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x1, y1;
            byte n;
            try
            {
                x1 = double.Parse(textBoxRe_1.Text);
                y1 = double.Parse(textBoxIm_1.Text);
                n = byte.Parse(textBoxStep.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Не все поля заполены!");
                return;
            }
            CNumber x = new CNumber(x1, y1);
            x = x ^ n;
            textBoxRes_Re.Text = x.re.ToString();
            textBoxRes_Im.Text = x.im.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxStep.Text = "";
            textBoxRes_Re.Text = "";
            textBoxRes_Im.Text = "";
            textBoxRe_2.Text = "";
            textBoxRe_1.Text = "";
            textBoxIm_2.Text = "";
            textBoxIm_1.Text = "";
        }

        
        Color[] pen_color = new Color[7];
        Graphics dr;
        private void button7_Click(object sender, EventArgs e)
        {
            dr = panel1.CreateGraphics();
            pen_color[0] = Color.Black;
            pen_color[1] = Color.Red;
            pen_color[2] = Color.Green;
            pen_color[3] = Color.Yellow;
            pen_color[4] = Color.Orange;
            pen_color[5] = Color.Blue;
            pen_color[6] = Color.Violet;
            Draw();
        }

        /// <summary>
        /// Рисование
        /// </summary>
        private void Draw()
        {
            int Count = 0;
            try
            {
                Count = int.Parse(textBox3.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Число итераций неверное!");
                return;
            }
            Mandelbrot mand = new Mandelbrot(Count);
            int radius = panel1.Height / 2;
            for (int i = 1; i < panel1.Height; i++)
            {
                for (int j = 1; j < panel1.Width; j++)
                {
                    double xCoord = (i - panel1.Height / 2) / (double)(panel1.Height) * 4;
                    double yCoord = (j - panel1.Height / 2) / (double)(panel1.Height) * 4;
                    CNumber complex = new CNumber(xCoord, yCoord);
                    byte speed = mand.Speed(complex);
                    DrawPoint(i, panel1.Height - j, speed); //или j  -i?
                }
            }
        }
        private void DrawPoint(int x, int y, byte speed)
        {
            Color color = pen_color[speed];
            dr.FillRectangle(new SolidBrush(color), x, y, 1, 1);
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dr.Clear(Color.White);
        }
    }
}
