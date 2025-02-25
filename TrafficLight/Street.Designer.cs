namespace TrafficLight
{
    partial class Street
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
            pictureBox2 = new PictureBox();
            trafficLight1 = new TrafficLightControl();
            trafficLight2 = new TrafficLightControl();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(38, 172);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 123);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // trafficLight1
            // 
            trafficLight1.Location = new Point(12, 126);
            trafficLight1.Name = "trafficLight1";
            trafficLight1.Size = new Size(112, 214);
            trafficLight1.TabIndex = 4;
            // 
            // trafficLight2
            // 
            trafficLight2.Location = new Point(557, 126);
            trafficLight2.Name = "trafficLight2";
            trafficLight2.Size = new Size(112, 214);
            trafficLight2.TabIndex = 5;
            // 
            // Street
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.street;
            ClientSize = new Size(693, 525);
            Controls.Add(trafficLight1);
            Controls.Add(trafficLight2);
            Controls.Add(pictureBox2);
            Name = "Street";
            Text = "Street";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private TrafficLightControl trafficLight1;
        private TrafficLightControl trafficLight2;
    }
}
