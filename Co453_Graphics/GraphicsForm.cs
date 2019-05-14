using System;
using System.Drawing;
using System.Windows.Forms;

namespace Co453_Graphics
{
    public partial class GraphicsForm : Form
    {
        private Random generator = new Random();

        public GraphicsForm()
        {
            InitializeComponent();
        }

        private void GraphicsForm_Paint(object sender, PaintEventArgs e)
        {
            //DrawString(e.Graphics);
            //DrawRectangles(e.Graphics);
            //DrawPolygons(e.Graphics);
            DrawShapes(e.Graphics);
        }

        private void DrawShapes(Graphics graphics)
        {
            graphics.Clear(Color.Black);
            Pen myPen = new Pen(Brushes.Yellow, 4);

            int x = generator.Next(20, this.Width / 2);
            int y = generator.Next(20, this.Height / 2);

            graphics.DrawLine(myPen, x, y, 200, 200);
        }

        /// <summary>
        /// This method draws 2 polygons: a triangle and a Hexagon.
        /// </summary>
        private void DrawPolygons(Graphics g)
        {
            g.Clear(Color.Blue);

            Brush brush = new SolidBrush(Color.Red);
            Pen myPen = new Pen(brush, 10);
            Font myFont = new Font("Arial", 16);

            Point[] points = new Point[]
            {
                new Point(200, 100),
                new Point(300, 200),
                new Point(100, 200)
            };

            g.DrawPolygon(myPen, points);
            g.FillPolygon(Brushes.Yellow, points);

            int x = 500; int y = 200;
            int h = 100; int l = 100;

            points = new Point[]
            {
                new Point(x, y),
                new Point(x + l, y - h),
                new Point(x + l + l, y - h),
                new Point(x + l + l + l, y),
                new Point(x + l + l, y + h),
                new Point(x + l, y + h)
            };

            g.FillPolygon(Brushes.Yellow, points);
            g.DrawString("Ana's Hexagon", myFont, Brushes.Black, x + l - 20, y + h + 20);
        }

        private void GraphicsForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Refresh();
        }

        /// <summary>
        /// This method draws a rectangle 6 times in 6 different positions.
        /// </summary>
        private void DrawRectangles(Graphics g)
        {
            BackColor = Color.Black;

            int x = 20;
            int y = 20;
            int w = 300;
            int h = 200;

            int noRectangles = 20;
            int d = w / (noRectangles * 2);

            Pen myPen = new Pen(Color.Gray, 4);

            for (int count = 0; count < noRectangles; count++)
            {
                //g.Clear(BackColor);
                g.DrawRectangle(myPen, x, y, w, h);

                y += d;
                x += d;
                //two sides
                w -= 2 * d;
                h -= 2 * d;

                System.Threading.Thread.Sleep(0);
            }

            myPen.Color = Color.Green;
            g.DrawRectangle(myPen, 500, 20, 300, 200);
            g.FillRectangle(Brushes.Red, 500, 20, 300, 200);
            g.FillEllipse(Brushes.Yellow, 500, 20, 300, 200);
        }

        /// <summary>
        /// This method draws a string 6 times in 6 different positions.
        /// </summary>
        private void DrawString(Graphics g)
        {
            BackColor = Color.Yellow;
            Font myFont = new Font("Century Gothic", 16);

            int x = 20;
            int y = 20;

            for (int count = 0; count < 6; count++)
            {
                g.Clear(BackColor);
                g.DrawString("Ana is texting a windows form!", myFont, Brushes.Red, x, y);
                y += 20;
                System.Threading.Thread.Sleep(5000);
            }
        }
    }
}
