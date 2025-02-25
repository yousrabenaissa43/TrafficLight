namespace TrafficLight
{
    public partial class TrafficLightControl : UserControl
    {
        private int currentState = 0; // 0 = Red, 1 = Yellow, 2 = Green

        public TrafficLightControl()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update the traffic light color at regular intervals
            currentState = (currentState + 1) % 3;
            UpdateTrafficLight();
        }

        private void UpdateTrafficLight()
        {
            switch (currentState)
            {
                case 0: // Red
                    pictureBoxRed.Visible = true;
                    pictureBoxYellow.Visible = false;
                    pictureBoxGreen.Visible = false;
                    break;
                case 1: // Yellow
                    pictureBoxRed.Visible = false;
                    pictureBoxYellow.Visible = true;
                    pictureBoxGreen.Visible = false;
                    break;
                case 2: // Green
                    pictureBoxRed.Visible = false;
                    pictureBoxYellow.Visible = false;
                    pictureBoxGreen.Visible = true;
                    break;
            }
        }
    }

}
