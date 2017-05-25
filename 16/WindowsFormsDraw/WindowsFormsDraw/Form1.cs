using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace WindowsFormsDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int _typeObject;
        private GeometricFigures.GeometricFigures buttonNew;
        private bool selectButton;
        private GeometricFigures.GeometricFigures selectButtonObject;


        private void CreateFigure(MouseEventArgs e)
        {
            switch (_typeObject)
            {
                case 0:
                    return;
                case 1:
                    buttonNew = new GeometricFigures.Circle(new Point(e.X, e.Y));
                    break;
                case 2:
                    buttonNew = new GeometricFigures.Square(new Point(e.X, e.Y));
                    break;
                case 3:
                    buttonNew = new GeometricFigures.Rectangule(new Point(e.X, e.Y));
                    break;
                case 4:
                    buttonNew = new GeometricFigures.Triangle(new Point(e.X, e.Y));
                    break;
                case 5:
                    buttonNew = new GeometricFigures.Line(new Point(e.X, e.Y));
                    break;
                case 6:
                    buttonNew = new GeometricFigures.Arc(new Point(e.X, e.Y));
                    break;
                case 7:
                    buttonNew = new GeometricFigures.Elipse(new Point(e.X, e.Y));
                    break;
            }
            buttonNew.Click += button_Click;

            panel1.Controls.Add(buttonNew);
            buttonNew.BringToFront();
        }

        private void selectFigure(object sender)
        {
            if (selectButton)
            {
                GeometricFigures.GeometricFigures button = (GeometricFigures.GeometricFigures)sender;
                selectButtonObject.BackColor = Color.White;
                if (selectButtonObject == button)
                {
                    selectButtonObject = null;
                    selectButton = false;
                }
                else
                {
                    button.BackColor = Color.Aqua;
                    selectButtonObject = button;
                    selectButton = true;
                }
            }
            else
            {
                GeometricFigures.GeometricFigures button = (GeometricFigures.GeometricFigures)sender;
                button.BackColor = Color.Aqua;
                selectButtonObject = button;
                selectButton = true;
            }
        }


        private void button_Click(object sender, EventArgs e)
        {
            selectFigure(sender);
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            CreateFigure(e);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (selectButton) selectButtonObject.BringToFront();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (selectButton) selectButtonObject.SendToBack();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (selectButton) selectButtonObject.DelSize();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (selectButton) panel1.Controls.Remove(selectButtonObject);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (selectButton) selectButtonObject.AddSize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _typeObject = 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            _typeObject = 2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            _typeObject = 3;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            _typeObject = 4;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            _typeObject = 5;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            _typeObject = 6;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            _typeObject = 7;
        }
    }
}
