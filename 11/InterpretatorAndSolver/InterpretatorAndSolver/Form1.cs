using DLLInterAndSol;
using System;
using System.Windows.Forms;

namespace InterpretatorAndSolver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Находим решение функции 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void solverButton_Click(object sender, EventArgs e)
        {
            Solver solver = new Solver(formulaBox.Text, 
                (float)Convert.ToDouble(epsText.Text));
            resultList.Items.Add(resultList.Items.Count+1 + 
                ") x = " + solver.Calculate());
            DrawOnChart.PrintCharts(charBox);
        }

        private void formulaList_SelectedValueChanged(object sender, EventArgs e)
        {
            formulaBox.Text = formulaList.SelectedItem.ToString();
        }
    }
}
