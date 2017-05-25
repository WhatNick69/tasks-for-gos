using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using ClassLibraryFond;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stopwatch time = new Stopwatch();
        private void button1_Click(object sender, EventArgs e)
        {
            Skol func = new Skol();
            string dir = @"Enter.txt";
            string dirExit = @"Exit.txt";
            string dannye = "";
            string result = "";
            StreamReader file = new StreamReader(dir, Encoding.GetEncoding(1251));
            dannye = file.ReadToEnd();
            time.Restart();
            result = func.BestProjects(dannye);
            time.Stop();
            using (StreamWriter text = File.CreateText(dirExit))
                text.WriteLine(result + "\r\n\r\n Затраченное время - " + time.Elapsed);
            MessageBox.Show("Готово!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Skol func = new Skol();
            string dir = @"Enter.txt";
            string dirExit = @"Exit2.txt";
            string dannye = "";
            string result = "";
            StreamReader file = new StreamReader(dir, Encoding.GetEncoding(1251));
            dannye = file.ReadToEnd();
            time.Restart();
            result = func.ProjectsBest(dannye);
            time.Stop();
            using (StreamWriter text = File.CreateText(dirExit))
                text.WriteLine(result + "\r\n\r\n Затраченное время - " + time.Elapsed);
            MessageBox.Show("Готово!");
        }
    }
}
