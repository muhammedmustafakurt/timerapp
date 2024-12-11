using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        // Countdown variables for hours, minutes, and seconds
        int countdownHours = 0;
        int countdownMinutes = 0;
        int countdownSeconds = 0;
        bool a = true;
        public Form1()
        {

            InitializeComponent();

            // Add values to the ComboBoxes for hours, minutes, and seconds
            for (int j = 0; j < 25; j++)
            {
                saat.Items.Add(j); // Hours
            }

            for (int i = 0; i < 61; i++)
            {
                saniye.Items.Add(i); // Minutes
                dakika.Items.Add(i); // Seconds
            }
            timer1.Interval = 1000;
            saat.SelectedIndex = 0;
            dakika.SelectedIndex = 0;
            saniye.SelectedIndex = 0;
            timer2.Start();
        }

        private void btnSetAlarm_Click_1(object sender, EventArgs e)
        {

            // Set the alarm time from ComboBoxes
            if (saat.SelectedItem != null || saniye.SelectedItem != null || dakika.SelectedItem != null)
            {
                countdownHours = int.Parse(saat.SelectedItem.ToString());
                countdownMinutes = int.Parse(dakika.SelectedItem.ToString());
                countdownSeconds = int.Parse(saniye.SelectedItem.ToString());

                // Display the countdown time
                label4.Text = $"Süre: {countdownHours:D2}:{countdownMinutes:D2}:{countdownSeconds:D2}";

                // Start the timer
                timer1.Start();

            }
            else
            {

            }
            a = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            // Countdown logic
            if (countdownSeconds == 0)
            {
                if (countdownMinutes == 0)
                {
                    if (countdownHours > 0)
                    {
                        countdownHours--;       // Decrease the hour
                        countdownMinutes = 59;  // Reset minutes to 59
                        countdownSeconds = 59;  // Reset seconds to 59
                    }
                    else
                    {
                        
                        if (a)
                        {
                            label5.Visible = !label5.Visible;
                        }
                        

                        return;
                    }
                }
                else
                {
                    countdownMinutes--;       // Decrease the minute
                    countdownSeconds = 59;    // Reset seconds to 59
                }
            }
            else
            {
                countdownSeconds--;           // Decrease the second
            }

            // Update the label to show the current countdown time
            label4.Text = $"Süre: {countdownHours:D2}:{countdownMinutes:D2}:{countdownSeconds:D2}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = false;
            label5.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongDateString();
            label7.Text = DateTime.Now.ToLongTimeString();
        }

        private void dateandtime_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
