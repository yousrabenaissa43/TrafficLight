namespace TrafficLight
{
    partial class TrafficLightControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxTrafficLight;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxTrafficLight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrafficLight)).BeginInit();
            this.SuspendLayout();

            // 
            // timer1
            // 
            this.timer1.Interval = 1000; // 1 second
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // 
            // pictureBoxTrafficLight
            // 
            this.pictureBoxTrafficLight.Location = new System.Drawing.Point(10, 10); // Position of the picture box
            this.pictureBoxTrafficLight.Name = "pictureBoxTrafficLight";
            this.pictureBoxTrafficLight.Size = new System.Drawing.Size(100, 200); // Adjust to fit the image size
            this.pictureBoxTrafficLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage; // Ensure the image scales to fit the picture box
            this.pictureBoxTrafficLight.TabIndex = 0;
            this.pictureBoxTrafficLight.TabStop = false;

            // 
            // TrafficLightControl
            // 
            this.Controls.Add(this.pictureBoxTrafficLight);
            this.Name = "TrafficLightControl";
            this.Size = new System.Drawing.Size(120, 220); // Size of the control area
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrafficLight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
