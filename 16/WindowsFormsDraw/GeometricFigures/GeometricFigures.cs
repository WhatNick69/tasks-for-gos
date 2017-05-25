using System.Drawing;
using System.Windows.Forms;

namespace GeometricFigures
{
    public class GeometricFigures : UserControl
    {
        private bool _isDragged;
        Point _ptOffset;
        public int _typeObject;
        private int x = 100;
        private int y = 100;
        private Graphics graphics;
        Pen myPen = new Pen(Color.Black);


        public GeometricFigures(){}


        public GeometricFigures(Point point, int typeObject)
        {
            _typeObject = typeObject;
            Name = "Button";
            Location = point;
            if (typeObject == 3 | _typeObject == 7)
                Size = new Size(202, 101);
            else
                Size = new Size(101, 101);
            ForeColor = Color.Transparent;
            BackColor = Color.Transparent;
            TabIndex = 1;
            Text = "";
            MouseDown += button_MouseDown;
            MouseMove += button_MouseMove;
            MouseUp += button_MouseUp;
        }

        public void button_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                GeometricFigures test = (GeometricFigures)sender;
                _isDragged = true;
                Point ptStartPosition = test.PointToScreen(new Point(e.X, e.Y));

                _ptOffset = new Point
                {
                    X = test.Location.X - ptStartPosition.X,
                    Y = test.Location.Y - ptStartPosition.Y
                };
            }
            else
            {
                _isDragged = false;
            }
        }

        public void button_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isDragged) return;
            GeometricFigures test = (GeometricFigures)sender;
            Point newPoint = test.PointToScreen(new Point(e.X, e.Y));
            newPoint.Offset(_ptOffset);
            test.Location = newPoint;
        }

        public void button_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragged = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            graphics = e.Graphics;


            switch (_typeObject)
            {
                case 1:
                    graphics.DrawEllipse(myPen, 0, 0, x, y);
                    break;
                case 2:
                    graphics.DrawRectangle(myPen, 0, 0, x, y);
                    break;
                case 3:
                    graphics.DrawRectangle(myPen, 0, 0, x + y, y);
                    break;
                case 4:
                    graphics.DrawPolygon(myPen, new[] { new Point(y / 2, 0), new Point(y, y), new Point(0, y) });
                    break;
                case 5:
                    graphics.DrawLine(myPen, 0, 0, x, y);
                    break;
                case 6:
                    graphics.DrawArc(myPen, 0, 0, x, y, 220, 100);
                    break;
                case 7:
                    graphics.DrawEllipse(myPen, 0, 0, x + y, y);
                    break;
            }
        }

        public void DelSize()
        {
            x -= 10;
            y -= 10;
            Size = _typeObject == 3 | _typeObject == 7
                ? new Size(Size.Width - 20, Size.Height - 10)
                : new Size(Size.Width - 10, Size.Height - 10);
            Invalidate();
        }

        public void AddSize()
        {
            x += 10;
            y += 10;
            Size = _typeObject == 3 | _typeObject == 7
                ? new Size(Size.Width + 20, Size.Height + 10)
                : new Size(Size.Width + 10, Size.Height + 10);
            Invalidate();
        }
    }
}
