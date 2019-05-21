using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;


namespace Co453_Graphics
{
    public partial class SketchForm : Form
    {
        public const int MAX_BRUSHSIZE = 100;
        public const int MIN_BRUSHSIZE = 10;

        private int x;
        private int y;

        Bitmap image;

        private int brushSize = 20;
        private int brushMove = 5;
        private Brush brush = new SolidBrush(Color.Black);

        private Color backgroundColor = Color.White;
        
        /// <summary>
        /// The sketch form initializes here.
        /// </summary>
        public SketchForm()
        {
            Thread t = new Thread(new ThreadStart(StartSplash));
            t.Start(); //splash screen starts here
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort(); //splash screen ends here
        }

        /// <summary>
        /// This method will start the splash screen.
        /// </summary>
        public void StartSplash()
        {
            Application.Run(new SplashScreen());
        }
        
        private void sketchPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Graphics.FromImage(image);
            g.FillEllipse(brush, x, y, brushSize, brushSize);
        }

        /// <summary>
        /// The SketchForm loads here.
        /// </summary>
        private void SketchForm_Load(object sender, EventArgs e)
        {
            x = sketchPanel.Width / 2;
            y = sketchPanel.Height / 2;

            image = new Bitmap(sketchPanel.Width, sketchPanel.Height);
            sketchPanel.BackgroundImage = image;
        }

        /// <summary>
        /// This method will change the values of x and y depending on the key
        /// the user presses. I will also change the brushSize and change the
        /// panel's BackColor.
        /// </summary>
        private void SketchForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right)
            {
                x += brushMove;
                Refresh();
            }
            else if (e.KeyData == Keys.Left)
            {
                x -= brushMove;
                Refresh();
            }
            else if (e.KeyData == Keys.Down)
            {
                y += brushMove;
                Refresh();
            }
            else if (e.KeyData == Keys.Up)
            {
                y -= brushMove;
                Refresh();
            }
            else if (e.KeyData == Keys.C)
            {
                ClearSketch();
                Refresh();
            }
            else if (e.KeyData == Keys.Escape)
            {
                CloseForm();
            }
            else if (e.KeyData == Keys.B)
            {
                if(brushSize < MAX_BRUSHSIZE)
                {
                    brushSize += MIN_BRUSHSIZE;
                    brushMove = brushSize / 4;
                }
            }
            else if (e.KeyData == Keys.S)
            {
                if(brushSize > MIN_BRUSHSIZE)
                {
                    brushSize -= MIN_BRUSHSIZE;
                    brushMove = brushSize / 4;
                }
            }
            else if(e.KeyData == Keys.K) //I used K key instead of F1
            {
                Color color = PickForm.CreateColor();
                brush = new SolidBrush(color);
            }
            else if (e.KeyData == Keys.Q)
            {
                x -= brushMove;
                y -= brushMove;
                Refresh();
            }
            else if (e.KeyData == Keys.A)
            {
                x -= brushMove;
                y += brushMove;
                Refresh();
            }
            else if (e.KeyData == Keys.P)
            {
                x += brushMove;
                y -= brushMove;
                Refresh();
            }
            else if (e.KeyData == Keys.L)
            {
                x += brushMove;
                y += brushMove;
                Refresh();
            }
            else if (e.KeyData == Keys.F2)
            {
                Color color = PickForm.CreateColor();
                sketchPanel.BackColor = color;
                Refresh();
            }
        }

        /// <summary>
        /// This method will close the form.
        /// </summary>
        private void CloseForm()
        {
            if (MessageBox.Show("Are you sure?", "Close Form", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }
            
        }

        /// <summary>
        /// This method will Clear the sketchPanel
        /// </summary>
        private void ClearSketch()
        {
            if (MessageBox.Show("Are you sure?", "Clear Screen", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Graphics g = Graphics.FromImage(image);
                g.Clear(backgroundColor);
            }
        }

    }
}