using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace UniversalSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private Stopwatch time;
        private int numData;
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            numData = (int) numericUpDown1.Value;
            double[] doubleArray1 = generateArray(numData);
            double[] doubleArray2 = new double[numData];
            string[] stringArray = generateArrayString(numData);
            string[] stringArray2 = new string[numData];


            Array.Copy(doubleArray1, doubleArray2, numData);
            Array.Copy(stringArray, stringArray2, numData);

            listBox1.Items.Add("----------------------DOUBLE ARRAY-----------------------");
            StartQuickSort(doubleArray1, doubleArray2);
            listBox1.Items.Add("---------------------");
            StartInsertionSort(doubleArray1, doubleArray2);
            listBox1.Items.Add("---------------------");
            listBox1.Items.Add("---------------------");

            listBox1.Items.Add("----------------------STRING ARRAY----------------------");
            StartQuickSort(stringArray, stringArray2);
            listBox1.Items.Add("---------------------");
            StartInsertionSort(stringArray, stringArray2);

        }

        private void StartQuickSort<T>(T[] doubleArray1, T[] doubleArray2) where T : IComparable<T>
        {
            time = Stopwatch.StartNew();
            UniversalSorter.QuicksortSequential(doubleArray1);
            listBox1.Items.Add("Быструю сортировку (последовательные) - " + numData + ": \t" + time.Elapsed.TotalSeconds);
            time.Reset();
            time.Start();
            UniversalSorter.QuicksortParallel(doubleArray2);
            listBox1.Items.Add("Быструю сортировку (параллельные) - " + numData + ": \t\t" + time.Elapsed.TotalSeconds);
        }

        private void StartInsertionSort<T>(T[] doubleArray1, T[] doubleArray2) where T : IComparable<T>
        {
            time = Stopwatch.StartNew();
            UniversalSorter.InsertionSortSequential(doubleArray1);
            listBox1.Items.Add("Сортировку вставкой (последовательные) - " + numData + ": \t" + time.Elapsed.TotalSeconds);
            time.Reset();
            time.Start();
            UniversalSorter.InsertionSortParallel(doubleArray2);
            listBox1.Items.Add("Сортировку вставкой (параллельные) - " + numData + ": \t\t" + time.Elapsed.TotalSeconds);
        }

        private double[] generateArray(int num)
        {
            double[] arr = new double[num];
            for (int i = 0; i < num; i++)
            {
                arr[i] = rnd.Next();
            }
            return arr;
        }

        private string[] generateArrayString(int num)
        {
            string[] arr = new string[num];
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < rnd.Next(2, 10); j++)
                {
                    arr[i] += ((char)rnd.Next(65, 90)).ToString();    
                }
            }
            return arr;
        }
    }
}
