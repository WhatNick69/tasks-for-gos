using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thiefs;

namespace ThiefsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bank bank = new Bank();
        Stopwatch time = new Stopwatch();
        private void buttonPerebor_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            time.Restart();
            bank.Perebor(n); //рекурсивный алгоритм
            time.Stop();
            richTextBoxOutput.AppendText("\r\nВремя полного перебора для " + n + " символов у одного вора занимает " + time.ElapsedMilliseconds + " мс.");
        }

        private void buttonRec_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            time.Restart();
            bank.RecFind(n); //рекурсивный алгоритм
            time.Stop();
            richTextBoxOutput.AppendText("\r\nВремя рекурсивного метода для " + n + " символов у одного вора занимает " + time.ElapsedMilliseconds + " мс.");
        }
    }
}
