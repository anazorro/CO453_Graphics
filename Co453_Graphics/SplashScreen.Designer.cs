namespace Co453_Graphics
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.splashScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // displayTextBox
            // 
            this.displayTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.displayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayTextBox.Location = new System.Drawing.Point(0, 0);
            this.displayTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(680, 392);
            this.displayTextBox.TabIndex = 1;
            this.displayTextBox.Text = resources.GetString("displayTextBox.Text");
            // 
            // splashScreenTimer
            // 
            this.splashScreenTimer.Enabled = true;
            this.splashScreenTimer.Interval = 1000;
            this.splashScreenTimer.Tick += new System.EventHandler(this.splashScreenTimer_Tick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(521, 348);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(112, 23);
            this.progressBar.TabIndex = 2;
            this.progressBar.Visible = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 392);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.displayTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.splashScreenTimer_Tick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayTextBox;
        public System.Windows.Forms.Timer splashScreenTimer;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}