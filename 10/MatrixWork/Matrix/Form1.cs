using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Operations op;
        int n;
        Stopwatch timer = new Stopwatch();
        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
            n = int.Parse(textBoxN.Text);
            op = new Operations(n);
            timer.Restart();
            op.Add();
            timer.Stop();
            richTextBox1.AppendText("Время сложения (посл) = " + timer.ElapsedMilliseconds + "мс.");
            if (checkBox1.Checked)
                WriteRes("Послед.");
            timer.Restart();
            op.AddPar();
            timer.Stop();
            richTextBox1.AppendText("\r\nВремя сложения (пар) = " + timer.ElapsedMilliseconds + "мс.");
            if (checkBox1.Checked)
            {
                WriteRes("Пар.");
                Write();
            }
        }

       

        private void buttonSub_Click(object sender, EventArgs e)
        {
            Clear();
            n = int.Parse(textBoxN.Text);
            op = new Operations(n);
            timer.Restart();
            op.Sub();
            timer.Stop();
            richTextBox1.AppendText("Время сложения (посл) = " + timer.ElapsedMilliseconds + "мс.");
            if (checkBox1.Checked)
                WriteRes("Послед.");
            timer.Restart();
            op.SubPar();
            timer.Stop();
            richTextBox1.AppendText("\r\nВремя сложения (пар) = " + timer.ElapsedMilliseconds + "мс.");
            if (checkBox1.Checked)
            {
                WriteRes("Пар.");
                Write();
            }
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            Clear();
            n = int.Parse(textBoxN.Text);
            op = new Operations(n);
            timer.Restart();
            op.Mult();
            timer.Stop();
            richTextBox1.AppendText("Время сложения (посл) = " + timer.ElapsedMilliseconds + "мс.");
            if (checkBox1.Checked)
                WriteRes("Послед.");
            timer.Restart();
            op.MultPar();
            timer.Stop();
            richTextBox1.AppendText("\r\nВремя сложения (пар) = " + timer.ElapsedMilliseconds + "мс.");
            if (checkBox1.Checked)
            {
                WriteRes("Пар.");
                Write();
            }
        }

        private void Clear()
        {
            richTextBox1.Clear();
        }

        private void Write()
        {
            richTextBox1.AppendText("\r\nМатрица А:\r\n");
            for (int i = 0; i < n; i++)
            {
                richTextBox1.AppendText("\r\n");
                for (int j = 0; j < n; j++)
                {
                    richTextBox1.AppendText(op.getA[i, j].ToString() + " ");
                }
            }
            richTextBox1.AppendText("\r\nМатрица B:\r\n");
            for (int i = 0; i < n; i++)
            {
                richTextBox1.AppendText("\r\n");
                for (int j = 0; j < n; j++)
                {
                    richTextBox1.AppendText(op.getB[i, j].ToString() + " ");
                }
            }
        }

        private void WriteRes(string r)
        {
            richTextBox1.AppendText("\r\n"+r+"\r\n");
            for (int i = 0; i < n; i++)
            {
                richTextBox1.AppendText("\r\n");
                for (int j = 0; j < n; j++)
                {
                    richTextBox1.AppendText(op.getC[i, j].ToString() + " ");
                }
            }
        }
    }
}
