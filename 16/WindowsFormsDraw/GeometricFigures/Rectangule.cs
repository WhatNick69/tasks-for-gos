using System.Drawing;

namespace GeometricFigures
{
    public class Rectangule : GeometricFigures
    {
        public Rectangule(Point point)
            : base()
        {
            _typeObject = 3;
            Name = "Button";
            Location = point;
            Size = new Size(202, 101);
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