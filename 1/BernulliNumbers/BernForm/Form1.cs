using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BernForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stopwatch time = new Stopwatch();
        private void buttonRec_Click(object sender, EventArgs e)
        {
            ClassBernulli func = new ClassBernulli();
            int n = 0;
            try
            {
                n = int.Parse(textBoxN.Text);
            }
            catch
            {
                MessageBox.Show("Введите нормальное число!");
                return;
            }
            if (n < 1)
            {
                MessageBox.Show("Введите число больше единицы!");
                return;
            }
            richTextBox1.AppendText("\r\nЧисла Бернулли:\r\n");
            time.Restart();
            for (int i = 0; i < n; i++)
            {
                if (i != 0)
                    richTextBox1.AppendText("n{" + i + "}= " + func.BernulliR(i) +"\r\n");
            }
            time.Stop();
            richTextBox1.AppendText("Затраченное время - " + time.Elapsed.ToString());
        }

        private void buttonRow_Click(object sender, EventArgs e)
        {
            ClassBernulli func = new ClassBernulli();
            int n = 0;
            try
            {
                n = int.Parse(textBoxN.Text);
            }
            catch
            {
                MessageBox.Show("Введите нормальное число!");
                return;
            }
            if (n < 1)
            {
                MessageBox.Show("Введите число больше единицы!");
                return;
            }
            richTextBox1.AppendText("\r\nЧисла Бернулли:\r\n");
            time.Restart();
            for (int i = 0; i < n; i++)
            {
                if (i != 0)
                    richTextBox1.AppendText("n{" + i + "}= " + func.BernulliRow(i) + "\r\n");
            }
            time.Stop();
            richTextBox1.AppendText("Затраченное время - " + time.Elapsed.ToString());
        }
    }
}
