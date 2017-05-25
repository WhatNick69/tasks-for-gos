using System.Drawing;

namespace GeometricFigures
{
    public class Circle : GeometricFigures
    {
        public Circle(Point point) : base()
        {
            _typeObject = 1;
            Name = "Button";
            Location = point;
            Size = new Size(101, 101);
            ForeColor = Color.Transparent;
            BackColor = Color.Transparent;
            TabIndex = 1;
            Text = "";
            MouseDown += button_MouseDown;
            MouseMove += button_MouseMove;
            MouseUp += button_MouseUp;
        }
    }
}