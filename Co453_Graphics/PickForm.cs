using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Co453_Graphics
{
    public partial class PickForm : Form
    {
        private static Random generator = new Random();
        private Pen myPen = new Pen(Brushes.Blue, 4);

        private int x, y;
        private char choice;

        private void PickForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            myPen = new Pen(CreateColor(), 4);

            g.Clear(Color.White);
            DrawCircles(g);
            switch (choice)
            {
                case 'l': case 'L': DrawLine(g); break;
                case 'r': case 'R': DrawRectangle(g); break;
                case 's': case 'S': DrawRectangle(g); break;
                case 'c': case 'C': DrawEllipse(g); break;
                case 'e': case 'E': DrawEllipse(g); break;

            }
        }

        private void DrawRectangle(Graphics g)
        {
            if (choice == 'r' || choice == 'R')
                g.DrawRectangle(myPen, GetRandomX(), GetRandomY(), 300, 200);
            else if (choice == 's' || choice == 'S')
                g.DrawRectangle(myPen, GetRandomX(), GetRandomY(), 200, 200);
        }

        private void DrawEllipse(Graphics g)
        {
            if (choice == 'c' || choice == 'C')
                g.DrawEllipse(myPen, GetRandomX(), GetRandomY(), 200, 200);
            else if (choice == 'e' || choice == 'E')
                g.DrawEllipse(myPen, GetRandomX(), GetRandomY(), 300, 200);
        }

        private void DrawLine(Graphics g)
        {
            g.DrawLine(myPen, GetRandomX(), GetRandomY(), GetRandomX(), GetRandomY());
        }

        private void PickForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            choice = (char)e.KeyChar;
            Refresh();
        }

        public PickForm()
        {
            InitializeComponent();
        }

        public static Color CreateColor()
        {
            Color color;

            int red = generator.Next(256);
            int green = generator.Next(256);
            int blue = generator.Next(256);

            color = Color.FromArgb(red, green, blue);
            return color;
        }

        private int GetRandomX()
        {
            return generator.Next(this.Width - 200);
        }

        private int GetRandomY()
        {
            return generator.Next(this.Height -200);
        }

        private void DrawCircles(Graphics g)
        {
            BackColor = Color.Black;

            int x = 20;
            int y = 20;
            int w = 200;
            int h = 200;

            int noCircles = 10;
            int d = w / (noCircles * 2);

            Pen myPen = new Pen(Color.Gray);


            for (int count = 0; count < noCircles; count++)
            {
                Brush myBrush = new SolidBrush(CreateColor());
                //g.Clear(BackColor);
                g.FillEllipse(myBrush, x, y, w, h);

                y += d;
                x += d;
                //two sides
                w -= 2 * d;
                h -= 2 * d;

                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}
