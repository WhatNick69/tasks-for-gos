using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PolinomForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string directory1 = @"C:\test\Massiv-Coefs.txt";
        string directory2 = @"C:\test\Massiv-Coefs2.txt";
        string directory3 = @"C:\test\Massiv-Korni.txt";
        input_trans inp = new input_trans();
        Polinom polinom;
        bool create = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (create != false)
            {
                double x;
                try
                { x = double.Parse(textBoxX.Text); }
                catch (Exception)
                {
                    MessageBox.Show("Необходимо ввести число!");
                    return;
                }
                double znach = polinom.PolinomZnach(x);
                textBoxResult.Text += "Значение полинома \"" + polinom.ToString() + "\" в точке "+ x + " равно " + znach + "\r\n\r\n";
            }
            else
            {
                MessageBox.Show("Полином еще не создан!");
            }
        }

        private void buttonCreatePolinom_Click(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader(directory1);
            string coefs = file.ReadToEnd();
            double[] coefficients = inp.StringSplit(coefs);
            bool korni = false;
            polinom = new Polinom(coefficients, korni);
            textBoxResult.Text += "Полином создан!" + "\r\n\r\n";
            create = true;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            polinom.Polinom_CLear();
            create = false;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (create != false)
            {
                StreamReader file = new StreamReader(directory2);
                string coefs = file.ReadToEnd();
                double[] coefficients = inp.StringSplit(coefs);
                bool korni = false;
                Polinom polinom2 = new Polinom(coefficients, korni);
                textBoxResult.Text += "Второй полином создан!" + "\r\n\r\n";
                textBoxResult.Text += "Сложение\r\nПолином №1: " + polinom.ToString() + "\r\nПолином №2: " + polinom2.ToString() + "\r\nРезультат:\r\n";
                polinom.PolinomSlozh(polinom2);
                textBoxResult.Text += polinom.ToString() + "\r\n\r\n";
            }
            else
            {
                MessageBox.Show("Первый полином еще не создан!");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (create != false)
            {
                StreamReader file = new StreamReader(directory2);
                string coefs = file.ReadToEnd();
                double[] coefficients = inp.StringSplit(coefs);
                bool korni = false;
                Polinom polinom2 = new Polinom(coefficients, korni);
                textBoxResult.Text += "Второй полином создан!" + "\r\n\r\n";
                textBoxResult.Text += "Вычитание\r\nПолином №1: " + polinom.ToString() + "\r\nПолином №2: " + polinom2.ToString() + "\r\nРезультат:\r\n";
                polinom.PolinomWych(polinom2);
                textBoxResult.Text += polinom.ToString() + "\r\n\r\n";
            }
            else
            {
                MessageBox.Show("Первый полином еще не создан!");
            }
        }
    }
}
