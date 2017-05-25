using DLLSystemExpressionSolver;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SystemExpressionSolver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Решаем СЛАУ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            listSLAU.Items.Clear();
            int x = Convert.ToInt32(xTextBox.Text);  
            //int y = Convert.ToInt32(yTextBox.Text);  

            SolverMatrix solverMatrix 
                = new SolverMatrix(x,x);
            string[] result = SolverMatrix.LinearSolverSheel(timeSeqSLAU,timeParallelSLAU);
            foreach (string res in result)
                listSLAU.Items.Add(res);
        }

        /// <summary>
        /// Находим определитель (детерминант) матрицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void determinantButton_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(xTextBox.Text);
            //int y = Convert.ToInt32(yTextBox.Text);  

            determinant.Text = "Finding...";
            SolverMatrix solverMatrix
                = new SolverMatrix(x, x);
            new Thread(delegate ()
            {
                if (determinant.InvokeRequired)
                {
                    determinant.Invoke(new MethodInvoker(delegate
                    {
                        determinant.Text = Math.Round(Convert.
                            ToDouble(SolverMatrix.DeterminantGauss()), 3).ToString();
                    }));
                }
            }).Start();
        }

        /// <summary>
        /// Находим обратную матрицу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reverseMatrixButton_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(xTextBox.Text);
            //int y = Convert.ToInt32(yTextBox.Text);  
            reversing.Text = "Solving...";
            new Thread(delegate ()
            {
                SolverMatrix solverMatrix
                = new SolverMatrix(x, x);
                if (SolverMatrix.ReverseMatrixSheel())
                {
                    if (reversing.InvokeRequired)
                    {
                        reversing.Invoke(new MethodInvoker(delegate
                        {
                            reversing.Text = "Solved!";
                        }));
                    }
                }
            }).Start();
            
        }
    }
}
