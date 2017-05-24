using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Merge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch time = new Stopwatch();   
            Random rand = new Random();
            ClassMerge Element = new ClassMerge();
            int[] start = new int[3];
            int Length;
            try
            {
                Length = int.Parse(textBoxLength.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введите нормальное целое число!");
                return;
            }
            if (Length < 1)
            {
                MessageBox.Show("Введите нормальное целое число большее нуля!");
                return;
            }
            start[0] = 0; //Массив стартов - указатели на новые подгруппы элементов
            start[1] = 3;
            start[2] = 7;
            ClassMerge[] Array = new ClassMerge[Length];
            for (int i = 0; i < Length; i++) //заполнение массива данных
            {
                int T = rand.Next(1, 1000); //ключи не могут принимать значение 0
                int K=0;
                if (i >= 0 && i <3) //заполнение данных интервалов
                    K = i+100;
                if (i >= 3 && i < 7)
                    K = i + 1;
                if (i >= 7 && i < Length)
                    K = i * 12;
                Array[i] = Element.AddElement(T, K);
            }
            textBoxBefore.Text = Element.Display(Array); //вывод того, что было
            time.Restart();
            ClassMerge[] Temp = Element.BigMerge(Array, start);
            time.Stop();
            textBoxTime.Text = time.Elapsed.ToString();
            textBoxAfter.Text = Element.Display(Temp); //вывод того, что стало
        }
    }
}
