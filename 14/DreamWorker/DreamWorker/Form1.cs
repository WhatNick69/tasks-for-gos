using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonProg_Click(object sender, EventArgs e)
        {
            Person pers = new Person();
            if (checkBoxCsharp.Checked)
                pers.Properties = pers.Properties | Dream_Properties.Знает_CSharp;
            if (checkBoxCpp.Checked)
                pers.Properties = pers.Properties | Dream_Properties.Знает_CPP;
            if (checkBoxAsp.Checked)
                pers.Properties = pers.Properties | Dream_Properties.Знает_ASPNET;
            if (checkBox1c.Checked)
                pers.Properties = pers.Properties | Dream_Properties.Знает_1С;
            if (checkBoxBuch.Checked)
                pers.Properties = pers.Properties | Dream_Properties.Знает_Бухучёт;
            if (checkBoxSmoke.Checked)
                pers.Properties = pers.Properties | Dream_Properties.Не_курит;
            string res = "";
            res = pers.priemCprog();
            richTextBox1.Text = res + "\r\n";
        }

        private void buttonBuh_Click(object sender, EventArgs e)
        {
            Person pers = new Person();
            if (checkBoxCsharp.Checked)
                pers.Properties = pers.Properties | Dream_Properties.Знает_CSharp;
            if (checkBoxCpp.Checked)
                pers.Properties = pers.Properties | Dream_Properties.Знает_CPP;
            if (checkBoxAsp.Checked)
                pers.Properties = pers.Properties | Dream_Properties.Знает_ASPNET;
            if (checkBox1c.Checked)
                pers.Properties = pers.Properties | Dream_Properties.Знает_1С;
            if (checkBoxBuch.Checked)
                pers.Properties = pers.Properties | Dream_Properties.Знает_Бухучёт;
            if (checkBoxSmoke.Checked)
                pers.Properties = pers.Properties | Dream_Properties.Не_курит;
            string res = "";
            res = pers.priem1c();
            richTextBox1.Text = res + "\r\n";
        }
    }
}
