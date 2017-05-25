using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThreadedInterface
{
    public delegate void Delegate_Void_String(string par); 
    public partial class MainForm : Form
    {
        public Delegate_Void_String myDelegate;
        Worker worker;
        public int lowLimit, highLimit;
        public MainForm()
        {
            InitializeComponent();
            myDelegate = AddList;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            buttonClear.Enabled = false;
            Thread myThread = new Thread(Pusk);
            myThread.Start();
        }

        void Pusk()
        {
            worker = new Worker(this);
            worker.Run();
        }

        void AddList(string item)
        {
            listBoxValues.Items.Add(item);
        }

        public void SetVisions()
        {
            listBoxValues.Items.Add(worker.Value);
            listBoxText.Items.Add(worker.Quality);
        }

        public void GetLimits()
        {
            lowLimit = int.Parse(textBoxDownLimit.Text);
            highLimit = int.Parse(textBoxUpLimit.Text);
            if (lowLimit >= highLimit)
            {
                MessageBox.Show("Введите нижний предел, который будет меньше высшего предела.");
                return;
            }
            worker.IsChanged = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            worker.Stop = true;
            //Thread.Sleep(25);
            
            buttonClear.Enabled = true; 
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxValues.Items.Clear();
            listBoxText.Items.Clear();
            worker.Number = 0;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            GetLimits();
        }
    }
}
