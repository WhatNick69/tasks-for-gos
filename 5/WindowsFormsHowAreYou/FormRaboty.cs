using System;
using System.Windows.Forms;
using Labs;

namespace WindowsFormsHowAreYou
{
    public partial class FormRaboty : Form
    {
        int m;
        public FormRaboty()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t = 0, n = 0;
            m = 21;
            t = 20;
            n = 100;
            int[,] tn = { { 0, 1, 2, 3, 4, 5, 6, 7, 8,9,10,11,12,13,14,15,16,17,18,19,t },
                        {0, 4,6,8,12,20,28,40,45,50,52,54,60,64,70,78,80,82,84,98, n } }; //на концах t и n, так как работа в итоге выполнена
            labelsT(tn);
            DrawGrafics graph = new DrawGrafics(this.CreateGraphics());
            graph.drawAll(tn,m);
            Calculate.m = m;
            textBoxRes.Text = Calculate.FindMaxInterval(tn);
        }

        /// <summary>
        /// подпись оси X(T - время)
        /// </summary>
        private void labelsT(int[,] array)
        {
            Label[] labels = new Label[m];
            for (int i = 0; i < m; i++)
            {
                labels[i] = new Label();
                this.Controls.Add(labels[i]);
                labels[i].Location = new System.Drawing.Point(47 + 600 * i / (m), 260);
                labels[i].Text = Convert.ToString(array[0,i]);
                labels[i].AutoSize = true;
                labels[i].BackColor = System.Drawing.Color.Transparent;
            }
        }
    }
}
