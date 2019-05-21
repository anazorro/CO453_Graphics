using System;
using System.Windows.Forms;

namespace Co453_Graphics
{
    public partial class SplashScreen : Form
    {
        /// <summary>
        /// The SplashScreen Form initializes here.
        /// </summary>
        public SplashScreen()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// When the progress bar is complete the splash screen stops.
        /// </summary>
        public void splashScreenTimer_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            if (progressBar.Value == 100)
                splashScreenTimer.Stop();
        }
    }
}