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
                    pictureBoxTrafficLight.Image = Properties.Resources.red; // Set Red image
                    break;
                case 1: // Yellow
                    pictureBoxTrafficLight.Image = Properties.Resources.yellow; // Set Yellow image
                    break;
                case 2: // Green
                    pictureBoxTrafficLight.Image = Properties.Resources.green; // Set Green image
                    break;
            }
        }
    }
}
