using LoginPage;
using System;
using System.Windows.Forms;
using System.Media;

namespace AmiggasRenting
{
    public partial class LoadingScreen : Form
    {
        private System.Windows.Forms.Timer loadingTimer; // Use System.Windows.Forms.Timer
        private SoundPlayer soundPlayer; // SoundPlayer object for playing the sound
        private int elapsedTime; // Variable to track elapsed time

        public LoadingScreen()
        {
            InitializeComponent();

            // Initialize the Timer
            loadingTimer = new System.Windows.Forms.Timer
            {
                Interval = 1000 // Timer ticks every 1000 milliseconds (1 second)
            };
            loadingTimer.Tick += LoadingTimer_Tick; // Attach the Tick event
            soundPlayer = new SoundPlayer("loadingScreen.wav");
            soundPlayer.Play();
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            // Increment elapsed time by 1 second
            elapsedTime += 1;

            // Check if 10 seconds have passed
            if (elapsedTime >= 10)
            {
                // Stop the timer when 10 seconds have passed
                soundPlayer.Stop(); // Stop the sound
                loadingTimer.Stop();

                // Open the LoginPageForm
                LoginPageForm loginPage = new LoginPageForm();
                loginPage.Show();

                // Close the current form
                this.Hide();
            }
        }

        private void LoadingScreen_Load_1(object sender, EventArgs e)
        {
            // Initialize elapsed time to 0
            elapsedTime = 0;

            // Start the Timer when the form loads
            loadingTimer.Start();
        }

        private void LoadingScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit(); // Exit the application when the form is closed
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Optional event handler for picture box clicks
        }
    }
}
