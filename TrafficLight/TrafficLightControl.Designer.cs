namespace TrafficLight
{
    partial class TrafficLightControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBoxRed = new PictureBox();
            pictureBoxYellow = new PictureBox();
            pictureBoxGreen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxYellow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGreen).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBoxRed
            // 
            pictureBoxRed.BackgroundImage = Properties.Resources.red;
            pictureBoxRed.Location = new Point(10, 10);
            pictureBoxRed.Name = "pictureBoxRed";
            pictureBoxRed.Size = new Size(81, 100);
            pictureBoxRed.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRed.TabIndex = 0;
            pictureBoxRed.TabStop = false;
            // 
            // pictureBoxYellow
            // 
            pictureBoxYellow.BackgroundImage = Properties.Resources.yellow_;
            pictureBoxYellow.Location = new Point(10, 120);
            pictureBoxYellow.Name = "pictureBoxYellow";
            pictureBoxYellow.Size = new Size(81, 100);
            pictureBoxYellow.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxYellow.TabIndex = 1;
            pictureBoxYellow.TabStop = false;
            // 
            // pictureBoxGreen
            // 
            pictureBoxGreen.BackgroundImage = Properties.Resources.greenpng;
            pictureBoxGreen.Location = new Point(10, 230);
            pictureBoxGreen.Name = "pictureBoxGreen";
            pictureBoxGreen.Size = new Size(81, 100);
            pictureBoxGreen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGreen.TabIndex = 2;
            pictureBoxGreen.TabStop = false;
            // 
            // TrafficLightControl
            // 
            Controls.Add(pictureBoxRed);
            Controls.Add(pictureBoxYellow);
            Controls.Add(pictureBoxGreen);
            Name = "TrafficLightControl";
            Size = new Size(210, 340);
            ((System.ComponentModel.ISupportInitialize)pictureBoxRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxYellow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGreen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxRed;
        private System.Windows.Forms.PictureBox pictureBoxYellow;
        private System.Windows.Forms.PictureBox pictureBoxGreen;
    }
}
